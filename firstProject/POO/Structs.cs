namespace POO;

// Estruturas (Structs) - Passagem por valor
// Quando passamos uma struct por parâmetro, o C# cria uma cópia do valor
// Quando passamos uma struct por referência, o C# cria uma cópia do valor
// O valor original da struct original não é alterado

// É obrigatório inicializar todos os atributos de uma struct
// Se não for possível inicializar todos os atributos de uma struct, é obrigatório
// definir um construtor - mesmo que seja o padrão

/* 
    
    CLASSES

    - Vantagens
        - Herança
        - Polimorfismo
        - Encapsulamento
        - Sobrescrita de métodos
        - Sobrecarga de métodos
        - Sobrecarga de operadores
        - Sobrecarga de construtores
        - Sobrecarga de eventos
        - Sobrecarga de delegates
        - Sobrecarga de traits
        - Sobrecarga de interfaces
        - Sobrecarga de classes
        - Sobrecarga de structs
        - Sobrecarga de enums
        - Sobrecarga de delegates
        - Sobrecarga de delegates
        - Sobrecarga de delegates

    - Desvantagens
        - Maior consumo de memória
        - Maior consumo de CPU
        - Maior consumo de disco
        - Maior consumo de rede
        - Maior consumo de memória
        - Maior consumo de CPU
        - Maior consumo de disco
        - Maior consumo de rede
        - Maior consumo de memória
        - Maior consumo de CPU
        - Maior consumo de disco
        - Maior consumo de rede

    - Quando usar
        - Quando precisar de herança
        - Quando precisar de polimorfismo
        - Quando precisar de encapsulamento
        - Quando precisar de sobrescrita de métodos
        - Quando precisar de sobrecarga de métodos
        - Quando precisar de sobrecarga de operadores
        - Quando precisar de sobrecarga de construtores
        - Quando precisar de sobrecarga de eventos
        - Quando precisar de sobrecarga de delegates
        - Quando precisar de sobrecarga de traits
        - Quando precisar de sobrecarga de interfaces
        - Quando precisar de sobrecarga de classes
        - Quando precisar de sobrecarga de structs
        - Quando precisar de sobrecarga de enums
        - Quando precisar de sobrecarga de delegates
        - Quando precisar de sobrecarga de delegates
        - Quando precisar de sobrecarga de delegates

    STRUCTS

    - Vantagens
        - Menor consumo de memória
        - Menor consumo de CPU
        - Menor consumo de disco
        - Menor consumo de rede
        - Menor consumo de memória
        - Menor consumo de CPU
        - Menor consumo de disco
        - Menor consumo de rede
        - Menor consumo de memória
        - Menor consumo de CPU
        - Menor consumo de disco
        - Menor consumo de rede

    - Desvantagens
        - Herança
        - Polimorfismo
        - Encapsulamento
        - Sobrescrita de métodos
        - Sobrecarga de métodos
        - Sobrecarga de operadores
        - Sobrecarga de construtores
        - Sobrecarga de eventos
        - Sobrecarga de delegates
        - Sobrecarga de traits
        - Sobrecarga de interfaces
        - Sobrecarga de classes
        - Sobrecarga de structs
        - Sobrecarga de enums
        - Sobrecarga de delegates
        - Sobrecarga de delegates
        - Sobrecarga de delegates

    - Quando usar
        - Quando precisar de menor consumo de memória
        - Quando precisar de menor consumo de CPU
        - Quando precisar de menor consumo de disco
        - Quando precisar de menor consumo de rede
        - Quando precisar de menor consumo de memória
        - Quando precisar de menor consumo de CPU
        - Quando precisar de menor consumo de disco
        - Quando precisar de menor consumo de rede
        - Quando precisar de menor consumo de memória
        - Quando precisar de menor consumo de CPU
        - Quando precisar de menor consumo de disco
        - Quando precisar de menor consumo de rede

*/

// Sintaxe básica de criação de uma struct
public struct Point
{
    // Atributos
    public double X;
    public double Y;

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
