using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.ManejadorErrores
{
    public class Error
    {
        private int NumeroLinea;
        private int PosicionInicial;
        private int PosicionFinal;
        private string falla;
        private string causa;
        private string solucion;
        private TipoError Tipo;

        private Error(int NumeroLinea, int PosicionInicial, int PosicionFinal, string Falla, string Causa, string Solucion, TipoError Tipo)
        {
            this.NumeroLinea = NumeroLinea;
            this.PosicionInicial = PosicionInicial;
            this.PosicionFinal = PosicionFinal;
            this.causa = Causa;
            this.falla = Falla;
            this.Tipo = Tipo;
        }
        public static Error Crear(int NumeroLinea,
         int PosicionInicial,
         int PosicionFinal,
         string falla,
         string causa,
         string solucion,
         TipoError Tipo)
        {
            return new Error(NumeroLinea, PosicionInicial, PosicionFinal, falla, causa, solucion, Tipo);
         }
        public int ObtenerNumeroLinea()
        {
            return NumeroLinea;
        }

        public int ObtenerPosicionInicial()
        {
            return PosicionInicial;
        }

        public int ObtenerPosicionFinal()
        {
            return PosicionFinal;
        }

        public string ObtenerFalla()
        {
            return falla;
        }

        public string ObtenerCausa()
        {
            return causa;
        }

        public string ObtenerSoucion()
        {
            return solucion;
        }

        public TipoError ObtenerTipo()
        {
            return Tipo;
        }
    }
}
