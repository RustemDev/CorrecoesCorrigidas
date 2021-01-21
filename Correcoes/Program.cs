using System;
using System.Collections.Generic;
using Correcoes.Bibliotecas;

namespace Correcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "" ;

            List<Cliente> meusClientes = new List<Cliente>();

            for (int i = 0; i < 5; i++)
            {
                Cliente meuCli = new Cliente();

                Console.WriteLine("esse cliente é vip? digite s para sim e n para não");
                opcao = Console.ReadLine();

                if (opcao == "s")
                {
                    meuCli.EhVip = true;
                }
                else if (opcao == "n")
                {
                    meuCli.EhVip = false;
                }

                meusClientes.Add(meuCli);
            }


            for (int i = 0; i < meusClientes.Count; i++)
            {
                Console.WriteLine("esse cliente vip : " + meusClientes[i].EhVip);
            }


            //Variaveis criadas para receber os valores padroes e podem ser alteradas a qualquer momento
            int posicaoProdutoEscolhido = 0;
            double saldoInicialCLiente = 0;
            int senha = 0;
            int continuar = 1;
            string nome = "";

            List<Cliente> clientesVip = new List<Cliente>();


            //Criar um produto e dentro dele estaram as variavveis
            Cliente cli = new Cliente();

            //Console.WriteLine é usado para visualização do texto no console
            Console.WriteLine("Bem Vindo a padaria do Geraldo!");
            Console.WriteLine(" ");
            Console.WriteLine("Favor colocar nome idade e senha para efetuarmos seu cadastro ");
            Console.WriteLine(" ");

            //Console.ReadLine é usado para receber o que o usuario vai digitar
            Console.WriteLine("Para começarmos informe o seu nome");
            cli.Nome = Console.ReadLine();

            Console.WriteLine("Agora informe a sua senha");
            cli.Senha = Convert.ToInt32(Console.ReadLine());

            //Convert.ToInt32 é usado para converter, o que vem como string ele converte para inteiro
            Console.WriteLine("Agora informe a sua idade");
            cli.Idade = Convert.ToInt32(Console.ReadLine());

            //Convert.ToDouble é usado para numeros quebrados, geralmente em programas que usam dinheiro
            Console.WriteLine("Agora informe o seu saldo");
            cli.Saldo = Convert.ToDouble(Console.ReadLine());
            saldoInicialCLiente = cli.Saldo;


            Console.WriteLine(" ");


            Console.WriteLine("Favor inserir nome para logar ");
            nome = Console.ReadLine();
            Console.WriteLine("Favor inserir senha ");
            senha = Convert.ToInt32(Console.ReadLine());



            if (cli.Nome == nome && cli.Senha == 123)
            {
                Console.WriteLine("Parabéns você é nosso cliente VIP e está logado ");
                cli.EhVip = true;
            }
            else if (cli.Nome != nome && cli.Senha != 123)
            {
                Console.WriteLine("Nome ou senha invalido ");
            }




            // A lista serve tanto para armazenar diversas variaveis quanto para ser exibida com um For
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto { NomeProduto = "Pão francês", ValorProduto = 0.78 });
            produtos.Add(new Produto { NomeProduto = "Peito de peru", ValorProduto = 7.48 });
            produtos.Add(new Produto { NomeProduto = "Pão de Queijo", ValorProduto = 12 });
            produtos.Add(new Produto { NomeProduto = "Cigarro", ValorProduto = 21 });
            produtos.Add(new Produto { NomeProduto = "Coxinha", ValorProduto = 5.41 });
            produtos.Add(new Produto { NomeProduto = "Bauru", ValorProduto = 2.87 });
            produtos.Add(new Produto { NomeProduto = "Pingado", ValorProduto = 1.78 });


            // o While é como um For mas ele irá continuar o lupi infinitamente enquanto a condição for verdadeira
            while (continuar == 1)
            {

                Console.WriteLine("Digite o número da opção que quer comprar");


                //o for vai operar como o while mas ele vai ler a quantidade que vc vai colocar na sua formula e só vai parar quando terminar todas as opções e vai exibir na tela
                for (int W = 0; W < produtos.Count; W++)
                {
                    Console.WriteLine("posição " + W + " " + produtos[W].NomeProduto + " " + "valor: " + produtos[W].ValorProduto);
                }

                posicaoProdutoEscolhido = Convert.ToInt32(Console.ReadLine());


                //Se o produto escolhido pelo usuario tiver o valor
                if (produtos[posicaoProdutoEscolhido].ValorProduto > cli.Saldo)
                {
                    Console.WriteLine("Você não tem dinheiro para comprar esse produto");
                }
                //Se a variavel produtoEscolhido (==)receber 3 e cli.Idade for maior que 18 anos o cliente  pode comprar com sucesso
                else if (posicaoProdutoEscolhido == 3 && cli.Idade >= 18)
                {
                    cli.Comprar(produtos[posicaoProdutoEscolhido].ValorProduto);
                    Console.WriteLine("Produto comprado com sucesso");

                }
                //Se a variavel produtoEscolhido (==)receber 3 e cli.Idade for menor que 18 anos o cliente não pode comprar
                else if (posicaoProdutoEscolhido == 3 && cli.Idade < 18)
                {
                    Console.WriteLine("Você não tem idade para comprar cigarros");
                }
                
                
                    
            






                else
                {   //Aqui cli.Saldo vai receber a conta, produto com a sua posição e o seu valor menos o saldo do cli(uma conta de menos)
                    Console.WriteLine("Produto comprado com sucesso");
                    cli.Saldo = cli.Saldo - produtos[posicaoProdutoEscolhido].ValorProduto;
                }
                //Aqui se o cli.Saldo for menor ou igual a zero então ele fara o q está dentro da chave
                if (cli.Saldo <= 0)
                {
                    Console.WriteLine("Você não tem saldo suficiente para comprar");
                    break;
                }
                // Aqui mostra a concatenação de frases com o saldo restante
                Console.WriteLine("seu saldo atual é " + cli.Saldo + " digite 1 para continuar comprando ou 0 para finalizar");
                continuar = Convert.ToInt32(Console.ReadLine());

                //Aqui o While vai continuar se o numero digitado for diferente de um e zero, mostrando a mensagem para o usuario
                while (continuar != 1 && continuar != 0)
                {
                    Console.WriteLine("Opção invalida, por favor digite 1 para continuar ou 0 para sair");
                    continuar = Convert.ToInt32(Console.ReadLine());
                }


            }

            //Aqui vai mostrar na tela a frase e concatenar com o saldo restante do cliente
            Console.WriteLine("Obrigado por comprar conosco, voce gastou um total de " + (saldoInicialCLiente - cli.Saldo) + " volte sempre  :) ");


            Console.ReadLine();


            // Console.WriteLine("Informe uma das opções válidas");
            //Console.WriteLine("digite 1 para continuar comprando ou 0 para finalizar");
            //continuar = Convert.ToInt32(Console.ReadLine());



        }
    }
}
