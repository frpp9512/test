namespace leo_test;

class Mouse : Perfierico
{
    public bool EsOptico { get; set; }
    public bool EsInalambrico { get; set; }

    public Mouse(string marca, string modelo, string numeroSerie, double precio, bool esOptico, bool esInalambrico)
        : base(marca, modelo, numeroSerie, precio)
    {
        EsOptico = esOptico;
        EsInalambrico = esInalambrico;
    }

    public override string ObtenerTipo()
    {
        return "entrada";
    }
}