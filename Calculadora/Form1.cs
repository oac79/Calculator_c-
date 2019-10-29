using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private Double resulValue = 0;
        private String operation = "";
        private bool isArithmeticOperator = false;

        private string opeTxt;

        Operator ope = new Operator();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void operator_click(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;
            operation = button.Text;
            resulValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = resulValue + " " + operation;
            isArithmeticOperator = true; 


        }

        private void btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((textBoxResult.Text == "0") || (isArithmeticOperator))
                textBoxResult.Clear();

            isArithmeticOperator = false;
            
            //controlamos que el usuario no introduzca mas de un carcter decimal 
            if(button.Text == ",")
            {
                if (!textBoxResult.Text.Contains(","))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }  
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text="0";
        }

        private void btnback_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(textBoxResult.Text.Length == 0)
            {
                button.Enabled = true;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
            }
            
        }

        private void btnequals_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (resulValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resulValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resulValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resulValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void label_result(object sender, EventArgs e)
        {

        }

        private void textboxresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void setTextBox(string val)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            opeTxt = opeTxt + val;
            textBoxResult.Text = opeTxt;

        }

 

        /*private void btn0_Click(object sender, EventArgs e)
        {
            setTextBox("0");
        
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            setTextBox("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            setTextBox("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            setTextBox("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            setTextBox("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            setTextBox("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setTextBox("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            setTextBox("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            setTextBox("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            setTextBox("9");
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            setTextBox(".");
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            //setTextBox("=");
        }

        

        private void btndiv_Click(object sender, EventArgs e)
        {
            setTextBox("/");
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            setTextBox("*");
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            setTextBox("-");
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            setTextBox("+");
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        */
        /* private void textBox1_KeyPress(object sender, KeyEventArgs e)
       {
           if(e.KeyCode == Keys.B && e.Control)
           {
               textboxresult.Text = "";
           }
       }*/
    }
}
