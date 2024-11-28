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


