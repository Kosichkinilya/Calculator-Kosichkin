namespace Calculator_Kosichkin;

public partial class MainPage : ContentPage
{
    private string currentInput = "";
    private double firstNumber = 0;
    private char operation = ' ';

    public MainPage()
    {
        InitializeComponent();
    }

    private void Btn_numbers(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button != null)
        {
            int number = int.Parse(button.Text);
            currentInput += number.ToString();
            Entry_1.Text = currentInput;
        }
    }

    private void Btn_plus(object sender, EventArgs e)
    {
        PerformCalculation();
        operation = '+';
    }

    private void btn_minus(object sender, EventArgs e)
    {
        PerformCalculation();
        operation = '-';
    }

    private void Btn_divide(object sender, EventArgs e)
    {
        PerformCalculation();
        operation = '/';
    }

    private void Btn_multiply(object sender, EventArgs e)
    {
        PerformCalculation();
        operation = '*';
    }

    private void Btn_equals(object sender, EventArgs e)
    {
        PerformCalculation();
        operation = ' ';
    }

    private void Btn_reset(object sender, EventArgs e)
    {

        currentInput = "";
        firstNumber = 0;
        operation = ' ';
        Entry_1.Text = "0";
    }


    private void PerformCalculation()
    {
        if (!string.IsNullOrEmpty(currentInput))
        {
            double inputNumber = double.Parse(currentInput);
            switch (operation)
            {
                case '+':
                    firstNumber += inputNumber;
                    break;
                case '-':
                    firstNumber -= inputNumber;
                    break;
                case '*':
                    firstNumber *= inputNumber;
                    break;
                case '/':
                    if (inputNumber != 0)
                    {
                        firstNumber /= inputNumber;
                    }
                    else
                    {
                        // вывести ошибку деления на ноль 
                    }
                    break;
            }
            currentInput = "";
            Entry_1.Text = firstNumber.ToString();
        }

    }
}

