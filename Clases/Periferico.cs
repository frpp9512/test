namespace leo_test;

abstract class Perfierico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string NumeroSerie { get; set; }
    public double Precio { get; set; }
    
    public Perfierico(string marca, string modelo, string numeroSerie, double precio)
    {
        Marca = marca;
        Modelo = modelo;
        NumeroSerie = numeroSerie;
        Precio = precio;
    }

    // Devolver si el periferico es de entrada o de salida (o ambos)
    public virtual string ObtenerTipo()
    {
        return "no definido";
    }
}