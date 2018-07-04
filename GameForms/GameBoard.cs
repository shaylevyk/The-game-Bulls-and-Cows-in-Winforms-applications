using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameForms
{
    // $G$ CSS-016 (-3) Bad class name - The name of classes derived from Form should end with Form.
    // $G$ DSN-002 (-10) User guesses/feedbacks belong in the game logic. The UI should only reflect the game's state to the user.
    public partial class GameBoard : Form
    {
        // $G$ DSN-004 (-5) Code duplication. You should use collection to handle board buttons.
        private Button rightGuess1;
        private Button rightGuess2;
        private Button rightGuess3;
        private Button rightGuess4;

        public Button[] Arr;
        // $G$ NTT-999 (-5) You should have used constant for the length variable.
        public Button[] RightGuesses = new Button[4];

        // $G$ CSS-013 (-5) Bad input variable name (should be in the form of i_PascalCased)
        public GameBoard(int m_amountOfGuesses)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent(m_amountOfGuesses);
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent(int m_amountOfGuesses)
        {
            Arr = new Button[9 * m_amountOfGuesses];
            this.SuspendLayout();

            // GameBoard
            this.Size = new System.Drawing.Size(284, 125 + (m_amountOfGuesses * 40));
            this.Name = "GameBoard";
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.GameBoard_Load_1);

            this.rightGuess1 = new System.Windows.Forms.Button();
            this.rightGuess2 = new System.Windows.Forms.Button();
            this.rightGuess3 = new System.Windows.Forms.Button();
            this.rightGuess4 = new System.Windows.Forms.Button();
            this.rightGuess1.Enabled = false;
            this.rightGuess2.Enabled = false;
            this.rightGuess3.Enabled = false;
            this.rightGuess4.Enabled = false;
            this.rightGuess1.BackColor = Color.Black;
            this.rightGuess2.BackColor = Color.Black;
            this.rightGuess3.BackColor = Color.Black;
            this.rightGuess4.BackColor = Color.Black;

            this.rightGuess1.Location = new System.Drawing.Point(20, 20);
            this.rightGuess1.Name = "rightGuess1";
            this.rightGuess1.Size = new System.Drawing.Size(35, 35);
            this.rightGuess1.TabIndex = 0;
            this.rightGuess1.Text = " ";
            this.rightGuess1.UseVisualStyleBackColor = true;

            this.Controls.Add(rightGuess1);

            this.rightGuess2.Location = new System.Drawing.Point(60, 20);
            this.rightGuess2.Name = "rightGuess2";
            this.rightGuess2.Size = new System.Drawing.Size(35, 35);
            this.rightGuess2.TabIndex = 0;
            this.rightGuess2.Text = " ";
            this.rightGuess2.UseVisualStyleBackColor = true;

            this.Controls.Add(rightGuess2);

            this.rightGuess3.Location = new System.Drawing.Point(100, 20);
            this.rightGuess3.Name = "rightGuess3";
            this.rightGuess3.Size = new System.Drawing.Size(35, 35);
            this.rightGuess3.TabIndex = 0;
            this.rightGuess3.Text = " ";
            this.rightGuess3.UseVisualStyleBackColor = true;

            this.Controls.Add(rightGuess3);

            this.rightGuess4.Location = new System.Drawing.Point(140, 20);
            this.rightGuess4.Name = "rightGuess4";
            this.rightGuess4.Size = new System.Drawing.Size(35, 35);
            this.rightGuess4.TabIndex = 0;
            this.rightGuess4.Text = " ";
            this.rightGuess4.UseVisualStyleBackColor = true;

            this.Controls.Add(rightGuess4);

            RightGuesses[0] = rightGuess1;
            RightGuesses[1] = rightGuess2;
            RightGuesses[2] = rightGuess3;
            RightGuesses[3] = rightGuess4;

            // Create first row of buttons
            int d = 0;
            for (int f = 0; f < 4; f++)
            {
                newButtonToColor guessButton0 = new newButtonToColor(0, d, Arr, f);
                guessButton0.Location = new System.Drawing.Point(20 + d, 80 + 0);
                guessButton0.Name = "guessButton";
                guessButton0.Size = new System.Drawing.Size(35, 35);
                guessButton0.TabIndex = 0;
                guessButton0.Text = " ";
                guessButton0.UseVisualStyleBackColor = false;
                Controls.Add(guessButton0);
                Arr[f] = guessButton0;
                d = d + 40;
            }

            d = 0;

            newArrowButton arrowButton0 = new newArrowButton(d, Arr, 4, m_amountOfGuesses, RightGuesses);
            arrowButton0.Enabled = false;
            arrowButton0.Location = new System.Drawing.Point(180, 80 + d + 9);
            arrowButton0.Name = "arrowButton";
            arrowButton0.Size = new System.Drawing.Size(35, 15);
            arrowButton0.TabIndex = 0;
            arrowButton0.Text = "--->";
            arrowButton0.UseVisualStyleBackColor = true;
            Controls.Add(arrowButton0);
            Arr[4] = arrowButton0;

            newCheckButton checkGuesses1_0 = new newCheckButton(d);
            checkGuesses1_0.Location = new System.Drawing.Point(220, 80 + d + 4);
            checkGuesses1_0.Name = "checkGuesses";
            checkGuesses1_0.Size = new System.Drawing.Size(10, 10);
            checkGuesses1_0.TabIndex = 0;
            checkGuesses1_0.Text = " ";
            checkGuesses1_0.UseVisualStyleBackColor = true;
            Controls.Add(checkGuesses1_0);

            newCheckButton checkGuesses2_0 = new newCheckButton(d);
            checkGuesses2_0.Location = new System.Drawing.Point(235, 80 + d + 4);
            checkGuesses2_0.Name = "checkGuesses";
            checkGuesses2_0.Size = new System.Drawing.Size(10, 10);
            checkGuesses2_0.TabIndex = 0;
            checkGuesses2_0.Text = " ";
            checkGuesses2_0.UseVisualStyleBackColor = true;
            Controls.Add(checkGuesses2_0);

            newCheckButton checkGuesses3_0 = new newCheckButton(d);
            checkGuesses3_0.Location = new System.Drawing.Point(220, 80 + d + 19);
            checkGuesses3_0.Name = "checkGuesses";
            checkGuesses3_0.Size = new System.Drawing.Size(10, 10);
            checkGuesses3_0.TabIndex = 0;
            checkGuesses3_0.Text = " ";
            checkGuesses3_0.UseVisualStyleBackColor = true;
            Controls.Add(checkGuesses3_0);

            newCheckButton checkGuesses4_0 = new newCheckButton(d);
            checkGuesses4_0.Location = new System.Drawing.Point(235, 80 + d + 19);
            checkGuesses4_0.Name = "checkGuesses";
            checkGuesses4_0.Size = new System.Drawing.Size(10, 10);
            checkGuesses4_0.TabIndex = 0;
            checkGuesses4_0.Text = " ";
            checkGuesses4_0.UseVisualStyleBackColor = true;
            Controls.Add(checkGuesses4_0);

            checkGuesses1_0.Enabled = false;
            checkGuesses2_0.Enabled = false;
            checkGuesses3_0.Enabled = false;
            checkGuesses4_0.Enabled = false;

            Arr[5] = checkGuesses1_0;
            Arr[6] = checkGuesses2_0;
            Arr[7] = checkGuesses3_0;
            Arr[8] = checkGuesses4_0;

            // Create other rows
            for (int i = 9, j = 40; i < m_amountOfGuesses * 9; i++, j = j + 40)
            {
                for (int k = 0, l = 0; k < 4; k++, l = l + 40)
                {
                    newButtonToColor guessButton = new newButtonToColor(j, l, Arr, i);
                    guessButton.Enabled = false;
                    guessButton.Location = new System.Drawing.Point(20 + l, 80 + j);
                    guessButton.Name = "guessButton";
                    guessButton.Size = new System.Drawing.Size(35, 35);
                    guessButton.TabIndex = 0;
                    guessButton.Text = " ";
                    guessButton.UseVisualStyleBackColor = false;
                    Controls.Add(guessButton);
                    Arr[i] = guessButton;
                    i++;
                }

                newArrowButton arrowButton = new newArrowButton(j, Arr, i, m_amountOfGuesses, RightGuesses);
                arrowButton.Enabled = false;
                arrowButton.Location = new System.Drawing.Point(180, 80 + j + 9);
                arrowButton.Name = "arrowButton";
                arrowButton.Size = new System.Drawing.Size(35, 15);
                arrowButton.TabIndex = 0;
                arrowButton.Text = "--->";
                arrowButton.UseVisualStyleBackColor = true;
                Controls.Add(arrowButton);
                Arr[i] = arrowButton;
                i++;

                newCheckButton checkGuesses1 = new newCheckButton(j);
                checkGuesses1.Enabled = false;
                checkGuesses1.Location = new System.Drawing.Point(220, 80 + j + 4);
                checkGuesses1.Name = "checkGuesses";
                checkGuesses1.Size = new System.Drawing.Size(10, 10);
                checkGuesses1.TabIndex = 0;
                checkGuesses1.Text = " ";
                checkGuesses1.UseVisualStyleBackColor = true;
                Controls.Add(checkGuesses1);

                newCheckButton checkGuesses2 = new newCheckButton(j);
                checkGuesses2.Enabled = false;
                checkGuesses2.Location = new System.Drawing.Point(235, 80 + j + 4);
                checkGuesses2.Name = "checkGuesses";
                checkGuesses2.Size = new System.Drawing.Size(10, 10);
                checkGuesses2.TabIndex = 0;
                checkGuesses2.Text = " ";
                checkGuesses2.UseVisualStyleBackColor = true;
                Controls.Add(checkGuesses2);

                newCheckButton checkGuesses3 = new newCheckButton(j);
                checkGuesses3.Enabled = false;
                checkGuesses3.Location = new System.Drawing.Point(220, 80 + j + 19);
                checkGuesses3.Name = "checkGuesses";
                checkGuesses3.Size = new System.Drawing.Size(10, 10);
                checkGuesses3.TabIndex = 0;
                checkGuesses3.Text = " ";
                checkGuesses3.UseVisualStyleBackColor = true;
                Controls.Add(checkGuesses3);

                newCheckButton checkGuesses4 = new newCheckButton(j);
                checkGuesses4.Enabled = false;
                checkGuesses4.Location = new System.Drawing.Point(235, 80 + j + 19);
                checkGuesses4.Name = "checkGuesses";
                checkGuesses4.Size = new System.Drawing.Size(10, 10);
                checkGuesses4.TabIndex = 0;
                checkGuesses4.Text = " ";
                checkGuesses4.UseVisualStyleBackColor = true;
                Controls.Add(checkGuesses4);

                checkGuesses1.Enabled = false;
                checkGuesses2.Enabled = false;
                checkGuesses3.Enabled = false;
                checkGuesses4.Enabled = false;

                Arr[i] = checkGuesses1;
                i++;
                Arr[i] = checkGuesses2;
                i++;
                Arr[i] = checkGuesses3;
                i++;
                Arr[i] = checkGuesses4;
            }
        }

        private void GameBoard_Load_1(object sender, EventArgs e)
        {
        }

        // $G$ CSS-016 (-5) Bad class name (Should be in the form of PascalCased. Also, no need for 'new' prefix)
        public class newButtonToColor : Button
        {
            // $G$ CSS-000 (-5) Meaningless variable name.
            private Button[] a;
            private int place;

            public newButtonToColor(int l, int j, Button[] arr, int i)
            {
                a = arr;
                place = i;
                this.Click += new System.EventHandler(guessButton_Click);
            }

            private void guessButton_Click(object sender, EventArgs e)
            {
                ColorForm colorForm = new ColorForm();
                colorForm.ShowDialog();
                this.BackColor = colorForm.SelectedColor;
                int row = place / 9;
                if ((a[(row * 9) + 3].BackColor != Control.DefaultBackColor) && (a[(row * 9) + 2].BackColor != Control.DefaultBackColor) && (a[(row * 9) + 1].BackColor != Control.DefaultBackColor) && (a[(row * 9)].BackColor != Control.DefaultBackColor))
                {
                    if (a[(row * 9) + 3].BackColor != a[(row * 9) + 2].BackColor && a[(row * 9) + 3].BackColor != a[(row * 9) + 1].BackColor && a[(row * 9) + 3].BackColor != a[(row * 9)].BackColor && a[(row * 9) + 2].BackColor != a[(row * 9) + 1].BackColor && a[(row * 9) + 2].BackColor != a[(row * 9)].BackColor && a[(row * 9) + 1].BackColor != a[(row * 9)].BackColor)
                    {
                        a[(row * 9) + 4].Enabled = true;
                    }
                    else
                    {
                        a[(row * 9) + 4].Enabled = false;
                    }
                }
            }
        }

        public class newArrowButton : Button
        {
            private Button[] a;
            private Button[] result;
            private int place;
            private int guesses;
            private bool o_win = false;

            public newArrowButton(int l, Button[] arr, int i, int m_amountOfGuesses, Button[] right)
            {
                a = arr;
                result = right;
                place = i;
                guesses = m_amountOfGuesses;
                this.Click += new System.EventHandler(this.arrowButton_Click);
            }

            private void arrowButton_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (place + i + 5 < guesses * 9)
                    {
                        a[place + i + 5].Enabled = true;
                    }

                    a[place - i - 1].Enabled = false;
                }

                string inputString = string.Empty;
                inputString += colorToLetter(place - 4) + " " + colorToLetter(place - 3) + " " + colorToLetter(place - 2) + " " + colorToLetter(place - 1);
                GameLogic.GameLogic.array<char> checkStateOfInput;
                checkStateOfInput = GameLogic.GameLogic.Logic.s_game(inputString, GameForms.Program.Target, out o_win);
                for (int c = 0; c < 4; c++)
                {
                    if (checkStateOfInput[c] == 'V')
                    {
                        a[place + c + 1].BackColor = Color.Black;
                    }
                    else if (checkStateOfInput[c] == 'X')
                    {
                        a[place + c + 1].BackColor = Color.Yellow;
                    }
                }

                if (o_win == true)
                {
                    for (int index = 0; index < 9 * guesses; index++)
                    {
                        a[index].Enabled = false;
                        a[index].TabStop = false;
                    }
                }

                if (o_win == true || place + 4 >= (guesses * 9))
                {
                    result[0].BackColor = a[place - 4].BackColor;
                    result[1].BackColor = a[place - 3].BackColor;
                    result[2].BackColor = a[place - 2].BackColor;
                    result[3].BackColor = a[place - 1].BackColor;
                }

                this.Enabled = false;
            }

            private char colorToLetter(int currentButton)
            {
                char letter;
                if (a[currentButton].BackColor == Color.Aquamarine)
                {
                    letter = 'A';
                }
                else if (a[currentButton].BackColor == Color.Tomato)
                {
                    letter = 'B';
                }
                else if (a[currentButton].BackColor == Color.Navy)
                {
                    letter = 'C';
                }
                else if (a[currentButton].BackColor == Color.YellowGreen)
                {
                    letter = 'D';
                }
                else if (a[currentButton].BackColor == Color.DarkRed)
                {
                    letter = 'E';
                }
                else if (a[currentButton].BackColor == Color.Lavender)
                {
                    letter = 'F';
                }
                else if (a[currentButton].BackColor == Color.NavajoWhite)
                {
                    letter = 'G';
                }
                else if (a[currentButton].BackColor == Color.DarkMagenta)
                {
                    letter = 'H';
                }
                else
                {
                    letter = 'x';
                }

                return letter;
            }
        }

        public class newCheckButton : Button
        {
            public newCheckButton(int j)
            {
                this.Click += new System.EventHandler(this.checkGuesses_Click);
            }

            private void checkGuesses_Click(object sender, EventArgs e)
            {
            }
        }
    }
}