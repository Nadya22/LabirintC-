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
    public partial class Form_level2 : Form
    {
        int count;
        public Form_level2()
        {
            InitializeComponent();
        }



        public void start_game()
        {
            Point point;
            point = label_start2.Location;
            point.Offset(label_start2.Width / 2, label_start2.Height / 2);
            Cursor.Position = PointToScreen(point);
            count = 5;
            label16.Visible = true;
            label19.Visible = true;        
            label20.Visible = true;
            label18.Visible = true;
            label15.Visible = true;
        }

        public void finish_game()
        {
            DialogResult dr = MessageBox.Show("Вы проиграли, попробовать пройти уровень еще раз?", "Проигрышь",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void Form_level2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if(count == 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            count--;
            ((Label)sender).Visible = false;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            count--;
            ((Label)sender).Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
