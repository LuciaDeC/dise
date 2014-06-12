using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logica;

namespace Logica
{
    public interface IPersistencia
    {
        void agregar(ObjetoPersistente o);
        void modificar(ObjetoPersistente o);
        void eliminar(ObjetoPersistente o);

        void traerDatos(ObjetoPersistente o);
        List<ObjetoPersistente> traerLista(ObjetoPersistente o);

        void conectarse();
        void desconectarse();
    }
}
