using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recorder
{
    


    public partial class Form1 : Form
    {
        private string encodingKey = "cdefghijklmnopqrstuvwxyzab";
        public Form1()
        {
            InitializeComponent();
            InputTextBox.TextChanged += InputTextBox_TextChanged;
        }
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            // Automatically encode when the text in the TextBox changes
            string inputText = InputTextBox.Text.ToLower();
            string encodedText = EncodeMessage(inputText);
            OutputLabel.Text = $"Encoded: {encodedText}";
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text.ToLower();
            string decodedText = DecodeMessage(inputText);
            OutputLabel.Text = $"Decoded: {decodedText}";
        }

        private string EncodeMessage(string input)
        {
            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.IsLetter(inputArray[i]))
                {
                    int index = inputArray[i] - 'a';
                    if (index >= 0 && index < encodingKey.Length)
                    {
                        inputArray[i] = encodingKey[index];
                    }
                }
            }

            return new string(inputArray);
        }

        private string DecodeMessage(string input)
        {
            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.IsLetter(inputArray[i]))
                {
                    int index = encodingKey.IndexOf(inputArray[i]);
                    if (index >= 0 && index < encodingKey.Length)
                    {
                        inputArray[i] = (char)('a' + index);
                    }
                }
            }

            return new string(inputArray);
        }
    }
}


