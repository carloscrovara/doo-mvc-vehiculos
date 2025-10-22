using MVC_Vehiculos_CROVARA.Models;
using MVC_Vehiculos_CROVARA.Repository;
using MVC_Vehiculos_CROVARA.Views;

namespace MVC_Vehiculos_CROVARA.Controllers;

/// <summary>
/// Controlador que maneja las operaciones CRUD de vehículos
/// Coordina entre el Repositorio (datos) y la Vista (presentación)
/// </summary>
public class VehiculoController
{
    private readonly VehiculoRepository _repository;
    private readonly VehiculoView _view;

    public VehiculoController()
    {
        _repository = new VehiculoRepository();
        _view = new VehiculoView();
    }

    /// <summary>
    /// GET ALL - Obtiene y muestra todos los vehículos
    /// </summary>
    public void ObtenerTodos()
    {
        var vehiculos = _repository.ObtenerTodos();
        _view.MostrarListaVehiculos(vehiculos, "TODOS LOS VEHÍCULOS");
    }

    /// <summary>
    /// GET BY ID - Obtiene y muestra un vehículo por ID
    /// </summary>
    public void ObtenerPorId(int id)
    {
        var vehiculo = _repository.ObtenerPorId(id);
        _view.MostrarVehiculo(vehiculo, $"VEHÍCULO ID: {id}");
    }

    /// <summary>
    /// GET AUTOS - Obtiene y muestra solo los autos
    /// </summary>
    public void ObtenerAutos()
    {
        var autos = _repository.ObtenerAutos();
        _view.MostrarListaVehiculos(autos.Cast<Vehiculo>().ToList(), "TODOS LOS AUTOS");
    }

    /// <summary>
    /// GET MOTOS - Obtiene y muestra solo las motos
    /// </summary>
    public void ObtenerMotos()
    {
        var motos = _repository.ObtenerMotos();
        _view.MostrarListaVehiculos(motos.Cast<Vehiculo>().ToList(), "TODAS LAS MOTOS");
    }

    /// <summary>
    /// POST - Crea un nuevo auto
    /// </summary>
    public void CrearAuto(string marca, string modelo, int anio, string color, decimal precio,
                          int cantidadPuertas, string tipoCombustible)
    {
        var auto = new Auto(0, marca, modelo, anio, color, precio, cantidadPuertas, tipoCombustible);
        _repository.Crear(auto);
        _view.MostrarMensajeExito($"Auto creado exitosamente con ID: {auto.Id}");
        _view.MostrarVehiculo(auto, "AUTO CREADO");
    }

    /// <summary>
    /// POST - Crea una nueva moto
    /// </summary>
    public void CrearMoto(string marca, string modelo, int anio, string color, decimal precio,
                          int cilindrada, string tipoMoto)
    {
        var moto = new Moto(0, marca, modelo, anio, color, precio, cilindrada, tipoMoto);
        _repository.Crear(moto);
        _view.MostrarMensajeExito($"Moto creada exitosamente con ID: {moto.Id}");
        _view.MostrarVehiculo(moto, "MOTO CREADA");
    }

    /// <summary>
    /// PUT - Actualiza un auto existente
    /// </summary>
    public void ActualizarAuto(int id, string marca, string modelo, int anio, string color, decimal precio,
                               int cantidadPuertas, string tipoCombustible)
    {
        var auto = new Auto(id, marca, modelo, anio, color, precio, cantidadPuertas, tipoCombustible);
        var resultado = _repository.Actualizar(auto);
        
        if (resultado)
        {
            _view.MostrarMensajeExito($"Auto ID {id} actualizado exitosamente");
            _view.MostrarVehiculo(auto, "AUTO ACTUALIZADO");
        }
        else
        {
            _view.MostrarMensajeError($"No se encontró el auto con ID {id}");
        }
    }

    /// <summary>
    /// PUT - Actualiza una moto existente
    /// </summary>
    public void ActualizarMoto(int id, string marca, string modelo, int anio, string color, decimal precio,
                               int cilindrada, string tipoMoto)
    {
        var moto = new Moto(id, marca, modelo, anio, color, precio, cilindrada, tipoMoto);
        var resultado = _repository.Actualizar(moto);
        
        if (resultado)
        {
            _view.MostrarMensajeExito($"Moto ID {id} actualizada exitosamente");
            _view.MostrarVehiculo(moto, "MOTO ACTUALIZADA");
        }
        else
        {
            _view.MostrarMensajeError($"No se encontró la moto con ID {id}");
        }
    }

    /// <summary>
    /// DELETE - Elimina un vehículo por ID
    /// </summary>
    public void Eliminar(int id)
    {
        var vehiculo = _repository.ObtenerPorId(id);
        if (vehiculo != null)
        {
            _view.MostrarVehiculo(vehiculo, "VEHÍCULO A ELIMINAR");
        }

        var resultado = _repository.Eliminar(id);
        
        if (resultado)
        {
            _view.MostrarMensajeExito($"Vehículo ID {id} eliminado exitosamente");
        }
        else
        {
            _view.MostrarMensajeError($"No se encontró el vehículo con ID {id}");
        }
    }

    /// <summary>
    /// GET BY MARCA - Busca vehículos por marca
    /// </summary>
    public void BuscarPorMarca(string marca)
    {
        var vehiculos = _repository.BuscarPorMarca(marca);
        _view.MostrarListaVehiculos(vehiculos, $"VEHÍCULOS DE MARCA: {marca.ToUpper()}");
    }
}
