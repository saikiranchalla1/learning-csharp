# Introduction
These assignments cover the concepts of variables, type casting and control flow.

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

5. Problem Statement
Write a program that will print the Fibonacci sequence. The Fibonacci sequence is a sequence of numbers where each number is the sum of the two previous numbers. The sequence starts with 0 and 1, and the first 10 numbers in the sequence are:

0, 1, 1, 2, 3, 5, 8, 13, 21, 34

Solution:

```
using System;

public class FibonacciSequence
{
    public static void Main()
    {
        // Initialize the first two numbers in the sequence
        int a = 0;
        int b = 1;

        // Print the first 10 numbers in the sequence
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a);

            // Calculate the next number in the sequence
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
```
Explanation
The program first initializes the first two numbers in the Fibonacci sequence to 0 and 1.

The program then prints the first 10 numbers in the sequence by looping from 0 to 9. Inside the loop, the program calculates the next number in the sequence by adding the two previous numbers together. The program then prints the current number and updates the values of a and b to be the next two numbers in the sequence.

Finally, the program calls the Main() method to start the program.


6. Temperature Conversion
Problem Statement
Write a program that will convert a temperature from Fahrenheit to Celsius, or from Celsius to Fahrenheit.

Solution:

```
using System;

public class TemperatureConversion
{
    public static void Main()
    {
        // Get the input from the user
        Console.WriteLine("Enter the temperature: ");
        float temperature = float.Parse(Console.ReadLine());

        // Get the input from the user
        Console.WriteLine("Enter the unit of measurement: ");
        string unit = Console.ReadLine();

        // Convert the temperature
        float convertedTemperature;
        if (unit == "Fahrenheit")
        {
            convertedTemperature = (temperature - 32) * 5 / 9;
        }
        else
        {
            convertedTemperature = temperature * 9 / 5 + 32;
        }

        // Display the result
        Console.WriteLine("The temperature in {0} is {1}.", unit, convertedTemperature);
    }
}

```
Explanation
The program first gets the temperature from the user using the Console.WriteLine() and Console.ReadLine() methods.

The program then gets the unit of measurement from the user using the Console.WriteLine() and Console.ReadLine() methods.

The program then converts the temperature by subtracting 32 from the Fahrenheit temperature, multiplying the result by 5, and dividing the result by 9. If the unit of measurement is Celsius, the program multiplies the temperature by 9, divides the result by 5, and adds 32.

Finally, the program displays the result using the Console.WriteLine() method.

7. Grade Calculator
Problem Statement
Write a program that will calculate the grade for a student. The program should ask the user for the student's name, the number of assignments they have completed, and the grades they received on each assignment. The program should then calculate the student's overall grade and display it to the user.

Solution:

```
using System;

public class GradeCalculator
{
    public static void Main()
    {
        // Get the input from the user
        Console.WriteLine("Enter the student's name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the number of assignments: ");
        int numberOfAssignments = int.Parse(Console.ReadLine());

        float[] grades = new float[numberOfAssignments];
        for (int i = 0; i < numberOfAssignments; i++)
        {
            Console.WriteLine("Enter the grade for assignment {0}: ", i + 1);
            grades[i] = float.Parse(Console.ReadLine());
        }

        // Calculate the student's overall grade
        float overallGrade = 0;
        for (int i = 0; i < numberOfAssignments; i++)
        {
            overallGrade += grades[i];
        }
        overallGrade /= numberOfAssignments;

        // Display the student's overall grade
        Console.WriteLine("{0}'s overall grade is {1}.", name, overallGrade);
    }
}
```

Explanation
The program first gets the student's name, the number of assignments they have completed, and the grades they received on each assignment using the Console.WriteLine() and Console.ReadLine() methods.

The program then calculates the student's overall grade by adding up the grades for each assignment and dividing the result by the number of assignments.

Finally, the program displays the student's overall grade using the Console.WriteLine() method.

8. Factorial
Problem Statement
Write a program that will calculate the factorial of a number. The factorial of a number is the product of all the positive integers less than or equal to the number. For example, the factorial of 5 is 120 because 120 = 1 * 2 * 3 * 4 * 5.

Solution:

```
using System;

public class Factorial
{
    public static void Main()
    {
        // Get the input from the user
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calculate the factorial
        int factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        // Display the factorial
        Console.WriteLine("The factorial of {0} is {1}.", number, factorial);
    }
}
```

Explanation
The program first gets the number from the user using the Console.WriteLine() and Console.ReadLine() methods.

The program then calculates the factorial by multiplying all the positive integers less than or equal to the number.

Finally, the program displays the factorial using the Console.WriteLine() method.

9. Bubble Sort
Problem Statement
Write a program that will sort a list of numbers using the bubble sort algorithm. The bubble sort algorithm works by repeatedly comparing adjacent elements and swapping them if they are in the wrong order.

Solution:

```
using System;

public class BubbleSort
{
    public static void Main()
    {
        // Declare a list of numbers
        int[] numbers = { 4, 2, 1, 3, 5 };

        // Bubble sort the list
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap the elements
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        // Display the sorted list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
```

Explanation
The program first declares a list of numbers.

The program then bubble sorts the list by repeatedly comparing adjacent elements and swapping them if they are in the wrong order.

Finally, the program displays the sorted list using the foreach loop.

10. Binary Search
Problem Statement
Write a program that will search for a number in a list using the binary search algorithm. The binary search algorithm works by repeatedly dividing the list in half and searching the half that is more likely to contain the number.

Solution:

```
using System;

public class BinarySearch
{
    public static int BinarySearch(int[] numbers, int numberToFind)
    {
        // Initialize the low and high indexes
        int low = 0;
        int high = numbers.Length - 1;

        // Loop until the low and high indexes meet
        while (low <= high)
        {
            // Calculate the middle index
            int middle = (low + high) / 2;

            // Check if the number is found at the middle index
            if (numbers[middle] == numberToFind)
            {
                // Return the middle index
                return middle;
            }

            // If the number is less than the middle index, set the high index to the middle index - 1
            else if (numberToFind < numbers[middle])
            {
                high = middle - 1;
            }

            // If the number is greater than the middle index, set the low index to the middle index + 1
            else
            {
                low = middle + 1;
            }
        }

        // Return -1 if the number is not found
        return -1;
    }
}
```

Explanation
The program first declares an array of numbers and a number to find.

The program then initializes the low and high indexes to 0 and the length of the array minus 1, respectively.

The program then loops until the low and high indexes meet. Inside the loop, the program calculates the middle index and checks if the number is found at the middle index. If the number is found, the program returns the middle index. Otherwise, the program checks if the number is less than or greater than the middle index and sets the low or high index accordingly.

Finally, the program returns -1 if the number is not found.
