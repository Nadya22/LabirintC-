using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labirint2D;

namespace Labirint2D
{
    public partial class Form_livel1 : Form
    {
        public Form_livel1()
        {           
            InitializeComponent();
            const int blockNumX = 30;
            const int blockNumY = 30;
            LabirintGenerator lb = new LabirintGenerator();
            lb.gen();
            int[,] lm =(int[,]) lb.Map.Clone();
            LabirintConstructor(lm,15, 15);
        }

        int[,] addPerim(int[,] matrix, int n, int m)
        {
            int[,] new_matrix = new int[n + 2, m + 2];

            for(int i=0; i<n+2; i++)
            {
                new_matrix[i, 0] = 1;
                new_matrix[i, m+1] = 1;
            }

            for (int i = 0; i < n ; i++)
                for (int j =0; j < m ; j++)
                    new_matrix[i+1, j+1] = matrix[i, j];

            for (int i = 0; i < m+2; i++)
            {
                new_matrix[0, i] = 1;
                new_matrix[n+1, i] = 1;
            }
            return new_matrix;
        }

       void createWall(int x, int y, int size_x, int size_y)
        {
            Label l = new Label();
            l.SetBounds(0, 0, size_x, size_y);
            l.Location = new Point(x, y);
            l.BackColor = Color.Green;
            this.Controls.Add(l);
            l.MouseEnter += label12_MouseEnter;
        }

        void LabirintConstructor(int[,] matrix, int blockNumX, int blockNumY)
        {
            int size_x = this.Width;
            int size_y = this.Height;

            int wallSizeX = size_x / blockNumX;
            int wallSizeY = size_y / blockNumY;
           
            for (int x = 0; x < blockNumX; x++)
            {
                for (int y = 0; y < blockNumY; y++)
                {
                    if (matrix[x, y] == 1)
                        createWall(0 + x * (size_x / blockNumX), 0 +y  * (size_y / blockNumY), wallSizeX, wallSizeY);
                }
                    
            }

        }

        private void label_finish_Click(object sender, EventArgs e)
        {
        
        }

       

        public void start_game()
        {                      
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
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

        private void Form_livel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {

            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void Form_livel1_Load(object sender, EventArgs e)
        {

        }
  
        private void label8_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
