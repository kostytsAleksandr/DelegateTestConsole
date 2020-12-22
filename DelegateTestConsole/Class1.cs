using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTestConsole
{
    public class Class1
    {
        public Class1()
        {
            this.powHandler = Pow;
        }

        public PowHandler powHandler;

        public ShowHandler ShowHandlerDelegate;

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
//Описать class 1, который содержит:
//1) 	делегат,  который ничего не возвращает, но принимает bool ( делегат ссылается на метод “Show”).
//2)	метод “Pow”, который принимает в качестве аргумента 2 числа и возвращает результат умножение