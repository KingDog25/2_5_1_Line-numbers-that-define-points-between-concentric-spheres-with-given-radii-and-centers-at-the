/*Условие: Дана матрица из 3 столбцов и 10 строк. Элементы каждой строки представляют координаты одной из 10 точек трехмерного пространства.
Отпечатать номера строк, которыми заданы точки, находящимися между концентрическими сферами с заданными радиусами и центрами в начале координат*/

/*Condition: Given a matrix of 3 columns and 10 rows. The elements of each row represent the coordinates of one of the 10 points in three-dimensional space.
Print line numbers that define points between concentric spheres with given radii and centers at the origin*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSarp_2_5_1
{
    public partial class ConsentricSpheres : Form
    {
        public ConsentricSpheres()
        {
            InitializeComponent();
        }
            private void labelInputEl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonHandle_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInputEl.Enabled = radioButtonHandle.Checked;                             //сделать текстбокс активным
        }

        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox_r1_Enter(object sender, EventArgs e)
        {
            textBox_r1.Text = null;
        }

        private void textBox_R2_Enter(object sender, EventArgs e)
        {
            textBox_R2.Text = null;
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;                             //кол-во строк
            dataGridView1.ColumnCount = 3;                          //столбцов
            dataGridView1.Rows[0].HeaderCell.Value = "Кооординаты X,Y,Z";
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].HeaderText = "Y";
            dataGridView1.Columns[2].HeaderText = "Z";
            int rowsCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount = 3;
            int[,] tableXYZ = new int[rowsCount, columnCount];
            Random rnd = new Random();
            short countPoints = 0;
            float summSquare = 0;                                                              //для подсчета левой части каждой строки X^2 + Y^2 +Z^2 = R^2
            int r = int.Parse(textBox_r1.Text);
            int R = int.Parse(textBox_R2.Text);
            labelRadiusesCount.Text = "Радиусы r="+ r +". R2=" + R + ".";
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnCount; j++)                                         //заполняем значения X
                {
                    tableXYZ[i, j] = rnd.Next(-50, 50);                                      //заполняем массив случайными значениями координат
                    dataGridView1.Rows[i].Cells[j].Value = tableXYZ[i, j];
                    summSquare += tableXYZ[i, j] * tableXYZ[i, j];
                    if (summSquare < R * R && summSquare > r * r)
                    {                                                                        //Если сумма квадратов координаты точки меньше, чем R и больше чем r
                        countPoints++;
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    summSquare = 0;
                }
            }
        }
    }
}
