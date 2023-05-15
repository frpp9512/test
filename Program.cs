using leo_test;

var mouse1 = new Mouse("Logitech", "GRR5454", "65465465654", 25.4, true, false);
var mouse2 = new Mouse("Maxell", "M9985454", "6886468464", 20.4, false, false);
var mouse3 = new Mouse("Microsoft", "M234", "988468464", 28.2, true, true);

var listadoMouse = new List<Mouse>
{
    new Mouse("Logitech", "GRR5454", "65465465654", 25.4, true, false),
    new Mouse("Maxell", "M9985454", "6886468464", 20.4, false, false),
    new Mouse("Microsoft", "M234", "988468464", 28.2, true, true)
};

for (var i = 0; i < listadoMouse.Count; i++)
{
    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", listadoMouse[i].Marca, listadoMouse[i].Modelo, listadoMouse[i].NumeroSerie, listadoMouse[i].Precio, listadoMouse[i].EsOptico, listadoMouse[i].EsInalambrico);
}

var monitor = new leo_test.Monitor("Dell", "D879C", "6+46846468486", 58.5, 17, TecnologiaMonitor.LCD);

Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", monitor.Marca, monitor.Modelo, monitor.NumeroSerie, monitor.Precio, monitor.TamañoPantalla, monitor.Teconlogia);

var listaPerifericos = new List<Perfierico>
{
    mouse1, mouse2, mouse3, monitor
};

foreach (var periferico in listaPerifericos)
{
    Console.WriteLine("{0}: {1} {2}", periferico.Marca, periferico.ObtenerTipo(), periferico.Precio);
}

Console.WriteLine("Finalizado");