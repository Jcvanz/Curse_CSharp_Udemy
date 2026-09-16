namespace firstProject;

public class DadosFuncionario
{
    public string Name;
    public double SalaryBrute;
    public double Tax;

    public override string ToString()
    {
        return $"{Name}, Salário líquido: ${SalaryLiquid():F2}";
    }


    public double SalaryLiquid()
    {
        return SalaryBrute - Tax;
    }

    public void IncrementSalary(double percentage)
    {
        SalaryBrute += SalaryBrute * (percentage / 100);
    }
}
