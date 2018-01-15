namespace BlackJack.UserControls
{
    partial class HandUC
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
            this.lblHandValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHandValue
            // 
            this.lblHandValue.AutoSize = true;
            this.lblHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue.Location = new System.Drawing.Point(3, 15);
            this.lblHandValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHandValue.Name = "lblHandValue";
            this.lblHandValue.Size = new System.Drawing.Size(26, 18);
            this.lblHandValue.TabIndex = 0;
            this.lblHandValue.Text = "25";
            // 
            // HandUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblHandValue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HandUC";
            this.Size = new System.Drawing.Size(32, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHandValue;
    }
}
