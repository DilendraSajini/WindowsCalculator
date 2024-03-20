
using System.Windows.Forms;

namespace WindowsCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEqu = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonPer = new System.Windows.Forms.Button();
            this.output2 = new System.Windows.Forms.TextBox();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReciprocal = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(12, 41);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(229, 23);
            this.output1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(78, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 36);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(141, 175);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 36);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(141, 336);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(42, 36);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDotClick);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(78, 337);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(42, 36);
            this.buttonZero.TabIndex = 11;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZeroClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(141, 70);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(42, 37);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClearClick);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(199, 119);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(42, 36);
            this.buttonDiv.TabIndex = 13;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDivClick);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(199, 175);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(42, 36);
            this.buttonMul.TabIndex = 14;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMulClick);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(199, 229);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(42, 36);
            this.buttonSub.TabIndex = 15;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSubClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(199, 284);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 36);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddClick);
            // 
            // buttonEqu
            // 
            this.buttonEqu.Location = new System.Drawing.Point(199, 335);
            this.buttonEqu.Name = "buttonEqu";
            this.buttonEqu.Size = new System.Drawing.Size(42, 37);
            this.buttonEqu.TabIndex = 18;
            this.buttonEqu.Text = "=";
            this.buttonEqu.UseVisualStyleBackColor = true;
            this.buttonEqu.Click += new System.EventHandler(this.buttonEquClick);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(13, 336);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(42, 37);
            this.buttonSign.TabIndex = 19;
            this.buttonSign.Text = "-/+";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSignClick);
            // 
            // buttonPer
            // 
            this.buttonPer.Location = new System.Drawing.Point(13, 70);
            this.buttonPer.Name = "buttonPercentage";
            this.buttonPer.Size = new System.Drawing.Size(42, 37);
            this.buttonPer.TabIndex = 20;
            this.buttonPer.Text = "%";
            this.buttonPer.UseVisualStyleBackColor = true;
            this.buttonPer.Click += new System.EventHandler(this.buttonPercentageClick);
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(115, 11);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(126, 23);
            this.output2.TabIndex = 21;
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(78, 70);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(42, 37);
            this.buttonCE.TabIndex = 22;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCEClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(199, 70);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(42, 35);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBackClick);
            // 
            // buttonReciprocal
            // 
            this.buttonReciprocal.Location = new System.Drawing.Point(13, 121);
            this.buttonReciprocal.Name = "buttonReciprocal";
            this.buttonReciprocal.Size = new System.Drawing.Size(41, 34);
            this.buttonReciprocal.TabIndex = 24;
            this.buttonReciprocal.Text = "1/x";
            this.buttonReciprocal.UseVisualStyleBackColor = true;
            this.buttonReciprocal.Click += new System.EventHandler(this.buttonReciprocalClick);
            // 
            // buttonSquared
            // 
            this.buttonSquared.Location = new System.Drawing.Point(78, 121);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(42, 35);
            this.buttonSquared.TabIndex = 25;
            this.buttonSquared.Text = "x²";
            this.buttonSquared.UseVisualStyleBackColor = true;
            this.buttonSquared.Click += new System.EventHandler(this.buttonSquaredClick);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Location = new System.Drawing.Point(141, 121);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(42, 34);
            this.buttonSquareRoot.TabIndex = 26;
            this.buttonSquareRoot.Text = "2√x";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRootClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 385);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.buttonReciprocal);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.buttonPer);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonEqu);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output1);
            this.KeyPreview = true;
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string Output1
        {
            get { return output1.Text; }
            set { output1.Text = value; }
        }

        public string Output2
        {
            get { return output2.Text; }
            set { output2.Text = value; }
        }
        #endregion

        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.TextBox output2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEqu;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonPer;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReciprocal;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button buttonSquareRoot;
    }
}

