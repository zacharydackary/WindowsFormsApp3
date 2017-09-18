using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);


            void drawMaze() //method because why write this all out again
            {
                formGraphics.Clear(Color.Black);
                //Draws walls of the maze
                formGraphics.DrawLine(drawPen, 10, 10, 500, 10);
                formGraphics.DrawLine(drawPen, 10, 90, 410, 90);
                formGraphics.DrawLine(drawPen, 500, 5, 500, 200);
                formGraphics.DrawLine(drawPen, 410, 85, 410, 200);
            }
          
            //method, and then draw pacman in the various locations it needs to be in
            drawMaze();
            formGraphics.FillPie(drawBrush, 10, 17, 65, 65, 30, 300);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 80, 17, 65, 65, 3, 353);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 150, 17, 65, 65, 30, 300);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 220, 17, 65, 65, 3, 353);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 290, 17, 65, 65, 30, 300);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 360, 17, 65, 65, 3, 353);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 420, 17, 65, 65, 30, 300);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 420, 87, 65, 65, 94, 353);
            Thread.Sleep(200);
            drawMaze();
            formGraphics.FillPie(drawBrush, 420, 147, 65, 65, 120, 300);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.);
            //player.Play();
            //
        }
    }
}