using System.Globalization;

namespace Projetos_Secao_3
{
    class DadosConta
    {
        public double numConta { get; private set; }
        public string nomeCliente { get; set; }
        public double saldoConta { get; private set; }

        public DadosConta(double numConta,string nomeCliente,double saldoConta)
        {
            this.numConta = numConta;
            this.nomeCliente = nomeCliente;
            this.saldoConta = saldoConta;
        }

        public DadosConta(double numConta, string nomeCliente)
        {
            this.numConta = numConta;
            this.nomeCliente = nomeCliente;
            this.saldoConta = 0;
        }

        public void Deposito(double vlrDeposito)
        {
            this.saldoConta = this.saldoConta + vlrDeposito;
        }

        public void Saque(double vlrSaque)
        {
            this.saldoConta = this.saldoConta - vlrSaque - 5;
        }

        public override string ToString()
        {
            return "Conta: " + this.numConta + 
                ", Titular: " + this.nomeCliente + 
                ", Saldo: $ " + this.saldoConta.ToString("F2",CultureInfo.InvariantCulture) ;
        }


    }
}
