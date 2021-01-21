using System;
using System.Collections.Generic;
using System.Text;

namespace Correcoes.Bibliotecas
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Senha { get; set; }
        public double Saldo { get; set; }
        public bool EhVip { get; set; }
        public string CompraVIP(Cliente cli, double valorProduto)
        {
            double resultado = cli.Saldo - (valorProduto - 2);

            cli.Saldo = resultado;

            return (cli.Nome + " Vc ganhou um desconto de " + resultado + "por ser VIP");


        }
        public void Comprar(double valorCompra)
        {
            Saldo = Saldo + valorCompra;
        }
    }
}
