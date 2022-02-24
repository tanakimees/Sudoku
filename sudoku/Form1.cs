using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        string selectedcell = "";

        int easycomplete = 0;
        int mediumcomplete = 0;
        int hardcomplete = 0;

        string line = "s";
        string row = "s";
        string[] sudokudata = { };

        int bigcell = 0;

        string[] cell1 = { "l1r1","l1r2","l1r3", "l2r1", "l2r2", "l2r3", "l3r1", "l3r2", "l3r3" };
        string[] cell2 = { "l1r4", "l1r5", "l1r6", "l2r4", "l2r5", "l2r6", "l3r4", "l3r5", "l3r6" };
        string[] cell3 = { "l1r7", "l1r8", "l1r9", "l2r7", "l2r8", "l2r9", "l3r7", "l3r8", "l3r9" };
        string[] cell4 = { "l4r1", "l4r2", "l4r3", "l5r1", "l5r2", "l5r3", "l6r1", "l6r2", "l6r3" };
        string[] cell5 = { "l4r4", "l4r5", "l4r6", "l5r4", "l5r5", "l5r6", "l6r4", "l6r5", "l6r6" };
        string[] cell6 = { "l4r7", "l4r8", "l4r9", "l5r7", "l5r8", "l5r9", "l6r7", "l6r8", "l6r9" };
        string[] cell7 = { "l7r1", "l7r2", "l7r3", "l8r1", "l8r2", "l8r3", "l9r1", "l9r2", "l9r3" };
        string[] cell8 = { "l7r4", "l7r5", "l7r6", "l8r4", "l8r5", "l8r6", "l9r4", "l9r5", "l9r6" };
        string[] cell9 = { "l7r7", "l7r8", "l7r9", "l8r7", "l8r8", "l8r9", "l9r7", "l9r8", "l9r9" };

        string c1 = "";
        string c2 = "";
        string c3 = "";
        string c4 = "";
        string c5 = "";
        string c6 = "";
        string c7 = "";
        string c8 = "";
        string c9 = "";
        string c10 = "";
        string c11 = "";
        string c12 = "";
        string c13 = "";
        string c14 = "";
        string c15 = "";
        string c16 = "";
        string c17 = "";
        string c18 = "";
        string c19 = "";
        string c20 = "";
        string c21 = "";
        string c22 = "";
        string c23 = "";
        string c24 = "";
        string c25 = "";
        string c26 = "";
        string c27 = "";
        string c28 = "";
        string c29 = "";
        string c30 = "";
        string c31 = "";
        string c32 = "";
        string c33 = "";
        string c34 = "";
        string c35 = "";
        string c36 = "";
        string c37 = "";
        string c38 = "";
        string c39 = "";
        string c40 = "";
        string c41 = "";
        string c42 = "";
        string c43 = "";
        string c44 = "";
        string c45 = "";
        string c46 = "";
        string c47 = "";
        string c48 = "";
        string c49 = "";
        string c50 = "";
        string c51 = "";
        string c52 = "";
        string c53 = "";
        string c54 = "";
        string c55 = "";
        string c56 = "";
        string c57 = "";
        string c58 = "";
        string c59 = "";
        string c60 = "";
        string c61 = "";
        string c62 = "";
        string c63 = "";
        string c64 = "";
        string c65 = "";
        string c66 = "";
        string c67 = "";
        string c68 = "";
        string c69 = "";
        string c70 = "";
        string c71 = "";
        string c72 = "";
        string c73 = "";
        string c74 = "";
        string c75 = "";
        string c76 = "";
        string c77 = "";
        string c78 = "";
        string c79 = "";
        string c80 = "";
        string c81 = "";


        bool shift;
        bool nr1;
        bool nr2;
        bool nr3;
        bool nr4;
        bool nr5;
        bool nr6;
        bool nr7;
        bool nr8;
        bool nr9;

        int nr1c = 0;
        int nr2c = 0;
        int nr3c = 0;
        int nr4c = 0;
        int nr5c = 0;
        int nr6c = 0;
        int nr7c = 0;
        int nr8c = 0;
        int nr9c = 0;

        double opacity = 1;
        int topmost = 1;

        int selectedcolor = 1;

        Color dim0 = Color.FromArgb(25, 25, 25);
        Color dim1 = Color.FromArgb(35, 35, 35);
        Color dim2 = Color.FromArgb(45, 45, 45);
        Color bright0 = Color.FromArgb(128, 128, 128);
        Color bright1 = Color.FromArgb(255, 255, 255);
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
                l.BackColor = dim0;
                l.AutoSize = false;
                l.Text = "";
                l.Cursor = Cursors.Hand;
                l.ForeColor = bright0;
                string containslol = "h";
                if(l.Name.Contains(containslol))
                {
                    l.Visible = false;
                }
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
            label1.ForeColor = bright1;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if(selectedshit != 1)
            {
                label1.ForeColor = bright0;
            }
            else
            {
                label1.ForeColor = bright1;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = bright1;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (selectedshit != 2)
            {
                label2.ForeColor = bright0;
            }
            else
            {
                label2.ForeColor = bright1;
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = bright1;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (selectedshit != 3)
            {
                label3.ForeColor = bright0;
            }
            else
            {
                label3.ForeColor = bright1;
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedshit = 1;
            gamepanel.BringToFront();
            label1.ForeColor = bright1;
            label2.ForeColor = bright0;
            label3.ForeColor = bright0;
            panel4.BackColor = dim1;
            panel5.BackColor = dim2;
            panel6.BackColor = dim2;
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
            label1.ForeColor = bright0;
            label2.ForeColor = bright1;
            label3.ForeColor = bright0;
            panel4.BackColor = dim2;
            panel5.BackColor = dim1;
            panel6.BackColor = dim2;
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
            label1.ForeColor = bright0;
            label2.ForeColor = bright0;
            label3.ForeColor = bright1;
            panel4.BackColor = dim2;
            panel5.BackColor = dim2;
            panel6.BackColor = dim1;
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
            label21.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = bright1;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = bright0;
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

                savedata();
            }
        }

        void savedata()
        {
            c1 = l1r1.Text;
            c2 = l1r2.Text;
            c3 = l1r3.Text;
            c4 = l1r4.Text;
            c5 = l1r5.Text;
            c6 = l1r6.Text;
            c7 = l1r7.Text;
            c8 = l1r8.Text;
            c9 = l1r9.Text;
            c10 = l2r1.Text;
            c11 = l2r2.Text;
            c12 = l2r3.Text;
            c13 = l2r4.Text;
            c14 = l2r5.Text;
            c15 = l2r6.Text;
            c16 = l2r7.Text;
            c17 = l2r8.Text;
            c18 = l2r9.Text;
            c19 = l3r1.Text;
            c20 = l3r2.Text;
            c21 = l3r3.Text;
            c22 = l3r4.Text;
            c23 = l3r5.Text;
            c24 = l3r6.Text;
            c25 = l3r7.Text;
            c26 = l3r8.Text;
            c27 = l3r9.Text;
            c28 = l4r1.Text;
            c29 = l4r2.Text;
            c30 = l4r3.Text;
            c31 = l4r4.Text;
            c32 = l4r5.Text;
            c33 = l4r6.Text;
            c34 = l4r7.Text;
            c35 = l4r8.Text;
            c36 = l4r9.Text;
            c37 = l5r1.Text;
            c38 = l5r2.Text;
            c39 = l5r3.Text;
            c40 = l5r4.Text;
            c41 = l5r5.Text;
            c42 = l5r6.Text;
            c43 = l5r7.Text;
            c44 = l5r8.Text;
            c45 = l5r9.Text;
            c46 = l6r1.Text;
            c47 = l6r2.Text;
            c48 = l6r3.Text;
            c49 = l6r4.Text;
            c50 = l6r5.Text;
            c51 = l6r6.Text;
            c52 = l6r7.Text;
            c53 = l6r8.Text;
            c54 = l6r9.Text;
            c55 = l7r1.Text;
            c56 = l7r2.Text;
            c57 = l7r3.Text;
            c58 = l7r4.Text;
            c59 = l7r5.Text;
            c60 = l7r6.Text;
            c61 = l7r7.Text;
            c62 = l7r8.Text;
            c63 = l7r9.Text;
            c64 = l8r1.Text;
            c65 = l8r2.Text;
            c66 = l8r3.Text;
            c67 = l8r4.Text;
            c68 = l8r5.Text;
            c69 = l8r6.Text;
            c70 = l8r7.Text;
            c71 = l8r8.Text;
            c72 = l8r9.Text;
            c73 = l9r1.Text;
            c74 = l9r2.Text;
            c75 = l9r3.Text;
            c76 = l9r4.Text;
            c77 = l9r5.Text;
            c78 = l9r6.Text;
            c79 = l9r7.Text;
            c80 = l9r8.Text;
            c81 = l9r9.Text;
            removenr.Start();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = bright1;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if(label4.Text == "Difficulty ↑")
            {
                label4.ForeColor = bright1;
            }
            else
            {
                label4.ForeColor = bright0;
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
            label13.ForeColor = bright1;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = bright0;
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
                        l.ForeColor = bright0;
                        l.BackColor = dim0;
                        row = "s";
                        line = "s";
                        lblname = "";
                        bigcell = 0;
                        lbltxt = "";
                    }
                    createsudoku.Start();
                    sudokualreadycreated = 0;

                    nr1c = 0;
                    nr2c = 0;
                    nr3c = 0;
                    nr4c = 0;
                    nr5c = 0;
                    nr6c = 0;
                    nr7c = 0;
                    nr8c = 0;
                    nr9c = 0;

                    foreach(Label l in panel12.Controls.OfType<Label>())
                    {
                        if(l.Name.Contains("r"))
                        {
                            l.Text = "0";
                        }
                    }
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
            label10.ForeColor = bright1;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            if(difficulty == 1)
            {
                label10.ForeColor = bright1;
            }
            else
            {
                label10.ForeColor = bright0;
            }
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = bright1;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            if (difficulty == 2)
            {
                label11.ForeColor = bright1;
            }
            else
            {
                label11.ForeColor = bright0;
            }
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = bright1;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            if (difficulty == 3)
            {
                label12.ForeColor = bright1;
            }
            else
            {
                label12.ForeColor = bright0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            label11.ForeColor = bright0;
            label12.ForeColor = bright0;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            label10.ForeColor = bright0;
            label12.ForeColor = bright0;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            label11.ForeColor = bright0;
            label10.ForeColor = bright0;
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
                    countnr();
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
                    countnr();
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
                    countnr();
                    sudokualreadycreated = 1;
                    idk = 0;
                }
            }

        }

        void countnr()
        {
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
             
                if (!l.Name.Contains("h"))
                {
                    if(l.Text == "1")
                    {
                        nr1c++;
                    }
                    else if (l.Text == "2")
                    {
                        nr2c++;
                    }
                    else if (l.Text == "3")
                    {
                        nr3c++;
                    }
                    else if (l.Text == "4")
                    {
                        nr4c++;
                    }
                    else if (l.Text == "5")
                    {
                        nr5c++;
                    }
                    else if (l.Text == "6")
                    {
                        nr6c++;
                    }
                    else if (l.Text == "7")
                    {
                        nr7c++;
                    }
                    else if (l.Text == "8")
                    {
                        nr8c++;
                    }
                    else if (l.Text == "9")
                    {
                        nr9c++;
                    }
                }
                all1r.Text = nr1c.ToString();
                all2r.Text = nr2c.ToString();
                all3r.Text = nr3c.ToString();
                all4r.Text = nr4c.ToString();
                all5r.Text = nr5c.ToString();
                all6r.Text = nr6c.ToString();
                all7r.Text = nr7c.ToString();
                all8r.Text = nr8c.ToString();
                all9r.Text = nr9c.ToString();
            }
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = bright1;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = bright0;
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
                l.ForeColor = bright0;
                l.BackColor = dim0;
                row = "s";
                line = "s";
                lblname = "";
                lbltxt = "";
                bigcell = 0;
                string includethatshet = "h";
                if(l.Name.Contains(includethatshet))
                {
                    l.Visible = false;
                    l.Text = "";
                }

            }
            selectedcell = "";
            bigcell = 0;
            nr1c = 0;
            nr2c = 0;
            nr3c = 0;
            nr4c = 0;
            nr5c = 0;
            nr6c = 0;
            nr7c = 0;
            nr8c = 0;
            nr9c = 0;
            foreach(Label l3 in panel12.Controls.OfType<Label>())
            {
                if (l3.Name.Contains("r"))
                {
                    l3.Text = "0";
                }
            }
        }

        void menter()
        {
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(l.Name == lblname)
                {
                    red = l.BackColor.R;
                    l.ForeColor = bright1;
                    l.BackColor = dim1;          
                }
                if(l.Name.Contains(lblname) && l.Name.Contains("h"))
                {
                    l.BackColor = dim1;
                }
            }
        }

        int red;
        //DIPSHIT UI
        void mleave()
        {
            foreach (Label l in panel1.Controls.OfType<Label>())
            {
                if (l.Name == lblname)
                {
                    if (l.Name.Contains(line) || l.Name.Contains(row))
                    {
                        l.ForeColor = bright1;
                        l.BackColor = dim1;
                    }
                    else if (l.Text != lbltxt && l.ForeColor != Color.White && l.BackColor != dim1)
                    {
                        l.BackColor = dim0;
                        l.ForeColor = bright0;
                    }
                    else if(bigcell != 0)
                    {
                        if (bigcell == 1)
                        {
                            if (cell1.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 2)
                        {
                            if (cell2.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 3)
                        {
                            if (cell3.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 4)
                        {
                            if (cell4.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 5)
                        {
                            if (cell5.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 6)
                        {
                            if (cell6.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 7)
                        {
                            if (cell7.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 8)
                        {
                            if (cell8.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                        else if (bigcell == 9)
                        {
                            if (cell9.Contains(l.Name))
                            {
                                l.BackColor = dim1;
                                l.ForeColor = bright1;
                            }
                            else
                            {
                                l.BackColor = dim0;
                                l.ForeColor = bright0;
                            }
                        }
                    }
                    else
                    {
                        l.BackColor = dim0;
                        l.ForeColor = bright0;
                    }
                    
                }

                if(l.Text == lbltxt)
                {
                    l.ForeColor = bright1;
                }
                if(l.Name == lblname)
                {
                    red = l.BackColor.R;
                    dotheshitneeded();
                }
            }
        }

        void dotheshitneeded()
        {
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(l.Name.Contains(lblname) && l.Name.Contains("h"))
                {
                    l.BackColor = Color.FromArgb(red, red, red);
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
            selectedcell = line + row;
            foreach (Label l in panel1.Controls.OfType<Label>())
            {
                //iga cell millel sama nr
                if(l.Text == lbltxt)
                {
                    l.ForeColor = bright1;
                }
                //iga cell reas ja kolumis
                if(l.Name.Contains(line) || l.Name.Contains(row))
                {
                    l.BackColor = dim1;
                    l.ForeColor = bright1;
                }
                //iga cell mis ei ole reas ega columis
                else if(!l.Name.Contains(line) || !l.Name.Contains(row))
                {
                    if(l.Text != lbltxt)
                    {
                        l.BackColor = dim0;
                        l.ForeColor = bright0;
                    }
                    else
                    {
                        l.ForeColor = bright1;
                        l.BackColor = dim0;
                    }
                }
                //kui none
                else
                {
                    l.ForeColor = bright0;
                    l.BackColor = dim0;
                }
            }

            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if (bigcell != 0)
                {
                    if (bigcell == 1)
                    {
                        if (cell1.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 2)
                    {
                        if (cell2.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 3)
                    {
                        if (cell3.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 4)
                    {
                        if (cell4.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 5)
                    {
                        if (cell5.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 6)
                    {
                        if (cell6.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 7)
                    {
                        if (cell7.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 8)
                    {
                        if (cell8.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                    else if (bigcell == 9)
                    {
                        if (cell9.Contains(l.Name))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
            }

            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(bigcell == 1)
                {
                    if(cell1.Any(l.Name.Contains))
                    {
                        if(l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 2)
                {
                    if (cell2.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 3)
                {
                    if (cell3.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 4)
                {
                    if (cell4.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 5)
                {
                    if (cell5.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 6)
                {
                    if (cell6.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 7)
                {
                    if (cell7.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 8)
                {
                    if (cell8.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
                if (bigcell == 9)
                {
                    if (cell9.Any(l.Name.Contains))
                    {
                        if (l.Name.Contains("h"))
                        {
                            l.BackColor = dim1;
                            l.ForeColor = bright1;
                        }
                    }
                }
            }

        }
        private void l1r1_Click(object sender, EventArgs e)
        {
            row = "r1";
            line = "l1";
            bigcell = 1;
            lbltxt = l1r1.Text;
            lblclick();
        }

        private void l1r8_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            row = "r8";
            line = "l1";
            lbltxt = l1r8.Text;
            lblclick();
        }

        private void l1r3_Click(object sender, EventArgs e)
        {
            row = "r3";
            line = "l1";
            bigcell = 1;
            lbltxt = l1r3.Text;
            lblclick();
        }

        private void l1r4_Click(object sender, EventArgs e)
        {
            row = "r4";
            line = "l1";
            bigcell = 2;
            lbltxt = l1r4.Text;
            lblclick();
        }

        private void l1r5_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            row = "r5";
            line = "l1";
            lbltxt = l1r5.Text;
            lblclick();
        }

        private void l1r6_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            row = "r6";
            line = "l1";
            lbltxt = l1r6.Text;
            lblclick();
        }

        private void l1r7_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            row = "r7";
            line = "l1";
            lbltxt = l1r7.Text;
            lblclick();
        }

        private void l1r2_Click(object sender, EventArgs e)
        {
            row = "r2";
            line = "l1";
            bigcell = 1;
            lbltxt = l1r2.Text;
            lblclick();
        }

        private void l1r9_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            row = "r9";
            line = "l1";
            lbltxt = l1r9.Text;
            lblclick();
        }

        private void l2r9_Click(object sender, EventArgs e)
        {
            row = "r9";
            line = "l2";
            bigcell = 3;
            lbltxt = l2r9.Text;
            lblclick();
        }

        private void l2r2_Click(object sender, EventArgs e)
        {
            row = "r2";
            line = "l2";
            bigcell = 1;
            lbltxt = l2r2.Text;
            lblclick();
        }

        private void l2r3_Click(object sender, EventArgs e)
        {
            row = "r3";
            bigcell = 1;
            line = "l2";
            lbltxt = l2r3.Text;
            lblclick();
        }

        private void l2r4_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            row = "r4";
            line = "l2";
            lbltxt = l2r4.Text;
            lblclick();
        }

        private void l2r5_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            row = "r5";
            line = "l2";
            lbltxt = l2r5.Text;
            lblclick();
        }

        private void l2r6_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            row = "r6";
            line = "l2";
            lbltxt = l2r6.Text;
            lblclick();
        }

        private void l2r7_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            row = "r7";
            line = "l2";
            lbltxt = l2r7.Text;
            lblclick();
        }

        private void l2r8_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            row = "r8";
            line = "l2";
            lbltxt = l2r8.Text;
            lblclick();
        }

        private void l2r1_Click(object sender, EventArgs e)
        {
            row = "r1";
            line = "l2";
            bigcell = 1;
            lbltxt = l2r1.Text;
            lblclick();
        }

        private void l3r1_Click(object sender, EventArgs e)
        {
            line = "l3";
            row = "r1";
            bigcell = 1;
            lbltxt = l3r1.Text;
            lblclick();
        }

        private void l3r2_Click(object sender, EventArgs e)
        {
            line = "l3";
            row = "r2";
            bigcell = 1;
            lbltxt = l3r2.Text;
            lblclick();
        }

        private void l3r3_Click(object sender, EventArgs e)
        {
            line = "l3";
            bigcell = 1;
            row = "r3";
            lbltxt = l3r3.Text;
            lblclick();
        }

        private void l3r4_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            line = "l3";
            row = "r4";
            lbltxt = l3r4.Text;
            lblclick();
        }

        private void l3r5_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            line = "l3";
            row = "r5";
            lbltxt = l3r5.Text;
            lblclick();
        }

        private void l3r6_Click(object sender, EventArgs e)
        {
            bigcell = 2;
            line = "l3";
            row = "r6";
            lbltxt = l3r6.Text;
            lblclick();
        }

        private void l3r7_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            line = "l3";
            row = "r7";
            lbltxt = l3r7.Text;
            lblclick();
        }

        private void l3r8_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            line = "l3";
            row = "r8";
            lbltxt = l3r8.Text;
            lblclick();
        }

        private void l3r9_Click(object sender, EventArgs e)
        {
            bigcell = 3;
            line = "l3";
            row = "r9";
            lbltxt = l3r9.Text;
            lblclick();
        }

        private void l4r1_Click(object sender, EventArgs e)
        {
            line = "l4";
            bigcell = 4;
            row = "r1";
            lbltxt = l4r1.Text;
            lblclick();
        }

        private void l4r2_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l4";
            row = "r2";
            lbltxt = l4r2.Text;
            lblclick();
        }

        private void l4r3_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l4";
            row = "r3";
            lbltxt = l4r3.Text;
            lblclick();
        }

        private void l4r4_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l4";
            row = "r4";
            lbltxt = l4r4.Text;
            lblclick();
        }

        private void l4r5_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l4";
            row = "r5";
            lbltxt = l4r5.Text;
            lblclick();
        }

        private void l4r6_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l4";
            row = "r6";
            lbltxt = l4r6.Text;
            lblclick();
        }

        private void l4r7_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l4";
            row = "r7";
            lbltxt = l4r7.Text;
            lblclick();
        }

        private void l4r8_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l4";
            row = "r8";
            lbltxt = l4r8.Text;
            lblclick();
        }

        private void l4r9_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l4";
            row = "r9";
            lbltxt = l4r9.Text;
            lblclick();
        }

        private void l5r1_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l5";
            row = "r1";
            lbltxt = l5r1.Text;
            lblclick();
        }

        private void l5r2_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l5";
            row = "r2";
            lbltxt = l5r2.Text;
            lblclick();
        }

        private void l5r3_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l5";
            row = "r3";
            lbltxt = l5r3.Text;
            lblclick();
        }

        private void l5r4_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l5";
            row = "r4";
            lbltxt = l5r4.Text;
            lblclick();
        }

        private void l5r5_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l5";
            row = "r5";
            lbltxt = l5r5.Text;
            lblclick();
        }

        private void l5r6_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l5";
            row = "r6";
            lbltxt = l5r6.Text;
            lblclick();
        }

        private void l5r7_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l5";
            row = "r7";
            lbltxt = l5r7.Text;
            lblclick();
        }

        private void l5r8_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l5";
            row = "r8";
            lbltxt = l5r8.Text;
            lblclick();
        }

        private void l5r9_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l5";
            row = "r9";
            lbltxt = l5r9.Text;
            lblclick();
        }

        private void l6r9_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l6";
            row = "r9";
            lbltxt = l6r9.Text;
            lblclick();
        }

        private void l6r2_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l6";
            row = "r2";
            lbltxt = l6r2.Text;
            lblclick();
        }

        private void l6r3_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l6";
            row = "r3";
            lbltxt = l6r3.Text;
            lblclick();
        }

        private void l6r4_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l6";
            row = "r4";
            lbltxt = l6r4.Text;
            lblclick();
        }

        private void l6r5_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l6";
            row = "r5";
            lbltxt = l6r5.Text;
            lblclick();
        }

        private void l6r6_Click(object sender, EventArgs e)
        {
            bigcell = 5;
            line = "l6";
            row = "r6";
            lbltxt = l6r6.Text;
            lblclick();
        }

        private void l6r7_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l6";
            row = "r7";
            lbltxt = l6r7.Text;
            lblclick();
        }

        private void l6r8_Click(object sender, EventArgs e)
        {
            bigcell = 6;
            line = "l6";
            row = "r8";
            lbltxt = l6r8.Text;
            lblclick();
        }

        private void l6r1_Click(object sender, EventArgs e)
        {
            bigcell = 4;
            line = "l6";
            row = "r1";
            lbltxt = l6r1.Text;
            lblclick();
        }

        private void l7r9_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l7";
            row = "r9";
            lbltxt = l7r9.Text;
            lblclick();
        }

        private void l7r2_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l7";
            row = "r2";
            lbltxt = l7r2.Text;
            lblclick();
        }

        private void l7r3_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l7";
            row = "r3";
            lbltxt = l7r3.Text;
            lblclick();
        }

        private void l7r4_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l7";
            row = "r4";
            lbltxt = l7r4.Text;
            lblclick();
        }

        private void l7r5_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l7";
            row = "r5";
            lbltxt = l7r5.Text;
            lblclick();
        }

        private void l7r6_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l7";
            row = "r6";
            lbltxt = l7r6.Text;
            lblclick();
        }

        private void l7r7_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l7";
            row = "r7";
            lbltxt = l7r7.Text;
            lblclick();
        }

        private void l7r8_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l7";
            row = "r8";
            lbltxt = l7r8.Text;
            lblclick();
        }

        private void l7r1_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l7";
            row = "r1";
            lbltxt = l7r1.Text;
            lblclick();
        }

        private void l8r9_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l8";
            row = "r9";
            lbltxt = l8r9.Text;
            lblclick();
        }

        private void l8r2_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l8";
            row = "r2";
            lbltxt = l8r2.Text;
            lblclick();
        }

        private void l8r3_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l8";
            row = "r3";
            lbltxt = l8r3.Text;
            lblclick();
        }

        private void l8r4_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l8";
            row = "r4";
            lbltxt = l8r4.Text;
            lblclick();
        }

        private void l8r5_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l8";
            row = "r5";
            lbltxt = l8r5.Text;
            lblclick();
        }

        private void l8r6_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l8";
            row = "r6";
            lbltxt = l8r6.Text;
            lblclick();
        }

        private void l8r7_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l8";
            row = "r7";
            lbltxt = l8r7.Text;
            lblclick();
        }

        private void l8r8_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l8";
            row = "r8";
            lbltxt = l8r8.Text;
            lblclick();
        }

        private void l8r1_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l8";
            row = "r1";
            lbltxt = l8r1.Text;
            lblclick();
        }

        private void l9r9_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l9";
            row = "r9";
            lbltxt = l9r9.Text;
            lblclick();
        }

        private void l9r2_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l9";
            row = "r2";
            lbltxt = l9r2.Text;
            lblclick();
        }

        private void l9r3_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l9";
            row = "r3";
            lbltxt = l9r3.Text;
            lblclick();
        }

        private void l9r4_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l9";
            row = "r4";
            lbltxt = l9r4.Text;
            lblclick();
        }

        private void l9r5_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l9";
            row = "r5";
            lbltxt = l9r5.Text;
            lblclick();
        }

        private void l9r6_Click(object sender, EventArgs e)
        {
            bigcell = 8;
            line = "l9";
            row = "r6";
            lbltxt = l9r6.Text;
            lblclick();
        }

        private void l9r7_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l9";
            row = "r7";
            lbltxt = l9r7.Text;
            lblclick();
        }

        private void l9r8_Click(object sender, EventArgs e)
        {
            bigcell = 9;
            line = "l9";
            row = "r8";
            lbltxt = l9r8.Text;
            lblclick();
        }

        private void l9r1_Click(object sender, EventArgs e)
        {
            bigcell = 7;
            line = "l9";
            row = "r1";
            lbltxt = l9r1.Text;
            lblclick();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey)
            {
                shift = true;
            }
            if (e.KeyCode == Keys.D1)
            {
                nr1 = true;
            }
            if (e.KeyCode == Keys.D2)
            {
                nr2 = true;
            }
            if (e.KeyCode == Keys.D3)
            {
                nr3 = true;
            }
            if (e.KeyCode == Keys.D4)
            {
                nr4 = true;
            }
            if (e.KeyCode == Keys.D5)
            {
                nr5 = true;
            }
            if (e.KeyCode == Keys.D6)
            {
                nr6 = true;
            }
            if (e.KeyCode == Keys.D7)
            {
                nr7 = true;
            }
            if (e.KeyCode == Keys.D8)
            {
                nr8 = true;
            }
            if (e.KeyCode == Keys.D9)
            {
                nr9 = true;
            }
            if(nr1 && !shift)
            {
                foreach(Label l in panel1.Controls.OfType<Label>())
                {
                    if(l.Name == selectedcell)
                    {
                        if(l.Text == "")
                        {
                            lesslines1();
                            l.Text = "1";
                            nr1c++;
                            all1r.Text = nr1c.ToString();
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "1")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if(bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if(l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "1")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if(l.Text == "1")
                        {
                            l.Text = "";
                            nr1c--;
                            all1r.Text = nr1c.ToString();
                            lesslines1();
                        }
                    }
                }          
            }
            if (nr2 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr2c++;
                            all2r.Text = nr2c.ToString();
                            l.Text = "2";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "2")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "2")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "2")
                        {
                            l.Text = "";
                            nr2c--;
                            all2r.Text = nr2c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr3 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            l.Text = "3";
                            nr3c++;
                            all3r.Text = nr3c.ToString();
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "3")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "3")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "3")
                        {
                            l.Text = "";
                            nr3c--;
                            all3r.Text = nr3c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr4 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr4c++;
                            all4r.Text = nr4c.ToString();
                            l.Text = "4";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "4")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "4")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "4")
                        {
                            l.Text = "";
                            nr4c--;
                            all4r.Text = nr4c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr5 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr5c++;
                            all5r.Text = nr5c.ToString();
                            l.Text = "5";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "5")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "5")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "5")
                        {
                            l.Text = "";
                            nr5c--;
                            all5r.Text = nr5c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr6 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr6c++;
                            all6r.Text = nr6c.ToString();
                            l.Text = "6";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "6")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "6")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "6")
                        {
                            l.Text = "";
                            nr6c--;
                            all6r.Text = nr6c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr7 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr7c++;
                            all7r.Text = nr7c.ToString();
                            l.Text = "7";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "7")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "7")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "7")
                        {
                            l.Text = "";
                            nr7c--;
                            all7r.Text = nr7c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr8 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            lesslines1();
                            nr8c++;
                            all8r.Text = nr8c.ToString();
                            l.Text = "8";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "8")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "8")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "8")
                        {
                            l.Text = "";
                            nr8c--;
                            all8r.Text = nr8c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if (nr9 && !shift)
            {
                foreach (Label l in panel1.Controls.OfType<Label>())
                {
                    if (l.Name == selectedcell)
                    {
                        if (l.Text == "")
                        {
                            nr9c++;
                            all9r.Text = nr9c.ToString();
                            lesslines1();
                            l.Text = "9";
                            foreach (Label l2 in panel1.Controls.OfType<Label>())
                            {
                                if (l2.Name.Contains(line) || l2.Name.Contains(row))
                                {
                                    if (l2.Name.Contains("h"))
                                    {
                                        if (l2.Text == "9")
                                        {
                                            l2.Text = "";
                                        }
                                    }
                                }
                                if (bigcell == 1)
                                {
                                    if (cell1.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 2)
                                {
                                    if (cell2.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 3)
                                {
                                    if (cell3.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 4)
                                {
                                    if (cell4.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 5)
                                {
                                    if (cell5.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 6)
                                {
                                    if (cell6.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 7)
                                {
                                    if (cell7.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 8)
                                {
                                    if (cell8.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                                if (bigcell == 9)
                                {
                                    if (cell9.Any(l2.Name.Contains))
                                    {
                                        if (l2.Name.Contains("h"))
                                        {
                                            if (l2.Text == "9")
                                            {
                                                l2.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (l.Text == "9")
                        {
                            l.Text = "";
                            nr9c--;
                            all9r.Text = nr9c.ToString();
                            lesslines1();
                        }
                    }
                }
            }
            if(shift)
            {
                if(nr1)
                {
                    foreach(Label l in panel1.Controls.OfType<Label>())
                    {
                        if(l.Name == selectedcell)
                        {
                            if(l.Text == "")
                            {
                                foreach(Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if(l1.Name == selectedcell + "h1")
                                    {
                                        if(l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "1";
                                        }
                                        else if(l1.Text == "1")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr2)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h2")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "2";
                                        }
                                        else if (l1.Text == "2")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr3)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h3")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "3";
                                        }
                                        else if (l1.Text == "3")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr4)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h4")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "4";
                                        }
                                        else if (l1.Text == "4")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr5)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h5")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "5";
                                        }
                                        else if (l1.Text == "5")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr6)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h6")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "6";
                                        }
                                        else if (l1.Text == "6")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr7)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h7")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "7";
                                        }
                                        else if (l1.Text == "7")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr8)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h8")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "8";
                                        }
                                        else if (l1.Text == "8")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (nr9)
                {
                    foreach (Label l in panel1.Controls.OfType<Label>())
                    {
                        if (l.Name == selectedcell)
                        {
                            if (l.Text == "")
                            {
                                foreach (Label l1 in panel1.Controls.OfType<Label>())
                                {
                                    if (l1.Name == selectedcell + "h9")
                                    {
                                        if (l1.Text == "")
                                        {
                                            l1.Visible = true;
                                            l1.Text = "9";
                                        }
                                        else if (l1.Text == "9")
                                        {
                                            l1.Visible = false;
                                            l1.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void lesslines1()
        {
            string includeslol = "h";
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(l.Name.Contains(selectedcell + includeslol))
                {
                    l.Visible = false;
                    l.Text = "";
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shift = false;
            }
            if (e.KeyCode == Keys.D1)
            {
                nr1 = false;
            }
            if (e.KeyCode == Keys.D2)
            {
                nr2 = false;
            }
            if (e.KeyCode == Keys.D3)
            {
                nr3 = false;
            }
            if (e.KeyCode == Keys.D4)
            {
                nr4 = false;
            }
            if (e.KeyCode == Keys.D5)
            {
                nr5 = false;
            }
            if (e.KeyCode == Keys.D6)
            {
                nr6 = false;
            }
            if (e.KeyCode == Keys.D7)
            {
                nr7 = false;
            }
            if (e.KeyCode == Keys.D8)
            {
                nr8 = false;
            }
            if (e.KeyCode == Keys.D9)
            {
                nr9 = false;
            }
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = bright1;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = bright0;
        }

        int x = 0;
        private void label8_Click(object sender, EventArgs e)
        {
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                if(!l.Name.Contains("h"))
                {
                    if(l.Text == "")
                    {
                        x++;
                        if(x == 1)
                        {
                            MessageBox.Show("Sudoku is wrong or incomplete.", "WRONG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if(l.Text != "")
                    {
                        if(l1r1.Text == c1 && l1r2.Text == c2 && l1r3.Text == c3 && l1r4.Text == c4 && l1r5.Text == c5 && l1r6.Text == c6 && l1r7.Text == c7 && l1r8.Text == c8 && l1r9.Text == c9)
                        {
                            if (l2r1.Text == c10 && l2r2.Text == c11 && l2r3.Text == c12 && l2r4.Text == c13 && l2r5.Text == c14 && l2r6.Text == c15 && l2r7.Text == c16 && l2r8.Text == c17 && l2r9.Text == c18)
                            {
                                if (l3r1.Text == c19 && l3r2.Text == c20 && l3r3.Text == c21 && l3r4.Text == c22 && l3r5.Text == c23 && l3r6.Text == c24 && l3r7.Text == c25 && l3r8.Text == c26 && l3r9.Text == c27)
                                {
                                    if (l4r1.Text == c28 && l4r2.Text == c29 && l4r3.Text == c30 && l4r4.Text == c31 && l4r5.Text == c32 && l4r6.Text == c33 && l4r7.Text == c34 && l4r8.Text == c35 && l4r9.Text == c36)
                                    {
                                        if (l5r1.Text == c37 && l5r2.Text == c38 && l5r3.Text == c39 && l5r4.Text == c40 && l5r5.Text == c41 && l5r6.Text == c42 && l5r7.Text == c43 && l5r8.Text == c44 && l5r9.Text == c45)
                                        {
                                            if (l6r1.Text == c46 && l6r2.Text == c47 && l6r3.Text == c48 && l6r4.Text == c49 && l6r5.Text == c50 && l6r6.Text == c51 && l6r7.Text == c52 && l6r8.Text == c53 && l6r9.Text == c54)
                                            {
                                                if (l7r1.Text == c55 && l7r2.Text == c56 && l7r3.Text == c57 && l7r4.Text == c58 && l7r5.Text == c59 && l7r6.Text == c60 && l7r7.Text == c61 && l7r8.Text == c62 && l7r9.Text == c63)
                                                {
                                                    if (l8r1.Text == c64 && l8r2.Text == c65 && l8r3.Text == c66 && l8r4.Text == c67 && l8r5.Text == c68 && l8r6.Text == c69 && l8r7.Text == c70 && l8r8.Text == c71 && l8r9.Text == c72)
                                                    {
                                                        if (l9r1.Text == c73 && l9r2.Text == c74 && l9r3.Text == c75 && l9r4.Text == c76 && l9r5.Text == c77 && l9r6.Text == c78 && l9r7.Text == c79 && l9r8.Text == c80 && l9r9.Text == c81)
                                                        {
                                                            if(x == 0)
                                                            {
                                                                MessageBox.Show("Sudoku is complete.", "CORRECT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                if(difficulty == 1)
                                                                {
                                                                    easycomplete += 1;
                                                                    label22.Text = easycomplete.ToString();
                                                                }
                                                                else if (difficulty == 2)
                                                                {
                                                                    mediumcomplete += 1;
                                                                    label23.Text = mediumcomplete.ToString();
                                                                }
                                                                else if (difficulty == 3)
                                                                {
                                                                    hardcomplete += 1;
                                                                    label24.Text = hardcomplete.ToString();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        else
                        {
                            if (x == 0)
                            {
                                MessageBox.Show("Sudoku is wrong or incomplete.", "WRONG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }    
                        }
                    }
                }
            }
            x = 0;
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            label26.ForeColor = bright1;
        }

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            label26.ForeColor = bright0;
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            label27.ForeColor = bright1;
        }

        private void label27_MouseLeave(object sender, EventArgs e)
        {
            label27.ForeColor = bright0;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (opacity <= 0.9)
            {
                opacity += 0.1;
                this.Opacity = opacity;
                label28.Text = opacity.ToString();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (opacity >= 0.6)
            {
                opacity -= 0.1;
                this.Opacity = opacity;
                label28.Text = opacity.ToString();
            }
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            label30.ForeColor = bright1;
            label30.BackColor = dim2;
        }

        private void label30_MouseLeave(object sender, EventArgs e)
        {
            if(selectedcolor != 1)
            {
                label30.ForeColor = bright0;
                label30.BackColor = dim1;
            }
            else
            {
                label30.ForeColor = bright1;
                label30.BackColor = dim2;
            }
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            label31.ForeColor = bright1;
            label31.BackColor = dim2;
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 2)
            {
                label31.ForeColor = bright0;
                label31.BackColor = dim1;
            }
            else
            {
                label31.ForeColor = bright1;
                label31.BackColor = dim2;
            }
        }

        void makelabelok()
        {
            foreach(Label l in panel22.Controls.OfType<Label>())
            {
                    l.BackColor = dim1;
                    l.ForeColor = bright0;
            }
        }

        void resetcolor()
        {
            label30.ForeColor = bright1;
            label30.BackColor = dim2;
            this.BackColor = dim1;
            textBox1.BackColor = bright0;
            textBox2.BackColor = bright0;
            textBox3.BackColor = bright0;
            textBox4.BackColor = bright0;
            panel3.BackColor = dim2;
            foreach(TextBox tb in panel3.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label7.ForeColor = bright1;
            label9.ForeColor = bright0;
            panel2.BackColor = dim2;
            foreach(TextBox tb in panel2.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            panel4.BackColor = dim2;
            foreach(TextBox tb in panel4.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label1.ForeColor = bright0;
            panel5.BackColor = dim1;
            foreach (TextBox tb in panel5.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label2.ForeColor = bright1;
            panel6.BackColor = dim2;
            foreach (TextBox tb in panel6.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label3.ForeColor = bright0;
            settingspanel.BackColor = dim1;
            gamepanel.BackColor = dim1;
            aboutpanel.BackColor = dim1;
            panel18.BackColor = dim0;
            foreach (TextBox tb in panel18.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach(Label l in panel18.Controls.OfType<Label>())
            {
                l.ForeColor = bright0;
            }
            panel19.BackColor = dim0;
            foreach (TextBox tb in panel19.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label29.ForeColor = bright0;
            foreach (TextBox tb in panel22.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (Label l in panel22.Controls.OfType<Label>())
            {
                l.ForeColor = bright0;
                l.BackColor = dim1;
            }
            panel14.BackColor = dim0;
            foreach (TextBox tb in panel14.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label25.ForeColor = bright0;
            foreach (TextBox tb in panel16.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (Label l in panel16.Controls.OfType<Label>())
            {
                l.ForeColor = bright0;
                l.BackColor = dim1;
            }
            panel20.BackColor = dim0;
            foreach (TextBox tb in panel20.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (TextBox tb in panel21.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (Label l in panel21.Controls.OfType<Label>())
            {
                l.ForeColor = bright0;
                l.BackColor = dim1;
            }
            label42.ForeColor = bright0;
            panel23.BackColor = dim0;
            panel24.BackColor = dim0;
            panel25.BackColor = dim0;
            foreach (TextBox tb in panel23.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (TextBox tb in panel24.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (TextBox tb in panel25.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            panel26.BackColor = dim0;
            foreach (TextBox tb in panel26.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label6.ForeColor = bright0;
            panel27.BackColor = dim0;
            foreach (TextBox tb in panel27.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label44.ForeColor = bright0;
            label45.ForeColor = bright0;
            panel28.BackColor = dim0;
            foreach (TextBox tb in panel28.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            panel29.BackColor = dim0;
            foreach (TextBox tb in panel29.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (TextBox tb in panel1.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (TextBox tb in gamepanel.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach(Label l in panel1.Controls.OfType<Label>())
            {
                l.BackColor = dim0;
                l.ForeColor = bright0;
            }
            foreach (TextBox tb in panel11.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label14.ForeColor = bright0;
            label14.BackColor = dim0;
            foreach (TextBox tb in panel13.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label8.ForeColor = bright0;
            panel13.BackColor = dim0;
            panel17.BackColor = dim0;
            foreach (TextBox tb in panel17.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            panel15.BackColor = dim0;
            foreach (TextBox tb in panel15.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            infopanel.BackColor = dim0;
            foreach (TextBox tb in infopanel.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label16.ForeColor = bright1;
            label17.ForeColor = bright0;
            label18.ForeColor = bright0;
            label19.ForeColor = bright0;
            label20.ForeColor = bright0;
            label21.ForeColor = bright1;
            label22.ForeColor = bright1;
            label23.ForeColor = bright1;
            label24.ForeColor = bright1;
            foreach (TextBox tb in panel12.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (Label l in panel12.Controls.OfType<Label>())
            {
                l.BackColor = dim0;
                l.ForeColor = bright0;
            }
            panel9.BackColor = dim0;
            foreach (TextBox tb in panel9.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            foreach (Label l in panel9.Controls.OfType<Label>())
            {
                l.BackColor = dim0;
                l.ForeColor = bright0;
            }
            foreach (TextBox tb in panel7.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label4.BackColor = dim0;
            label4.ForeColor = bright0;
            foreach (TextBox tb in panel8.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label13.ForeColor = bright0;
            label13.BackColor = dim0;
            foreach (TextBox tb in panel10.Controls.OfType<TextBox>())
            {
                tb.BackColor = bright0;
            }
            label15.ForeColor = bright0;
            label15.BackColor = dim0;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            //dark mode
            selectedcolor = 1;
            makelabelok();


            dim0 = Color.FromArgb(25, 25, 25);
            dim1 = Color.FromArgb(35, 35, 35);
            dim2 = Color.FromArgb(45, 45, 45);
            bright0 = Color.FromArgb(128, 128, 128);
            bright1 = Color.FromArgb(255, 255, 255);

            resetcolor();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            //light mode
            selectedcolor = 2;
            makelabelok();

            dim0 = Color.FromArgb(255, 255, 255);
            dim1 = Color.FromArgb(220, 220, 220);
            dim2 = Color.FromArgb(190, 190, 190);
            bright0 = Color.FromArgb(50, 50, 50);
            bright1 = Color.FromArgb(0, 0, 0);

            resetcolor();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            selectedcolor = 3;
            makelabelok();
            label32.ForeColor = bright1;
            label32.BackColor = dim2;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            selectedcolor = 4;
            makelabelok();
            label33.ForeColor = bright1;
            label33.BackColor = dim2;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            selectedcolor = 5;
            makelabelok();
            label34.ForeColor = bright1;
            label34.BackColor = dim2;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            selectedcolor = 6;
            makelabelok();
            label35.ForeColor = bright1;
            label35.BackColor = dim2;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            selectedcolor = 7;
            makelabelok();
            label36.ForeColor = bright1;
            label36.BackColor = dim2;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            selectedcolor = 8;
            makelabelok();
            label37.ForeColor = bright1;
            label37.BackColor = dim2;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            selectedcolor = 9;
            makelabelok();
            label38.ForeColor = bright1;
            label38.BackColor = dim2;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            selectedcolor = 10;
            makelabelok();
            label39.ForeColor = bright1;
            label39.BackColor = dim2;
        }

        private void label32_MouseEnter(object sender, EventArgs e)
        {
            label32.ForeColor = bright1;
            label32.BackColor = dim2;
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 3)
            {
                label32.ForeColor = bright0;
                label32.BackColor = dim1;
            }
            else
            {
                label32.ForeColor = bright1;
                label32.BackColor = dim2;
            }
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            label33.ForeColor = bright1;
            label33.BackColor = dim2;
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 4)
            {
                label33.ForeColor = bright0;
                label33.BackColor = dim1;
            }
            else
            {
                label33.ForeColor = bright1;
                label33.BackColor = dim2;
            }
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            label34.ForeColor = bright1;
            label34.BackColor = dim2;
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 5)
            {
                label34.ForeColor = bright0;
                label34.BackColor = dim1;
            }
            else
            {
                label34.ForeColor = bright1;
                label34.BackColor = dim2;
            }
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            label35.ForeColor = bright1;
            label35.BackColor = dim2;
        }

        private void label35_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 6)
            {
                label35.ForeColor = bright0;
                label35.BackColor = dim1;
            }
            else
            {
                label35.ForeColor = bright1;
                label35.BackColor = dim2;
            }
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            label36.ForeColor = bright1;
            label36.BackColor = dim2;
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 7)
            {
                label36.ForeColor = bright0;
                label36.BackColor = dim1;
            }
            else
            {
                label36.ForeColor = bright1;
                label36.BackColor = dim2;
            }
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            label37.ForeColor = bright1;
            label37.BackColor = dim2;
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 8)
            {
                label37.ForeColor = bright0;
                label37.BackColor = dim1;
            }
            else
            {
                label37.ForeColor = bright1;
                label37.BackColor = dim2;
            }
        }

        private void label38_MouseEnter(object sender, EventArgs e)
        {
            label38.ForeColor = bright1;
            label38.BackColor = dim2;
        }

        private void label38_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 9)
            {
                label38.ForeColor = bright0;
                label38.BackColor = dim1;
            }
            else
            {
                label38.ForeColor = bright1;
                label38.BackColor = dim2;
            }
        }

        private void label39_MouseEnter(object sender, EventArgs e)
        {
            label39.ForeColor = bright1;
            label39.BackColor = dim2;
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            if (selectedcolor != 10)
            {
                label39.ForeColor = bright0;
                label39.BackColor = dim1;
            }
            else
            {
                label39.ForeColor = bright1;
                label39.BackColor = dim2;
            }
        }

        private void label40_MouseEnter(object sender, EventArgs e)
        {
            label40.ForeColor = bright1;
            label40.BackColor = dim2;
        }

        private void label40_MouseLeave(object sender, EventArgs e)
        {
            label40.ForeColor = bright0;
            label40.BackColor = dim1;
        }

        private void label41_MouseEnter(object sender, EventArgs e)
        {
            label41.ForeColor = bright1;
            label41.BackColor = dim2;
        }

        private void label41_MouseLeave(object sender, EventArgs e)
        {
            label41.ForeColor = bright0;
            label41.BackColor = dim1;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\sudoku.txt";
            FileInfo fi = new FileInfo(fileName);

            try
            {     
                if (fi.Exists)
                {
                    fi.Delete();
                }
  
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine("Save file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Made by: Kristo Tänak");
                    sw.WriteLine(easycomplete.ToString());
                    //easy sudokus completed
                    sw.WriteLine(mediumcomplete.ToString());
                    //medium sudokus completed
                    sw.WriteLine(hardcomplete.ToString());
                    //hard sudokus completed
                    sw.WriteLine(difficulty.ToString());
                    //difficulty
                    sw.WriteLine(opacity.ToString());
                    //opacity
                    sw.Close();
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            string fileName1 = @"C:\Temp\sudoku.txt";
            FileInfo fi = new FileInfo(fileName1);

            try
            {
                if (fi.Exists)
                {
                    StreamReader st = new StreamReader(fileName1);
                    Console.WriteLine(st.ReadToEnd());
                    string[] datalmao = File.ReadAllLines(fileName1);

                    //easy
                    label22.Text = datalmao[2].ToString();
                    easycomplete = Convert.ToInt32(datalmao[2]);
                    //medium
                    label23.Text = datalmao[3].ToString(); 
                    mediumcomplete = Convert.ToInt32(datalmao[3]);
                    //hard
                    label24.Text = datalmao[4].ToString();
                    hardcomplete = Convert.ToInt32(datalmao[4]);
                    //difficulty
                    difficulty = Convert.ToInt32(datalmao[5]);
                    if(difficulty == 1)
                    {
                        label11.ForeColor = bright0;
                        label12.ForeColor = bright0;
                    }
                    if (difficulty == 2)
                    {
                        label10.ForeColor = bright0;
                        label12.ForeColor = bright0;
                    }
                    if (difficulty == 3)
                    {
                        label10.ForeColor = bright0;
                        label11.ForeColor = bright0;
                    }
                    //opacity
                    opacity = Convert.ToDouble(datalmao[6]);
                    this.Opacity = opacity;
                    label28.Text = opacity.ToString();

                    st.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void label43_MouseEnter(object sender, EventArgs e)
        {
            label43.ForeColor = bright1;
        }

        private void label43_MouseLeave(object sender, EventArgs e)
        {
            label43.ForeColor = bright0;
        }

        private void label43_Click(object sender, EventArgs e)
        {
            if(label43.Text == "Enabled")
            {
                topmost = 0;
                label43.Text = "Disabled";
                this.TopMost = false;
            }
            else
            {
                topmost = 1;
                label43.Text = "Enabled";
                this.TopMost = true;
            }
        }

        private void label44_MouseEnter(object sender, EventArgs e)
        {
            label44.ForeColor = bright1;
        }

        private void label44_MouseLeave(object sender, EventArgs e)
        {
            label44.ForeColor = bright0;
        }

        private void label45_MouseEnter(object sender, EventArgs e)
        {
            label45.ForeColor = bright1;
        }

        private void label45_MouseLeave(object sender, EventArgs e)
        {
            label45.ForeColor = bright0;
        }

        private void label44_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tanakimees");
        }

        private void label45_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tanakimees.github.io/");
        }
    }
}
