namespace BlackJack
{
    partial class FrmMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNbDeck = new System.Windows.Forms.Label();
            this.nupNbDeck = new System.Windows.Forms.NumericUpDown();
            this.nupNbPlayer = new System.Windows.Forms.NumericUpDown();
            this.nupNbTurn = new System.Windows.Forms.NumericUpDown();
            this.lblNbPlayer = new System.Windows.Forms.Label();
            this.lblNbTurn = new System.Windows.Forms.Label();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.lblNbTable = new System.Windows.Forms.Label();
            this.nupNbTable = new System.Windows.Forms.NumericUpDown();
            this.nupCash = new System.Windows.Forms.NumericUpDown();
            this.lblCashBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCash)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(12, 137);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 23);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNbDeck
            // 
            this.lblNbDeck.AutoSize = true;
            this.lblNbDeck.Location = new System.Drawing.Point(12, 9);
            this.lblNbDeck.Name = "lblNbDeck";
            this.lblNbDeck.Size = new System.Drawing.Size(95, 13);
            this.lblNbDeck.TabIndex = 0;
            this.lblNbDeck.Text = "Nombre de paquet";
            // 
            // nupNbDeck
            // 
            this.nupNbDeck.Location = new System.Drawing.Point(138, 7);
            this.nupNbDeck.Name = "nupNbDeck";
            this.nupNbDeck.Size = new System.Drawing.Size(78, 20);
            this.nupNbDeck.TabIndex = 1;
            this.nupNbDeck.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nupNbPlayer
            // 
            this.nupNbPlayer.Location = new System.Drawing.Point(138, 33);
            this.nupNbPlayer.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nupNbPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbPlayer.Name = "nupNbPlayer";
            this.nupNbPlayer.Size = new System.Drawing.Size(78, 20);
            this.nupNbPlayer.TabIndex = 3;
            this.nupNbPlayer.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nupNbTurn
            // 
            this.nupNbTurn.Location = new System.Drawing.Point(138, 59);
            this.nupNbTurn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupNbTurn.Name = "nupNbTurn";
            this.nupNbTurn.Size = new System.Drawing.Size(78, 20);
            this.nupNbTurn.TabIndex = 5;
            this.nupNbTurn.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblNbPlayer
            // 
            this.lblNbPlayer.AutoSize = true;
            this.lblNbPlayer.Location = new System.Drawing.Point(12, 35);
            this.lblNbPlayer.Name = "lblNbPlayer";
            this.lblNbPlayer.Size = new System.Drawing.Size(91, 13);
            this.lblNbPlayer.TabIndex = 2;
            this.lblNbPlayer.Text = "Nombre de joueur";
            // 
            // lblNbTurn
            // 
            this.lblNbTurn.AutoSize = true;
            this.lblNbTurn.Location = new System.Drawing.Point(12, 61);
            this.lblNbTurn.Name = "lblNbTurn";
            this.lblNbTurn.Size = new System.Drawing.Size(80, 13);
            this.lblNbTurn.TabIndex = 4;
            this.lblNbTurn.Text = "Nombre de tour";
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 10;
            // 
            // lblNbTable
            // 
            this.lblNbTable.AutoSize = true;
            this.lblNbTable.Location = new System.Drawing.Point(12, 87);
            this.lblNbTable.Name = "lblNbTable";
            this.lblNbTable.Size = new System.Drawing.Size(85, 13);
            this.lblNbTable.TabIndex = 6;
            this.lblNbTable.Text = "Nombre de table";
            // 
            // nupNbTable
            // 
            this.nupNbTable.Location = new System.Drawing.Point(138, 85);
            this.nupNbTable.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupNbTable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbTable.Name = "nupNbTable";
            this.nupNbTable.Size = new System.Drawing.Size(78, 20);
            this.nupNbTable.TabIndex = 7;
            this.nupNbTable.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nupCash
            // 
            this.nupCash.Location = new System.Drawing.Point(138, 111);
            this.nupCash.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nupCash.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupCash.Name = "nupCash";
            this.nupCash.Size = new System.Drawing.Size(78, 20);
            this.nupCash.TabIndex = 27;
            this.nupCash.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lblCashBase
            // 
            this.lblCashBase.AutoSize = true;
            this.lblCashBase.Location = new System.Drawing.Point(12, 113);
            this.lblCashBase.Name = "lblCashBase";
            this.lblCashBase.Size = new System.Drawing.Size(72, 13);
            this.lblCashBase.TabIndex = 26;
            this.lblCashBase.Text = "Cash de base";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 170);
            this.Controls.Add(this.nupCash);
            this.Controls.Add(this.lblCashBase);
            this.Controls.Add(this.nupNbTable);
            this.Controls.Add(this.lblNbTable);
            this.Controls.Add(this.lblNbTurn);
            this.Controls.Add(this.lblNbPlayer);
            this.Controls.Add(this.nupNbTurn);
            this.Controls.Add(this.nupNbPlayer);
            this.Controls.Add(this.nupNbDeck);
            this.Controls.Add(this.lblNbDeck);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.nupNbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNbDeck;
        private System.Windows.Forms.NumericUpDown nupNbDeck;
        private System.Windows.Forms.NumericUpDown nupNbPlayer;
        private System.Windows.Forms.NumericUpDown nupNbTurn;
        private System.Windows.Forms.Label lblNbPlayer;
        private System.Windows.Forms.Label lblNbTurn;
        private System.Windows.Forms.Timer tmrTurn;
        private System.Windows.Forms.Label lblNbTable;
        private System.Windows.Forms.NumericUpDown nupNbTable;
        private System.Windows.Forms.NumericUpDown nupCash;
        private System.Windows.Forms.Label lblCashBase;
    }
}

