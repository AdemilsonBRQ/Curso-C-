using System.Collections.Generic;
using System.Globalization;

namespace ExercicioSecao3.Exercicio2
{
    class Filme
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> itens {get;set;}

        public Filme (int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.itens = new List<Participacao>();
        }

        public double custoTotal()
        {
            double soma = 0.0;
            for(int cont=0; cont < itens.Count; cont++)
            {
                soma = soma  +(itens[cont].artista.valor -  itens[cont].desconto);
            }
            return soma;
        }

        public override string ToString()
        {
            string msg =  "Filme "
                + codigo
                + ", Título "
                + titulo
                + ", Ano "
                + ano
                + "\nParticipações: ";

            for (int cont =0;cont<itens.Count;cont++)
            {
                msg = msg + itens[cont] + "\n";

            }
            msg = msg + "Custo total do filme: " + custoTotal().ToString("F2",CultureInfo.InvariantCulture);
            return msg;
        }
    }
}
