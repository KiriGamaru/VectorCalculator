using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorСalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // функция для рассчета
        private void Calculate()
        {
            try
            {
                // считали значения с полей для ввода и сконвертили в числа
                var Ax = double.Parse(txt1x.Text);
                var Ay = double.Parse(txt1y.Text);
                var Bx = double.Parse(txt2x.Text);
                var By = double.Parse(txt2y.Text);
                // на основании значений создали экземпляры нашего класса Length
                var a = new Vector(Ax, Ay);
                var b = new Vector(Bx, By);

                //
                Vector c;
                double ans;
                // смотрим что выбрали в cmbOperation
                switch (cmbOperation.Text)
                {
                    case "сложение":
                        c = Vector.Addition(a, b);
                        txtResult.Text = c.Verbose(); // записали в поле txtResult ответ в строковом виде
                        break;
                    case "вычитание":
                        c = Vector.Subtraction(a, b);
                        txtResult.Text = c.Verbose();
                        break;
                    case "скалярное произведение":
                        ans = Vector.Skal(a, b);
                        txtResult.Text = ans.ToString();
                        break;
                    case "длина вектора 1":
                        ans = Vector.Length(a);
                        txtResult.Text = ans.ToString(); //???
                        break;
                    case "длина вектора 2":
                        ans = Vector.Length(b);
                        txtResult.Text = ans.ToString();
                        break;
                    case "векторное произведение":
                        ans = Vector.CrossProduct(a, b);
                        txtResult.Text = ans.ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        private void txt1x_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt1y_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt2x_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt2y_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
