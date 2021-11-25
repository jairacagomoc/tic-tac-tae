using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktk
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool isX;
        int p1 = 0;
        int p2 = 0;
        int d3 = 0;


        void Enable_False()          {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button1.Text = "X";
                button1.Enabled = false;
                isX = false;
            }
            else if (!isX)
            {
                count += 1;
                button1.Text = "O";
                button1.Enabled = false;
                isX = true;
                if (button2.Text== "O" && button3.Text== "O" )
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe",MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button4.Text == "O" && button7.Text == "O")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button5.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
            }
            else
            {
                count += 1;
                button1.Text = "X";
                button1.Enabled = false;
                isX = false;
                if (button2.Text == "X" && button3.Text == "X")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button4.Text == "X" && button7.Text == "X")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button5.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button2.Text = "X";
                button2.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button2.Text = "O";
                button2.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button3.Text == "O")
                {
                    Enable_False();
                    button2.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button5.Text == "O" && button8.Text == "O")
                {
                    Enable_False();
                    button2.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
           
            }
            else
            {
                count += 1;
                button2.Text = "X";
                button2.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button3.Text == "X")
                {
                    Enable_False();
                    button2.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button5.Text == "X" && button8.Text == "X")
                {
                    Enable_False();
                    button2.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count ==9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button3.Text = "X";
                button3.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button3.Text = "O";
                button3.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button2.Text == "O")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button6.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button5.Text == "O" && button7.Text == "O")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }

            }
            else
            {
                count += 1;
                button3.Text = "X";
                button3.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button2.Text == "X")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button6.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button5.Text == "X" && button7.Text == "X")
                {
                    Enable_False();
                    button3.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button4.Text = "X";
                button4.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button4.Text = "O";
                button4.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button7.Text == "O")
                {
                    Enable_False();
                    button4.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button5.Text == "O" && button6.Text == "O")
                {
                    Enable_False();
                    button4.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
            }
            else
            {
                count += 1;
                button4.Text = "X";
                button4.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button7.Text == "X")
                {
                    Enable_False();
                    button4.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button5.Text == "X" && button6.Text == "X")
                {
                    Enable_False();
                    button4.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button5.Text = "X";
                button5.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button5.Text = "O";
                button5.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button4.Text == "O" && button6.Text == "O")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button7.Text == "O" && button3.Text == "O")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button2.Text == "O" && button8.Text == "O")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
            
             }
            else
            {
                count += 1;
                button5.Text = "X";
                button5.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button4.Text == "X" && button6.Text == "X")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button7.Text == "X" && button3.Text == "X")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button2.Text == "X" && button8.Text == "X")
                {
                    Enable_False();
                    button5.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button6.Text = "X";
                button6.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button6.Text = "O";
                button6.Enabled = false;
                isX = true;
                if (button4.Text == "O" && button5.Text == "O")
                {
                    Enable_False();
                    button6.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button3.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button6.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }

            }
            else
            {
                count += 1;
                button6.Text = "X";
                button6.Enabled = false;
                isX = false;
                if (button4.Text == "X" && button5.Text == "X")
                {
                    Enable_False();
                    button6.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button3.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button6.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button7.Text = "X";
                button7.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button7.Text = "O";
                button7.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button4.Text == "O")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button5.Text == "O" && button3.Text == "O")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button8.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
            }
            else
            {
                count += 1;
                button7.Text = "X";
                button7.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button4.Text == "X")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button4.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X  wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button5.Text == "X" && button3.Text == "X")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button8.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button7.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button8.Text = "X";
                button8.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button8.Text = "O";
                button8.Enabled = false;
                isX = true;
                if (button2.Text == "O" && button5.Text == "O")
                {
                    Enable_False();
                    button8.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button7.Text == "O" && button9.Text == "O")
                {
                    Enable_False();
                    button8.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
            }
            else
            {
                count += 1;
                button8.Text = "X";
                button8.Enabled = false;
                isX = false;
                if (button2.Text == "X" && button5.Text == "X")
                {
                    Enable_False();
                    button8.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button7.Text == "X" && button9.Text == "X")
                {
                    Enable_False();
                    button8.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button9.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                p2 += 1;
                pX.Text = p2.ToString();
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                button9.Text = "X";
                button9.Enabled = false;
                isX = false;

            }
            else if (!isX)
            {
                count += 1;
                button9.Text = "O";
                button9.Enabled = false;
                isX = true;
                if (button1.Text == "O" && button5.Text == "O")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button3.Text == "O" && button6.Text == "O")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }
                if (button7.Text == "O" && button8.Text == "O")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player O wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p1 += 1;
                    pO.Text = p1.ToString();
                }

            }
            else
            {
                count += 1;
                button9.Text = "X";
                button9.Enabled = false;
                isX = false;
                if (button1.Text == "X" && button5.Text == "X")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button1.BackColor = Color.IndianRed;
                    button5.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button3.Text == "X" && button6.Text == "X")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button3.BackColor = Color.IndianRed;
                    button6.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
                if (button7.Text == "X" && button8.Text == "X")
                {
                    Enable_False();
                    button9.BackColor = Color.IndianRed;
                    button7.BackColor = Color.IndianRed;
                    button8.BackColor = Color.IndianRed;
                    MessageBox.Show("Player X wins!", "Tiktaktoe", MessageBoxButtons.OK);
                    p2 += 1;
                    pX.Text = p2.ToString();
                }
            }
            if (count == 9)
            {
                MessageBox.Show("The Game is Draw!", "Tiktaktoe", MessageBoxButtons.OK);
                d3 += 1;
                d.Text = d3.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void gamereset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke; 
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;

            count = 0;

        }

        private void pX_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
