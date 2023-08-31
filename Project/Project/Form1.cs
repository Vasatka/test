using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dataGridView1.Rows.Add();
            Col_num1.DataSource = new List<string>() { "6", "77", "12345", "8218", "0", "5", "2", "8" };
            Col_var.DataSource = new List<string>() { "*", "/", "-" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null &&
                dataGridView1.Rows[0].Cells[1].Value != null &&
                dataGridView1.Rows[0].Cells[2].Value != null)
            {
                double n1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value);
                string token = dataGridView1.Rows[0].Cells[1].Value.ToString();
                double result = 0;
                try
                {
                    double n2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
                    switch (token)
                    {
                        case "*":
                            result = n1 * n2;
                            break;
                        case "/":
                            result = n1 / n2;
                            break;
                        case "-":
                            result = n1 - n2;
                            break;
                    }

                    dataGridView1.Rows[0].Cells[3].Value = result.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверный формат входных данных");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
