using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        private int _userInput = 0;
        int operationResult = 0;
        string operationType = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) throw new Exception("Operazione_click deve essere associato ad un bottone!");
            lblRisultato.Text += btn.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {

            // Associate pressed button to a var
            var btn = sender as Button;
            if (btn == null) throw new Exception("Operazione_click deve essere associato ad un bottone!");


            string prova = lblRisultato.Text.Replace(_userInput + " " + btn.Text + " ", "");

            // Convert label text into integer numbers
            bool parseResult = int.TryParse(prova, out int userInput);
            if (!parseResult) throw new Exception("Not a valid input");

            if (userInput != _userInput)
            {
                _userInput = userInput;
            }

            if (btn.Text == "+" || btn.Text != "-" || btn.Text == "x" || btn.Text == ":")
            {
                switch (btn.Text)
                {
                    case "+":
                        lblOperazione.Text += lblRisultato.Text + " + ";
                        lblRisultato.Text = "";
                        operationResult = _userInput + userInput;
                        operationType = "+";
                        break;

                    case "-":
                        lblOperazione.Text += lblRisultato.Text + " - ";
                        lblRisultato.Text = "";
                        operationResult = _userInput - userInput;
                        operationType = "-";
                        break;

                    case "x":
                        lblOperazione.Text += lblRisultato.Text + " x ";
                        lblRisultato.Text = "";
                        operationResult = _userInput * userInput;
                        operationType = "x";
                        break;

                    case ":":
                        lblOperazione.Text += lblRisultato.Text + " : ";
                        lblRisultato.Text = "";
                        operationResult = _userInput / userInput;
                        operationType = ":";
                        break;
                }
            }

            else
            {
                MessageBox.Show("Not a valid option");
            }

        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (lblRisultato.Text != string.Empty)
            {
                if (!int.TryParse(lblRisultato.Text, out temp)) throw new ArgumentException("valore immesso non valido");
            }

            lblOperazione.Text += temp + " = ";

            int risultato = 0;
            switch (operationType)
            {

                case "+":
                    risultato = _userInput + temp;
                    break;
                case "-":
                    risultato = _userInput - temp;
                    break;
                case "x":
                    risultato = _userInput * temp;
                    break;
                case ":":
                    risultato = _userInput / temp;
                    break;

            }

            lblRisultato.Text = risultato.ToString();

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = "";
            lblOperazione.Text = "";
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            string operationString = lblOperazione.Text;
            string resultString = lblRisultato.Text;
            string modifiedOperation = "";

            if (resultString == string.Empty)
            {
                foreach (var c in operationString)
                {
                    modifiedOperation = operationString.Remove(operationString.Length - 1);
                    lblOperazione.Text = modifiedOperation;
                }
            }
            else
            {
                foreach(var c in resultString)
                modifiedOperation = resultString.Remove(resultString.Length - 1);
                lblRisultato.Text = modifiedOperation;
            }
            
        }
    }
}