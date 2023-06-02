1. Problem Statement:

Write a program that will calculate the area of a triangle. The program should ask the user for the length of the base and the height of the triangle, and then calculate the area using the formula:

Area = (1/2) * base * height

Solution:

```
using System;

public class TriangleArea
{
    public static void Main()
    {
        // Declare variables
        float base;
        float height;
        float area;

        // Get input from user
        Console.WriteLine("Enter the base of the triangle: ");
        base = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle: ");
        height = float.Parse(Console.ReadLine());

        // Calculate the area
        area = (1 / 2) * base * height;

        // Display the area
        Console.WriteLine("The area of the triangle is {0}.", area);
    }
}
```

Explanation:

The program first declares three variables: base, height, and area. The base and height variables are used to store the input from the user, and the area variable is used to store the calculated area.

The program then gets input from the user using the Console.WriteLine() and Console.ReadLine() methods. The float.Parse() method is used to convert the input string to a float.

The program then calculates the area using the formula Area = (1/2) * base * height. The area is then stored in the area variable.

Finally, the program displays the area using the Console.WriteLine() method.


2. Problem Statement:

Write a program that will print the numbers from 1 to 100, but for multiples of 3, print "Fizz" instead of the number, and for multiples of 5, print "Buzz" instead of the number. For numbers that are multiples of both 3 and 5, print "FizzBuzz".

Solution:

```
using System;

public class FizzBuzz
{
    public static void Main()
    {
        // Loop from 1 to 100
        for (int i = 1; i <= 100; i++)
        {
            // If i is a multiple of 3, print "Fizz"
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // If i is a multiple of 5, print "Buzz"
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // If i is a multiple of both 3 and 5, print "FizzBuzz"
            else if (i % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Otherwise, print i
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
```


Explanation:

The program first declares a for loop that will loop from 1 to 100. Inside the loop, the program checks if the current number is a multiple of 3, 5, or both. If it is, the program prints the appropriate string. Otherwise, the program prints the current number.

The program then calls the Main() method to start the program.

3. Problem Statement
Write a program that will check if a string is a palindrome. A palindrome is a word or phrase that is spelled the same way forwards and backwards.

Solution:

```
using System;

public class Palindrome
{
    public static void Main()
    {
        // Get input from user
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        // Check if the string is a palindrome
        bool isPalindrome = true;
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        // Display the result
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
```

Explanation
The program first gets input from the user using the Console.WriteLine() and Console.ReadLine() methods.

The program then checks if the string is a palindrome by looping through the string from the beginning to the end and comparing each character to the character at the opposite end of the string. If any of the characters do not match, the program sets the isPalindrome variable to false and breaks out of the loop.

Finally, the program displays the result using the Console.WriteLine() method.


4. Problem Statement
Write a program that will determine if a year is a leap year. A leap year is a year that has 366 days, instead of the usual 365 days. Leap years occur every four years, except for years that are divisible by 100 but not by 400.

Solution:

```
using System;

public class LeapYear
{
    public static void Main()
    {
        // Get input from user
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine("The year is a leap year.");
        }
        else
        {
            Console.WriteLine("The year is not a leap year.");
        }
    }
}
```


Explanation
The program first gets input from the user using the Console.WriteLine() and Console.ReadLine() methods.

The program then checks if the year is a leap year by checking if the year is divisible by 4, and if it is not divisible by 100, or if it is divisible by 400.

Finally, the program displays the result using the Console.WriteLine() method.

5. Problem Statement
Write a program that will determine if a number is a prime number. A prime number is a number that is divisible only by itself and by 1.

Solution:

```
using System;

public class PrimeNumber
{
    public static void Main()
    {
        // Get input from user
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a prime number
        bool isPrime = true;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Display the result
        if (isPrime)
        {
            Console.WriteLine("The number is a prime number.");
        }
        else
        {
            Console.WriteLine("The number is not a prime number.");
        }
    }
}
```

The program then checks if the number is a prime number by looping through all the numbers from 2 to the square root of the number. If any of these numbers divides the number evenly, then the number is not a prime number.

Finally, the program displays the result using the Console.WriteLine() method.

