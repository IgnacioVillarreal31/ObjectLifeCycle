//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i=0;i<100000;i++)
            {
                new Train("Prueba");
            }
            // Lo que hace el lenguaje es borrar los objetos que no se usan cada cierto valor para liberar espacio en la memoria, entonces cuando creas muchas instancias de clase como 100000 lo que hace c# es borrar algunas de estas.
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine($"t1==t2 {t1==t2},t2==t3 {t2==t3}");
        // Lo que ocurre es que t1, t2 y t3 son instancias de la clase distintas por lo que ocupan diferentes espacios en la memoria, aunque se pasen como parametro los mismos valotes, no son los mismos objetos
        }
    }
}
