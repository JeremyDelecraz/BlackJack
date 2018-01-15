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
            this.plBanUC = new BlackJack.UserControls.PlayerBankUC();
            this.gbxPlayer = new System.Windows.Forms.GroupBox();
            this.lblSabotValue = new System.Windows.Forms.Label();
            this.lblNbCard = new System.Windows.Forms.Label();
            this.lblNbCardValue = new System.Windows.Forms.Label();
            this.gbxBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbTable
            // 
            this.lblNbTable.AutoSize = true;
            this.lblNbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTable.Location = new System.Drawing.Point(0, 0);
            this.lblNbTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbTable.Name = "lblNbTable";
            this.lblNbTable.Size = new System.Drawing.Size(151, 25);
            this.lblNbTable.TabIndex = 0;
            this.lblNbTable.Text = "Table numéro ";
            // 
            // lblNbTableValue
            // 
            this.lblNbTableValue.AutoSize = true;
            this.lblNbTableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTableValue.Location = new System.Drawing.Point(160, 0);
            this.lblNbTableValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbTableValue.Name = "lblNbTableValue";
            this.lblNbTableValue.Size = new System.Drawing.Size(24, 25);
            this.lblNbTableValue.TabIndex = 1;
            this.lblNbTableValue.Text = "0";
            // 
            // gbxPlayerPro
            // 
            this.gbxPlayerPro.Location = new System.Drawing.Point(107, 53);
            this.gbxPlayerPro.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPlayerPro.Name = "gbxPlayerPro";
            this.gbxPlayerPro.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPlayerPro.Size = new System.Drawing.Size(247, 85);
            this.gbxPlayerPro.TabIndex = 12;
            this.gbxPlayerPro.TabStop = false;
            // 
            // gbxBank
            // 
            this.gbxBank.Controls.Add(this.plBanUC);
            this.gbxBank.Location = new System.Drawing.Point(12, 51);
            this.gbxBank.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBank.Name = "gbxBank";
            this.gbxBank.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBank.Size = new System.Drawing.Size(72, 87);
            this.gbxBank.TabIndex = 13;
            this.gbxBank.TabStop = false;
            // 
            // plBanUC
            // 
            this.plBanUC.BackColor = System.Drawing.SystemColors.Control;
            this.plBanUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plBanUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plBanUC.Location = new System.Drawing.Point(15, 14);
            this.plBanUC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plBanUC.Name = "plBanUC";
            this.plBanUC.Size = new System.Drawing.Size(43, 66);
            this.plBanUC.TabIndex = 0;
            // 
            // gbxPlayer
            // 
            this.gbxPlayer.Location = new System.Drawing.Point(4, 133);
            this.gbxPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPlayer.Name = "gbxPlayer";
            this.gbxPlayer.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPlayer.Size = new System.Drawing.Size(499, 233);
            this.gbxPlayer.TabIndex = 13;
            this.gbxPlayer.TabStop = false;
            // 
            // lblSabotValue
            // 
            this.lblSabotValue.AutoSize = true;
            this.lblSabotValue.Location = new System.Drawing.Point(162, 32);
            this.lblSabotValue.Name = "lblSabotValue";
            this.lblSabotValue.Size = new System.Drawing.Size(16, 17);
            this.lblSabotValue.TabIndex = 14;
            this.lblSabotValue.Text = "0";
            // 
            // lblNbCard
            // 
            this.lblNbCard.AutoSize = true;
            this.lblNbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbCard.Location = new System.Drawing.Point(242, 0);
            this.lblNbCard.Name = "lblNbCard";
            this.lblNbCard.Size = new System.Drawing.Size(195, 25);
            this.lblNbCard.TabIndex = 15;
            this.lblNbCard.Text = "Nombre de cartes :";
            // 
            // lblNbCardValue
            // 
            this.lblNbCardValue.AutoSize = true;
            this.lblNbCardValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbCardValue.Location = new System.Drawing.Point(439, 0);
            this.lblNbCardValue.Name = "lblNbCardValue";
            this.lblNbCardValue.Size = new System.Drawing.Size(64, 25);
            this.lblNbCardValue.TabIndex = 16;
            this.lblNbCardValue.Text = "label1";
            // 
            // TableUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblNbCardValue);
            this.Controls.Add(this.lblNbCard);
            this.Controls.Add(this.lblSabotValue);
            this.Controls.Add(this.gbxPlayer);
            this.Controls.Add(this.gbxBank);
            this.Controls.Add(this.gbxPlayerPro);
            this.Controls.Add(this.lblNbTableValue);
            this.Controls.Add(this.lblNbTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableUC";
            this.Size = new System.Drawing.Size(509, 369);
            this.gbxBank.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbTable;
        private System.Windows.Forms.Label lblNbTableValue;
        private System.Windows.Forms.GroupBox gbxPlayerPro;
        private System.Windows.Forms.GroupBox gbxBank;
        private System.Windows.Forms.GroupBox gbxPlayer;
        private System.Windows.Forms.Label lblSabotValue;
        private PlayerBankUC plBanUC;
        private System.Windows.Forms.Label lblNbCard;
        private System.Windows.Forms.Label lblNbCardValue;
    }
}
