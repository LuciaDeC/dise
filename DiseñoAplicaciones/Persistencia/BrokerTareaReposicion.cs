﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logica;

namespace Persistencia
{
    class BrokerTareaReposicion : Broker
    {
        public BrokerTareaReposicion()
        {
            this.conn = ConnBD.getInstance();
        }

        public override void agregar(ObjetoPersistente o)
        {
        }

        public override void modificar(ObjetoPersistente o) { }

        public override void eliminar(ObjetoPersistente o) { }

        public override ObjetoPersistente traerDatos(ObjetoPersistente o)
        {
            //ver otro ejemplo; no retorna el mismo Objeto persistente,
            return o;
        }

        public override List<ObjetoPersistente> traerLista()
        {
            List<ObjetoPersistente> lop = new List<ObjetoPersistente>();

            return lop;
        }
    }
}