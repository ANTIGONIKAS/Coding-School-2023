using CalculatorLib;
using static CalculatorLib.Calculation;
using static System.Net.Mime.MediaTypeNames;

namespace Session_09
{
    public partial class Form1 : Form
    {
        public decimal? _x = null;
        public decimal? _y = null;
        public decimal? _res = null;

        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition,
            Subtraction,     
            Multiplication,
            Division,
            RaiseToPower,
            SquareRoot

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation();
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _res = addition.Do(_x, _y);

                    break;
                case CalcOperation.Subtraction:

                    Subtraction sub = new Subtraction();
                    _res = sub.Do(_x, _y);

                    break;
                case CalcOperation.Multiplication:

                    Multiplication mul = new Multiplication();
                    _res = mul.Do(_x, _y);

                    break;

                case CalcOperation.Division:
                    Division div = new Division();
                    _res = div.Do(_x, _y);

                    break;
                case CalcOperation.RaiseToPower:
                    RaiseToPower power = new RaiseToPower();
                    _res = power.Do(_x, _y);
                    break;

                case CalcOperation.SquareRoot:
                    SquareRoot sq = new SquareRoot();
                    _res = sq.Do(_x);
                    break;
                default:
                    break;
            }

            ctrlDisplay.Text += _res;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            NewNumber(1);
            ctrlDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            NewNumber(2);
            ctrlDisplay.Text += "2";

        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            NewNumber(3);
            ctrlDisplay.Text += "3";

        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            NewNumber(4);
            ctrlDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            NewNumber(5);
            ctrlDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            NewNumber(1);
            ctrlDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            NewNumber(7);
            ctrlDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            NewNumber(8);
            ctrlDisplay.Text += "8";

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            NewNumber(9);
            ctrlDisplay.Text += "9";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            NewNumber(0);
            ctrlDisplay.Text += "0";
        }
        //method NewNumber
        private void NewNumber(decimal? number)
    {
        if (_res != null)
        {
            ctrlDisplay.Text = string.Empty;
            _x = null;
            _y = null;
            _res = null;
            ctrlDisplay.Text = string.Empty;
        }

        if (_x == null)
        {
            _x = number;
        }
        else
        {
            _y = number;
        }
    }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "+";
            _calcOperation = CalcOperation.Addition;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "-";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "*";
            _calcOperation = CalcOperation.Multiplication;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
            _calcOperation = CalcOperation.Division;


        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " . ";
          

        }

        private void btnPower_Click(object sender, EventArgs e)
        {

            ctrlDisplay.Text += " 2X ";
            _calcOperation = CalcOperation.RaiseToPower;




        }

        private void btnSqR_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " √ ";
            _calcOperation = CalcOperation.SquareRoot;


        }
    }
}

    //    private void ctrlDisplay_TextChanged(object sender, EventArgs e)
    //    {
           
    //}
