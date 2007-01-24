using System;
using System.Collections.Generic;
using System.Text;

namespace TUAssembler
{
    class Mensajes
    {
        public const string CantidadParametrosEntradaNoCoincideConDefinicion = "La cantidad de parametros de entrada no coincide con la definici�n de la funci�n";
        public const string CantidadDeParametrosNoCoincidenConDefinicion = "La cantidad de parametros no coincide con la definici�n de la funci�n";
        public static string TipoIncorrectoMatriz( int f, int c )
        {
            return "El tipo del elemento de la matriz, en la posici�n " + f + "," + c + " es incorrecto.";
        }
        public static string TipoIncorrectoVector( int i )
        {
            return "El tipo del elemento del vector, en la posici�n " + i + " es incorrecto.";
        }
    }
}
