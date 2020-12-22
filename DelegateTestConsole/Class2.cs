using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTestConsole
{
    
    public class Class2
    {
        private int powValue; 
        
        public Class2()
        {
            predicate = Result;
        }

        public Predicate<int> predicate;

        //1)	метод “Calc”, который принимает на вход  делегат для метода “Pow”, а также параметры для расчета.
        //Метод “Calc” выполняет вызов делегата для метода “Pow” и сохраняет значения результата внутри класса.
        //Возвращающим типом метода “Calc” является делегат. Этот делегат должен принимать 1 число в качестве параметра,
        //а в качестве результата возвращать значение bool. Этот делегат ссылается на метод “Result”.
        public Predicate<int> Calc(PowHandler powHandler, int x, int y)
        {
            powValue = powHandler.Invoke(x, y);
            return this.predicate;
        }

        //2) 	метод “Result”, который принимает в качестве аргумента 1 число и возвращает bool. 
        //Текущий метод должен посчитать остаток от деления результат выполнения вызова делегата на метод “Pow”
        //и числа пришедшего в метод как параметр. Сделать проверку на то, что делиться ли число у нас без остатка 
        //или же нет и вернуть это как результат метода “Result”
        public bool Result(int inputValue)
        {
            if (powValue % inputValue==0)
            {
                return true;
            }
            return false;
        }
    }
}