using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSecao2
{
    class Aluno
    {
        public string nomeAluno;
        public double nota1, nota2, nota3;

        public double somaNota()
        {
            return nota1 + nota2 + nota3;
        }
        public string Avaliacao()
        {
            double soma,saldo;

            soma = nota1 + nota2 + nota3;
            if(soma>=60)
            {
                return "APROVADO";
            }
            else
            {
                saldo = 60 - soma;
                return "REPROVADO " + Environment.NewLine + "FALTARAM " +  saldo + " PONTOS.";
            }
        }
        public override string ToString()
        {

            return "NOTA FINAL = " + somaNota() + Environment.NewLine + Avaliacao();
        }
    }
}
