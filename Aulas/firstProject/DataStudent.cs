namespace firstProject;

public class DataStudent
{
    public string Name;
    public double N1;
    public double N2;
    public double N3;

    public double Media()
    {
        return (N1 + N2 + N3);
    }

    public string Status()
    {
        return Media() >= 60.00 ? "APROVADO" : "REPROVADO";
    }

    public double NotaRestante()
    {
        return 60 - Media();
    }

}
