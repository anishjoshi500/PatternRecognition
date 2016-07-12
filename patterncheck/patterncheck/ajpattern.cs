using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patterncheck
{
    public partial class ajpattern: UserControl
    {
        private string pat = "12489bg";
        private string st = "";
        int s1 = 0; Graphics g;
        int px = 0, py = 0;
        int passw; SolidBrush rb1,rb2,rb3,rb4;
        System.Drawing.Pen myPen;
        public ajpattern()
        {
            rb1 = new SolidBrush(Color.Blue);
            
            rb2 = new SolidBrush(Color.Chartreuse);
            rb3 = new SolidBrush(Color.White);
            rb4 = new SolidBrush(Color.Transparent);
            
            myPen = new System.Drawing.Pen(System.Drawing.Color.Chartreuse, 10);
             
            InitializeComponent();
            if (panel10 != null)
                g = panel10.CreateGraphics();




 






           }
        public void setText(string s)
        {
            pat = s;
        }
        public void check()
        {

            if (st.Equals(pat))
            {
                MessageBox.Show(" your password is correct");
                panel10.Visible = false;

            }
            

        }

        public string getPattern()
        { return st; }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 1 || s1 == 0)
            {
                s1 = 1;
                st += 1;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel1.Location.X + 20, panel1.Location.Y + 20);
                px = panel1.Location.X;
                py = panel1.Location.Y;

                Graphics g1 = panel1.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);


                g1.DrawLine(myPen, px + 20, py + 20, panel1.Location.X + 20, panel1.Location.Y + 20);


            }

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 2 || s1 == 0)
            {
                s1 = 2;
                st += 2;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel2.Location.X + 20, panel2.Location.Y + 20);
                px = panel2.Location.X;
                py = panel2.Location.Y;

                Graphics g1 = panel2.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
   

        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 7 || s1 == 0)
            {
                s1 = 7;
                st += 7;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel7.Location.X + 20, panel7.Location.Y + 20);
                px = panel7.Location.X;
                py = panel7.Location.Y;

                Graphics g1 = panel7.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 13 || s1 == 0)
            {
                s1 = 13;
               
                st += "d";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel13.Location.X + 20, panel13.Location.Y + 20);
                px = panel13.Location.X;
                py = panel13.Location.Y;

                Graphics g1 = panel13.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }


        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 3 || s1 == 0)
            {
                s1 = 3;
                st += 3;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel3.Location.X + 20, panel3.Location.Y + 20);
                px = panel3.Location.X;
                py = panel3.Location.Y;

                Graphics g1 = panel3.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 4 || s1 == 0)
            {
                s1 = 4;
                st += 4;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel4.Location.X + 20, panel4.Location.Y + 20);
                px = panel4.Location.X;
                py = panel4.Location.Y;

                Graphics g1 = panel4.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 8 || s1 == 0)
            {
                s1 = 8;
                st += 8;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel8.Location.X + 20, panel8.Location.Y + 20);
                px = panel8.Location.X;
                py = panel8.Location.Y;

                Graphics g1 = panel8.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 12 || s1 == 0)
            {
                s1 = 12;
               
                st += "h";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel12.Location.X + 20, panel12.Location.Y + 20);
                px = panel12.Location.X;
                py = panel12.Location.Y;

                Graphics g1 = panel12.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 6 || s1 == 0)
            {
                s1 = 6;
                st += 6;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel6.Location.X + 20, panel6.Location.Y + 20);
                px = panel6.Location.X;
                py = panel6.Location.Y;

                Graphics g1 = panel6.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        

        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 5 || s1 == 0)
            {
                s1 = 5;
               
                st += 5;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel5.Location.X + 20, panel5.Location.Y + 20);
                px = panel5.Location.X;
                py = panel5.Location.Y;

                Graphics g1 = panel5.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 9 || s1 == 0)
            {
                s1 = 9;
                st += 9;
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel9.Location.X + 20, panel9.Location.Y + 20);
                px = panel9.Location.X;
                py = panel9.Location.Y;

                Graphics g1 = panel9.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }

        }

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 16 || s1 == 0)
            {
                s1 = 16;
               
                st += "f";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel16.Location.X + 20, panel16.Location.Y + 20);
                px = panel16.Location.X;
                py = panel16.Location.Y;

                Graphics g1 = panel16.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }

        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 15 || s1 == 0)
            {
                s1 = 15;
               
                st += "e";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel15.Location.X + 20, panel15.Location.Y + 20);
                px = panel15.Location.X;
                py = panel15.Location.Y;

                Graphics g1 = panel15.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }

        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {

            if (s1 != 14 || s1 == 0)
            {
                s1 = 14;
               
                st += "c";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel14.Location.X + 20, panel14.Location.Y + 20);
                px = panel14.Location.X;
                py = panel14.Location.Y;

                Graphics g1 = panel14.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }

        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 11 || s1 == 0)
            {
                s1 = 11;
               
                st += "b";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel11.Location.X + 20, panel11.Location.Y + 20);
                px = panel11.Location.X;
                py = panel11.Location.Y;

                Graphics g1 = panel11.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }

        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            if (s1 != 17 || s1 == 0)
            {
                s1 = 17;
               
                st += "g";
                textBox1.Text = st;
                if (px != 0)
                    g.DrawLine(myPen, px + 20, py + 20, panel17.Location.X + 20, panel17.Location.Y + 20);
                px = panel17.Location.X;
                py = panel17.Location.Y;

                Graphics g1 = panel17.CreateGraphics();

                g1.FillEllipse(rb2, 0, 0, 40, 40);

                g1.FillEllipse(rb3, 10, 10, 20, 20);
            
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g1 = panel1.CreateGraphics();
            g1.FillEllipse(rb1, 0, 0, 40, 40);
            g1.FillEllipse(rb3, 10, 10, 20, 20);
       
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel2.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel7.CreateGraphics();
            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
         }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel13.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
        

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel12.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
        

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel8.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
        

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel4.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel3.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel6.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel5.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel9.CreateGraphics();
            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel16.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel17.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel11.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel14.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = panel15.CreateGraphics();

            g1.FillEllipse(rb1, 0, 0, 40, 40);

            g1.FillEllipse(rb3, 10, 10, 20, 20);
            

        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            check();
        }
    }
}
