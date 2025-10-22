using MVC_Vehiculos_CROVARA.Models;

namespace MVC_Vehiculos_CROVARA.Repository;

/// <summary>
/// Repositorio para gestionar datos estáticos de vehículos
/// Simula una base de datos en memoria
/// </summary>
public class VehiculoRepository
{
    private static List<Vehiculo> _vehiculos;
    private static int _nextId;

    public VehiculoRepository()
    {
        if (_vehiculos == null)
        {
            InicializarDatos();
        }
    }

    /// <summary>
    /// Inicializa los datos estáticos con vehículos de ejemplo
    /// </summary>
    private void InicializarDatos()
    {
        _vehiculos = new List<Vehiculo>
        {
            new Auto(1, "Toyota", "Corolla", 2022, "Blanco", 25000m, 4, "Nafta"),
            new Auto(2, "Ford", "Focus", 2021, "Rojo", 22000m, 5, "Nafta"),
            new Auto(3, "Chevrolet", "Cruze", 2023, "Negro", 28000m, 4, "Diesel"),
            new Moto(4, "Honda", "CBR 600", 2022, "Rojo", 12000m, 600, "Deportiva"),
            new Moto(5, "Yamaha", "MT-07", 2023, "Azul", 10000m, 689, "Naked"),
            new Moto(6, "Kawasaki", "Ninja 400", 2021, "Verde", 8500m, 399, "Deportiva")
        };

        _nextId = 7; // Próximo ID disponible
    }

    /// <summary>
    /// Obtiene todos los vehículos
    /// </summary>
    public List<Vehiculo> ObtenerTodos()
    {
        return new List<Vehiculo>(_vehiculos);
    }

    /// <summary>
    /// Obtiene un vehículo por ID
    /// </summary>
    public Vehiculo? ObtenerPorId(int id)
    {
        return _vehiculos.FirstOrDefault(v => v.Id == id);
    }

    /// <summary>
    /// Obtiene solo los autos
    /// </summary>
    public List<Auto> ObtenerAutos()
    {
        return _vehiculos.OfType<Auto>().ToList();
    }

    /// <summary>
    /// Obtiene solo las motos
    /// </summary>
    public List<Moto> ObtenerMotos()
    {
        return _vehiculos.OfType<Moto>().ToList();
    }

    /// <summary>
    /// Crea un nuevo vehículo
    /// </summary>
    public void Crear(Vehiculo vehiculo)
    {
        vehiculo.Id = _nextId++;
        _vehiculos.Add(vehiculo);
    }

    /// <summary>
    /// Actualiza un vehículo existente
    /// </summary>
    public bool Actualizar(Vehiculo vehiculoActualizado)
    {
        var vehiculo = ObtenerPorId(vehiculoActualizado.Id);
        if (vehiculo == null)
            return false;

        var index = _vehiculos.IndexOf(vehiculo);
        _vehiculos[index] = vehiculoActualizado;
        return true;
    }

    /// <summary>
    /// Elimina un vehículo por ID
    /// </summary>
    public bool Eliminar(int id)
    {
        var vehiculo = ObtenerPorId(id);
        if (vehiculo == null)
            return false;

        _vehiculos.Remove(vehiculo);
        return true;
    }

    /// <summary>
    /// Busca vehículos por marca
    /// </summary>
    public List<Vehiculo> BuscarPorMarca(string marca)
    {
        return _vehiculos.Where(v => v.Marca.Contains(marca, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
