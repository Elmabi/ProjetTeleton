
namespace ProjetTeleton
{
    partial class FenetreAccueil
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuitterLogin = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.lblHinde = new System.Windows.Forms.Label();
            this.lblAuteurs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChristian = new System.Windows.Forms.Label();
            this.lblAlexandre = new System.Windows.Forms.Label();
            this.lblArmel = new System.Windows.Forms.Label();
            this.pnlTelethonDesc = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTelethonDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(55)))), ((int)(((byte)(177)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(55)))), ((int)(((byte)(177)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnLogin.Image = global::ProjetTeleton.Properties.Resources.ConnexionButton;
            this.btnLogin.Location = new System.Drawing.Point(475, 472);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 59);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuitterLogin
            // 
            this.btnQuitterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnQuitterLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitterLogin.FlatAppearance.BorderSize = 0;
            this.btnQuitterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitterLogin.Location = new System.Drawing.Point(967, 373);
            this.btnQuitterLogin.Name = "btnQuitterLogin";
            this.btnQuitterLogin.Size = new System.Drawing.Size(10, 10);
            this.btnQuitterLogin.TabIndex = 1;
            this.btnQuitterLogin.UseVisualStyleBackColor = false;
            this.btnQuitterLogin.Click += new System.EventHandler(this.btnQuitterLogin_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(234)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(200)))), ((int)(((byte)(29)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(234)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Image = global::ProjetTeleton.Properties.Resources.informationsButton;
            this.btnInfo.Location = new System.Drawing.Point(475, 561);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(171, 59);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlInformations
            // 
            this.pnlInformations.BackColor = System.Drawing.Color.Transparent;
            this.pnlInformations.Controls.Add(this.lblHinde);
            this.pnlInformations.Controls.Add(this.lblAuteurs);
            this.pnlInformations.Controls.Add(this.pictureBox1);
            this.pnlInformations.Controls.Add(this.lblChristian);
            this.pnlInformations.Controls.Add(this.lblAlexandre);
            this.pnlInformations.Controls.Add(this.lblArmel);
            this.pnlInformations.Location = new System.Drawing.Point(10, 24);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(572, 192);
            this.pnlInformations.TabIndex = 4;
            // 
            // lblHinde
            // 
            this.lblHinde.AutoSize = true;
            this.lblHinde.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinde.ForeColor = System.Drawing.Color.White;
            this.lblHinde.Location = new System.Drawing.Point(3, 167);
            this.lblHinde.Name = "lblHinde";
            this.lblHinde.Size = new System.Drawing.Size(388, 16);
            this.lblHinde.TabIndex = 6;
            this.lblHinde.Text = "* Ce projet a été réalisé sous la supervision du professeur Hinde Anouel ";
            // 
            // lblAuteurs
            // 
            this.lblAuteurs.AutoSize = true;
            this.lblAuteurs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteurs.ForeColor = System.Drawing.Color.Snow;
            this.lblAuteurs.Location = new System.Drawing.Point(132, 14);
            this.lblAuteurs.Name = "lblAuteurs";
            this.lblAuteurs.Size = new System.Drawing.Size(232, 23);
            this.lblAuteurs.TabIndex = 4;
            this.lblAuteurs.Text = "L\'équipe de Développement *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetTeleton.Properties.Resources.icons8_people_120px_1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblChristian
            // 
            this.lblChristian.AutoSize = true;
            this.lblChristian.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChristian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.lblChristian.Location = new System.Drawing.Point(132, 90);
            this.lblChristian.Name = "lblChristian";
            this.lblChristian.Size = new System.Drawing.Size(116, 20);
            this.lblChristian.TabIndex = 2;
            this.lblChristian.Text = "Christian Toumie";
            // 
            // lblAlexandre
            // 
            this.lblAlexandre.AutoSize = true;
            this.lblAlexandre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlexandre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.lblAlexandre.Location = new System.Drawing.Point(132, 71);
            this.lblAlexandre.Name = "lblAlexandre";
            this.lblAlexandre.Size = new System.Drawing.Size(114, 20);
            this.lblAlexandre.TabIndex = 1;
            this.lblAlexandre.Text = "Alexandre Forget";
            // 
            // lblArmel
            // 
            this.lblArmel.AutoSize = true;
            this.lblArmel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.lblArmel.Location = new System.Drawing.Point(132, 50);
            this.lblArmel.Name = "lblArmel";
            this.lblArmel.Size = new System.Drawing.Size(210, 20);
            this.lblArmel.TabIndex = 0;
            this.lblArmel.Text = "Armel Franck Djiongo Sobgoum";
            // 
            // pnlTelethonDesc
            // 
            this.pnlTelethonDesc.BackColor = System.Drawing.Color.Transparent;
            this.pnlTelethonDesc.Controls.Add(this.label2);
            this.pnlTelethonDesc.Location = new System.Drawing.Point(626, 24);
            this.pnlTelethonDesc.Name = "pnlTelethonDesc";
            this.pnlTelethonDesc.Size = new System.Drawing.Size(486, 182);
            this.pnlTelethonDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(125, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 138);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cette application permet de gérer les dons reçus\r\nlors d’un téléthon. \r\n\r\nElle pe" +
    "rmet de: \r\n1- Faire le suivi des dons et des donateurs.\r\n2- Attribuer des prix a" +
    "ux donateurs.";
            // 
            // FenetreAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetTeleton.Properties.Resources.telethonBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnQuitterLogin;
            this.ClientSize = new System.Drawing.Size(1121, 732);
            this.Controls.Add(this.pnlTelethonDesc);
            this.Controls.Add(this.pnlInformations);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnQuitterLogin);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FenetreAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FenetreAccueil_MouseDown);
            this.pnlInformations.ResumeLayout(false);
            this.pnlInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTelethonDesc.ResumeLayout(false);
            this.pnlTelethonDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuitterLogin;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlInformations;
        private System.Windows.Forms.Label lblChristian;
        private System.Windows.Forms.Label lblAlexandre;
        private System.Windows.Forms.Label lblArmel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAuteurs;
        private System.Windows.Forms.Label lblHinde;
        private System.Windows.Forms.Panel pnlTelethonDesc;
        private System.Windows.Forms.Label label2;
    }
}