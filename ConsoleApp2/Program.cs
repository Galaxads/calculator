// See https://aka.ms/new-console-template for more information
int i=1;
double b;
double c=0;
string operation;
while( i<1000)
{
    if (c == 0)
    {
        Console.WriteLine($"{c}\nВведите число");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите операцию(+;-;/;*;%;+/-;n!;ln;log;10^x;x^2;x^5;x^y;√;3√x;y√x;1/x;sin;cos;tan;sinh;cosh;tanh;|a|;c и т.д)");
        operation = Console.ReadLine();

    }
    else
    {
        Console.WriteLine($"{c}");
        Console.WriteLine("Введите операцию(+;-;/;*;%;+/-;n!;ln;log;10^x;x^2;x^5;x^y;√;3√x;y√x;1/x;sin;cos;tan;sinh;cosh;tanh;|a|;c и т.д)");
        operation = Console.ReadLine();
    }
    switch (operation)
    {
        case "+":
                Console.WriteLine($"Введите число");
                b = Convert.ToDouble(Console.ReadLine());
                c = c + b;
      
            break;
        case "-":
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            c = c - b;
            break;
        case "*":
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            c = c * b;
            break;
        case "/":
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            c = c / b;
            break;
        case "%":
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            c = c % b;
            break;
        case "+/-":
            if (c>0)
            {
                c -= c*2;
            }
            else
            {
                c -= c * 2;
            }
                    
            break;
        case "n!":         
            double l=1;
            for (double v=1;v<=c ;v++)
            {
               l=l*= v;
            }
            c=l;

            break;
        case "ln":
            c = Math.Log(c);
            break;
        case "log":
            c = Math.Log(c,c/2);
            break;
        case "10^x":
            c = Math.Pow(10,c);
            break;
        case "x^2":
            c = Math.Pow(c, 2);
            break;
        case "x^5":
            c = Math.Pow(c, 5);
            break;
        case "x^y":
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Pow(c, b);
            break;
        case "√":
            c=Math.Sqrt(c);
            break;
        case "1/x":
            c = 1/c;
            break;
        case "3√x":
            double k=0;
            double r=1;
            while (k<c)
            {
                k = Math.Pow(r, 3);
                r++;
            }
            c = r-1;
            
            break;
        case "y√x":
            double n = 0;
            double f ;
            Console.WriteLine($"Введите число");
            b = Convert.ToDouble(Console.ReadLine());
            for ( f = 1; n <c ; f++)
            {
                n = Math.Pow(f, b); ;
            }
            c = f-1;
            break;
            
        case "sin":
             c=Math.Sin(c);
            break;
        case "cos":
            c = Math.Cos(c);
            break;
        case "tan":
            c = Math.Tan(c);
            break;
        case "sinh":
            c = Math.Sinh(c);
            break;
        case "cosh":
            c = Math.Cosh(c);
            break;
        case "tanh":
            c = Math.Tanh(c);
            break;
        case "c":
            c = 0;
            break;
        case "|a|":
            if (c > 0)
            {
                
            }
            else
            {
                c -= c * 2;
            }
            break;
       
    }
    i ++;
}
