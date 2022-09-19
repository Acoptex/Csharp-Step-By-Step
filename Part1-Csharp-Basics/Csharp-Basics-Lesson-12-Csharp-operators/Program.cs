using System;

namespace Csharp_Basics_Lesson_12_Csharp_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# operators

            /*
            
            Operators can be separated into different types according
            to the number of arguments they could take.

            Types of Operators by Number of Arguments:            

             unary -   takes one operand
             binary -  takes two operands
             ternary - takes three operands
            
            Operator Categories:

                arithmetic    -, +, *, /, %, ++, --
                logical       &&, ||, !, ^
                binary        &, |, ^, ~, <<, >>
                comparison    ==,!=, >, <, >=, <=
                assignment    =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
                
                string concatenation +
                type conversion      (type), as, is, typeof, sizeof
                other                ., new, (), [], ?:, ??

             */

            // 1. Assignment Operators

            /*
             =	    x = 5	    x = 5	
             +=	    x += 3	    x = x + 3	
             -=	    x -= 3	    x = x - 3	
             *=	    x *= 3	    x = x * 3	
             /=	    x /= 3	    x = x / 3	
             %=	    x %= 3	    x = x % 3	
             &=	    x &= 3	    x = x & 3	
             |=	    x |= 3	    x = x | 3	
             ^=	    x ^= 3	    x = x ^ 3	
             >>=	x >>= 3	    x = x >> 3	
             <<=	x <<= 3	    x = x << 3

             */
            Console.WriteLine("******************* 1. Assignment Operators ********************");
            float myFloat = 14.5f;

            int x, y, z;
            x = y = z = 25;

            int num5, num = 1;
            num5 = 4;
           
            int sum1 = 90 + 50;         // 140 (90 + 50)
            int sum2 = sum1 + 250;      // 390 (140 + 250)
            int sum3 = sum2 + sum2;     // 780 (390 + 390)
            
            bool isRaining = true;
            
            num5 = -num; // Unary operators
            Console.WriteLine("num5 is {0}", num5);

            x = 2;
            y = 4;
            x *= y; // Same as x = x * y;
            Console.WriteLine(x);      // 8
            Console.WriteLine(x |= 1); // 9
            Console.WriteLine(x += 3); // 12
            Console.WriteLine(x /= 2); // 6

            // 2. Conditional Operator ?:

            /*
             
             The operator ?: has the following syntax:
                 operand1 ? operand2 : operand3

             */
            Console.WriteLine("******************* 2. Conditional Operator ?: ******************");
            int c = 6; 
            int d = 4; 
            Console.WriteLine(c > d ? "c>d" : "d<=c"); // c > d

            // 3. Arithmetic Operators

            /*
            +	Addition	    Adds together two values	                x + y	
            -	Subtraction	    Subtracts one value from another	        x - y	
            *	Multiplication	Multiplies two values	                    x * y	
            /	Division	    Divides one value by another	            x / y	
            %	Modulus	        Returns the division remainder	            x % y	
            ++	Increment	    Increases the value of a variable by 1	    x++	
            --	Decrement	    Decreases the value of a variable by 1	    x-- 
             */

            Console.WriteLine("******************* 3. Arithmetic Operators ********************");
            int num1 = 2, num2 = 1;
            Console.WriteLine($"result of {num1} + {num2} is {num1 + num2}");
            Console.WriteLine("********************************************************");

            Console.WriteLine($"result of {num1} - {num2} is {num1 - num2}");
            Console.WriteLine("********************************************************");

            Console.WriteLine($"result of {num1} / {num2} is {num1 / num2}");
            Console.WriteLine("********************************************************");

            Console.WriteLine($"result of {num1} * {num2} is {num1 * num2}");
            Console.WriteLine("********************************************************");

            Console.WriteLine($"result of {num1} % {num2} is {num1 % num2}");
            Console.WriteLine("********************************************************");

            Console.WriteLine($"{num1}++ is {num1++}"); // increment. original value of the operand is returned first, then the addition or subtraction is performed.
            Console.WriteLine("********************************************************");

            Console.WriteLine($"++{num2} is {++num2}"); // pre increment. the new value is calculated first and then the result is returned.
            Console.WriteLine("********************************************************");

            Console.WriteLine($"{num1}-- is {num1--}"); // decrement. original value of the operand is returned first, then the addition or subtraction is performed.
            Console.WriteLine("********************************************************");

            Console.WriteLine($"--{num2} is {--num2}"); // pre decrement. the new value is calculated first and then the result is returned.
            Console.WriteLine("********************************************************");
           
            // 4. C# Comparison Operators

            /*
             
            ==	Equal to	                x == y	
            !=	Not equal	                x != y	
            >	Greater than	            x > y	
            <	Less than	                x < y	
            >=	Greater than or equal to	x >= y	
            <=	Less than or equal to	    x <= y
             
             */
            Console.WriteLine("******************* 4. C# Comparison Operators *********************");
            int num3 = 2, num4 = 5;            
            bool isEqual = num3 == num4;
            Console.WriteLine($"result of {num3} == {num4} is {isEqual}");
            Console.WriteLine("********************************************************");

            isEqual = num3 != num4;
            Console.WriteLine($"result of {num3} != {num4} is {isEqual}");
            Console.WriteLine("********************************************************");
            
            isEqual = num3 > num4;
            Console.WriteLine($"result of {num3} > {num4} is {isEqual}");
            Console.WriteLine("********************************************************");
            
            isEqual = num3 < num4;
            Console.WriteLine($"result of {num3} < {num4} is {isEqual}");
            Console.WriteLine("********************************************************");

            isEqual = num3 >= num4;
            Console.WriteLine($"result of {num3} >= {num4} is {isEqual}");
            Console.WriteLine("********************************************************");

            isEqual = num3 <= num4;
            Console.WriteLine($"result of {num3} <= {num4} is {isEqual}");
            Console.WriteLine("********************************************************");

            // 5. C# Logical Operators 

            /*
             && 	Logical and	   Returns true if both statements are true	                x < 5 &&  x < 10	
             || 	Logical or	   Returns true if one of the statements is true	        x < 5 || x < 4	
             !	    Logical not	   Reverse the result, returns false if the result is true	!(x < 5 && x < 10)	
                      
            x     y     !x    x && y  x || y  x ^ y
            true  true  false true    true    false
            true  false false false   true    true
            false true  true  false   true    true
            false false true  false   false   false

             */
            Console.WriteLine("******************* 5. C# Logical Operators ************");
            // Logical and
            bool isTall = true, isRich = true;
            bool isTallAndRich = isTall && isRich;
            Console.WriteLine("The result of isTall && isRich -> {0}", isTallAndRich);
            Console.WriteLine("********************************************************");
            
            // Logical or
            isTall = false;
            isRich = false;
            isTallAndRich = isTall || isRich;
            Console.WriteLine("result of isTall || isRich is {0}", isTallAndRich);
            Console.WriteLine("********************************************************");

            // Logical not
            isTall = false;
            isRich = true;
            isTallAndRich = !(isTall && isRich);
            Console.WriteLine("result of !(isTall && isRich) is {0}", isTallAndRich);

            // 6. Bitwise operators
            Console.WriteLine("******************* 6. Bitwise operators ************");
            byte a = 3; // 0000 0011 = 3
            byte b = 5; // 0000 0101 = 5
            Console.WriteLine(a | b);  // 0000 0111 = 7
            Console.WriteLine(a & b);  // 0000 0001 = 1
            Console.WriteLine(a ^ b);  // 0000 0110 = 6
            Console.WriteLine(~a & b); // 0000 0100 = 4
            Console.WriteLine(a << 1); // 0000 0110 = 6
            Console.WriteLine(a << 2); // 0000 1100 = 12
            Console.WriteLine(a >> 1); // 0000 0001 = 1

            // 7. Other Operators

            Console.WriteLine("******************* 7. Other Operators ************");
            // The "." Operator
            Console.WriteLine(DateTime.Now); // Prints the date + time
            // Square Brackets [] Operator
            string str = "World"; 
            Console.WriteLine(str[0]); // W
                                       // Brackets () Operator
                                       // Brackets () are used to override the priority of execution of expressions and operators.

            // Operator "as"
            // The operator as also is used for type conversion but invalid conversion returns null, not an exception.

            // Operator "new"
            // The new operator is used to create and initialize new objects.

            // Operator "is"
            // The is operator is used to check whether an object is compatible with a given type(check object's type).

            string text = "Acoptex"; 
            Console.WriteLine(text is string); // True

            // Operator "??"
            // The operator ?? is similar to the conditional operator ?:. The difference is that it is placed between two operands and returns the left operand only if its value is not null, otherwise it returns the right operand.
            int? e = 5; 
            Console.WriteLine(e ?? -1); // 5

            string notNullString = text; 
            string nullString = null; 
            Console.WriteLine(nullString ?? "Unspecified"); // Unspecified
            Console.WriteLine(notNullString ?? "Specified"); // Acoptex

            Console.Read();

        }
    }
}
