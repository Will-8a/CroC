using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroC
{
    public class cls_DiaConteo
    {
        private DateTime fecha;
        private string responsable;
        private Int32 cantidadPersonas;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int CantidadPersonas
        {
            get
            {
                return cantidadPersonas;
            }

            set
            {
                cantidadPersonas = value;
            }
        }

        public string Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
            }
        }

        public cls_DiaConteo(DateTime fecha, string responsable, Int32 cantidadPersonas)
        {
            this.Fecha = fecha;
            this.Responsable = responsable;
            this.CantidadPersonas = cantidadPersonas;
        }
        
        public string conteo()
        {
            // TEXTO DE PRUEBA
            return this.Responsable + " conto el dia " + this.Fecha.ToLongDateString() + ", " + this.CantidadPersonas + " personas";
        }
    }
}
