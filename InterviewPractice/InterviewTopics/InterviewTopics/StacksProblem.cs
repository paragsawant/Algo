using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class StacksProblem
    {

        public int GetEvaluatedValue(string expression)
        {
            Stack<int> operands = new Stack<int>();
            Stack<char> operators = new Stack<char>();
            foreach (var str in expression)
            {
                if (((int)str > 47 && (int)str < 58))
                {
                    operands.Push(Convert.ToInt32(str.ToString()));

                }
                else if ((int)str == 42 || (int)str == 43)
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(str);
                    }
                    else
                    {
                        var currentvalue = operators.Peek();
                        if ((int)currentvalue <= (int)str)
                        {
                            var op = operators.Pop();
                            var a = operands.Pop();
                            var b = operands.Pop();
                            operands.Push(Evaluate(op, a, b));
                            operators.Push(str);
                        }
                        else
                        {
                            operators.Push(str);
                        }
                    }
                }
                else
                {
                    return -1;
                }
            }
            var result = 0;
            //result = operands.Pop();
            while (operators.Count != 0)
            {
                var op = operators.Pop();
                var a = operands.Pop();
                var b = operands.Pop();
                operands.Push(Evaluate(op, a, b));
            }

            return operands.Pop();
        }

        private int Evaluate(char operators, int a, int b)
        {
            switch (operators)
            {
                case '*':
                    return a * b;
                case '+':
                    return a + b;
                default:
                    return -1;
            }
        }
    }
}
