using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceGroup
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddForm frm = new AddForm() { ChildInfo = new Child() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.textBox1.Text.Length == 0 | frm.textBox2.Text.Length == 0 | frm.textBox3.Text.Length == 0 | frm.textBox5.Text.Length == 0)
                    {
                        MessageBox.Show("Вы не заполнили поля", "Внимание!");
                    }
                    else
                    {
                        childBindingSource.Add(frm.ChildInfo);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Child obj = childBindingSource.Current as Child;
            if(obj!=null)
            {
                using (AddForm frm = new AddForm() { ChildInfo = obj })
                {
                    if(frm.ShowDialog()==DialogResult.OK)
                    {
                        childBindingSource.EndEdit();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                childBindingSource.RemoveCurrent();
            }

        }
    }
}
