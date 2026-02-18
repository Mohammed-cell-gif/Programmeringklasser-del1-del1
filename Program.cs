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