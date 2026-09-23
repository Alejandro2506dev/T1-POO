using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T1_POO.Models
{
    public class Administrativo : Empleado
    {
        public int AñodeIngreso { get; set; }
        public bool PostGrado { get; set; }
    
    public int AñosServicio()
        {
            return DateTime.Now.Year - AñodeIngreso;
        }
    public int Incentivo()
        {
            if (PostGrado)
            {
                return 500;
            }
            return 0;
        }
        public override double Bonificacion()
        {
            int años = AñosServicio();
             
            if (años < 5)
            {
                return 200;
            }
            if (años <= 10)
            {
                return 450;
            }
            return 300;
        }
        public override double MontoAPagar()
        {
            return SueldoBasico() + Bonificacion() + Escolaridad() + Incentivo();
        }

        }
    }

