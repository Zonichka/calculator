namespace Calc
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_tan = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_ctan = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(4, 156);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 46);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_sin
            // 
            this.button_sin.Location = new System.Drawing.Point(4, 231);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(140, 46);
            this.button_sin.TabIndex = 2;
            this.button_sin.Text = "sin";
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Location = new System.Drawing.Point(130, 156);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(120, 46);
            this.button_subtraction.TabIndex = 3;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_subtraction_Click);
            // 
            // button_cos
            // 
            this.button_cos.Location = new System.Drawing.Point(167, 231);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(140, 46);
            this.button_cos.TabIndex = 4;
            this.button_cos.Text = "cos";
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(256, 156);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(120, 46);
            this.button_multiply.TabIndex = 5;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_tan
            // 
            this.button_tan.Location = new System.Drawing.Point(328, 231);
            this.button_tan.Name = "button_tan";
            this.button_tan.Size = new System.Drawing.Size(140, 46);
            this.button_tan.TabIndex = 6;
            this.button_tan.Text = "tan";
            this.button_tan.UseVisualStyleBackColor = true;
            this.button_tan.Click += new System.EventHandler(this.button_tan_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(382, 156);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(120, 46);
            this.button_division.TabIndex = 7;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_ctan
            // 
            this.button_ctan.Location = new System.Drawing.Point(489, 231);
            this.button_ctan.Name = "button_ctan";
            this.button_ctan.Size = new System.Drawing.Size(140, 46);
            this.button_ctan.TabIndex = 8;
            this.button_ctan.Text = "ctan";
            this.button_ctan.UseVisualStyleBackColor = true;
            this.button_ctan.Click += new System.EventHandler(this.button_ctan_Click);
            // 
            // button_pow
            // 
            this.button_pow.Location = new System.Drawing.Point(508, 156);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(120, 46);
            this.button_pow.TabIndex = 9;
            this.button_pow.Text = "pow";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Равно:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_pow);
            this.groupBox1.Controls.Add(this.button_ctan);
            this.groupBox1.Controls.Add(this.button_division);
            this.groupBox1.Controls.Add(this.button_tan);
            this.groupBox1.Controls.Add(this.button_multiply);
            this.groupBox1.Controls.Add(this.button_cos);
            this.groupBox1.Controls.Add(this.button_subtraction);
            this.groupBox1.Controls.Add(this.button_sin);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(453, 39);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 39);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 39);
            this.textBox1.TabIndex = 12;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(6, 28);
            this.button_clear.Margin = new System.Windows.Forms.Padding(1);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(120, 99);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_add;
        private Button button_sin;
        private Button button_subtraction;
        private Button button_cos;
        private Button button_multiply;
        private Button button_tan;
        private Button button_division;
        private Button button_ctan;
        private Button button_pow;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        public TextBox textBox1;
        private Button button_clear;
    }
}