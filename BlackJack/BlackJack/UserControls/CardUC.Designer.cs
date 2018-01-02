namespace BlackJack.UserControls
{
    partial class CardUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardUC));
            this.imgListCard = new System.Windows.Forms.ImageList(this.components);
            this.pbxCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListCard
            // 
            this.imgListCard.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCard.ImageStream")));
            this.imgListCard.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCard.Images.SetKeyName(0, "CA_2.png");
            this.imgListCard.Images.SetKeyName(1, "CA_3.png");
            this.imgListCard.Images.SetKeyName(2, "CA_4.png");
            this.imgListCard.Images.SetKeyName(3, "CA_5.png");
            this.imgListCard.Images.SetKeyName(4, "CA_6.png");
            this.imgListCard.Images.SetKeyName(5, "CA_7.png");
            this.imgListCard.Images.SetKeyName(6, "CA_8.png");
            this.imgListCard.Images.SetKeyName(7, "CA_9.png");
            this.imgListCard.Images.SetKeyName(8, "CA_10.png");
            this.imgListCard.Images.SetKeyName(9, "CA_J.png");
            this.imgListCard.Images.SetKeyName(10, "CA_Q.png");
            this.imgListCard.Images.SetKeyName(11, "CA_K.png");
            this.imgListCard.Images.SetKeyName(12, "CA_A.png");
            this.imgListCard.Images.SetKeyName(13, "CO_2.png");
            this.imgListCard.Images.SetKeyName(14, "CO_3.png");
            this.imgListCard.Images.SetKeyName(15, "CO_4.png");
            this.imgListCard.Images.SetKeyName(16, "CO_5.png");
            this.imgListCard.Images.SetKeyName(17, "CO_6.png");
            this.imgListCard.Images.SetKeyName(18, "CO_7.png");
            this.imgListCard.Images.SetKeyName(19, "CO_8.png");
            this.imgListCard.Images.SetKeyName(20, "CO_9.png");
            this.imgListCard.Images.SetKeyName(21, "CO_10.png");
            this.imgListCard.Images.SetKeyName(22, "CO_J.png");
            this.imgListCard.Images.SetKeyName(23, "CO_Q.png");
            this.imgListCard.Images.SetKeyName(24, "CO_K.png");
            this.imgListCard.Images.SetKeyName(25, "CO_A.png");
            this.imgListCard.Images.SetKeyName(26, "P_2.png");
            this.imgListCard.Images.SetKeyName(27, "P_3.png");
            this.imgListCard.Images.SetKeyName(28, "P_4.png");
            this.imgListCard.Images.SetKeyName(29, "P_5.png");
            this.imgListCard.Images.SetKeyName(30, "P_6.png");
            this.imgListCard.Images.SetKeyName(31, "P_7.png");
            this.imgListCard.Images.SetKeyName(32, "P_8.png");
            this.imgListCard.Images.SetKeyName(33, "P_9.png");
            this.imgListCard.Images.SetKeyName(34, "P_10.png");
            this.imgListCard.Images.SetKeyName(35, "P_J.png");
            this.imgListCard.Images.SetKeyName(36, "P_Q.png");
            this.imgListCard.Images.SetKeyName(37, "P_K.png");
            this.imgListCard.Images.SetKeyName(38, "P_A.png");
            this.imgListCard.Images.SetKeyName(39, "T_2.png");
            this.imgListCard.Images.SetKeyName(40, "T_3.png");
            this.imgListCard.Images.SetKeyName(41, "T_4.png");
            this.imgListCard.Images.SetKeyName(42, "T_5.png");
            this.imgListCard.Images.SetKeyName(43, "T_6.png");
            this.imgListCard.Images.SetKeyName(44, "T_7.png");
            this.imgListCard.Images.SetKeyName(45, "T_8.png");
            this.imgListCard.Images.SetKeyName(46, "T_9.png");
            this.imgListCard.Images.SetKeyName(47, "T_10.png");
            this.imgListCard.Images.SetKeyName(48, "T_J.png");
            this.imgListCard.Images.SetKeyName(49, "T_Q.png");
            this.imgListCard.Images.SetKeyName(50, "T_K.png");
            this.imgListCard.Images.SetKeyName(51, "T_A.png");
            this.imgListCard.Images.SetKeyName(52, "dos-web.jpg");
            // 
            // pbxCard
            // 
            this.pbxCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCard.InitialImage = null;
            this.pbxCard.Location = new System.Drawing.Point(0, 0);
            this.pbxCard.Name = "pbxCard";
            this.pbxCard.Size = new System.Drawing.Size(50, 73);
            this.pbxCard.TabIndex = 0;
            this.pbxCard.TabStop = false;
            // 
            // CardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxCard);
            this.Name = "CardUC";
            this.Size = new System.Drawing.Size(50, 73);
            this.Load += new System.EventHandler(this.CardUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCard;
        private System.Windows.Forms.ImageList imgListCard;
    }
}
