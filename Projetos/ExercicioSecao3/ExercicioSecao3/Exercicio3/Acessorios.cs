using System.Globalization;

namespace ExercicioSecao3.Exercicio3
{
    class Acessorios
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Acessorios(string nome,double preco)
        {
            this.nome = nome;
            this.preco = preco;

        }

        public override string ToString()
        {
            return nome
                + ", Preço: "
                + preco.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
