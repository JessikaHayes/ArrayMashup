using System;

namespace ArrayMashupSolutions {
    class Program {
        static void Main(string[] args) {
            int array0Size = PromptInt("How big should the 1st array be? ");
            int array1Size = PromptInt("How big should the 2nd array be? ");

            Console.WriteLine();

            int[] array0 = new int[array0Size];
            int[] array1 = new int[array1Size];

            Console.WriteLine("Fill the first Array");
            FillArray(array0, 8);

            Console.WriteLine();

            Console.WriteLine("Fill the second Array");
            FillArray(array1, 16);

            int[] array2 = CombineArray(array0, array1);

            Console.Write("The combined array is -> ");
            PrintArray(array2);

        }//end function

        static string Prompt(string text) {
            Console.Write(text);
            return Console.ReadLine();
        }//end function

        static int PromptInt(string text) {
            return int.Parse(Prompt(text));
        }//end function

        static void FillArray( int[] arrayToBeFilled, int fillValue) {
            int arrayLength = arrayToBeFilled.Length;

            for (int index = 0; index < arrayLength; index += 1) {
                arrayToBeFilled[index] = PromptInt($"Array entry {index} = ");
            }//end for
        }//end function

        static int[] CombineArray(int[] arrayLeft, int[] arrayRight) {
            var leftArrayLength  = arrayLeft.Length;
            var rightArrayLength = arrayRight.Length;
            var newArrayLength  = leftArrayLength + rightArrayLength;

            int[] combinedArray = new int[newArrayLength];

            for (int index = 0; index < leftArrayLength; index += 1) {
                combinedArray[index] = arrayLeft[index];
            }//end for

            for (int index = 0; index < rightArrayLength; index += 1) {
                int combinedArrayIndex = leftArrayLength + index;
                combinedArray[combinedArrayIndex] = arrayRight[index];
            }//end for

            return combinedArray;
        }//end function

        static void PrintArray(int[] arrayToBePrinted) {
            int arrayToBePrintedLength = arrayToBePrinted.Length;

            Console.Write("[");

            for (int index = 0; index < arrayToBePrintedLength; index += 1) {
                Console.Write(arrayToBePrinted[index]);

                if (index < arrayToBePrintedLength - 1) {
                    Console.Write(", ");
                }//end if
            }//end for

            Console.Write("]");
        }//end function
    }//end class
}//end namespace
