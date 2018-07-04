using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameLogic;

namespace GameForms
{   
    public partial class NumberOfGuesses : Form
    {
        private const int k_MinGuesses = 4;
        // $G$ CSS-002 (-5) Bad member variable name (should be in the form of m_PascalCased)
        private Button startButton;
        private Button numberOfGuessesButton;
        private int numberOfGuessesFromUser = k_MinGuesses;

        public int getGuesses()
        {
            return numberOfGuessesFromUser;
        }

        public NumberOfGuesses()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;   
        }

        private void numberOfGuessesButton_Click(object sender, EventArgs e)
        {
            this.numberOfGuessesFromUser = GameLogic.GameLogic.inputsAndOutputs.s_amountOfGuessesUserWants(numberOfGuessesFromUser);
            this.numberOfGuessesButton.Text = string.Format(@"Number of guesses: {0}", numberOfGuessesFromUser);
        }

        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.numberOfGuessesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // startButton
            this.startButton.Location = new System.Drawing.Point(68, 52);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // numberOfGuessesButton
            this.numberOfGuessesButton.Location = new System.Drawing.Point(68, 12);
            this.numberOfGuessesButton.Name = "numberOfGuessesButton";
            this.numberOfGuessesButton.Size = new System.Drawing.Size(166, 23);
            this.numberOfGuessesButton.TabIndex = 0;
            this.numberOfGuessesButton.Text = "Number of guesses: 4";
            this.numberOfGuessesButton.UseVisualStyleBackColor = true;
            this.numberOfGuessesButton.Click += new System.EventHandler(this.numberOfGuessesButton_Click);

            // NumberOfGuesses
            this.AcceptButton = this.startButton;
            this.ClientSize = new System.Drawing.Size(298, 104);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberOfGuessesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberOfGuesses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
