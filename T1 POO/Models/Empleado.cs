using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T1_POO.Models
{
    public class Empleado

    {
        public string idEmpleado { get; set; }
        public string nomapeEmpleado { get; set; }
        public string categoriaEmpleado { get; set; }
        public int nHijos { get; set; }
        public string tipoContrato { get; set; }

    
    public int SueldoBasico()
        {
            switch (categoriaEmpleado.ToUpper())
            {
                case "E1": return 5500;
                case "E2": return 2500;
                case "E3": return 2200;
                default: return 1700;
            }
        }
    public int Escolaridad()
        {
            return nHijos * 108;
        }
    public virtual double Bonificacion()
        {
            if (tipoContrato == "Indefinido")
            {
                return 0.15 * SueldoBasico();
            }
            return 0.10 * SueldoBasico();
        }
    public virtual double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion();
        }
    }
}