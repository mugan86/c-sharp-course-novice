using System;

namespace ExceptionObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string studentObject = "Anartz";
                int age = -1;
                if (studentObject == null) {
                    throw new Exception("El objeto del estudiante no tiene información. Procura añadirla");
                }
                if (age < 0) {
                    throw new Exception("La edad no es correcta, no puede ser negativa");
                }
                Console.WriteLine("Información del estudiante: {0}", studentObject);
                Console.WriteLine("Edad del estudiante: {0}", age);
            } catch (Exception ex) {
                Console.WriteLine("Excepción general {0}", ex);
            }
        }
    }
}
