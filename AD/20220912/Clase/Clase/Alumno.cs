using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    //Borramos el internal de la clase alumno
     class Alumno{

      

        public String Nombre
        {
            get;
            set;
        }

        public int Edad
        {
            get;
            set;
        }

        public DateTime Alta
        {
            get;
            set;
        }
        
        public String Turno
        {
            get;
            set;


        }
        public Boolean Comedor
        {
            get;
            set;
        }




    }
}
