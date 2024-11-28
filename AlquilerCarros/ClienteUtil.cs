public class ClienteUtil
{
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public double PagoMaximo { get; set; }

    public ClienteUtil(double pagoMaximo)
    {
        PagoMaximo = pagoMaximo;
    }

    public Cliente(int dni, string nombre, double pagoMaximo)
    {
        Dni = dni;
        Nombre = nombre;
        PagoMaximo = pagoMaximo;
    }

    public override string ToString()
    {
        return $"DNI: {Dni}, Nombre: {Nombre}, Pago Máximo: {PagoMaximo:C}";
    }
}

public static class ClienteUtil
{
    private static List<Cliente> clientes = new List<Cliente>();

    public static void CrearCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public static void ListarCliente()
    {
        Console.WriteLine("Lista de Clientes:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente.ToString());
        }
    }

    public static void EliminarCliente(int dni)
    {
        var cliente = clientes.Find(c => c.Dni == dni);
        if (cliente != null)
        {
            cliente.Remove(cliente);
            Console.WriteLine($"Cliente {dni} eliminado.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }
}
