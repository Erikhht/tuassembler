﻿
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Regla
    {
        #region Variables de instancia
        private int bien, regular;
        private int n0, n1, n2, n3;
        #endregion

        #region Constructores
        public Regla(int n0, int n1, int n2, int n3, int bien, int regular)
        {
            this.bien = bien;
            this.n0 = n0;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.regular = regular;
        }
        #endregion

        #region Propiedades
        public NumeroGenerado Numero
        {
            get
            {
                return new NumeroGenerado(n0, n1, n2, n3);
            }
        }
        #endregion

        #region Métodos
        public List<NumeroGenerado> Generar()
        {
            var lista = new List<NumeroGenerado>();
            switch (bien)
            {
                case 0:
                    switch (regular)
                    {
                        case 0:
                            lista = NumeroGenerado.GenerarComplementos(new List<int> { n0, n1, n2, n3 });
                            break;
                        case 1:
                            lista.Add(new NumeroGenerado(null, n0, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n3, null, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 2:
                            lista.Add(new NumeroGenerado(n1, n0, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n1, null, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n0, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n0, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n0, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n1, null, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n1, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n3, n0, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n1, n2, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n2, null, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n1, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n2, null, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n3, n1, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n2, n3, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n3, n2, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n3, null, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 3:
                            ///0 1 y 2                                                                      
                            lista.Add(new NumeroGenerado(null, n0, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n0, null, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n1, n2, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n0, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n0, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n0, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n2, n1, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n1, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n2, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, null, n0, new List<int> { n0, n1, n2, n3 }));

                            ///0 2 y 3                                                                      
                            lista.Add(new NumeroGenerado(null, n0, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, n3, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, null, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n3, n2, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n3, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n0, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n0, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n2, n3, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n3, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n3, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n2, null, n0, new List<int> { n0, n1, n2, n3 }));

                            ///1 2 y 3                                                                      
                            lista.Add(new NumeroGenerado(n1, null, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n2, n3, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, null, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n3, n2, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n3, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n1, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n2, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n3, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n2, null, n1, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 4:
                            lista.Add(new NumeroGenerado(n1, n2, n3, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n0, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, n0, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n2, n3, n1, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n2, n1, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, n1, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n2, n0, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n3, n0, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n2, n0, n1, new List<int> { n0, n1, n2, n3 }));
                            break;
                    }
                    break;
                case 1:
                    switch (regular)
                    {
                        case 0:
                            lista.Add(new NumeroGenerado(n0, null, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, null, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 1:
                            lista.Add(new NumeroGenerado(n0, null, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n2, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n1, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n0, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n2, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n0, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, null, n3, new List<int> { n0, n1, n2, n3 }));

                            break;
                        case 2:
                            lista.Add(new NumeroGenerado(n0, n2, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n2, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, n1, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, null, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n2, n3, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n3, n2, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n1, n0, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, n0, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, null, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n3, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, n3, null, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(n1, n0, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n3, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, null, n2, n1, new List<int> { n0, n1, n2, n3 }));

                            lista.Add(new NumeroGenerado(null, n0, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n0, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n2, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, null, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n2, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 3:
                            lista.Add(new NumeroGenerado(n0, n2, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, n1, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, n3, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n3, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n0, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n2, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n0, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                    }
                    break;
                case 2:
                    switch (regular)
                    {
                        case 0:
                            lista.Add(new NumeroGenerado(n0, n1, null, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, null, n2, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 1:
                            lista.Add(new NumeroGenerado(n0, n1, n3, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n1, null, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n2, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, null, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, n2, null, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n1, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, null, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, null, n2, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(null, n0, n2, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                        case 2:
                            lista.Add(new NumeroGenerado(n0, n1, n3, n2, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n3, n2, n1, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n0, n2, n1, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n3, n1, n2, n0, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n2, n1, n0, n3, new List<int> { n0, n1, n2, n3 }));
                            lista.Add(new NumeroGenerado(n1, n0, n2, n3, new List<int> { n0, n1, n2, n3 }));
                            break;
                    }
                    break;
                case 3:
                    lista.Add(new NumeroGenerado(null, n1, n2, n3, new List<int> { n0, n1, n2, n3 }));
                    lista.Add(new NumeroGenerado(n0, null, n2, n3, new List<int> { n0, n1, n2, n3 }));
                    lista.Add(new NumeroGenerado(n0, n1, null, n3, new List<int> { n0, n1, n2, n3 }));
                    lista.Add(new NumeroGenerado(n0, n1, n2, null, new List<int> { n0, n1, n2, n3 }));
                    break;
                case 4:
                    lista.Add(new NumeroGenerado(n0, n1, n2, n3, new List<int> { n0, n1, n2, n3 }));
                    break;
            }
            return lista;
            //for(var i=0; i<4-bien;i++)
            //{
            //    for(var j=i+1; j<4-bien-1;j++)
            //    {

            //    }
            //    var num = new Numero();
            //    num[i] = n[i];
            //}
        }
        public override string ToString()
        {
            return n0 + n1.ToString() + n2 + n3 + " " + bien + "B " + regular + "R";
        }
        #endregion
    }

}
