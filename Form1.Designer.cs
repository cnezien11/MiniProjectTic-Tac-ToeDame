namespace MiniProjectTic_Tac_ToeDame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1 = new Button();
            panelBoard = new Panel();
            btnReset = new Button();
            txtStatus = new TextBox();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            txtHeader = new TextBox();
            panelBoard.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.DodgerBlue;
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(40, 37);
            btn1.Name = "btn1";
            btn1.Size = new Size(48, 42);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // panelBoard
            // 
            panelBoard.BackColor = Color.SaddleBrown;
            panelBoard.Controls.Add(btnReset);
            panelBoard.Controls.Add(txtStatus);
            panelBoard.Controls.Add(btn9);
            panelBoard.Controls.Add(btn8);
            panelBoard.Controls.Add(btn7);
            panelBoard.Controls.Add(btn6);
            panelBoard.Controls.Add(btn5);
            panelBoard.Controls.Add(btn4);
            panelBoard.Controls.Add(btn3);
            panelBoard.Controls.Add(btn2);
            panelBoard.Controls.Add(btn1);
            panelBoard.Location = new Point(241, 98);
            panelBoard.Name = "panelBoard";
            panelBoard.Size = new Size(258, 248);
            panelBoard.TabIndex = 1;
            panelBoard.Paint += panelBoard_Paint;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 0, 0);
            btnReset.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(91, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 31);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.InactiveBorder;
            txtStatus.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(40, 204);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(178, 26);
            txtStatus.TabIndex = 9;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // btn9
            // 
            btn9.BackColor = Color.SlateGray;
            btn9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(169, 149);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 39);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.SlateGray;
            btn8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(106, 149);
            btn8.Name = "btn8";
            btn8.Size = new Size(48, 39);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.SlateGray;
            btn7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(40, 149);
            btn7.Name = "btn7";
            btn7.Size = new Size(48, 39);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightSeaGreen;
            btn6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(169, 96);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 38);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightSeaGreen;
            btn5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(107, 96);
            btn5.Name = "btn5";
            btn5.Size = new Size(48, 38);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightSeaGreen;
            btn4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(40, 96);
            btn4.Name = "btn4";
            btn4.Size = new Size(48, 38);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DodgerBlue;
            btn3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(169, 37);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 42);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DodgerBlue;
            btn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(107, 37);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 42);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // txtHeader
            // 
            txtHeader.BackColor = Color.PeachPuff;
            txtHeader.BorderStyle = BorderStyle.None;
            txtHeader.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHeader.Location = new Point(235, 27);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(264, 36);
            txtHeader.TabIndex = 2;
            txtHeader.Text = "LET THE FUN BEGIN!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(725, 450);
            Controls.Add(txtHeader);
            Controls.Add(panelBoard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIC-TAC-TOE";
            panelBoard.ResumeLayout(false);
            panelBoard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Panel panelBoard;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private TextBox txtStatus;
        private Button btnReset;
        private TextBox txtHeader;
    }
}
