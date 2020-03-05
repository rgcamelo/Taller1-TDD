using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class CuentaAhorro
    {
        private string numeroCuenta;
        private string nombre;
        private decimal saldo;
        private Boolean primeraConsignacion = false;
        private string ciudad;

        public CuentaAhorro(string numeroCuenta, string nombre, decimal saldo, Boolean p, string ciudad)
        {
            this.numeroCuenta = numeroCuenta;
            this.nombre = nombre;
            this.saldo = saldo;
            this.primeraConsignacion = p;
            this.ciudad = ciudad;
        }

        public string Consignar( decimal consignacion, string ciudad)
        {

            if ( consignacion <= 0)
            {
                return "El valor a consignar es incorrecto";
            }
            else
            {

                if ( this.primeraConsignacion == true)
                {
                    if ( consignacion >= 50000)
                    {
                        if( ciudad == this.ciudad)
                        {
                            this.saldo += consignacion;
                        }
                        else
                        {
                            this.saldo += consignacion - 10000;
                        }
                        
                        return $"Su nuevo saldo es ${saldo}";
                    }
                    else
                    {
                        return "el valor minimo de la primera consignacion debe ser de $50000 mil pesos" +
                            $"Su nuevo saldo es ${saldo}";
                    }
                }
                else
                {
                    if (ciudad == this.ciudad)
                    {
                        this.saldo += consignacion;
                    }
                    else
                    {
                        this.saldo += consignacion - 10000;
                    }
                    return $"Su nuevo saldo es ${saldo}";
                }

            }
        }
        //Y si consigna en otra ciudad la primera vez?
        //Preguntar
        //Estara asi bn?


    }
}
