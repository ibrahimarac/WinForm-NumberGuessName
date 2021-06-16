namespace Ibrahim.OnlineGames
{
    partial class GameArea
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
            this.flowYourFriendArea = new System.Windows.Forms.FlowLayoutPanel();
            this.groupPartner = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupYou = new System.Windows.Forms.GroupBox();
            this.groupSendGuess = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowYourArea = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupGetGuess = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupPartner.SuspendLayout();
            this.groupYou.SuspendLayout();
            this.groupSendGuess.SuspendLayout();
            this.groupGetGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowYourFriendArea
            // 
            this.flowYourFriendArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowYourFriendArea.Location = new System.Drawing.Point(3, 22);
            this.flowYourFriendArea.Name = "flowYourFriendArea";
            this.flowYourFriendArea.Size = new System.Drawing.Size(465, 515);
            this.flowYourFriendArea.TabIndex = 1;
            // 
            // groupPartner
            // 
            this.groupPartner.BackColor = System.Drawing.Color.Transparent;
            this.groupPartner.Controls.Add(this.groupGetGuess);
            this.groupPartner.Controls.Add(this.flowYourFriendArea);
            this.groupPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupPartner.Location = new System.Drawing.Point(500, 36);
            this.groupPartner.Name = "groupPartner";
            this.groupPartner.Size = new System.Drawing.Size(471, 540);
            this.groupPartner.TabIndex = 3;
            this.groupPartner.TabStop = false;
            this.groupPartner.Text = "Your Partner Is Waiting...";
            this.groupPartner.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Number Is : ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Red;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(164, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(49, 20);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "1235";
            // 
            // groupYou
            // 
            this.groupYou.BackColor = System.Drawing.Color.Transparent;
            this.groupYou.Controls.Add(this.groupSendGuess);
            this.groupYou.Controls.Add(this.flowYourArea);
            this.groupYou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupYou.Location = new System.Drawing.Point(12, 36);
            this.groupYou.Name = "groupYou";
            this.groupYou.Size = new System.Drawing.Size(463, 540);
            this.groupYou.TabIndex = 2;
            this.groupYou.TabStop = false;
            // 
            // groupSendGuess
            // 
            this.groupSendGuess.Controls.Add(this.btnSend);
            this.groupSendGuess.Controls.Add(this.txtGuess);
            this.groupSendGuess.Controls.Add(this.label3);
            this.groupSendGuess.Location = new System.Drawing.Point(17, 460);
            this.groupSendGuess.Name = "groupSendGuess";
            this.groupSendGuess.Size = new System.Drawing.Size(430, 67);
            this.groupSendGuess.TabIndex = 1;
            this.groupSendGuess.TabStop = false;
            this.groupSendGuess.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Green;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(290, 25);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(161, 27);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 26);
            this.txtGuess.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Guess";
            // 
            // flowYourArea
            // 
            this.flowYourArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowYourArea.Location = new System.Drawing.Point(3, 22);
            this.flowYourArea.Name = "flowYourArea";
            this.flowYourArea.Size = new System.Drawing.Size(457, 515);
            this.flowYourArea.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupGetGuess
            // 
            this.groupGetGuess.Controls.Add(this.label4);
            this.groupGetGuess.Location = new System.Drawing.Point(20, 463);
            this.groupGetGuess.Name = "groupGetGuess";
            this.groupGetGuess.Size = new System.Drawing.Size(430, 63);
            this.groupGetGuess.TabIndex = 12;
            this.groupGetGuess.TabStop = false;
            this.groupGetGuess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your Partner Is Thinking";
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 582);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPartner);
            this.Controls.Add(this.groupYou);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numbers Game V 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameArea_FormClosing);
            this.groupPartner.ResumeLayout(false);
            this.groupYou.ResumeLayout(false);
            this.groupSendGuess.ResumeLayout(false);
            this.groupSendGuess.PerformLayout();
            this.groupGetGuess.ResumeLayout(false);
            this.groupGetGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowYourFriendArea;
        private System.Windows.Forms.GroupBox groupPartner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox groupYou;
        private System.Windows.Forms.GroupBox groupSendGuess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowYourArea;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupGetGuess;
        private System.Windows.Forms.Label label4;
    }
}

