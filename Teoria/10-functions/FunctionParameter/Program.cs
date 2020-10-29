using System;

namespace FunctionParameter
{
    class Program
    {
        static void HelloProgram(string name) {
            Console.WriteLine("Hello With parameter: {0}", name);
        }
        static void HelloProgramInt(int numberValue) {
            Console.WriteLine("Hello With parameter (number): {0}", numberValue);
        }
        static void DefaultParamValue(int numberValue = -1) {
            Console.WriteLine("Hello With default parameter (number): {0}", numberValue);
        }
        static void MultipleParams(string name = "Master Devs", int iterations = 10) {
            int i = 0;
            while(i < iterations) {
                Console.WriteLine("Hello {0}", name);
                i++;
            }
        }

        static int ReturnInt() {
            return -1;
        }

        static int Plus(int x = 0, int y = 0) {
            return x + y ;
        }
         static string [] ListShop() {
            return new string []{"Game Tomb Raider", "Ps5", "Mando"};
        }

        static bool isMultipleTwo(int value = 2) {
            /*if (value % 2 == 0) {
                return true;
            }
            return false;*/
            return (value % 2 == 0) ? true : false;
        }
        public static void Main (string[] args) {
            Console.WriteLine ("Hello World");
            /*HelloProgram("Anartz");
            HelloProgramInt(34);
            DefaultParamValue();
            MultipleParams(iterations: 4, name: "Anartz Mugika Ledo");
            MultipleParams(iterations: 3);
            MultipleParams(name: "Curso de C# con los métodos", iterations: 2);*/
            int valueReturn = ReturnInt();
            Console.WriteLine("ReturnInt : {0}", valueReturn);
            int plusResult = Plus(45, 789); // 834
            Console.WriteLine("Plus => 45 + 789 = {0}", plusResult);
            string [] list = ListShop();
            bool isMultiple = isMultipleTwo(4);
            bool isMultipleT = isMultipleTwo(-1);
        }
    }
}
