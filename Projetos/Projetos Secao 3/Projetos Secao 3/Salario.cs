using System;
using System.Globalization;

namespace Projetos_Secao_3
{
    class Salario
    {
        public double numCPF { get; private set; }
        public string nomeFuncionario { get; set; }
        public double salarioFuncionario { get; set; }

        public Salario(double numCPF, string nome, double salario)
        {
            this.numCPF = numCPF;
            this.nomeFuncionario = nome;
            this.salarioFuncionario = salario;
        }
        public void atualizaSalario(double percentual)
        {
            this.salarioFuncionario = this.salarioFuncionario + this.salarioFuncionario / 100 * percentual;
        }

        public override string ToString()
        {
            return this.numCPF + ", " + this.nomeFuncionario + ", " + this.salarioFuncionario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
