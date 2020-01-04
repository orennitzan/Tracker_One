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
            this.numUpDwn = new System.Windows.Forms.NumericUpDown();
            this.lblNSteps = new System.Windows.Forms.Label();
            this.chkBxList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownIntervals = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIntervals)).BeginInit();
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
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(23, 507);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 20);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // numUpDwn
            // 
            this.numUpDwn.Location = new System.Drawing.Point(23, 401);
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
            this.numUpDwn.ValueChanged += new System.EventHandler(this.numUpDwn_ValueChanged);
            // 
            // lblNSteps
            // 
            this.lblNSteps.AutoSize = true;
            this.lblNSteps.Location = new System.Drawing.Point(23, 382);
            this.lblNSteps.Name = "lblNSteps";
            this.lblNSteps.Size = new System.Drawing.Size(96, 13);
            this.lblNSteps.TabIndex = 6;
            this.lblNSteps.Text = "History Steps (1-5):";
            // 
            // chkBxList
            // 
            this.chkBxList.AutoSize = true;
            this.chkBxList.Location = new System.Drawing.Point(23, 30);
            this.chkBxList.Name = "chkBxList";
            this.chkBxList.Size = new System.Drawing.Size(120, 200);
            this.chkBxList.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movenemt Intervals (ms)";
            // 
            // numUpDownIntervals
            // 
            this.numUpDownIntervals.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownIntervals.Location = new System.Drawing.Point(23, 450);
            this.numUpDownIntervals.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDownIntervals.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownIntervals.Name = "numUpDownIntervals";
            this.numUpDownIntervals.Size = new System.Drawing.Size(120, 20);
            this.numUpDownIntervals.TabIndex = 8;
            this.numUpDownIntervals.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownIntervals.ValueChanged += new System.EventHandler(this.numUpDownIntervals_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownIntervals);
            this.Controls.Add(this.chkBxList);
            this.Controls.Add(this.lblNSteps);
            this.Controls.Add(this.numUpDwn);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Tracker One";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIntervals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numUpDwn;
        private System.Windows.Forms.Label lblNSteps;
        private System.Windows.Forms.Panel chkBxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownIntervals;
    }
}