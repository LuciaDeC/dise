using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sistema
    {
        private List<Usuario> ListaUsuarios;
        private List<Cliente> ListaClientes;
        private List<TanqueCombustible> ListaTanquesCombustible;
        private List<TanqueAgua> ListaTanquesAgua;
        private List<TanqueAceite> ListaTanquesAceite;
        public List<TipoCombustible> ListaTiposCombustible;
        private List<Manguera> ListaMangueras;
        private List<Surtidor> ListaSurtidores;
        private List<Vehiculo> ListaVehiculos;
        private List<Carga> ListaCargas;
        private List<TareaReposicionCombustible> ListaTareasReposicion;

        private List<TareaTratamientoAgua> ListaTareaTratamientoAgua;
        private List<TareaTratamientoAceite> ListaTareaTratamientoAceite;
        private List<TareaTratamientoCombustible> ListaTareaTratamientoCombustible;

        private List<TareaLimpiezaAgua> ListaTareaLimpiezaAgua;
        private List<TareaLimpiezaAceite> ListaTareaLimpiezaAceite;
        private List<TareaLimpiezaCombustible> ListaTareaLimpiezaCombustible;

        private static bool datosCargados;

        #region SINGLETON

        private static Sistema sis = null;

        public static Sistema getSistema()
        {
            if (sis == null)
            {
                sis = new Sistema();
            }
            return sis;
        }

        private Sistema()
        {
            this.ListaUsuarios = new List<Usuario>();
            this.ListaClientes = new List<Cliente>();
            this.ListaTanquesCombustible = new List<TanqueCombustible>();
            this.ListaTanquesAgua = new List<TanqueAgua>();
            this.ListaTanquesAceite = new List<TanqueAceite>();
            this.ListaTiposCombustible = new List<TipoCombustible>();
            this.ListaMangueras = new List<Manguera>();
            this.ListaSurtidores = new List<Surtidor>();
            this.ListaVehiculos = new List<Vehiculo>();
            this.ListaCargas = new List<Carga>();
            this.ListaTareasReposicion = new List<TareaReposicionCombustible>();

            this.ListaTareaTratamientoAgua = new List<TareaTratamientoAgua>();
            this.ListaTareaTratamientoAceite = new List<TareaTratamientoAceite>();
            this.ListaTareaTratamientoCombustible = new List<TareaTratamientoCombustible>();

            this.ListaTareaLimpiezaAgua = new List<TareaLimpiezaAgua>();
            this.ListaTareaLimpiezaAceite = new List<TareaLimpiezaAceite>();
            this.ListaTareaLimpiezaCombustible = new List<TareaLimpiezaCombustible>();
            datosCargados = false;
        }
        #endregion

        #region getsLISTAS
        public List<Usuario> listaUsuarios
        {
            get { return ListaUsuarios; }
        }
        public List<Cliente> listaClientes
        {
            get { return ListaClientes; }
        }
        public List<TanqueCombustible> listaTanquesCombustible
        {
            get { return ListaTanquesCombustible; }
        }
        public List<TipoCombustible> listaTiposCombustible
        {
            get { return ListaTiposCombustible; }
        }
        public List<Manguera> listaMangueras
        {
            get { return ListaMangueras; }
        }
        public List<Surtidor> listaSurtidores
        {
            get { return ListaSurtidores; }
        }
        public List<Vehiculo> listaVehiculos
        {
            get { return ListaVehiculos; }
        }
        public List<Carga> listaCargas
        {
            get { return ListaCargas; }
        }
        public List<TanqueAgua> listaTanquesAgua
        {
            get { return ListaTanquesAgua; }
        }
        public List<TanqueAceite> listaTanquesAceite
        {
            get { return ListaTanquesAceite; }
        }
     
        public List<TareaTratamientoAgua> listaTareaTratamientoAgua
        {
            get { return ListaTareaTratamientoAgua; }
        }
        public List<TareaTratamientoAceite> listaTareaTratamientoAceite
        {
            get { return ListaTareaTratamientoAceite; }
        }
        public List<TareaTratamientoCombustible> listaTareaTratamientoCombustible
        {
            get { return ListaTareaTratamientoCombustible; }
        }

        public List<TareaLimpiezaAgua> listaTareaLimpiezaAgua
        {
            get { return ListaTareaLimpiezaAgua; }
        }
        public List<TareaLimpiezaAceite> listaTareaLimpiezaAceite
        {
            get { return ListaTareaLimpiezaAceite; }
        }
        public List<TareaLimpiezaCombustible> listaTareaLimpiezaCombustible
        {
            get { return ListaTareaLimpiezaCombustible; }
        }

        public List<TareaReposicionCombustible> listaTareasReposicion
        {
            get { return ListaTareasReposicion; }
        }
       
        #endregion

        #region USUARIO
        public void crearUsuario(String cedula, String nombre, String apellido)
        {
            Usuario usuarioNuevo = new Usuario(cedula, nombre, apellido);
            this.listaUsuarios.Add(usuarioNuevo);
        }
        public void eliminarUsuario(Usuario usuarioSel)
        {
            foreach (Usuario usu in listaUsuarios)
            {
                if (usu.ci == usuarioSel.ci)
                {
                    listaUsuarios.Remove(usu);
                    break;
                }
            }
        }
        public void editarUsuario(String cedula, String nombre, String apellido, Usuario usuarioSel)
        {
            usuarioSel.ci = cedula;
            usuarioSel.nombre = nombre;
            usuarioSel.apellido = apellido;
        }

        #endregion

        #region CLIENTE
        public void crearCliente(String cedula, String nombre, String apellido)
        {
            Cliente clienteNuevo = new Cliente(cedula, nombre, apellido);
            this.listaClientes.Add(clienteNuevo);
        }
        public void eliminarCliente(Cliente clienteSel)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ci == clienteSel.ci){

                    listaClientes.Remove(cli);
                    break;
                }
            }
        }

        public bool tieneVehiculos(Cliente clienteSel)
        {
            return clienteSel.listaVehiculo.Count != 0;
        }

        public void editarCliente(String cedula, String nombre, String apellido, Cliente clienteSel)
        {
           clienteSel.ci =cedula;
           clienteSel.nombre = nombre;
           clienteSel.apellido = apellido;
        }


        #endregion

        #region VEHICULO
        public void crearVehiculo(Cliente cliente, String matricula, String modelo, String marca )
        {
           Vehiculo vehiculoNuevo = new Vehiculo(matricula, modelo, marca, cliente);
           this.listaVehiculos.Add(vehiculoNuevo);
           cliente.listaVehiculo.Add(vehiculoNuevo);
        }
        public void eliminarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Remove(vehiculo);
            vehiculo.cliente.listaVehiculo.Remove(vehiculo);
        }

        public void editarVehiculo(Vehiculo vehiculo, Cliente cliente, String marca, String modelo, String matricula)
        {
            vehiculo.cliente.listaVehiculo.Remove(vehiculo);
            vehiculo.cliente = cliente;
            vehiculo.cliente.listaVehiculo.Add(vehiculo);
            vehiculo.marca = marca;
            vehiculo.modelo = modelo;
            vehiculo.matricula = matricula;
        }

        #endregion

        #region TIPOCOMBUSTIBLE
        public void crearTipoCombustible(String descripcion)
        {
            TipoCombustible tipo = new TipoCombustible(descripcion);
            this.listaTiposCombustible.Add(tipo);
        }
        public void editarTipoCombustible(TipoCombustible tipo, String descripcion)
        {
            tipo.nombre = descripcion;

        }
        public void eliminarTipoCombustible(String desc)
        {
            {
                foreach (TipoCombustible tipo in listaTiposCombustible)
                {
                    if (tipo.nombre == desc)
                    {
                        listaTiposCombustible.Remove(tipo);
                        break;
                    }
                }
            }
        }

       /* public void editarTipoCombustible() {
        
        }
        */


        #endregion

        #region TAREAREPOSICIONCOMBUSTIBLE

        public void crearTareaReposicion(int id, TanqueCombustible unTanque, int cantidad)
        {
            if (!existeTarea(id)){
                TareaReposicionCombustible tarea = new TareaReposicionCombustible(id, unTanque, cantidad);
                this.listaTareasReposicion.Add(tarea);
            }
        }

        public bool chequearCapacidad(TanqueCombustible tanque, int cantidad)
        {
            bool ok = false;
            if (tanque.capacidadDisponible>= cantidad)
            {
                ok = true;
            }
            return ok;
        }

        public void eliminarTarea(int id)
        {
            foreach (TareaReposicionCombustible tarea in listaTareasReposicion)
            {
                if (tarea.idTarea == id)
                {
                    listaTareasReposicion.Remove(tarea);
                    break;
                }
            }
        }

        #endregion

        // TAREAS DE TRATAMIENTO

        #region TAREATRATMIENTOAGUA

        public void crearTareaTratamientoAgua(TanqueAgua unTanque)
        {
                int id = largoListaTareaTratamientoAgua() + 1;
                TareaTratamientoAgua tarea = new TareaTratamientoAgua(id, unTanque);
                unTanque.indiceCalidad = 5;
                this.listaTareaTratamientoAgua.Add(tarea);
        }
        #endregion
        
        #region TAREATRATMIENTOACEITE

        public void crearTareaTratamientoAceite(TanqueAceite unTanque)
        {
            
                int id = largoListaTareaTratamientoAceite() + 1;
                TareaTratamientoAceite tarea = new TareaTratamientoAceite(id, unTanque);
                if (unTanque.indiceCalidad >= 1 && unTanque.indiceCalidad <= 3)
                {
                    unTanque.indiceCalidad = unTanque.indiceCalidad + 2;
                }
                else {
                    unTanque.indiceCalidad = 5;
                }
                this.listaTareaTratamientoAceite.Add(tarea);
            
        }
        #endregion

        #region TAREATRATMIENTOCOMB

        public void crearTareaTratamientoComb(TanqueCombustible unTanque)
        {

            int id = largoListaTareaTratamientoComb() + 1;
            TareaTratamientoCombustible tarea = new TareaTratamientoCombustible(id, unTanque);
            if (unTanque.indiceCalidad >= 1 && unTanque.indiceCalidad <= 3)
            {
                unTanque.indiceCalidad = unTanque.indiceCalidad + 2;
            }
            else
            {
                unTanque.indiceCalidad = 5;
            }
            this.listaTareaTratamientoCombustible.Add(tarea);

        }
        #endregion


        // TAREAS DE LIMPIEZA

        #region TAREALIMPIEZAAGUA

        public void crearTareaLimpiezaAgua(TanqueAgua unTanque)
        {
            int id = largoListaTareaLimpiezaAgua() + 1;
            TareaLimpiezaAgua tarea = new TareaLimpiezaAgua(id, unTanque);
            unTanque.indiceCalidad = 5;
            this.listaTareaLimpiezaAgua.Add(tarea);
        }
        #endregion

        #region TAREALIMPIEZAACEITE

        public void crearTareaLimpiezaAceite(TanqueAceite unTanque)
        {
            int id = largoListaTareaLimpiezaAceite() + 1;
            TareaLimpiezaAceite tarea = new TareaLimpiezaAceite(id, unTanque);
            unTanque.indiceCalidad = 5;
            this.listaTareaLimpiezaAceite.Add(tarea);
        }
        #endregion

        #region TAREALIMPIEZACOMB

        public void crearTareaLimpiezaComb(TanqueCombustible unTanque)
        {
            int id = largoListaTareaLimpiezaComb() + 1;
            TareaLimpiezaCombustible tarea = new TareaLimpiezaCombustible(id, unTanque);
            unTanque.indiceCalidad = 5;
            this.listaTareaLimpiezaCombustible.Add(tarea);
        }
        #endregion

        #region TANQUEACEITE
        public void crearTanqueAceite(int numero, String descripcion, int capacidad, int viscosidad)
        {
            TanqueAceite tanque = new TanqueAceite(numero, descripcion, capacidad, viscosidad);

            this.listaTanquesAceite.Add(tanque);
        }
        public void eliminarTanqueAceite(int numero)
        {
            foreach (TanqueAceite tanque in listaTanquesAceite)
            {
                if (tanque.idTanque == numero)
                {
                    listaTanquesAceite.Remove(tanque);
                    break;
                }
            }
        }

        public void editarTanqueAceite(int numero, String descripcion, int capacidad, int viscosidad, TanqueAceite tanqueSel)
        {
            tanqueSel.idTanque = numero;
            tanqueSel.descripcion = descripcion;
            tanqueSel.capacidad = capacidad;
            tanqueSel.Viscosidad= viscosidad;
        }

        #endregion

        #region TANQUEAGUA
        public void crearTanqueAgua(int numero, String descripcion, int capacidad, String localizacion)
        {
            TanqueAgua tanque = new TanqueAgua(numero, descripcion, capacidad, localizacion);
            listaTanquesAgua.Add(tanque);
                           
        }

        public void eliminarTanqueAgua(int numero)
        {
            foreach (TanqueAgua tanque in listaTanquesAgua)
            {
                if (tanque.idTanque == numero)
                {
                    listaTanquesAgua.Remove(tanque);
                    break;
                }
            }
        }

        public void editarTanqueAgua(int numero, String descripcion, int capacidad, String localizacion, TanqueAgua tanqueSel)
        {
            tanqueSel.idTanque = numero;
            tanqueSel.descripcion = descripcion;
            tanqueSel.capacidad = capacidad;
            tanqueSel.Localizacion = localizacion;
        }

       #endregion

        #region TANQUECOMBUSTIBLE
        public void crearTanqueCombustible(int numero, String descripcion, int capacidad, TipoCombustible tipoCombustibleSeleccionado)
        {
            TanqueCombustible tanque = new TanqueCombustible(numero, descripcion, capacidad, tipoCombustibleSeleccionado);

            this.listaTanquesCombustible.Add(tanque);
        }
        public void eliminarTanqueCombustible(int numero)
        {
            foreach (TanqueCombustible tanque in listaTanquesCombustible)
            {
                if (tanque.idTanque == numero)
                {
                    listaTanquesCombustible.Remove(tanque);
                    break;
                }
            }
        }

        public void editarTanqueCombustible(int numero, String descripcion, int capacidad, TipoCombustible tipo, TanqueCombustible tanqueSel)
        {
             tanqueSel.idTanque = numero;
             tanqueSel.descripcion = descripcion;
             tanqueSel.capacidad = capacidad;
             tanqueSel.tipoCombustible = tipo;
         }

        public bool contieneMangueras(TanqueCombustible tanque)
        {
            foreach(Manguera m in this.listaMangueras){
                if(tanque.idTanque == m.tanque.idTanque){
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region MANGUERA
        public void crearManguera(int numero, int tanque)
        {
            TanqueCombustible tanqueAux = null;
            foreach (TanqueCombustible tanqueC in listaTanquesCombustible)
            {
                if (tanqueC.idTanque == tanque){
                    tanqueAux = tanqueC;
                }
            }
            Manguera manguera = new Manguera(numero, tanqueAux);
            this.listaMangueras.Add(manguera);
        }

        public void eliminarManguera (int numero)
        {
            foreach (Manguera manguera in listaMangueras)
            {
                if (manguera.numeroManguera == numero){
                    listaMangueras.Remove(manguera);
                    break;
                }
            }

        }

        public void editarManguera(int numero, int tanque, Manguera mangueraSel)
        {
            foreach (TanqueCombustible t in listaTanquesCombustible) { 
                if(t.idTanque==tanque){

                    foreach (Manguera m in listaMangueras)
                    {
                        if (m.numeroManguera == mangueraSel.numeroManguera)
                        {
                            m.numeroManguera = numero;
                            m.tanque = t;
                            break;
                        }
                    }
                }

            }
           
        }
        public List<String> obtenerLitrosPorTipo (List<Manguera> mangueras)
        {       
            int litros =0;
            String tipoLitros= "";
            List<String> retorno = new List<string>();
            foreach (TipoCombustible t in listaTiposCombustible){
                foreach (Manguera m in mangueras){
                    if(m.tanque.tipoCombustible == t) {
                        litros = litros + m.litrosExpendidos;
                    }                  
                }
                tipoLitros = t.nombre + " - " + litros + "Lts";
                retorno.Add(tipoLitros);
                litros = 0;
                tipoLitros = "";
            }
            return retorno;
        }
                    

        #endregion

        #region SURTIDOR
        public void crearSurtidor(int numero)
        {
            Surtidor surtidor = new Surtidor(numero);
            this.listaSurtidores.Add(surtidor);
        }
        public void editarSurtidor(int numero, Surtidor surtidor)
        {
            foreach (Surtidor surt in listaSurtidores){
                if (surt.numeroSerie == surtidor.numeroSerie)
                {
                    surt.numeroSerie = numero;
                    break;
                }
            }
        }
        public void eliminarSurtidor(int numero)
        {
            foreach (Surtidor surtidor in listaSurtidores)
            {
                if (surtidor.numeroSerie == numero){
                    listaSurtidores.Remove(surtidor);
                    break;
                }
            }
        }

        public void agregarManguera(Surtidor s, Manguera m)
        {
            s.listaMangueras.Add(m);
        }
        public void quitarManguera(Surtidor s, Manguera m)
        {
            s.listaMangueras.Remove(m);
        }

        public List<String> obtenerDatosCargasReporteSurtidor(Surtidor surtidor, DateTime fechaD, DateTime fechaH)
        {
            List<String> listaCargas = new List<string>();
            foreach (Manguera m in surtidor.listaMangueras)
            {
                foreach (Carga c in this.listaCargas)
                {
                    if ((m.numeroManguera == c.manguera.numeroManguera) && (c.fecha.Date >= fechaD && c.fecha.Date <= fechaH))
                    {
                        listaCargas.Add(c.ToString());
                    }
                }
            }
            return listaCargas;
        }

        public List<String> obtenerDatosTareasReporteSurtidor(Surtidor surtidor, DateTime fechaD, DateTime fechaH)
        {
            List<String> listaTareas = new List<String>();
            foreach (Manguera m in surtidor.listaMangueras)
            {
                foreach (TareaReposicionCombustible t in listaTareasReposicion)
                {
                    if ((m.tanque.idTanque == t.tanque.idTanque) && (t.fecha.Date >= fechaD && t.fecha.Date <= fechaH))
                    {
                        listaTareas.Add(t.ToString());
                    }
                }
            }
            return listaTareas;
        }

        #endregion

        #region CARGARDATOS
        public bool cargarDatos()
        {
            if(datosCargados){
                return false;
            }
            else{
                TipoCombustible tipo1 = new TipoCombustible("Super 95SP");
                listaTiposCombustible.Add(tipo1);
                TipoCombustible tipo2 = new TipoCombustible("Premium 97SP");
                listaTiposCombustible.Add(tipo2);
                TipoCombustible tipo3 = new TipoCombustible("Gas Oil");
                listaTiposCombustible.Add(tipo3);
                TipoCombustible tipo4 = new TipoCombustible("Gas Oil 50-S");
                listaTiposCombustible.Add(tipo4);
                TipoCombustible tipo5 = new TipoCombustible("Queroseno");
                listaTiposCombustible.Add(tipo5);

                TanqueCombustible tanque1 = new TanqueCombustible(1, "Tanque 1", 90000, tipo1);
                listaTanquesCombustible.Add(tanque1);
                TanqueCombustible tanque2 = new TanqueCombustible(2, "Tanque 2", 80000, tipo2);
                tanque2.cantidadActual = 10000;
                listaTanquesCombustible.Add(tanque2);
                TanqueCombustible tanque3 = new TanqueCombustible(3, "Tanque 3", 65000, tipo3);
                listaTanquesCombustible.Add(tanque3);
                TanqueCombustible tanque4 = new TanqueCombustible(4, "Tanque 4", 50000, tipo4);
                listaTanquesCombustible.Add(tanque4);
                TanqueCombustible tanque5 = new TanqueCombustible(5, "Tanque 5", 30000, tipo5);
                listaTanquesCombustible.Add(tanque5);
                TanqueCombustible tanque6 = new TanqueCombustible(6, "Tanque 6", 95000, tipo1);
                listaTanquesCombustible.Add(tanque6);
                TanqueCombustible tanque7 = new TanqueCombustible(7, "Tanque 7", 95000, tipo3);
                listaTanquesCombustible.Add(tanque7);

                TanqueAceite tanqueAceite1 = new TanqueAceite(1, "Tanque Aceite 1", 90000, 30);
                listaTanquesAceite.Add(tanqueAceite1);
                TanqueAceite tanqueAceite2 = new TanqueAceite(2, "Tanque Aceite 2", 20000, 30);
                listaTanquesAceite.Add(tanqueAceite2);

                TanqueAgua tanqueAgua1 = new TanqueAgua(5, "Tanque Agua 1", 90000, "Elevado");
                listaTanquesAgua.Add(tanqueAgua1);
                TanqueAgua tanqueAgua2 = new TanqueAgua(4, "Tanque Agua 2", 20000, "Elevado");
                listaTanquesAgua.Add(tanqueAgua2);

                Surtidor surtidor1 = new Surtidor(1);
                listaSurtidores.Add(surtidor1);
                Surtidor surtidor2 = new Surtidor(2);
                listaSurtidores.Add(surtidor2);
                Surtidor surtidor3 = new Surtidor(3);
                listaSurtidores.Add(surtidor3);
                Surtidor surtidor4 = new Surtidor(4);
                listaSurtidores.Add(surtidor4);
                Surtidor surtidor5 = new Surtidor(5);
                listaSurtidores.Add(surtidor5);
                Surtidor surtidor6 = new Surtidor(6);
                listaSurtidores.Add(surtidor6);

                Usuario usu1 = new Usuario("3.919.585-8", "Alajandro", "Frankenstein");
                listaUsuarios.Add(usu1);
                Usuario usu2 = new Usuario("4.371.407-0", "Bruno", "Fabiano");
                listaUsuarios.Add(usu2);
                Usuario usu3 = new Usuario("1.111.111-1", "Lucia", "De Carvalho");
                listaUsuarios.Add(usu3);
                Usuario usu4 = new Usuario("7.125.364-2", "Pepe", "Argento");
                listaUsuarios.Add(usu4);
                Usuario usu5 = new Usuario("1.234.567-8", "Homero", "Simpson");
                listaUsuarios.Add(usu5);

                Cliente cli1 = new Cliente("6.789.585-8", "Carlitos", "Pancho");
                listaClientes.Add(cli1);
                Cliente cli2 = new Cliente("4.123.4497-0", "Tony", "Pacheco");
                listaClientes.Add(cli2);
                Cliente cli3 = new Cliente("1.102.785-1", "Diego", "Aguirre");
                listaClientes.Add(cli3);
                Cliente cli4 = new Cliente("4.125.875-2", "Pepe", "Trueno");
                listaClientes.Add(cli4);
                Cliente cli5 = new Cliente("1.284.574-7", "Bart", "Simpson");
                listaClientes.Add(cli5);

                Manguera man1 = new Manguera(101, tanque1);
                listaMangueras.Add(man1);
                Manguera man2 = new Manguera(102, tanque1);
                listaMangueras.Add(man2);
                Manguera man3 = new Manguera(103, tanque2);
                listaMangueras.Add(man3);
                Manguera man4 = new Manguera(104, tanque3);
                listaMangueras.Add(man4);
                Manguera man5 = new Manguera(105, tanque4);
                listaMangueras.Add(man5);
                Manguera man6 = new Manguera(106, tanque4);
                listaMangueras.Add(man6);
                Manguera man7 = new Manguera(107, tanque4);
                listaMangueras.Add(man7);
                Manguera man8 = new Manguera(108, tanque5);
                listaMangueras.Add(man8);
                Manguera man9 = new Manguera(109, tanque6);
                listaMangueras.Add(man9);
                Manguera man0 = new Manguera(100, tanque7);
                listaMangueras.Add(man0);

                surtidor1.listaMangueras.Add(man1);
                surtidor1.listaMangueras.Add(man2);
                surtidor1.listaMangueras.Add(man3);
                surtidor1.listaMangueras.Add(man4);
                surtidor1.listaMangueras.Add(man5);
                surtidor2.listaMangueras.Add(man1);
                surtidor2.listaMangueras.Add(man2);
                surtidor3.listaMangueras.Add(man3);
                surtidor4.listaMangueras.Add(man4);
                surtidor4.listaMangueras.Add(man5);

                Vehiculo v1 = new Vehiculo("LCA-1234", "Civic","Honda", cli1);
                listaVehiculos.Add(v1);
                Vehiculo v2 = new Vehiculo("SLA-1234", "Fiesta", "Ford", cli1);
                listaVehiculos.Add(v2);
                Vehiculo v3 = new Vehiculo("HCB-1234", "Gol", "VW", cli2);
                listaVehiculos.Add(v3);
                Vehiculo v4 = new Vehiculo("JNA-1234", "325", "BMW", cli2);
                listaVehiculos.Add(v4);
                Vehiculo v5 = new Vehiculo("ECA-1234", "Saxo", "Citroen", cli2);
                listaVehiculos.Add(v5);
                Vehiculo v6 = new Vehiculo("HNC-1234", "308", "Peugeot", cli3);
                listaVehiculos.Add(v6);
                Vehiculo v7 = new Vehiculo("LCC-1234", "Fiorino", "Fiat", cli4);
                listaVehiculos.Add(v7);
                Vehiculo v8 = new Vehiculo("LCB-1234", "Kangoo", "Renault", cli5);
                listaVehiculos.Add(v8);
                Vehiculo v9 = new Vehiculo("LCB-1234", "300d", "Mercedes Benz", cli5);
                listaVehiculos.Add(v9);

                cli1.listaVehiculo.Add(v1);
                cli2.listaVehiculo.Add(v2);
                cli3.listaVehiculo.Add(v3);
                cli4.listaVehiculo.Add(v4);
                cli5.listaVehiculo.Add(v5);

                Carga c1 = new Carga(1, man1, 10, v1, surtidor1, cli1, usu1);
                listaCargas.Add(c1);
                Carga c2 = new Carga(2, man2, 23, v1, surtidor1, cli1, usu1);
                listaCargas.Add(c2);
                Carga c3 = new Carga(3, man2, 12, v1, surtidor1, cli1, usu1);
                listaCargas.Add(c3);
                Carga c4 = new Carga(4, man3, 120, v2, surtidor1, cli3, usu1);
                listaCargas.Add(c4);
                Carga c5 = new Carga(5, man4, 8, v3, surtidor1, cli4, usu1);
                listaCargas.Add(c5);
                Carga c6 = new Carga(6, man1, 12, v1, surtidor2, cli1, usu1);
                listaCargas.Add(c6);
                Carga c7 = new Carga(7, man2, 120, v2, surtidor2, cli3, usu1);
                listaCargas.Add(c7);
                Carga c8 = new Carga(8, man3, 8, v3, surtidor3, cli4, usu1);
                listaCargas.Add(c8);
            
                TareaReposicionCombustible tareaRep1 = new TareaReposicionCombustible(1, tanque1, 50000);
                listaTareasReposicion.Add(tareaRep1);
                TareaReposicionCombustible tareaRep2 = new TareaReposicionCombustible(2, tanque1, 20000);
                listaTareasReposicion.Add(tareaRep2);
                TareaReposicionCombustible tareaRep3 = new TareaReposicionCombustible(3, tanque2, 50000);
                listaTareasReposicion.Add(tareaRep3);
                TareaReposicionCombustible tareaRep4 = new TareaReposicionCombustible(4, tanque3, 40000);
                listaTareasReposicion.Add(tareaRep4);
                TareaReposicionCombustible tareaRep5 = new TareaReposicionCombustible(5, tanque4, 20000);
                listaTareasReposicion.Add(tareaRep5);
                TareaReposicionCombustible tareaRep6 = new TareaReposicionCombustible(5, tanque5, 20000);
                listaTareasReposicion.Add(tareaRep6);
                TareaReposicionCombustible tareaRep7 = new TareaReposicionCombustible(5, tanque6, 60000);
                listaTareasReposicion.Add(tareaRep7);
                TareaReposicionCombustible tareaRep8 = new TareaReposicionCombustible(5, tanque7, 50000);
                listaTareasReposicion.Add(tareaRep8);
                datosCargados = true;
                return true;
            }
        }



        #endregion

        #region VALIDACIONES
        public bool existeCarga(int numero)
        {
            foreach (Carga carga in listaCargas)
            {
                if (carga.numero == numero)
                    return true;
            }
            return false;
        }

        public bool existeUsuario(String cedula)
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.ci == cedula)
                    return true;
            }
            return false;
        }
        public bool existeCliente(String cedula)
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.ci == cedula)
                    return true;
            }
            return false;
        }
        public bool existeTipoCombustible(String desc)
        {
            foreach (TipoCombustible tipo in listaTiposCombustible)
            {
                if (tipo.nombre == desc)
                    return true;
            }
            return false;
        }

        public bool existeTanqueCombustible(int numero)
        {
            foreach (TanqueCombustible tanque in listaTanquesCombustible)
            {
                if (tanque.idTanque == numero)
                    return true;
            }
            return false;
        }

        public bool existeManguera(int numero)
        {
            foreach (Manguera manguera in listaMangueras)
            {
                if (manguera.numeroManguera == numero)
                    return true;
            }
            return false;
        }

        public bool existeSurtidor(int numero)
        {
            foreach (Surtidor surt in listaSurtidores)
            {
                if (surt.numeroSerie == numero)
                    return true;
            }
            return false;
        }

        public bool existeVehiculo(String matricula)
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.matricula == matricula)
                    return true;
            }
            return false;
        }
        public bool existeTarea(int idTarea)
        {
            foreach (TareaReposicionCombustible t in listaTareasReposicion)
            {
                if (t.idTarea == idTarea)
                    return true;
            }
            return false;
        }

        public bool existeTanqueAgua(int idTanque)
        {
            foreach (TanqueAgua t in listaTanquesAgua)
            {
                if (t.idTanque == idTanque)
                    return true;
            }
            return false;
        }
        public bool existeTanqueAceite(int idTanque)
        {
            foreach (TanqueAceite t in listaTanquesAceite)
            {
                if (t.idTanque == idTanque)
                    return true;
            }
            return false;
        }

        #endregion

        #region CARGA

        public void realizarCarga(Usuario usuario, Cliente cliente, Vehiculo vehiculo, Manguera manguera, Surtidor surtidor, int cantidad, int numero)
        {
                Carga carga = new Carga(numero, manguera, cantidad, vehiculo, surtidor, cliente, usuario);
                this.listaCargas.Add(carga);
            
          
        }

        public bool chequearDisponibilidad(Manguera manguera, Surtidor surtidor, int cantidad)
        {
            bool ok = false;
            foreach (TanqueCombustible t in listaTanquesCombustible)
            {
                if (t.idTanque == manguera.tanque.idTanque)
                {
                    int litrosExp = t.cantidadActual - cantidad;
                    if (litrosExp >= 0)
                    {
                        ok = true;
                    }
                }
            }
            return ok;
        }
        public List<Carga> listaCargaFiltrada(DateTime fechaDesde, DateTime fechaHasta, int litrosDesde, int litrosHasta, Surtidor surtidor, Manguera manguera)
        {
            List<Carga> listaFiltrada = new List<Carga>();

            bool litros = false;
            if (litrosDesde != 0 && litrosHasta != 0)
            {
                litros = true;
            }

            foreach (Carga carga in listaCargas)
            {
                if (litros)
                {
                    if (carga.cantidad >= litrosDesde && carga.cantidad <= litrosHasta)
                    {
                        if (surtidor == null)
                        {
                            if (manguera == null)
                            {
                                listaFiltrada.Add(carga);
                            }
                            else
                            {
                                if (carga.manguera.numeroManguera == manguera.numeroManguera)
                                {
                                    listaFiltrada.Add(carga);
                                }
                            }
                        }
                        else
                        {
                            if (manguera == null)
                            {
                                if (carga.surtidor.numeroSerie == surtidor.numeroSerie)
                                {
                                    listaFiltrada.Add(carga);
                                }
                            }
                            else
                            {
                                if (carga.manguera.numeroManguera == manguera.numeroManguera && carga.surtidor.numeroSerie == surtidor.numeroSerie)
                                {
                                    listaFiltrada.Add(carga);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (surtidor == null)
                    {
                        if (manguera == null)
                        {
                            listaFiltrada.Add(carga);
                        }
                        else
                        {
                            if (carga.manguera.numeroManguera == manguera.numeroManguera)
                            {
                                listaFiltrada.Add(carga);
                            }
                        }
                    }
                    else
                    {
                        if (manguera == null)
                        {
                            if (carga.surtidor.numeroSerie == surtidor.numeroSerie)
                            {
                                listaFiltrada.Add(carga);
                            }
                        }
                        else
                        {
                            if (carga.manguera.numeroManguera == manguera.numeroManguera && carga.surtidor.numeroSerie == surtidor.numeroSerie)
                            {
                                listaFiltrada.Add(carga);
                            }
                        }
                    }
                }
            }
            return listaFiltrada;
        }
        #endregion

        #region LARGOLISTAS

        public int largoListaTareaTratamientoAgua() {
            int largo=0;
            foreach (TareaTratamientoAgua t in listaTareaTratamientoAgua) {
                largo++;
            }
            return largo;
        }

        public int largoListaTareaTratamientoAceite()
        {
            int largo = 0;
            foreach (TareaTratamientoAceite t in listaTareaTratamientoAceite)
            {
                largo++;
            }
            return largo;
        }
        public int largoListaTareaTratamientoComb()
        {
            int largo = 0;
            foreach (TareaTratamientoCombustible t in listaTareaTratamientoCombustible)
            {
                largo++;
            }
            return largo;
        }

        public int largoListaTareaLimpiezaComb()
        {
            int largo = 0;
            foreach (TareaLimpiezaCombustible t in listaTareaLimpiezaCombustible)
            {
                largo++;
            }
            return largo;
        }
        public int largoListaTareaLimpiezaAgua()
        {
            int largo = 0;
            foreach (TareaLimpiezaAgua t in listaTareaLimpiezaAgua)
            {
                largo++;
            }
            return largo;
        }
        public int largoListaTareaLimpiezaAceite()
        {
            int largo = 0;
            foreach (TareaLimpiezaAceite t in listaTareaLimpiezaAceite)
            {
                largo++;
            }
            return largo;
        }

        #endregion
    }
}