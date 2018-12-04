using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class BracesChecker
    {
        //Написать программу, проверяющую правильность расстановки  
        //скобок в арифметическом выражении. Скобки могут быть круглыми, 
        //квадратными и фигурными.
        public string Str { get; set; }
        MyStack<char> stack;

        public BracesChecker(string str)
        {
            Str = str;
        }
        public bool Check()
        {
            stack = new MyStack<char>();
            for (int i = 0; i < Str.Length; i++)
            {
                switch (Str[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(Str[i]);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;
                }
            }
            if (stack.Count != 0)
                return false;
            return true;
        }
    }
}
