using System;
using System.Globalization;

namespace ExercicioSecao3.Exercicio2
{
    class Artista:IComparable
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }

        public Artista(int codigo,string nome,double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.valor = valor;
        }
        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                +", "
                +valor.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Artista art = (Artista)(obj);
            int result = nome.CompareTo(art.nome);
            if (result != 0)
            {
                return result;
            }
            
            throw new NotImplementedException();
        }
    }
}
