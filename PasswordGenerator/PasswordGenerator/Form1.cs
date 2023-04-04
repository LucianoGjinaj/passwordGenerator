using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 8;
        Random character = new Random();

        private void passwordGenerator(int passwordLength)
        {
            String allCharacter = "";
            String randompassword = "";

            if (includeUpperCase.Checked)
            {
                allCharacter += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (includeLowerCase.Checked)
            {
                allCharacter += "abcdefghijklmnopqrstuvwxyz";
            }

            if (includeNumber.Checked)
            {
                allCharacter += "1234567890";
            }

            if (inludeSymbol.Checked)
            {
                allCharacter += "~!`!@#$%^&*()_+-=<>?,.";
            }

            for (int i=0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacter.Length);
                randompassword += allCharacter[randomNum];
            }

            passwordLabel.Text = randompassword;
        }
        public Form1()
        {
            InitializeComponent();
            passwordLengthSlider.Minimum = 8;
            passwordLengthSlider.Maximum = 36;
            
        }

        private void passwordLengthSlider_Scroll(object sender, EventArgs e)
        {
            passwordLengthLabel.Text = "Password Length: " + passwordLengthSlider.Value.ToString();

            currentPasswordLength = passwordLengthSlider.Value;

        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            if (inludeSymbol.Checked | includeUpperCase.Checked | includeLowerCase.Checked | includeNumber.Checked)
            {
                passwordGenerator(currentPasswordLength);
            }
            else
            {
                MessageBox.Show("Please selecet to include something in password");
            }
        }
    }
}
