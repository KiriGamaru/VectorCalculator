
namespace VectorСalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1x = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txt1y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2y = new System.Windows.Forms.TextBox();
            this.txt2x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1x
            // 
            this.txt1x.Location = new System.Drawing.Point(210, 31);
            this.txt1x.Name = "txt1x";
            this.txt1x.Size = new System.Drawing.Size(54, 20);
            this.txt1x.TabIndex = 0;
            this.txt1x.TextChanged += new System.EventHandler(this.txt1x_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 77);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(160, 20);
            this.txtResult.TabIndex = 2;
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "сложение",
            "вычитание",
            "скалярное произведение",
            "длина вектора 1",
            "длина вектора 2",
            "векторное произведение"});
            this.cmbOperation.Location = new System.Drawing.Point(12, 30);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(160, 21);
            this.cmbOperation.TabIndex = 3;
            this.cmbOperation.Text = "сложение";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // txt1y
            // 
            this.txt1y.Location = new System.Drawing.Point(294, 31);
            this.txt1y.Name = "txt1y";
            this.txt1y.Size = new System.Drawing.Size(54, 20);
            this.txt1y.TabIndex = 6;
            this.txt1y.TextChanged += new System.EventHandler(this.txt1y_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "вектор 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "x=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "y=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "y=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "x=";
            // 
            // txt2y
            // 
            this.txt2y.Location = new System.Drawing.Point(294, 78);
            this.txt2y.Name = "txt2y";
            this.txt2y.Size = new System.Drawing.Size(54, 20);
            this.txt2y.TabIndex = 14;
            this.txt2y.TextChanged += new System.EventHandler(this.txt2y_TextChanged);
            // 
            // txt2x
            // 
            this.txt2x.Location = new System.Drawing.Point(210, 78);
            this.txt2x.Name = "txt2x";
            this.txt2x.Size = new System.Drawing.Size(54, 20);
            this.txt2x.TabIndex = 13;
            this.txt2x.TextChanged += new System.EventHandler(this.txt2x_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "вектор 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2y);
            this.Controls.Add(this.txt2x);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1y);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txt1x);
            this.Name = "Form1";
            this.Text = "VectorWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1x;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txt1y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2y;
        private System.Windows.Forms.TextBox txt2x;
        private System.Windows.Forms.Label label1;
    }
}

