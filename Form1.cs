﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        bool t = true;
        int count_t = 0;
        static String name1, name2;
        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (t) b.Text = "X";
            else b.Text = "O";
            t = !t;
            b.Enabled = false;
            count_t++;
            Check_Winner();
        }
        public void Check_Winner()
        { bool i = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                i = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {
                i = true;
            }
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                i = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                i = true;
            }
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
            {
                i = true;
            }
            if (i)
            { String s;
                if (t)
                {
                    int a = Convert.ToInt32(o.Text);
                    a++;
                    o.Text = a.ToString();
                    s = player1.Text;
                    enabelbutton();

                }
                else
                {
                    int a = Convert.ToInt32(x.Text);
                    a++;
                    x.Text = a.ToString();
                    s = player2.Text;
                    enabelbutton();
                }
                MessageBox.Show(s + " win");
                count_t = 0;
                        }
            if (count_t == 9) 
            {
                MessageBox.Show("draw");
                count_t = 0;
                enabelbutton();
                int a = Convert.ToInt32(d.Text);
                a++;
                d.Text = a.ToString();
            }
        }
        private void enabelbutton()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    c.Enabled = true;
                    b.Text = "";
                }
                catch (Exception e) 
                {
                
                }
                
            }


        }

        private void mouse_An(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (t && b.Enabled)
            {
                b.Text = "X";
            }
            if (!t && b.Enabled)
            {
                b.Text = "O";
            }
        }

        private void mouse_aus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ( b.Enabled)
            {
                b.Text = " ";
            }
           

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enabelbutton();
            o.Text = "0";
            x.Text = "0";
            d.Text = "0";
                count_t = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frm = new Form2();
                frm.ShowDialog();
            player1.Text = name1;
            player2.Text = name2;

        }

        public static void playername(String n1, String n2)
        {
            name1 = n1;
            name2 = n2;
        
        }
    }

}
