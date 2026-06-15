namespace SlotMachineMaddness2026
{
    partial class MainForm
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
            btnMin = new Button();
            btnMax = new Button();
            lblMoney = new Label();
            lblCurrent = new Label();
            lblSlot1 = new Label();
            lblSlot2 = new Label();
            lblSlot3 = new Label();
            lblResult = new Label();
            btnSpin = new Button();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatStyle = FlatStyle.Popup;
            btnMin.Location = new Point(521, 467);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(103, 31);
            btnMin.TabIndex = 0;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Transparent;
            btnMax.Cursor = Cursors.Hand;
            btnMax.FlatStyle = FlatStyle.Popup;
            btnMax.Location = new Point(643, 466);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(107, 31);
            btnMax.TabIndex = 1;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.BackColor = Color.Transparent;
            lblMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.ForeColor = Color.Yellow;
            lblMoney.Location = new Point(78, 479);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(14, 15);
            lblMoney.TabIndex = 2;
            lblMoney.Text = "$";
            lblMoney.Click += lblMoney_Click;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.BackColor = Color.Transparent;
            lblCurrent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.ForeColor = Color.Yellow;
            lblCurrent.Location = new Point(362, 393);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(14, 15);
            lblCurrent.TabIndex = 3;
            lblCurrent.Text = "$";
            lblCurrent.Click += lblCurrent_Click;
            // 
            // lblSlot1
            // 
            lblSlot1.AutoSize = true;
            lblSlot1.BackColor = Color.Transparent;
            lblSlot1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblSlot1.ForeColor = Color.Red;
            lblSlot1.Location = new Point(273, 290);
            lblSlot1.Name = "lblSlot1";
            lblSlot1.Size = new Size(22, 30);
            lblSlot1.TabIndex = 4;
            lblSlot1.Text = "?";
            lblSlot1.Click += lblSlot1_Click;
            // 
            // lblSlot2
            // 
            lblSlot2.AutoSize = true;
            lblSlot2.BackColor = Color.Transparent;
            lblSlot2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblSlot2.ForeColor = Color.Red;
            lblSlot2.Location = new Point(370, 292);
            lblSlot2.Name = "lblSlot2";
            lblSlot2.Size = new Size(22, 30);
            lblSlot2.TabIndex = 5;
            lblSlot2.Text = "?";
            lblSlot2.Click += lblSlot2_Click;
            // 
            // lblSlot3
            // 
            lblSlot3.AutoSize = true;
            lblSlot3.BackColor = Color.Transparent;
            lblSlot3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblSlot3.ForeColor = Color.Red;
            lblSlot3.Location = new Point(469, 292);
            lblSlot3.Name = "lblSlot3";
            lblSlot3.Size = new Size(22, 30);
            lblSlot3.TabIndex = 6;
            lblSlot3.Text = "?";
            lblSlot3.Click += lblSlot3_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(300, 170);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(162, 29);
            lblResult.TabIndex = 7;
            lblResult.Text = "WILL YOU WIN?!";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = Color.Transparent;
            btnSpin.Cursor = Cursors.Hand;
            btnSpin.FlatStyle = FlatStyle.Popup;
            btnSpin.Location = new Point(561, 199);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(49, 45);
            btnSpin.TabIndex = 8;
            btnSpin.UseVisualStyleBackColor = false;
            btnSpin.Click += btnSpin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SlotMachineMaddness;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(771, 521);
            Controls.Add(btnSpin);
            Controls.Add(lblResult);
            Controls.Add(lblSlot3);
            Controls.Add(lblSlot2);
            Controls.Add(lblSlot1);
            Controls.Add(lblCurrent);
            Controls.Add(lblMoney);
            Controls.Add(btnMax);
            Controls.Add(btnMin);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "SlotMachineMaddness!";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnMax;
        private Label lblSlot1;
        private Label lblSlot2;
        private Label lblSlot3;
        private Label lblMoney;
        private Label lblCurrent;
        private Label lblResult;
        private Button btnSpin;
    }
}
