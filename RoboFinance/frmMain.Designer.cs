namespace RoboFinance
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            txtResponse = new TextBox();
            label1 = new Label();
            lbCount = new Label();
            label3 = new Label();
            cboTimer = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 9);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(143, 58);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResponse
            // 
            txtResponse.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResponse.Location = new Point(9, 77);
            txtResponse.Margin = new Padding(5);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(457, 221);
            txtResponse.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(206, 42);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 4;
            label1.Text = "Count APi response:";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCount.ForeColor = Color.FromArgb(64, 64, 64);
            lbCount.Location = new Point(389, 42);
            lbCount.Margin = new Padding(5, 0, 5, 0);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(23, 25);
            lbCount.TabIndex = 5;
            lbCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(206, 9);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 23);
            label3.TabIndex = 6;
            label3.Text = "Timer Response(mls):";
            // 
            // cboTimer
            // 
            cboTimer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboTimer.ForeColor = Color.FromArgb(64, 64, 64);
            cboTimer.FormattingEnabled = true;
            cboTimer.Items.AddRange(new object[] { "200", "500", "700", "1000" });
            cboTimer.Location = new Point(389, 9);
            cboTimer.Name = "cboTimer";
            cboTimer.Size = new Size(77, 28);
            cboTimer.TabIndex = 7;
            cboTimer.Text = "500";
            cboTimer.SelectedIndexChanged += cboTimer_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(475, 307);
            Controls.Add(cboTimer);
            Controls.Add(label3);
            Controls.Add(lbCount);
            Controls.Add(label1);
            Controls.Add(txtResponse);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Blue;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "frmMain";
            Text = "Robô Finance";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtResponse;
        private Label label1;
        private Label lbCount;
        private Label label3;
        private ComboBox cboTimer;
        private System.Windows.Forms.Timer timer1;
    }
}