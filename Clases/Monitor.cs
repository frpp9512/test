namespace leo_test;

class Monitor : Perfierico
{
    public double TamañoPantalla { get; set; }
    public TecnologiaMonitor Teconlogia { get; set;}

    public Monitor(string marca, string modelo, string numeroSerie, double precio, double tamañoPantalla, TecnologiaMonitor tecnologia)
        : base (marca, modelo, numeroSerie, precio)
    {
        TamañoPantalla = tamañoPantalla;
        Teconlogia = tecnologia;
    }

    public override string ObtenerTipo()
    {
        return "salida";
    }
}