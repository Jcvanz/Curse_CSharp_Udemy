namespace firstProject;

public class ConversorDeMoeda
{
    public static double Iof = 6;

    public static double Converter(double cot, double qte)
    {
        return (qte * cot) + ((qte * cot) * Iof / 100.0);
    }
}
