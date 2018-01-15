namespace BlackJack.UserControls
{
    partial class PlayerProUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxProfil = new System.Windows.Forms.PictureBox();
            this.lblNbWin = new System.Windows.Forms.Label();
            this.lblNbEqual = new System.Windows.Forms.Label();
            this.lblNbLose = new System.Windows.Forms.Label();
            this.lblNbWinValue = new System.Windows.Forms.Label();
            this.lblNbEqualValue = new System.Windows.Forms.Label();
            this.lblNbLoseValue = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCashValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProfil
            // 
            this.pbxProfil.BackgroundImage = global::BlackJack.Properties.Resources.UserPro;
            this.pbxProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxProfil.Location = new System.Drawing.Point(3, 3);
            this.pbxProfil.Name = "pbxProfil";
            this.pbxProfil.Size = new System.Drawing.Size(30, 30);
            this.pbxProfil.TabIndex = 0;
            this.pbxProfil.TabStop = false;
            // 
            // lblNbWin
            // 
            this.lblNbWin.AutoSize = true;
            this.lblNbWin.Location = new System.Drawing.Point(3, 36);
            this.lblNbWin.Name = "lblNbWin";
            this.lblNbWin.Size = new System.Drawing.Size(48, 13);
            this.lblNbWin.TabIndex = 1;
            this.lblNbWin.Text = "Gagnant";
            // 
            // lblNbEqual
            // 
            this.lblNbEqual.AutoSize = true;
            this.lblNbEqual.Location = new System.Drawing.Point(62, 36);
            this.lblNbEqual.Name = "lblNbEqual";
            this.lblNbEqual.Size = new System.Drawing.Size(39, 13);
            this.lblNbEqual.TabIndex = 2;
            this.lblNbEqual.Text = "Egalité";
            // 
            // lblNbLose
            // 
            this.lblNbLose.AutoSize = true;
            this.lblNbLose.Location = new System.Drawing.Point(112, 36);
            this.lblNbLose.Name = "lblNbLose";
            this.lblNbLose.Size = new System.Drawing.Size(44, 13);
            this.lblNbLose.TabIndex = 3;
            this.lblNbLose.Text = "Perdant";
            // 
            // lblNbWinValue
            // 
            this.lblNbWinValue.AutoSize = true;
            this.lblNbWinValue.Location = new System.Drawing.Point(3, 51);
            this.lblNbWinValue.Name = "lblNbWinValue";
            this.lblNbWinValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbWinValue.TabIndex = 4;
            this.lblNbWinValue.Text = "0";
            // 
            // lblNbEqualValue
            // 
            this.lblNbEqualValue.AutoSize = true;
            this.lblNbEqualValue.Location = new System.Drawing.Point(62, 51);
            this.lblNbEqualValue.Name = "lblNbEqualValue";
            this.lblNbEqualValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbEqualValue.TabIndex = 5;
            this.lblNbEqualValue.Text = "0";
            // 
            // lblNbLoseValue
            // 
            this.lblNbLoseValue.AutoSize = true;
            this.lblNbLoseValue.Location = new System.Drawing.Point(112, 51);
            this.lblNbLoseValue.Name = "lblNbLoseValue";
            this.lblNbLoseValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbLoseValue.TabIndex = 6;
            this.lblNbLoseValue.Text = "0";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(39, 3);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(38, 13);
            this.lblCash.TabIndex = 7;
            this.lblCash.Text = "Argent";
            // 
            // lblCashValue
            // 
            this.lblCashValue.AutoSize = true;
            this.lblCashValue.Location = new System.Drawing.Point(39, 20);
            this.lblCashValue.Name = "lblCashValue";
            this.lblCashValue.Size = new System.Drawing.Size(13, 13);
            this.lblCashValue.TabIndex = 8;
            this.lblCashValue.Text = "0";
            // 
            // PlayerProUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCashValue);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblNbLoseValue);
            this.Controls.Add(this.lblNbEqualValue);
            this.Controls.Add(this.lblNbWinValue);
            this.Controls.Add(this.lblNbLose);
            this.Controls.Add(this.lblNbEqual);
            this.Controls.Add(this.lblNbWin);
            this.Controls.Add(this.pbxProfil);
            this.Name = "PlayerProUC";
            this.Size = new System.Drawing.Size(162, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProfil;
        private System.Windows.Forms.Label lblNbWin;
        private System.Windows.Forms.Label lblNbEqual;
        private System.Windows.Forms.Label lblNbLose;
        private System.Windows.Forms.Label lblNbWinValue;
        private System.Windows.Forms.Label lblNbEqualValue;
        private System.Windows.Forms.Label lblNbLoseValue;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblCashValue;
    }
}
