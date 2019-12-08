using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace GameDataTool
{
    public partial class frmTool : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        

        public static readonly int BEFORE = 0;
        public static readonly int AFTER  = 1;
        public static readonly string domainBase = "https://www.giantbomb.com";
        public static readonly string domainSearch = "/search/?i=game&q=";
        ToolTip ttPath;
        public static readonly string configFile = System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Documents\game_tool_config.ini";

        public frmTool()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;//SecurityProtocolType.Tls;

        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listResults.ClearSelected();
            listResults.DataSource = null;
            listResults.Items.Clear();
            listResults.Update();
            lblStatus.Text = "Finding games...";
            lblStatus.Update();
            System.Threading.Thread.Sleep(1);

            imgPreview.ImageLocation = "";
            lblAux.Text = "";

            btnSearch.Enabled = false;
            ArrayList dataFields = new ArrayList();

            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

                string responseString = client.DownloadString("https://www.giantbomb.com/search/?i=game&q=" + txtSearch.Text);
                responseString = responseString.Split("editorial river search-results")[AFTER];
                responseString = responseString.Split("</ul")[BEFORE];

                responseString = responseString.Replace(System.Environment.NewLine, string.Empty);
                responseString = responseString.Replace("\t", " ");

                responseString = Regex.Replace(responseString, @"\s+", " ");

                string[] entries = responseString.Split("<li class=\"media\"i>");
                entries[0] = "skipme";

                foreach (string entry in entries)
                {
                    if (entry.Equals("skipme")) continue;
                    MyListDataField myField = new MyListDataField();
                    myField.URL = domainBase + entry.Split("a href=\"")[AFTER].Split("\">")[BEFORE];
                    myField.PreviewCoverURL = entry.Split("img src=\"")[AFTER].Split("\"")[BEFORE];
                    myField.Label = entry.Split("class=\"title\">")[AFTER].Split("</h3>")[BEFORE];
                    myField.Label = myField.Label.fixHtmlSymbols();
                    if (myField.Label[0] == ' ') myField.Label = myField.Label.Substring(1);
                    if (myField.Label[myField.Label.Length-1] == ' ') myField.Label = myField.Label.Substring(0, myField.Label.Length-1);
                    myField.Aux = entry.Split("<span class=\"type\">")[AFTER].Split("</span>")[BEFORE];
                    dataFields.Add(myField);
                }

                if (entries.Length < 2) lblStatus.Text = "No results.";
                else lblStatus.Text = "";
            }

            listResults.DisplayMember = "Label";
            listResults.DataSource = dataFields;
            listResults.ClearSelected();
        }

        private void listResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listResults_Click(object sender, EventArgs e)
        {
            if (listResults.Items.Count < 1) return;
            string url = (listResults.SelectedItem as MyListDataField).URL;
            string label = (listResults.SelectedItem as MyListDataField).Label;
            string aux = (listResults.SelectedItem as MyListDataField).Aux;
            string preview = (listResults.SelectedItem as MyListDataField).PreviewCoverURL;

            imgPreview.ImageLocation = preview;
            lblAux.Text = aux;

            btnUpdate.Text = "Update files";
            btnUpdate.Enabled = true;
        }

        private void listResults_KeyDown(object sender, KeyEventArgs e)
        {
            listResults_Click(sender, e);
        }

        private void listResults_KeyUp(object sender, KeyEventArgs e)
        {
            listResults_Click(sender, e);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Updating files...";
            lblStatus.Update();
            btnUpdate.Text = "Updating...";
            btnUpdate.Enabled = false;
            btnUpdate.Update();
            System.Threading.Thread.Sleep(1);

            GameInfo game = getGameDetails((listResults.SelectedItem as MyListDataField).URL);

            File.WriteAllText(txtPath.Text + "/name.txt", game.Name);
            File.WriteAllText(txtPath.Text + "/release_date.txt", game.ReleaseDate);
            File.WriteAllText(txtPath.Text + "/developer.txt", game.Developer);
            File.WriteAllText(txtPath.Text + "/publisher.txt", game.Publisher);
            File.WriteAllText(txtPath.Text + "/overview.txt", game.Overview);
            using (var client = new WebClient())
            {
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(ReleaseUpdateButton);
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                client.DownloadFileAsync(new Uri(game.CoverURL), txtPath.Text + "/cover.png");
            }
        }

        private void ReleaseUpdateButton(object sender, AsyncCompletedEventArgs e)
        {
            btnUpdate.Text = "Update files";
            btnUpdate.Enabled = true;
            btnUpdate.Update();

            lblStatus.Text = "Done. All files are were updated.";
            lblStatus.Update();
        }

        public static GameInfo getGameDetails(string url)
        {
            url = url.Replace(" ", "+");

            String page = "";
            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                page = client.DownloadString(url);
            }

            GameInfo game = new GameInfo();

            game.CoverURL = page.Split("<div class=\"wiki-boxart")[AFTER].Split("<img src=\"")[AFTER].Split("\"/>")[BEFORE];

            String details = "";
            details = page.Split("<div class=\"wiki-details\">")[AFTER];
            game.ReleaseDate = details.Split("<th>First release date</th>")[AFTER].Split("data-field=\"release_date\"")[AFTER].Split("\">")[AFTER].Split("</div>")[BEFORE];
            game.ReleaseDate = game.ReleaseDate.Replace("  ", "");
            game.ReleaseDate = game.ReleaseDate.Replace("\n", "");
            game.ReleaseDate = game.ReleaseDate.fixHtmlSymbols();

            game.Name = details.Split("<th>Name</th>")[AFTER].Split("<span><a")[AFTER].Split("\">")[AFTER].Split("</a>")[BEFORE];
            game.Name = game.Name.fixHtmlSymbols();

            game.Developer = details.Split("<th>Developer</th>")[AFTER].Split("<a href")[AFTER].Split("\">")[AFTER].Split("</a>")[BEFORE];
            game.Developer = game.Developer.fixHtmlSymbols();

            game.Publisher = details.Split("<th>Publisher</th>")[AFTER].Split("<a href")[AFTER].Split("\">")[AFTER].Split("</a>")[BEFORE];
            game.Publisher = game.Publisher.fixHtmlSymbols();

            game.Overview = page.Split("<meta name=\"description\" content=\"")[AFTER].Split("\">")[BEFORE];
            game.Overview = game.Overview.fixHtmlSymbols();

            return game;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Enter your game here")) txtSearch.Text = "";
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtPath.Text;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
                ttPath.RemoveAll();
                ttPath.SetToolTip(txtPath, txtPath.Text);
                btnUpdate.Enabled = true;
                WriteConfig();
            }
        }

        private void WriteConfig()
        {
            File.WriteAllText(configFile, txtPath.Text);
        }

        private void frmTool_Load(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;

            if (true)
            {
                txtPath.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Documents";
            }

            if (File.Exists(configFile))
            {
                txtPath.Text = File.ReadAllText(configFile);
            }
            else
            {
                WriteConfig();
            }

            ttPath = new ToolTip();
            ttPath.AutoPopDelay = 0;
            ttPath.InitialDelay = 500;
            ttPath.ReshowDelay = 500;
            ttPath.ShowAlways = true;
            ttPath.SetToolTip(txtPath, txtPath.Text);

            var twitterUrl = new LinkLabel.Link();
            twitterUrl.LinkData = "https://twitter.com/XO_Khaos";
            linkTwitter.Links.Add(twitterUrl);

            var twitchUrl = new LinkLabel.Link();
            twitchUrl.LinkData = "https://www.twitch.tv/xo_khaos";
            linkTwitch.Links.Add(twitchUrl);

            var howToUrl = new LinkLabel.Link();
            howToUrl.LinkData = "https://github.com/XOCODE-OP/Quick_Lazy_Game_Details";
            linkHowTo.Links.Add(howToUrl);
        }

        private void linkTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkHowTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void frmTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblStatus_MouseDown(object sender, MouseEventArgs e)
        {
            frmTool_MouseDown(sender, e);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            frmTool_MouseDown(sender, e);
        }

        private void lblAux_MouseDown(object sender, MouseEventArgs e)
        {
            frmTool_MouseDown(sender, e);
        }

        private void imgPreview_MouseDown(object sender, MouseEventArgs e)
        {
            frmTool_MouseDown(sender, e);
        }

        private void btnMenuMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTitleX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class MyListDataField
    {
        public string URL { get; set; }
        public string Label { get; set; }
        public string PreviewCoverURL { get; set; }
        public string Aux { get; set; }
    }

    public class GameInfo
    {
        public string Name;
        public string CoverURL;
        public string ReleaseDate;
        public string Developer;
        public string Publisher;
        public string Overview;
    }

    public static class Extensions
    {
        public static string[] Split(this string value, string splitter)
        {
            return value.Split(new[] { splitter }, StringSplitOptions.None);
        }

        public static string removeTagFromString(this string full, string tag)
        {
            return full.Replace("<" + tag + ">", "").Replace("</" + tag + ">", "");
        }

        public static string fixHtmlSymbols(this string value)
        {
            return value.removeTagFromString("span").Replace("&#039;", "'").Replace("&quot;", "\"").Replace("&amp;", "&")
                .Replace("&ouml;", "oe").Replace("&Ouml;", "OE").Replace("ö", "oe").Replace("Ö", "OE")
                .Replace("&auml;", "ae").Replace("&Auml;", "AE").Replace("ä", "ae").Replace("Ä", "AE")
                .Replace("&uuml;", "ue").Replace("&Uuml;", "UE").Replace("ü", "ue").Replace("Ü", "UE")
                .Replace("&szlig;", "ss").Replace("ß", "ss")
                ;
        }
    }
}
