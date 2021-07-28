namespace TwoCardPokerChallenge
{
    partial class TwoCardPoker
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfTimes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundNumber = new System.Windows.Forms.TextBox();
            this.ShuffleDeck = new System.Windows.Forms.Button();
            this.welcomeDealer = new System.Windows.Forms.Label();
            this.DealCard = new System.Windows.Forms.Button();
            this.DisplayResult = new System.Windows.Forms.RichTextBox();
            this.reStart = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameRounds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfPlayers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(40, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHUFFLE CARDS";
            // 
            // numberOfTimes
            // 
            this.numberOfTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTimes.Location = new System.Drawing.Point(240, 151);
            this.numberOfTimes.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfTimes.Name = "numberOfTimes";
            this.numberOfTimes.Size = new System.Drawing.Size(143, 30);
            this.numberOfTimes.TabIndex = 1;
            this.numberOfTimes.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(731, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRESENT ROUND";
            // 
            // roundNumber
            // 
            this.roundNumber.Enabled = false;
            this.roundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNumber.Location = new System.Drawing.Point(929, 26);
            this.roundNumber.Margin = new System.Windows.Forms.Padding(4);
            this.roundNumber.Name = "roundNumber";
            this.roundNumber.Size = new System.Drawing.Size(76, 30);
            this.roundNumber.TabIndex = 3;
            this.roundNumber.Text = "0";
            // 
            // ShuffleDeck
            // 
            this.ShuffleDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShuffleDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShuffleDeck.ForeColor = System.Drawing.Color.Maroon;
            this.ShuffleDeck.Location = new System.Drawing.Point(419, 145);
            this.ShuffleDeck.Margin = new System.Windows.Forms.Padding(4);
            this.ShuffleDeck.Name = "ShuffleDeck";
            this.ShuffleDeck.Size = new System.Drawing.Size(158, 45);
            this.ShuffleDeck.TabIndex = 4;
            this.ShuffleDeck.Text = "ShuffleDeck";
            this.ShuffleDeck.UseVisualStyleBackColor = false;
            this.ShuffleDeck.Click += new System.EventHandler(this.ShuffleDeck_Click);
            // 
            // welcomeDealer
            // 
            this.welcomeDealer.AutoSize = true;
            this.welcomeDealer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcomeDealer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeDealer.ForeColor = System.Drawing.Color.Maroon;
            this.welcomeDealer.Location = new System.Drawing.Point(254, 29);
            this.welcomeDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeDealer.Name = "welcomeDealer";
            this.welcomeDealer.Size = new System.Drawing.Size(292, 27);
            this.welcomeDealer.TabIndex = 5;
            this.welcomeDealer.Text = "HELLO DEALER WELCOME";
            // 
            // DealCard
            // 
            this.DealCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DealCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealCard.ForeColor = System.Drawing.Color.Maroon;
            this.DealCard.Location = new System.Drawing.Point(655, 143);
            this.DealCard.Margin = new System.Windows.Forms.Padding(4);
            this.DealCard.Name = "DealCard";
            this.DealCard.Size = new System.Drawing.Size(159, 49);
            this.DealCard.TabIndex = 6;
            this.DealCard.Text = "DEAL CARDS";
            this.DealCard.UseVisualStyleBackColor = false;
            this.DealCard.Visible = false;
            this.DealCard.Click += new System.EventHandler(this.DealCard_Click);
            // 
            // DisplayResult
            // 
            this.DisplayResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayResult.ForeColor = System.Drawing.Color.Black;
            this.DisplayResult.Location = new System.Drawing.Point(1, 264);
            this.DisplayResult.Name = "DisplayResult";
            this.DisplayResult.Size = new System.Drawing.Size(1196, 561);
            this.DisplayResult.TabIndex = 7;
            this.DisplayResult.Text = "";
            this.DisplayResult.TextChanged += new System.EventHandler(this.DisplayResult_TextChanged);
            // 
            // reStart
            // 
            this.reStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reStart.ForeColor = System.Drawing.Color.Maroon;
            this.reStart.Location = new System.Drawing.Point(874, 145);
            this.reStart.Name = "reStart";
            this.reStart.Size = new System.Drawing.Size(152, 47);
            this.reStart.TabIndex = 8;
            this.reStart.Text = "RESTART";
            this.reStart.UseVisualStyleBackColor = false;
            this.reStart.Click += new System.EventHandler(this.ReStart_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Enabled = false;
            this.errorMessage.Location = new System.Drawing.Point(160, 218);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(39, 17);
            this.errorMessage.TabIndex = 9;
            this.errorMessage.Text = "error";
            this.errorMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "GAME ROUNDS";
            // 
            // gameRounds
            // 
            this.gameRounds.Enabled = false;
            this.gameRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRounds.Location = new System.Drawing.Point(240, 86);
            this.gameRounds.Name = "gameRounds";
            this.gameRounds.Size = new System.Drawing.Size(143, 30);
            this.gameRounds.TabIndex = 11;
            this.gameRounds.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(433, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "NUMBER OF PLAYERS";
            // 
            // numOfPlayers
            // 
            this.numOfPlayers.Enabled = false;
            this.numOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPlayers.Location = new System.Drawing.Point(727, 83);
            this.numOfPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.numOfPlayers.Name = "numOfPlayers";
            this.numOfPlayers.Size = new System.Drawing.Size(100, 30);
            this.numOfPlayers.TabIndex = 3;
            this.numOfPlayers.Text = "0";
            // 
            // TwoCardPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1197, 826);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameRounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.reStart);
            this.Controls.Add(this.DisplayResult);
            this.Controls.Add(this.DealCard);
            this.Controls.Add(this.welcomeDealer);
            this.Controls.Add(this.ShuffleDeck);
            this.Controls.Add(this.numOfPlayers);
            this.Controls.Add(this.roundNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfTimes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwoCardPoker";
            this.Text = "Two Card Poker Game";
            this.Load += new System.EventHandler(this.TwoCardPoker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roundNumber;
        private System.Windows.Forms.Button ShuffleDeck;
        private System.Windows.Forms.Label welcomeDealer;
        private System.Windows.Forms.Button DealCard;
        private System.Windows.Forms.RichTextBox DisplayResult;
        private System.Windows.Forms.Button reStart;
        public System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameRounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numOfPlayers;
    }
}

