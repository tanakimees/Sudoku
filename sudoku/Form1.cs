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

        int sudokualreadycreated = 0;
        int sudokuline = 1;
        int sudokurow = 1;
        int difficulty = 2;
        int idk = 0;
        string lblname = "";
        string lbltxt = "a";

        string line = "s";
        string row = "s";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fadein.Start();
            loop.Start();

            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                l.BackColor = Color.FromArgb(25,25,25);
                l.AutoSize = false;
                l.Text = "";
                l.Cursor = Cursors.Hand;
                l.ForeColor = Color.Gray;
            }
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
        
        public List<int> randomList = new List<int>();
        private void createsudoku_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int int1 = rnd.Next(1, 10);
            if(sudokuline == 1)
            {
                if (!randomList.Contains(int1))
                {
                    randomList.Add(int1);
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == "l" + sudokuline + "r" + sudokurow)
                        {
                            l.Text = int1.ToString();
                            sudokurow++;
                        }
                    }
                }
                else
                {
                    int tgsum = randomList.Sum();
                    if(tgsum == 45)
                    {
                        sudokuline += 1;
                    }
                }
            }

            if(sudokuline != 1)
            {
                l2r1.Text = l1r4.Text;
                l2r2.Text = l1r5.Text;
                l2r3.Text = l1r6.Text;
                l2r4.Text = l1r7.Text;
                l2r5.Text = l1r8.Text;
                l2r6.Text = l1r9.Text;
                l2r7.Text = l1r1.Text;
                l2r8.Text = l1r2.Text;
                l2r9.Text = l1r3.Text;

                l3r1.Text = l2r4.Text;
                l3r2.Text = l2r5.Text;
                l3r3.Text = l2r6.Text;
                l3r4.Text = l2r7.Text;
                l3r5.Text = l2r8.Text;
                l3r6.Text = l2r9.Text;
                l3r7.Text = l2r1.Text;
                l3r8.Text = l2r2.Text;
                l3r9.Text = l2r3.Text;

                l4r1.Text = l3r2.Text;
                l4r2.Text = l3r3.Text;
                l4r3.Text = l3r4.Text;
                l4r4.Text = l3r5.Text;
                l4r5.Text = l3r6.Text;
                l4r6.Text = l3r7.Text;
                l4r7.Text = l3r8.Text;
                l4r8.Text = l3r9.Text;
                l4r9.Text = l3r1.Text;

                l5r1.Text = l4r4.Text;
                l5r2.Text = l4r5.Text;
                l5r3.Text = l4r6.Text;
                l5r4.Text = l4r7.Text;
                l5r5.Text = l4r8.Text;
                l5r6.Text = l4r9.Text;
                l5r7.Text = l4r1.Text;
                l5r8.Text = l4r2.Text;
                l5r9.Text = l4r3.Text;

                l6r1.Text = l5r4.Text;
                l6r2.Text = l5r5.Text;
                l6r3.Text = l5r6.Text;
                l6r4.Text = l5r7.Text;
                l6r5.Text = l5r8.Text;
                l6r6.Text = l5r9.Text;
                l6r7.Text = l5r1.Text;
                l6r8.Text = l5r2.Text;
                l6r9.Text = l5r3.Text;

                l7r1.Text = l6r2.Text;
                l7r2.Text = l6r3.Text;
                l7r3.Text = l6r4.Text;
                l7r4.Text = l6r5.Text;
                l7r5.Text = l6r6.Text;
                l7r6.Text = l6r7.Text;
                l7r7.Text = l6r8.Text;
                l7r8.Text = l6r9.Text;
                l7r9.Text = l6r1.Text;

                l8r1.Text = l7r4.Text;
                l8r2.Text = l7r5.Text;
                l8r3.Text = l7r6.Text;
                l8r4.Text = l7r7.Text;
                l8r5.Text = l7r8.Text;
                l8r6.Text = l7r9.Text;
                l8r7.Text = l7r1.Text;
                l8r8.Text = l7r2.Text;
                l8r9.Text = l7r3.Text;

                l9r1.Text = l8r4.Text;
                l9r2.Text = l8r5.Text;
                l9r3.Text = l8r6.Text;
                l9r4.Text = l8r7.Text;
                l9r5.Text = l8r8.Text;
                l9r6.Text = l8r9.Text;
                l9r7.Text = l8r1.Text;
                l9r8.Text = l8r2.Text;
                l9r9.Text = l8r3.Text;


                removenr.Start();
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if(label4.Text == "Difficulty ↑")
            {
                label4.ForeColor = Color.White;
            }
            else
            {
                label4.ForeColor = Color.Gray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(label4.Text == "Difficulty ↑")
            {
                label4.Text = "Difficulty ↓";
                panel9.Visible = false;
            }
            else
            {
                label4.Text = "Difficulty ↑";
                panel9.Visible = true;
            }
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.White;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Gray;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if(sudokualreadycreated == 1)
            {   
                DialogResult dr = MessageBox.Show("You have already created a sudoku, do you want to create another one?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    createsudoku.Stop();
                    removenr.Stop();                  
                    sudokuline = 1;
                    sudokurow = 1;
                    randomList.Clear();
                    idk = 0;

                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {              
                        l.Text = "";
                        l.ForeColor = Color.Gray;
                        l.BackColor = Color.FromArgb(25, 25, 25);
                        row = "s";
                        line = "s";
                        lblname = "";
                        lbltxt = "";
                    }
                    createsudoku.Start();
                    sudokualreadycreated = 0;
                }
                else if(dr == DialogResult.No)
                {
                    return;
                }
            }
            if(sudokualreadycreated == 0)
            {
                sudokualreadycreated = 1;
                createsudoku.Start();
            }
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            if(difficulty == 1)
            {
                label10.ForeColor = Color.White;
            }
            else
            {
                label10.ForeColor = Color.Gray;
            }
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.White;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            if (difficulty == 2)
            {
                label11.ForeColor = Color.White;
            }
            else
            {
                label11.ForeColor = Color.Gray;
            }
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            if (difficulty == 3)
            {
                label12.ForeColor = Color.White;
            }
            else
            {
                label12.ForeColor = Color.Gray;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            label11.ForeColor = Color.Gray;
            label12.ForeColor = Color.Gray;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            label10.ForeColor = Color.Gray;
            label12.ForeColor = Color.Gray;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            label11.ForeColor = Color.Gray;
            label10.ForeColor = Color.Gray;
        }
        
        private void removenr_Tick(object sender, EventArgs e)
        {
            createsudoku.Stop();
            sudokuline = 1;
            sudokurow = 1;
            if(difficulty == 1)
            {         
                Random rnd3 = new Random();
                int lines = rnd3.Next(0, 10);
                int rows = rnd3.Next(0, 10);
                foreach(Label l in panel1.Controls.OfType<Label>())
                {
                    if(l.Name == "l" + lines + "r" + rows)
                    {
                        if(l.Text != "")
                        {
                            l.Text = "";
                            idk++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if(idk > 40)
                {
                    removenr.Stop();
                    sudokualreadycreated = 1;
                    idk = 0;
                }
            }
            if (difficulty == 2)
            {              
                Random rnd3 = new Random();
                int lines = rnd3.Next(0, 10);
                int rows = rnd3.Next(0, 10);
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == "l" + lines + "r" + rows)
                    {
                        if (l.Text != "")
                        {
                            l.Text = "";
                            idk++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if (idk > 50)
                {
                    removenr.Stop();
                    sudokualreadycreated = 1;
                    idk = 0;
                }
            }
            if (difficulty == 3)
            {
                Random rnd3 = new Random();
                int lines = rnd3.Next(0, 10);
                int rows = rnd3.Next(0, 10);
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == "l" + lines + "r" + rows)
                    {
                        if (l.Text != "")
                        {
                            l.Text = "";
                            idk++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if (idk > 60)
                {
                    removenr.Stop();
                    sudokualreadycreated = 1;
                    idk = 0;
                }
            }
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.White;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Gray;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            createsudoku.Stop();
            removenr.Stop();
            randomList.Clear();
            sudokualreadycreated = 0;
            sudokuline = 1;
            sudokurow = 1;
            idk = 0;
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                l.Text = "";
                l.ForeColor = Color.Gray;
                l.BackColor = Color.FromArgb(25, 25, 25);
                row = "s";
                line = "s";
                lblname = "";
                lbltxt = "";
            }
        }

        void menter()
        {
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(l.Name == lblname)
                {
                    l.ForeColor = Color.White;
                    l.BackColor = Color.FromArgb(35, 35, 35);
                }
            }
        }


        //DIPSHIT UI
        void mleave()
        {
            foreach (Label l in panel1.Controls.OfType<Label>())
            {
                if (l.Name == lblname)
                {
                    if(l.Name.Contains(line) || l.Name.Contains(row))
                    {
                            l.ForeColor = Color.White;
                            l.BackColor = Color.FromArgb(35, 35, 35);
                    }
                    else if(l.Text != lbltxt)
                    {
                            l.BackColor = Color.FromArgb(25, 25, 25);
                            l.ForeColor = Color.Gray;
                    }
                    else
                    {
                        l.BackColor = Color.FromArgb(25, 25, 25);
                        l.ForeColor = Color.White;
                    }
                }
            }
        }
        private void l1r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r1";
            menter();
        }

        private void l1r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r2";
            menter();
        }

        private void l1r2_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r3";
            menter();
        }

        private void l1r3_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r1";
            menter();
        }

        private void l2r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r2";
            menter();
        }

        private void l2r2_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r3";
            menter();
        }

        private void l2r3_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r1";
            menter();
        }

        private void l3r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r2";
            menter();
        }

        private void l3r2_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r3";
            menter();
        }

        private void l3r3_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r4";
            menter();
        }

        private void l1r4_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r5";
            menter();
        }

        private void l1r5_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r6";
            menter();
        }

        private void l1r6_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r4";
            menter();
        }

        private void l2r4_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r5";
            menter();
        }

        private void l2r5_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r6";
            menter();
        }

        private void l2r6_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r4";
            menter();
        }

        private void l3r4_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r5";
            menter();
        }

        private void l3r5_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r6";
            menter();
        }

        private void l3r6_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r7";
            menter();
        }

        private void l1r7_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r8";
            menter();
        }

        private void l1r8_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l1r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l1r9";
            menter();
        }

        private void l1r9_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r7";
            menter();
        }

        private void l2r7_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r8";
            menter();
        }

        private void l2r8_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l2r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l2r9";
            menter();
        }

        private void l2r9_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r7";
            menter();
        }

        private void l3r7_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r8";
            menter();
        }

        private void l3r8_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l3r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l3r9";
            menter();
        }

        private void l3r9_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r1";
            menter();
        }

        private void l4r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r2";
            menter();
        }

        private void l4r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r3";
            menter();
        }

        private void l4r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r4";
            menter();
        }

        private void l4r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r5";
            menter();
        }

        private void l4r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r6";
            menter();
        }

        private void l4r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r7";
            menter();
        }

        private void l4r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r8";
            menter();
        }

        private void l4r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l4r9";
            menter();
        }

        private void l4r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r2_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r3_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r4_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r5_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r6_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r7_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r8_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l4r9_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l5r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r1";
            menter();
        }

        private void l5r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r2";
            menter();
        }

        private void l5r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r3";
            menter();
        }

        private void l5r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r4";
            menter();
        }

        private void l5r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r5";
            menter();
        }

        private void l5r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r6";
            menter();
        }

        private void l5r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r7";
            menter();
        }

        private void l5r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r8";
            menter();
        }

        private void l5r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l5r9";
            menter();
        }

        private void l5r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l6r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r1";
            menter();
        }

        private void l6r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r2";
            menter();
        }

        private void l6r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r3";
            menter();
        }

        private void l6r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r4";
            menter();
        }

        private void l6r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r5";
            menter();
        }

        private void l6r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r6";
            menter();
        }

        private void l6r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r7";
            menter();
        }

        private void l6r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r8";
            menter();
        }

        private void l6r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l6r9";
            menter();
        }

        private void l6r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l7r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r1";
            menter();
        }

        private void l7r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r2";
            menter();
        }

        private void l7r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r3";
            menter();
        }

        private void l8r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r1";
            menter();
        }

        private void l8r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r2";
            menter();
        }

        private void l8r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r3";
            menter();
        }

        private void l9r1_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r1";
            menter();
        }

        private void l9r2_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r2";
            menter();
        }

        private void l9r3_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r3";
            menter();
        }

        private void l7r1_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l7r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r4";
            menter();
        }

        private void l7r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r5";
            menter();
        }

        private void l7r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r6";
            menter();
        }

        private void l8r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r4";
            menter();
        }

        private void l8r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r5";
            menter();
        }

        private void l8r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r6";
            menter();
        }

        private void l9r4_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r4";
            menter();
        }

        private void l9r5_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r5";
            menter();
        }

        private void l9r6_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r6";
            menter();
        }

        private void l7r4_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        private void l7r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r7";
            menter();
        }

        private void l7r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r8";
            menter();
        }

        private void l7r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l7r9";
            menter();
        }

        private void l8r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r7";
            menter();
        }

        private void l8r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r8";
            menter();
        }

        private void l8r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l8r9";
            menter();
        }

        private void l9r7_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r7";
            menter();
        }

        private void l9r8_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r8";
            menter();
        }

        private void l9r9_MouseEnter(object sender, EventArgs e)
        {
            lblname = "l9r9";
            menter();
        }

        private void l7r7_MouseLeave(object sender, EventArgs e)
        {
            mleave();
        }

        void lblclick()
        {
            foreach (Label l in panel1.Controls.OfType<Label>())
            {
                //iga cell millel sama nr
                if(l.Text == lbltxt)
                {
                    l.ForeColor = Color.White;
                }
                //iga cell reas ja kolumis
                if(l.Name.Contains(line) || l.Name.Contains(row))
                {
                    l.BackColor = Color.FromArgb(35, 35, 35);
                    l.ForeColor = Color.White;
                }
                //iga cell mis ei ole reas ega columis
                else if(!l.Name.Contains(line) || !l.Name.Contains(row))
                {
                    if(l.Text != lbltxt)
                    {
                        l.BackColor = Color.FromArgb(25, 25, 25);
                        l.ForeColor = Color.Gray;
                    }
                    else
                    {
                        l.ForeColor = Color.White;
                        l.BackColor = Color.FromArgb(25, 25, 25);
                    }
                }
                //kui none
                else
                {
                    l.ForeColor = Color.Gray;
                    l.BackColor = Color.FromArgb(25, 25, 25);
                }
            }
        }
        private void l1r1_Click(object sender, EventArgs e)
        {
            row = "r1";
            line = "l1";

            lbltxt = l1r1.Text;
            lblclick();
        }

        private void l1r8_Click(object sender, EventArgs e)
        {
            row = "r8";
            line = "l1";
            lbltxt = l1r8.Text;
            lblclick();
        }

        private void l1r3_Click(object sender, EventArgs e)
        {
            row = "r3";
            line = "l1";
            lbltxt = l1r3.Text;
            lblclick();
        }

        private void l1r4_Click(object sender, EventArgs e)
        {
            row = "r4";
            line = "l1";
            lbltxt = l1r4.Text;
            lblclick();
        }

        private void l1r5_Click(object sender, EventArgs e)
        {
            row = "r5";
            line = "l1";
            lbltxt = l1r5.Text;
            lblclick();
        }

        private void l1r6_Click(object sender, EventArgs e)
        {
            row = "r6";
            line = "l1";
            lbltxt = l1r6.Text;
            lblclick();
        }

        private void l1r7_Click(object sender, EventArgs e)
        {
            row = "r7";
            line = "l1";
            lbltxt = l1r7.Text;
            lblclick();
        }

        private void l1r2_Click(object sender, EventArgs e)
        {
            row = "r2";
            line = "l1";
            lbltxt = l1r2.Text;
            lblclick();
        }

        private void l1r9_Click(object sender, EventArgs e)
        {
            row = "r9";
            line = "l1";
            lbltxt = l1r9.Text;
            lblclick();
        }

        private void l2r9_Click(object sender, EventArgs e)
        {
            row = "r9";
            line = "l2";

            lbltxt = l2r9.Text;
            lblclick();
        }

        private void l2r2_Click(object sender, EventArgs e)
        {
            row = "r2";
            line = "l2";
            lbltxt = l2r2.Text;
            lblclick();
        }

        private void l2r3_Click(object sender, EventArgs e)
        {
            row = "r3";
            line = "l2";
            lbltxt = l2r3.Text;
            lblclick();
        }

        private void l2r4_Click(object sender, EventArgs e)
        {
            row = "r4";
            line = "l2";
            lbltxt = l2r4.Text;
            lblclick();
        }

        private void l2r5_Click(object sender, EventArgs e)
        {
            row = "r5";
            line = "l2";
            lbltxt = l2r5.Text;
            lblclick();
        }

        private void l2r6_Click(object sender, EventArgs e)
        {
            row = "r6";
            line = "l2";
            lbltxt = l2r6.Text;
            lblclick();
        }

        private void l2r7_Click(object sender, EventArgs e)
        {
            row = "r7";
            line = "l2";
            lbltxt = l2r7.Text;
            lblclick();
        }

        private void l2r8_Click(object sender, EventArgs e)
        {
            row = "r8";
            line = "l2";
            lbltxt = l2r8.Text;
            lblclick();
        }

        private void l2r1_Click(object sender, EventArgs e)
        {
            row = "r1";
            line = "l2";
            lbltxt = l2r1.Text;
            lblclick();
        }

        private void l3r1_Click(object sender, EventArgs e)
        {
            lbltxt = l3r1.Text;
            lblclick();
        }

        private void l3r2_Click(object sender, EventArgs e)
        {
            lbltxt = l3r2.Text;
            lblclick();
        }

        private void l3r3_Click(object sender, EventArgs e)
        {
            lbltxt = l3r3.Text;
            lblclick();
        }

        private void l3r4_Click(object sender, EventArgs e)
        {
            lbltxt = l3r4.Text;
            lblclick();
        }

        private void l3r5_Click(object sender, EventArgs e)
        {
            lbltxt = l3r5.Text;
            lblclick();
        }

        private void l3r6_Click(object sender, EventArgs e)
        {
            lbltxt = l3r6.Text;
            lblclick();
        }

        private void l3r7_Click(object sender, EventArgs e)
        {
            lbltxt = l3r7.Text;
            lblclick();
        }

        private void l3r8_Click(object sender, EventArgs e)
        {
            lbltxt = l3r8.Text;
            lblclick();
        }

        private void l3r9_Click(object sender, EventArgs e)
        {
            lbltxt = l3r9.Text;
            lblclick();
        }

        private void l4r1_Click(object sender, EventArgs e)
        {
            lbltxt = l4r1.Text;
            lblclick();
        }

        private void l4r2_Click(object sender, EventArgs e)
        {
            lbltxt = l4r2.Text;
            lblclick();
        }

        private void l4r3_Click(object sender, EventArgs e)
        {
            lbltxt = l4r3.Text;
            lblclick();
        }

        private void l4r4_Click(object sender, EventArgs e)
        {
            lbltxt = l4r4.Text;
            lblclick();
        }

        private void l4r5_Click(object sender, EventArgs e)
        {
            lbltxt = l4r5.Text;
            lblclick();
        }

        private void l4r6_Click(object sender, EventArgs e)
        {
            lbltxt = l4r6.Text;
            lblclick();
        }

        private void l4r7_Click(object sender, EventArgs e)
        {
            lbltxt = l4r7.Text;
            lblclick();
        }

        private void l4r8_Click(object sender, EventArgs e)
        {
            lbltxt = l4r8.Text;
            lblclick();
        }

        private void l4r9_Click(object sender, EventArgs e)
        {
            lbltxt = l4r9.Text;
            lblclick();
        }

        private void l5r1_Click(object sender, EventArgs e)
        {
            lbltxt = l5r1.Text;
            lblclick();
        }

        private void l5r2_Click(object sender, EventArgs e)
        {
            lbltxt = l5r2.Text;
            lblclick();
        }

        private void l5r3_Click(object sender, EventArgs e)
        {
            lbltxt = l5r3.Text;
            lblclick();
        }

        private void l5r4_Click(object sender, EventArgs e)
        {
            lbltxt = l5r4.Text;
            lblclick();
        }

        private void l5r5_Click(object sender, EventArgs e)
        {
            lbltxt = l5r5.Text;
            lblclick();
        }

        private void l5r6_Click(object sender, EventArgs e)
        {
            lbltxt = l5r6.Text;
            lblclick();
        }

        private void l5r7_Click(object sender, EventArgs e)
        {
            lbltxt = l5r7.Text;
            lblclick();
        }

        private void l5r8_Click(object sender, EventArgs e)
        {
            lbltxt = l5r8.Text;
            lblclick();
        }

        private void l5r9_Click(object sender, EventArgs e)
        {
            lbltxt = l5r9.Text;
            lblclick();
        }

        private void l6r9_Click(object sender, EventArgs e)
        {
            lbltxt = l6r9.Text;
            lblclick();
        }

        private void l6r2_Click(object sender, EventArgs e)
        {
            lbltxt = l6r2.Text;
            lblclick();
        }

        private void l6r3_Click(object sender, EventArgs e)
        {
            lbltxt = l6r3.Text;
            lblclick();
        }

        private void l6r4_Click(object sender, EventArgs e)
        {
            lbltxt = l6r4.Text;
            lblclick();
        }

        private void l6r5_Click(object sender, EventArgs e)
        {
            lbltxt = l6r5.Text;
            lblclick();
        }

        private void l6r6_Click(object sender, EventArgs e)
        {
            lbltxt = l6r6.Text;
            lblclick();
        }

        private void l6r7_Click(object sender, EventArgs e)
        {
            lbltxt = l6r7.Text;
            lblclick();
        }

        private void l6r8_Click(object sender, EventArgs e)
        {
            lbltxt = l6r8.Text;
            lblclick();
        }

        private void l6r1_Click(object sender, EventArgs e)
        {
            lbltxt = l6r1.Text;
            lblclick();
        }

        private void l7r9_Click(object sender, EventArgs e)
        {
            lbltxt = l7r9.Text;
            lblclick();
        }

        private void l7r2_Click(object sender, EventArgs e)
        {
            lbltxt = l7r2.Text;
            lblclick();
        }

        private void l7r3_Click(object sender, EventArgs e)
        {
            lbltxt = l7r3.Text;
            lblclick();
        }

        private void l7r4_Click(object sender, EventArgs e)
        {
            lbltxt = l7r4.Text;
            lblclick();
        }

        private void l7r5_Click(object sender, EventArgs e)
        {
            lbltxt = l7r5.Text;
            lblclick();
        }

        private void l7r6_Click(object sender, EventArgs e)
        {
            lbltxt = l7r6.Text;
            lblclick();
        }

        private void l7r7_Click(object sender, EventArgs e)
        {
            lbltxt = l7r7.Text;
            lblclick();
        }

        private void l7r8_Click(object sender, EventArgs e)
        {
            lbltxt = l7r8.Text;
            lblclick();
        }

        private void l7r1_Click(object sender, EventArgs e)
        {
            lbltxt = l7r1.Text;
            lblclick();
        }

        private void l8r9_Click(object sender, EventArgs e)
        {
            lbltxt = l8r9.Text;
            lblclick();
        }

        private void l8r2_Click(object sender, EventArgs e)
        {
            lbltxt = l8r2.Text;
            lblclick();
        }

        private void l8r3_Click(object sender, EventArgs e)
        {
            lbltxt = l8r3.Text;
            lblclick();
        }

        private void l8r4_Click(object sender, EventArgs e)
        {
            lbltxt = l8r4.Text;
            lblclick();
        }

        private void l8r5_Click(object sender, EventArgs e)
        {
            lbltxt = l8r5.Text;
            lblclick();
        }

        private void l8r6_Click(object sender, EventArgs e)
        {
            lbltxt = l8r6.Text;
            lblclick();
        }

        private void l8r7_Click(object sender, EventArgs e)
        {
            lbltxt = l8r7.Text;
            lblclick();
        }

        private void l8r8_Click(object sender, EventArgs e)
        {
            lbltxt = l8r8.Text;
            lblclick();
        }

        private void l8r1_Click(object sender, EventArgs e)
        {
            lbltxt = l8r1.Text;
            lblclick();
        }

        private void l9r9_Click(object sender, EventArgs e)
        {
            lbltxt = l9r9.Text;
            lblclick();
        }

        private void l9r2_Click(object sender, EventArgs e)
        {
            lbltxt = l9r2.Text;
            lblclick();
        }

        private void l9r3_Click(object sender, EventArgs e)
        {
            lbltxt = l9r3.Text;
            lblclick();
        }

        private void l9r4_Click(object sender, EventArgs e)
        {
            lbltxt = l9r4.Text;
            lblclick();
        }

        private void l9r5_Click(object sender, EventArgs e)
        {
            lbltxt = l9r5.Text;
            lblclick();
        }

        private void l9r6_Click(object sender, EventArgs e)
        {
            lbltxt = l9r6.Text;
            lblclick();
        }

        private void l9r7_Click(object sender, EventArgs e)
        {
            lbltxt = l9r7.Text;
            lblclick();
        }

        private void l9r8_Click(object sender, EventArgs e)
        {
            lbltxt = l9r8.Text;
            lblclick();
        }

        private void l9r1_Click(object sender, EventArgs e)
        {
            lbltxt = l9r1.Text;
            lblclick();
        }
    }
}
