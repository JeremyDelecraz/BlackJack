namespace BlackJack.UserControls
{
    partial class playerUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerUC));
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.pbxProfil = new System.Windows.Forms.PictureBox();
            this.lblCashValue = new System.Windows.Forms.Label();
            this.lstImageProfil = new System.Windows.Forms.ImageList(this.components);
            this.lstHandUC = new BlackJack.UserControls.ListHandUC();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(2, 4);
            this.lblNamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(118, 15);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "Joueur Numéro 1";
            // 
            // pbxProfil
            // 
            this.pbxProfil.Location = new System.Drawing.Point(5, 28);
            this.pbxProfil.Name = "pbxProfil";
            this.pbxProfil.Size = new System.Drawing.Size(30, 30);
            this.pbxProfil.TabIndex = 2;
            this.pbxProfil.TabStop = false;
            // 
            // lblCashValue
            // 
            this.lblCashValue.AutoSize = true;
            this.lblCashValue.Location = new System.Drawing.Point(158, 4);
            this.lblCashValue.Name = "lblCashValue";
            this.lblCashValue.Size = new System.Drawing.Size(60, 15);
            this.lblCashValue.TabIndex = 3;
            this.lblCashValue.Text = "50\'000.-";
            // 
            // lstImageProfil
            // 
            this.lstImageProfil.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImageProfil.ImageStream")));
            this.lstImageProfil.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImageProfil.Images.SetKeyName(0, "UserPro.png");
            this.lstImageProfil.Images.SetKeyName(1, "UserLambda.png");
            // 
            // lstHandUC
            // 
            this.lstHandUC.Location = new System.Drawing.Point(38, 17);
            this.lstHandUC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstHandUC.Name = "lstHandUC";
            this.lstHandUC.Size = new System.Drawing.Size(355, 50);
            this.lstHandUC.TabIndex = 4;
            // 
            // playerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lstHandUC);
            this.Controls.Add(this.lblCashValue);
            this.Controls.Add(this.pbxProfil);
            this.Controls.Add(this.lblNamePlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "playerUC";
            this.Size = new System.Drawing.Size(391, 67);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.PictureBox pbxProfil;
        private System.Windows.Forms.Label lblCashValue;
        private System.Windows.Forms.ImageList lstImageProfil;
        private ListHandUC lstHandUC;
    }
}
