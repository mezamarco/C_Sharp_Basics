using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primitive variables
            bool flag = true;
            char myCh = 'a';
            int num = 2;
            double number = 23.55;
                
            int maxInt = int.MaxValue;
            string word = "Happy";

            Console.WriteLine("\nbool : " + sizeof(bool) + " bytes.");
            Console.WriteLine("char : " + sizeof(char) + " bytes.");
            Console.WriteLine("int : " + sizeof(int) + " bytes.");
            Console.WriteLine("double : " + sizeof(double) + " bytes.");
            int unicodeBytes = System.Text.ASCIIEncoding.Unicode.GetByteCount(word);
            int asciiBytes = System.Text.ASCIIEncoding.ASCII.GetByteCount(word);
            Console.WriteLine("string: \"Happy\"(UNICODE) : " + unicodeBytes + " bytes");
            Console.WriteLine("string: \"Happy\"(ASCII) : " + asciiBytes + " bytes\n\n");


            //var: the data type is automatically set by the compiler
            var name = "Marco";
            Console.WriteLine("Marco is of {0} data type", name.GetTypeCode());


            Console.WriteLine("\n\nMath.Abs(-2)  = " + Math.Abs(-2));
            Console.WriteLine("Math.Ceiling(1.6)  = " + Math.Ceiling(1.6) );
            Console.WriteLine("Math.Floor(1.6)  = " + Math.Floor(1.6) );


            Console.WriteLine("Math.Max(7,29)  = " + Math.Max(7,29) );
            Console.WriteLine("Math.Min(7,29)  = " + Math.Min(7,29) );
            Console.WriteLine("Math.Pow(2,8)  = " + Math.Pow(2,8) );


            //Random numbers
            Random rand = new Random();
            //Print out ten random numbers, range: [1,5]
            Console.WriteLine("\nPrinting ten random numbers: ");
            for (int i = 0; i < 10; i++) {
                int randVal = rand.Next(1, 6);
                Console.Write(randVal + "  ");
            }



            //We do have if else statements
            //We have ternary operators
            //We hae switch statements
            //(Make sure to always break in each case, except for the default case)
            //We have while loops
            //We have do while loops
            //We have for loops
            
            // == will only compare string primitive types
            // .Equals will compare strings and objects.


            //Stiring equality
            string one = "apple";
            string two = "apple";
            if (one.Equals(two))
                Console.WriteLine("\nEqual Strings\n\n");



            //for each loop 
            string myName = "Marco Meza";

            foreach (char ch in myName)
                Console.Write(ch);

            //Do we have an empty string
            Console.WriteLine("\nIs empty: " + String.IsNullOrEmpty(myName));
            Console.WriteLine("Length of string: " + myName.Length);


            //Useful string functions

            //Can we find: "co" in the given word, otherwise return -1.
            Console.WriteLine("Index of \"co\" : " + myName.IndexOf("co"));
            Console.WriteLine("Starts with: \"Mar\" : " + myName.StartsWith("Mar"));
            Console.WriteLine("Ends with: \"eza\" : " + myName.EndsWith("eza"));

            //If we need to trim whitespace from the word.
            string sentence = "\n\n    The apple is green     ";
            Console.WriteLine(sentence);
            Console.WriteLine("We need to trim the whitespace from the start and the end");
            string sent = sentence.Trim();
            Console.WriteLine(sent);
            //How do we get a substring of a string
            string sub = sent.Substring(4);
            Console.WriteLine("Get the substring starting at index 4:\n" + sub);

            //Format a string
            //Dollar sign
            //Decimal places(two zeros and two decimal places)(It will round)
            //Wildcard plus two decimal values
            //Thousand separator
            
	    
	    string fmtString = String.Format( "{0:c} {1:00.00} {2:#.00} {3:0,0}"
			    		      , 23.44, 15.567, .56, 1000000);
            Console.WriteLine(fmtString);

            //Note: When we create a string we have an additional string in memory
            //String builder will allow us to edit a string, without creating another string in memory.

            StringBuilder sb = new StringBuilder();

            sb.Append("First sentence. ");
            sb.AppendFormat("My name is {0}." , "Marco");
            Console.WriteLine("\n" + sb);
            //Or
            Console.WriteLine(sb.ToString());









            //Arrays
            Console.WriteLine("\n\nWe are now dealing with arrays");
            int[] arr;
            arr = new int[2];

            arr[0] = 2;
            arr[1] = 3;

            int[] secArr = { 1, 2, 3, 4 };

            Console.WriteLine("Array Length:" + secArr.Length);
            for (int i = 0; i < secArr.Length; i++)
                Console.WriteLine("Index {0}: {1}", i, secArr[i]);


            Console.Write("\n\n");
            string[] strArr = new string[3] { "Bob", "Turtle", "Marco" };

            foreach (string s in strArr)
                Console.WriteLine(s);


            string tempString = String.Join(",", strArr);
            Console.WriteLine("\n\nstrArr :\n" +  tempString);
            //We can actually split the joined string
            string[] fifthArr = tempString.Split(',');
            foreach (string w in fifthArr)
                Console.WriteLine(w);


            //Find first index of the given element, otherwise return -1
            int[] thirdArr = { 3, 4, 3, 5, 6 };
            int indexVal = Array.IndexOf(thirdArr,5);

            Console.Write("\n\n");



            //Multidimensional array
            int[,] twoDimArr = new int[2, 3];
            twoDimArr[0, 0] = 5;
            twoDimArr[0, 1] = 10;
            twoDimArr[0, 2] = 100;
            twoDimArr[1, 0] = 15;
            twoDimArr[1, 1] =  20;
            twoDimArr[0, 2] = 200;


            //GetLenght(0): row size, GetLength(1): column size
            for (int i = 0; i < twoDimArr.GetLength(0); i++) {
                Console.Write("\n");
                for (int j = 0; j < twoDimArr.GetLength(1); j++) {
                    Console.Write(twoDimArr[i, j] + " ");
                }
            }
            Console.WriteLine("\n\n");

            int[,] secondTwoDimArr = { { 1,2,3,4,5},{6,7,8,9,10} };
            for (int i = 0; i < 2; i++) {
                Console.Write("\n");
                for (int j = 0; j < 5; j++) {
                    Console.Write(secondTwoDimArr[i,j] + " ");
                }
            }



            Console.WriteLine("\n\n");

            //String to int 
            int x = int.Parse("203");
            int y = 7;
            Console.WriteLine(x + y);
            //int to string
            string valString = Convert.ToString(y);
            Console.WriteLine(valString);



            //Try-catch-finally
            //finally : 
	    //The finally block allows you to execute certain code if an exception is thrown or not.

            try
            {
                Console.Write("Dividing 10 by: ");
                int theNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", theNumber, 10 / theNumber);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                

            }
            catch (Exception ex) {
                //This is the default exception
                //It will catch all the exceptions
                Console.WriteLine(ex.GetType().Name);

            }
            finally
            {
                Console.WriteLine("We have reached the finally block.");
            }



            //List
            //It is equivalent to an arraylist
            //Doubles the size of an array when it is full 
	    //and then copy all the element into this new array
            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            foreach (int currNum in myList)
                Console.WriteLine(currNum);

            for (int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);

            //Remove a specific element
            myList.Remove(20);
            for (int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);
            //Remove an element at index
            myList.Add(40);
            myList.Add(50);
            myList.Add(60);
            
            myList.RemoveAt(3);
            //This should remove the element 50
            for (int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);


            //Do we have a 60 in our List?
            bool sixtyFlag = myList.Contains(60);
            Console.WriteLine("60 appears in the List: " + sixtyFlag);



            //Stack and Queues
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i <= 10; i++) {
                myQueue.Enqueue(i);
                myStack.Push(i);

            }

            Console.WriteLine("Printing Queue:");
            while (myQueue.Count != 0) {
                int qVal = myQueue.Dequeue();
                Console.Write(qVal + " ");
            }

            Console.WriteLine("\nPrinting Stack:");
            while (myStack.Count != 0) {
                int stackVal = myStack.Pop();
                Console.Write(stackVal + " ");
            }

            //NO priority queue in C#

            Console.WriteLine("\n\n");


            //An unoredered map or hashMap in C# is a Dictionary in C#

            Dictionary<int, string> myMap = new Dictionary<int, string>();

            myMap.Add(2, "Car");
            myMap.Add(4, "Turtle");
            myMap.Add(6, "Frog");
            myMap.Add(8, "Dog");



            //Using a for loop essentially we are dealing with a pair
            //to traverse through all the elements in the myMap
            foreach(KeyValuePair<int, string> item in myMap) {
                Console.WriteLine("key:{0} and Value:{1}", item.Key, item.Value);
            }


            //How for traverse a dictionary using a for loop
            for (int i = 0; i < myMap.Count; i++) {
                Console.WriteLine("Key:{0} and Value:{1}"
				  ,myMap.Keys.ElementAt(i),myMap[myMap.Keys.ElementAt(i)]);
            }

            //Does it containg a specific key? O(1) runtime
            Console.WriteLine( "Does the map contain the key: 2 -> " + myMap.ContainsKey(2));
            Console.WriteLine("Does the map contain the key: 99 -> " + myMap.ContainsKey(99));

            Console.WriteLine("Does the map contain the value: \"Frog\" -> " 
			    	+ myMap.ContainsValue("Frog"));
            Console.WriteLine("Does the map contain the value: \"Cat\" -> " 
			    	+ myMap.ContainsValue("Cat"));


            Console.Write("\n\n");




            //In the case where you need sorting then use SortedSet<T>.
            //Otherwise if you don't, 
	    //then use HashSet<T> since it's O(1) for search and manipulate operations.

            //Whereas SortedSet<T> is O(log n) for search and manipulate operations.
            //SortedSet is essentially a balance binary tree
            //Two Properties: Ascending order and no repeated elements

            SortedSet<int> mySet = new SortedSet<int>();

            mySet.Add(8);
            mySet.Add(3);
            mySet.Add(8);
            mySet.Add(8);
            mySet.Add(2);
            mySet.Add(6);
            mySet.Add(4);

            foreach (int numb in mySet)
                Console.WriteLine(numb);

            Console.Write("\n\n");

            
            //Manipulating bits

            //Print the given bits of the following number
            int theMainNum = 2432532;
            string bitAnswer = "";
            for (int i = (sizeof(int) * 8) - 1; i >= 0; i--) {

                int tempNum = theMainNum & (1 << i);

                if (tempNum == 0)
                    bitAnswer = bitAnswer + '0';
                else
                    bitAnswer = bitAnswer + "1";
            }

            Console.WriteLine(bitAnswer);


            Console.ReadKey();




        }
    }
}


