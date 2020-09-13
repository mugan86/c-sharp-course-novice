using System;

namespace StringConcatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenación - Operador sumar");
            int x = 10, y = 29;
            string helloMessage = "Hola!";
            string result = "";

            result = Convert.ToString(x + y); // "39" => OBJ : "1029"
            result = Convert.ToString(x) + y; // "1029"
            result = x + "" + y; // "1029"

            result = helloMessage + " " + x; // "Hola! 10"

            Console.WriteLine("Concatenación - Función Concat");

            string name = "Anartz", lastname = "Mugika Ledo";
            // Concatenar name y lastname
            result = String.Concat(name, lastname); // "AnartzMugika Ledo"
            // Separando el nombre y el apellido
            result = String.Concat(name, " ", lastname); // "Anartz Mugika Ledo"
            /*int x = 10, y = 29;
            string helloMessage = "Hola!";*/
            // Concatenamos muchos valores
            result = String.Concat(name, " ", lastname, x, y, helloMessage); 
            // "Anartz Mugika Ledo1029Hola!"
            result = String.Concat(name, " ", lastname, " ",  x, y, " ", helloMessage); 
            // "Anartz Mugika Ledo 1029 Hola!"
            Console.WriteLine("Concatenación - Función Format");
            result = String.Format("Mi nombre de pila es {0}", name); // "Mi nombre de pila es Anartz" 
            result = String.Format("Mi nombre de pila es {0} y mis apellidos son {1}", name, lastname); 
            // "Mi nombre de pila es Anartz y mis apellidos son Mugika Ledo"
            result = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", 1, 2, 3, 4, 5, 6, 7, 8);
            // "1, 2, 3, 4, 5, 6, 7, 8"

            Console.WriteLine("Concatenación - String Interpolation");
            int age = 34;
            string fullName = $"{name} {lastname}"; // "Anartz Mugika Ledo
            result = $"Yo soy {fullName} y tengo {age} años.";
        }
    }
}
