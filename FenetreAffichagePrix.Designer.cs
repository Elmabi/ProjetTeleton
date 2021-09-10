
namespace ProjetTeleton
{
    partial class FenetreAffichagePrix
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
            this.btnOKFormPrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrixFormPrix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOKFormPrix
            // 
            this.btnOKFormPrix.BackColor = System.Drawing.Color.DimGray;
            this.btnOKFormPrix.FlatAppearance.BorderSize = 0;
            this.btnOKFormPrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKFormPrix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOKFormPrix.ForeColor = System.Drawing.Color.Black;
            this.btnOKFormPrix.Location = new System.Drawing.Point(100, 190);
            this.btnOKFormPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOKFormPrix.Name = "btnOKFormPrix";
            this.btnOKFormPrix.Size = new System.Drawing.Size(167, 44);
            this.btnOKFormPrix.TabIndex = 3;
            this.btnOKFormPrix.Text = "O K";
            this.btnOKFormPrix.UseVisualStyleBackColor = false;
            this.btnOKFormPrix.Click += new System.EventHandler(this.btnOKFormPrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "Le don a été ajouté \r\navec succès";
            // 
            // lblPrixFormPrix
            // 
            this.lblPrixFormPrix.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixFormPrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrixFormPrix.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrixFormPrix.Location = new System.Drawing.Point(0, 0);
            this.lblPrixFormPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixFormPrix.Name = "lblPrixFormPrix";
            this.lblPrixFormPrix.Size = new System.Drawing.Size(517, 100);
            this.lblPrixFormPrix.TabIndex = 6;
            this.lblPrixFormPrix.Text = "label1";
            this.lblPrixFormPrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetTeleton.Properties.Resources.prixArrierePlan1;
            this.ClientSize = new System.Drawing.Size(517, 249);
            this.Controls.Add(this.lblPrixFormPrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOKFormPrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOKFormPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrixFormPrix;
    }
}