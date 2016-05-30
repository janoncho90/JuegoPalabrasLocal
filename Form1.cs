using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            List<string> palabras = new List<string>();//este es un arreglo dinamico

            string frase = txtFrase.Text;
            int cantidadPalabras = 0;

            string temporal = "";
            for(int i=0; i < frase.Length; i++)
            {
                char caracter = frase[i];
                if (caracter == ' ')
                {
                    palabras.Add(temporal);
                    temporal = "";
                    cantidadPalabras++;
                }
                else
                {
                    temporal += caracter;
                }
            }
            if (frase.Length > 0)
            {
                palabras.Add(temporal);
                cantidadPalabras++;
            }
            
            lblPizarra.Text = "Esta frase tiene " + cantidadPalabras + " palabras.\n";

            for (int i = 0; i < palabras.Count; i++)
            {
                lblPizarra.Text += "Palabra " + (i + 1) + ": " + palabras[i] + " tiene " + palabras[i].Length + " letras\n";
            }
        }
    }
}
