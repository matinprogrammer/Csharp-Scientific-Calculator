using ScientificCalculator.CalculatorCore;
using ScientificCalculator.DataLayer;
using System;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class calculator : Form
    {
        ICalculator calc;

        public calculator()
        {
            InitializeComponent();
            txtResult.SelectionStart = 0;
            calc = new PostFixCalculator();
            FillHository();
        }

        void addOperandToResult(string operand)
        {
            int cursorPos = txtResult.SelectionStart;
            string startTxt = txtResult.Text.Substring(0, cursorPos);
            string endTxt = txtResult.Text.Substring(cursorPos, txtResult.TextLength - cursorPos);
            txtResult.Text = startTxt + operand + endTxt;
            cursorPos += operand.Length;
            txtResult.SelectionStart = cursorPos;
        }

        void addOperatorToResult(string operator_, bool addParenthesis = false)
        {

            if (addParenthesis)
            {
                addOperandToResult(operator_ + "()");
                txtResult.SelectionStart -= 1;
            }
            else
            {
                addOperandToResult(operator_);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addOperandToResult("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addOperandToResult("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addOperandToResult("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addOperandToResult("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addOperandToResult("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addOperandToResult("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addOperandToResult("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addOperandToResult("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addOperandToResult("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addOperandToResult("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            addOperandToResult(".");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            addOperandToResult(",");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            addOperatorToResult("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            addOperatorToResult("-");
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            addOperatorToResult("*");
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            addOperatorToResult("/");
        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
            clearLastCharOfResult();
        }

        void clearLastCharOfResult()
        {
            int cursorPos = txtResult.SelectionStart;
            string startTxt = txtResult.Text.Substring(0, cursorPos - 1);
            string endTxt = txtResult.Text.Substring(cursorPos, txtResult.TextLength - cursorPos);
            txtResult.Text = startTxt + endTxt;
            txtResult.SelectionStart = --cursorPos;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            addOperatorToResult("SIN", true);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            addOperatorToResult("COS", true);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            addOperatorToResult("SUM", true);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            addOperatorToResult("TAN", true);
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            addOperatorToResult("COT", true);
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            addOperatorToResult("POW", true);
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            addOperatorToResult("(");
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            addOperatorToResult(")");
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            addOperatorToResult("MAX", true);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            addOperatorToResult("MIN", true);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            addOperatorToResult("LOG", true);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            addOperatorToResult("!");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            addOperandToResult("3.1415");
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            addOperandToResult("2.7182");
        }

        void addToHistory(string mathExpresion, string result)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                History history = new History()
                {
                    MathExpresion = mathExpresion,
                    Result = result,
                    Time = DateTime.Now,
                };
                uow.HistoryRepository.Add(history);
                uow.Save();
            }
            FillHository();
        }

        void FillHository()
        {
            rchTxtHistory.Text = "";
            using (UnitOfWork uow = new UnitOfWork())
            {
                var histories = uow.HistoryRepository.GetAll();
                foreach (var history in histories)
                {
                    rchTxtHistory.Text += history.MathExpresion + "\n";
                    rchTxtHistory.Text += "result: " + history.Result + "\n";
                    rchTxtHistory.Text += "-----------------------------" + "\n";
                }
            }
            rchTxtHistory.SelectionStart = rchTxtHistory.Text.Length;
            rchTxtHistory.ScrollToCaret();
        }

        void submitMathString()
        {
            string mathString = txtResult.Text;
            if (mathString == "")
            {
                MessageBox.Show("You must enter mathString", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float result = calc.evaluate(mathString);
            addToHistory(mathString, result.ToString());
            txtResult.Text = result.ToString();
            txtResult.SelectionStart = txtResult.Text.Length;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitMathString();
        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Oemplus)
            {
                e.SuppressKeyPress = true;
                submitMathString();
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var histories = uow.HistoryRepository.GetAll();
                uow.HistoryRepository.Delete(histories);
                FillHository();
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            addOperatorToResult("AVG", true);
        }
    }
}
