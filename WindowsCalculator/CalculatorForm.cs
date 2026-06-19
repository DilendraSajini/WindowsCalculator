using System;
using log4net;
using System.Data;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class CalculatorForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CalculatorForm));

        private string calcOperandPart1 = "";
        private string calcOperandPart2 = "";
        private string calcOperator1 = "";
        private string calcOperator2 = "";
        private bool isFirstBasicOperationApplied = false;
        private bool isErasableOperatorOutput = true;
        private bool isAllowedResetOutput = false;
        private string backUpResetOutput = "";
        private const string ZERO_TEXT = "0";

        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void OperandButonClick(string buttonText)
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


        public void SignButtonClicked(string buttonText)
        {
            updateSignOperand();
            updateOperandOutPut1();
        }

        public void setSquaredClicked()
        {
            isErasableOperatorOutput = false;
            updateSquaredOperand();
            updateOperandOutPut1();
        }

        public void SquareRootButtonClicked()
        {
            isErasableOperatorOutput = false;
            updateSquareRootOperand();
            updateOperandOutPut1();
        }

        public void ReciprocalButtonClicked()
        {
            isErasableOperatorOutput = false;
            if (calcOperandPart1.Equals(ZERO_TEXT))
            {
                setOutput1("Cannot divide by zero");
            }
            else if (StringUtil.isValidSring(calcOperandPart1))
            {
                setOperandPart1((1.0 / float.Parse(calcOperandPart1)).ToString());
                setOutput1(calcOperandPart1);
            }

        }

        public void PercentageButtonClicked()
        {
            isErasableOperatorOutput = false;
            updatePercentageOperand();
            updatePercentageOutPut();
        }

        public void EqualButtonClicked(string buttonText)
        {
            isErasableOperatorOutput = false;
            if (string.IsNullOrEmpty(calcOperandPart1) && !string.IsNullOrEmpty(calcOperandPart2))
            {
                calcOperandPart1 = backUpResetOutput;
            }
            updateEqualOutPut(buttonText);
            setOperandPart1(output1.Text);
            resetOperand2();
            isErasableOperatorOutput = true;
            isAllowedResetOutput = true;

        }

        public void OperationsClick(string buttonText)
        {
            setOperation(buttonText);
            setOperationOutput();
            setOperationOutput2();
        }

        public void ResetCalculator()
        {
            resetOutPut();
            resetOperator();
            resetOperand();
            isFirstBasicOperationApplied = false;
            isErasableOperatorOutput = true;
            isAllowedResetOutput = false;
            backUpResetOutput = "";
        }

        public void EraseLastLetterOfOperand()
        {
            eraseLastLetterOperand();
            eraseLastOutput1();
        }

        public void KeyPressInputHandler(char ch)
        {
            string input = ch.ToString();
            if (CalculatorUtil.isValidCharacterOperand(ch))
            {
                checkValidToResetOutputBeforeOperandSet();
                updateOperand(input);
            }
            else if (CalculatorUtil.isvalidCharacterOperator(ch))
            {
                setOperation(input);
                setOperationOutput();
            }
            else
            {
                switch (ch)
                {
                    case '=':
                    case '\r':
                        EqualButtonClicked(input);
                        break;
                    case '%':
                        updatePercentageOperand();
                        break;
                    case '\b':
                        EraseLastLetterOfOperand();
                        break;
                    default:
                        log.Error("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                        throw new InvalidExpressionException();

                }

            }
        }

        protected void HandleKeyPressInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = CalculatorUtil.isValidNumpadInput(e.KeyChar, output1.Text);
            if (sender is CalculatorForm)
            {
                KeyPressInputHandler(e.KeyChar);
            }
        }

        private void eraseLastLetterOperand()
        {
            if (!isErasableOperatorOutput) return;
            if (!isFirstBasicOperationApplied)
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
        private void checkValidToResetOutputBeforeOperandSet()
        {
            if (isAllowedResetOutput)
            {
                backUpResetOutput = calcOperandPart1;
                resetOperand1();
                resetOutPut1();
                isAllowedResetOutput = false;
            }
            else if (isFirstBasicOperationApplied)
            {
                resetOutPut1();
            }
        }

        private void checkValidToResetOutputAfterOperatorSet()
        {
            if (isAllowedResetOutput)
            {
                resetOutPut1();
                isAllowedResetOutput = false;
            }
            if (!isFirstBasicOperationApplied)
            {
                resetOutPut1();
            }
            else
            {
                isAllowedResetOutput = true;
            }
        }

        private void button1Click(object sender, EventArgs e)
        {
            OperandButonClick(button1.Text);
        }
        private void button2Click(object sender, EventArgs e)
        {
            OperandButonClick(button2.Text);
        }
        private void button3Click(object sender, EventArgs e)
        {
            OperandButonClick(button3.Text);
        }
        private void button4Click(object sender, EventArgs e)
        {
            OperandButonClick(button4.Text);
        }
        private void button5Click(object sender, EventArgs e)
        {
            OperandButonClick(button5.Text);
        }
        private void button6Click(object sender, EventArgs e)
        {
            OperandButonClick(button6.Text);
        }
        private void button7Click(object sender, EventArgs e)
        {
            OperandButonClick(button7.Text);
        }
        private void button8Click(object sender, EventArgs e)
        {
            OperandButonClick(button8.Text);
        }
        private void button9Click(object sender, EventArgs e)
        {
            OperandButonClick(button9.Text);
        }
        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void buttonDotClick(object sender, EventArgs e)
        {
            OperandButonClick(buttonDot.Text);
        }

        private void buttonZeroClick(object sender, EventArgs e)
        {
            OperandButonClick(buttonZero.Text);
        }

        private void buttonSignClick(object sender, EventArgs e)
        {
            SignButtonClicked(buttonSign.Text);
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
            ResetCalculator();
        }

        private void buttonEquClick(object sender, EventArgs e)
        {
            EqualButtonClicked(buttonEqu);
        }

        private void buttonCEClick(object sender, EventArgs e)
        {
            resetOperandAndOutPut1();
        }

        private void buttonReciprocalClick(object sender, EventArgs e)
        {
            ReciprocalButtonClicked();
        }

        private void buttonSquareRootClick(object sender, EventArgs e)
        {
            SquareRootButtonClicked();
        }

        private void buttonSquaredClick(object sender, EventArgs e)
        {
            setSquaredClicked();
        }

        private void buttonBackClick(object sender, EventArgs e)
        {
            EraseLastLetterOfOperand();
        }

        private void buttonPercentageClick(object sender, EventArgs e)
        {
            try
            {
                PercentageButtonClicked();
            }
            catch
            {
                log.Error("Invalid Input ");
            }
        }

        private void updateOperand(string buttonText)
        {
            if (!isFirstBasicOperationApplied)
            {
                string operand1 = calcOperandPart1 + buttonText;
                setOperandPart1(operand1);
            }
            else if (isFirstBasicOperationApplied)
            {
                string operand2 = calcOperandPart2 + buttonText;
                setOperandPart2(operand2);
            }
        }

        private void updateOperandOutPut1()
        {
            if (!isFirstBasicOperationApplied && StringUtil.isValidSring(calcOperandPart1))
            {
                setOutput1(calcOperandPart1);
            }
            if (isFirstBasicOperationApplied && StringUtil.isValidSring(calcOperandPart2))
            {
                setOutput1(calcOperandPart2);
            }
        }

        private void updateSignOperand()
        {
            if (!isFirstBasicOperationApplied)
            {
                string operand1 = CalculatorUtil.getSignedString(calcOperandPart1);
                setOperandPart1(operand1);
            }
            else if (isFirstBasicOperationApplied)
            {
                string operand2 = CalculatorUtil.getSignedString(calcOperandPart2);
                setOperandPart2(operand2);
            }
        }

        private void updateSquaredOperand()
        {
            if (!isFirstBasicOperationApplied)
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
            if (!isFirstBasicOperationApplied)
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
            if (!isFirstBasicOperationApplied)
            {
                setOutput1(ZERO_TEXT);
            }
            if (isFirstBasicOperationApplied)
            {
                setOutput(calcOperandPart2, calcOperandPart1 + " " + calcOperator1 + " " + calcOperandPart2);
            }
        }

        private void updatePercentageOperand()
        {
            if (isFirstBasicOperationApplied)
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

        private void EqualButtonClicked(Button button)
        {
            EqualButtonClicked(button.Text);
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
            OperationsClick(button.Text);
        }

        private void setOperation(string buttonText)
        {
            if (!isFirstBasicOperationApplied)
            {
                isFirstBasicOperationApplied = true;
                setOperator1(buttonText);
            }
            else
            {
                setOperator2(buttonText);
                setOperandPart1(CalculatorUtil.calculateBasicOperationWithTwoOperands(calcOperandPart1, calcOperandPart2, calcOperator1));
                resetOperand2();
                setOperator1(calcOperator2);
                isFirstBasicOperationApplied = true;
                resetOperator2();
            }
        }
        private void setOperationOutput()
        {
            if (!isFirstBasicOperationApplied)
            {
                setOutput(calcOperandPart1, calcOperandPart1 + " " + calcOperator1 + " ");
            }
            else
            {
                setOutput2(calcOperandPart1 + " " + calcOperator1 + " ");
                setOutput1(calcOperandPart1);
            }
        }

        private void setOperationOutput2()
        {
            if (isFirstBasicOperationApplied)
            {
                setOutput2(calcOperandPart1 + " " + calcOperator1 + " ");
            }
        }


        private void eraseLastOutput1()
        {
            if (!isFirstBasicOperationApplied)
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

        private void resetCalculation()
        {
            resetOperator();
            resetOperand();
            isFirstBasicOperationApplied = false;

        }

        private void resetOperandAndOutPut1()
        {
            if (!isFirstBasicOperationApplied)
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

        private void setOperandPart1(string operand)
        {
            if (CalculatorUtil.isValidStringOperand(operand))
            {
                calcOperandPart1 = operand;
            }
        }

        private void setOperandPart2(string operand)
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
            resetOperator1();
            resetOperator2();
        }

        private void resetOperator1()
        {
            isFirstBasicOperationApplied = false;
            calcOperator1 = "";
        }

        private void resetOperator2()
        {
            calcOperator2 = "";
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

        private void resetOutPut1()
        {
            setOutput1("");
        }

    }
}
