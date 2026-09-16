using System.Globalization;

namespace POO;

public class Produto
{
    public string Name;
    public double Price;
    public int Quantity;

    // Construtor
    // Tem o mesmo nome da classe e recebe os parâmetros na ordem que foram definidos no objeto
    // é necessário explicitar cada atributo do objeto na sua criação
    // A ordem dos parâmetros do construtor não precisa ser a mesma ordem dos atributos
    // Pode haver vários construtores 
    // Ex: public Produto(string name, double price, int quantity) {}
    //    public Produto(string name, double price) {}
    //    public Produto() {}

    // Construtor padrão é criado automaticamente pelo C#
    // se não houver nenhum construtor na classe
    // Se criarmos um construtor, o construtor padrão não será criado automaticamente
    // e devemos criá-lo manualmente se quisermos que o objeto seja criado sem parâmetros
    // ou com valores padrão diferentes dos atributos

    // Exemplo de construtor que recebe todos os parâmetros
    public Produto(string name, double price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Sobrecarga: usando Construtor
    // Para facilitar o uso, criamos um construtor que recebe apenas o nome e o preço
    // A quantidade será iniciada com 0 por padrão
    public Produto(string name, double price) {
        Name = name;
        Price = price;
        Quantity = 0;
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
            Name = nome;
            Price = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantity = quantidade;
        }
    */

    // Getters and Setters
    // Serve para acessar e modificar os atributos privados
    // Get = obter, Set = definir
    // Vantagem: podemos colocar validações nos métodos Get e Set
    // Ex: if (price > 0) { _price = price; } 
    // No C# não é comum usar Getters e Setters
    // Mas é bom saber que existe

    // private por padrão se não for especificado nada
    // Se não for especificado nada, o atributo é privado
    // Os atributos não podem ser acessados diretamente de fora da classe
    // para acessar os atributos de fora da classe, precisamos usar métodos
    // que são public
    // O underscore(_) é usado para indicar que o atributo é privado
    private string _name;
    private double _price;
    private int _quantity;

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

    // Properties
    // Propriedades são uma forma mais limpa de acessar e modificar os atributos privados
    // O "get" é o método que retorna o valor do atributo
    // O "set" é o método que define o valor do atributo
    // Se o atributo for privado, precisamos usar os métodos Get e Set
    
    // A vantagem do Property é que ele é mais limpo e organizado
    // E podemos colocar validações nos métodos Get e Set

    /*
        // sintaxe:
        public tipo NomeDaPropriedade {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        } 

        // ou sintaxe curta:

        public string Name {
            get => _name;
            set => _name = value;
        }

        // Podemos criar um property que não pode ser modificado de fora da classe, ou seja, somente leitura:
        public string Name {
            get => _name;
            // Não colocamos set
        }
       
        // Podemos colocar validações no set também:
        public string Name {
            get { return _name; }
            set {
                if (value != null) {
                    _name = value;
                }
            }
        }
    */

    public string Name {
        get => _name;
        set => _name = value;
    }

    public double Price {
        get => _price;
        set => _price = value;
    }

    public int Quantity {
        get => _quantity;
        set => _quantity = value;
    }

    // Auto Properties
    // São properties que não precisam de atributos privados para armazenar os valores
    // O C# cria os atributos privados automaticamente
    // A sintaxe é a mesma das properties, mas sem os atributos privados
    
    /*
        // sintaxe:
        public tipo NomeDaPropriedade { get; set; }

        // ou sintaxe curta:
        public string Name { get; set; }

        // Podemos criar um property que não pode ser modificado de fora da classe, ou seja, somente leitura:
        public string Name {
            get => _name;
            // Não colocamos set
        }

        // Podemos colocar validações no set também:
        public string Name {
            get { return _name; }
            set {
                if (value != null) {
                    _name = value;
                }
            }
        }
    */

    // Modificadores de acesso em propriedades
    // public: pode ser acessado de qualquer lugar
    // private: pode ser acessado apenas dentro da classe
    // protected: pode ser acessado dentro da classe e das classes filhas
    // internal: pode ser acessado dentro do mesmo assembly
    // protected internal: pode ser acessado dentro do mesmo assembly ou das classes filhas
    // private protected: pode ser acessado dentro da classe e das classes filhas do mesmo assembly

    public double ValorTotalEstoque() {
        return Price * Quantity;
    }

    public void AdicionarProdutos(int qte) {
        Quantity += qte; 
    }

    public void RemoverProdutos(int qte) {
        Quantity -= qte;
    }

    public override string ToString() {
        return $"Nome {Name}, $ {Price:F2}, Quantidade: {Quantity}, Valor Total: $ {ValorTotalEstoque():F2}";
    }
}
