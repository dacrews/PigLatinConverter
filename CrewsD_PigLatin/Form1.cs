using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewsD_PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Assign the input 
            string inputSentence = sentenceTextbox.Text;

            // create the array of delimiters
            char[] delim = { ' ' , '.' };

            // tokenize and pull the tokens
            string[] tokens = inputSentence.Split(delim);

            string newWord;
            var outputMessage = "";

            // remove the first letter of each token
            foreach (string letters in tokens)
            {
                string firstLetter = letters.Substring(0, 1);
                string word = letters.Substring(1, letters.Length - 1);

                // add the first letter to the end of each token and also add "ay"
                newWord = word + firstLetter + "ay" + " ";

                outputMessage += newWord;

                //display new sentence
                convertedOutput.Text = outputMessage.ToString();
            }

        }

        private void sentenceLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
