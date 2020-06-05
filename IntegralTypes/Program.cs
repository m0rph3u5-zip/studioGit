using System;

namespace IntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // variabili, tipi e onversioni
            int a = 500;
            short b = 100;
            sbyte c = -50;
            long d = 100_000_000L;
            int e = 0b10101010;
            ushort f = 0x0A56;
            float g = 10.51458f;
            double h = 5.75d;
            decimal i = 1500.545645m;
            bool l = true;
            string m = "Ciao come stai?";
            var demo = 5+10*9;
            var demob = (10*50)*8;
            a++;
            a = demo + ++a;
            
            Console.WriteLine(demo+" "+demob);
            Console.WriteLine($"a={a}, b={b}, c={c}, d={d}, e={e}, f={f}, g={g}, h={h}, i={i}, l={l}, m={m}");
    
            int test = 5 + (int)h;
            Console.WriteLine(test);

            var testS = Convert.ToString(demo);
            Console.WriteLine(test);

            int x = 10;
            double y = x;
            float x1 = 12000;
            int y1 = (int)x1;

            int y2 = y1++;

            int x2 = Convert.ToInt32("1234");

            Console.WriteLine(x+" "+y+" "+x1+" "+y1+" "+y2+" "+x2);
            */

            /*
            // Condizioni
            const int Caldo = 24, Freddo = 26;
            int t = 17;
            var result = "";
            if (t > Caldo) {
                result = "fa caldo";
            } else if (t < Freddo) {
                result = "fa freddo";
            } else {
                result = "si sta bene";
            }
            Console.WriteLine(result);

            string msg = t >= Caldo ? "fa caldo" : "non fa caldo";
            Console.WriteLine(msg);
            */

            /* 
            // Condizioni
            Console.Write("scrivi il tuo valore: ");
            string s = Console.ReadLine();
            switch(s){
                case "primo":
                    Console.WriteLine("hai scritto primo");
                    break;
                case "secondo":
                    Console.WriteLine("hai scritto secondo");
                    break;
                default:
                    Console.WriteLine($"hai scritto: {s}");
                    break;
            }
            */

            // Cicli
            /*
            int number = 0;
            while(number < 10){
                number++;
                Console.WriteLine(number);
            }
            */
            /*
            int number1 = 0;
            do {
                number1++;
                Console.WriteLine(number1);
            } while (number1 > 0 && number1 < 10);
            */
            /*
            for(var x = 0; x < 11; x++){
                if (x == 5)
                    continue;
                Console.WriteLine(x);
            }
            */
            /*
            const string crt = "* ";
            int righe = 0;
            while(true){
                Console.WriteLine("indica un numero ('no' per uscire dal programma)");
                string s = Console.ReadLine();

                if (s == "no"){
                    Console.WriteLine("Ciao. il programma è finito");
                    break;
                }

                righe = Convert.ToInt32(s);
                for (var i = 1; i <= righe; i++) {
                    for(var r=1; r <= i; r++){
                        Console.Write(crt);
                    }
                    Console.WriteLine("\n");
                }
            }
            */

            /*
            string[] lista = new string[10];
            for(int i=0; i <= 9; i++){
                lista[i] = "Spazio: "+Convert.ToString(i);
                Console.WriteLine(lista[i]);
            }
            */

            /*
            int [,] a = new int [3,3];
            int [] x = new int[10] {1,15,20,2,6,5,4,7,8,9};
            foreach (int valore_x in x) {
                Console.Write(valore_x+" ");
            }
            */

            /*
            int[,] MyArr = new int[5,5];

            var count = 0;
            for (int i = 0; i <= 4; i++){
                for (int j = 0; j <= 4; j++){
                    count++;
                    MyArr[i,j] = (j==0) ? 0 : count;
                }
            }

             for (int i = 0; i <= 4; i++){
                for (int j = 0; j <= 4; j++){
                    if (MyArr[i,j] <= 9 && MyArr[i,j] != 0)
                        Console.Write($"0{MyArr[i,j]} ");
                    else
                        Console.Write($"{MyArr[i,j]} ");
                    if (j==4)
                        Console.Write("\n");
                }
            }
            */

            string type = Console.ReadLine();
            if (type == "testo"){
                string input = Console.ReadLine();
                string test = Test(input);
                Console.WriteLine($"hai scritto: {test}");
            } else {
                int input_n = Convert.ToInt32(Console.ReadLine());
                int test_n = Test(input_n);
                Console.WriteLine($"hai scritto: {test_n}");
            }
        }

        // overload
        static string Test(string valore){
            return valore;
        } 

        // overload 
        static int Test(int valore){
            return valore;
        }
    }
}
