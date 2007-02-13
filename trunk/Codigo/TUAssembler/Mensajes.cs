using System;
using TUAssembler.Compilacion;

namespace TUAssembler
{
    internal class Mensajes
    {
        public const string CantidadParametrosEntradaNoCoincideConDefinicion =
            "La cantidad de parametros de entrada no coincide con la definici�n de la funci�n";

        public const string CantidadDeParametrosNoCoincidenConDefinicion =
            "La cantidad de parametros no coincide con la definici�n de la funci�n";

        public static string ErrorAlLeerParametroDeEntrada( Exception e )
        {
            string mensaje = string.Empty;
            mensaje = "Se produjo un error al leer los par�metros de entrada de la funci�n:\n";
            mensaje += "Descripci�n: \n" + MA.ExcepcionCompleta(e) + "\n\n";
            return mensaje;
        }
        public static string ErrorAlLeerParametroDeSalida( Exception e )
        {
            string mensaje = string.Empty;
            mensaje = "Se produjo un error al leer los par�metros de salida de la funci�n:\n";
            mensaje += "Descripci�n: \n" + MA.ExcepcionCompleta( e ) + "\n\n";            
            return mensaje;
        }
        public static string ErrorLecturaDefinicion( string archivo, Exception e )
        {
            string mensaje = string.Empty;
            mensaje = "Se produjo un error en la lectura de la definici�n de la funci�n:\n";
            mensaje += "Archivo: " + archivo + "\n";
            mensaje += "Descripci�n: \n" + MA.ExcepcionCompleta(e) + "\n\n";
            return mensaje;
        }
        public static string ErrorAlEjecutar( Exception e )
        {
            return ErrorAlEjecutar( MA.ExcepcionCompleta( e ) );
        }
        public static string ErrorAlEjecutar( string descripcion )
        {
            return "Error al ejecutar el c�digo probador: \n" + descripcion;
        }
        public static string ErrorAlCompilar( Compilador compilador, string comando, Exception excepcion )
        {
            return ErrorAlCompilar( compilador, comando, MA.ExcepcionCompleta( excepcion ) );
        }
        public static string ErrorAlCompilar( Compilador compilador, string comando, string descripcion )
        {
            string mensaje = string.Empty;

            if( compilador is CompiladorAsm )
                mensaje = "Error de compilaci�n ASM: ";
            if( compilador is CompiladorC )
                mensaje = "Error de compilaci�n C: ";
            if( mensaje==string.Empty )
                mensaje = "Error en enlace: ";
            mensaje += "\nComando: " + comando;
            mensaje += "\nDescripci�n: \n" + descripcion + "\n\n";

            return mensaje;
        }
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
            //%10.2f Para los float 10 digitos, 2 de precision
            string salida = 
                "printf( \"El valor del parametro " + variable + ":%d es distinto al valor esperado: " + valorEsperado +
                    "\", "+ variable + ");";
            salida += "\nprintf( \"\\nDiferencia: %d \", " + variable + "-" + valorEsperado + " );";
            return salida;
        }
        
        public static string PrintfValorDistintoCadena( string variable, string valorEsperado, int i )
        {
            return
                "printf( \"El valor de la cadena " + variable + ": de la posicion " + i +
                    " %i es distinto al valor esperado: " + valorEsperado + "\", " + valorEsperado + " );";
        }
        public static string PrintfPruebaConcluida()
        {
            return "printf( \"\\nLa prueba ha concluido con %d errores\", cantErrores ); ";
        } 
    }
}