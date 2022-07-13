using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banco
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }

        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Nome = nome;
            this.Credito = credito;
        }
        public bool Sacar(double valorsaque)
        {
            //validação do saldo suficiente
            if (this.Saldo - valorsaque < (this.Saldo * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorsaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar (valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta" + this.TipoConta + " | ";
            retorno += "Nome" + this.Nome + " | ";
            retorno += "Saldo" + this.Saldo + " | ";
            retorno += "Credito" + this.Credito + " | ";
            return  retorno;
        }
    }
}
