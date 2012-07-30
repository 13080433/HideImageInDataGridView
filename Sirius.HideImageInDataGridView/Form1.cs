using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.HideImageInDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<RowItem> dataSource = new List<RowItem>();
            for (int i = 0; i < 10; i++)
            {
                dataSource.Add(new RowItem { Id = i, ImageCell = Properties.Resources.Bitmap1 });
            }

            dataGridView1.DataSource = dataSource;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image blankImage = new Bitmap(1, 1);
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].Cells[1].Value = blankImage;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Image blankImage = new Bitmap(1, 1);
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    dataGridView1.Rows[i].Cells[1].Value = blankImage;
                }
            }
        }
    }
}
