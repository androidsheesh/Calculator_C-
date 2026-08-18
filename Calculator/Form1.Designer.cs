namespace Calculator
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
            label1 = new Label();
            btnclear = new Button();
            btnallclear = new Button();
            bkspc = new Button();
            divide = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            multiply = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            addition = new Button();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            minus = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 94);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(50, 124);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(70, 58);
            btnclear.TabIndex = 1;
            btnclear.Text = "CE";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button1_Click;
            // 
            // btnallclear
            // 
            btnallclear.Location = new Point(135, 124);
            btnallclear.Name = "btnallclear";
            btnallclear.Size = new Size(70, 58);
            btnallclear.TabIndex = 2;
            btnallclear.Text = "C";
            btnallclear.UseVisualStyleBackColor = true;
            // 
            // bkspc
            // 
            bkspc.Location = new Point(226, 124);
            bkspc.Name = "bkspc";
            bkspc.Size = new Size(70, 58);
            bkspc.TabIndex = 3;
            bkspc.Text = "BKSPC";
            bkspc.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(319, 124);
            divide.Name = "divide";
            divide.Size = new Size(70, 58);
            divide.TabIndex = 4;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // num7
            // 
            num7.Location = new Point(50, 201);
            num7.Name = "num7";
            num7.Size = new Size(70, 58);
            num7.TabIndex = 5;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            // 
            // num8
            // 
            num8.Location = new Point(135, 201);
            num8.Name = "num8";
            num8.Size = new Size(70, 58);
            num8.TabIndex = 6;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            // 
            // num9
            // 
            num9.Location = new Point(226, 201);
            num9.Name = "num9";
            num9.Size = new Size(70, 58);
            num9.TabIndex = 7;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Location = new Point(319, 201);
            multiply.Name = "multiply";
            multiply.Size = new Size(70, 58);
            multiply.TabIndex = 8;
            multiply.Text = "X";
            multiply.UseVisualStyleBackColor = true;
            // 
            // num4
            // 
            num4.Location = new Point(50, 277);
            num4.Name = "num4";
            num4.Size = new Size(70, 58);
            num4.TabIndex = 9;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            // 
            // num5
            // 
            num5.Location = new Point(135, 277);
            num5.Name = "num5";
            num5.Size = new Size(70, 58);
            num5.TabIndex = 10;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            // 
            // num6
            // 
            num6.Location = new Point(226, 277);
            num6.Name = "num6";
            num6.Size = new Size(70, 58);
            num6.TabIndex = 11;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            addition.Location = new Point(319, 277);
            addition.Name = "addition";
            addition.Size = new Size(70, 58);
            addition.TabIndex = 12;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            num1.AccessibleName = "";
            num1.Location = new Point(50, 352);
            num1.Name = "num1";
            num1.Size = new Size(70, 58);
            num1.TabIndex = 13;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Location = new Point(135, 352);
            num2.Name = "num2";
            num2.Size = new Size(70, 58);
            num2.TabIndex = 14;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            // 
            // num3
            // 
            num3.Location = new Point(226, 352);
            num3.Name = "num3";
            num3.Size = new Size(70, 58);
            num3.TabIndex = 15;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Location = new Point(319, 352);
            minus.Name = "minus";
            minus.Size = new Size(70, 58);
            minus.TabIndex = 16;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(351, 72);
            label.Name = "label";
            label.Size = new Size(38, 15);
            label.TabIndex = 17;
            label.Text = "label2";
            label.Click += label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(label);
            Controls.Add(minus);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(addition);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(multiply);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(divide);
            Controls.Add(bkspc);
            Controls.Add(btnallclear);
            Controls.Add(btnclear);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnclear;
        private Button btnallclear;
        private Button bkspc;
        private Button divide;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button multiply;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button addition;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button minus;
        private Label label;
    }
}
