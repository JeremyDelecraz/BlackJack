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
            this.lblNbTable = new System.Windows.Forms.Label();
            this.lblNbTableValue = new System.Windows.Forms.Label();
            this.gbxPlayerPro = new System.Windows.Forms.GroupBox();
            this.gbxBank = new System.Windows.Forms.GroupBox();
            this.gbxPlayer = new System.Windows.Forms.GroupBox();
            this.plBanUC = new BlackJack.UserControls.PlayerBankUC();
            this.gbxBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbTable
            // 
            this.lblNbTable.AutoSize = true;
            this.lblNbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTable.Location = new System.Drawing.Point(0, 0);
            this.lblNbTable.Name = "lblNbTable";
            this.lblNbTable.Size = new System.Drawing.Size(123, 20);
            this.lblNbTable.TabIndex = 0;
            this.lblNbTable.Text = "Table numéro ";
            // 
            // lblNbTableValue
            // 
            this.lblNbTableValue.AutoSize = true;
            this.lblNbTableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTableValue.Location = new System.Drawing.Point(120, 0);
            this.lblNbTableValue.Name = "lblNbTableValue";
            this.lblNbTableValue.Size = new System.Drawing.Size(19, 20);
            this.lblNbTableValue.TabIndex = 1;
            this.lblNbTableValue.Text = "0";
            // 
            // gbxPlayerPro
            // 
            this.gbxPlayerPro.Location = new System.Drawing.Point(273, 16);
            this.gbxPlayerPro.Name = "gbxPlayerPro";
            this.gbxPlayerPro.Size = new System.Drawing.Size(401, 84);
            this.gbxPlayerPro.TabIndex = 12;
            this.gbxPlayerPro.TabStop = false;
            // 
            // gbxBank
            // 
            this.gbxBank.Controls.Add(this.plBanUC);
            this.gbxBank.Location = new System.Drawing.Point(132, 16);
            this.gbxBank.Name = "gbxBank";
            this.gbxBank.Size = new System.Drawing.Size(92, 84);
            this.gbxBank.TabIndex = 13;
            this.gbxBank.TabStop = false;
            // 
            // gbxPlayer
            // 
            this.gbxPlayer.Location = new System.Drawing.Point(4, 99);
            this.gbxPlayer.Name = "gbxPlayer";
            this.gbxPlayer.Size = new System.Drawing.Size(795, 226);
            this.gbxPlayer.TabIndex = 13;
            this.gbxPlayer.TabStop = false;
            // 
            // plBanUC
            // 
            this.plBanUC.BackColor = System.Drawing.SystemColors.Control;
            this.plBanUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plBanUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plBanUC.Location = new System.Drawing.Point(5, 12);
            this.plBanUC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plBanUC.Name = "plBanUC";
            this.plBanUC.Size = new System.Drawing.Size(81, 66);
            this.plBanUC.TabIndex = 2;
            // 
            // TableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.gbxPlayer);
            this.Controls.Add(this.gbxBank);
            this.Controls.Add(this.gbxPlayerPro);
            this.Controls.Add(this.lblNbTableValue);
            this.Controls.Add(this.lblNbTable);
            this.Name = "TableUC";
            this.Size = new System.Drawing.Size(802, 326);
            this.gbxBank.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbTable;
        private System.Windows.Forms.Label lblNbTableValue;
        private PlayerBankUC plBanUC;
        private System.Windows.Forms.GroupBox gbxPlayerPro;
        private System.Windows.Forms.GroupBox gbxBank;
        private System.Windows.Forms.GroupBox gbxPlayer;
    }
}
