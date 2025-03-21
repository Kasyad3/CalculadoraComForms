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
            SuspendLayout();
            // 
            // btn2
            // 
            btn2.Location = new Point(252, 115);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 54);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(175, 68);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(211, 23);
            txtResultado.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(175, 115);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 54);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(329, 115);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 54);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(329, 235);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 54);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(175, 235);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 54);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(252, 235);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 54);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(329, 175);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 54);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(175, 175);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 54);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(252, 175);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 54);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(329, 295);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(57, 54);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(175, 295);
            btnC.Name = "btnC";
            btnC.Size = new Size(57, 54);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(252, 295);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 54);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(451, 295);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(57, 54);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(451, 175);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(57, 54);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(451, 235);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(57, 54);
            btnMult.TabIndex = 14;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(451, 115);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(57, 54);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
