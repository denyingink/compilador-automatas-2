using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validadores;

namespace appAvanceAutomatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAnalisisParentesis_Click(object sender, EventArgs e)
        {
            String codigo = textBox1.Text;
            Validadores.Validador validador = new Validadores.Validador();

            if (validador.validarParentesis(codigo))
            {
                lblAnalisisParentesis.Text = "Esta expresión contiene paréntesis correctamente :)";
            }
            else
            {
                lblAnalisisParentesis.Text = "Esta expresión contiene algunos errores en los paréntesis :(";
            }
        }

        private void btnAnalisisOpera_Click(object sender, EventArgs e)
        {
            String codigo = textBox1.Text;
            Validadores.Validador validador = new Validadores.Validador();

            if (validador.validarOperaciones(codigo))
            {
                lblAnalisisOpera.Text = "Esta expresión contiene sus operadores y operandos correctamente :)";
            }
            else
            {
                lblAnalisisOpera.Text = "Esta expresión contiene algunos errores en los operadores/operandos :(";
            }
        }
    }
}
