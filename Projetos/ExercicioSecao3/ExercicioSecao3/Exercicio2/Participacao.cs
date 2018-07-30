using System.Globalization;

namespace ExercicioSecao3.Exercicio2
{
    class Participacao
    {
        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desconto, Artista art, Filme fil)
        {
            this.desconto = desconto;
            this.artista = art;
            this.filme = fil;

        }
        public double custo()
        {
            return artista.valor - desconto;
        }

        public override string ToString()
        {
            return artista.nome
                + ", Cachê: "
                + artista.valor.ToString("F2",CultureInfo.InvariantCulture)
                + ", Desconto: "
                + desconto.ToString("F2",CultureInfo.InvariantCulture)
                + ", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
