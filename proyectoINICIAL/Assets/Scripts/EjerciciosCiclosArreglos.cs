using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    void Start()
    {
        // ============================================
        // EJERCICIO 1: Dos arreglos con Random.Range
        // y un tercero con la suma de ambos
        // ============================================
        int tamano = 5;
        int[] arr1 = new int[tamano];
        int[] arr2 = new int[tamano];
        int[] arr3 = new int[tamano];

        for (int i = 0; i < tamano; i++)
        {
            arr1[i] = Random.Range(0, 100);
            arr2[i] = Random.Range(0, 100);
            arr3[i] = arr1[i] + arr2[i];

            Debug.Log($"arr1[{i}]={arr1[i]} + arr2[{i}]={arr2[i]} = arr3[{i}]={arr3[i]}");
        }

        // ============================================
        // EJERCICIO 2: Arreglo de strings con foreach
        // ============================================
        string[] palabras = { "El", "perro", "corre", "por", "el", "parque" };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log("Oración completa: " + oracion.Trim());

        // ============================================
        // EJERCICIO 3: Multiplicación Matriz 2x2 * Vector 2x1
        // A × B = resultado
        // | a11 a12 |   | b1 |   | a11*b1 + a12*b2 |
        // | a21 a22 | × | b2 | = | a21*b1 + a22*b2 |
        // ============================================

        // Matriz A (2 renglones, 2 columnas)
        int[,] A = new int[2, 2]
        {
            { 1, 2 },
            { 3, 4 }
        };

        // Vector B (2 elementos)
        int[] B = new int[2] { 5, 6 };

        // Resultado: vector unidimensional de 2 elementos
        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++)
        {
            resultado[i] = 0;
            for (int j = 0; j < 2; j++)
            {
                resultado[i] += A[i, j] * B[j];
            }
        }

        // Imprime la operación completa
        Debug.Log("=== Multiplicación Matriz x Vector ===");
        Debug.Log($"A = | {A[0, 0]} {A[0, 1]} |   B = | {B[0]} |");
        Debug.Log($"    | {A[1, 0]} {A[1, 1]} |       | {B[1]} |");
        Debug.Log("---");
        Debug.Log($"resultado[0] = {A[0, 0]}*{B[0]} + {A[0, 1]}*{B[1]} = {resultado[0]}");
        Debug.Log($"resultado[1] = {A[1, 0]}*{B[0]} + {A[1, 1]}*{B[1]} = {resultado[1]}");
        Debug.Log($"Resultado = | {resultado[0]} |");
        Debug.Log($"            | {resultado[1]} |");
    }
}