namespace MVC_Vehiculos_CROVARA.Models;

/// <summary>
/// Clase que representa una motocicleta
/// </summary>
public class Moto : Vehiculo
{
    public int Cilindrada { get; set; }
    public string TipoMoto { get; set; } // Deportiva, Cruiser, Touring, etc.

    public Moto() : base()
    {
        TipoMoto = string.Empty;
    }

    public Moto(int id, string marca, string modelo, int anio, string color, decimal precio, 
                int cilindrada, string tipoMoto)
        : base(id, marca, modelo, anio, color, precio)
    {
        Cilindrada = cilindrada;
        TipoMoto = tipoMoto;
    }

    public override string ObtenerTipo()
    {
        return "Moto";
    }

    public override string ObtenerInformacionEspecifica()
    {
        return $"Cilindrada: {Cilindrada}cc | Tipo: {TipoMoto}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} | {ObtenerInformacionEspecifica()}";
    }
}
