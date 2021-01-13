using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac10
{
    class BD
    {
        private static TablaClientes clientes;
        private static TablaVehiculo vehiculos;

        //private static TablaExtras extras;
        private BD() { }
        public static TablaClientes Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new TablaClientes();
                return clientes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void INSERTCliente(ClienteDato c)
        {
            BD.clientes.Add(c);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        public static  SELECTCliente()
        {
            //List<ClienteDato> lista = new List<ClienteDato>();
            return l;
        }

        public static ClienteDato SELECTCliente(ClienteDato c)
        {
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void UPDATECliente(ClienteDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void DELETECliente(ClienteDato c)
        {
            BD.clientes.Remove(c);
        }












        public static TablaClientes Vehiculo
        {
            get
            {
                if (clientes == null)
                    clientes = new TablaClientes();
                return clientes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void INSERTVehiculo(ClienteDato c)
        {
            BD.clientes.Add(c);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        public static SELECTVehiculoe()
        {
            //List<ClienteDato> lista = new List<ClienteDato>();
            return l;
        }

        public static ClienteDato SELECTVehiculo(ClienteDato c)
        {
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void UPDATEVehiculo(ClienteDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void DELETEVehiculo(ClienteDato c)
        {
            BD.clientes.Remove(c);
        }
    }
}
