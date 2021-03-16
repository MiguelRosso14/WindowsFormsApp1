using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidad;

namespace WindowsFormsApp1
{
    public class ServicioMesero
    {

        public void Add(Mesero item)
        {
            RepositorioMeseros.Instancia.Meseros.Add(item);
        }

        public void Mesa5(Mesero item)
        {
            RepositorioMeseros.Instancia.Meseros.Add(item);
        }

        public void Mesa6(Mesero item)
        {
            RepositorioMeseros.Instancia.Meseros.Add(item);
        }

        public void Mesa7(Mesero item)
        {
            RepositorioMeseros.Instancia.Meseros.Add(item);
        }

        public void Mesa8(Mesero item)
        {
            RepositorioMeseros.Instancia.Meseros.Add(item);
        }

        public List<Mesero>GetAll(Mesero item)
        {
            return RepositorioMeseros.Instancia.Meseros;
        }
    }
}
