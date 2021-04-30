using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputValues = true;
            short total = 0;
            byte totalCalifications = 0;
            while (inputValues == true)
            {
                sbyte calification = 0;
                bool valueOk = false;
                do
                {
                    Console.WriteLine("Introduzca la nota: ");
                    calification = Convert.ToSByte(Console.ReadLine());
                    if (calification == -1)
                    {
                        Console.WriteLine("Se ha dejado de introducir notas");
                        valueOk = true;
                    }
                    else if (calification <= 0 || calification >= 10)
                    {
                        Console.WriteLine("El valor tiene que estar entre 0 y 10");
                    }
                    else
                    {
                        Console.WriteLine("Valor almacenado correctamente");
                        valueOk = true;
                    }
                } while (!valueOk);
                if (calification == -1f)
                {
                    inputValues = !inputValues;
                }
                else
                {
                    total += calification;
                    totalCalifications++;
                }

            }

            if (totalCalifications > 0)
            {
                float average = (float)total / totalCalifications;
                Console.WriteLine("La media es " + average);
                return;
            }
            Console.WriteLine("No se ha introducido ninguna nota");

        }
    }
}
