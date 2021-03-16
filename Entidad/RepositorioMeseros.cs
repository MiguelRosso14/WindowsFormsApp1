using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidad;

namespace WindowsFormsApp1
{
    public sealed class RepositorioMeseros
    {

        public List<Mesero> Meseros { get; set; } = new List<Mesero>();

        public static RepositorioMeseros Instancia { get; } = new RepositorioMeseros();
        private RepositorioMeseros()
        {

        }
    }
}
