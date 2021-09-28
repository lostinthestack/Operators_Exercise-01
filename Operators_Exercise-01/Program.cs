using System;

namespace Operators_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region/*===================================================   Mathematical Operators   ======================================================*/

            int x = 10;
            int y = 20;

            // TODO: Add 20 to x and 60 to y, print them out to the console, then AddSpace()
            x += 20;
            y += 60;
            // TODO: x = 30
            // TODO: y = 80
            Console.WriteLine($"X = {x} and Y = {y}");
            AddSpace();

            // TODO: Subtract 10 from x and 70 from y, print them out to the console, then AddSpace()
            x -= 10;
            y -= 70;
            // TODO: x = 20
            // TODO: y = 10

            Console.WriteLine($"X = {x} and Y = {y}");
            AddSpace();

            // TODO: Multiply x by 3 and y by 2, print them out to the console, then AddSpace()
            x *= 3;
            y *= 2;
            // TODO: x = 60
            // TODO: y = 20
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // TODO: Divide x by 6 and y by 1, print them out to the console, then AddSpace()
            x /= 6;
            y /= 1;
            // TODO: x = 10
            // TODO: y = 20
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // TODO: Modulus x by 3 and y by 3, print them out to the console, then AddSpace()
            x %= 3;
            y %= 3;
            // TODO: x = 1
            // TODO: y = 2
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // TODO: Pre-increment x and y, print them out to the console, then AddSpace()
            ++x;
            y++;
            // TODO: x = 2
            // TODO: y = 3
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // Thought Experiment: What will the value of x and y be after going through this pre/post increment operation?
            x = ++x;
            y = y++;
            // TODO: x = 3
            // TODO: y = 3
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // Thought Experiment: What will the value of x and y be after going thought the pre/post increment again, only slightly changed up a bit?
            // ANSWER: Although the output of y in the previous portion did not show the incrementation, it was executed and stored afterwards so the value that was applied in this exercise was not 3 but 4.
            x++;
            ++y;
            // TODO: x = 4
            // TODO: y = 4
            Console.WriteLine($"X = {x} and Y = {y}");

            AddSpace();

            // Thought Experiment: What will be the value of x,y,and z that is written to the console?
            int z = --y + ++x;
            // TODO: x = 5
            // TODO: y = 3
            // TODO: z = 8
            Console.WriteLine($"X = {x} and Y = {y} and Z = {z}");

            AddSpace();

            #endregion

            #region/*===================================================   Relational Operators   ======================================================*/

            bool conditionalValue = false;
            int a = 10;
            int b = 11;

            bool first = true;
            bool second = true;

            // Thought Experiment: What is the value of the variable conditionalValue after the == operator?
            conditionalValue = first == second;
            // TODO: conditionalValue = true
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the != operator?
            conditionalValue = first != second;
            // TODO: conditionalValue = false
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the > operator?
            conditionalValue = a > b;
            // TODO: conditionalValue = false
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the < operator?
            conditionalValue = a < b;
            // TODO: conditionalValue = true
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the >= operator?
            conditionalValue = a >= b;
            // TODO: conditionalValue = false
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the <= operator?
            conditionalValue = a <= b;
            // TODO: conditionalValue = true
            Console.WriteLine(conditionalValue);

            AddSpace();

            #endregion

            #region/*===================================================   Logical Operators   ======================================================*/
            // a = 10;
            // b = 11;
            // first = true;
            // second = true;
            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            conditionalValue = a < b && ++a == b;
            // TODO: conditionalValue = true (because a was prefixed by incrementing by 1 {to 11})
            Console.WriteLine(conditionalValue);

            AddSpace();

            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            conditionalValue = a++ == b || first == second;
            // TODO: conditionalValue = true because second condition of OR is true
            Console.WriteLine(conditionalValue);

            AddSpace();

            first = false;
            second = true;
            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            conditionalValue = !second == first && a >= --b;
            // TODO: conditionalValue = true
            Console.WriteLine(conditionalValue);

            AddSpace();

            #endregion

            #region/*===================================================   Assignment Operators   ======================================================*/

            double total = 0; // Simple assignment operator =
            double var1 = 10.50; // Simple assignment operator =
            double var2 = 3.25; // Simple assignment operator =

            // TODO: use the Simple Assignment operator to add var1 and var2 and then assign the sum to the total variable
            total = var1 + var2;
            // TODO: total = 13.75
            Console.WriteLine(total);

            AddSpace();

            // Thought Experiment: What's the result doing the same operation, but replacing the Simple Assignment operator with the Add Assignment operator?
            // This is equivalent to total = total(Value) + var1 + var2
            total += var1 + var2;
            // TODO: total = 27.5
            Console.WriteLine(total);

            AddSpace();

            // TODO: use the Subtract Assignment operator to subtract total from var1 
            total -= var1;
            // TODO: total = 17
            Console.WriteLine(total);

            AddSpace();

            // TODO: use the Multiply Assignment operator to multiply total by var2
            total *= var2;
            // TODO: total = 55.25
            Console.WriteLine(total);

            AddSpace();

            // TODO: use the Division Assignment operator to divide total by 5
            total /= 5;
            // TODO: total = 11.05
            Console.WriteLine(total);

            AddSpace();

            // TODO: use the Modulus Assignment operator to modulo the total by 11.05
            total %= 11.05;
            // TODO: total = 0
            Console.WriteLine(total);

            AddSpace();

            #endregion

            #region/*===================================================   Ternary Operators   ======================================================*/
            string finalString = "";
            string str1 = $"String 1";
            string str2 = $"String 2";
            int intTotal = 0;
            int int1 = 1;
            int int2 = 2;

            // TODO: use the Ternary operator to shorten this if/else statement with syntax sugar
            /*
            if (finalString.Length == 0)
            {
                finalString = str1;
            }
            else
            {
                finalString = str2;
            }
            */
            finalString = finalString.Length == 0 ? str1 : str2;
            // TODO: finalString = str1
            Console.WriteLine(finalString);

            AddSpace();

            // TODO: use the Ternary operator to shorten this if statement with syntax sugar
            /*
            if (int1 + int2 > intTotal)
            {
                intTotal = int1 + int2;
            }
            else
            {
                intTotal = int1 - int2;
            }
            */
            intTotal = int1 + int2 > intTotal ? int1 + int2 : int1 - int2;
            // TODO: intTotal = returns first expression with result of 3
            Console.WriteLine(intTotal);

            AddSpace();

            // Thought Experiment: What will be the value of finalString after the Ternary operation?
            finalString = finalString != null && finalString.Length != 0 ? str1[7].ToString() : str2[7].ToString();
            // TODO: finalString = 2
            Console.WriteLine(str2[7].ToString());

            #endregion
        }

        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
