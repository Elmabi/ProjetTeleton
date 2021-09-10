using MesClasses;
using System.Collections.Generic;

namespace ProjetTeleton {
    partial class FenetreSelectionDonateur {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cmbSelectDonnateur = new System.Windows.Forms.ComboBox();
            this.gestionnaireSTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaireSTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdDonnateurTemp = new System.Windows.Forms.TextBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireSTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donateursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireSTEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectDonnateur
            // 
            this.cmbSelectDonnateur.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmbSelectDonnateur.FormattingEnabled = true;
            this.cmbSelectDonnateur.Location = new System.Drawing.Point(16, 59);
            this.cmbSelectDonnateur.Name = "cmbSelectDonnateur";
            this.cmbSelectDonnateur.Size = new System.Drawing.Size(380, 29);
            this.cmbSelectDonnateur.TabIndex = 0;
            this.cmbSelectDonnateur.SelectedIndexChanged += new System.EventHandler(this.cmbSelectDonnateur_SelectedIndexChanged);
            // 
            // gestionnaireSTEBindingSource
            // 
            this.gestionnaireSTEBindingSource.DataSource = typeof(MesClasses.GestionnaireSTE);
            // 
            // donateursBindingSource
            // 
            this.donateursBindingSource.DataMember = "Donateurs";
            this.donateursBindingSource.DataSource = this.gestionnaireSTEBindingSource;
            // 
            // gestionnaireSTEBindingSource1
            // 
            this.gestionnaireSTEBindingSource1.DataSource = typeof(MesClasses.GestionnaireSTE);
            // 
            // txtIdDonnateurTemp
            // 
            this.txtIdDonnateurTemp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtIdDonnateurTemp.Location = new System.Drawing.Point(155, 141);
            this.txtIdDonnateurTemp.Name = "txtIdDonnateurTemp";
            this.txtIdDonnateurTemp.ReadOnly = true;
            this.txtIdDonnateurTemp.Size = new System.Drawing.Size(100, 20);
            this.txtIdDonnateurTemp.TabIndex = 1;
            this.txtIdDonnateurTemp.Visible = false;
            this.txtIdDonnateurTemp.TextChanged += new System.EventHandler(this.txtIdDonnateurTemp_TextChanged);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectionner.Enabled = false;
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSelectionner.Location = new System.Drawing.Point(125, 186);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(170, 39);
            this.btnSelectionner.TabIndex = 2;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(392, 42);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Vous n\'avez entré aucun ID donnateur.\r\nVeuillez en sélectionner un dans la liste " +
    "ci sessous.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectionDonnateur
            // 
            this.AcceptButton = this.btnSelectionner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.txtIdDonnateurTemp);
            this.Controls.Add(this.cmbSelectDonnateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionDonnateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selection Donnateur";
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireSTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donateursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireSTEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectDonnateur;
        private System.Windows.Forms.BindingSource gestionnaireSTEBindingSource;
        private System.Windows.Forms.BindingSource donateursBindingSource;
        private System.Windows.Forms.BindingSource gestionnaireSTEBindingSource1;
        private System.Windows.Forms.TextBox txtIdDonnateurTemp;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Label lblMessage;
    }
}