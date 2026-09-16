namespace firstProject;

public class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public double ValorTotalEmEstoque()
    {
        return Price * Quantity;
    }

    public void AdicionarProdutos(int qte)
    {
        Quantity += qte;
    }

    public void RemoverProdutos(int qte)
    {
        Quantity -= qte;
    }

    public override string ToString()
    {
        return $"Dados do produto: {Name}, ${Price:F2}, {Quantity} un., Valor total = ${ValorTotalEmEstoque():F2}";
    }

}
