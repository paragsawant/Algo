using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class Fibonacci
    {
        public void FibSeq(int n)
        {
            List<long> returnLong = new List<long>();
            int secondNumber = 1;
            int firstNumber = 0;
            int calculatedValue = 0;
            for (int i = 0; i < n; i++)
            {
                calculatedValue = firstNumber + secondNumber;
                returnLong.Add(calculatedValue);
                firstNumber = secondNumber;
                secondNumber = calculatedValue;
            }
            foreach (var item in returnLong)
            {
                Console.WriteLine(item);
            }
        }
    }
}
