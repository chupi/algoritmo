using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Alg
    {
        public void encontrar_dicotomica(int[] a, int k, int N, int v)
        {
            int i;
            if (k >= N)
            {
                if (a[k] == v)
                {
                    i = k;
                }
                else
                {
                    i = 1;
                }
            }
            else
            {
                int propi;
                propi = (k + N) / 2;
                if (a[propi] == v)
                {
                    i = propi;
                }
                else if (a[propi] > v)
                {
                    encontrar_dicotomica(a, k, propi - 1, v);
                }
                else
                {
                    encontrar_dicotomica(a, propi + 1, N, v);
                }
            }
        }
        public Int64 encontrar_inversion(int[] a, Int64 k, Int64 N, Int64 v)
        {
            Int64 i;
            if (k >= N)
            {
                if (a[k] == v)
                {
                    i = k;
                }
                else
                {
                    i = 1;
                }
            }
            else
            {
                Int64 propi;
                propi = (((N - k) * (v - a[k])) / (a[N] - a[k])) + k;
                if (a[propi] == v)
                {
                    i = propi;
                }
                else if (a[propi] > v)
                {
                    i = encontrar_inversion(a, k, propi - 1, v);
                }
                else
                {
                    i = encontrar_inversion(a, propi + 1, N, v);
                }
            }
            return (i);

        }
        public void mergeSort(int[] x, int[] xTemp, int izq, int der)
        {
            if (izq < der)
            {
                int medio = (izq + der) / 2;
                mergeSort(x, xTemp, izq, medio);
                mergeSort(x, xTemp, medio + 1, der);
                mezclar(x, xTemp, izq, medio + 1, der);
            }
        }
        public void mezclar(int[] x, int[] xAux, int posIzq, int posDer, int posFin)
        {
            int finIzq = posDer - 1;
            int posAux = posIzq;
            int numElementos = posFin - posIzq + 1;
            // Bucle principal
            while (posIzq <= finIzq && posDer <= posFin)
                if (x[posIzq] < x[posDer])
                    xAux[posAux++] = x[posIzq++];
                else
                    xAux[posAux++] = x[posDer++];
            // Copiar el resto de la primera mitad
            while (posIzq <= finIzq)
                xAux[posAux++] = x[posIzq++];
            // Copiar el resto de la segunda mitad
            while (posDer <= posFin)
                xAux[posAux++] = x[posDer++];
            // Copiar el vector temporal en el original
            for (int i = 0; i < numElementos; i++, posFin--)
                x[posFin] = xAux[posFin];
        }
    }
}
