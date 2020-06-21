using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioSimix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxbTitulo.Text = "Ao clicar no botão \"Enviar\" será gerada uma lista de 1 a 200, sendo que:" + Environment.NewLine +
                "\tSe o número for divisível por 3 será substituidos por \"X\";" + Environment.NewLine +
                "\tSe for divisível por 5 será substituido por \"Y\"" + Environment.NewLine +
                "\tSe for divisível por 3 e 5 simultaneamente será substituido por \"Z\";" + Environment.NewLine +
                "\tCaso contrario será apresentado o número mesmo.";
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            int countZ = 0;
            int countY = 0;
            int countX = 0;

            for (int num = 1; num <= 200; num++)
            {
                if (num % 15 == 0)
                {
                    countZ++;
                    TxbResult.Text += "Z" + Environment.NewLine;
                }
                else if (num % 5 == 0) 
                {
                    countY++;
                    TxbResult.Text += "Y" + Environment.NewLine;
                }
                else if (num % 3 == 0)
                {
                    countX++;
                    TxbResult.Text += "X" + Environment.NewLine;
                }
                else
                {
                    TxbResult.Text += num + Environment.NewLine; 
                }
            }

            LblFeedback.Text = "Total: X: " + countX + " - Y: " + countY + " - Z: " + countZ;
        }
    }
}
