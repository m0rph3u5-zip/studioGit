using System;

namespace Strutture
{
    public class MyClass {
        public string MyString;
        public int MyInteger;
    }

    public struct MyStruct {
        public string MyString;
        public int MyInteger;
    }

    class Program
    {
        static void ClassMethod(MyClass mc, MyStruct ms, int intValue, string strValue){
            mc.MyInteger = intValue;
            mc.MyString = strValue;
            ms.MyInteger = intValue;
            ms.MyString = strValue;
        }
        static void Main(string[] args)
        {
            MyStruct myMS;
            myMS.MyInteger = 1;
            myMS.MyString = "stringa 1";
            Console.WriteLine($"Struttura: {myMS.MyInteger}; {myMS.MyString}");

            MyClass myMC = new MyClass(){
                MyInteger = 1,
                MyString = "stringa 1"
            };
            Console.WriteLine($"Classe: {myMC.MyInteger}; {myMC.MyString}");

            ClassMethod(myMC,myMS,2,"stringa 2");

            Console.WriteLine($"Struttura: {myMS.MyInteger}; {myMS.MyString}");
            Console.WriteLine($"Classe: {myMC.MyInteger}; {myMC.MyString}");

        }
    }
}
