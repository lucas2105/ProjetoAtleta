using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double resultado;

            try
            {
                obj.nome = txt_nome.Text;
                obj.altura = double.Parse(txt_altura.Text);
                obj.peso = double.Parse(txt_peso.Text);
                obj.idade = int.Parse(txt_idade.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                resultado = double.Parse(obj.CalcularIMC().ToString("0.00"));
                MessageBox.Show("O IMC do atleta " + obj.nome + " de " + obj.idade + " anos é " + resultado);
            }
            ////git
        }
    }
}
