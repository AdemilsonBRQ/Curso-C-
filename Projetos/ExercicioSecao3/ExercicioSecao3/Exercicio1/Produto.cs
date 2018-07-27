using System;
using System.Globalization;

namespace ExercicioSecao3.Exercicio1
{
    class Produto : IComparable
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + descricao
                + ", "
                + preco.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Produto prod = (Produto)obj;
            int result = descricao.CompareTo(prod.descricao);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return -preco.CompareTo(prod.preco);
            }

            throw new NotImplementedException();
        }
    }
}
