using System.IO;

namespace TUAssembler.Auxiliares
{
    public class EscritorC: StreamWriter
    {
        #region Variables miembro
        private int identacion;
        private bool identacionActiva;
        #endregion

        #region Constructores
        public EscritorC( string path )
            : base( path )
        {
            identacion = 0;
        }
        #endregion

        #region M�todos
        public bool IdentacionActiva
        {
            get
            {
                return identacionActiva;
            }
            set
            {
                identacionActiva = value;
            }
        }

        private string Espacios()
        {
            int i = 0;
            string espacios = string.Empty;
            if( IdentacionActiva )
                while( identacion > i )
                {
                    espacios += "\t";
                    i++;
                }

            return espacios;
        }

        #region Escritura general
        public void EntreCorchetes( string valor )
        {
            WriteLine( "{" );
            identacion ++;
            WriteLine( valor );
            identacion --;
            WriteLine( "}" );
        }
        public void EntreCorchetes( params string[] lineas )
        {
            WriteLine( "{" );
            identacion++;
            foreach( string linea in lineas )
                WriteLine( linea );
            identacion--;
            WriteLine( "}" );
        }
        public override void WriteLine( string valor )
        {
            valor = Espacios() + valor;
            base.WriteLine( valor );
        }
        #endregion

        #region Instrucciones
        public void AbrirCorchetes()
        {
            WriteLine( "{" );
            identacion++;
        }
        public void CerrarCorchetes()
        {
            identacion--;
            WriteLine( "}" );
        }
        public void If( string condicion )
        {
            WriteLine( "if( " + condicion + " )" );
            AbrirCorchetes();
        }
        public void FinIf()
        {
            CerrarCorchetes();
        }
        public void For( string inicializacion, string condicion, string asignacion )
        {
            WriteLine( "for( " + inicializacion + "; " + condicion + "; " + asignacion + " )" );
            AbrirCorchetes();
        }
        public void FinFor()
        {
            CerrarCorchetes();
        }
        #endregion

        #region PrintF
        public void PrintfPruebaConcluida()
        {
            Printf( "La prueba " + Mensajes.NombreDePrueba + " ha concluido con %d errores", "cantErrores" );
        }
        /*        public void PrintfValorDistintoVector(string nombreVector, string valorEsperado, int posicion)
        {
            string texto = "Prueba " + Mensajes.NombreDePrueba + ": El valor del vector " + nombreVector +
                " en la posicion " +
                    posicion +
                        ": %i es distinto al valor esperado: " + valorEsperado;
            string variable = nombreVector + "[" + posicion +
                "]";
            Printf(texto, variable);
        }
 * */
        public void PrintfValorDistinto( string variable, string valorEsperado )
        {
            //%10.2f Para los float 10 digitos, 2 de precision
            Printf(
                "Prueba " + Mensajes.NombreDePrueba + ": El valor del parametro/elemento " + variable +
                    ":%d es distinto al valor esperado: " + valorEsperado, variable );
        }
        public void PrintfValorDistintoConDiferencia( string variable, string valorEsperado, string varDiferencia )
        {
            PrintfValorDistinto( variable, valorEsperado );
            Printf( "\\nDiferencia: %d", varDiferencia );
        }
        public void PrintfValorDistintoConDiferencia( string variable, string valorEsperado )
        {
            PrintfValorDistinto( variable, valorEsperado );
            Printf( "\\nDiferencia: %d", variable + " - " + valorEsperado );
        }
        public void PrintfEscrituraFueraDelBuffer( string nombreVariable )
        {
            string texto = "Prueba " + Mensajes.NombreDePrueba + ": Se ha escrito fuera del buffer en el par�metro " +
                nombreVariable;

            Printf( texto );
        }
        public void CambioDeDireccionDelPuntero( string nombreVariable )
        {
            string texto = "Prueba " + Mensajes.NombreDePrueba + ": Se ha cambiado la direcci�n del par�metro " +
                nombreVariable + " por una direcci�n inv�lida.";

            Printf( texto );
        }
        public void Printf( string texto, params string[] variables )
        {
            Write( Espacios() );
            Write( "printf( \"" + texto + "\"" );
            foreach( string variable in variables )
                Write( " ," + variable );
            Write( " );" );
            WriteLine();
        }
        #endregion

        #endregion
    }
}