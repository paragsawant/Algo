﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTopics
{
    public class NumbersQuestions
    {
        public List<int> FindMissingNumber(int[] numbers,int low ,int high)
        {
            var returnList = new List<int>();
            List<int> numbersList = new List<int>();
            foreach (var number in numbers)
            {
                numbersList.Add(number);
            }

            for (int i = low; i <= high; i++)
            {
                if(!numbersList.Contains(i))
                {
                    returnList.Add(i);
                }
            }

            return returnList;
        }

        public List<int> Deciaml2Binary(int input)
        {
            List<int> binaryValue = new List<int>();
            int i = 0;
            while (input>0)
            {
                binaryValue.Add(input % 2);
                input = input / 2;
                i++;
            }

            return binaryValue.OrderByDescending(x=> x).ToList();
        }
    }
}
