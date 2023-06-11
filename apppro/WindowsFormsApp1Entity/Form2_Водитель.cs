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
    public partial class Form2_Водитель : Form
    {
        Transport_companyEntities db = new Transport_companyEntities();
        public Form2_Водитель()
        {
            InitializeComponent();

            dataGridView1.DataSource = db.Водитель.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Водитель водитель = new Водитель();
            водитель.Фамилия = textBox1.Text;
            водитель.Имя = textBox2.Text;
            водитель.Отчество = textBox3.Text;
            водитель.Возраст = Convert.ToInt32(textBox4.Text);
            водитель.Телефон = textBox5.Text;
            db.Водитель.Add(водитель);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Водитель.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Водитель водитель = db.Водитель.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_водителя"].Value));
            водитель.Фамилия = textBox1.Text;
            водитель.Имя = textBox2.Text;
            водитель.Отчество = textBox3.Text;
            водитель.Возраст = Convert.ToInt32(textBox4.Text);
            водитель.Телефон = textBox5.Text;
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Водитель.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Водитель водитель = db.Водитель.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_водителя"].Value));
            if (водитель != null)
            {
                db.Водитель.Remove(водитель);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Водитель.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
