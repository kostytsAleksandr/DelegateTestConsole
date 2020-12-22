using System;

namespace DelegateTestConsole
{
    public delegate void ShowHandler(bool value);
    public delegate int PowHandler(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            var a= new Class2();
            var b = new Class1();
            b.ShowHandlerDelegate = Show;
            b.ShowHandlerDelegate(a.Calc(b.powHandler, 2, 3).Invoke(2));
            Console.ReadKey();
        }

        public static void Show(bool value)
        {
            Console.WriteLine(value);
        }
    }
}


//Класс Program содержит:
//1)	метод “Show”, принимает на вход результат выполнения делегата на метод “Result” 
//и отображает его в консоль.