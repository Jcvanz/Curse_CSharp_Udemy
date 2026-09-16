using System;

namespace POO
{
    class Program
    {
        // EXERCÍCIO 1:
        /* 
            static void Main(string[] args)
            {
                Console.WriteLine("Entre os dados do produto");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                
                // instanciando um objeto do tipo Produto
                // usando o Construtor Padrão
                Produto p = new Produto(nome, preco, quantidade);

                // instanciando um objeto do tipo Produto 
                // usando Sobrecarga de construtor
                // por padrão ele inicia com a quantidade 0
                Produto p2 = new Produto(nome, preco);

                // instanciando um objeto do tipo Produto
                // usando Atributos Padrão (Pattern Matching)
                // os valores dos atributos são passados na criação do objeto
                Produto p3 = new Produto 
                {
                    Name = "TV",
                    Price = 500.00,
                    Quantity = 5
                };

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Dados do produto: {p}");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();

                Console.Write("Digite o numero de produtos a ser adicionado: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {p}");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");

                Console.Write("Digite o numero de produtos a ser removido: ");
                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {p}");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");

                // -----------------------------------------------------------------------------------
                / *  
                    - Getters and Setters -

                    Note que ao criar o objeto, os atributos são private
                    e não podem ser acessados diretamente
                    E se tentarmos acessar os atributos privados diretamente
                    O C# vai dar erro
                    p.Name = "TV"; - Isso vai dar erro
                    p.Price = 1000.00; - Isso vai dar erro
                    p.Quantity = 10; - Isso vai dar erro

                    mas com os métodos Get e Set podemos acessar os atributos privados
                    e alterar os atributos privados
                * /
                Produto p4 = new Produto("TV", 1000.00, 10);

                // acessando os atributos privados
                Console.WriteLine(p4.GetName());
                Console.WriteLine(p4.GetPrice());
                Console.WriteLine(p4.GetQuantity());

                // alterando os atributos privados
                p4.SetName("Notebook");
                p4.SetPrice(2000.00);
                p4.SetQuantity(20);

                Console.WriteLine(p4.GetName());
                Console.WriteLine(p4.GetPrice());
                Console.WriteLine(p.GetQuantity());
            }
        */

        // EXERCÍCIO 2:
        /*
            static void Main(string[] args)
            {
                Bank bank;

                Console.Write("Digite o número da conta: ");
                int numAccount = int.Parse(Console.ReadLine());

                Console.Write("Digite o titular da conta: ");
                string nameAccount = Console.ReadLine();

                Console.Write("Haverá depósito inicial? (s/n): ");
                char initialDeposit = char.Parse(Console.ReadLine().ToLower());

                if (initialDeposit == 's')
                {
                    Console.Write("Digite o valor de depósito inicial: ");
                    double initialValue = double.Parse(Console.ReadLine());
                    bank = new Bank(nameAccount, numAccount, initialValue);
                }
                else
                {
                    bank = new Bank(nameAccount, numAccount);
                }

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(bank);

                Console.WriteLine();
                Console.Write("Digite um valor de depósito: ");
                bank.Deposit(double.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(bank);
                
                Console.WriteLine();
                Console.Write("Digite um valor de saque: ");
                bank.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(bank);
            }
        */

        /* 
            static void Main(string[] args) {
                // Executando Structs
                // Declaração sem inicialização - Padrão
                Point p;
                p.X = 10;
                p.Y = 20;

                Console.WriteLine(p);

                // Inicialização sem construtor padrão
                // Note que os atributos são zerados
                p = new Point();
                Console.WriteLine(p);

                // Declaração com inicialização - Usando Pattern Matching
                Point p2 = new Point();
                Console.WriteLine(p2);
            }
        */

        static void Main(string[] args) {
            
        }
    }
}
