using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class CalculatorForm : Form
    {
        bool tag = false; //연산자가 눌렷는지
        double result = 0;
        double savedNum = 0;
        double tmp_result = 0;
        char op;

        public CalculatorForm()
        {
            InitializeComponent();
        }

      private void btn_Click(object sender, EventArgs e)
        {
           Button btn = sender as Button;
           if (textBox1.Text == "0" || tag)
           {
               textBox1.Text = string.Empty;
               tag = false;
           }
           textBox1.Text += btn.Text;
        }

      private void calc()
      {
          string a = textBox2.Text.Substring(textBox2.Text.Length - 1);
          char currentOp = Convert.ToChar(a);
          switch (currentOp)
          {
              case '/':
                  tmp_result = Convert.ToDouble(textBox1.Text);
                  savedNum = savedNum / tmp_result;
                  textBox2.Text += textBox1.Text + op;
                  textBox1.Text = Convert.ToString(savedNum);
                  tag = true;
                  break;
              case '*':
                  tmp_result = Convert.ToDouble(textBox1.Text);
                  savedNum = savedNum * tmp_result;  
                  textBox2.Text += textBox1.Text + op;               
                  textBox1.Text = Convert.ToString(savedNum);
                  tag = true;
                  break;
              case '+':
                  tmp_result = Convert.ToDouble(textBox1.Text); //tmp에있는 숫자 를 가져옴
                  savedNum = savedNum + tmp_result; //저장된숫자와 더함 
                  textBox2.Text += textBox1.Text + op; // 버튼을 누른 수식과 입력된 숫자(tmp)를 입력                  
                  textBox1.Text = Convert.ToString(savedNum); //저장된 숫자를 text에 보여줌
                  tag = true;
                  break;
              case '-':
                  tmp_result = Convert.ToDouble(textBox1.Text);
                  savedNum = savedNum - tmp_result;
                  textBox2.Text += textBox1.Text + op;
                  textBox1.Text = Convert.ToString(savedNum);
                  tag = true;
                  break;

          }
      }
        private void button_Plus_Click(object sender, EventArgs e)
        {
            op = '+';
            if (textBox1.Text != string.Empty)
            {
                if (!tag)
                {
                    tag = true;

                    if (textBox2.Text == string.Empty)
                    {
                        tmp_result = Convert.ToDouble(textBox1.Text);
                        savedNum = tmp_result;
                        textBox2.Text += Convert.ToString(tmp_result) + op;
                        textBox1.Text = Convert.ToString(tmp_result);
                    }
                    else
                    {
                        calc();
                    }
                }
                else
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1) + op;
                    return;
            }           

        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            op = '-';

            if (textBox1.Text != "")
            {
                if (!tag)
                {
                    tag = true;

                    if (textBox2.Text == string.Empty)
                    {
                        tmp_result = Convert.ToDouble(textBox1.Text);
                        savedNum = tmp_result;
                        textBox2.Text += Convert.ToString(tmp_result) + op;
                        //textBox3.Text = Convert.ToString(tmp_result);
                    }
                    else
                    {
                        calc();
                    }
                }
                else

                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1) + op;
                    return;
            }
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            op = '*';
            if (textBox1.Text != "")
            {
                if (!tag)
                {
                    tag = true;

                    if (textBox2.Text == string.Empty)
                    {
                        tmp_result = Convert.ToDouble(textBox1.Text);
                        savedNum = tmp_result;
                        textBox2.Text += Convert.ToString(tmp_result) + "*";
                       // textBox3.Text = Convert.ToString(tmp_result);
                    }
                    else
                    {
                        calc();
                    }
                }
                else

                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1) + "*";
                    return;
            }
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            op = '/';
            if (textBox1.Text != "")
            {
                if (!tag)
                {
                    tag = true;

                    if (textBox2.Text == string.Empty)
                    {
                        tmp_result = Convert.ToDouble(textBox1.Text);
                        savedNum = tmp_result;
                        textBox2.Text += Convert.ToString(tmp_result) + "/";
                    }
                    else
                    { 
                      calc();
                    }
                }
                else
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1) + "/";
                return;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            result = 0;
            savedNum = 0;
            tmp_result = 0;

            textBox1.Text = "0";
            textBox2.Text = string.Empty;
            tag = false;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);     
        }

        private void button_Result_Click(object sender, EventArgs e)
        {

            int leng = textBox2.Text.Length;
            string a = textBox2.Text.Substring(textBox2.Text.Length - 1);
            char currentOp = Convert.ToChar(a);
            
            switch (currentOp)
            {
                case '/':
                    tmp_result = Convert.ToDouble(textBox1.Text);
                    savedNum = savedNum / tmp_result;
                    textBox1.Text = Convert.ToString(savedNum);
                    textBox2.Text = string.Empty;
                    break;
                case '*':
                    tmp_result = Convert.ToDouble(textBox1.Text);
                    savedNum = savedNum * tmp_result;
                    textBox1.Text = Convert.ToString(savedNum);
                    textBox2.Text = string.Empty;
                    break;
                case '+':
                    tmp_result = Convert.ToDouble(textBox1.Text);
                    savedNum = savedNum + tmp_result;
                    textBox1.Text = Convert.ToString(savedNum);
                    textBox2.Text = string.Empty;
                    break;
                case '-':
                    tmp_result = Convert.ToDouble(textBox1.Text);
                    savedNum = savedNum - tmp_result;
                    textBox1.Text = Convert.ToString(savedNum);
                    textBox2.Text = string.Empty;
                    break;

            }

        }

        private void button_Deciaml_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                if (textBox1.Text == "0")
                    textBox1.Text += ".";
                else
                    textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, ".");
            }
            else
                return;
    

        }

        private void button_PlusMinus_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str != string.Empty)
            {
                double num = Convert.ToDouble(str);
                double conversionNum = -1 * num;
                textBox1.Text = Convert.ToString(conversionNum);
            }
            else return;
        }

    }
}
 