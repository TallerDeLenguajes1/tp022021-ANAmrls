using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02
{
    public class Empleado
    {
        private string nombre;
        private DateTime fechaNac;
        private int dni;
        private int tel;
        private string direccion;
        private DateTime fechaIngreso;
        private decimal sueldoBasico;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public decimal SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public int calcularAnios(DateTime fecha)
        {
            DateTime hoy = DateTime.Now;

            if (hoy.Month < fecha.Month
                || (hoy.Month == fecha.Month && hoy.Day < fecha.Day))
            {
                return hoy.Year - fecha.Year - 1;
            }
            else
            {
                return hoy.Year - fecha.Year;
            }

        }

        public decimal CalcularSalario(int antiguedad)
        {
            decimal adicional;

            if (antiguedad <= 20)
            {
                adicional = sueldoBasico * (decimal)0.1 * antiguedad;
            }
            else
            {
                adicional = sueldoBasico * (decimal)0.25;
            }

            return sueldoBasico + adicional - (sueldoBasico * (decimal)0.15);
            
        }
    }
}
