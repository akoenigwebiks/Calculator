namespace Calculator
{
    partial class CalculatorForm
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
            this.comboBox_operator = new System.Windows.Forms.ComboBox();
            this.textBox_val2 = new System.Windows.Forms.TextBox();
            this.textBox_val1 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_num_1 = new System.Windows.Forms.Button();
            this.button_num_2 = new System.Windows.Forms.Button();
            this.button_num_3 = new System.Windows.Forms.Button();
            this.button_operator_add = new System.Windows.Forms.Button();
            this.button_operator_subtract = new System.Windows.Forms.Button();
            this.button_num_6 = new System.Windows.Forms.Button();
            this.button_num_5 = new System.Windows.Forms.Button();
            this.button_num_4 = new System.Windows.Forms.Button();
            this.button_operator_multiply = new System.Windows.Forms.Button();
            this.button_num_9 = new System.Windows.Forms.Button();
            this.button_num_8 = new System.Windows.Forms.Button();
            this.button_num_7 = new System.Windows.Forms.Button();
            this.button_operator_divide = new System.Windows.Forms.Button();
            this.button_num_0 = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_operator
            // 
            this.comboBox_operator.FormattingEnabled = true;
            this.comboBox_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBox_operator.Location = new System.Drawing.Point(171, 22);
            this.comboBox_operator.Name = "comboBox_operator";
            this.comboBox_operator.Size = new System.Drawing.Size(73, 39);
            this.comboBox_operator.TabIndex = 2;
            this.comboBox_operator.Text = "+";
            this.comboBox_operator.SelectedIndexChanged += new System.EventHandler(this.comboBox_operator_SelectedIndexChanged);
            // 
            // textBox_val2
            // 
            this.textBox_val2.Location = new System.Drawing.Point(253, 23);
            this.textBox_val2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_val2.Name = "textBox_val2";
            this.textBox_val2.Size = new System.Drawing.Size(120, 38);
            this.textBox_val2.TabIndex = 3;
            this.textBox_val2.Click += new System.EventHandler(this.textBox_val_Click);
            // 
            // textBox_val1
            // 
            this.textBox_val1.Location = new System.Drawing.Point(42, 23);
            this.textBox_val1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_val1.Name = "textBox_val1";
            this.textBox_val1.Size = new System.Drawing.Size(120, 38);
            this.textBox_val1.TabIndex = 4;
            this.textBox_val1.Click += new System.EventHandler(this.textBox_val_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(421, 23);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(100, 38);
            this.textBox_result.TabIndex = 7;
            // 
            // button_num_1
            // 
            this.button_num_1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_1.Location = new System.Drawing.Point(42, 97);
            this.button_num_1.Name = "button_num_1";
            this.button_num_1.Size = new System.Drawing.Size(100, 50);
            this.button_num_1.TabIndex = 8;
            this.button_num_1.Text = "1";
            this.button_num_1.UseVisualStyleBackColor = false;
            this.button_num_1.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_2
            // 
            this.button_num_2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_2.Location = new System.Drawing.Point(156, 97);
            this.button_num_2.Name = "button_num_2";
            this.button_num_2.Size = new System.Drawing.Size(100, 50);
            this.button_num_2.TabIndex = 9;
            this.button_num_2.Text = "2";
            this.button_num_2.UseVisualStyleBackColor = false;
            this.button_num_2.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_3
            // 
            this.button_num_3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_3.Location = new System.Drawing.Point(273, 97);
            this.button_num_3.Name = "button_num_3";
            this.button_num_3.Size = new System.Drawing.Size(100, 50);
            this.button_num_3.TabIndex = 10;
            this.button_num_3.Text = "3";
            this.button_num_3.UseVisualStyleBackColor = false;
            this.button_num_3.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_operator_add
            // 
            this.button_operator_add.BackColor = System.Drawing.Color.Yellow;
            this.button_operator_add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_operator_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_operator_add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_operator_add.Location = new System.Drawing.Point(421, 97);
            this.button_operator_add.Name = "button_operator_add";
            this.button_operator_add.Size = new System.Drawing.Size(100, 50);
            this.button_operator_add.TabIndex = 11;
            this.button_operator_add.Text = "+";
            this.button_operator_add.UseVisualStyleBackColor = false;
            this.button_operator_add.Click += new System.EventHandler(this.button_operator_Click);
            // 
            // button_operator_subtract
            // 
            this.button_operator_subtract.BackColor = System.Drawing.Color.Yellow;
            this.button_operator_subtract.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_operator_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_operator_subtract.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_operator_subtract.Location = new System.Drawing.Point(421, 162);
            this.button_operator_subtract.Name = "button_operator_subtract";
            this.button_operator_subtract.Size = new System.Drawing.Size(100, 50);
            this.button_operator_subtract.TabIndex = 15;
            this.button_operator_subtract.Text = "-";
            this.button_operator_subtract.UseVisualStyleBackColor = false;
            this.button_operator_subtract.Click += new System.EventHandler(this.button_operator_Click);
            // 
            // button_num_6
            // 
            this.button_num_6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_6.Location = new System.Drawing.Point(273, 162);
            this.button_num_6.Name = "button_num_6";
            this.button_num_6.Size = new System.Drawing.Size(100, 50);
            this.button_num_6.TabIndex = 14;
            this.button_num_6.Text = "6";
            this.button_num_6.UseVisualStyleBackColor = false;
            this.button_num_6.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_5
            // 
            this.button_num_5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_5.Location = new System.Drawing.Point(156, 162);
            this.button_num_5.Name = "button_num_5";
            this.button_num_5.Size = new System.Drawing.Size(100, 50);
            this.button_num_5.TabIndex = 13;
            this.button_num_5.Text = "5";
            this.button_num_5.UseVisualStyleBackColor = false;
            this.button_num_5.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_4
            // 
            this.button_num_4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_4.Location = new System.Drawing.Point(42, 162);
            this.button_num_4.Name = "button_num_4";
            this.button_num_4.Size = new System.Drawing.Size(100, 50);
            this.button_num_4.TabIndex = 12;
            this.button_num_4.Text = "4";
            this.button_num_4.UseVisualStyleBackColor = false;
            this.button_num_4.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_operator_multiply
            // 
            this.button_operator_multiply.BackColor = System.Drawing.Color.Yellow;
            this.button_operator_multiply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_operator_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_operator_multiply.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_operator_multiply.Location = new System.Drawing.Point(421, 231);
            this.button_operator_multiply.Name = "button_operator_multiply";
            this.button_operator_multiply.Size = new System.Drawing.Size(100, 50);
            this.button_operator_multiply.TabIndex = 19;
            this.button_operator_multiply.Text = "x";
            this.button_operator_multiply.UseVisualStyleBackColor = false;
            this.button_operator_multiply.Click += new System.EventHandler(this.button_operator_Click);
            // 
            // button_num_9
            // 
            this.button_num_9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_9.Location = new System.Drawing.Point(273, 231);
            this.button_num_9.Name = "button_num_9";
            this.button_num_9.Size = new System.Drawing.Size(100, 50);
            this.button_num_9.TabIndex = 18;
            this.button_num_9.Text = "9";
            this.button_num_9.UseVisualStyleBackColor = false;
            this.button_num_9.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_8
            // 
            this.button_num_8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_8.Location = new System.Drawing.Point(156, 231);
            this.button_num_8.Name = "button_num_8";
            this.button_num_8.Size = new System.Drawing.Size(100, 50);
            this.button_num_8.TabIndex = 17;
            this.button_num_8.Text = "8";
            this.button_num_8.UseVisualStyleBackColor = false;
            this.button_num_8.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_num_7
            // 
            this.button_num_7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_7.Location = new System.Drawing.Point(42, 231);
            this.button_num_7.Name = "button_num_7";
            this.button_num_7.Size = new System.Drawing.Size(100, 50);
            this.button_num_7.TabIndex = 16;
            this.button_num_7.Text = "7";
            this.button_num_7.UseVisualStyleBackColor = false;
            this.button_num_7.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_operator_divide
            // 
            this.button_operator_divide.BackColor = System.Drawing.Color.Yellow;
            this.button_operator_divide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_operator_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_operator_divide.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_operator_divide.Location = new System.Drawing.Point(421, 299);
            this.button_operator_divide.Name = "button_operator_divide";
            this.button_operator_divide.Size = new System.Drawing.Size(100, 50);
            this.button_operator_divide.TabIndex = 20;
            this.button_operator_divide.Text = "/";
            this.button_operator_divide.UseVisualStyleBackColor = false;
            this.button_operator_divide.Click += new System.EventHandler(this.button_operator_Click);
            // 
            // button_num_0
            // 
            this.button_num_0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_num_0.Location = new System.Drawing.Point(42, 299);
            this.button_num_0.Name = "button_num_0";
            this.button_num_0.Size = new System.Drawing.Size(331, 50);
            this.button_num_0.TabIndex = 21;
            this.button_num_0.Text = "0";
            this.button_num_0.UseVisualStyleBackColor = false;
            this.button_num_0.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.Green;
            this.button_equals.Location = new System.Drawing.Point(382, 23);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(30, 38);
            this.button_equals.TabIndex = 22;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 410);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_num_0);
            this.Controls.Add(this.button_operator_divide);
            this.Controls.Add(this.button_operator_multiply);
            this.Controls.Add(this.button_num_9);
            this.Controls.Add(this.button_num_8);
            this.Controls.Add(this.button_num_7);
            this.Controls.Add(this.button_operator_subtract);
            this.Controls.Add(this.button_num_6);
            this.Controls.Add(this.button_num_5);
            this.Controls.Add(this.button_num_4);
            this.Controls.Add(this.button_operator_add);
            this.Controls.Add(this.button_num_3);
            this.Controls.Add(this.button_num_2);
            this.Controls.Add(this.button_num_1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_val1);
            this.Controls.Add(this.textBox_val2);
            this.Controls.Add(this.comboBox_operator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatorForm";
            this.Text = "מחשבון";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_operator;
        private System.Windows.Forms.TextBox textBox_val2;
        private System.Windows.Forms.TextBox textBox_val1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_num_1;
        private System.Windows.Forms.Button button_num_2;
        private System.Windows.Forms.Button button_num_3;
        private System.Windows.Forms.Button button_operator_add;
        private System.Windows.Forms.Button button_operator_subtract;
        private System.Windows.Forms.Button button_num_6;
        private System.Windows.Forms.Button button_num_5;
        private System.Windows.Forms.Button button_num_4;
        private System.Windows.Forms.Button button_operator_multiply;
        private System.Windows.Forms.Button button_num_9;
        private System.Windows.Forms.Button button_num_8;
        private System.Windows.Forms.Button button_num_7;
        private System.Windows.Forms.Button button_operator_divide;
        private System.Windows.Forms.Button button_num_0;
        private System.Windows.Forms.Button button_equals;
    }
}

