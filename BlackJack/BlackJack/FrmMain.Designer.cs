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
            ((System.ComponentModel.ISupportInitialize)(this.nupNbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Location = new System.Drawing.Point(12, 153);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(180, 23);
            this.btnRestart.TabIndex = 1;
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
            this.lblNbDeck.TabIndex = 2;
            this.lblNbDeck.Text = "Nombre de paquet";
            // 
            // nupNbDeck
            // 
            this.nupNbDeck.Location = new System.Drawing.Point(114, 19);
            this.nupNbDeck.Name = "nupNbDeck";
            this.nupNbDeck.Size = new System.Drawing.Size(78, 20);
            this.nupNbDeck.TabIndex = 3;
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
            this.nupNbPlayer.Name = "nupNbPlayer";
            this.nupNbPlayer.Size = new System.Drawing.Size(78, 20);
            this.nupNbPlayer.TabIndex = 4;
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
            1000,
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
            this.lblNbPlayer.TabIndex = 6;
            this.lblNbPlayer.Text = "Nombre de joueur";
            // 
            // lblNbTurn
            // 
            this.lblNbTurn.AutoSize = true;
            this.lblNbTurn.Location = new System.Drawing.Point(13, 75);
            this.lblNbTurn.Name = "lblNbTurn";
            this.lblNbTurn.Size = new System.Drawing.Size(80, 13);
            this.lblNbTurn.TabIndex = 7;
            this.lblNbTurn.Text = "Nombre de tour";
            // 
            // lblCashBase
            // 
            this.lblCashBase.AutoSize = true;
            this.lblCashBase.Location = new System.Drawing.Point(215, 48);
            this.lblCashBase.Name = "lblCashBase";
            this.lblCashBase.Size = new System.Drawing.Size(72, 13);
            this.lblCashBase.TabIndex = 8;
            this.lblCashBase.Text = "Cash de base";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(215, 75);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(31, 13);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "Total";
            // 
            // lblAccountValue
            // 
            this.lblAccountValue.AutoSize = true;
            this.lblAccountValue.Location = new System.Drawing.Point(295, 75);
            this.lblAccountValue.Name = "lblAccountValue";
            this.lblAccountValue.Size = new System.Drawing.Size(37, 13);
            this.lblAccountValue.TabIndex = 10;
            this.lblAccountValue.Text = "50000";
            // 
            // lblCashBaseValue
            // 
            this.lblCashBaseValue.AutoSize = true;
            this.lblCashBaseValue.Location = new System.Drawing.Point(295, 48);
            this.lblCashBaseValue.Name = "lblCashBaseValue";
            this.lblCashBaseValue.Size = new System.Drawing.Size(37, 13);
            this.lblCashBaseValue.TabIndex = 11;
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
            this.lblNbTurnInfo.Location = new System.Drawing.Point(215, 21);
            this.lblNbTurnInfo.Name = "lblNbTurnInfo";
            this.lblNbTurnInfo.Size = new System.Drawing.Size(44, 13);
            this.lblNbTurnInfo.TabIndex = 12;
            this.lblNbTurnInfo.Text = "Tour N°";
            // 
            // lblNbTurnValue
            // 
            this.lblNbTurnValue.AutoSize = true;
            this.lblNbTurnValue.Location = new System.Drawing.Point(298, 25);
            this.lblNbTurnValue.Name = "lblNbTurnValue";
            this.lblNbTurnValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbTurnValue.TabIndex = 13;
            this.lblNbTurnValue.Text = "0";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(198, 153);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(176, 23);
            this.btnStartStop.TabIndex = 14;
            this.btnStartStop.Text = "Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblNbWin
            // 
            this.lblNbWin.AutoSize = true;
            this.lblNbWin.Location = new System.Drawing.Point(30, 103);
            this.lblNbWin.Name = "lblNbWin";
            this.lblNbWin.Size = new System.Drawing.Size(48, 13);
            this.lblNbWin.TabIndex = 15;
            this.lblNbWin.Text = "Gagnant";
            // 
            // lblNbLose
            // 
            this.lblNbLose.AutoSize = true;
            this.lblNbLose.Location = new System.Drawing.Point(267, 103);
            this.lblNbLose.Name = "lblNbLose";
            this.lblNbLose.Size = new System.Drawing.Size(44, 13);
            this.lblNbLose.TabIndex = 16;
            this.lblNbLose.Text = "Perdant";
            // 
            // lblNbEqual
            // 
            this.lblNbEqual.AutoSize = true;
            this.lblNbEqual.Location = new System.Drawing.Point(153, 103);
            this.lblNbEqual.Name = "lblNbEqual";
            this.lblNbEqual.Size = new System.Drawing.Size(39, 13);
            this.lblNbEqual.TabIndex = 17;
            this.lblNbEqual.Text = "Egalité";
            // 
            // lblNbWinValue
            // 
            this.lblNbWinValue.AutoSize = true;
            this.lblNbWinValue.Location = new System.Drawing.Point(109, 103);
            this.lblNbWinValue.Name = "lblNbWinValue";
            this.lblNbWinValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbWinValue.TabIndex = 18;
            this.lblNbWinValue.Text = "0";
            // 
            // lblNbEqualValue
            // 
            this.lblNbEqualValue.AutoSize = true;
            this.lblNbEqualValue.Location = new System.Drawing.Point(223, 103);
            this.lblNbEqualValue.Name = "lblNbEqualValue";
            this.lblNbEqualValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbEqualValue.TabIndex = 19;
            this.lblNbEqualValue.Text = "0";
            // 
            // lblNbLoseValue
            // 
            this.lblNbLoseValue.AutoSize = true;
            this.lblNbLoseValue.Location = new System.Drawing.Point(342, 103);
            this.lblNbLoseValue.Name = "lblNbLoseValue";
            this.lblNbLoseValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbLoseValue.TabIndex = 20;
            this.lblNbLoseValue.Text = "0";
            // 
            // lblSabot
            // 
            this.lblSabot.AutoSize = true;
            this.lblSabot.Location = new System.Drawing.Point(143, 127);
            this.lblSabot.Name = "lblSabot";
            this.lblSabot.Size = new System.Drawing.Size(35, 13);
            this.lblSabot.TabIndex = 21;
            this.lblSabot.Text = "Sabot";
            // 
            // lblSabotValue
            // 
            this.lblSabotValue.AutoSize = true;
            this.lblSabotValue.Location = new System.Drawing.Point(231, 127);
            this.lblSabotValue.Name = "lblSabotValue";
            this.lblSabotValue.Size = new System.Drawing.Size(13, 13);
            this.lblSabotValue.TabIndex = 22;
            this.lblSabotValue.Text = "0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 188);
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
    }
}

