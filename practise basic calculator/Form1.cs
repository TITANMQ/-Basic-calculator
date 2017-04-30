using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise_basic_calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        char operation;
        Double result = 0.0;
        
	

	
        public Form1()
        {
            InitializeComponent();



        }

#region number buttons


        private void num9_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("9");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("8");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("7");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("6");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("5");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("4");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("3");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("2");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("1");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("0");
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            calculatorBox.AppendText("3.14159265359");
        }
        #endregion

        #region operator buttons

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            input = calculatorBox.Text;
            firstNumber = input;
            operation = '*';
            input = string.Empty;
            calculatorBox.ResetText();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            input = calculatorBox.Text;
            firstNumber = input;
            operation = '-';
            input = string.Empty;
            calculatorBox.ResetText();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            input = calculatorBox.Text;
            firstNumber = input;
            operation = '/';
            input = string.Empty;
            calculatorBox.ResetText();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            input = calculatorBox.Text;
            firstNumber = input;
            operation = '+';
            input = string.Empty;
            calculatorBox.ResetText();


        }

        


      

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            input = calculatorBox.Text;
            secondNumber = input;
            Double Fnum, Snum;
            Double.TryParse(firstNumber, out Fnum);
            Double.TryParse(secondNumber, out Snum);
            calculatorBox.ResetText();

        


            if ( operation == '+')
            {   
                
                result = Fnum + Snum;
                calculatorBox.Text = result.ToString();
            } 
            else if (operation == '-')
            {
                result = Fnum - Snum;
                calculatorBox.Text = result.ToString();
            }
            else if(operation == '*')
            {
                result = Fnum * Snum;
                calculatorBox.Text = result.ToString();
            } 
            else if (operation == '/')
            {
                result = Fnum / Snum;
                calculatorBox.Text = result.ToString();
            }
            else
            {
                calculatorBox.Text = "Error";
            }


            




        }

#endregion 





        //cancel button

        private void button1_Click(object sender, EventArgs e) 
        {
            calculatorBox.ResetText(); 
            
        }
        
        private void undoButton_Click(object sender, EventArgs e)
        {
          //  calculatorBox.ClearUndo();
        }

        private void calculatorBox_TextChanged(object sender, EventArgs e)
        {

        }

#region Menu
        // menu button
        private void menuButton_Click_1(object sender, EventArgs e) 
        {
            menuPanel.Visible = true;
        } 
        //panel menu button
        private void menuButton2_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            designPanel.Visible = false;
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {   

            if (designPanel.Visible == true)
            {
                designPanel.Visible = false;
            }
            else
            {
                menuPanel.Visible = false;
            }
            
            
        }
        //exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //option button
        private void optionButton_Click(object sender, EventArgs e)
        {
            
        }
#region design sytles
        // design styles button
        private void designButton_Click(object sender, EventArgs e)
        {
            designPanel.Visible = true;
        }
        //default sytle

        private void DefaultCBox_CheckedChanged(object sender, EventArgs e)
        {
            

            if (DefaultCBox.Checked)
            {
                DefaultCBox.Enabled = false;
                greenCBox.Enabled = true;
                neonCBox.Enabled = true;
                silverCBox.Enabled = true;
                redCBox.Enabled = true;
                blueCBox.Enabled = true;

                greenCBox.Checked = false;
                neonCBox.Checked = false;
                silverCBox.Checked = false;
                redCBox.Checked = false;
                blueCBox.Checked = false; 

                //form colour    
                this.BackColor = Color.WhiteSmoke;
                menuPanel.BackColor = Color.WhiteSmoke;
                designPanel.BackColor = Color.WhiteSmoke;
                
                // calculator box font colour 
                calculatorBox.ForeColor = Color.Black;

                //side menu button colour 
                menuButton.BackColor = Color.White;
                menuButton2.BackColor = Color.White;
            } 
           
        }

        // green
        private void greenCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greenCBox.Checked)
            {   
                DefaultCBox.Enabled = true;
                greenCBox.Enabled = false;
                neonCBox.Enabled = true;
                silverCBox.Enabled = true;
                redCBox.Enabled = true;
                blueCBox.Enabled = true;

                DefaultCBox.Checked = false;
                neonCBox.Checked = false;
                silverCBox.Checked = false;
                redCBox.Checked = false;
                blueCBox.Checked = false; 

                //form colour    
                this.BackColor = Color.White;
                menuPanel.BackColor = Color.LimeGreen;
                designPanel.BackColor = Color.LimeGreen; 

                // calculator box font colour 
                calculatorBox.ForeColor = Color.LimeGreen;

                //side menu button colour 
                menuButton.BackColor = Color.LimeGreen;
                menuButton2.BackColor = Color.LimeGreen;
            }
        } 

        //neon 

        private void neonCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (neonCBox.Checked)
            {
                DefaultCBox.Enabled = true;
                greenCBox.Enabled = true;
                neonCBox.Enabled = false;
                silverCBox.Enabled = true;
                redCBox.Enabled = true;
                blueCBox.Enabled = true;

                DefaultCBox.Checked = false;
                greenCBox.Checked = false;
                silverCBox.Checked = false;
                redCBox.Checked = false;
                blueCBox.Checked = false;

                //form colour    
                this.BackColor = Color.Fuchsia;
                menuPanel.BackColor = Color.DarkTurquoise;
                designPanel.BackColor = Color.DarkTurquoise;

                // calculator box font colour 
                calculatorBox.ForeColor = Color.DarkTurquoise;

                //side menu button colour 
                menuButton.BackColor = Color.DarkTurquoise;
                menuButton2.BackColor = Color.DarkTurquoise;
            }
        } 

        //silver 

        private void silverCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (silverCBox.Checked)
            {
                DefaultCBox.Enabled = true;
                greenCBox.Enabled = true;
                neonCBox.Enabled = true;
                silverCBox.Enabled = false;
                redCBox.Enabled = true;
                blueCBox.Enabled = true;

                DefaultCBox.Checked = false;
                greenCBox.Checked = false;
                neonCBox.Checked = false;
                redCBox.Checked = false;
                blueCBox.Checked = false;

                //form colour    
                this.BackColor = Color.Silver;
                menuPanel.BackColor = Color.Silver;
                designPanel.BackColor = Color.Silver;

                // calculator box font colour 
                calculatorBox.ForeColor = Color.Black;

                //side menu button colour 
                menuButton.BackColor = Color.Silver;
                menuButton2.BackColor = Color.Silver;
            }
        }
        //red
        private void redCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redCBox.Checked)
            {
                DefaultCBox.Enabled = true;
                greenCBox.Enabled = true;
                neonCBox.Enabled = true;
                silverCBox.Enabled = true;
                redCBox.Enabled = false;
                blueCBox.Enabled = true;

                DefaultCBox.Checked = false;
                greenCBox.Checked = false;
                neonCBox.Checked = false;
                silverCBox.Checked = false;
                blueCBox.Checked = false;

                //form colour    
                this.BackColor = Color.White;
                menuPanel.BackColor = Color.Red;
                designPanel.BackColor = Color.Red;

                // calculator box font colour 
                calculatorBox.ForeColor = Color.Red;

                //side menu button colour 
                menuButton.BackColor = Color.Red;
                menuButton2.BackColor = Color.Red;
            }
            
        }
        //blue 
        private void blueCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blueCBox.Checked)
            {
                DefaultCBox.Enabled = true;
                greenCBox.Enabled = true;
                neonCBox.Enabled = true;
                silverCBox.Enabled = true;
                redCBox.Enabled = true;
                blueCBox.Enabled = false;

                DefaultCBox.Checked = false;
                greenCBox.Checked = false;
                neonCBox.Checked = false;
                silverCBox.Checked = false;
                redCBox.Checked = false;

                //form colour    
                this.BackColor = Color.White;
                menuPanel.BackColor = Color.Blue;
                designPanel.BackColor = Color.Blue; 

                // calculator box font colour 
                calculatorBox.ForeColor = Color.Blue;

                //side menu button colour 
                menuButton.BackColor = Color.Blue;
                menuButton2.BackColor = Color.Blue;
            }
        }
#endregion
        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void menuPanel_Click(object sender, EventArgs e)
        {
            designPanel.Visible = false;
        }
#endregion

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string number = calculatorBox.Text;
            int sqnum;
            int.TryParse(number, out sqnum);

            int squaredNumber = sqnum * sqnum;
            calculatorBox.Text = squaredNumber.ToString();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form aboutF = new about();
            aboutF.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form helpF = new Help();
            helpF.Show();
        }
    }
}
