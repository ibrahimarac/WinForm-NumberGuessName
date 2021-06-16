namespace Ibrahim.OnlineGames.Room
{
    partial class SelectRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupSendGuess = new System.Windows.Forms.GroupBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgRoomList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnJoinRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupSendGuess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupSendGuess);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgRoomList);
            this.groupBox1.Controls.Add(this.btnCreateRoom);
            this.groupBox1.Controls.Add(this.btnJoinRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Room From List";
            // 
            // groupSendGuess
            // 
            this.groupSendGuess.Controls.Add(this.txtGuess);
            this.groupSendGuess.Controls.Add(this.label3);
            this.groupSendGuess.Location = new System.Drawing.Point(15, 411);
            this.groupSendGuess.Name = "groupSendGuess";
            this.groupSendGuess.Size = new System.Drawing.Size(381, 84);
            this.groupSendGuess.TabIndex = 9;
            this.groupSendGuess.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(189, 34);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 24);
            this.txtGuess.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Number";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(276, 502);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 39);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgRoomList
            // 
            this.dgRoomList.AllowUserToAddRows = false;
            this.dgRoomList.AllowUserToDeleteRows = false;
            this.dgRoomList.AllowUserToResizeColumns = false;
            this.dgRoomList.AllowUserToResizeRows = false;
            this.dgRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgRoomList.Location = new System.Drawing.Point(15, 35);
            this.dgRoomList.MultiSelect = false;
            this.dgRoomList.Name = "dgRoomList";
            this.dgRoomList.ReadOnly = true;
            this.dgRoomList.RowHeadersVisible = false;
            this.dgRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoomList.Size = new System.Drawing.Size(381, 344);
            this.dgRoomList.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomName";
            this.Column1.HeaderText = "Room Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "Connected User";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.Color.Green;
            this.btnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateRoom.ForeColor = System.Drawing.Color.White;
            this.btnCreateRoom.Location = new System.Drawing.Point(135, 502);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(135, 39);
            this.btnCreateRoom.TabIndex = 6;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.BackColor = System.Drawing.Color.Green;
            this.btnJoinRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJoinRoom.ForeColor = System.Drawing.Color.White;
            this.btnJoinRoom.Location = new System.Drawing.Point(15, 501);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(114, 39);
            this.btnJoinRoom.TabIndex = 5;
            this.btnJoinRoom.Text = "Join Room";
            this.btnJoinRoom.UseVisualStyleBackColor = false;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // SelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ibrahim.OnlineGames.Properties.Resources.login_sign_in;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 575);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Room";
            this.Activated += new System.EventHandler(this.SelectRoom_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupSendGuess.ResumeLayout(false);
            this.groupSendGuess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnJoinRoom;
        private System.Windows.Forms.DataGridView dgRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupSendGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label3;
    }
}