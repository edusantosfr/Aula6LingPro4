using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6lp1._2
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int v1, v2;
        int [] numb = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = int.Parse(textBoxV1.Text);
                v2 = int.Parse(textBoxV2.Text);

                for (int i = 0; i < 10; i++) 
                {
                    numb[i] = randNum.Next(v1, v2);

                    if (numb[i] % int.Parse(comboBox1.Text) == 0)
                    {
                        listBox1.Items.Add(numb[i]);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }
    }
}
