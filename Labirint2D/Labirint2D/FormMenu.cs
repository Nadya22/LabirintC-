using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void start_level1()
        {
            Form_livel1 level1 = new Form_livel1();
           DialogResult dr = level1.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                start_youwin();
            }
        }

       /* private void start_level2()
        {
            Form_level2 level2 = new Form_level2();
           DialogResult dr = level2.ShowDialog();

             if (dr == System.Windows.Forms.DialogResult.OK)
             {
                start_youwin();
            }
        }*/

      /*  private void start_level3()
        {
            Form_level3 level3 = new Form_level3();
            DialogResult dr = level3.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_youwin();
            }
        }*/

        private void start_youwin()
        {
            MessageBox.Show("Игра пройдена.","Поздравляем!");
        }


    }
}
