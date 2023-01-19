using CalculatorLib;

namespace Session_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";
            _calcOperation = CalcOperation.Addition;

            switch (_calcOperation)
            {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);

                    break;

                default:
                    break;
            }

            ctrlDisplay.Text += _result;
        }


        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
            ctrlDisplay.Text += " 1 ";
            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }

        }
    }

    private void btnAddition_Click(object sender, EventArgs e)
    {
        ctrlDisplay.Text += " + ";
      

       
        _calcOperation = CalcOperation.Addition;
    }

}
