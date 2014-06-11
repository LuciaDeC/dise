using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FachadaUISistema
    {
        private Sistema sis;

        #region SINGLETON
        private static FachadaUISistema fs = null;

        private FachadaUISistema()
        {
            sis = Sistema.getSistema();
        }

        public static FachadaUISistema getFachada()
        {
            if (fs == null)
            {
                fs = new FachadaUISistema();
            }
            return fs;
        }
        #endregion

        #region USUARIO

        public void crearUsuario(String cedula, String nombre, String apellido)
        {
            if (sis.existeUsuario(cedula) == false)
            {
                sis.crearUsuario(cedula, nombre, apellido);
            }
            else
            {
                throw new MiExcepcion("El usuario ya existente.");
            }
        }

        public void eliminarUsuario(Usuario usuarioSel)
        {
            sis.eliminarUsuario(usuarioSel);
        }

        public List<Usuario> getListaUsuarios()
        {
            return sis.listaUsuarios;
        }

        public void editarUsuario(String cedula, String nombre, String apellido, Usuario usuarioSel)
        {
            sis.editarUsuario(cedula, nombre, apellido, usuarioSel);
        }

        #endregion

        #region CLIENTE

        public void crearCliente(String cedula, String nombre, String apellido)
        {
            if (sis.existeCliente(cedula) == false)
            {
                sis.crearCliente(cedula, nombre, apellido);
            }
            else
            {
                throw new MiExcepcion("El cliente ya existente.");
            }
        }

        public void eliminarCliente(Cliente clienteSel)
        {
            sis.eliminarCliente(clienteSel);
        }

        public bool tieneVehiculos(Cliente clienteSel)
        {
            return sis.tieneVehiculos(clienteSel);
        }

        public List<Cliente> getListaClientes()
        {
            return sis.listaClientes;
        }

        public void editarCliente(String cedula, String nombre, String apellido,Cliente clienteSel)
        {
            sis.editarCliente(cedula, nombre, apellido, clienteSel);
        }

        #endregion

        #region VEHICULO

        public void crearVehiculo(String matricula, String modelo, String marca, Cliente cliente)
        {
            if (sis.existeVehiculo(matricula) == false)
            {
                sis.crearVehiculo(cliente, matricula, modelo, marca);
            }
            else
            {
                throw new MiExcepcion("El vehículo ya existente.");
            }
        }

        public void eliminarVehiculo(Vehiculo vehiculo)
        {
            sis.eliminarVehiculo(vehiculo);
        }
        
        public void editarVehiculo(Vehiculo vehiculo, Cliente cliente, String marca, String modelo, String matricula)
        {
            sis.editarVehiculo(vehiculo, cliente, marca, modelo, matricula);
        }


        public List<Vehiculo> getListaVehiculos()
        {
            return sis.listaVehiculos;
        }

        public List<Vehiculo> getListaVehiculosCliente(Cliente cliente)
        {
            return cliente.listaVehiculo;
        }

        
        #endregion

        #region TANQUEAGUA

        public void crearTanqueAgua(int numero, String descripcion, int capacidad, String localizacion)
        {
            
            if (sis.existeTanqueAgua(numero) == false)
            {
                sis.crearTanqueAgua(numero, descripcion, capacidad, localizacion);
            }
            else
            {
                throw new MiExcepcion("El tanque ya existente.");
            }
        }
        public void eliminarTanqueAgua(int numero)
        {
            if (sis.existeTanqueAgua(numero))
            {
                sis.eliminarTanqueAgua(numero);
            }
            else { throw new MiExcepcion("El tanque no existe"); }
        }


        public List<TanqueAgua> getListaTanquesAgua()
        {
            return sis.listaTanquesAgua;
        }


        #endregion
        
        #region TANQUEACEITE

        public void crearTanqueAceite(int numero, String descripcion, int capacidad, int viscosidad)
        {
            if (sis.existeTanqueAceite(numero) == false)
            {
                sis.crearTanqueAceite(numero, descripcion, capacidad, viscosidad);
            }
            else
            {
                throw new MiExcepcion("El tanque ya existente.");
            }
        }
        
        public void eliminarTanqueAceite(int numero)
        {
            if (sis.existeTanqueAceite(numero))
            {
                sis.eliminarTanqueAceite(numero);
            }
            else { throw new MiExcepcion("El tanque no existe"); }
        }


        public List<TanqueAceite> getListaTanquesAceite()
        {
            return sis.listaTanquesAceite;
        }

      /*  public void editarTanqueAceite(int numero, String descripcion, int capacidad, int viscosidad, TanqueCombustible tanqueSel)
        {
            sis.editarTanqueAceite(numero, descripcion, capacidad, viscosidad, tanqueSel);
        }*/

        #endregion

        #region TANQUECOMBUSTIBLE

        public void crearTanqueCombustible(int numero, String descripcion, int capacidad, TipoCombustible tipo)
        {
            if (!sis.existeTipoCombustible(tipo.nombre))
            {
                throw new MiExcepcion("El tipo de combustible ingresado no existente.");
            }
            if (sis.existeTanqueCombustible(numero) == false)
            {
                sis.crearTanqueCombustible(numero, descripcion, capacidad, tipo);
            }
            else
            {
                throw new MiExcepcion("El tanque ya existente.");
            }
        }

        public bool contieneMangueras(TanqueCombustible tanque)
        {
            return sis.contieneMangueras(tanque);
        }


        public void eliminarTanqueCombustible(int numero)
        {
            if (sis.existeTanqueCombustible(numero))
            {
                sis.eliminarTanqueCombustible(numero);
            }
            else { throw new MiExcepcion("El tanque ya existe"); }
        }


        public List<TanqueCombustible> getListaTanquesCombustible()
        {
            return sis.listaTanquesCombustible;
        }

        public void editarTanqueCombustible(int numero, String descripcion, int capacidad, TipoCombustible tipo, TanqueCombustible tanqueSel)
        {
            sis.editarTanqueCombustible(numero, descripcion, capacidad, tipo, tanqueSel);
        }
        #endregion

        #region TIPOCOMBUSTIBLE

        public void crearTipoCombustible(String descripcion)
        {
            if (sis.existeTipoCombustible(descripcion) == false)
            {
                sis.crearTipoCombustible(descripcion);
            }
            else
            {
                throw new MiExcepcion("El tipo ya existe");
            }
        }

        public void editarTipoCombustible(TipoCombustible tipo, String nuevaDesc)
        {
            sis.editarTipoCombustible(tipo, nuevaDesc);
        }

        public void eliminarTipoCombustible(String desc)
        {
            if (sis.existeTipoCombustible(desc))
            {
                sis.eliminarTipoCombustible(desc);
            }
            else { throw new MiExcepcion("El tipo ingresado no existe"); }
        }

      

        public List<TipoCombustible> getListaTiposCombustible()
        {
            return sis.listaTiposCombustible;
        }

     
        #endregion

        #region TAREAREPOSICION

        public void crearTareaReposicion(int id, TanqueCombustible unTanque, int cantidad)
        {
            if (!sis.existeTarea(id) && (chequearCapacidad(unTanque, cantidad)))
            {
                sis.crearTareaReposicion(id, unTanque, cantidad);
            }
            else
            {
                throw new MiExcepcion("La tarea ya existe");
            }
        }


        public void eliminarTareaReposicion(int id)
        {
            sis.eliminarTarea(id);
        }

        public bool chequearCapacidad(TanqueCombustible tanque, int cantidad)
        {
            if (sis.chequearCapacidad(tanque, cantidad))
            {
                return true;
            }
            else
            {
                throw new MiExcepcion("No es posible realizar la reposición, supera la capacidad disponible.");
            }
        }
        public List<TareaReposicionCombustible> getListaTareasReposicion()
        {
            return sis.listaTareasReposicion;
        }


        #endregion


        // TAREAS DE TRATAMIENTO 

        #region TAREATRATMIENTOAGUA

        public void crearTareaTratamientoAgua(TanqueAgua unTanque)
        {
            sis.crearTareaTratamientoAgua(unTanque);
           
        }
       
        public List<TareaTratamientoAgua> getListaTareasTratamientoAgua()
        {
            return sis.listaTareaTratamientoAgua;
        }
        #endregion

        #region TAREATRATMIENTOACEITE

        public void crearTareaTratamientoAceite(TanqueAceite unTanque)
        {
            sis.crearTareaTratamientoAceite(unTanque);

        }

        public List<TareaTratamientoAceite> getListaTareasTratamientoAceite()
        {
            return sis.listaTareaTratamientoAceite;
        }
        #endregion

        #region TAREATRATMIENTOCOMB

        public void crearTareaTratamientoCombustible(TanqueCombustible unTanque)
        {
            sis.crearTareaTratamientoComb(unTanque);

        }

        public List<TareaTratamientoCombustible> getListaTareasTratamientoComb()
        {
            return sis.listaTareaTratamientoCombustible;
        }
        #endregion

        // TAREAS DE LIMPIEZA 

        #region TAREALIMPIEZAAGUA

        public void crearTareaLimpiezaAgua(TanqueAgua unTanque)
        {
            sis.crearTareaLimpiezaAgua(unTanque);

        }

        public List<TareaLimpiezaAgua> getListaTareasLimpiezaAgua()
        {
            return sis.listaTareaLimpiezaAgua;
        }
        #endregion

        #region TAREALIMPIEZAACEITE

        public void crearTareaLimpiezaAceite(TanqueAceite unTanque)
        {
            sis.crearTareaLimpiezaAceite(unTanque);

        }

        public List<TareaLimpiezaAceite> getListaTareasLimpiezaAceite()
        {
            return sis.listaTareaLimpiezaAceite;
        }
        #endregion

        #region TAREALIMPIEZACOMB

        public void crearTareaLimpiezaComb(TanqueCombustible unTanque)
        {
            sis.crearTareaLimpiezaComb(unTanque);

        }

        public List<TareaLimpiezaCombustible> getListaTareasLimpiezaCombustible()
        {
            return sis.listaTareaLimpiezaCombustible;
        }
        #endregion

        #region SURTIDOR

        public void crearSurtidor(int numero)
        {
            if (sis.existeSurtidor(numero) == false)
            {
                sis.crearSurtidor(numero);
            }
            else
            {
                throw new MiExcepcion("El surtidor ya existe");
            }
        }

        public void editarSurtidor(int numero, Surtidor surtidor)
        {
                sis.editarSurtidor(numero,surtidor);
        }

        public void eliminarSurtidor(int numero)
        {
            sis.eliminarSurtidor(numero);
        }

        public List<Surtidor> getListaSurtidores()
        {
            return sis.listaSurtidores;
        }

        public void agregarManguera(Surtidor s, Manguera m)
        {
            sis.agregarManguera(s, m);
        }
        public void quitarManguera(Surtidor s, Manguera m)
        {
            sis.quitarManguera(s, m);
        }

        public List<String> obtenerDatosCargasReporteSurtidor(Surtidor surtidor,DateTime fechaD, DateTime fechaH)
        {
            return sis.obtenerDatosCargasReporteSurtidor(surtidor, fechaD, fechaH);
        }

        public List<String> obtenerDatosTareasReporteSurtidor(Surtidor surtidor, DateTime fechaD, DateTime fechaH)
        {
            return sis.obtenerDatosTareasReporteSurtidor(surtidor, fechaD, fechaH);
        }
        #endregion

        #region MANGUERA
        public void crearManguera(int numero, int tanque)
        {
            if (!sis.existeTanqueCombustible(tanque))
            {
                throw new MiExcepcion("El tanque ingresado no existente.");
            }
            if (!sis.existeManguera(numero))
            {
                sis.crearManguera(numero, tanque);
            }
            else
            {
                throw new MiExcepcion("El tanque ya existente.");
            }
        }

        public void eliminarManguera(int numero)
        {
            sis.eliminarManguera(numero);
        }
      

        public List<Manguera> getListaMangueras()
        {
            return sis.listaMangueras;
        }

        public void editarManguera(int numero, int tanque, Manguera mangueraSel)
        {
            sis.editarManguera(numero, tanque, mangueraSel);
        }
    

        public List<String> obtenerLitrosPorTipo (List<Manguera> mangueras)
        {
           return sis.obtenerLitrosPorTipo(mangueras);
        }
        #endregion

        #region CARGAR_DATOS

        public bool cargarDatos()
        {
            return sis.cargarDatos();
        }

        #endregion

        #region CARGA
        
        public void realizarCarga (Usuario usuario,Cliente cliente,Vehiculo vehiculo,Manguera manguera,Surtidor surtidor,int cantidad,int numero)
        {
            if(!existeCarga(numero) && (chequearDisponibilidad(manguera, surtidor, cantidad))){
                sis.realizarCarga(usuario,cliente,vehiculo,manguera,surtidor,cantidad,numero);
            }else{
                throw new MiExcepcion("El número de carga ingresado ya existe.");
            }
        }

        public List<Carga> getListaCargas()
        {
            return sis.listaCargas;
        }

        public bool existeCarga(int numero)
        {
            if (numero > 0)
                return sis.existeCarga(numero);
            throw new MiExcepcion("Ingrese una carga.");
        }

        public bool chequearDisponibilidad(Manguera manguera, Surtidor surtidor, int cantidad)
        {
            if (sis.chequearDisponibilidad(manguera, surtidor, cantidad))
            {
                return true;
            }
            else
            {
                throw new MiExcepcion("No es posible realizar la carga, cantidad supera la disponible.");
            }
        }


        public List<Carga> listaCargaFiltrada(DateTime fechaDesde, DateTime fechaHasta, int litrosDesde, int litrosHasta, Surtidor surtidor, Manguera manguera)
        {

            return sis.listaCargaFiltrada( fechaDesde,  fechaHasta,  litrosDesde,  litrosHasta,  surtidor,  manguera);
        }

        #endregion


    }
        
    #region MiExcepcion
    public class MiExcepcion : System.Exception
    {
        String msg;
        public MiExcepcion(String reason)
            : base(reason)
        {
            msg = reason;
        }

        public override string Message
        {
            get
            {
                string msg = base.Message;
                return msg;
            }
        }
    }
    #endregion

}
