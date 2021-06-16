namespace Ibrahim.OnlineGames.UserControls
{
    partial class GuessObject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowWrong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGuess = new System.Windows.Forms.Label();
            this.flowCorrects = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.flowWrong, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowCorrects, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 21);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowWrong
            // 
            this.flowWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowWrong.Location = new System.Drawing.Point(194, 1);
            this.flowWrong.Margin = new System.Windows.Forms.Padding(1);
            this.flowWrong.Name = "flowWrong";
            this.flowWrong.Size = new System.Drawing.Size(129, 19);
            this.flowWrong.TabIndex = 2;
            // 
            // lblGuess
            // 
            this.lblGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuess.Location = new System.Drawing.Point(3, 0);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(58, 21);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "label1";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowCorrects
            // 
            this.flowCorrects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCorrects.Location = new System.Drawing.Point(65, 1);
            this.flowCorrects.Margin = new System.Windows.Forms.Padding(1);
            this.flowCorrects.Name = "flowCorrects";
            this.flowCorrects.Size = new System.Drawing.Size(127, 19);
            this.flowCorrects.TabIndex = 1;
            // 
            // GuessObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GuessObject";
            this.Size = new System.Drawing.Size(324, 21);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.FlowLayoutPanel flowCorrects;
        private System.Windows.Forms.FlowLayoutPanel flowWrong;
    }
}
