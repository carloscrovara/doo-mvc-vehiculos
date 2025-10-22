namespace MVC_Vehiculos_CROVARA.Models;

/// <summary>
/// Clase que representa un automóvil
/// </summary>
public class Auto : Vehiculo
{
    public int CantidadPuertas { get; set; }
    public string TipoCombustible { get; set; }

    public Auto() : base()
    {
        TipoCombustible = string.Empty;
    }

    public Auto(int id, string marca, string modelo, int anio, string color, decimal precio, 
                int cantidadPuertas, string tipoCombustible)
        : base(id, marca, modelo, anio, color, precio)
    {
        CantidadPuertas = cantidadPuertas;
        TipoCombustible = tipoCombustible;
    }

    public override string ObtenerTipo()
    {
        return "Auto";
    }

    public override string ObtenerInformacionEspecifica()
    {
        return $"Puertas: {CantidadPuertas} | Combustible: {TipoCombustible}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} | {ObtenerInformacionEspecifica()}";
    }
}
