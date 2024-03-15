using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class CalculatorForm : Form
    {
        string calcOperandPart1 = "";
        String calcOperandPart2 = "";
        string calcOperator1 = "";
        string calcOperator2 = "";
        Boolean isFirstOperationClicked = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1TextChanged(object sender, EventArgs e)

        {

        }
        private void textBox2TextChanged(object sender, EventArgs e)

        {

        }

        private void button1Click(object sender, EventArgs e)
        {
            operandButonClick(button1.Text);
        }
        private void button2Click(object sender, EventArgs e)
        {
            operandButonClick(button2.Text);
        }
        private void button3Click(object sender, EventArgs e)
        {
            operandButonClick(button3.Text);
        }
        private void button4Click(object sender, EventArgs e)
        {
            operandButonClick(button4.Text);
        }
        private void button5Click(object sender, EventArgs e)
        {
            operandButonClick(button5.Text);
        }
        private void button6Click(object sender, EventArgs e)
        {
            operandButonClick(button6.Text);
        }
        private void button7Click(object sender, EventArgs e)
        {
            operandButonClick(button7.Text);
        }
        private void button8Click(object sender, EventArgs e)
        {
            operandButonClick(button8.Text);
        }
        private void button9Click(object sender, EventArgs e)
        {
            operandButonClick(button9.Text);
        }
        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void buttonDotClick(object sender, EventArgs e)
        {
            operandButonClick(buttonDot.Text);
        }

        private void buttonZeroClick(object sender, EventArgs e)
        {
            operandButonClick(buttonZero.Text);
        }

        private void buttonSignClick(object sender, EventArgs e)
        {
            setSignClicked(buttonSign.Text);
        }

        private void buttonSubClick(object sender, EventArgs e)
        {
            setOperationClicked(buttonSub);
        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            setOperationClicked(buttonAdd);
        }

        private void buttonDivClick(object sender, EventArgs e)
        {
            setOperationClicked(buttonDiv);
        }

        private void buttonMulClick(object sender, EventArgs e)
        {
            setOperationClicked(buttonMul);
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            resetCalculator();
        }

        private void buttonEquClick(object sender, EventArgs e)
        {
            setEqualClicked(buttonEqu);
        }

        private void buttonCEClick(object sender, EventArgs e)
        {
            resetOperandAndOutPut1();
        }

        private void buttonReciprocalClick(object sender, EventArgs e)
        {
            setReciprocalClicked();
        }

        private void buttonSquareRootClick(object sender, EventArgs e)
        {
            setSquareRootClicked();
        }

        private void buttonSquaredClick(object sender, EventArgs e)
        {
            setSquaredClicked();
        }

        private void buttonBackClick(object sender, EventArgs e)
        {
            eraseLastLetterOperandAndOutPut1();
        }
        private void buttonPerClick(object sender, EventArgs e)
        {
            setPerClicked();
        }

        public void operandButonClick(String buttonText)
        {
            try
            {
                updateOperand(buttonText);
                updateOutPutText(buttonText);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }

        private void updateOperand(string buttonText)
        {
            if (!isFirstOperationClicked)
            {
                setOperandPart1(calcOperandPart1 + buttonText);
            }
            else
            {
                setOperandPart2(calcOperandPart2 + buttonText);
            }
        }

        private void updateOutPutText(string buttonText)
        {
            if (!isFirstOperationClicked)
            {
                setOutput1(calcOperandPart1);
            }
            else
            {
                setOutput1(calcOperandPart2);
            }
        }

        public void setSignClicked(string buttonText)
        {
            if (!isFirstOperationClicked)
            {
                setOperandPart1(updateOperandWithSign(calcOperandPart1));
                setOutput1(calcOperandPart1);
            }
            else
            {
                setOperandPart2(updateOperandWithSign(calcOperandPart2));
                setOutput1(calcOperandPart2);
            }
        }

        public void setSquaredClicked()
        {
            if (!isFirstOperationClicked)
            {
                if (!string.IsNullOrEmpty(calcOperandPart1))
                {
                    setOperandPart1(CalculatorUtil.getSquared(float.Parse(calcOperandPart1)).ToString());
                    setOutput1(calcOperandPart1);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(calcOperandPart2))
                {
                    setOperandPart2(CalculatorUtil.getSquared(float.Parse(calcOperandPart2)).ToString());
                    setOutput1(calcOperandPart2);
                }
            }
        }

        public void setSquareRootClicked()
        {
            if (!isFirstOperationClicked)
            {
                if (!string.IsNullOrEmpty(calcOperandPart1))
                {
                    setOperandPart1(Math.Sqrt(float.Parse(calcOperandPart1)).ToString());
                    setOutput1(calcOperandPart1);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(calcOperandPart2))
                {
                    setOperandPart2(Math.Sqrt(float.Parse(calcOperandPart2)).ToString());
                    setOutput1(calcOperandPart2);
                }
            }
        }

        public void setReciprocalClicked()
        {
            if (calcOperandPart1.Equals("0"))
            {
                setOutput1("Cannot divide by zero");
            }
            else if (!string.IsNullOrEmpty(calcOperandPart1))
            {
                setOperandPart1((1.0 / float.Parse(calcOperandPart1)).ToString());
                setOutput1(calcOperandPart1);
            }

        }

        public void setPerClicked()
        {
            if (!isFirstOperationClicked)
            {
                setOutput1("0");
            }
            if (isFirstOperationClicked)
            {
                if (calcOperandPart2.Equals(""))
                {
                    setPercentage(calcOperandPart1, calcOperandPart1, calcOperator1);
                }
                else
                {
                    setPercentage(calcOperandPart1, calcOperandPart2, calcOperator1);
                }
            }
        }

        private void setPercentage(string value1, string value2, string op)
        {
            if (!string.IsNullOrEmpty(value1) && !string.IsNullOrEmpty(value2))
            {
                setOperandPart2(CalculatorUtil.getPercentage(value1, value2, op));
                setOutput(calcOperandPart2, calcOperandPart1 + " " + calcOperator1 + " " + calcOperandPart2);
            }
        }

        private string updateOperandWithSign(string operand)
        {
            return CalculatorUtil.getSigned(operand);
        }

        private void setEqualClicked(Button button)
        {
            setEqualClicked(button.Text);
        }

        public void setEqualClicked(String buttonText)
        {
            if (string.IsNullOrEmpty(calcOperator1))
            {
                setOutput(calcOperandPart1, calcOperandPart1 + " " + buttonText);
            }
            else if (string.IsNullOrEmpty(calcOperandPart2))
            {
                setOutput(calculateWithOperatorOnly(calcOperandPart1, buttonText), calcOperandPart1 + " " + calcOperator1);
            }
            else
            {
                setOutput(CalculatorUtil.calculateWithSecondOperand(calcOperandPart1, calcOperandPart2, calcOperator1).ToString(), calcOperandPart1 + " " + calcOperator1 + " " + calcOperandPart2);
            }

            resetCalculation();
        }
        private void setOperationClicked(Button button)
        {
            setOperationClick(button.Text);
        }

        public void setOperationClick(String buttonText)
        {
            if (!isFirstOperationClicked)
            {
                isFirstOperationClicked = true;
                setOperator1(buttonText);
                string calculationString = calcOperandPart1 + " " + calcOperator1 + " ";
                setOutput2(calculationString);
            }
            else
            {
                setOperator2(buttonText);
                setOperandPart1(CalculatorUtil.calculateWithSecondOperand(calcOperandPart1, calcOperandPart2, calcOperator1));
                setOperator1(calcOperator2);
                setOutput(calcOperandPart1, calcOperandPart1 + " " + calcOperator1 + " ");
                resetCalculation();
            }
        }

        private string calculateWithOperatorOnly(string value1, string op)
        {
            return CalculatorUtil.calculateWithSecondOperand(value1, value1, calcOperator1);
        }

        public void resetCalculator()
        {
            resetOutPut();
            resetOperator();
            resetOperand();
            isFirstOperationClicked = false;

        }
        public void resetOperandAndOutPut1()
        {
            if (!isFirstOperationClicked)
            {
                resetOperand1();
                resetOutPut1();
            }
            else
            {
                resetOperand2();
                resetOutPut1();
            }
        }
        public void eraseLastLetterOperandAndOutPut1()
        {
            if (!isFirstOperationClicked)
            {
                if (calcOperandPart1.Length == 0) return;
                setOperandPart1(CalculatorUtil.getBackSpacedLastCharacter(calcOperandPart1));
                setOutput1(calcOperandPart1);
            }
            else
            {
                if (calcOperandPart2.Length == 0) return;
                setOperandPart2(CalculatorUtil.getBackSpacedLastCharacter(calcOperandPart2));
                setOutput1(calcOperandPart2);
            }
        }

        private void resetCalculation()
        {
            resetOperator();
            resetOperand();
            isFirstOperationClicked = false;

        }

        private void setOutput(string outPut1, string outPut2)
        {
            setOutput1(outPut1);
            setOutput2(outPut2);

        }
        private void setOutput1(string value)
        {
            output1.Text = value;
        }

        private void setOutput2(string value)
        {
            output2.Text = value;
        }
        private void resetOperand1()
        {
            calcOperandPart1 = "";
        }

        private void resetOperand2()
        {
            calcOperandPart2 = "";
        }
        private void resetOperand()
        {
            resetOperand1();
            resetOperand2();
        }

        private void setOperandPart1(String operand)
        {
            if (CalculatorUtil.isValidOperand(operand))
            {
                calcOperandPart1 = operand;
            }
            else
            {
                throw new InvalidExpressionException();
            }
        }
        private void setOperandPart2(String operand)
        {
            if (CalculatorUtil.isValidOperand(operand))
            {
                calcOperandPart2 = operand;
            }
            else
            {
                throw new InvalidExpressionException();
            }
        }
        private void setOperator1(string value)
        {
            calcOperator1 = value;
        }
        private void setOperator2(string value)
        {
            calcOperator2 = value;
        }

        private void resetOperator()
        {
            calcOperator1 = "";
            calcOperator2 = "";
        }

        private void resetOutPut1()
        {
            setOutput1("");
        }
        private void resetOutPut2()
        {
            setOutput2("");
        }
        private void resetOutPut()
        {
            resetOutPut1();
            resetOutPut2();
        }
    }
}
