using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class GameLogic
    {
        private const int k_MinGuesses = 4;
        private const int k_MaxGuesses = 10;
        
        public class array<arrayTemplate>
        {
            private arrayTemplate[] userOrComputerArray = new arrayTemplate[4];

            public arrayTemplate this[int i]
            {
                get
                {
                    return userOrComputerArray[i];
                }

                set
                {
                    userOrComputerArray[i] = value;
                }
            }
        }

        private static array<char> s_generateRandomComputerChoise()
        {
            Random m_randomLetter = new Random();
            array<char> m_computerChoise = new array<char>();
            int i = 0;
            int j = 0;
            m_computerChoise[i] = (char)m_randomLetter.Next(65, 73);
            for (i = 1; i < 4; i++)
            {
                j = 0;
                m_computerChoise[i] = (char)m_randomLetter.Next(65, 73);
                while (j < 4)
                {
                    while (j != i && m_computerChoise[i] == m_computerChoise[j])
                    {
                        m_computerChoise[i] = (char)m_randomLetter.Next(65, 73);
                        j = 0;
                    }

                    j++;
                }
            }

            return m_computerChoise;
        }

        public class Logic
        {
            public static array<char> s_random()
            {
                array<char> randomArray;
                randomArray = s_generateRandomComputerChoise();

                return randomArray;
            }

            public static array<char> s_game(string i_userInput, array<char> target, out bool o_win)
            {
                array<char> guess = inputsAndOutputs.s_putUserGuessInArray(i_userInput);
                array<char> hitMissOrDirect = s_checkIfHitOrDirectOrMiss(target, guess);
                o_win = s_checkIfWon(guess, target);
                
                return hitMissOrDirect;
            }

            public static array<char> s_checkIfHitOrDirectOrMiss(array<char> i_target, array<char> i_guess)
            {
                array<char> m_hitMissOrDirectArray = new array<char>();
                int i = 0;
                int j = 0;
                while (i < 4)
                {
                    if (i_guess[i] == i_target[i] && j < 4)
                    {
                        m_hitMissOrDirectArray[j] = 'V';
                        j++;
                    }

                    i++;
                }

                i = 0;
                while (i < 4)
                {
                    if (i_guess[i] != i_target[i])
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (i_guess[i] == i_target[k])
                            {
                                m_hitMissOrDirectArray[j] = 'X';
                                j++;
                                break;
                            }
                        }
                    }

                    i++;
                }

                return m_hitMissOrDirectArray;
            }

            public static bool s_checkIfWon(array<char> i_guess, array<char> i_target)
            {
                bool m_win = true;
                for (int i = 0; i < 4; i++)
                {
                    if (i_guess[i] != i_target[i])
                    {
                        m_win = false;
                        break;
                    }
                }

                return m_win;
            }
        }

        public class inputsAndOutputs
        {
            public static array<char> s_putUserGuessInArray(string i_userInput)
            {
                array<char> m_userGuessArray = new array<char>();
                int j = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (char.IsWhiteSpace(i_userInput[i]) == true)
                    {
                        j++;
                    }
                    else
                    {
                        m_userGuessArray[j] = i_userInput[i];
                    }
                }

                return m_userGuessArray;
            }

            public static int s_amountOfGuessesUserWants(int m_amountOfGuesses)
            {
                m_amountOfGuesses++;
                if (m_amountOfGuesses == k_MaxGuesses + 1)
                {
                    m_amountOfGuesses = k_MinGuesses;
                }

                return m_amountOfGuesses;
            }
        }
    }
}