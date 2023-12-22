var calculator = new Calculator(1,2);
calculator.FirstNumber =Convert.ToInt32(Console.ReadLine()); 
calculator.Operation = Convert.ToChar(Console.ReadLine());
calculator.SecondNumber = Convert.ToInt32(Console.ReadLine());

class Calculator
{
    public int FirstNumber;
    public char Operation;
    public int SecondNumber;
    public Calculator(int a,int b)
    {
        FirstNumber=a;
        SecondNumber=b;
        if(Operation == '+')
        {
            string Sum()
            {
                return $"{a} + {b} = {a+b}";
            }
        }
        else if(Operation == '-')
        {
            string Subtract()
            {
                return $"{a} - {b} = {a-b}";
            }
        }   
        else if(Operation == '/')
        {
            string Multiplication()
            {
                return $"{a} / {b} = {a/b}";
            }
        }
        else
        {
            string Multiplication()
            {
                return $"{a} * {b} = {a*b}";
            }
        }
    }
}