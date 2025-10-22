namespace MVC_Vehiculos_CROVARA.Models;

/// <summary>
/// Clase base abstracta para representar vehículos
/// </summary>
public abstract class Vehiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public string Color { get; set; }
    public decimal Precio { get; set; }

    protected Vehiculo()
    {
        Marca = string.Empty;
        Modelo = string.Empty;
        Color = string.Empty;
    }

    protected Vehiculo(int id, string marca, string modelo, int anio, string color, decimal precio)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        Color = color;
        Precio = precio;
    }

    /// <summary>
    /// Método abstracto para obtener el tipo de vehículo
    /// </summary>
    public abstract string ObtenerTipo();

    /// <summary>
    /// Método abstracto para mostrar información específica
    /// </summary>
    public abstract string ObtenerInformacionEspecifica();

    public override string ToString()
    {
        return $"ID: {Id} | Marca: {Marca} | Modelo: {Modelo} | Año: {Anio} | Color: {Color} | Precio: ${Precio:N2}";
    }
}
