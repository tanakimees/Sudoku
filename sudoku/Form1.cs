using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form
    {
        int selectedshit = 1;
        int checkshitlmao = 0;

        int sudokuline = 1;
        int sudokurow = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fadein.Start();
            loop.Start();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void fadein_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
            if (Opacity == 1)
            {
                fadein.Stop();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if(selectedshit != 1)
            {
                label1.ForeColor = Color.Gray;
            }
            else
            {
                label1.ForeColor = Color.White;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (selectedshit != 2)
            {
                label2.ForeColor = Color.Gray;
            }
            else
            {
                label2.ForeColor = Color.White;
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (selectedshit != 3)
            {
                label3.ForeColor = Color.Gray;
            }
            else
            {
                label3.ForeColor = Color.White;
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedshit = 1;
            gamepanel.BringToFront();
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            panel4.BackColor = Color.FromArgb(35, 35, 35);
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel6.BackColor = Color.FromArgb(45, 45, 45);
            textBox5.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = false;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox14.Visible = true;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedshit = 2;
            settingspanel.BringToFront();
            label1.ForeColor = Color.Gray;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.Gray;
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel5.BackColor = Color.FromArgb(35, 35, 35);
            panel6.BackColor = Color.FromArgb(45, 45, 45);
            textBox5.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = false;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox14.Visible = true;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedshit = 3;
            aboutpanel.BringToFront();
            label1.ForeColor = Color.Gray;
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.White;
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel6.BackColor = Color.FromArgb(35, 35, 35);
            textBox5.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = true;
            textBox12.Visible = false;
            textBox13.Visible = true;
            textBox15.Visible = false;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox14.Visible = false;
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Gray;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            fadeout.Start();
            fadein.Stop();
        }

        private void fadeout_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if(this.Opacity == 0)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            createsudoku.Start();
        }

        public List<int> randomList = new List<int>();
        private void createsudoku_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int int1 = rnd.Next(1, 10);

            if(!randomList.Contains(int1))
            {
                randomList.Add(int1);
                foreach(Label l in panel1.Controls.OfType<Label>())
                {
                    if(l.Name == "l" + sudokuline + "r" + sudokurow)
                    {
                        l.Text = int1.ToString();
                        sudokurow++;
                    }       
                }
                checkshitlmao++;
            }
            if(checkshitlmao == 9)
            {
                
            }
        }
    }
}
