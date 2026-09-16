/* using System;
using firstProject;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 1:
            // Triangulo x, y;
            // x = new Triangulo();
            // y = new Triangulo();

            // Console.WriteLine("Entre com as medidas do triangulo x: ");
            // x.A = double.Parse(Console.ReadLine());
            // x.B = double.Parse(Console.ReadLine());
            // x.C = double.Parse(Console.ReadLine());

            // Console.WriteLine("Entre com as medidas do triangulo y: ");
            // y.A = double.Parse(Console.ReadLine());
            // y.B = double.Parse(Console.ReadLine());
            // y.C = double.Parse(Console.ReadLine());

            // double areaX = x.Area();
            // double areaY = y.Area();

            // Console.WriteLine("Area de X: " + areaX.ToString("F4"));
            // Console.WriteLine("Area de Y: " + areaY.ToString("F4"));

            // if (areaX > areaY)
            // {
            //     Console.WriteLine("Area de X é maior que area de Y");
            // }
            // else
            // {
            //     Console.WriteLine("Area de Y é maior que area de X");
            // }


            // ---------------------------------------------------------------------------------
            // EXERCÍCIO 2:
            // DataPersons p1, p2;
            // p1 = new DataPersons();
            // p2 = new DataPersons();

            // Console.WriteLine("Dados da primeira pessoa");
            // p1.Name = Console.ReadLine();
            // p1.Age = int.Parse(Console.ReadLine());

            // Console.WriteLine("Dados da segunda pessoa");
            // p2.Name = Console.ReadLine();
            // p2.Age = int.Parse(Console.ReadLine());

            // if (p1.Age > p2.Age)
            // {
            //     Console.WriteLine($"Pessoa mais velha: {p1.Name}");
            // }
            // else
            // {
            //     Console.WriteLine($"Pessoa mais velha: {p2.Name}");
            // }
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 3:
            // DataEmployeer f1, f2;
            // f1 = new DataEmployeer();
            // f2 = new DataEmployeer();

            // Console.WriteLine("Dados do primeiro funcionario");
            // f1.Name = Console.ReadLine();
            // f1.Salary = double.Parse(Console.ReadLine());

            // Console.WriteLine("Dados do segundo funcionario");
            // f2.Name = Console.ReadLine();
            // f2.Salary = double.Parse(Console.ReadLine());

            // double media = (f1.Salary + f2.Salary) / 2.0;
            // Console.WriteLine($"Salário médio = {media.ToString("F2")}");
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 4:
            // Product p = new Product();

            // Console.WriteLine("Entre os dados do produto");
            // Console.Write("Nome: ");
            // p.Name = Console.ReadLine();

            // Console.Write("Preço: ");
            // p.Price = double.Parse(Console.ReadLine());

            // Console.Write("Quantidade: ");
            // p.Quantity = int.Parse(Console.ReadLine());

            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine($"Dados do produto: {p}");
            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");
            // Console.WriteLine();

            // Console.Write("Digite o numero de produtos a ser adicionado: ");
            // int qte = int.Parse(Console.ReadLine());
            // p.AdicionarProdutos(qte);

            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine($"Dados atualizados: {p}");
            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");

            // Console.Write("Digite o numero de produtos a ser removido: ");
            // qte = int.Parse(Console.ReadLine());
            // p.RemoverProdutos(qte);

            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine($"Dados atualizados: {p}");
            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------");
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 5:
            // Retangulo r = new Retangulo();
            // Console.WriteLine("Entre com as medidas do retangulo: ");
            // r.Largura = double.Parse(Console.ReadLine());
            // r.Altura = double.Parse(Console.ReadLine());

            // double area, perimetro, diagonal;
            // area = r.Area();
            // perimetro = r.Perimetro();
            // diagonal = r.Diagonal();

            // Console.WriteLine($"AREA = {area:F2}");
            // Console.WriteLine($"PERIMETRO = {perimetro:F2}");
            // Console.WriteLine($"DIAGONAL = {diagonal:F2}");
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 6:
            // DadosFuncionario f = new DadosFuncionario();
            // Console.Write("Nome: ");
            // f.Name = Console.ReadLine();
            // Console.Write("Salário Bruto: ");
            // f.SalaryBrute = double.Parse(Console.ReadLine());
            // Console.Write("Imposto: ");
            // f.Tax = double.Parse(Console.ReadLine());

            // Console.WriteLine($"Funcionário: {f.Name}, ${f.SalaryLiquid()}");

            // Console.Write("Digite a porcentagem para aumentar o salário: ");
            // double percentage = double.Parse(Console.ReadLine());
            // f.IncrementSalary(percentage);

            // Console.WriteLine($"Dados atualizados: {f}");
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 7:
            // DataStudent s = new DataStudent();
            // Console.Write("Nome do aluno: ");
            // s.Name = Console.ReadLine();
            // Console.WriteLine("Digite as três notas do aluno:");
            // s.N1 = double.Parse(Console.ReadLine());
            // s.N2 = double.Parse(Console.ReadLine());
            // s.N3 = double.Parse(Console.ReadLine());

            // Console.WriteLine($"Nota Final = {s.Media():F2}");
            // Console.WriteLine($"{s.Status()}");
            // if (s.Media() < 60.00)
            // {
            //     Console.WriteLine($"Faltaram {s.NotaRestante():F2} pontos.");
            // }
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 8:
            // Console.Write("Entre o valor do raio: ");
            // double raio = double.Parse(Console.ReadLine());

            // double circ = CalculatorCircle.Circunferencia(raio);
            // double vol = CalculatorCircle.Volume(raio);

            // Console.WriteLine($"Circunferencia: {circ:F2}");
            // Console.WriteLine($"Volume: {vol:F2}");
            // Console.WriteLine($"Valor de Pi: {CalculatorCircle.Pi}");
            // ---------------------------------------------------------------------------------


            // EXERCÍCIO 9:
            // Console.Write("Qual é a cotação do dólar? ");
            // double cotacao = double.Parse(Console.ReadLine());
            // Console.Write("Quantos dólares você vai comprar? ");
            // double qte = double.Parse(Console.ReadLine());

            // double total = ConversorDeMoeda.Converter(cotacao, qte);
            // Console.WriteLine($"Valor a ser pago em reais = {total:F2}");
        }

    }
}
*/

using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
