using System;
using System.Globalization;
using System.Collections.Generic;
namespace ExercicioSecao3.Exercicio1
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo,int dia,int mes,int ano)
        {
            this.codigo = codigo;
            this.data = new DateTime(ano, mes, dia);
            this.itens = new List<ItemPedido>();
        }

        public double calculoValorTotal()
        {
            double soma = 0.0;
            for(int cont = 0; cont < itens.Count; cont++)
            {
                soma = soma + itens[cont].calculaSubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            string msg = "Pedido "
                + codigo
                + ", data: "
                + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                + "Itens:\n";

            for(int cont = 0; cont < itens.Count; cont++)
            {
                msg = msg + itens[cont] + "\n";
            }

            msg = msg + "Total do Pedido: " + calculoValorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return msg;

        }
    }
}
