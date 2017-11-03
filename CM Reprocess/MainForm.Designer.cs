namespace CM_Reprocess
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtBoxSearchKey = new System.Windows.Forms.TextBox();
            this.btnReprocess = new System.Windows.Forms.Button();
            this.btnAmadeus = new System.Windows.Forms.Button();
            this.btnAbacus = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnDirectAmadeus = new System.Windows.Forms.Button();
            this.btnCebuPac = new System.Windows.Forms.Button();
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.listBoxAirFile = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearchKey
            // 
            this.txtBoxSearchKey.BackColor = System.Drawing.Color.LightBlue;
            this.txtBoxSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSearchKey.Location = new System.Drawing.Point(14, 52);
            this.txtBoxSearchKey.Name = "txtBoxSearchKey";
            this.txtBoxSearchKey.Size = new System.Drawing.Size(144, 26);
            this.txtBoxSearchKey.TabIndex = 0;
            this.txtBoxSearchKey.TextChanged += new System.EventHandler(this.txtBoxSearchKey_TextChanged);
            this.txtBoxSearchKey.Enter += new System.EventHandler(this.txtBoxSearchKey_Enter);
            // 
            // btnReprocess
            // 
            this.btnReprocess.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReprocess.FlatAppearance.BorderSize = 0;
            this.btnReprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprocess.Location = new System.Drawing.Point(164, 52);
            this.btnReprocess.Name = "btnReprocess";
            this.btnReprocess.Size = new System.Drawing.Size(97, 26);
            this.btnReprocess.TabIndex = 1;
            this.btnReprocess.Text = "Reprocess";
            this.btnReprocess.UseVisualStyleBackColor = false;
            this.btnReprocess.Click += new System.EventHandler(this.btnReprocess_Click);
            // 
            // btnAmadeus
            // 
            this.btnAmadeus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.btnAmadeus.FlatAppearance.BorderSize = 0;
            this.btnAmadeus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmadeus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmadeus.ForeColor = System.Drawing.Color.White;
            this.btnAmadeus.Location = new System.Drawing.Point(457, 95);
            this.btnAmadeus.Name = "btnAmadeus";
            this.btnAmadeus.Size = new System.Drawing.Size(97, 26);
            this.btnAmadeus.TabIndex = 3;
            this.btnAmadeus.Text = "Amadeus";
            this.btnAmadeus.UseVisualStyleBackColor = false;
            this.btnAmadeus.Click += new System.EventHandler(this.btnAmadeus_Click);
            // 
            // btnAbacus
            // 
            this.btnAbacus.BackColor = System.Drawing.Color.Red;
            this.btnAbacus.FlatAppearance.BorderSize = 0;
            this.btnAbacus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbacus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbacus.ForeColor = System.Drawing.Color.White;
            this.btnAbacus.Location = new System.Drawing.Point(457, 127);
            this.btnAbacus.Name = "btnAbacus";
            this.btnAbacus.Size = new System.Drawing.Size(97, 26);
            this.btnAbacus.TabIndex = 4;
            this.btnAbacus.Text = "Sabre";
            this.btnAbacus.UseVisualStyleBackColor = false;
            this.btnAbacus.Click += new System.EventHandler(this.btnAbacus_Click);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.Silver;
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.Black;
            this.btnOption.Location = new System.Drawing.Point(457, 471);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(97, 26);
            this.btnOption.TabIndex = 8;
            this.btnOption.Text = "Setup";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Record Locator | Ticket No";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(17, 504);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(102, 13);
            this.lblErrorMessage.TabIndex = 10;
            this.lblErrorMessage.Text = "No record found . . .";
            this.lblErrorMessage.Visible = false;
            // 
            // btnDirectAmadeus
            // 
            this.btnDirectAmadeus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.btnDirectAmadeus.FlatAppearance.BorderSize = 0;
            this.btnDirectAmadeus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectAmadeus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectAmadeus.ForeColor = System.Drawing.Color.White;
            this.btnDirectAmadeus.Location = new System.Drawing.Point(457, 439);
            this.btnDirectAmadeus.Name = "btnDirectAmadeus";
            this.btnDirectAmadeus.Size = new System.Drawing.Size(97, 26);
            this.btnDirectAmadeus.TabIndex = 11;
            this.btnDirectAmadeus.Text = "1A - Direct";
            this.btnDirectAmadeus.UseVisualStyleBackColor = false;
            this.btnDirectAmadeus.Click += new System.EventHandler(this.btnDirectAmadeus_Click);
            // 
            // btnCebuPac
            // 
            this.btnCebuPac.BackColor = System.Drawing.Color.Yellow;
            this.btnCebuPac.FlatAppearance.BorderSize = 0;
            this.btnCebuPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCebuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCebuPac.ForeColor = System.Drawing.Color.Black;
            this.btnCebuPac.Location = new System.Drawing.Point(457, 159);
            this.btnCebuPac.Name = "btnCebuPac";
            this.btnCebuPac.Size = new System.Drawing.Size(97, 26);
            this.btnCebuPac.TabIndex = 13;
            this.btnCebuPac.Text = "Cebu Pacific";
            this.btnCebuPac.UseVisualStyleBackColor = false;
            this.btnCebuPac.Click += new System.EventHandler(this.btnCebuPac_Click);
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.Image = global::CM_Reprocess.Properties.Resources._24_October_abacus;
            this.pictureBoxType.Location = new System.Drawing.Point(458, 508);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(108, 34);
            this.pictureBoxType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxType.TabIndex = 14;
            this.pictureBoxType.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBoxLogo);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(566, 24);
            this.panel6.TabIndex = 43;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CM_Reprocess.Properties.Resources.refresh_3_icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 46;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Client Magic Reprocess";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(510, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(541, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "4.0";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(267, 52);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(97, 26);
            this.btnView.TabIndex = 45;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // listBoxAirFile
            // 
            this.listBoxAirFile.BackColor = System.Drawing.Color.LightBlue;
            this.listBoxAirFile.FormattingEnabled = true;
            this.listBoxAirFile.HorizontalScrollbar = true;
            this.listBoxAirFile.Location = new System.Drawing.Point(14, 98);
            this.listBoxAirFile.Name = "listBoxAirFile";
            this.listBoxAirFile.Size = new System.Drawing.Size(437, 407);
            this.listBoxAirFile.TabIndex = 46;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 542);
            this.Controls.Add(this.listBoxAirFile);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBoxType);
            this.Controls.Add(this.btnCebuPac);
            this.Controls.Add(this.btnDirectAmadeus);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnAbacus);
            this.Controls.Add(this.btnAmadeus);
            this.Controls.Add(this.btnReprocess);
            this.Controls.Add(this.txtBoxSearchKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Magic Reprocess";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearchKey;
        private System.Windows.Forms.Button btnReprocess;
        private System.Windows.Forms.Button btnAmadeus;
        private System.Windows.Forms.Button btnAbacus;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnDirectAmadeus;
        private System.Windows.Forms.Button btnCebuPac;
        private System.Windows.Forms.PictureBox pictureBoxType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListBox listBoxAirFile;
    }
}

