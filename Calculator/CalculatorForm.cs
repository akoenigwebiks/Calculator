using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private TextBox _activeTextbox;
        private string _activeOperator;
        public CalculatorForm()
        {
            InitializeComponent();
            _activeTextbox = textBox_val1;
            _activeOperator = SetActiveOperator();
        }

        private void button_num_Click(object sender, EventArgs e)
        {
            _activeTextbox.Text += ((Button)sender).Text;
        }

        private void button_operator_Click(object sender, EventArgs e)
        {
            _activeOperator = ((Button)sender).Text;
            comboBox_operator.Text = _activeOperator;
        }

        private void textBox_val_Click(object sender, EventArgs e)
        {
            _activeTextbox = (TextBox)sender;
        }

        private string SetActiveOperator()
        {
            string operatorText = comboBox_operator.Text;
            return operatorText == string.Empty ? "+" : operatorText;
        }

        private void comboBox_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            _activeOperator = this.SetActiveOperator();
        }

        private double? Calculate(double val1, double val2, string selectedOperator)
        {
            switch (selectedOperator)
            {
                case "+":
                    return (val1 + val2);
                case "-":
                    return (val1 - val2);
                case "x":
                    return (val1 * val2);
                case "/":
                    return (val1 / val2);
                default:
                    return null;
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            // Check if either textbox is empty or null and return immediately if so
            if (string.IsNullOrEmpty(textBox_val2.Text) || string.IsNullOrEmpty(textBox_val1.Text))
            {
                MessageBox.Show("אנא הזינו ערך בשני השדות על מנת לקבל תוצאה");
                return;
            }

            // Safely parse the values as both text boxes have been confirmed to be non-empty
            double val1 = double.Parse(textBox_val1.Text);
            double val2 = double.Parse(textBox_val2.Text);

            // Assuming Calculate is a method defined elsewhere that handles the calculation based on the operator
            double? result = Calculate(val1, val2, this.SetActiveOperator());
            textBox_result.Text = result.ToString();
        }

    }
}
