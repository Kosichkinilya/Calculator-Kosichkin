namespace Calculator_Kosichkin;

public partial class MainPage : ContentPage
{
    private string currentInput = string.Empty;
    private string currentOperator = string.Empty;
    private double result = 0.0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Btn_numbers(object sender, EventArgs e)
    {
        //Entry_1.Text += (sender as Button).Text; // нажатая кнопка выводится в entry

        Button button = (Button)sender;
        currentInput += button.Text;
        Entry_1.Text = currentInput;
    }

    private void OnOperatorButton(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (!string.IsNullOrEmpty(currentInput))
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                result = PerformOperation(result, double.Parse(currentInput), currentOperator);
                Entry_1.Text = result.ToString();
            }
            else
            {
                result = double.Parse(currentInput);
            }

            currentInput = string.Empty;
            currentOperator = button.Text;
        }
    }

    private void OnCalculate(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(currentOperator))
        {
            result = PerformOperation(result, double.Parse(currentInput), currentOperator);
            Entry_1.Text = result.ToString();
            currentInput = string.Empty;
            currentOperator = string.Empty;
        }
    }

    private void OnCleaer(object sender, EventArgs e)
    {
        currentInput = string.Empty;
        currentOperator = string.Empty;
        result = 0.0;
        Entry_1.Text = "0";
    }



   


    private double PerformOperation(double operand1, double operand2, string operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "×":
                return operand1 * operand2;
            case "÷":
                if (operand2 != 0)
                {
                    return operand1 / operand2;
                }
                else
                {
                    // Handle division by zero
                    return double.NaN;
                }
            default:
                return operand2;
        }
    }
}

