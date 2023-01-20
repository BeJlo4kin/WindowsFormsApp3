using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.VityaDataSetTableAdapters;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Photographer". При необходимости она может быть перемещена или удалена.
            this.photographerTableAdapter.Fill(this.vityaDataSet.Photographer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Photo_studio". При необходимости она может быть перемещена или удалена.
            this.photo_studioTableAdapter.Fill(this.vityaDataSet.Photo_studio);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.vityaDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Servicees". При необходимости она может быть перемещена или удалена.
            this.serviceesTableAdapter.Fill(this.vityaDataSet.Servicees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.vityaDataSet.Request);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            requestTableAdapter.Update(this.vityaDataSet);
            serviceesTableAdapter.Update(this.vityaDataSet);
            clientTableAdapter.Update(this.vityaDataSet);
            photo_studioTableAdapter.Update(this.vityaDataSet);
            photographerTableAdapter.Update(this.vityaDataSet);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
