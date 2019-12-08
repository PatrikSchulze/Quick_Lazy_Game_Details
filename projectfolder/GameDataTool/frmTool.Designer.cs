namespace GameDataTool
{
    partial class frmTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTool));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.lblAux = new System.Windows.Forms.Label();
            this.linkTwitch = new System.Windows.Forms.LinkLabel();
            this.linkTwitter = new System.Windows.Forms.LinkLabel();
            this.linkHowTo = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTitleX = new System.Windows.Forms.Button();
            this.btnMenuMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnSearch.Location = new System.Drawing.Point(416, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtSearch.Location = new System.Drawing.Point(12, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(398, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Enter your game here";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.listResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResults.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.listResults.FormattingEnabled = true;
            this.listResults.HorizontalScrollbar = true;
            this.listResults.ItemHeight = 18;
            this.listResults.Location = new System.Drawing.Point(12, 101);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(286, 470);
            this.listResults.TabIndex = 4;
            this.listResults.Click += new System.EventHandler(this.listResults_Click);
            this.listResults.SelectedIndexChanged += new System.EventHandler(this.listResults_SelectedIndexChanged);
            this.listResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listResults_KeyDown);
            this.listResults.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listResults_KeyUp);
            // 
            // imgPreview
            // 
            this.imgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPreview.ErrorImage = null;
            this.imgPreview.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgPreview.InitialImage")));
            this.imgPreview.Location = new System.Drawing.Point(314, 101);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(200, 200);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 5;
            this.imgPreview.TabStop = false;
            this.imgPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgPreview_MouseDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnUpdate.Location = new System.Drawing.Point(314, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update files";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(335, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "File save location:";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtPath.Location = new System.Drawing.Point(314, 490);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(153, 23);
            this.txtPath.TabIndex = 9;
            this.txtPath.Text = "Enter your game here";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnChoosePath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChoosePath.FlatAppearance.BorderSize = 0;
            this.btnChoosePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnChoosePath.Location = new System.Drawing.Point(473, 490);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(41, 23);
            this.btnChoosePath.TabIndex = 10;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = false;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // lblAux
            // 
            this.lblAux.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblAux.Location = new System.Drawing.Point(314, 304);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(200, 127);
            this.lblAux.TabIndex = 11;
            this.lblAux.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAux.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAux_MouseDown);
            // 
            // linkTwitch
            // 
            this.linkTwitch.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkTwitch.AutoSize = true;
            this.linkTwitch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.linkTwitch.Location = new System.Drawing.Point(14, 594);
            this.linkTwitch.Name = "linkTwitch";
            this.linkTwitch.Size = new System.Drawing.Size(247, 13);
            this.linkTwitch.TabIndex = 12;
            this.linkTwitch.TabStop = true;
            this.linkTwitch.Text = "This tool is made by XO__Khaos on Twitch";
            this.linkTwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTwitch_LinkClicked);
            // 
            // linkTwitter
            // 
            this.linkTwitter.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkTwitter.AutoSize = true;
            this.linkTwitter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.linkTwitter.Location = new System.Drawing.Point(457, 594);
            this.linkTwitter.Name = "linkTwitter";
            this.linkTwitter.Size = new System.Drawing.Size(61, 13);
            this.linkTwitter.TabIndex = 13;
            this.linkTwitter.TabStop = true;
            this.linkTwitter.Text = "@XO_Khaos";
            this.linkTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTwitter_LinkClicked);
            // 
            // linkHowTo
            // 
            this.linkHowTo.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkHowTo.AutoSize = true;
            this.linkHowTo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.linkHowTo.Location = new System.Drawing.Point(330, 594);
            this.linkHowTo.Name = "linkHowTo";
            this.linkHowTo.Size = new System.Drawing.Size(67, 13);
            this.linkHowTo.TabIndex = 14;
            this.linkHowTo.TabStop = true;
            this.linkHowTo.Text = "How to use";
            this.linkHowTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHowTo_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblStatus.Location = new System.Drawing.Point(14, 74);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(500, 18);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStatus_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 23);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Quick Lazy Game Details vDec8-2019";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnTitleX
            // 
            this.btnTitleX.BackColor = System.Drawing.Color.Black;
            this.btnTitleX.FlatAppearance.BorderSize = 0;
            this.btnTitleX.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnTitleX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTitleX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleX.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitleX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnTitleX.Location = new System.Drawing.Point(499, 0);
            this.btnTitleX.Name = "btnTitleX";
            this.btnTitleX.Size = new System.Drawing.Size(28, 23);
            this.btnTitleX.TabIndex = 17;
            this.btnTitleX.Text = "X";
            this.btnTitleX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTitleX.UseVisualStyleBackColor = false;
            this.btnTitleX.Click += new System.EventHandler(this.btnTitleX_Click);
            // 
            // btnMenuMin
            // 
            this.btnMenuMin.BackColor = System.Drawing.Color.Black;
            this.btnMenuMin.FlatAppearance.BorderSize = 0;
            this.btnMenuMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenuMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnMenuMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnMenuMin.Location = new System.Drawing.Point(471, 0);
            this.btnMenuMin.Name = "btnMenuMin";
            this.btnMenuMin.Size = new System.Drawing.Size(28, 23);
            this.btnMenuMin.TabIndex = 18;
            this.btnMenuMin.Text = "_";
            this.btnMenuMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuMin.UseVisualStyleBackColor = false;
            this.btnMenuMin.Click += new System.EventHandler(this.btnMenuMin_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(525, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 620);
            this.label2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 620);
            this.label3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(0, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(527, 2);
            this.label4.TabIndex = 22;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(527, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenuMin);
            this.Controls.Add(this.btnTitleX);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.linkHowTo);
            this.Controls.Add(this.linkTwitter);
            this.Controls.Add(this.linkTwitch);
            this.Controls.Add(this.lblAux);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTool";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTool_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTool_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblAux;
        private System.Windows.Forms.LinkLabel linkTwitch;
        private System.Windows.Forms.LinkLabel linkTwitter;
        private System.Windows.Forms.LinkLabel linkHowTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTitleX;
        private System.Windows.Forms.Button btnMenuMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

