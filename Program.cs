class Fordon
{
    private string tillverkare;
    private string modell;
    private int arsmodell;
    private double vikt;

    public void Settillverkare(string tv)
    {
        tillverkare=tv;
    }
    public string Gettillverkare(){return tillverkare;}
    public void Setmodell(string m) {modell=m;}
    public string Getmodell() {return modell;}
    public void Setarsmodell(int am){arsmodell=am;}
    public int Getarsmodell(){ return arsmodell;}
    public void Setvikt(double v){vikt=v;}
    public double Getvikt(){return vikt;}
}
class Program{
static List<Fordon> FordonLista = new List<Fordon>();
static void Main(string[] args)
{
    Fordon bill1 = new();
    Fordon bill2 = new Fordon();
    bill1.Settillverkare("Volvo");
    bill1.Setmodell("XC60");
    bill1.Setarsmodell(2022);
    bill1.Setvikt(1900);

    bill2.Settillverkare("BMW");
    bill2.Setmodell("XW60");
    bill2.Setarsmodell(2021);
    bill2.Setvikt(1349);
    FordonLista.Add(bill1);
    FordonLista.Add(bill2);
}
static void SkrivutFordon(List<Fordon> lista)
    {
        foreach (Fordon f in lista)
        {
            Console.WriteLine(f.Gettillverkare() + " " + f.Getmodell() +" " + f.Getarsmodell() + " " + f.Getvikt() + " kg");

        }
    }
}