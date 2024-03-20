using System;
using log4net;
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
        private static readonly ILog log = LogManager.GetLogger(typeof(CalculatorForm));

        private string calcOperandPart1 = "";
        private String calcOperandPart2 = "";
        private string calcOperator1 = "";
        private string calcOperator2 = "";
        private Boolean isFirstOperationApplied = false;
        private const string ZERO_TEXT = "0";

        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void operandButonClick(String buttonText)
        {
            try
            {
                updateOperand(buttonText);
                updateOperandOutPut1();
            }
            catch
            {
                log.Error("Invalid Input");
            }
        }


        public void setSignClicked(string buttonText)
        {
            updateSignOperand();
            updateOperandOutPut1();
        }

        public void setSquaredClicked()
        {
            updateSquaredOperand();
            updateOperandOutPut1();
        }

        public void setSquareRootClicked()
        {
            updateSquareRootOperand();
            updateOperandOutPut1();
        }

        public void setReciprocalClicked()
        {
            if (calcOperandPart1.Equals(ZERO_TEXT))
            {
                setOutput1("Cannot divide by zero");
            }
            else if (!string.IsNullOrEmpty(calcOperandPart1))
            {
                setOperandPart1((1.0 / float.Parse(calcOperandPart1)).ToString());
                setOutput1(calcOperandPart1);
            }

        }

        public void setPercentageClicked()
        {
            updatePercentageOperand();
            updatePercentageOutPut();

        }

        public void setEqualClicked(String buttonText)
        {
            updateEqualOutPut(buttonText);
            resetCalculation();
        }

        public void setOperationClick(String buttonText)
        {
            setOperation(buttonText);
            setOperationOutput1();
            setOperationOutput2();
        }

        public void resetCalculator()
        {
            resetOutPut();
            resetOperator();
            resetOperand();
            isFirstOperationApplied = false;

        }

        public void eraseLastLetterOperandAndOutPut1()
        {
            setEraseLastLetterOperand();
            eraseLastOutput1();
        }

        public void KeyPressInputHandler(char ch)
        {
            string input = ch.ToString();
            if (CalculatorUtil.isValidCharacterOperand(ch))
            {
                updateOperand(input);
            }
            else if (CalculatorUtil.isvalidCharacterOperator(ch))
            {
                resetOutPut1();
                setOperation(input);
                setOperationOutput2();
            }
            else
            {
                switch (ch)
                {
                    case '=':
                        setEqualClicked(input);
                        break;
                    case '%':
                        updatePercentageOperand();
                        break;
                    case '<':
                        setEqualClicked(input);
                        break;
                    default:
                        log.Error("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                        throw new InvalidExpressionException();

                }

            }
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

        private void buttonPercentageClick(object sender, EventArgs e)
        {
            try
            {
                setPercentageClicked();
            }
            catch
            {
                log.Error("Invalid Input ");
            }
        }

        private void updateOperand(string buttonText)
        {
            if (!isFirstOperationApplied)
            {
                string operand1 = calcOperandPart1 + buttonText;
                setOperandPart1(operand1);
            }
            else if (isFirstOperationApplied)
            {
                string operand2 = calcOperandPart2 + buttonText;
                setOperandPart2(operand2);
            }
        }

        private void updateOperandOutPut1()
        {
            if (!isFirstOperationApplied && StringUtil.isValidSring(calcOperandPart1))
            {
                setOutput1(calcOperandPart1);
            }
            if (isFirstOperationApplied && StringUtil.isValidSring(calcOperandPart2))
            {
                setOutput1(calcOperandPart2);
            }
        }

        private void updateSignOperand()
        {
            if (!isFirstOperationApplied)
            {
                string operand1 = CalculatorUtil.getSignedString(calcOperandPart1);
                setOperandPart1(operand1);
            }
            else if (isFirstOperationApplied)
            {
                string operand2 = CalculatorUtil.getSignedString(calcOperandPart2);
                setOperandPart2(operand2);
            }
        }

        private void updateSquaredOperand()
        {
            if (!isFirstOperationApplied)
            {
                if (CalculatorUtil.isValidStringOperand(calcOperandPart1))
                {
                    setOperandPart1(CalculatorUtil.calculateSquare(float.Parse(calcOperandPart1)).ToString());
                }
            }
            else
            {
                if (CalculatorUtil.isValidStringOperand(calcOperandPart1))
                {
                    setOperandPart2(CalculatorUtil.calculateSquare(float.Parse(calcOperandPart2)).ToString());
                }
            }
        }

        private void updateSquareRootOperand()
        {
            if (!isFirstOperationApplied)
            {
                string operand1 = Math.Sqrt(float.Parse(calcOperandPart1)).ToString();
                setOperandPart1(operand1);
            }
            else
            {
                string operand2 = Math.Sqrt(float.Parse(calcOperandPart2)).ToString();
                setOperandPart2(operand2);
            }
        }

        private void updatePercentageOutPut()
        {
            if (!isFirstOperationApplied)
            {
                setOutput1(ZERO_TEXT);
            }
            if (isFirstOperationApplied)
            {
                setOutput(calcOperandPart2, calcOperandPart1 + " " + calcOperator1 + " " + calcOperandPart2);
            }
        }

        private void updatePercentageOperand()
        {
            if (isFirstOperationApplied)
            {
                if (calcOperandPart2.Equals(StringUtil.EMPTY_STRING))
                {
                    setOperandPart2(CalculatorUtil.calculatePercentageWithTwoOperands(calcOperandPart1, calcOperandPart1, calcOperator1));
                }
                else
                {
                    setOperandPart2(CalculatorUtil.calculatePercentageWithTwoOperands(calcOperandPart1, calcOperandPart2, calcOperator1));
                }
            }
        }

        private void setEqualClicked(Button button)
        {
            setEqualClicked(button.Text);
        }


        private void updateEqualOutPut(string buttonText)
        {
            if (string.IsNullOrEmpty(calcOperator1))
            {
                setOutput(calcOperandPart1, calcOperandPart1 + " " + buttonText);
            }
            else if (string.IsNullOrEmpty(calcOperandPart2))
            {
                setOutput(CalculatorUtil.calculateBasicOperationWithTwoOperands(calcOperandPart1, calcOperandPart1, buttonText), calcOperandPart1 + " " + calcOperator1);
            }
            else
            {
                setOutput(CalculatorUtil.calculateBasicOperationWithTwoOperands(calcOperandPart1, calcOperandPart2, calcOperator1).ToString(), calcOperandPart1 + " " + calcOperator1 + " " + calcOperandPart2);
            }
        }

        private void setOperationClicked(Button button)
        {
            setOperationClick(button.Text);
        }

        private void setOperation(String buttonText)
        {
            if (!isFirstOperationApplied)
            {
                isFirstOperationApplied = true;
                setOperator1(buttonText);
            }
            else
            {
                setOperator2(buttonText);
                setOperandPart1(CalculatorUtil.calculateBasicOperationWithTwoOperands(calcOperandPart1, calcOperandPart2, calcOperator1));
                setOperator1(calcOperator2);
                resetCalculation();
            }
        }
        private void setOperationOutput1()
        {
            if (!isFirstOperationApplied)
            {
                setOutput(calcOperandPart1, calcOperandPart1 + " " + calcOperator1 + " ");
            }
            else
            {
                setOutput2(calcOperandPart1 + " " + calcOperator1 + " ");
            }
        }

        private void setOperationOutput2()
        {
            if (isFirstOperationApplied)
            {
                setOutput2(calcOperandPart1 + " " + calcOperator1 + " ");
            }
        }


        private void eraseLastOutput1()
        {
            if (!isFirstOperationApplied)
            {
                if (calcOperandPart1.Length == 0) return;
                setOutput1(calcOperandPart1);
            }
            else
            {
                if (calcOperandPart2.Length == 0) return;
                setOutput1(calcOperandPart2);
            }
        }

        private void setEraseLastLetterOperand()
        {
            if (!isFirstOperationApplied)
            {
                if (calcOperandPart1.Length == 0) return;
                setOperandPart1(CalculatorUtil.removeLastCharacterFromString(calcOperandPart1));
            }
            else
            {
                if (calcOperandPart2.Length == 0) return;
                setOperandPart2(CalculatorUtil.removeLastCharacterFromString(calcOperandPart2));
            }
        }

        private void resetCalculation()
        {
            resetOperator();
            resetOperand();
            isFirstOperationApplied = false;

        }

        private void resetOperandAndOutPut1()
        {
            if (!isFirstOperationApplied)
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

        private void setOutput(string outPut1, string outPut2)
        {
            if (StringUtil.isValidSring(outPut1) && StringUtil.isValidSring(outPut2))
            {
                setOutput1(outPut1);
                setOutput2(outPut2);
            }
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
            if (CalculatorUtil.isValidStringOperand(operand))
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
            if (CalculatorUtil.isValidStringOperand(operand))
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
