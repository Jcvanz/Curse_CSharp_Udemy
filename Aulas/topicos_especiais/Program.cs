using System;

namespace topicos_especiais{
    class Program{
        static void Main(string[] args){
            // SWITCH CASE
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-feira";
                    break;
                case 3:
                    day = "Terca-feira";
                    break;
                case 4:
                    day = "Quarta-feira";
                    break;
                case 5:
                    day = "Quinta-feira";
                    break;
                case 6:
                    day = "Sexta-feira";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Dia invalido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + day);

            // ------------------------------------------------------------------

            // Expressão condicinal ternária
            int n1, n2, max;

            Console.WriteLine("Digite dois numeros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            max = (n1 > n2) ? n1 : n2;
            Console.WriteLine("Maior: " + max);

            // ------------------------------------------------------------------

            // Funções para string
            string s = "ABCde";
            Console.WriteLine("Original: " + s);
            Console.WriteLine("Maiusculo: " + s.ToUpper());
            Console.WriteLine("Minusculo: " + s.ToLower());
            Console.WriteLine("Limpar: " + s.Trim());
            Console.WriteLine("Substring: " + s.Substring(2));
            Console.WriteLine("Replace: " + s.Replace("ABC", "XYZ"));
            Console.WriteLine("Contains: " + s.Contains("ABC"));
            Console.WriteLine("IndexOf: " + s.IndexOf("ABC"));
            Console.WriteLine("LastIndexOf: " + s.LastIndexOf("ABC"));
            Console.WriteLine("Length: " + s.Length);
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(s));
            Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(s));
            Console.WriteLine("Split: " + s.Split(' ')[0]);

            // ------------------------------------------------------------------

            // Date Time
            DateTime d1 = DateTime.Now; // data e hora atual
            DateTime d2 = new DateTime(2000, 10, 20); // data específica
            DateTime d3 = new DateTime(2000, 10, 20, 10, 30, 0); // data e hora específica
            DateTime d4 = new DateTime(2000, 10, 20, 10, 30, 0, 500); // data e hora com milissegundos
            DateTime d5 = new DateTime(2000, 10, 20, 10, 30, 0, 500, DateTimeKind.Local); // data e hora local
            DateTime d6 = new DateTime(2000, 10, 20, 10, 30, 0, 500, DateTimeKind.Utc); // data e hora UTC
            DateTime d7 = new DateTime(2000, 10, 20, 10, 30, 0, 500, DateTimeKind.Unspecified); // data e hora não especificada

            Console.WriteLine("DATA E HORA ATUAL: " + d1);
            Console.WriteLine("DATA E HORA ATUAL (TICKS): " + d1.Ticks); // 100 nanoseconds
            Console.WriteLine("DATA ESPECÍFICA: " + d2);
            Console.WriteLine("DATA E HORA ESPECÍFICA: " + d3);
            Console.WriteLine("DATA E HORA COM MILISSEGUNDOS: " + d4);
            Console.WriteLine("DATA E HORA LOCAL: " + d5);
            Console.WriteLine("DATA E HORA UTC: " + d6);
            Console.WriteLine("DATA E HORA NÃO ESPECIFICADA: " + d7);

            // ------------------------------------------------------------------

            // Time Span
            TimeSpan t1 = TimeSpan.Zero;
            TimeSpan t2 = new TimeSpan(0, 1, 30);
            TimeSpan t3 = new TimeSpan(9, 30, 53);
            TimeSpan t4 = new TimeSpan(1, 10, 0, 0);
            TimeSpan t5 = new TimeSpan(0, 0, 0, 1, 500);
            TimeSpan t6 = TimeSpan.FromDays(3);
            TimeSpan t7 = TimeSpan.FromHours(24);
            TimeSpan t8 = TimeSpan.FromMinutes(60);
            TimeSpan t9 = TimeSpan.FromSeconds(60);
            TimeSpan t10 = TimeSpan.FromMilliseconds(60);

            Console.WriteLine("TIME SPAN ZERO: " + t1);
            Console.WriteLine("TIME SPAN: " + t2);
            Console.WriteLine("TIME SPAN: " + t3);
            Console.WriteLine("TIME SPAN: " + t4);
            Console.WriteLine("TIME SPAN: " + t5);
            Console.WriteLine("TIME SPAN FROM DAYS: " + t6);
            Console.WriteLine("TIME SPAN FROM HOURS: " + t7);
            Console.WriteLine("TIME SPAN FROM MINUTES: " + t8);
            Console.WriteLine("TIME SPAN FROM SECONDS: " + t9);
            Console.WriteLine("TIME SPAN FROM MILLISECONDS: " + t10);

            TimeSpan d11 = DateTime.Now - d2;
            Console.WriteLine("TIME SPAN DIFF: " + d11);
            Console.WriteLine("TIME SPAN DAYS: " + d11.Days);
            Console.WriteLine("TIME SPAN HOURS: " + d11.Hours);
            Console.WriteLine("TIME SPAN MINUTES: " + d11.Minutes);
            Console.WriteLine("TIME SPAN SECONDS: " + d11.Seconds);
            Console.WriteLine("TIME SPAN MILLISECONDS: " + d11.Milliseconds);
            Console.WriteLine("TIME SPAN TOTAL DAYS: " + d11.TotalDays);
            Console.WriteLine("TIME SPAN TOTAL HOURS: " + d11.TotalHours);
            Console.WriteLine("TIME SPAN TOTAL MINUTES: " + d11.TotalMinutes);
            Console.WriteLine("TIME SPAN TOTAL SECONDS: " + d11.TotalSeconds);
            Console.WriteLine("TIME SPAN TOTAL MILLISECONDS: " + d11.TotalMilliseconds);
        }
    }
}