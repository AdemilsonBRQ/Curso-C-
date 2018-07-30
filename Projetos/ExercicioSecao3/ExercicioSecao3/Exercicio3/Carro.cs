using System.Collections.Generic;
using System.Globalization;
using System;

namespace ExercicioSecao3.Exercicio3
{
    class Carro : IComparable
    {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorios> itens { get; set; }
        public Carro(int codigo,string modelo, int ano, double precoBasico,Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            this.itens = new List<Acessorios>();
        }

        public double subTotal()
        {
            double soma = 0.0;
            for(int cont = 0; cont < itens.Count; cont++)
            {
                soma = soma + itens[cont].preco;
            }
            return precoBasico + soma;
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + modelo
                + ", Ano: "
                + ano
                + ", Preço Básico: "
                + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço Total: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Carro car = (Carro)obj;
            int result = modelo.CompareTo(car.modelo);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return -subTotal().CompareTo(car.subTotal());
            }
            throw new NotImplementedException();
        }
    }
}
