using System;
using System.Globalization;
using System.Collections.Generic;

namespace CSharp_Completo_Udemy {
    class Program {
        static void Main(string[] args) {
            // VETORES
            // Um vetor é uma coleção de elementos do mesmo tipo
            // os índices são baseados em 0
            // os índices são contínuos
            // os índices não podem ser negativos
            // os índices não podem ser maiores que o tamanho do vetor
            /*
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }
            double soma = 0.0;
            for(int i = 0; i > 0; i++) {
                soma += vect[i].Price;
            }
            double avg = soma / n;
            Console.WriteLine($"AVERAGE PRICE = {avg:F2}");
            */
            
            // -------------------------------------------------------------------------

            // MODIFICADOR DE PARÂMETROS (PARAMS)
            // Permite que uma função receba um número variável de parâmetros
            // É usado para passar vários valores para uma função
            // Pode ser usado com tipos primitivos e objetos

            /*
            // sem params seria assim:
            int s1 = Calculator.Sum(new int[] { 10, 20, 30, 40, 50 });

            // com params:
            int s1 = Calculator.Sum(10, 20, 30, 40, 50);
            int s2 = Calculator.Sum(10, 20, 30);
            int s3 = Calculator.Sum(10, 20);
            int s4 = Calculator.Sum();

            Console.WriteLine($"S1: {s1}");
            Console.WriteLine($"S2: {s2}");
            Console.WriteLine($"S3: {s3}");
            Console.WriteLine($"S4: {s4}");
            */

            // -------------------------------------------------------------------------

            // MODIFICADOR DE PARÂMETROS (REF E OUT)
            // Ref: Passa uma variável por referência, ou seja, a função recebe a variável original
            // mas a variável original deve ser inicializada antes de ser passada.

            /*
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */

            // Out: Passa uma variável por referência, mas não precisa ser inicializada
            // mas a variável original não é modificada (na verdade ela não é passada, 
            // só a variável local dentro da função é modificada)  
            // outra coisa interessante, é que na declaração da variável eu passo a palavra "out"
            // na chamada da função também passo a palavra "out"

            /*
            int b = 10;
            int triple;
            Calculator.Triple2(b, out triple);
            Console.WriteLine(triple);
            */

            // -------------------------------------------------------------------------

            // FOREACH
            // O foreach é usado para percorrer todos os elementos de uma coleção
            // É mais simples que o for, pois não precisa declarar variável de controle
            
            /*
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            foreach (string name in vect) {
                Console.WriteLine(name);
            }
            */

            // -------------------------------------------------------------------------

            // LISTA (LIST)
            // Ela é homogênea, ou seja, só pode conter elementos do mesmo tipo
            // Mas ao contrário do vetor, ela é dinâmica, ou seja, pode adicionar e remover elementos
            // é a forma mais usada em c# para criar coleções
            // por baixo dos panos, a lista é um vetor, mas quando ele fica cheio, 
            // ele cria um vetor maior e copia os elementos para ele (duplica o tamanho)
            // por exemplo: se eu tiver uma lista com 4 elementos, e adicionar mais um,
            // ele cria um vetor de tamanho 8 e copia os elementos para ele

            /* 
            // declarando uma lista vazia
            List<string> list = new List<string>();
            // declarando uma lista com elementos
            List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };
            
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(0, "Alex");
            list.Remove("Alex");
            list.RemoveAt(0);
            list.RemoveRange(0, 2);
            list.RemoveAll(x => x.Length >= 5);
            
            foreach (string name in list) {
                Console.WriteLine(name);
            }

            // Count é uma propriedade que retorna o número de elementos da lista
            Console.WriteLine("Tamanho da lista: " + list.Count);

            // Find é um método que retorna o primeiro elemento que satisfaz a condição
            // se não encontrar, retorna null
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com A: " + s1);

            // FindAll é um método que retorna todos os elementos que satisfazem a condição
            // se não encontrar, retorna null
            List<string> s2 = list.FindAll(x => x[0] == 'A');
            Console.WriteLine("Todos os elementos que começam com A: " + s2);

            // FindLast é um método que retorna o último elemento que satisfaz a condição
            // se não encontrar, retorna null
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com A: " + s3);

            // FindIndex é um método que retorna o índice do primeiro elemento que satisfaz a condição
            // se não encontrar, retorna -1
            int s4 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Índice do primeiro elemento que começa com A: " + s4);

            // FindLastIndex é um método que retorna o índice do último elemento que satisfaz a condição
            // se não encontrar, retorna -1
            int s5 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Índice do último elemento que começa com A: " + s5);
            */

            // -------------------------------------------------------------------------

            // MATRIZES
            // Matriz é um vetor de vetores
            // a declaration é feita assim: type[,] name = new type[rows, columns];
            // a matrix é indexada por [row, column]
            // os índices são baseados em 0
            // os índices são contínuos
            // os índices não podem ser negativos
            // os índices não podem ser maiores que o tamanho da matriz

            /*
            int [,] mat = new int[2, 3];
            mat[0, 0] = 1;
            mat[0, 1] = 2;
            mat[0, 2] = 3;
            mat[1, 0] = 4;
            mat[1, 1] = 5;
            mat[1, 2] = 6;
            
            for(int i = 0; i < 2; i++) {
                for(int j = 0; j < 3; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            // EXERCÍCIO:
            // int n = int.Parse(Console.ReadLine());
            // int[,] mat = new int[n, n];

            // for (int i = 0; i < n; i++) {
            //     string[] values = Console.ReadLine().Split(' ');
                
            //     for (int j = 0; j < n; j++) {
            //         mat[i, j] = int.Parse(values[j]);
            //     }
            // }

            // Console.WriteLine("Main diagonal");
            // for (int i = 0; i < n; i++) {
            //     Console.Write(mat[i, i] + " ");
            // }
            // Console.WriteLine();

            // int count = 0;
            // for (int i = 0; i < n; i++) {
            //     for (int j = 0; j < n; j++) {
            //         if (mat[i,j] < 0) {
            //             count++;
            //         }
            //     }
            // }
            // Console.WriteLine($"Negative numbers: {count}");

        }
    }
}
