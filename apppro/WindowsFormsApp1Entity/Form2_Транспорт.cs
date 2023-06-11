using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1Entity
{
    public partial class Form2_Транспорт : Form
    {
        Transport_companyEntities db = new Transport_companyEntities();

        public Form2_Транспорт()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Транспорт.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Транспорт транспорт = new Транспорт();
            транспорт.Марка = textBox1.Text;
            транспорт.Грузоподъемность = textBox2.Text;
            транспорт.Стоимость = Convert.ToInt32(textBox3.Text);

            db.Транспорт.Add(транспорт);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Транспорт.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Транспорт транспорт = db.Транспорт.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_транспорта"].Value));
            транспорт.Марка = textBox1.Text;
            транспорт.Грузоподъемность = textBox2.Text;
            транспорт.Стоимость = Convert.ToInt32(textBox3.Text);

            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Транспорт.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transport_companyEntities db = new Transport_companyEntities();
            Транспорт транспорт = db.Транспорт.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_транспорта"].Value));
            if (транспорт != null)
            {
                db.Транспорт.Remove(транспорт);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Транспорт.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
