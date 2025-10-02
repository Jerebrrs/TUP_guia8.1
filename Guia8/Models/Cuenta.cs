
using System;

namespace Guia8.Models
{
    public class Cuenta : IComparable<Cuenta>
    {
        public string Nombre{ get; set; }
        public int Dni { get; set; }
        public double Importe { get; set; }

        public Cuenta() { }
        public Cuenta(string nombre,int dni,double importe)
        {
            this.Nombre= nombre; 
            this.Dni= dni;
            this.Importe= importe;
        }

        public string ToString()
        {
            return $@"Nombre: {Nombre} - Dni :{Dni} - Importe: {Importe}";
        }

        public int CompareTo(Cuenta other)
        {
            throw new NotImplementedException();
        }
    }
}
