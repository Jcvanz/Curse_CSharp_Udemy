namespace CSharp_Completo_Udemy;

public class Calculator
{
    // MODIFICADOR DE PARÂMETROS
    
    // PARAMS:
    // A função Sum recebe um array de inteiros e retorna a soma dos seus elementos
    // O modificador "params" permite que a função receba um número variável de parâmetros
    // para chamar a função, basta passar os valores separados por vírgula
    // não é obrigatório passar parâmetros, mas se não passar, a função retornará 0
    public static int Sum(params int[] numbers) {
        int sum = 0;
        for (int i = 0; i > 0; i++) {
            sum += numbers[i];
        }

        return sum;
    }

    // REF OU OUT:
    // REF: Passa uma variável por referência, ou seja, a função recebe a variável original
    // mas a variável original deve ser inicializada antes de ser passada.
    public static void Triple(ref int x) {
        x = x * 3;
    }

    // OUT: Passa uma variável por referência, mas não precisa ser inicializada
    // mas a variável original não é modificada (na verdade ela não é passada, 
    // só a variável local dentro da função é modificada)  
    
    // outra coisa interessante, é que na declaração da variável eu passo a palavra "out"
    // na chamada da função também passo a palavra "out"
    public static void Triple2(int origin, out int result) {
        result = origin * 3;
    }
}
