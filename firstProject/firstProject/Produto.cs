using System.Globalization;

namespace POO;

public class Produto
{
    // private por padrão se não for especificado nada
    // Se não for especificado nada, o atributo é privado
    // Os atributos não podem ser acessados diretamente de fora da classe
    // para acessar os atributos de fora da classe, precisamos usar métodos
    // que são public
    // O underscore(_) é usado para indicar que o atributo é privado
    private string _name;
    private double _price;
    private int _quantity;
    
    // Construtor
    public Produto(string name, double price, int quantity) {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    // Sobrecarga: usando Construtor
    public Produto(string name, double price) {
        _name = name;
        _price = price;
        _quantity = 0;
    }

    // Construtor Padrão (pode ser omitido)
    // Só precisamos dele se quisermos que o objeto seja criado sem parâmetros
    // ou com valores padrão diferentes dos atributos
    public Produto() {

    }

    /*  
        Sobrecarga de Construtor chamando o Construtor Padrão
        Para não repetir código e deixar o código mais limpo, passamos os parâmetros para o construtor que já existe
        os parâmetros são passados para o construtor que já existe
        
        A sintaxe ": this()" significa que estamos chamando o Construtor Padrão para inicializar o objeto
        Note que ele deve ser chamado antes de qualquer outra instrução do construtor
        Ele é chamado automaticamente quando usamos o operador "new" sem argumentos
        Se omitirmos a chamada ao construtor padrão, ele será chamado automaticamente

        Exemplo:
        public Produto(string nome, double preco) : this()
        {
            _name = name;
            _price = price;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantity = quantidade;
        }
    */

    // Getters and Setters
    // Serve para acessar e modificar os atributos privados
    // Get = obter, Set = definir
    // Vantagem: podemos colocar validações nos métodos Get e Set
    // Ex: if (price > 0) { _price = price; } 
    // No C# não é comum usar Getters e Setters
    // Mas é bom saber que existe

    public string GetName() {
        return _name;
    }

    public void SetName(string name) {
        if (name != null) {
            _name = name;
        }
    }

    public double GetPrice() {
        return _price;
    }

    public void SetPrice(double price) {
        if (price > 0)
        {
            _price = price;
        }
    }

    public int GetQuantity() {
        return _quantity;
    }

    public void SetQuantity(int quantity) {
        if (quantity >= 0) {
            _quantity = quantity;
        }
    }
    
    public double ValorTotalEstoque() {
        return _price * _quantity;
    }

    public void AdicionarProdutos(int qte) {
        _quantity += qte; 
    }

    public void RemoverProdutos(int qte) {
        _quantity -= qte;
    }

    public override string ToString() {
        return $"Nome {_name}, $ {_price:F2}, Quantidade: {_quantity}, Valor Total: $ {ValorTotalEstoque():F2}";
    }
}
