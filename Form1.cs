using System;
using System.Windows.Forms;
using System.Drawing;

using Tao.OpenGl;
using Tao.FreeGlut;

namespace _3ebba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация Glut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            
            // очитка окна
            Gl.glClearColor(0, 0, 0, 1); // черный фон
            
            // установка порта вывода в соотвествии с размерами элемента
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            
            // настройка параллельной проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            
            const double W = 7;
            double H = W * AnT.Height / AnT.Width;
            
            Gl.glOrtho(-W, W, -H, H, -200, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            // настройка параметров OpenGL для визуализации
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);

            Gl.glEnable(Gl.GL_LIGHT0);
        }
        private void Render(double x, double y)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor4d(1, 1, 1, Convert.ToDouble(trasparency.Text)); // цвет фигуры - белый

            Gl.glPushMatrix();
            Gl.glTranslated(-1.8, 1 - Convert.ToDouble(height.Text)/2, 0);
            Gl.glRotated((x - AnT.Height) * 180 / AnT.Height, 0, 1, 0);
            Gl.glRotated((y - AnT.Width) * 180 / AnT.Width, 1, 0, 0);
           
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Glut.glutSolidCone(Convert.ToDouble(radius.Text), Convert.ToDouble(height.Text), 180, 1);


            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }
        
        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Render(e.X, e.Y);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) if (DialogResult.OK == colorDialog1.ShowDialog()) dataGridView1.Rows[e.RowIndex].Cells[3].Value = colorDialog1.Color;
        }

        private void buttonLightUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows) if (r.Index + 1 != dataGridView1.Rows.Count)
            {
                Gl.glEnable(Gl.GL_LIGHT0 + r.Index);

                float[] pos =
                {
                    (float) Convert.ToDecimal(r.Cells[0].Value),
                    (float) Convert.ToDecimal(r.Cells[1].Value),
                    (float) Convert.ToDecimal(r.Cells[2].Value), 3
                };
                
                Gl.glLightfv(Gl.GL_LIGHT0 + r.Index, Gl.GL_POSITION, pos);
                
                float[] color =
                {
                    ((Color) r.Cells[3].Value).R/(float) 255,
                    ((Color) r.Cells[3].Value).G/(float) 255,
                    ((Color) r.Cells[3].Value).B/(float) 255, 1
                };

                Gl.glLightfv(Gl.GL_LIGHT0 + r.Index, Gl.GL_DIFFUSE, color);
            }
        }
    }
}
