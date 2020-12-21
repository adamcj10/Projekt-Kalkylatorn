using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_6_Programmering_1
{
    public partial class Form1 : Form
    {
        double fix = 0;
        bool buttonplus1_Click = false;
        String text = "";
        bool Push = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if((Result.Text == "0") || (Push))
            {
                Result.Clear();
            }

            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
            Push = false;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            Push = true;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (buttonplus1_Click)
            {
                switch (text)
                {
                    case "+":
                        Result.Text = (fix + double.Parse(Result.Text)).ToString();
                        break;
                    case "-":
                        Result.Text = (fix - double.Parse(Result.Text)).ToString();
                        break;
                    case "/":
                        Result.Text = (fix / double.Parse(Result.Text)).ToString();
                        break;
                    case "*":
                        Result.Text = (fix * double.Parse(Result.Text)).ToString();
                        break;
                    case "1/x":
                        Result.Text = (1 / fix).ToString();
                        break;
                    case "√":
                        Result.Text = Math.Sqrt(fix).ToString();
                        break;
                   

                }
                Push = false;
            }
            Button button = (Button)sender;
            text = button.Text;
            fix = double.Parse(Result.Text);
            Push = true;
            buttonplus1_Click = true;
            
        }
        
        private void buttonlika_Click(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    Result.Text = (fix + double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (fix - double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (fix / double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (fix * double.Parse(Result.Text)).ToString();
                    break;
                case "1/x":
                    Result.Text = (1/fix).ToString();
                    break;
                case "√":
                    Result.Text = Math.Sqrt(fix).ToString();
                    break;
                
                
            }
            Push = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            Push = true;
            buttonplus1_Click = false;
        }

        private void buttonpil_Click(object sender, EventArgs e)
        {
            if(Result.Text.Length > 0)
            {
                Result.Text = Result.Text.Remove(Result.Text.Length - 1);
            }
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
             
            Result.Text = (double.Parse(Result.Text) * -1).ToString();
            buttonplus1_Click = false;
           
        }
    }
}
