using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

/*
 *      Jonathan Rojas Vargas    
 *      Fecha de inicio: 07/10/2014
 */

namespace ProyectoArqui
{
    public partial class Form1 : Form
    {
        public static int MAX = 200000; // Tamaño de la lista general
        public static int [] vectorOri = new int[MAX]; //Declaración de la lista Principal
        public static int[] vectorCop; // Declaración de la lista temporal
        // Declaración de listas donde se almacena partes de la lista temporal
        public static int[] lista1; 
        public static int[] lista2;
        public static int[] lista3;
        public static int[] lista4;
        
        // Variables y direcciones para obtener en nombre del sistema y el nombre del procesador
        public static String dir = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"; 
        public static RegistryKey key = Registry.LocalMachine.OpenSubKey(dir);
        public static String nombreProcesador = key.GetValue("ProcessorNameString").ToString();
        // Variable que contiene la cantidad de nucleos del procesador
        public static int numeroNucleos = Environment.ProcessorCount;

        /// <summary>
        /// Inicializa la ventana principal
        /// </summary>
        public Form1()
        {
            // Muestra informacion en labels en la ventana principal
            InitializeComponent();            
            numNucleos.Text = numeroNucleos.ToString();
            nombrePC.Text = SystemInformation.ComputerName;
            nombreProcesor.Text = nombreProcesador;
            // Metodo que genera la lista principal con numeros consecutivos de forma desordenada
            GenerarAleatorio();
            Random rnd = new Random();
            int num = rnd.Next(0, 99);
            mostrar.Text = num.ToString();
        }

        /// <summary>
        /// Genera lista principal con numeros consecutivos de manera desordenada
        /// </summary>
        static void GenerarAleatorio()
        {
            int i, numero, tam;
            int n = MAX;
            int[] aux = new int[MAX];

            //srand ( time(NULL) );
            Random rnd = new Random();
            for (i = 0; i < n; i++)
                aux[i] = i;

            tam = n;
            for (i = 0; i < n; i++)
            {
                numero = rnd.Next(0, 99);
                vectorOri[i] = aux[numero];
                aux[numero] = aux[tam - 1];
                tam--;
            }
        }

        /// <summary>
        /// Imprime la lista en el area de texto de la interfaz
        /// </summary>
        /// <param name="v"> Recive la lista a imprimir </param>
        public void imprimirVector(int[] v){

            string vectores = "";
            string list1 = "";
            string list2 = "";
            string list3 = "";
            string list4 = "";

            dividirLista(v);

            Parallel.Invoke(() =>
            {
                for (int i = 0; i < lista1.Length; i++)
                {
                    list1 = list1 + lista1[i] + ", ";
                }
            },
            () =>
            {
                for (int i = 0; i < lista2.Length; i++)
                {
                    list2 = list2 + lista2[i] + ", ";
                }
            },
            () =>
            {
                for (int i = 0; i < lista3.Length; i++)
                {
                    list3 = list3 + lista3[i] + ", ";
                }
            },
            () =>
            {
                for (int i = 0; i < lista4.Length; i++)
                {
                    list4 = list4 + lista4[i] + ", ";
                }
            });
            vectores = list1 + list2 + list3 + list4;
            this.Invoke((MethodInvoker)delegate
            {
                mostrar.Text = vectores;
            }); 
        }

        /// <summary>
        /// Toma una lista y la divide en 4 partes
        /// </summary>
        /// <param name="listaPrincipal"> Recive la lista a dividir </param>
        public void dividirLista(int[] lista){

            lista1 = new int[MAX / 4];
            lista2 = new int[MAX / 4];
            lista3 = new int[MAX / 4];
            lista4 = new int[MAX / 4];
            int pos1 = 0;
            int pos2 = 0;
            int pos3 = 0;
            int pos4 = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] < (MAX / 4))
                {
                    lista1[pos1] = lista[i];
                    pos1++;
                }
                else if ((lista[i] >= (MAX / 4)) && (lista[i] < (MAX / 2)))
                {
                    lista2[pos2] = lista[i];
                    pos2++;
                }
                else if ((lista[i] >= (MAX / 2)) && (lista[i] < ((MAX / 2) + (MAX / 4))))
                {
                    lista3[pos3] = lista[i];
                    pos3++;
                }
                else
                {
                    lista4[pos4] = lista[i];
                    pos4++;
                }
            }
        }

        /// <summary>
        /// Metodo que intercambia posisciones
        /// </summary>
        /// <param name="v"> Recive la lista a la que se desea realizar los cambios </param>
        /// <param name="primero"> Recive el numero que se va a cambiar por el segundo </param>
        /// <param name="segundo"> Recive el numero que se va a cambiar por el primero </param>
        public void swap(int[] v, int primero, int segundo)
        {
            int temp = v[primero];
            v[primero] = v[segundo];
            v[segundo] = temp;
        }

        /// <summary>
        /// Metodo ciclico paralelo que es llamado desde un Parallel.Invoke en el metodo algoritmoCiclicoParalelo();
        /// </summary>
        /// <param name="v"> Recive la lista a ordenar </param>
        public void algoritmoCiclicoParaleloAux(int[] v)
        {
            for (int i = v.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        swap(v, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo ciclico paralelo
        /// </summary>
        public void algoritmoCiclicoParalelo()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();

            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);
            dividirLista(vectorCop);
            int n = vectorCop.Length;

            Parallel.Invoke(() =>
            {
                algoritmoCiclicoParaleloAux(lista1);
            },
            () =>
            {
                algoritmoCiclicoParaleloAux(lista2);
            },
            () =>
            {
                algoritmoCiclicoParaleloAux(lista3);
            },
            () =>
            {
                algoritmoCiclicoParaleloAux(lista4);
            });


            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoParal.Text = tiempoAux.ToString() + " seg";
            });
            vectorCop = lista1.Union(lista2.Union(lista3.Union(lista4))).ToArray();
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo ciclico secuencial
        /// </summary>
        public void algoritmoCiclicoSecuencial()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();
            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);

            int n = vectorCop.Length;
            int i, j;
            
            for (i = n - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (vectorCop[j] > vectorCop[j + 1])
                    {
                        swap(vectorCop, j, j + 1);
                    }

                }
            }
            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoSecuen.Text = tiempoAux.ToString() + " seg";
            });
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo de ordenamiento paralelo que es llamado desde un Parallel.Invoke en el metodo algoritmoOrdenamientoParalelo();
        /// </summary>
        /// <param name="vect1"> Recive la lista que se desea ordenar </param>
        public void algoritmoOrdenamientoParaleloAux(int[] lista)
        {
            int pos_min, i_aux;

            for (int i = 0; i < lista.Length - 1; i++)
            {
                pos_min = i;
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[j] < lista[pos_min])
                        pos_min = j;
                }
                if (pos_min != i)
                {
                    i_aux = lista[i];
                    lista[i] = lista[pos_min];
                    lista[pos_min] = i_aux;
                }
            }
        }

        /// <summary>
        /// Metodo de ordenamiento paralelo
        /// </summary>
        public void algoritmoOrdenamientoParalelo()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();
            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);
            dividirLista(vectorCop);

            Parallel.Invoke(() =>
            {
                algoritmoOrdenamientoParaleloAux(lista1);
            },
            () =>
            {
                algoritmoOrdenamientoParaleloAux(lista2);
            },
            () =>
            {
                algoritmoOrdenamientoParaleloAux(lista3);
            },
            () =>
            {
                algoritmoOrdenamientoParaleloAux(lista4);
            });

            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoParal.Text = tiempoAux.ToString() + " seg";
            });
            vectorCop = lista1.Union(lista2.Union(lista3.Union(lista4))).ToArray();
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo de ordenamiento secuencial
        /// </summary>
        public void algoritmoOrdenamientoSecuencial()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();

            int i, j, pos_min;
            int i_aux;
            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);

            int n = vectorCop.Length;

            for (i = 0; i < n - 1; i++)
            {
                pos_min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (vectorCop[j] < vectorCop[pos_min])
                        pos_min = j;
                }
                if (pos_min != i)
                {
                    i_aux = vectorCop[i];
                    vectorCop[i] = vectorCop[pos_min];
                    vectorCop[pos_min] = i_aux;
                }
            }
            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoSecuen.Text = tiempoAux.ToString() + " seg";
            });
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo de ordenamiento recursivo que es llamado desde un Parallel.Invoke en el metodo algoritmoRecursivoParalelo(); 
        /// </summary>
        /// <param name="v"> Recive la lista a ordenar </param>
        /// <param name="izq"> Recive el inicio de la lista </param>
        /// <param name="der"> Recive el final de la lista </param>
        public void algoritmoRecursivoParaleloAux(int[] v, int izq, int der)
        {
            int aux;
            int i, j;
            int piv;

            piv = v[(izq + der) / 2];
            i = izq;
            j = der;

            while (i <= j)
            {
                while (v[i] < piv)
                {
                    i++;
                }

                while (v[j] > piv)
                {
                    j--;
                }
                if (i < j)
                {
                    aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    i++;
                    j--;
                }
                else
                    if (i == j)
                    {
                        i++;
                        j--;
                    }
            }

            if (izq < j)
            {
                algoritmoRecursivoParaleloAux(v, izq, j);
            }
            if (i < der)
            {
                algoritmoRecursivoParaleloAux(v, i, der);
            }
        }

        /// <summary>
        /// Metodo recursivo paralelo
        /// </summary>
        public void algoritmoRecursivoParalelo()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();
            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);
            dividirLista(vectorCop);

            Parallel.Invoke(() =>
            {
                algoritmoRecursivoParaleloAux(lista1, 0, lista1.Length - 1);
            },
            ()=> 
            {
                algoritmoRecursivoParaleloAux(lista2, 0, lista2.Length - 1);
            },
            ()=>
            {
                algoritmoRecursivoParaleloAux(lista3, 0, lista3.Length - 1);
            },
            ()=> 
            {
                algoritmoRecursivoParaleloAux(lista4, 0, lista4.Length - 1);
            });

            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoParal.Text = tiempoAux.ToString() + " seg";
            });

            vectorCop = lista1.Union(lista2.Union(lista3.Union(lista4))).ToArray();
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo de ornamiento secuencial que es llamado desde un Parallel.Invoke en el metodo algoritmoRecursivoSecuencial();
        /// </summary>
        /// <param name="v"> Recive lista a ordenar </param>
        /// <param name="izq"> Recive el inicio de la lista </param>
        /// <param name="der"> Recive el final de la lista </param>
        public void algoritmoRecursivoSecuencialAux(int[] v, int izq, int der)
        {
            int i, j;
            int aux, piv;

            piv = v[(izq + der) / 2];
            i = izq;
            j = der;

            while (i <= j)
            {
                while (v[i] < piv)
                {
                    i++;
                }
                while (v[j] > piv)
                {
                    j--;
                }
                if (i < j)
                {
                    aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    i++;
                    j--;
                }
                else
                    if (i == j)
                    {
                        i++;
                        j--;
                    }
            }

            if (izq < j)
            {
                algoritmoRecursivoSecuencialAux(v, izq, j);
            }

            if (i < der)
            {
                algoritmoRecursivoSecuencialAux(v, i, der);
            }
        } 

        /// <summary>
        /// Metodo recursivo secuencial
        /// </summary>
        public void algoritmoRecursivoSecuencial()
        {
            Stopwatch tiempo;
            float tiempoAux;
            tiempo = Stopwatch.StartNew();
            vectorCop = new int[MAX];
            vectorOri.CopyTo(vectorCop, 0);

            algoritmoRecursivoSecuencialAux(vectorCop, 0, vectorCop.Length - 1);

            tiempoAux = tiempo.ElapsedMilliseconds;
            tiempoAux = tiempoAux / 1000;
            this.Invoke((MethodInvoker)delegate
            {
                tiempoSecuen.Text = tiempoAux.ToString() + " seg";
            });  
            imprimirVector(vectorCop);
        }

        /// <summary>
        /// Metodo que verifica la seleccion del combobox y llama a ejecutar el algoritmo seleccionado
        /// </summary>
        public void ejecutarAlgoritmos()
        {
            int comboselect = 0;

            this.Invoke((MethodInvoker)delegate
            {
                comboselect = algoritmos.SelectedIndex;
            });

            if (comboselect == 0)
            {
                algoritmoCiclicoParalelo();
            }

            else if (comboselect == 1)
            {
                algoritmoCiclicoSecuencial();
            }

            else if (comboselect == 2)
            {
                algoritmoOrdenamientoParalelo();
            }

            else if (comboselect == 3)
            {
                algoritmoOrdenamientoSecuencial();
            }

            else if (comboselect == 4)
            {
                algoritmoRecursivoParalelo();
            }

            else if (comboselect == 5)
            {
                algoritmoRecursivoSecuencial();
            }
        }

        /// <summary>
        /// Boton de ejecutar llama al metodo ejecutarAlgoritmos(); de una forma que la interfaz no se congele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ejecutar_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(ejecutarAlgoritmos);
        }

        /// <summary>
        /// Metodo donde se estan ejecutando los progressBar de manera constante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numeroNucleos == 2)
            {
                procesador1.Value = (int)(performanceCounter1.NextValue());
                porcentaje1.Text = "Processor: " + procesador1.Value.ToString() + "%";

                procesador2.Value = (int)(performanceCounter2.NextValue());
                porcentaje2.Text = "Processor: " + procesador2.Value.ToString() + "%";
            }

            if (numeroNucleos == 4)
            {
                procesador1.Value = (int)(performanceCounter1.NextValue());
                porcentaje1.Text = "Processor: " + procesador1.Value.ToString() + "%";

                procesador2.Value = (int)(performanceCounter2.NextValue());
                porcentaje2.Text = "Processor: " + procesador2.Value.ToString() + "%";

                procesador3.Value = (int)(performanceCounter3.NextValue());
                porcentaje3.Text = "Processor: " + procesador3.Value.ToString() + "%";

                procesador4.Value = (int)(performanceCounter4.NextValue());
                porcentaje4.Text = "Processor: " + procesador4.Value.ToString() + "%";
            }
            else
            {
                procesador1.Value = (int)(performanceCounter1.NextValue());
                porcentaje1.Text = "Processor: " + procesador1.Value.ToString() + "%";

                procesador2.Value = (int)(performanceCounter2.NextValue());
                porcentaje2.Text = "Processor: " + procesador2.Value.ToString() + "%";

                procesador3.Value = (int)(performanceCounter3.NextValue());
                porcentaje3.Text = "Processor: " + procesador3.Value.ToString() + "%";

                procesador4.Value = (int)(performanceCounter4.NextValue());
                porcentaje4.Text = "Processor: " + procesador4.Value.ToString() + "%";

                procesador5.Value = (int)(performanceCounter5.NextValue());
                porcentaje5.Text = "Processor: " + procesador5.Value.ToString() + "%";

                procesador6.Value = (int)(performanceCounter6.NextValue());
                porcentaje6.Text = "Processor: " + procesador6.Value.ToString() + "%";

                procesador7.Value = (int)(performanceCounter7.NextValue());
                porcentaje7.Text = "Processor: " + procesador7.Value.ToString() + "%";

                procesador8.Value = (int)(performanceCounter8.NextValue());
                porcentaje8.Text = "Processor: " + procesador8.Value.ToString() + "%";
            }
        }
    }
}
