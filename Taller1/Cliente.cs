using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    class Cliente
    {
        private string nombre;
        private string ubicacion;
        private CuentaAhorro cuenta;

        public Cliente( string nombre, string ubicacion, CuentaAhorro cuenta)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.cuenta = cuenta;
        }

    }
}
