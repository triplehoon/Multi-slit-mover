namespace Multi_slit_mover
{
    partial class Form1
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
            this.btInitMotor = new System.Windows.Forms.Button();
            this.TbDebugConsole = new System.Windows.Forms.TextBox();
            this.LbConnection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NudX = new System.Windows.Forms.NumericUpDown();
            this.NudY = new System.Windows.Forms.NumericUpDown();
            this.NudZ = new System.Windows.Forms.NumericUpDown();
            this.NudS = new System.Windows.Forms.NumericUpDown();
            this.NudT = new System.Windows.Forms.NumericUpDown();
            this.NudP = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.BtMoveMotor = new System.Windows.Forms.Button();
            this.LbCurrentX = new System.Windows.Forms.Label();
            this.LbCurrentY = new System.Windows.Forms.Label();
            this.LbCurrentZ = new System.Windows.Forms.Label();
            this.LbCurrentSwivel = new System.Windows.Forms.Label();
            this.LbCurrentTilt = new System.Windows.Forms.Label();
            this.LbCurrentPivot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudP)).BeginInit();
            this.SuspendLayout();
            // 
            // btInitMotor
            // 
            this.btInitMotor.Location = new System.Drawing.Point(44, 96);
            this.btInitMotor.Name = "btInitMotor";
            this.btInitMotor.Size = new System.Drawing.Size(146, 47);
            this.btInitMotor.TabIndex = 0;
            this.btInitMotor.Text = "Initiate Motor";
            this.btInitMotor.UseVisualStyleBackColor = true;
            this.btInitMotor.Click += new System.EventHandler(this.btInitMotor_Click);
            // 
            // TbDebugConsole
            // 
            this.TbDebugConsole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TbDebugConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TbDebugConsole.Enabled = false;
            this.TbDebugConsole.Location = new System.Drawing.Point(44, 369);
            this.TbDebugConsole.Multiline = true;
            this.TbDebugConsole.Name = "TbDebugConsole";
            this.TbDebugConsole.ReadOnly = true;
            this.TbDebugConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbDebugConsole.Size = new System.Drawing.Size(646, 297);
            this.TbDebugConsole.TabIndex = 1;
            this.TbDebugConsole.TextChanged += new System.EventHandler(this.TbDebugConsole_TextChanged);
            // 
            // LbConnection
            // 
            this.LbConnection.AutoSize = true;
            this.LbConnection.Location = new System.Drawing.Point(218, 113);
            this.LbConnection.Name = "LbConnection";
            this.LbConnection.Size = new System.Drawing.Size(38, 12);
            this.LbConnection.TabIndex = 2;
            this.LbConnection.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "SWIVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "TILT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "PIVOT";
            // 
            // NudX
            // 
            this.NudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudX.Location = new System.Drawing.Point(44, 220);
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(74, 21);
            this.NudX.TabIndex = 5;
            // 
            // NudY
            // 
            this.NudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudY.Location = new System.Drawing.Point(150, 220);
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(74, 21);
            this.NudY.TabIndex = 5;
            // 
            // NudZ
            // 
            this.NudZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudZ.Location = new System.Drawing.Point(256, 220);
            this.NudZ.Name = "NudZ";
            this.NudZ.Size = new System.Drawing.Size(74, 21);
            this.NudZ.TabIndex = 5;
            // 
            // NudS
            // 
            this.NudS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudS.Location = new System.Drawing.Point(362, 220);
            this.NudS.Name = "NudS";
            this.NudS.Size = new System.Drawing.Size(74, 21);
            this.NudS.TabIndex = 5;
            // 
            // NudT
            // 
            this.NudT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudT.Location = new System.Drawing.Point(468, 220);
            this.NudT.Name = "NudT";
            this.NudT.Size = new System.Drawing.Size(74, 21);
            this.NudT.TabIndex = 5;
            // 
            // NudP
            // 
            this.NudP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudP.Location = new System.Drawing.Point(574, 220);
            this.NudP.Name = "NudP";
            this.NudP.Size = new System.Drawing.Size(74, 21);
            this.NudP.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Position";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtMoveMotor
            // 
            this.BtMoveMotor.Enabled = false;
            this.BtMoveMotor.Location = new System.Drawing.Point(654, 220);
            this.BtMoveMotor.Name = "BtMoveMotor";
            this.BtMoveMotor.Size = new System.Drawing.Size(96, 21);
            this.BtMoveMotor.TabIndex = 7;
            this.BtMoveMotor.Text = "Move Motor";
            this.BtMoveMotor.UseVisualStyleBackColor = true;
            this.BtMoveMotor.Click += new System.EventHandler(this.BtMoveMotor_Click);
            // 
            // LbCurrentX
            // 
            this.LbCurrentX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentX.Location = new System.Drawing.Point(44, 301);
            this.LbCurrentX.Name = "LbCurrentX";
            this.LbCurrentX.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentX.TabIndex = 8;
            this.LbCurrentX.Text = "label8";
            this.LbCurrentX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentX.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // LbCurrentY
            // 
            this.LbCurrentY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentY.Location = new System.Drawing.Point(148, 301);
            this.LbCurrentY.Name = "LbCurrentY";
            this.LbCurrentY.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentY.TabIndex = 8;
            this.LbCurrentY.Text = "label8";
            this.LbCurrentY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentY.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // LbCurrentZ
            // 
            this.LbCurrentZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentZ.Location = new System.Drawing.Point(254, 301);
            this.LbCurrentZ.Name = "LbCurrentZ";
            this.LbCurrentZ.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentZ.TabIndex = 8;
            this.LbCurrentZ.Text = "label8";
            this.LbCurrentZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentZ.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // LbCurrentSwivel
            // 
            this.LbCurrentSwivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentSwivel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentSwivel.Location = new System.Drawing.Point(360, 301);
            this.LbCurrentSwivel.Name = "LbCurrentSwivel";
            this.LbCurrentSwivel.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentSwivel.TabIndex = 8;
            this.LbCurrentSwivel.Text = "label8";
            this.LbCurrentSwivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentSwivel.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // LbCurrentTilt
            // 
            this.LbCurrentTilt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentTilt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentTilt.Location = new System.Drawing.Point(466, 301);
            this.LbCurrentTilt.Name = "LbCurrentTilt";
            this.LbCurrentTilt.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentTilt.TabIndex = 8;
            this.LbCurrentTilt.Text = "label8";
            this.LbCurrentTilt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentTilt.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // LbCurrentPivot
            // 
            this.LbCurrentPivot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCurrentPivot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbCurrentPivot.Location = new System.Drawing.Point(572, 301);
            this.LbCurrentPivot.Name = "LbCurrentPivot";
            this.LbCurrentPivot.Size = new System.Drawing.Size(74, 23);
            this.LbCurrentPivot.TabIndex = 8;
            this.LbCurrentPivot.Text = "label8";
            this.LbCurrentPivot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbCurrentPivot.Click += new System.EventHandler(this.LbCurrentX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 687);
            this.Controls.Add(this.LbCurrentPivot);
            this.Controls.Add(this.LbCurrentTilt);
            this.Controls.Add(this.LbCurrentSwivel);
            this.Controls.Add(this.LbCurrentZ);
            this.Controls.Add(this.LbCurrentY);
            this.Controls.Add(this.LbCurrentX);
            this.Controls.Add(this.BtMoveMotor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudP);
            this.Controls.Add(this.NudT);
            this.Controls.Add(this.NudS);
            this.Controls.Add(this.NudZ);
            this.Controls.Add(this.NudY);
            this.Controls.Add(this.NudX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbConnection);
            this.Controls.Add(this.TbDebugConsole);
            this.Controls.Add(this.btInitMotor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInitMotor;
        private System.Windows.Forms.TextBox TbDebugConsole;
        private System.Windows.Forms.Label LbConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudX;
        private System.Windows.Forms.NumericUpDown NudY;
        private System.Windows.Forms.NumericUpDown NudZ;
        private System.Windows.Forms.NumericUpDown NudS;
        private System.Windows.Forms.NumericUpDown NudT;
        private System.Windows.Forms.NumericUpDown NudP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtMoveMotor;
        private System.Windows.Forms.Label LbCurrentX;
        private System.Windows.Forms.Label LbCurrentY;
        private System.Windows.Forms.Label LbCurrentZ;
        private System.Windows.Forms.Label LbCurrentSwivel;
        private System.Windows.Forms.Label LbCurrentTilt;
        private System.Windows.Forms.Label LbCurrentPivot;
    }
}

