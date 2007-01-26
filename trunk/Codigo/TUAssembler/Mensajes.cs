using System;

namespace TUAssembler
{
    internal class Mensajes
    {
        public const string CantidadParametrosEntradaNoCoincideConDefinicion =
            "La cantidad de parametros de entrada no coincide con la definici�n de la funci�n";

        public const string CantidadDeParametrosNoCoincidenConDefinicion =
            "La cantidad de parametros no coincide con la definici�n de la funci�n";

        public static string TipoIncorrectoMatriz( int f, int c )
        {
            return "El tipo del elemento de la matriz, en la posici�n " + f + "," + c + " es incorrecto.";
        }
        public static string TipoIncorrectoVector( int i )
        {
            return "El tipo del elemento del vector, en la posici�n " + i + " es incorrecto.";
        }
        public static string PrintfValorDistinto( string variable, string valorEsperado )
        {
            return "printf( \"El valor del parametro " + variable + ": %i es distinto al valor esperado: " + valorEsperado  + "\", "+valorEsperado +" );";
        }
        public static string PrintfValorDistintoCadena( string variable, string valorEsperado, int i )
        {
            return "printf( \"El valor de la cadena " + variable + ": de la posicion " + i + " %i es distinto al valor esperado: " + valorEsperado + "\", " + valorEsperado + " );";
        }
    }
}