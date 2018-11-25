using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace moreBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 9;

            int ans = addVals(x, y);

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            multByFIveArray(arr);

            foreach (int num in arr)
                Console.WriteLine(num);


            //ref keyword (Use when variable is not null) 
            //out keyword (Use when varible is null)
            int valOne = 3;
            modifyFunct(ref valOne);
            Console.WriteLine(valOne);



            int emptyNum;
            assignFunct(out emptyNum);
            Console.WriteLine(emptyNum);


            Console.WriteLine("\n\n");


            //Input and Output
            int a;
            int b;
            int c;
            string word;

            Console.Write("Enter favNum(0): ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter favNum(1): ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter favNum(2): ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter favWord: ");
            word = Console.ReadLine();
            Console.WriteLine("\n\n\n");


            //using System.IO;
            //Reading and writing to a file

            //Get the path to the file
            //Use @ to ignore escape character 
            string filePath = @"C:\Users\Marco Meza\Desktop\testing.txt";

            //It is easier to deal with List when reading a file
            List<string> singleLineList = File.ReadAllLines(filePath).ToList();

            foreach (string currLine in singleLineList)
                Console.WriteLine(currLine);

            //We have read the entire text of the file
            //How do we append to the given input file
            //simply add your input in to the list
            singleLineList.Add("HELLO MARCO");

            //Place the modified list into the text file
            File.WriteAllLines(filePath, singleLineList);
            Console.WriteLine("\n\n\n");



            //Reading and writing to a file character by character
            //We need a StreamReader object to read our characters one by one
            string filePathTwo = @"C:\Users\Marco Meza\Desktop\testingTwo.txt";
            StreamReader myReader = new StreamReader(filePathTwo);


            Console.WriteLine("\n\n\nWe will now read a file character by character:");

            while (!myReader.EndOfStream) {
                char ch = (char)myReader.Read();
                Console.Write(ch);
            }
            myReader.Close();
            //We have read the entire file character by character
            //Now we have to write input to a file character by character.

            string tempSentence = "Hola Nenau.";

            /*   This will overwrite the file, this will not apppend to the file
            StreamWriter myWriter = new StreamWriter(filePathTwo);
            for (int i = 0; i < tempSentence.Length; i++) 
                myWriter.Write(tempSentence[i]);
             */


            StreamWriter myWriter = new StreamWriter(filePathTwo, append: true);
            myWriter.WriteLine();
            for (int i = 0; i < tempSentence.Length; i++)
                myWriter.Write(tempSentence[i]);

            myWriter.Close();


            Console.WriteLine("\n\n");

            //Assing a primitive to a primitive, we get a copy
            //Assing a object to an object, we get a reference
            int[] theFirstArr = new int[2];
            theFirstArr[0] = 5;
            theFirstArr[1] = 10;

            //Make a copy of the first array
            //Note any changes done to this second array will be reflected also the first array.
            //We have a reference to the first array.
            int[] secArr = theFirstArr;
            secArr[0] = 100;
            secArr[1] = 200;
               
            for (int i = 0; i <  theFirstArr.Length; i++) {
                Console.WriteLine( theFirstArr[i]);
            }
            
            Console.WriteLine("\n");

            

            //By default when assigning an object to another object we have a shallow copy
            //Therefore if we want a deep copy we have to work will a copy constructor

     




            //This line will run slow
            //Console.WriteLine(person.name + person.email);
            //A more optimized way t run this line
            //Console.WriteLine($"{person.name} {person.email}");
            Console.ReadKey();

        }




        //Primitive variables: pass by value
        //Objects: pass by reference.
        static int addVals(int x, int y)
        {
            return x + y;
        }


        //Pass by reference example
        static void multByFIveArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = arr[i] * 5;
            }
        }

        //Using the ref keyword example
        static void modifyFunct(ref int val) {
            val = 100;
        }

        //Using the out keyword example (Note we take an empty int argument)
        static void assignFunct(out int data) {
            data = 50;
        }


    }
}

