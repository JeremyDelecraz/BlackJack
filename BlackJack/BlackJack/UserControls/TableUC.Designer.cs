namespace BlackJack.UserControls
{
    partial class TableUC
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
            this.pbxTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTable
            // 
            this.pbxTable.BackgroundImage = global::BlackJack.Properties.Resources.Table;
            this.pbxTable.Location = new System.Drawing.Point(0, 0);
            this.pbxTable.Name = "pbxTable";
            this.pbxTable.Size = new System.Drawing.Size(800, 356);
            this.pbxTable.TabIndex = 0;
            this.pbxTable.TabStop = false;
            // 
            // TableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxTable);
            this.Name = "TableUC";
            this.Size = new System.Drawing.Size(800, 356);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTable;
    }
}
