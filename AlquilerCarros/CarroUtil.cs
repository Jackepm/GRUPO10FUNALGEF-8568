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
    public static void EliminarCarro(string placa)
    {
        var carro = carros.Find(c => c.placa == placa);
        if (carro != null)
        {
            carros.Remove(carro);
            Console.WriteLine($"Carro {placa} eliminado.");
        }
        else
        {
            Console.WriteLine("Carro no encontrado.");
        }
    }
}