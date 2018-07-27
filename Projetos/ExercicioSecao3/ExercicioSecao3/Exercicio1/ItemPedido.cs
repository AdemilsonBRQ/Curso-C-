using System.Globalization;

namespace ExercicioSecao3.Exercicio1
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagem, Pedido pedido,Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagem;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double calculaSubTotal()
        {
            double desconto = produto.preco * porcentagemDesconto / 100;
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.descricao
                + ", Preço: "
                + produto.preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", Qtde: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + calculaSubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
