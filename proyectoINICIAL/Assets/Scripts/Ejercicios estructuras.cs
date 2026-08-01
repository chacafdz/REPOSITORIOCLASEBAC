using System;
using System.Collections.Generic;
using System.Linq;

public class EjerciciosEstructuras
{
    // 1) Lista de números aleatorios de un tamaño y rango dados
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();
        Random rnd = new Random();

        for (int i = 0; i < tamaño; i++)
        {
            // rangoSuperior + 1 porque Random.Next es exclusivo en el límite superior
            numeros.Add(rnd.Next(rangoInferior, rangoSuperior + 1));
        }

        return numeros;
    }

    // 2) Ordenar un arreglo de enteros de manera descendente
    public int[] ordenarDescendente(int[] arreglo)
    {
        int[] copia = (int[])arreglo.Clone();
        Array.Sort(copia);
        Array.Reverse(copia);
        return copia;
    }

    // 3) Eliminar duplicados de una lista (números o strings) usando HashSet
    public HashSet<T> eliminarDuplicados<T>(List<T> lista)
    {
        // El constructor de HashSet ya elimina duplicados automáticamente
        HashSet<T> sinDuplicados = new HashSet<T>(lista);
        return sinDuplicados;
    }

    // 4) Pasar una pila de strings a una cola, imprimiendo en cada paso
    public void pilaAColaConImpresion(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        Console.WriteLine("--- Contenido de la Pila (orden LIFO con Pop) ---");
        while (pila.Count > 0)
        {
            // Peek para ver el valor antes de sacarlo, luego Pop para sacarlo y encolarlo
            string valor = pila.Peek();
            Console.WriteLine("Pop: " + valor);
            cola.Enqueue(pila.Pop());
        }

        Console.WriteLine("--- Contenido de la Cola (orden FIFO con Dequeue) ---");
        while (cola.Count > 0)
        {
            string valor = cola.Peek();
            Console.WriteLine("Dequeue: " + valor);
            cola.Dequeue();
        }
    }
}