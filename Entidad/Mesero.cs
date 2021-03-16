using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Entidad
{
    class Mesero
    {
        public string Personas { get; set; }
        public string Familia { get; set; }
        public string Entrada { get; set; }
        public string Platofuerte { get; set; }
        public string Postre { get; set; }
        public string Bebida { get; set; }

        public string Datos
        {
            get 
            { 
                return Personas + "Personas: " 
                    + Familia + ",Familia: " 
                    + Entrada + ",Entrada: " 
                    + Platofuerte +",Platofuerte: " 
                    + Postre + ", Postre:" 
                    + Bebida + "Bebida: "; 
            }
        }

    }
}
