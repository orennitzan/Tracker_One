namespace Tracker_One_View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkBxList = new System.Windows.Forms.CheckedListBox();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.numUpDwn = new System.Windows.Forms.NumericUpDown();
            this.lblNSteps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 478);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 20);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(23, 507);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 20);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // chkBxList
            // 
            this.chkBxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkBxList.FormattingEnabled = true;
            this.chkBxList.Location = new System.Drawing.Point(23, 33);
            this.chkBxList.Name = "chkBxList";
            this.chkBxList.Size = new System.Drawing.Size(120, 345);
            this.chkBxList.TabIndex = 3;
            // 
            // picBoard
            // 
            this.picBoard.Image = global::Tracker_One_View.Properties.Resources.board;
            this.picBoard.Location = new System.Drawing.Point(200, 30);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(500, 500);
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            // 
            // numUpDwn
            // 
            this.numUpDwn.Location = new System.Drawing.Point(23, 424);
            this.numUpDwn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDwn.Name = "numUpDwn";
            this.numUpDwn.Size = new System.Drawing.Size(120, 20);
            this.numUpDwn.TabIndex = 5;
            this.numUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNSteps
            // 
            this.lblNSteps.AutoSize = true;
            this.lblNSteps.Location = new System.Drawing.Point(23, 405);
            this.lblNSteps.Name = "lblNSteps";
            this.lblNSteps.Size = new System.Drawing.Size(96, 13);
            this.lblNSteps.TabIndex = 6;
            this.lblNSteps.Text = "History Steps (1-5):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblNSteps);
            this.Controls.Add(this.numUpDwn);
            this.Controls.Add(this.chkBxList);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Tracker One";
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckedListBox chkBxList;
        private System.Windows.Forms.NumericUpDown numUpDwn;
        private System.Windows.Forms.Label lblNSteps;
    }
}