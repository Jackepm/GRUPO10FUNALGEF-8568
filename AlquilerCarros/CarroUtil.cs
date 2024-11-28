public class CarroUtil
{
    private static List<carro> carros = new List<carro>();

    public static void CrearCarro(carro carro)
    {
        carros.Add(carro);
    }

    public static void ListarCarro()
    {
        Console.WriteLine("Lista de Carros:");
        foreach (var carro in carros)
        {
            Console.WriteLine(carro.ToString());
        }
    }
