using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesRecorrido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
               

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);// color del relleno del circulo
            System.Drawing.Graphics graphics = this.CreateGraphics();//creacion del objeto
            System.Drawing.Pen myPen;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            
            //-------------------- Nivel 0 nodo A
            System.Drawing.Rectangle nodo1 = new System.Drawing.Rectangle(550, 35, 100, 100);//posicion X,Y,ancho,largo
            
            //-------------------- Nivel 1 nodos B,C,D. 
            System.Drawing.Rectangle nodo2 = new System.Drawing.Rectangle(290, 170, 90, 90);
            System.Drawing.Rectangle nodo3 = new System.Drawing.Rectangle(800, 170, 90, 90);
            System.Drawing.Rectangle nodo4 = new System.Drawing.Rectangle(550, 170, 90, 90);
            
            //-------------------- Nivel 2 nodo E,F,I,J,G,H
            System.Drawing.Rectangle nodo5 = new System.Drawing.Rectangle(190, 330, 85, 85);
            System.Drawing.Rectangle nodo6 = new System.Drawing.Rectangle(350, 330, 85, 85);            
            System.Drawing.Rectangle nodo7 = new System.Drawing.Rectangle(480, 330, 85, 85);
            System.Drawing.Rectangle nodo8 = new System.Drawing.Rectangle(610, 330, 85, 85);            
            System.Drawing.Rectangle nodo9 = new System.Drawing.Rectangle(755, 330, 85, 85);
            System.Drawing.Rectangle nodo10 = new System.Drawing.Rectangle(890,330, 85, 85);
            
            //-------------------- Nivel 3 nodo I,J,K,L,M,L
            System.Drawing.Rectangle nodo11 = new System.Drawing.Rectangle(90, 490, 80, 80);
            System.Drawing.Rectangle nodo12 = new System.Drawing.Rectangle(200, 490, 80, 80);            
            System.Drawing.Rectangle nodo13 = new System.Drawing.Rectangle(300, 490, 80, 80);
            System.Drawing.Rectangle nodo14 = new System.Drawing.Rectangle(400, 490, 80, 80);            
            System.Drawing.Rectangle nodo15 = new System.Drawing.Rectangle(755, 490, 80, 80);
            System.Drawing.Rectangle nodo16 = new System.Drawing.Rectangle(890, 490, 80, 80);
            
            //---------relleno del circulo
            graphics.FillEllipse(myBrush, new Rectangle(550, 35, 100, 100));//Nodo A
            graphics.FillEllipse(myBrush, new Rectangle(290, 170, 90, 90)); //Nodo B
            graphics.FillEllipse(myBrush, new Rectangle(800, 170, 90, 90)); //Nodo C
            graphics.FillEllipse(myBrush, new Rectangle(550, 170, 90, 90)); //Nodo D
            graphics.FillEllipse(myBrush, new Rectangle(190, 330, 85, 85)); //Nodo E
            graphics.FillEllipse(myBrush, new Rectangle(350, 330, 85, 85)); //Nodo F
            graphics.FillEllipse(myBrush, new Rectangle(480, 330, 85, 85)); //Nodo I 
            graphics.FillEllipse(myBrush, new Rectangle(610, 330, 85, 85)); //Nodo J
            graphics.FillEllipse(myBrush, new Rectangle(755, 330, 85, 85)); //Nodo G
            graphics.FillEllipse(myBrush, new Rectangle(890, 330, 85, 85)); //Nodo H
            graphics.FillEllipse(myBrush, new Rectangle(90,  490, 80, 80)); //Nodo I
            graphics.FillEllipse(myBrush, new Rectangle(200, 490, 80, 80)); //Nodo J
            graphics.FillEllipse(myBrush, new Rectangle(300, 490, 80, 80)); //Nodo K
            graphics.FillEllipse(myBrush, new Rectangle(400, 490, 80, 80)); //Nodo L
            graphics.FillEllipse(myBrush, new Rectangle(755, 490, 80, 80)); //Nodo M
            graphics.FillEllipse(myBrush, new Rectangle(890, 490, 80, 80)); //Nodo L

            //---------contorno del ciruclo
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo1);//contorno de la figura
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo2);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo3);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo4);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo5);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo6);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo7);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo8);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo9);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo10);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo11);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo12);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo13);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo14);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo15);
            graphics.DrawEllipse(System.Drawing.Pens.Black, nodo16);     

            //Lineas, Caminos.
            formGraphics.DrawLine(myPen, 366, 183, 553, 102);//A,B
            formGraphics.DrawLine(myPen, 600, 171, 600, 135);//A,C
            formGraphics.DrawLine(myPen, 813, 183, 648, 102);//A,D            

            formGraphics.DrawLine(myPen, 245, 331, 311, 252);//B,E
            formGraphics.DrawLine(myPen, 399, 331, 360, 252);//B,F

            formGraphics.DrawLine(myPen, 541, 331, 581, 259);//C,I
            formGraphics.DrawLine(myPen, 641, 331, 612, 259);//C,J

            formGraphics.DrawLine(myPen, 803, 331, 829, 259);//D,G
            formGraphics.DrawLine(myPen, 922, 331, 869, 253);//D,H

            formGraphics.DrawLine(myPen, 141, 492, 209, 408);//E,I
            formGraphics.DrawLine(myPen, 237, 416, 249, 491);//E,J

            formGraphics.DrawLine(myPen,352 , 492, 384, 414 );//F,K
            formGraphics.DrawLine(myPen, 438, 491, 414, 410);//F,L

            formGraphics.DrawLine(myPen, 800, 491, 800, 414);//G,M
            formGraphics.DrawLine(myPen, 935, 491, 935, 414);//H,L
            
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }   
       
    }
}
