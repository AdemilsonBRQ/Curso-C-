using System.Collections.Generic;

namespace ExercicioSecao3.Exercicio3
{
    class Marca
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> itens { get; set; }

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            this.itens = new List<Carro>();
        }

        public Marca(int codigo, string nome, string pais,List<Carro> lstCarro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            this.itens = lstCarro;
        }

        public void addCarro(Carro car)
        {
            itens.Add(car);
            itens.Sort();
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                + ", País: "
                + pais
                + ", Número de carros: "
                + itens.Count;
        }

    }
}
