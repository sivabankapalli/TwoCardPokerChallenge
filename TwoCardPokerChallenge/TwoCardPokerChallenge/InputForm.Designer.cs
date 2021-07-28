namespace TwoCardPokerChallenge
{
    partial class InputForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfPlayers = new System.Windows.Forms.TextBox();
            this.numberOfRounds = new System.Windows.Forms.TextBox();
            this.gameStart = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.welcomeDealer = new System.Windows.Forms.Label();
            this.Note1 = new System.Windows.Forms.Label();
            this.Note2 = new System.Windows.Forms.Label();
            this.inputError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(34, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number Of Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Number Of Rounds";
            // 
            // numberOfPlayers
            // 
            this.numberOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPlayers.Location = new System.Drawing.Point(253, 129);
            this.numberOfPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfPlayers.Name = "numberOfPlayers";
            this.numberOfPlayers.Size = new System.Drawing.Size(155, 30);
            this.numberOfPlayers.TabIndex = 2;
            this.numberOfPlayers.Text = "0";
            // 
            // numberOfRounds
            // 
            this.numberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRounds.Location = new System.Drawing.Point(253, 43);
            this.numberOfRounds.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfRounds.Name = "numberOfRounds";
            this.numberOfRounds.Size = new System.Drawing.Size(155, 30);
            this.numberOfRounds.TabIndex = 2;
            this.numberOfRounds.Text = "0";
            // 
            // gameStart
            // 
            this.gameStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gameStart.Location = new System.Drawing.Point(38, 210);
            this.gameStart.Margin = new System.Windows.Forms.Padding(4);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(169, 41);
            this.gameStart.TabIndex = 3;
            this.gameStart.Text = "START GAME";
            this.gameStart.UseVisualStyleBackColor = false;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancel.Location = new System.Drawing.Point(240, 210);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(155, 41);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // welcomeDealer
            // 
            this.welcomeDealer.AutoSize = true;
            this.welcomeDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeDealer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcomeDealer.Location = new System.Drawing.Point(124, 9);
            this.welcomeDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeDealer.Name = "welcomeDealer";
            this.welcomeDealer.Size = new System.Drawing.Size(262, 20);
            this.welcomeDealer.TabIndex = 4;
            this.welcomeDealer.Text = "WELCOME TO POKER GAME";
            // 
            // Note1
            // 
            this.Note1.AutoSize = true;
            this.Note1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Note1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note1.ForeColor = System.Drawing.Color.Maroon;
            this.Note1.Location = new System.Drawing.Point(58, 160);
            this.Note1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(116, 18);
            this.Note1.TabIndex = 5;
            this.Note1.Text = "(Between 2 to 6)";
            // 
            // Note2
            // 
            this.Note2.AutoSize = true;
            this.Note2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Note2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note2.ForeColor = System.Drawing.Color.Maroon;
            this.Note2.Location = new System.Drawing.Point(71, 74);
            this.Note2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Note2.Name = "Note2";
            this.Note2.Size = new System.Drawing.Size(116, 18);
            this.Note2.TabIndex = 5;
            this.Note2.Text = "(Between 2 to 5)";
            // 
            // inputError
            // 
            this.inputError.AutoSize = true;
            this.inputError.BackColor = System.Drawing.Color.Red;
            this.inputError.Enabled = false;
            this.inputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputError.Location = new System.Drawing.Point(12, 277);
            this.inputError.Name = "inputError";
            this.inputError.Size = new System.Drawing.Size(50, 20);
            this.inputError.TabIndex = 6;
            this.inputError.Text = "error";
            this.inputError.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 342);
            this.Controls.Add(this.inputError);
            this.Controls.Add(this.Note2);
            this.Controls.Add(this.Note1);
            this.Controls.Add(this.welcomeDealer);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.numberOfRounds);
            this.Controls.Add(this.numberOfPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfPlayers;
        private System.Windows.Forms.TextBox numberOfRounds;
        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label welcomeDealer;
        private System.Windows.Forms.Label Note1;
        private System.Windows.Forms.Label Note2;
        private System.Windows.Forms.Label inputError;
    }
}