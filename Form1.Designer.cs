namespace CalculadoraComForms
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
            btn2 = new Button();
            txtResultado = new TextBox();
            btn1 = new Button();
            btn3 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btnIgual = new Button();
            btnC = new Button();
            btn0 = new Button();
            btnDiv = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnSoma = new Button();
            btnNegativo = new Button();
            SuspendLayout();
            // 
            // btn2
            // 
            btn2.BackColor = Color.Silver;
            btn2.Location = new Point(252, 120);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 54);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.Chartreuse;
            txtResultado.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = SystemColors.InactiveCaptionText;
            txtResultado.Location = new Point(175, 62);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(211, 52);
            txtResultado.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Location = new Point(175, 120);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 54);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Silver;
            btn3.Location = new Point(329, 120);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 54);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.Location = new Point(329, 240);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 54);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.Location = new Point(175, 240);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 54);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.Location = new Point(252, 240);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 54);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkGray;
            btn6.Location = new Point(329, 180);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 54);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkGray;
            btn4.Location = new Point(175, 180);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 54);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkGray;
            btn5.Location = new Point(252, 180);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 54);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.IndianRed;
            btnIgual.Location = new Point(329, 300);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(135, 54);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Red;
            btnC.Location = new Point(175, 300);
            btnC.Name = "btnC";
            btnC.Size = new Size(57, 54);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DimGray;
            btn0.Location = new Point(252, 300);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 54);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 128, 0);
            btnDiv.Location = new Point(407, 242);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(57, 54);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Gold;
            btnSub.Location = new Point(407, 122);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(57, 54);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Orange;
            btnMult.Location = new Point(407, 182);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(57, 54);
            btnMult.TabIndex = 14;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(255, 192, 128);
            btnSoma.FlatAppearance.BorderColor = Color.Red;
            btnSoma.Location = new Point(407, 62);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(57, 54);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnNegativo
            // 
            btnNegativo.BackColor = Color.Crimson;
            btnNegativo.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnNegativo.FlatAppearance.BorderSize = 3;
            btnNegativo.FlatStyle = FlatStyle.Flat;
            btnNegativo.ForeColor = SystemColors.InactiveCaptionText;
            btnNegativo.Location = new Point(504, 62);
            btnNegativo.Name = "btnNegativo";
            btnNegativo.Size = new Size(84, 52);
            btnNegativo.TabIndex = 17;
            btnNegativo.Text = "Negativo";
            btnNegativo.UseVisualStyleBackColor = false;
            btnNegativo.Click += btnNegativo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNegativo);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnC);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(txtResultado);
            Controls.Add(btn2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn2;
        private TextBox txtResultado;
        private Button btn1;
        private Button btn3;
        private Button btn9;
        private Button btn7;
        private Button btn8;
        private Button btn6;
        private Button btn4;
        private Button btn5;
        private Button btnIgual;
        private Button btnC;
        private Button btn0;
        private Button btnDiv;
        private Button btnSub;
        private Button btnMult;
        private Button btnSoma;
        private Button btnNegativo;
    }
}
