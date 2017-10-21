using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public static class RandomQuestions
    {
        public static void SwitchQuestion()
        {
            bool[] inputs = new bool[] { false, false, false, false, false, false };
            setPlayer(inputs, 2);
            setPlayer(inputs, 3);
            //setPlayer(inputs, 6);
            var result = getPlayers(inputs);
        }

        public static bool[] setPlayer(bool[] inputs, int playerNumber)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                if ((i+1) % playerNumber == 0)
                {
                    inputs[i] = !inputs[i];
                }
            }
            return null;
        }

        public static List<int> getPlayers(bool[] inputs)
        {
            var returnValue = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i])
                {
                    
                    int x = i+1;
                    returnValue.Add(x);
                    for (int j = x; j < inputs.Length;)
                    {
                        inputs[j] = !inputs[j];
                        j += i;
                    }
                }
            }

            return returnValue;
        }
    }
}
