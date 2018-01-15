namespace BlackJack
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.gbxPlay = new System.Windows.Forms.GroupBox();
            this.lblNbTurn = new System.Windows.Forms.Label();
            this.lblNbTurnValue = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPausePlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.playerProUC = new BlackJack.UserControls.PlayerProUC();
            this.gbxPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 1000;
            this.tmrTurn.Tick += new System.EventHandler(this.tmrTurn_Tick);
            // 
            // gbxPlay
            // 
            this.gbxPlay.Controls.Add(this.btnLast);
            this.gbxPlay.Controls.Add(this.btnNext);
            this.gbxPlay.Controls.Add(this.btnPausePlay);
            this.gbxPlay.Controls.Add(this.btnPrevious);
            this.gbxPlay.Controls.Add(this.btnFirst);
            this.gbxPlay.Location = new System.Drawing.Point(214, 32);
            this.gbxPlay.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPlay.Name = "gbxPlay";
            this.gbxPlay.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPlay.Size = new System.Drawing.Size(138, 33);
            this.gbxPlay.TabIndex = 0;
            this.gbxPlay.TabStop = false;
            // 
            // lblNbTurn
            // 
            this.lblNbTurn.AutoSize = true;
            this.lblNbTurn.Location = new System.Drawing.Point(357, 45);
            this.lblNbTurn.Name = "lblNbTurn";
            this.lblNbTurn.Size = new System.Drawing.Size(44, 13);
            this.lblNbTurn.TabIndex = 5;
            this.lblNbTurn.Text = "Tour N°";
            // 
            // lblNbTurnValue
            // 
            this.lblNbTurnValue.AutoSize = true;
            this.lblNbTurnValue.Location = new System.Drawing.Point(407, 45);
            this.lblNbTurnValue.Name = "lblNbTurnValue";
            this.lblNbTurnValue.Size = new System.Drawing.Size(13, 13);
            this.lblNbTurnValue.TabIndex = 6;
            this.lblNbTurnValue.Text = "0";
            // 
            // btnLast
            // 
            this.btnLast.Image = global::BlackJack.Properties.Resources.Last;
            this.btnLast.Location = new System.Drawing.Point(108, 10);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(22, 19);
            this.btnLast.TabIndex = 4;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::BlackJack.Properties.Resources.Next;
            this.btnNext.Location = new System.Drawing.Point(82, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(22, 19);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.Image = global::BlackJack.Properties.Resources.Pause;
            this.btnPausePlay.Location = new System.Drawing.Point(56, 10);
            this.btnPausePlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Size = new System.Drawing.Size(22, 19);
            this.btnPausePlay.TabIndex = 2;
            this.btnPausePlay.UseVisualStyleBackColor = true;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::BlackJack.Properties.Resources.Previous;
            this.btnPrevious.Location = new System.Drawing.Point(30, 10);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(22, 19);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::BlackJack.Properties.Resources.First;
            this.btnFirst.Location = new System.Drawing.Point(4, 10);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(22, 19);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // playerProUC
            // 
            this.playerProUC.Location = new System.Drawing.Point(12, 9);
            this.playerProUC.Name = "playerProUC";
            this.playerProUC.Size = new System.Drawing.Size(162, 72);
            this.playerProUC.TabIndex = 7;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(528, 206);
            this.Controls.Add(this.playerProUC);
            this.Controls.Add(this.lblNbTurnValue);
            this.Controls.Add(this.lblNbTurn);
            this.Controls.Add(this.gbxPlay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGame";
            this.Text = "Jeux";
            this.gbxPlay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTurn;
        private System.Windows.Forms.GroupBox gbxPlay;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblNbTurn;
        private System.Windows.Forms.Label lblNbTurnValue;
        private UserControls.PlayerProUC playerProUC;
    }
}