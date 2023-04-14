using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0; i < progressBar1.Maximum; i++) 
            {
                progressBar1.PerformStep();
                label1.Text = progressBar1.Value.ToString() + "%";
                Thread.Sleep(100);
                this.Update();
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                groupBox1.Visible = true;  
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (!checkedListBox1.Items.Contains(textBox1.Text))
                {
                    checkedListBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("Такой эл-нт уже существует!");
                    textBox1.Clear();
                    textBox1.Select();
                }
            }
            else
            {
                MessageBox.Show("Строка пуста!");
            }
        }
    }
}
