namespace ScientificCalculator
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnP = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnOpenParenthesis = new System.Windows.Forms.Button();
            this.btnCloseParenthesis = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnClearOne = new System.Windows.Forms.Button();
            this.btnDivid = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.rchTxtHistory = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 29);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(555, 30);
            this.txtResult.TabIndex = 2;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnP);
            this.groupBox2.Controls.Add(this.btnEuler);
            this.groupBox2.Controls.Add(this.btnFactorial);
            this.groupBox2.Controls.Add(this.btnMax);
            this.groupBox2.Controls.Add(this.btnMin);
            this.groupBox2.Controls.Add(this.btnLog);
            this.groupBox2.Controls.Add(this.btnOpenParenthesis);
            this.groupBox2.Controls.Add(this.btnCloseParenthesis);
            this.groupBox2.Controls.Add(this.btnPow);
            this.groupBox2.Controls.Add(this.btnTan);
            this.groupBox2.Controls.Add(this.btnCot);
            this.groupBox2.Controls.Add(this.btnAvg);
            this.groupBox2.Controls.Add(this.btnSin);
            this.groupBox2.Controls.Add(this.btnCos);
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.btn8);
            this.groupBox2.Controls.Add(this.btn9);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btnComma);
            this.groupBox2.Controls.Add(this.btn0);
            this.groupBox2.Controls.Add(this.btnDot);
            this.groupBox2.Controls.Add(this.btnMultiple);
            this.groupBox2.Controls.Add(this.btnClearOne);
            this.groupBox2.Controls.Add(this.btnDivid);
            this.groupBox2.Controls.Add(this.btnClearAll);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Location = new System.Drawing.Point(309, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "buttons";
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.White;
            this.btnP.ForeColor = System.Drawing.Color.Black;
            this.btnP.Location = new System.Drawing.Point(6, 24);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(74, 54);
            this.btnP.TabIndex = 33;
            this.btnP.Text = "PI";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.BackColor = System.Drawing.Color.White;
            this.btnEuler.ForeColor = System.Drawing.Color.Black;
            this.btnEuler.Location = new System.Drawing.Point(86, 24);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Size = new System.Drawing.Size(74, 54);
            this.btnEuler.TabIndex = 32;
            this.btnEuler.Text = "E";
            this.btnEuler.UseVisualStyleBackColor = false;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.White;
            this.btnFactorial.ForeColor = System.Drawing.Color.Black;
            this.btnFactorial.Location = new System.Drawing.Point(166, 24);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(74, 54);
            this.btnFactorial.TabIndex = 31;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.White;
            this.btnMax.ForeColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(6, 84);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(74, 54);
            this.btnMax.TabIndex = 30;
            this.btnMax.Text = "max";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.White;
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(86, 84);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(74, 54);
            this.btnMin.TabIndex = 29;
            this.btnMin.Text = "min";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.White;
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(166, 84);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(74, 54);
            this.btnLog.TabIndex = 28;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnOpenParenthesis
            // 
            this.btnOpenParenthesis.BackColor = System.Drawing.Color.White;
            this.btnOpenParenthesis.ForeColor = System.Drawing.Color.Black;
            this.btnOpenParenthesis.Location = new System.Drawing.Point(6, 144);
            this.btnOpenParenthesis.Name = "btnOpenParenthesis";
            this.btnOpenParenthesis.Size = new System.Drawing.Size(74, 54);
            this.btnOpenParenthesis.TabIndex = 27;
            this.btnOpenParenthesis.Text = "(";
            this.btnOpenParenthesis.UseVisualStyleBackColor = false;
            this.btnOpenParenthesis.Click += new System.EventHandler(this.btnOpenParenthesis_Click);
            // 
            // btnCloseParenthesis
            // 
            this.btnCloseParenthesis.BackColor = System.Drawing.Color.White;
            this.btnCloseParenthesis.ForeColor = System.Drawing.Color.Black;
            this.btnCloseParenthesis.Location = new System.Drawing.Point(86, 144);
            this.btnCloseParenthesis.Name = "btnCloseParenthesis";
            this.btnCloseParenthesis.Size = new System.Drawing.Size(74, 54);
            this.btnCloseParenthesis.TabIndex = 26;
            this.btnCloseParenthesis.Text = ")";
            this.btnCloseParenthesis.UseVisualStyleBackColor = false;
            this.btnCloseParenthesis.Click += new System.EventHandler(this.btnCloseParenthesis_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackColor = System.Drawing.Color.White;
            this.btnPow.ForeColor = System.Drawing.Color.Black;
            this.btnPow.Location = new System.Drawing.Point(166, 144);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(74, 54);
            this.btnPow.TabIndex = 25;
            this.btnPow.Text = "pow";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.White;
            this.btnTan.ForeColor = System.Drawing.Color.Black;
            this.btnTan.Location = new System.Drawing.Point(6, 204);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(74, 54);
            this.btnTan.TabIndex = 24;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCot
            // 
            this.btnCot.BackColor = System.Drawing.Color.White;
            this.btnCot.ForeColor = System.Drawing.Color.Black;
            this.btnCot.Location = new System.Drawing.Point(86, 204);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(74, 54);
            this.btnCot.TabIndex = 23;
            this.btnCot.Text = "cot";
            this.btnCot.UseVisualStyleBackColor = false;
            this.btnCot.Click += new System.EventHandler(this.btnCot_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.BackColor = System.Drawing.Color.White;
            this.btnAvg.ForeColor = System.Drawing.Color.Black;
            this.btnAvg.Location = new System.Drawing.Point(166, 204);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(74, 54);
            this.btnAvg.TabIndex = 22;
            this.btnAvg.Text = "avg";
            this.btnAvg.UseVisualStyleBackColor = false;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.White;
            this.btnSin.ForeColor = System.Drawing.Color.Black;
            this.btnSin.Location = new System.Drawing.Point(6, 264);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(74, 54);
            this.btnSin.TabIndex = 21;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.White;
            this.btnCos.ForeColor = System.Drawing.Color.Black;
            this.btnCos.Location = new System.Drawing.Point(86, 264);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(74, 54);
            this.btnCos.TabIndex = 20;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.White;
            this.btnSum.ForeColor = System.Drawing.Color.Black;
            this.btnSum.Location = new System.Drawing.Point(166, 264);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(74, 54);
            this.btnSum.TabIndex = 19;
            this.btnSum.Text = "sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(246, 84);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 54);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(327, 84);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 54);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(407, 84);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 54);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(246, 144);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 54);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(327, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 54);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(407, 144);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 54);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(246, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 54);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(327, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 54);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(407, 204);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 54);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.White;
            this.btnComma.ForeColor = System.Drawing.Color.Black;
            this.btnComma.Location = new System.Drawing.Point(246, 264);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(74, 54);
            this.btnComma.TabIndex = 9;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(327, 264);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 54);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(407, 264);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(74, 54);
            this.btnDot.TabIndex = 7;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.Color.White;
            this.btnMultiple.ForeColor = System.Drawing.Color.Black;
            this.btnMultiple.Location = new System.Drawing.Point(487, 24);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(74, 54);
            this.btnMultiple.TabIndex = 6;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnClearOne
            // 
            this.btnClearOne.BackColor = System.Drawing.Color.White;
            this.btnClearOne.ForeColor = System.Drawing.Color.Black;
            this.btnClearOne.Location = new System.Drawing.Point(326, 24);
            this.btnClearOne.Name = "btnClearOne";
            this.btnClearOne.Size = new System.Drawing.Size(74, 54);
            this.btnClearOne.TabIndex = 5;
            this.btnClearOne.Text = "C";
            this.btnClearOne.UseVisualStyleBackColor = false;
            this.btnClearOne.Click += new System.EventHandler(this.btnClearOne_Click);
            // 
            // btnDivid
            // 
            this.btnDivid.BackColor = System.Drawing.Color.White;
            this.btnDivid.ForeColor = System.Drawing.Color.Black;
            this.btnDivid.Location = new System.Drawing.Point(407, 24);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(74, 54);
            this.btnDivid.TabIndex = 4;
            this.btnDivid.Text = "/";
            this.btnDivid.UseVisualStyleBackColor = false;
            this.btnDivid.Click += new System.EventHandler(this.btnDivid_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(246, 24);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(74, 54);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "CE";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Location = new System.Drawing.Point(487, 84);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(74, 54);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(487, 144);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(74, 54);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(487, 204);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 114);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "=";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearHistory);
            this.groupBox3.Controls.Add(this.rchTxtHistory);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 398);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.White;
            this.btnClearHistory.Location = new System.Drawing.Point(6, 338);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(279, 54);
            this.btnClearHistory.TabIndex = 1;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // rchTxtHistory
            // 
            this.rchTxtHistory.Location = new System.Drawing.Point(6, 29);
            this.rchTxtHistory.Name = "rchTxtHistory";
            this.rchTxtHistory.ReadOnly = true;
            this.rchTxtHistory.Size = new System.Drawing.Size(279, 303);
            this.rchTxtHistory.TabIndex = 0;
            this.rchTxtHistory.Text = "";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnClearOne;
        private System.Windows.Forms.Button btnDivid;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnOpenParenthesis;
        private System.Windows.Forms.Button btnCloseParenthesis;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rchTxtHistory;
        private System.Windows.Forms.Button btnClearHistory;
    }
}

