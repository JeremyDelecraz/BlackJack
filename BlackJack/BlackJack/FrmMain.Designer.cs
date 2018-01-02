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
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblNbDeck = new System.Windows.Forms.Label();
            this.nupNbDeck = new System.Windows.Forms.NumericUpDown();
            this.nupNbPlayer = new System.Windows.Forms.NumericUpDown();
            this.nupNbTurn = new System.Windows.Forms.NumericUpDown();
            this.lblNbPlayer = new System.Windows.Forms.Label();
            this.lblNbTurn = new System.Windows.Forms.Label();
            this.lblCashBase = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblAccountValue = new System.Windows.Forms.Label();
            this.lblCashBaseValue = new System.Windows.Forms.Label();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.lblNbTurnInfo = new System.Windows.Forms.Label();
            this.lblNbTurnValue = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblNbWin = new System.Windows.Forms.Label();
            this.lblNbLose = new System.Windows.Forms.Label();
            this.lblNbEqual = new System.Windows.Forms.Label();
            this.lblNbWinValue = new System.Windows.Forms.Label();
            this.lblNbEqualValue = new System.Windows.Forms.Label();
            this.lblNbLoseValue = new System.Windows.Forms.Label();
            this.lblSabot = new System.Windows.Forms.Label();
            this.lblSabotValue = new System.Windows.Forms.Label();
            this.lblGameIndex = new System.Windows.Forms.Label();
            this.lblGameIndexValue = new System.Windows.Forms.Label();
            this.lblNbTable = new System.Windows.Forms.Label();
            this.nupNbTable = new System.Windows.Forms.NumericUpDown();
            this.cbxTimer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.Location = new System.Drawing.Point(12, 194);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(162, 23);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblNbDeck
            // 
            this.lblNbDeck.AutoSize = true;
            this.lblNbDeck.Location = new System.Drawing.Point(13, 21);
            this.lblNbDeck.Name = "lblNbDeck";
            this.lblNbDeck.Size = new System.Drawing.Size(95, 13);
            this.lblNbDeck.TabIndex = 0;
            this.lblNbDeck.Text = "Nombre de paquet";
            // 
            // nupNbDeck
            // 
            this.nupNbDeck.Location = new System.Drawing.Point(114, 19);
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
            this.nupNbPlayer.Location = new System.Drawing.Point(114, 46);
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
            5,
            0,
            0,
            0});
            // 
            // nupNbTurn
            // 
            this.nupNbTurn.Location = new System.Drawing.Point(114, 73);
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
            this.lblNbPlayer.Location = new System.Drawing.Point(13, 48);
            this.lblNbPlayer.Name = "lblNbPlayer";
            this.lblNbPlayer.Size = new System.Drawing.Size(91, 13);
            this.lblNbPlayer.TabIndex = 2;
            this.lblNbPlayer.Text = "Nombre de joueur";
            // 
            // lblNbTurn
            // 
            this.lblNbTurn.AutoSize = true;
            this.lblNbTurn.Location = new System.Drawing.Point(13, 75);
            this.lblNbTurn.Name = "lblNbTurn";
            this.lblNbTurn.Size = new System.Drawing.Size(80, 13);
            this.lblNbTurn.TabIndex = 4;
            this.lblNbTurn.Text = "Nombre de tour";
            // 
            // lblCashBase
            // 
            this.lblCashBase.AutoSize = true;
            this.lblCashBase.Location = new System.Drawing.Point(216, 75);
            this.lblCashBase.Name = "lblCashBase";
            this.lblCashBase.Size = new System.Drawing.Size(72, 13);
            this.lblCashBase.TabIndex = 11;
            this.lblCashBase.Text = "Cash de base";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(216, 102);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(31, 13);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "Total";
            // 
            // lblAccountValue
            // 
            this.lblAccountValue.AutoSize = true;
            this.lblAccountValue.Location = new System.Drawing.Point(296, 102);
            this.lblAccountValue.Name = "lblAccountValue";
            this.lblAccountValue.Size = new System.Drawing.Size(37, 13);
            this.lblAccountValue.TabIndex = 14;
            this.lblAccountValue.Text = "50000";
            // 
            // lblCashBaseValue
            // 
            this.lblCashBaseValue.AutoSize = true;
            this.lblCashBaseValue.Location = new System.Drawing.Point(296, 75);
            this.lblCashBaseValue.Name = "lblCashBaseValue";
            this.lblCashBaseValue.Size = new System.Drawing.Size(37, 13);
            this.lblCashBaseValue.TabIndex = 12;
            this.lblCashBaseValue.Text = "50000";
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 1;
            this.tmrTurn.Tick += new System.EventHandler(this.tmrTurn_Tick);
            // 
            // lblNbTurnInfo
            // 
            this.lblNbTurnInfo.AutoSize = true;
            this.lblNbTurnInfo.Location = new System.Drawing.Point(216, 48);
            this.lblNbTurnInfo.Name = "lblNbTurnInfo";
            this.lblNbTurnInfo.Size = new System.Drawing.Size(44, 13);
            this.lblNbTurnInfo.TabIndex = 9;
            this.lblNbTurnInfo.Text = "Tour N°";
            // 
            // lblNbTurnValue
            // 
            this.lblNbTurnValue.AutoSize = true;
            this.lblNbTurnValue.Location = new System.Drawing.Point(299, 52);
            this.lblNbTurnValue.Name = "lblNbTurnValue";
            this.lblNbTurnValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbTurnValue.TabIndex = 10;
            this.lblNbTurnValue.Text = "0";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartStop.Location = new System.Drawing.Point(180, 194);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(171, 23);
            this.btnStartStop.TabIndex = 26;
            this.btnStartStop.Text = "Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblNbWin
            // 
            this.lblNbWin.AutoSize = true;
            this.lblNbWin.Location = new System.Drawing.Point(18, 138);
            this.lblNbWin.Name = "lblNbWin";
            this.lblNbWin.Size = new System.Drawing.Size(48, 13);
            this.lblNbWin.TabIndex = 15;
            this.lblNbWin.Text = "Gagnant";
            // 
            // lblNbLose
            // 
            this.lblNbLose.AutoSize = true;
            this.lblNbLose.Location = new System.Drawing.Point(255, 138);
            this.lblNbLose.Name = "lblNbLose";
            this.lblNbLose.Size = new System.Drawing.Size(44, 13);
            this.lblNbLose.TabIndex = 19;
            this.lblNbLose.Text = "Perdant";
            // 
            // lblNbEqual
            // 
            this.lblNbEqual.AutoSize = true;
            this.lblNbEqual.Location = new System.Drawing.Point(141, 138);
            this.lblNbEqual.Name = "lblNbEqual";
            this.lblNbEqual.Size = new System.Drawing.Size(39, 13);
            this.lblNbEqual.TabIndex = 17;
            this.lblNbEqual.Text = "Egalité";
            // 
            // lblNbWinValue
            // 
            this.lblNbWinValue.AutoSize = true;
            this.lblNbWinValue.Location = new System.Drawing.Point(97, 138);
            this.lblNbWinValue.Name = "lblNbWinValue";
            this.lblNbWinValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbWinValue.TabIndex = 16;
            this.lblNbWinValue.Text = "0";
            // 
            // lblNbEqualValue
            // 
            this.lblNbEqualValue.AutoSize = true;
            this.lblNbEqualValue.Location = new System.Drawing.Point(211, 138);
            this.lblNbEqualValue.Name = "lblNbEqualValue";
            this.lblNbEqualValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbEqualValue.TabIndex = 18;
            this.lblNbEqualValue.Text = "0";
            // 
            // lblNbLoseValue
            // 
            this.lblNbLoseValue.AutoSize = true;
            this.lblNbLoseValue.Location = new System.Drawing.Point(330, 138);
            this.lblNbLoseValue.Name = "lblNbLoseValue";
            this.lblNbLoseValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbLoseValue.TabIndex = 20;
            this.lblNbLoseValue.Text = "0";
            // 
            // lblSabot
            // 
            this.lblSabot.AutoSize = true;
            this.lblSabot.Location = new System.Drawing.Point(173, 162);
            this.lblSabot.Name = "lblSabot";
            this.lblSabot.Size = new System.Drawing.Size(35, 13);
            this.lblSabot.TabIndex = 23;
            this.lblSabot.Text = "Sabot";
            // 
            // lblSabotValue
            // 
            this.lblSabotValue.AutoSize = true;
            this.lblSabotValue.Location = new System.Drawing.Point(247, 162);
            this.lblSabotValue.Name = "lblSabotValue";
            this.lblSabotValue.Size = new System.Drawing.Size(13, 13);
            this.lblSabotValue.TabIndex = 24;
            this.lblSabotValue.Text = "0";
            // 
            // lblGameIndex
            // 
            this.lblGameIndex.AutoSize = true;
            this.lblGameIndex.Location = new System.Drawing.Point(29, 162);
            this.lblGameIndex.Name = "lblGameIndex";
            this.lblGameIndex.Size = new System.Drawing.Size(50, 13);
            this.lblGameIndex.TabIndex = 21;
            this.lblGameIndex.Text = "Game N°";
            // 
            // lblGameIndexValue
            // 
            this.lblGameIndexValue.AutoSize = true;
            this.lblGameIndexValue.Location = new System.Drawing.Point(118, 162);
            this.lblGameIndexValue.Name = "lblGameIndexValue";
            this.lblGameIndexValue.Size = new System.Drawing.Size(16, 13);
            this.lblGameIndexValue.TabIndex = 22;
            this.lblGameIndexValue.Text = "-1";
            // 
            // lblNbTable
            // 
            this.lblNbTable.AutoSize = true;
            this.lblNbTable.Location = new System.Drawing.Point(13, 100);
            this.lblNbTable.Name = "lblNbTable";
            this.lblNbTable.Size = new System.Drawing.Size(85, 13);
            this.lblNbTable.TabIndex = 6;
            this.lblNbTable.Text = "Nombre de table";
            // 
            // nupNbTable
            // 
            this.nupNbTable.Location = new System.Drawing.Point(114, 100);
            this.nupNbTable.Maximum = new decimal(new int[] {
            10,
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
            10,
            0,
            0,
            0});
            // 
            // cbxTimer
            // 
            this.cbxTimer.AutoSize = true;
            this.cbxTimer.Location = new System.Drawing.Point(219, 22);
            this.cbxTimer.Name = "cbxTimer";
            this.cbxTimer.Size = new System.Drawing.Size(52, 17);
            this.cbxTimer.TabIndex = 8;
            this.cbxTimer.Text = "Timer";
            this.cbxTimer.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnRestart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 229);
            this.Controls.Add(this.cbxTimer);
            this.Controls.Add(this.nupNbTable);
            this.Controls.Add(this.lblNbTable);
            this.Controls.Add(this.lblGameIndexValue);
            this.Controls.Add(this.lblGameIndex);
            this.Controls.Add(this.lblSabotValue);
            this.Controls.Add(this.lblSabot);
            this.Controls.Add(this.lblNbLoseValue);
            this.Controls.Add(this.lblNbEqualValue);
            this.Controls.Add(this.lblNbWinValue);
            this.Controls.Add(this.lblNbEqual);
            this.Controls.Add(this.lblNbLose);
            this.Controls.Add(this.lblNbWin);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblNbTurnValue);
            this.Controls.Add(this.lblNbTurnInfo);
            this.Controls.Add(this.lblCashBaseValue);
            this.Controls.Add(this.lblAccountValue);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblCashBase);
            this.Controls.Add(this.lblNbTurn);
            this.Controls.Add(this.lblNbPlayer);
            this.Controls.Add(this.nupNbTurn);
            this.Controls.Add(this.nupNbPlayer);
            this.Controls.Add(this.nupNbDeck);
            this.Controls.Add(this.lblNbDeck);
            this.Controls.Add(this.btnRestart);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.nupNbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblNbDeck;
        private System.Windows.Forms.NumericUpDown nupNbDeck;
        private System.Windows.Forms.NumericUpDown nupNbPlayer;
        private System.Windows.Forms.NumericUpDown nupNbTurn;
        private System.Windows.Forms.Label lblNbPlayer;
        private System.Windows.Forms.Label lblNbTurn;
        private System.Windows.Forms.Label lblCashBase;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblAccountValue;
        private System.Windows.Forms.Label lblCashBaseValue;
        private System.Windows.Forms.Timer tmrTurn;
        private System.Windows.Forms.Label lblNbTurnInfo;
        private System.Windows.Forms.Label lblNbTurnValue;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblNbWin;
        private System.Windows.Forms.Label lblNbLose;
        private System.Windows.Forms.Label lblNbEqual;
        private System.Windows.Forms.Label lblNbWinValue;
        private System.Windows.Forms.Label lblNbEqualValue;
        private System.Windows.Forms.Label lblNbLoseValue;
        private System.Windows.Forms.Label lblSabot;
        private System.Windows.Forms.Label lblSabotValue;
        private System.Windows.Forms.Label lblGameIndex;
        private System.Windows.Forms.Label lblGameIndexValue;
        private System.Windows.Forms.Label lblNbTable;
        private System.Windows.Forms.NumericUpDown nupNbTable;
        private System.Windows.Forms.CheckBox cbxTimer;
    }
}

