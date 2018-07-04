using System;
using System.Collections.Generic;
using System.Text;

// $G$ RUL-004 (-10) Wrong zip name format / folder name format (missing space between first student id and name)
namespace GameForms
{
    public class Program
    {
        // $G$ CSS-004 (-2) Bad static variable name (should be in the form of s_PascalCased) 
        public static GameLogic.GameLogic.array<char> Target;

        public static GameLogic.GameLogic.array<char> getTarget(GameLogic.GameLogic.array<char> target)
        {
            return target;
        }

        public static void Main()
        {
            GameLogic.GameLogic.array<char> randomArray;
            randomArray = GameLogic.GameLogic.Logic.s_random();
            Target = getTarget(randomArray);
            NumberOfGuesses newUserGuessesScreen = new NumberOfGuesses();
            newUserGuessesScreen.ShowDialog();
            int m_amountOfGuesses = newUserGuessesScreen.getGuesses();

            if (newUserGuessesScreen.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                newUserGuessesScreen.Close();
                GameBoard newGameBoard = new GameBoard(m_amountOfGuesses);
                newGameBoard.ShowDialog();
            }
            else
            {
                newUserGuessesScreen.Close();
            }
        }
    }
}
