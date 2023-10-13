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
        Entry_1.Text += (sender as Button).Text; // нажатая кнопка выводится в entry

    }

    private void Btn_plus(object sender, EventArgs e)
    {
     // кнопка сложения
    }

    private void btn_minus(object sender, EventArgs e)
    {
       // кнопка вычитания 
    }

    private void Btn_divide(object sender, EventArgs e)
    {
       // кнопка деления
    }

    private void Btn_multiply(object sender, EventArgs e)
    {
       // кнопка умножения
    }

    private void Btn_equals(object sender, EventArgs e)
    {
        // кнопка равенства 
    }

    private void Btn_reset(object sender, EventArgs e)
    {
     // кнопка сброса 
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

