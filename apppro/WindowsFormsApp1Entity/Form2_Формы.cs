using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Entity
{
    public partial class Form2_Формы : Form
    {
        public Form2_Формы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Клиент form2_Клиент = new Form2_Клиент();
            form2_Клиент.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Водитель form2_Водитель = new Form2_Водитель();
            form2_Водитель.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_Транспорт form2_Транспорт = new Form2_Транспорт();
            form2_Транспорт.Show();
        }
    }
}
