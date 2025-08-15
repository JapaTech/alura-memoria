using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLib
{
    internal struct Coordenadas
    {
        public double Latidude;
        public double Longidude;

        public Coordenadas(double longidude, double latitude)
        {
            Longidude = longidude;
            Latidude = latitude;
        }

        public override string ToString()
        {
            return $"Latitude: {Latidude}, Longitude: {Longidude}";
        }
    }
}
