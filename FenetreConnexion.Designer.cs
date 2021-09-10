
namespace ProjetTeleton
{
    partial class FenetreConnexion
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConnexion2 = new System.Windows.Forms.Button();
            this.btnReessayer = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(147)))), ((int)(((byte)(224)))));
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.lblConnexion);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(507, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 2);
            this.panel1.TabIndex = 2;
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.Color.White;
            this.lblConnexion.Location = new System.Drawing.Point(1, 12);
            this.lblConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(170, 26);
            this.lblConnexion.TabIndex = 1;
            this.lblConnexion.Text = "Page de Connexion";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(469, 6);
            this.btnX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 33);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(45, 11);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Nom d\'Utilisateur";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(45, 9);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mot de Passe";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Location = new System.Drawing.Point(106, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 43);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetTeleton.Properties.Resources.icons8_user_40px;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Location = new System.Drawing.Point(106, 147);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 44);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetTeleton.Properties.Resources.icons8_key_40px;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnConnexion2
            // 
            this.btnConnexion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(147)))), ((int)(((byte)(224)))));
            this.btnConnexion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(200)))), ((int)(((byte)(29)))));
            this.btnConnexion2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(200)))), ((int)(((byte)(29)))));
            this.btnConnexion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion2.ForeColor = System.Drawing.Color.White;
            this.btnConnexion2.Image = global::ProjetTeleton.Properties.Resources.icons8_padlock_40px;
            this.btnConnexion2.Location = new System.Drawing.Point(104, 221);
            this.btnConnexion2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnexion2.Name = "btnConnexion2";
            this.btnConnexion2.Size = new System.Drawing.Size(146, 45);
            this.btnConnexion2.TabIndex = 5;
            this.btnConnexion2.Text = "&Connexion";
            this.btnConnexion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnexion2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnexion2.UseVisualStyleBackColor = false;
            this.btnConnexion2.Click += new System.EventHandler(this.btnConnexion2_Click);
            // 
            // btnReessayer
            // 
            this.btnReessayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(147)))), ((int)(((byte)(224)))));
            this.btnReessayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReessayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReessayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReessayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReessayer.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReessayer.ForeColor = System.Drawing.Color.White;
            this.btnReessayer.Image = global::ProjetTeleton.Properties.Resources.icons8_reset_40px;
            this.btnReessayer.Location = new System.Drawing.Point(270, 221);
            this.btnReessayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReessayer.Name = "btnReessayer";
            this.btnReessayer.Size = new System.Drawing.Size(144, 45);
            this.btnReessayer.TabIndex = 6;
            this.btnReessayer.Text = "&Réessayer";
            this.btnReessayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReessayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReessayer.UseVisualStyleBackColor = false;
            this.btnReessayer.Click += new System.EventHandler(this.btnReessayer_Click);
            // 
            // Connexion
            // 
            this.AcceptButton = this.btnConnexion2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnX;
            this.ClientSize = new System.Drawing.Size(507, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnReessayer);
            this.Controls.Add(this.btnConnexion2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connexion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConnexion2;
        private System.Windows.Forms.Button btnReessayer;
    }
}