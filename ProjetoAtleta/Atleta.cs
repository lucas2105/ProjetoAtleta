using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string Nome;
        private double Altura;
        private double Peso;
        private int Idade;

        public string nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.Nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.Nome; }
        }

        public double altura
        {
            set
            {
                if (value > 0)
                {
                    this.Altura = value;
                }
                else
                {
                    throw new Exception("A altura deve ser positiva!");
                }
            }
            get { return this.Altura; }
        }

        public double peso
        {
            set
            {
                if (value > 0)
                {
                    this.Peso = value;
                }
                else
                {
                    throw new Exception("O peso deve ser positiva!");
                }
            }
            get { return this.Peso; }
        }

        public int idade
        {
            set
            {
                if (value > 0)
                {
                    this.Idade = value;
                }
                else
                {
                    throw new Exception("A idade deve ser positiva!");
                }
            }
            get { return this.Idade; }
        }



        public double CalcularIMC()
        {
            return (Peso / (Altura * Altura)) * 100;
        }

    }
}
