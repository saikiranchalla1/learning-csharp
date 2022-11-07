<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

- [Programming with C#](#programming-with-c)
  - [Installing Visual Studio Community](#installing-visual-studio-community)
    - [Windows Users](#windows-users)
  - [Hello World!](#hello-world)
    - [Windows](#windows)
    - [Mac Users](#mac-users)
    - [Deep Dive into the Hello World](#deep-dive-into-the-hello-world)
  - [.NET Core vs .NET Framework](#net-core-vs-net-framework)
  - [DataTypes and Variables](#datatypes-and-variables)
    - [Value Types](#value-types)
      - [Integral types](#integral-types)
        - [Integer literals](#integer-literals)
      - [Floating-point Types](#floating-point-types)
    - [The string type](#the-string-type)
      - [Creating a String object](#creating-a-string-object)
      - [String literals](#string-literals)
      - [Properties of the String Class](#properties-of-the-string-class)
      - [Methods of the String class](#methods-of-the-string-class)
        - [Examples](#examples)
          - [Comparing Strings](#comparing-strings)
          - [String Contains String](#string-contains-string)
          - [Getting a Substring](#getting-a-substring)
          - [Joining Strings](#joining-strings)
    - [Type Conversion](#type-conversion)
      - [C# Type Conversion Methods](#c-type-conversion-methods)
    - [Coding Standards](#coding-standards)
    - [Value vs reference types](#value-vs-reference-types)
    - [Console Methods](#console-methods)
    - [Constants](#constants)
    - [Operators](#operators)
      - [Arithmetic Operators](#arithmetic-operators)
      - [Relational Operators](#relational-operators)
      - [Logical Operators](#logical-operators)
      - [Bitwise Operators](#bitwise-operators)
      - [Assignment Operators](#assignment-operators)
      - [Miscellaneous Operators](#miscellaneous-operators)
      - [Operator Precedence in C#](#operator-precedence-in-c)
    - [Challenges](#challenges)
      - [Challenge 1 – String and its methods](#challenge-1--string-and-its-methods)
      - [Challenge String and its methods 2](#challenge-string-and-its-methods-2)
  - [Functions/Methods - Code Reuse](#functionsmethods---code-reuse)
    - [Methods in C#](#methods-in-c)
      - [Defining Methods in C#](#defining-methods-in-c)
      - [Calling Methods in C#](#calling-methods-in-c)
      - [Recursive Method Call](#recursive-method-call)
      - [Passing Parameters to a Method](#passing-parameters-to-a-method)
        - [Value Parameters](#value-parameters)
        - [Reference Parameters](#reference-parameters)
        - [Output Parameters](#output-parameters)
  - [Exception Handling in C#](#exception-handling-in-c)
    - [Syntax](#syntax)
    - [Exception Classes in C#](#exception-classes-in-c)
    - [Handling Exceptions](#handling-exceptions)
    - [Creating User-Defined Exceptions](#creating-user-defined-exceptions)
    - [Throwing Objects](#throwing-objects)
  - [Decision Making](#decision-making)
    - [if Statement](#if-statement)
      - [Syntax](#syntax-1)
      - [Example](#example)
    - [if...else statement](#ifelse-statement)
      - [Syntax](#syntax-2)
      - [Example](#example-1)
    - [The if...else if...else Statement](#the-ifelse-ifelse-statement)
      - [Syntax](#syntax-3)
      - [Example](#example-2)
    - [Nested if statements](#nested-if-statements)
      - [Syntax](#syntax-4)
      - [Example](#example-3)
    - [Switch statement](#switch-statement)
      - [Syntax](#syntax-5)
      - [Flow diagram](#flow-diagram)
      - [Example](#example-4)
    - [Nested Switch](#nested-switch)
      - [Syntax](#syntax-6)
      - [Example](#example-5)
    - [The ? : Operator](#the---operator)
    - [TryParse Methods in C#](#tryparse-methods-in-c)
      - [Example](#example-6)
  - [Loops in C#](#loops-in-c)
    - [While Loop](#while-loop)
      - [Syntax](#syntax-7)
      - [Flow Diagram](#flow-diagram-1)
      - [Example](#example-7)
    - [for loop](#for-loop)
      - [Syntax](#syntax-8)
      - [Flow Diagram](#flow-diagram-2)
      - [Example](#example-8)
    - [do...while Loop](#dowhile-loop)
      - [Syntax](#syntax-9)
      - [Flow Diagram](#flow-diagram-3)
      - [Example](#example-9)
    - [Nested Loop](#nested-loop)
      - [Example](#example-10)
    - [Loop Control Statements](#loop-control-statements)
      - [break statement](#break-statement)
        - [Syntax](#syntax-10)
        - [Flow Diagram](#flow-diagram-4)
        - [Example](#example-11)
      - [continue statement](#continue-statement)
        - [Syntax](#syntax-11)
        - [Flow Diagram](#flow-diagram-5)
        - [Example](#example-12)
    - [Infinite Loop](#infinite-loop)
      - [Example](#example-13)
  - [Encapsulation](#encapsulation)
    - [Public Access Specifier](#public-access-specifier)
    - [Private Access Specifier](#private-access-specifier)
    - [Protected Access Specifier](#protected-access-specifier)
    - [Internal Access Specifier](#internal-access-specifier)
    - [Protected Internal Access Specifier](#protected-internal-access-specifier)
  - [Nullables](#nullables)
    - [The Null Coalescing Operator (??)](#the-null-coalescing-operator-)
  - [Object Oriented Programming](#object-oriented-programming)
    - [Classes](#classes)
      - [Defining a Class](#defining-a-class)
    - [Member Functions and Encapsulation](#member-functions-and-encapsulation)
    - [C# Constructors](#c-constructors)
    - [C# Destructors](#c-destructors)
    - [Static Members of a C# Class](#static-members-of-a-c-class)
    - [Inheritance](#inheritance)
      - [Base and Derived Classes](#base-and-derived-classes)
      - [Initializing Base Class](#initializing-base-class)
      - [Multiple Inheritance in C#](#multiple-inheritance-in-c)
    - [Polymorphism](#polymorphism)
      - [Static Polymorphism](#static-polymorphism)
        - [Function Overloading](#function-overloading)
      - [Dynamic Polymorphism](#dynamic-polymorphism)
    - [Operator Overloading](#operator-overloading)
      - [Implementing the Operator Overloading](#implementing-the-operator-overloading)
        - [Overloadable and Non-Overloadable Operators](#overloadable-and-non-overloadable-operators)
  - [Collections](#collections)
    - [Collection Class](#collection-class)
    - [Various Collection Classes and Their Usage](#various-collection-classes-and-their-usage)
      - [ArrayList](#arraylist)
      - [Hashtable](#hashtable)
      - [SortedList Class](#sortedlist-class)
      - [Stack Class](#stack-class)
      - [Queue Class](#queue-class)
      - [BitArray Class](#bitarray-class)
  - [Structs](#structs)
    - [Defining a Structure](#defining-a-structure)
    - [Features of C# Structures](#features-of-c-structures)
    - [Class versus Structure](#class-versus-structure)
  - [Enums](#enums)
    - [Declaring enum Variable](#declaring-enum-variable)
    - [Example](#example-14)
  - [Regular Expressions](#regular-expressions)
    - [Constructs for Defining Regular Expressions](#constructs-for-defining-regular-expressions)
  - [File I/O](#file-io)
    - [C# I/O Classes](#c-io-classes)
    - [The FileStream Class](#the-filestream-class)
    - [Example](#example-15)
    - [Advanced File Operations in C#](#advanced-file-operations-in-c)
      - [Reading from and Writing to Text Files](#reading-from-and-writing-to-text-files)
        - [The StreamReader Class](#the-streamreader-class)
        - [The StreamWriter Class](#the-streamwriter-class)
      - [Reading from and Writing into Binary files](#reading-from-and-writing-into-binary-files)
        - [The BinaryReader Class](#the-binaryreader-class)
        - [The BinaryWriter Class](#the-binarywriter-class)
      - [Windows File System](#windows-file-system)
        - [The DirectoryInfo Class](#the-directoryinfo-class)
        - [The FileInfo Class](#the-fileinfo-class)
  - [Attributes](#attributes)
    - [Specifying an Attribute](#specifying-an-attribute)
    - [Predefined Attributes](#predefined-attributes)
    - [AttributeUsage](#attributeusage)
    - [Conditional](#conditional)
    - [Obsolete](#obsolete)
    - [Creating Custom Attributes](#creating-custom-attributes)
      - [Declaring a Custom Attribute](#declaring-a-custom-attribute)
      - [Constructing the Custom Attribute](#constructing-the-custom-attribute)
      - [Applying the Custom Attribute](#applying-the-custom-attribute)
  - [Reflection](#reflection)
    - [Applications of Reflection](#applications-of-reflection)
    - [Viewing Metadata](#viewing-metadata)
    - [Example](#example-16)
  - [Properties](#properties)
    - [Accessors](#accessors)
    - [Example](#example-17)
    - [Abstract Properties](#abstract-properties)
  - [Indexers](#indexers)
    - [Syntax](#syntax-12)
    - [Use of Indexers](#use-of-indexers)
    - [Overloaded Indexers](#overloaded-indexers)
  - [Delegates](#delegates)
    - [Declaring Delegates](#declaring-delegates)
    - [Instantiating Delegates](#instantiating-delegates)
    - [Multicasting of a Delegate](#multicasting-of-a-delegate)
    - [Using Delegates](#using-delegates)
  - [Events](#events)
    - [Using Delegates with Events](#using-delegates-with-events)
    - [Declaring Events](#declaring-events)
  - [Anonymous Methods](#anonymous-methods)
    - [Writing an Anonymous Method](#writing-an-anonymous-method)
    - [Example](#example-18)
  - [Unsafe Codes](#unsafe-codes)
    - [Pointers](#pointers)
    - [Retrieving the Data Value Using a Pointer](#retrieving-the-data-value-using-a-pointer)
    - [Passing Pointers as Parameters to Methods](#passing-pointers-as-parameters-to-methods)
    - [Accessing Array Elements Using a Pointer](#accessing-array-elements-using-a-pointer)
    - [Compiling Unsafe Code](#compiling-unsafe-code)
  - [Multithreading](#multithreading)
    - [Thread Life Cycle](#thread-life-cycle)
    - [The Main Thread](#the-main-thread)
    - [Creating Threads](#creating-threads)
    - [Managing Threads](#managing-threads)
    - [Destroying Threads](#destroying-threads)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# Programming with C#
## Installing Visual Studio Community
Download and install Visual Studio Community Edition from [here](https://visualstudio.microsoft.com/).
![vs-download](imgs/vs-download.png)

Follow the instructions in the installer to setup VS2022 in your local machine. Once installed, launch VS2022.

__Note for Mac Users: VS 2022 is also available for Mac. Download the DMG and install it in your local.__
![vs on mac](imgs/vs-on-mac.png)

In addition, Mac Users will also have to install .NET Core 5.0. Download and install the package from [here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-macos-x64-installer).

### Windows Users
After launching VS2022 installer, you should see the following screen:
![vs on windows](imgs/vs-on-windows.png)


Here, click on `Install` next to `Visual Studio Community 2022`.

Select the following in the `Workloads` tab:

- .NET desktop development

Other than the defaults in `Individual Components`, select the following as well:
- .NET 5.0 Runtime

__Note that the .NET 5.0 is End of support as of May 10, 2022. Also make sure that .NET 6.0 is selected.__


Next, click on `Install` and the bottom right and wait for the installation to finish.

Once the installation is done, you'll be asked to `Sign In`. Use an existing account or create a new one. Next, customize the look and feel for your Visual Studio.

## Hello World!
### Windows
Let's create a new project in Visual Studio 2022 and select `Create a new Project`.
![hw on windows](imgs/hw-on-windows.png)

Next, select the template as `Console Application` for C# (not VB) and click `Next`.
![console application](imgs/console-application.png)

Select the target framework as `.NET 5.0` and click `Create`.

Once the project creation completes, you should see the Solution open in VS 2022 with the files showing in the `Solution Explorer`.
![hw on windows 2](imgs/hw-on-windows-2.png)


If you open the project in `Explorer`, you'll notice that there is a file that ends in the extension `.sln`. This is the solution file for your project.
![solution file](imgs/solution-file.png)


### Mac Users
Open VS 2022 and click on `New`:
![project on mac](imgs/project-on-mac.png)

In the Wizard, select `Console Application` under `General` and the programming language as C#.
![csharp on mac](imgs/csharp-on-mac.png)

Next, select the target framework as .NET 6.0 and click on `Continue`.
![netfw on mac](imgs/netfw-on-mac.png)

Provide the following input on the next screen:

- Project Name: `Hello_World`
![hw on mac step last](imgs/hw-on-mac-step-last.png)

Click on `Create` and wait for the project to load in VS 2022. You should see the following in VS 2022 window:
![hw on mac last step](imgs/hw-on-mac-last-step.png)


### Deep Dive into the Hello World
The "Hello, World" program starts with a `using` directive that references the `System` namespace. Namespaces provide a hierarchical means of organizing C# programs and libraries. Namespaces contain types and other namespaces—for example, the `System` namespace contains a number of types, such as the `Console` class referenced in the program, and a number of other namespaces, such as `IO` and `Collections`. A `using` directive that references a given namespace enables unqualified use of the types that are members of that namespace. Because of the `using` directive, the program can use `Console.WriteLine` as shorthand for `System.Console.WriteLine`.

The `Hello` class declared by the "Hello, World" program has a single member, the method named Main. The `Main` method is declared with the `static` modifier. While instance methods can reference a particular enclosing object instance using the keyword this, static methods operate without reference to a particular object. By convention, a `static` method named Main serves as the entry point of a C# program.

The output of the program is produced by the `WriteLine` method of the `Console` class in the `System` namespace. This class is provided by the standard class libraries, which, by default, are automatically referenced by the compiler.

## .NET Core vs .NET Framework
Refer to [this](https://stackify.com/net-core-vs-net-framework/) blog to compare .NET core vs framework.

## DataTypes and Variables
A type defines the structure and behavior of any data in C#. The declaration of a type may include its members, base type, interfaces it implements, and operations permitted for that type. A variable is a label that refers to an instance of a specific type.

There are two kinds of types in C#: value types and reference types. Variables of value types directly contain their data. Variables of reference types store references to their data, the latter being known as objects. With reference types, it's possible for two variables to reference the same object and possible for operations on one variable to affect the object referenced by the other variable. With value types, the variables each have their own copy of the data, and it isn't possible for operations on one to affect the other (except for `ref` and `out` parameter variables).

An `identifier` is a variable name. An identifier is a sequence of unicode characters without any whitespace. An identifier may be a C# reserved word, if it's prefixed by @. Using a reserved word as an identifier can be useful when interacting with other languages.

C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types. C#'s reference types are further divided into class types, interface types, array types, and delegate types.


The following outline provides an overview of C#'s type system.

### Value Types
Value types and reference types are the two main categories of C# types. A variable of a value type contains an instance of the type. This differs from a variable of a reference type, which contains a reference to an instance of the type. By default, on assignment, passing an argument to a method, and returning a method result, variable values are copied. In the case of value-type variables, the corresponding type instances are copied. The following example demonstrates that behavior:

```
using System;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

public class Program
{
    public static void Main()
    {
        var p1 = new MutablePoint(1, 2);
        var p2 = p1;
        p2.Y = 200;
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");

        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
    }

    private static void MutateAndDisplay(MutablePoint p)
    {
        p.X = 100;
        Console.WriteLine($"Point mutated in a method: {p}");
    }
}
// Expected output:
// p1 after p2 is modified: (1, 2)
// p2: (1, 200)
// Point mutated in a method: (100, 200)
// p2 after passing to a method: (1, 200)
```

As the preceding example shows, operations on a value-type variable affect only that instance of the value type, stored in the variable.

If a value type contains a data member of a reference type, only the reference to the instance of the reference type is copied when a value-type instance is copied. Both the copy and original value-type instance have access to the same reference-type instance. The following example demonstrates that behavior:

```
using System;
using System.Collections.Generic;

public struct TaggedInteger
{
    public int Number;
    private List<string> tags;

    public TaggedInteger(int n)
    {
        Number = n;
        tags = new List<string>();
    }

    public void AddTag(string tag) => tags.Add(tag);

    public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
}

public class Program
{
    public static void Main()
    {
        var n1 = new TaggedInteger(0);
        n1.AddTag("A");
        Console.WriteLine(n1);  // output: 0 [A]

        var n2 = n1;
        n2.Number = 7;
        n2.AddTag("B");

        Console.WriteLine(n1);  // output: 0 [A, B]
        Console.WriteLine(n2);  // output: 7 [A, B]
    }
}
```

__Note: To make your code less error-prone and more robust, define and use immutable value types.__

#### Integral types
C# supports the following predefined integral types:
![types](imgs/types.png)

##### Integer literals

Integer literals can be

- decimal: without any prefix
- hexadecimal: with the 0x or 0X prefix
- binary: with the 0b or 0B prefix

```
var decimalLiteral = 42;
var hexLiteral = 0x2A;
var binaryLiteral = 0b_0010_1010;
```

The type of an integer literal is determined by its suffix as follows:

- If the literal has no suffix, its type is the first of the following types in which its value can be represented: int, uint, long, ulong.
- If the literal is suffixed by U or u, its type is the first of the following types in which its value can be represented: uint, ulong.
- If the literal is suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu, its type is ulong
- If the literal is suffixed by L or l, its type is the first of the following types in which its value can be represented: long, ulong.

#### Floating-point Types
C# supports the following predefined floating-point types:

![fp types](imgs/fp-types.png)

In the preceding table, each C# type keyword from the leftmost column is an alias for the corresponding .NET type. They are interchangeable. For example, the following declarations declare variables of the same type:

```
double a = 12.3;
System.Double b = 12.3;
```

The default value of each floating-point type is zero, 0. Each of the floating-point types has the MinValue and MaxValue constants that provide the minimum and maximum finite value of that type. The float and double types also provide constants that represent not-a-number and infinity values. For example, the double type provides the following constants: Double.NaN, Double.NegativeInfinity, and Double.PositiveInfinity.

### The string type
The string type represents a sequence of zero or more Unicode characters. string is an alias for System.String in .NET.

Although string is a reference type, the equality operators == and != are defined to compare the values of string objects, not references. Value based equality makes testing for string equality more intuitive. For example:

```
string a = "hello";
string b = "h";
// Append to contents of 'b'
b += "ello";
Console.WriteLine(a == b);
Console.WriteLine(object.ReferenceEquals(a, b));
```

The previous example displays "True" and then "False" because the content of the strings is equivalent, but a and b don't refer to the same string instance.

The + operator concatenates strings:

```
string a = "good " + "morning";
```

The preceding code creates a string object that contains "good morning".

Strings are immutable--the contents of a string object can't be changed after the object is created. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b. The memory that had been allocated for b (when it contained the string "h") is then eligible for garbage collection.


```
string b = "h";
b += "ello";
```

The [] operator can be used for readonly access to individual characters of a string. Valid index values start at 0 and must be less than the length of the string:


```
string str = "test";
char x = str[2];  // x = 's';
```

#### Creating a String object
You can create string object using one of the following methods −

- By assigning a string literal to a String variable
- By using a String class constructor
- By using the string concatenation operator (+)
- By retrieving a property or calling a method that returns a string
- By calling a formatting method to convert a value or an object to its string representation

The following example demonstrates this −
```
using System;

namespace StringApplication {

   class Program {

      static void Main(string[] args) {
         //from string literal and string concatenation
         string fname, lname;
         fname = "Rowan";
         lname = "Atkinson";

         char []letters= { 'H', 'e', 'l', 'l','o' };
         string [] sarray={ "Hello", "From", "Tutorials", "Point" };

         string fullname = fname + lname;
         Console.WriteLine("Full Name: {0}", fullname);

         //by using string constructor { 'H', 'e', 'l', 'l','o' };
         string greetings = new string(letters);
         Console.WriteLine("Greetings: {0}", greetings);

         //methods returning string { "Hello", "From", "Tutorials", "Point" };
         string message = String.Join(" ", sarray);
         Console.WriteLine("Message: {0}", message);

         //formatting method to convert a value
         DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
         string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
         Console.WriteLine("Message: {0}", chat);
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Full Name: RowanAtkinson
Greetings: Hello
Message: Hello From Tutorials Point
Message: Message sent at 5:58 PM on Wednesday, October 10, 2012
```



#### String literals

String literals are of type string and can be written in three forms, raw, quoted, and verbatim.

Raw string literals are available beginning in C# 11. Raw string literals can contain arbitrary text without requiring escape sequences. Raw string literals can include whitespace and new lines, embedded quotes, and other special characters. Raw string literals are enclosed in a minimum of three double quotation marks ("""):

```
"""
This is a multi-line
    string literal with the second line indented.
"""
```


Raw string literals typically have the starting and ending quote sequences on separate lines from the embedded text. Multiline raw string literals support strings that are themselves quoted strings:


```
var message = """
"This is a very important message."
""";
Console.WriteLine(message);
// output: "This is a very important message."
```


When the starting and ending quotes are on separate lines, the newlines following the opening quote and preceding the ending quote aren't included in the final content. The closing quote sequence dictates the leftmost column for the string literal. You can indent a raw string literal to match the overall code format:

```
var message = """
    "This is a very important message."
    """;
Console.WriteLine(message);
// output: "This is a very important message."
// The leftmost whitespace is not part of the raw string literal
```

Verbatim string literals start with @ and are also enclosed in double quotation marks. For example:
```
@"good morning"  // a string literal
```

The advantage of verbatim strings is that escape sequences aren't processed, which makes it easy to write. For example, the following text matches a fully qualified Windows file name:

```
@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"

```

#### Properties of the String Class
The String class has the following two properties −

| Sr.No | Property and Description |
|----|----|
| 1   |  Chars: Gets the Char object at a specified position in the current String object. |
| 2   | Length: Gets the number of characters in the current String object.   |


#### Methods of the String class
The String class has numerous methods that help you in working with the string objects. The following table provides some of the most commonly used methods −

| **Sr.No.** | **Methods Description**  |
|:----------:|:-------:|
| **1**      | public static int Compare(string strA, string strB) Compares two specified string objects and returns an integer that indicates their relative position in the sort order.   |
| **2**      | public static int Compare(string strA, string strB, bool ignoreCase ) Compares two specified string objects and returns an integer that indicates their relative position in the sort order. However, it ignores case if the Boolean parameter is true. |
| **3**      | public static string Concat(string str0, string str1) Concatenates two string objects. |
| **4**      | public static string Concat(string str0, string str1, string str2) Concatenates three string objects.  |
| **5**      | public static string Concat(string str0, string str1, string str2, string str3) Concatenates four string objects.  |
| **6**      | public bool Contains(string value) Returns a value indicating whether the specified String object occurs within this string. |
| **7**      | public static string Copy(string str) Creates a new String object with the same value as the specified string.  |
| **8**      | public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) Copies a specified number of characters from a specified position of the String object to a specified position in an array of Unicode characters.    |
| **9**      | public bool EndsWith(string value) Determines whether the end of the string object matches the specified string.  |
| **10**     | public bool Equals(string value) Determines whether the current String object and the specified String object have the same value. |
| **11**     | public static bool Equals(string a, string b) Determines whether two specified String objects have the same value. |
| **12**     | public static string Format(string format, Object arg0) Replaces one or more format items in a specified string with the string representation of a specified object.   |
| **13**     | public int IndexOf(char value) Returns the zero-based index of the first occurrence of the specified Unicode character in the current string.   |
| **14**     | public int IndexOf(string value) Returns the zero-based index of the first occurrence of the specified string in this instance. |
| **15**     | public int IndexOf(char value, int startIndex) Returns the zero-based index of the first occurrence of the specified Unicode character in this string, starting search at the specified character position.  |
| **16**     | public int IndexOf(string value, int startIndex) Returns the zero-based index of the first occurrence of the specified string in this instance, starting search at the specified character position. |
| **17**     | public int IndexOfAny(char[] anyOf) Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. |
| **18**     | public int IndexOfAny(char[] anyOf, int startIndex) Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters, starting search at the specified character position.   |
| **19**     | public string Insert(int startIndex, string value) Returns a new string in which a specified string is inserted at a specified index position in the current string object. |
| **20**     | public static bool IsNullOrEmpty(string value) Indicates whether the specified string is null or an Empty string. |
| **21**     | public static string Join(string separator, params string[] value) Concatenates all the elements of a string array, using the specified separator between each element. |
| **22**     | public static string Join(string separator, string[] value, int startIndex, int count) Concatenates the specified elements of a string array, using the specified separator between each element. |
| **23**     | public int LastIndexOf(char value) Returns the zero-based index position of the last occurrence of the specified Unicode character within the current string object. |
| **24**     | public int LastIndexOf(string value) Returns the zero-based index position of the last occurrence of a specified string within the current string object. |
| **25**     | public string Remove(int startIndex) Removes all the characters in the current instance, beginning at a specified position and continuing through the last position, and returns the string. |
| **26**     | public string Remove(int startIndex, int count) Removes the specified number of characters in the current string beginning at a specified position and returns the string. |
| **27**     | public string Replace(char oldChar, char newChar) Replaces all occurrences of a specified Unicode character in the current string object with the specified Unicode character and returns the new string. |
| **28**     | public string Replace(string oldValue, string newValue) Replaces all occurrences of a specified string in the current string object with the specified string and returns the new string. |
| **29**     | public string[] Split(params char[] separator) Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array. |
| **30**     | public string[] Split(char[] separator, int count) Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array. The int parameter specifies the maximum number of substrings to return. |
| **31**     | public bool StartsWith(string value) Determines whether the beginning of this string instance matches the specified string.  |
| **32**     | public char[] ToCharArray()Returns a Unicode character array with all the characters in the current string object. |
| **33**     | public char[] ToCharArray(int startIndex, int length) Returns a Unicode character array with all the characters in the current string object, starting from the specified index and up to the specified length.|
| **34**     | public string ToLower() Returns a copy of this string converted to lowercase. |
| **35**     | public string ToUpper() Returns a copy of this string converted to uppercase. |
| **36**     | public string Trim() Removes all leading and trailing white-space characters from the current String object. |

##### Examples
The following example demonstrates some of the methods mentioned above −

###### Comparing Strings
```
using System;

namespace StringApplication {

   class StringProg {

      static void Main(string[] args) {
         string str1 = "This is test";
         string str2 = "This is text";

         if (String.Compare(str1, str2) == 0) {
            Console.WriteLine(str1 + " and " + str2 +  " are equal.");
         } else {
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
         }
         Console.ReadKey() ;
      }
   }
}
```


When the above code is compiled and executed, it produces the following result −
```
This is test and This is text are not equal.
```

###### String Contains String
```
using System;

namespace StringApplication {

   class StringProg {

      static void Main(string[] args) {
         string str = "This is test";

         if (str.Contains("test")) {
            Console.WriteLine("The sequence 'test' was found.");
         }
         Console.ReadKey() ;
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
The sequence 'test' was found.
```

###### Getting a Substring
```
using System;

namespace StringApplication {

   class StringProg {

      static void Main(string[] args) {
         string str = "Last night I dreamt of San Pedro";
         Console.WriteLine(str);
         string substr = str.Substring(23);
         Console.WriteLine(substr);
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
San Pedro
```

###### Joining Strings
```
using System;

namespace StringApplication {

   class StringProg {

      static void Main(string[] args) {
         string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

         string str = String.Join("\n", starray);
         Console.WriteLine(str);
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
Down the way nights are dark
And the sun shines daily on the mountain top
I took a trip on a sailing ship
And when I reached Jamaica
I made a stop
```
### Type Conversion
Type conversion is converting one type of data to another type. It is also known as Type Casting. In C#, type casting has two forms −

- Implicit type conversion − These conversions are performed by C# in a type-safe manner. For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.
- Explicit type conversion − These conversions are done explicitly by users using the pre-defined functions. Explicit conversions require a cast operator.

```
using System;

namespace TypeConversionApplication {
   class ExplicitConversion {
      static void Main(string[] args) {
         double d = 5673.74;
         int i;

         // cast double to int.
         i = (int)d;
         Console.WriteLine(i);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
5673
```

#### C# Type Conversion Methods
C# provides the following built-in type conversion methods −

| Sr.No. | Methods & Description  |
|--------|-------------------------|
| 1      | ToBoolean Converts a type to a Boolean value, where possible. |
| 2      | ToByte Converts a type to a byte. |
| 3      | ToChar Converts a type to a single Unicode character, where possible. |
| 4      | ToDateTime Converts a type (integer or string type) to date-time structures. |
| 5      | ToDecimal Converts a floating point or integer type to a decimal type. |
| 6      | ToDouble Converts a type to a double type. |
| 7      | ToInt16 Converts a type to a 16-bit integer. |
| 8      | ToInt32 Converts a type to a 32-bit integer. |
| 9      | ToInt64 Converts a type to a 64-bit integer. |
| 10     | ToSbyte Converts a type to a signed byte type. |
| 11     | ToSingle Converts a type to a small floating point number. |
| 12     | ToString Converts a type to a string.|

### Coding Standards

Ref: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

### Value vs reference types

Ref: https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type

### Console Methods

Ref: https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1#System_Console_WriteLine_System_String_

### Constants
The constants refer to fixed values that the program may not alter during its execution. These fixed values are also called literals. Constants can be of any of the basic data types like an integer constant, a floating constant, a character constant, or a string literal. There are also enumeration constants as well.

The constants are treated just like regular variables except that their values cannot be modified after their definition.


Constants are defined using the const keyword. Syntax for defining a constant is −
```
const <data_type> <constant_name> = value;
```

The following program demonstrates defining and using a constant in your program −
```
using System;

namespace DeclaringConstants {
   class Program {
      static void Main(string[] args) {
         const double pi = 3.14159;   

         // constant declaration
         double r;
         Console.WriteLine("Enter Radius: ");
         r = Convert.ToDouble(Console.ReadLine());

         double areaCircle = pi * r * r;
         Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
         Console.ReadLine();
      }
   }
}
```

### Operators
An operator is a symbol that tells the compiler to perform specific mathematical or logical manipulations. C# has rich set of built-in operators and provides the following type of operators −

- Arithmetic Operators
- Relational Operators
- Logical Operators
- Bitwise Operators
- Assignment Operators
- Misc Operators

#### Arithmetic Operators

![arithmetic operators](imgs/arithmetic-operators.png)

```
using System;

namespace OperatorsAppl {
   class Program {
      static void Main(string[] args) {
         int a = 21;
         int b = 10;
         int c;

         c = a + b;
         Console.WriteLine("Line 1 - Value of c is {0}", c);

         c = a - b;
         Console.WriteLine("Line 2 - Value of c is {0}", c);

         c = a * b;
         Console.WriteLine("Line 3 - Value of c is {0}", c);

         c = a / b;
         Console.WriteLine("Line 4 - Value of c is {0}", c);

         c = a % b;
         Console.WriteLine("Line 5 - Value of c is {0}", c);

         c = a++;
         Console.WriteLine("Line 6 - Value of c is {0}", c);

         c = a--;
         Console.WriteLine("Line 7 - Value of c is {0}", c);
         Console.ReadLine();
      }
   }
}
```

#### Relational Operators
![relational operators](imgs/relational-operators.png)

```
using System;

class Program {
   static void Main(string[] args) {
      int a = 21;
      int b = 10;

      if (a == b) {
         Console.WriteLine("Line 1 - a is equal to b");
      } else {
         Console.WriteLine("Line 1 - a is not equal to b");
      }

      if (a < b) {
         Console.WriteLine("Line 2 - a is less than b");
      } else {
         Console.WriteLine("Line 2 - a is not less than b");
      }

      if (a > b) {
         Console.WriteLine("Line 3 - a is greater than b");
      } else {
         Console.WriteLine("Line 3 - a is not greater than b");
      }

      /* Lets change value of a and b */
      a = 5;
      b = 20;

      if (a <= b) {
         Console.WriteLine("Line 4 - a is either less than or equal to  b");
      }

      if (b >= a) {
         Console.WriteLine("Line 5-b is either greater than or equal to b");
      }
   }
}
```

#### Logical Operators
![logical operators](imgs/logical-operators.png)

```
using System;

namespace OperatorsAppl {
   class Program {
      static void Main(string[] args) {
         bool a = true;
         bool b = true;

         if (a && b) {
            Console.WriteLine("Line 1 - Condition is true");
         }

         if (a || b) {
            Console.WriteLine("Line 2 - Condition is true");
         }

         /* lets change the value of  a and b */
         a = false;
         b = true;

         if (a && b) {
            Console.WriteLine("Line 3 - Condition is true");
         } else {
            Console.WriteLine("Line 3 - Condition is not true");
         }

         if (!(a && b)) {
            Console.WriteLine("Line 4 - Condition is true");
         }
         Console.ReadLine();
      }
   }
}
```

#### Bitwise Operators

Bitwise operator works on bits and perform bit by bit operation. The truth tables for &, |, and ^ are as follows −.

![bitwise operators](imgs/bitwise-operators.png)


Assume if A = 60; and B = 13; then in the binary format they are as follows −

A = 0011 1100

B = 0000 1101

-------------------

A&B = 0000 1100

A|B = 0011 1101

A^B = 0011 0001

~A  = 1100 0011

The Bitwise operators supported by C# are listed in the following table. Assume variable A holds 60 and variable B holds 13, then −

![bitwise operators-1](imgs/bitwise-operators-1.png)


```
using System;

namespace OperatorsAppl {

   class Program {

      static void Main(string[] args) {
         int a = 60;            /* 60 = 0011 1100 */
         int b = 13;            /* 13 = 0000 1101 */
         int c = 0;

         c = a & b;             /* 12 = 0000 1100 */
         Console.WriteLine("Line 1 - Value of c is {0}", c );

         c = a | b;             /* 61 = 0011 1101 */
         Console.WriteLine("Line 2 - Value of c is {0}", c);

         c = a ^ b;             /* 49 = 0011 0001 */
         Console.WriteLine("Line 3 - Value of c is {0}", c);

         c = ~a;                /*-61 = 1100 0011 */
         Console.WriteLine("Line 4 - Value of c is {0}", c);

         c = a << 2;      /* 240 = 1111 0000 */
         Console.WriteLine("Line 5 - Value of c is {0}", c);

         c = a >> 2;      /* 15 = 0000 1111 */
         Console.WriteLine("Line 6 - Value of c is {0}", c);
         Console.ReadLine();
      }
   }
}
```

#### Assignment Operators
There are following assignment operators supported by C# −

![assignment operators](imgs/assignment-operators.png)
```
using System;

namespace OperatorsAppl {

   class Program {

      static void Main(string[] args) {
         int a = 21;
         int c;
         c = a;
         Console.WriteLine("Line 1 - =  Value of c = {0}", c);

         c += a;
         Console.WriteLine("Line 2 - += Value of c = {0}", c);

         c -= a;
         Console.WriteLine("Line 3 - -=  Value of c = {0}", c);

         c *= a;
         Console.WriteLine("Line 4 - *=  Value of c = {0}", c);

         c /= a;
         Console.WriteLine("Line 5 - /=  Value of c = {0}", c);

         c = 200;
         c %= a;
         Console.WriteLine("Line 6 - %=  Value of c = {0}", c);

         c <<= 2;
         Console.WriteLine("Line 7 - <<=  Value of c = {0}", c);

         c >>= 2;
         Console.WriteLine("Line 8 - >>=  Value of c = {0}", c);

         c &= 2;
         Console.WriteLine("Line 9 - &=  Value of c = {0}", c);

         c ^= 2;
         Console.WriteLine("Line 10 - ^=  Value of c = {0}", c);

         c |= 2;
         Console.WriteLine("Line 11 - |=  Value of c = {0}", c);
         Console.ReadLine();
      }
   }
}
```

#### Miscellaneous Operators

![misc operators](imgs/misc-operators.png)

#### Operator Precedence in C#
Operator precedence determines the grouping of terms in an expression. This affects evaluation of an expression. Certain operators have higher precedence than others; for example, the multiplication operator has higher precedence than the addition operator.

For example x = 7 + 3 * 2; here, x is assigned 13, not 20 because operator * has higher precedence than +, so the first evaluation takes place for 3*2 and then 7 is added into it.

Here, operators with the highest precedence appear at the top of the table, those with the lowest appear at the bottom. Within an expression, higher precedence operators are evaluated first.

![precedence](imgs/precedence.png)




### Challenges
#### Challenge 1 – String and its methods

Now you know the use of various string functions so let’s create a small Console application to practice this.

Declare a string variable and don’t assign any value to it.

Print on the console “Please enter your name and press enter”. You can then enter your name or any other valid string like “tutorials.eu”.

Assign that entered string to the string variable which you have declared initially.

The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line. In the third line, it writes on the console the string with no trailing or preceding white space like if string entered as “ tutorials.eu ” it should be written on the console as “tutorials.eu”. And in the last line, it should write the Substring of the entered string on the console.

These kinds of features are e.g. used when creating a login screen, where the system will cut out trailing or preceding white space or, doesn’t care about the casing of the entered username.

#### Challenge String and its methods 2

Let’s create another console application for more practice.

This application asks the user to input a string in the first line like “Enter a string here: ”.

In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”

On the third line, it should write the index of the first occurrence of the searched character from the string.

Now on concatenation...

It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.

It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, before displaying it.


## Functions/Methods - Code Reuse

### Methods in C#

A method is a group of statements that together perform a task. Every C# program has at least one class with a method named Main.

To use a method, you need to −

- Define the method
- Call the method

#### Defining Methods in C#
When you define a method, you basically declare the elements of its structure. The syntax for defining a method in C# is as follows −
```
<Access Specifier> <Return Type> <Method Name>(Parameter List) {
   Method Body
}
```
Following are the various elements of a method −

- Access Specifier − This determines the visibility of a variable or a method from another class.
- Return type − A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.
- Method name − Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.
- Parameter list − Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
- Method body − This contains the set of instructions needed to complete the required activity.

Following code snippet shows a function FindMax that takes two integer values and returns the larger of the two. It has public access specifier, so it can be accessed from outside the class using an instance of the class.
```
class NumberManipulator {

   public int FindMax(int num1, int num2) {
      /* local variable declaration */
      int result;

      if (num1 > num2)
         result = num1;
      else
         result = num2;

      return result;
   }
   ...
}
```

#### Calling Methods in C#
You can call a method using the name of the method. The following example illustrates this −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public int FindMax(int num1, int num2) {
         /* local variable declaration */
         int result;

         if (num1 > num2)
            result = num1;
         else
            result = num2;
         return result;
      }

      static void Main(string[] args) {
         /* local variable definition */
         int a = 100;
         int b = 200;
         int ret;
         NumberManipulator n = new NumberManipulator();

         //calling the FindMax method
         ret = n.FindMax(a, b);
         Console.WriteLine("Max value is : {0}", ret );
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −
```
Max value is : 200
```

You can also call public method from other classes by using the instance of the class. For example, the method FindMax belongs to the NumberManipulator class, you can call it from another class Test.
```

using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public int FindMax(int num1, int num2) {
         /* local variable declaration */
         int result;

         if(num1 > num2)
            result = num1;
         else
            result = num2;

         return result;
      }
   }
   class Test {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 100;
         int b = 200;
         int ret;
         NumberManipulator n = new NumberManipulator();

         //calling the FindMax method
         ret = n.FindMax(a, b);
         Console.WriteLine("Max value is : {0}", ret );
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
Max value is : 200
```

#### Recursive Method Call
A method can call itself. This is known as recursion. Following is an example that calculates factorial for a given number using a recursive function −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public int factorial(int num) {
         /* local variable declaration */
         int result;
         if (num == 1) {
            return 1;
         } else {
            result = factorial(num - 1) * num;
            return result;
         }
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         //calling the factorial method {0}", n.factorial(6));
         Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
         Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
Factorial of 6 is: 720
Factorial of 7 is: 5040
Factorial of 8 is: 40320
```

#### Passing Parameters to a Method
When method with parameters is called, you need to pass the parameters to the method. There are three ways that parameters can be passed to a method −

1. Value Parameters:
2. Reference parameters
3. Output parameters


##### Value Parameters
This is the default mechanism for passing parameters to a method. In this mechanism, when a method is called, a new storage location is created for each value parameter.

The values of the actual parameters are copied into them. Hence, the changes made to the parameter inside the method have no effect on the argument. The following example demonstrates the concept −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void swap(int x, int y) {
         int temp;

         temp = x; /* save the value of x */
         x = y;    /* put y into x */
         y = temp; /* put temp into y */
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();

         /* local variable definition */
         int a = 100;
         int b = 200;

         Console.WriteLine("Before swap, value of a : {0}", a);
         Console.WriteLine("Before swap, value of b : {0}", b);

         /* calling a function to swap the values */
         n.swap(a, b);

         Console.WriteLine("After swap, value of a : {0}", a);
         Console.WriteLine("After swap, value of b : {0}", b);

         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Before swap, value of a :100
Before swap, value of b :200
After swap, value of a :100
After swap, value of b :200
```

It shows that there is no change in the values though they had changed inside the function.

##### Reference Parameters
A reference parameter is a reference to a memory location of a variable. When you pass parameters by reference, unlike value parameters, a new storage location is not created for these parameters. The reference parameters represent the same memory location as the actual parameters that are supplied to the method.

You can declare the reference parameters using the ref keyword. The following example demonstrates this −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void swap(ref int x, ref int y) {
         int temp;

         temp = x; /* save the value of x */
         x = y;    /* put y into x */
         y = temp; /* put temp into y */
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();

         /* local variable definition */
         int a = 100;
         int b = 200;

         Console.WriteLine("Before swap, value of a : {0}", a);
         Console.WriteLine("Before swap, value of b : {0}", b);

         /* calling a function to swap the values */
         n.swap(ref a, ref b);

         Console.WriteLine("After swap, value of a : {0}", a);
         Console.WriteLine("After swap, value of b : {0}", b);

         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Before swap, value of a : 100
Before swap, value of b : 200
After swap, value of a : 200
After swap, value of b : 100
```

It shows that the values have changed inside the swap function and this change reflects in the Main function.


##### Output Parameters
A return statement can be used for returning only one value from a function. However, using output parameters, you can return two values from a function. Output parameters are similar to reference parameters, except that they transfer data out of the method rather than into it.

The following example illustrates this −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void getValue(out int x ) {
         int temp = 5;
         x = temp;
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();

         /* local variable definition */
         int a = 100;

         Console.WriteLine("Before method call, value of a : {0}", a);

         /* calling a function to get the value */
         n.getValue(out a);

         Console.WriteLine("After method call, value of a : {0}", a);
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
Before method call, value of a : 100
After method call, value of a : 5
```

The variable supplied for the output parameter need not be assigned a value. Output parameters are particularly useful when you need to return values from a method through the parameters without assigning an initial value to the parameter. Go through the following example, to understand this −

```
using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void getValues(out int x, out int y ) {
          Console.WriteLine("Enter the first value: ");
          x = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the second value: ");
          y = Convert.ToInt32(Console.ReadLine());
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();

         /* local variable definition */
         int a , b;

         /* calling a function to get the values */
         n.getValues(out a, out b);

         Console.WriteLine("After method call, value of a : {0}", a);
         Console.WriteLine("After method call, value of b : {0}", b);
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
Enter the first value:
7
Enter the second value:
8
After method call, value of a : 7
After method call, value of b : 8
```

## Exception Handling in C#
An exception is a problem that arises during the execution of a program. A C# exception is a response to an exceptional circumstance that arises while a program is running, such as an attempt to divide by zero.

Exceptions provide a way to transfer control from one part of a program to another. C# exception handling is built upon four keywords: try, catch, finally, and throw.

- try − A try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks.
- catch − A program catches an exception with an exception handler at the place in a program where you want to handle the problem. The catch keyword indicates the catching of an exception.
- finally − The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. For example, if you open a file, it must be closed whether an exception is raised or not.
- throw − A program throws an exception when a problem shows up. This is done using a throw keyword.

### Syntax
Assuming a block raises an exception, a method catches an exception using a combination of the try and catch keywords. A try/catch block is placed around the code that might generate an exception. Code within a try/catch block is referred to as protected code, and the syntax for using try/catch looks like the following −
```
try {
   // statements causing exception
} catch( ExceptionName e1 ) {
   // error handling code
} catch( ExceptionName e2 ) {
   // error handling code
} catch( ExceptionName eN ) {
   // error handling code
} finally {
   // statements to be executed
}
```
You can list down multiple catch statements to catch different type of exceptions in case your try block raises more than one exception in different situations.

### Exception Classes in C#
C# exceptions are represented by classes. The exception classes in C# are mainly directly or indirectly derived from the System.Exception class. Some of the exception classes derived from the System.Exception class are the System.ApplicationException and System.SystemException classes.

The System.ApplicationException class supports exceptions generated by application programs. Hence the exceptions defined by the programmers should derive from this class.

The System.SystemException class is the base class for all predefined system exception.

The following table provides some of the predefined exception classes derived from the Sytem.SystemException class −
![exceptions](imgs/exceptions.png


### Handling Exceptions
C# provides a structured solution to the exception handling in the form of try and catch blocks. Using these blocks the core program statements are separated from the error-handling statements.

These error handling blocks are implemented using the try, catch, and finally keywords. Following is an example of throwing an exception when dividing by zero condition occurs −

```
using System;

namespace ErrorHandlingApplication {
   class DivNumbers {
      int result;

      DivNumbers() {
         result = 0;
      }
      public void division(int num1, int num2) {
         try {
            result = num1 / num2;
         } catch (DivideByZeroException e) {
            Console.WriteLine("Exception caught: {0}", e);
         } finally {
            Console.WriteLine("Result: {0}", result);
         }
      }
      static void Main(string[] args) {
         DivNumbers d = new DivNumbers();
         d.division(25, 0);
         Console.ReadKey();
      }
   }
}
```


When the above code is compiled and executed, it produces the following result −

```
Exception caught: System.DivideByZeroException: Attempted to divide by zero.
at ...
Result: 0
```

### Creating User-Defined Exceptions
You can also define your own exception. User-defined exception classes are derived from the Exception class. The following example demonstrates this −

```
using System;

namespace UserDefinedException {
   class TestTemperature {
      static void Main(string[] args) {
         Temperature temp = new Temperature();
         try {
            temp.showTemp();
         } catch(TempIsZeroException e) {
            Console.WriteLine("TempIsZeroException: {0}", e.Message);
         }
         Console.ReadKey();
      }
   }
}
public class TempIsZeroException: Exception {
   public TempIsZeroException(string message): base(message) {
   }
}
public class Temperature {
   int temperature = 0;

   public void showTemp() {

      if(temperature == 0) {
         throw (new TempIsZeroException("Zero Temperature found"));
      } else {
         Console.WriteLine("Temperature: {0}", temperature);
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
TempIsZeroException: Zero Temperature found
```

### Throwing Objects
You can throw an object if it is either directly or indirectly derived from the System.Exception class. You can use a throw statement in the catch block to throw the present object as −
```

Catch(Exception e) {
   ...
   Throw e
}
```

## Decision Making
Decision making structures requires the programmer to specify one or more conditions to be evaluated or tested by the program, along with a statement or statements to be executed if the condition is determined to be true, and optionally, other statements to be executed if the condition is determined to be false.

Following is the general form of a typical decision making structure found in most of the programming languages −
![decision making](imgs/decision-making.png)

C# provides following types of decision making statements

1. if statement
2. if...else statement
3. nested if statements
4. switch statement
5. nested switch statements


### if Statement
An if statement consists of a boolean expression followed by one or more statements.

#### Syntax
The syntax of an if statement in C# is −
```
if(boolean_expression) {
   /* statement(s) will execute if the boolean expression is true */
}
```

If the boolean expression evaluates to true, then the block of code inside the if statement is executed. If boolean expression evaluates to false, then the first set of code after the end of the if statement(after the closing curly brace) is executed.
![if statement](imgs/if-statement.png)

#### Example

```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;

         /* check the boolean condition using if statement */
         if (a < 20) {
            /* if condition is true then print the following */
            Console.WriteLine("a is less than 20");
         }
         Console.WriteLine("value of a is : {0}", a);
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −
```
a is less than 20;
value of a is : 10
```

### if...else statement
An if statement can be followed by an optional else statement, which executes when the boolean expression is false.

#### Syntax
The syntax of an if...else statement in C# is −

```
if(boolean_expression) {
   /* statement(s) will execute if the boolean expression is true */
} else {
   /* statement(s) will execute if the boolean expression is false */
}
```

If the boolean expression evaluates to true, then the if block of code is executed, otherwise else block of code is executed.
![ifelseflowdiagram](imgs/ifelseflowdiagram.png)

#### Example
```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 100;

         /* check the boolean condition */
         if (a < 20) {
            /* if condition is true then print the following */
            Console.WriteLine("a is less than 20");
         } else {
            /* if condition is false then print the following */
            Console.WriteLine("a is not less than 20");
         }
         Console.WriteLine("value of a is : {0}", a);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
a is not less than 20;
value of a is : 100
```
### The if...else if...else Statement
An if statement can be followed by an optional else if...else statement, which is very useful to test various conditions using single if...else if statement.

When using if, else if, else statements there are few points to keep in mind.

- An if can have zero or one else's and it must come after any else if's.
- An if can have zero to many else if's and they must come before the else.
- Once an else if succeeds, none of the remaining else if's or else's will be tested.

#### Syntax
The syntax of an if...else if...else statement in C# is −

```
if(boolean_expression 1) {
   /* Executes when the boolean expression 1 is true */
}
else if( boolean_expression 2) {
   /* Executes when the boolean expression 2 is true */
}
else if( boolean_expression 3) {
   /* Executes when the boolean expression 3 is true */
} else {
   /* executes when the none of the above condition is true */
}
```

#### Example
```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 100;

         /* check the boolean condition */
         if (a == 10) {
            /* if condition is true then print the following */
            Console.WriteLine("Value of a is 10");
         }
         else if (a == 20) {
            /* if else if condition is true */
            Console.WriteLine("Value of a is 20");
         }
         else if (a == 30) {
            /* if else if condition is true  */
            Console.WriteLine("Value of a is 30");
         } else {
            /* if none of the conditions is true */
            Console.WriteLine("None of the values is matching");
         }
         Console.WriteLine("Exact value of a is: {0}", a);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
None of the values is matching
Exact value of a is: 100
```

### Nested if statements
It is always legal in C# to nest if-else statements, which means you can use one if or else if statement inside another if or else if statement(s).

#### Syntax
The syntax for a nested if statement is as follows −
```
if( boolean_expression 1) {
   /* Executes when the boolean expression 1 is true */
   if(boolean_expression 2) {
      /* Executes when the boolean expression 2 is true */
   }
}
```
You can nest else if...else in the similar way as you have nested if statement.

#### Example
```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         //* local variable definition */
         int a = 100;
         int b = 200;

         /* check the boolean condition */
         if (a == 100) {

            /* if condition is true then check the following */
            if (b == 200) {
               /* if condition is true then print the following */
               Console.WriteLine("Value of a is 100 and b is 200");
            }
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
Value of a is 100 and b is 200
Exact value of a is : 100
Exact value of b is : 200
```

### Switch statement
A switch statement allows a variable to be tested for equality against a list of values. Each value is called a case, and the variable being switched on is checked for each switch case.

#### Syntax
The syntax for a switch statement in C# is as follows −
```
switch(expression) {
   case constant-expression1  :
      statement(s);
      break;
   case constant-expression2  :
   case constant-expression3  :
      statement(s);
      break;

   /* you can have any number of case statements */
   default : /* Optional */
   statement(s);
}
```

The following rules apply to a switch statement −

- The expression used in a switch statement must have an integral or enumerated type, or be of a class type in which the class has a single conversion function to an integral or enumerated type.
- You can have any number of case statements within a switch. Each case is followed by the value to be compared to and a colon.
- The constant-expression for a case must be the same data type as the variable in the switch, and it must be a constant or a literal.
- When the variable being switched on is equal to a case, the statements following that case will execute until a break statement is reached.
- When a break statement is reached, the switch terminates, and the flow of control jumps to the next line following the switch statement.
- Not every case needs to contain a break. If no break appears, then it will raise a compile time error.
- A switch statement can have an optional default case, which must appear at the end of the switch. The default case can be used for performing a task when none of the cases is true.

#### Flow diagram
![switch flow diagram](imgs/switch-flow-diagram.png)

#### Example
```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         char grade = 'B';

         switch (grade) {
            case 'A':
               Console.WriteLine("Excellent!");
               break;
            case 'B':
            case 'C':
               Console.WriteLine("Well done");
               break;
            case 'D':
               Console.WriteLine("You passed");
               break;
            case 'F':
               Console.WriteLine("Better try again");
               break;
               default:
            Console.WriteLine("Invalid grade");
               break;
         }
         Console.WriteLine("Your grade is  {0}", grade);
         Console.ReadLine();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
Well done
Your grade is B
```

### Nested Switch
It is possible to have a switch as part of the statement sequence of an outer switch. Even if the case constants of the inner and outer switch contain common values, no conflicts will arise.

#### Syntax
The syntax for a nested switch statement is as follows −

```
switch(ch1) {
   case 'A':
   Console.WriteLine("This A is part of outer switch" );

   switch(ch2) {
      case 'A':
         Console.WriteLine("This A is part of inner switch" );
         break;
      case 'B': /* inner B case code */
   }
   break;
   case 'B': /* outer B case code */
}
```

#### Example
```
using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         int a = 100;
         int b = 200;

         switch (a) {
            case 100:
            Console.WriteLine("This is part of outer switch ");

            switch (b) {
               case 200:
               Console.WriteLine("This is part of inner switch ");
               break;
            }
            break;
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
This is part of outer switch
This is part of inner switch
Exact value of a is : 100
Exact value of b is : 200

```

### The ? : Operator
We have covered conditional operator ? : in previous chapter which can be used to replace if...else statements. It has the following general form −

```
Exp1 ? Exp2 : Exp3;
```

Where Exp1, Exp2, and Exp3 are expressions. Notice the use and placement of the colon.

The value of a ? expression is determined as follows: Exp1 is evaluated. If it is true, then Exp2 is evaluated and becomes the value of the entire ? expression. If Exp1 is false, then Exp3 is evaluated and its value becomes the value of the expression.

### TryParse Methods in C#
Convert a string representation of number to an integer, using the int.TryParse method in C#. If the string cannot be converted, then the int.TryParse method returns false i.e. a Boolean value.

Let’s say you have a string representation of a number.
```
string myStr = "12";
```

Now to convert it to an integer, use the int.TryParse(). It will get converted and will return True.
```
int.TryParse(myStr, out a);
```

#### Example
```
using System.IO;
using System;
class Program {
   static void Main() {
      bool res;
      int a;
      string myStr = "12";
      res = int.TryParse(myStr, out a);
      Console.WriteLine("String is a numeric representation: "+res);
   }
}
```
Output
```
String is a numeric representation: True
```

## Loops in C#
There may be a situation, when you need to execute a block of code several number of times. In general, the statements are executed sequentially: The first statement in a function is executed first, followed by the second, and so on.

Programming languages provide various control structures that allow for more complicated execution paths.

A loop statement allows us to execute a statement or a group of statements multiple times and following is the general from of a loop statement in most of the programming languages −
![loop flow diagram](imgs/loop-flow-diagram.png)

C# provides following types of loop to handle looping requirements

1. while loop
2. for loop
3. do...while loop
4. foreach loop

### While Loop
A while loop statement in C# repeatedly executes a target statement as long as a given condition is true.

#### Syntax
The syntax of a while loop in C# is −
```
while(condition) {
   statement(s);
}
```
Here, statement(s) may be a single statement or a block of statements. The condition may be any expression, and true is any non-zero value. The loop iterates while the condition is true.

When the condition becomes false, program control passes to the line immediately following the loop.

#### Flow Diagram
![while loop flow diagram](imgs/while-loop-flow-diagram.png)

Here, key point of the while loop is that the loop might not ever run. When the condition is tested and the result is false, the loop body is skipped and the first statement after the while loop is executed.

#### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;

         /* while loop execution */
         while (a < 20) {
            Console.WriteLine("value of a: {0}", a);
            a++;
         }
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
value of a: 16
value of a: 17
value of a: 18
value of a: 19
```

### for loop
A for loop is a repetition control structure that allows you to efficiently write a loop that needs to execute a specific number of times.

#### Syntax
The syntax of a for loop in C# is −

```
for ( init; condition; increment ) {
   statement(s);
}
```

Here is the flow of control in a for loop −

- The init step is executed first, and only once. This step allows you to declare and initialize any loop control variables. You are not required to put a statement here, as long as a semicolon appears.
- Next, the condition is evaluated. If it is true, the body of the loop is executed. If it is false, the body of the loop does not execute and flow of control jumps to the next statement just after the for loop.
- After the body of the for loop executes, the flow of control jumps back up to the increment statement. This statement allows you to update any loop control variables. This statement can be left blank, as long as a semicolon appears after the condition.
- The condition is now evaluated again. If it is true, the loop executes and the process repeats itself (body of loop, then increment step, and then again testing for a condition). After the condition becomes false, the for loop terminates.

#### Flow Diagram
![for loop flow diagram](imgs/for-loop-flow-diagram.png)

#### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {

         /* for loop execution */
         for (int a = 10; a < 20; a = a + 1) {
            Console.WriteLine("value of a: {0}", a);
         }
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
value of a: 16
value of a: 17
value of a: 18
value of a: 19
```

### do...while Loop
Unlike for and while loops, which test the loop condition at the start of the loop, the do...while loop checks its condition at the end of the loop.

A do...while loop is similar to a while loop, except that a do...while loop is guaranteed to execute at least one time.

#### Syntax
The syntax of a do...while loop in C# is −

```
do {
   statement(s);
} while( condition );
```

Notice that the conditional expression appears at the end of the loop, so the statement(s) in the loop execute once before the condition is tested.

If the condition is true, the flow of control jumps back up to do, and the statement(s) in the loop execute again. This process repeats until the given condition becomes false.

#### Flow Diagram
![dowhile loop flow diagram](imgs/dowhile-loop-flow-diagram.png)

#### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;

         /* do loop execution */
         do {
            Console.WriteLine("value of a: {0}", a);
            a = a + 1;
         }
         while (a < 20);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
value of a: 16
value of a: 17
value of a: 18
value of a: 19
```

### Nested Loop
C# allows to use one loop inside another loop. Following section shows few examples to illustrate the concept.

####Syntax
The syntax for a nested for loop statement in C# is as follows −
```

for ( init; condition; increment ) {
   for ( init; condition; increment ) {
      statement(s);
   }
   statement(s);
}
```

The syntax for a nested while loop statement in C# is as follows −

```
while(condition) {
   while(condition) {
      statement(s);
   }
   statement(s);
}
```
The syntax for a nested do...while loop statement in C# is as follows −
```
do {
   statement(s);
   do {
      statement(s);
   }
   while( condition );
}
while( condition );
```



__A final note on loop nesting is that you can put any type of loop inside of any other type of loop. For example a for loop can be inside a while loop or vice versa.__

#### Example
The following program uses a nested for loop to find the prime numbers from 2 to 100 −

```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int i, j;

         for (i = 2; i < 100; i++) {
            for (j = 2; j <= (i / j); j++)
            if ((i % j) == 0) break; // if factor found, not prime
            if (j > (i / j)) Console.WriteLine("{0} is prime", i);
         }
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
2 is prime
3 is prime
5 is prime
7 is prime
11 is prime
13 is prime
17 is prime
19 is prime
23 is prime
29 is prime
31 is prime
37 is prime
41 is prime
43 is prime
47 is prime
53 is prime
59 is prime
61 is prime
67 is prime
71 is prime
73 is prime
79 is prime
83 is prime
89 is prime
97 is prime
```

### Loop Control Statements
Loop control statements change execution from its normal sequence. When execution leaves a scope, all automatic objects that were created in that scope are destroyed.

C# provides the following control statements.
Sr. No  |  Control Statement & Description
--|--
1  |  break - Terminates the loop or switch statement and transfers execution to the statement immediately following the loop or switch.  |  
2 | continue - Causes the loop to skip the remainder of its body and immediately retest its condition prior to reiterating.  |  

#### break statement
The break statement in C# has following two usage −

- When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes at the next statement following the loop.
- It can be used to terminate a case in the switch statement.

If you are using nested loops (i.e., one loop inside another loop), the break statement will stop the execution of the innermost loop and start executing the next line of code after the block.

##### Syntax
The syntax for a break statement in C# is as follows −

```
break;
```


##### Flow Diagram
![break flow diagram](imgs/break-flow-diagram.png)

##### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;

         /* while loop execution */
         while (a < 20) {
            Console.WriteLine("value of a: {0}", a);
            a++;

            if (a > 15) {
               /* terminate the loop using break statement */
               break;
            }
         }
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −
```
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
```

#### continue statement
The continue statement in C# works somewhat like the break statement. Instead of forcing termination, however, continue forces the next iteration of the loop to take place, skipping any code in between.

For the for loop, continue statement causes the conditional test and increment portions of the loop to execute. For the while and do...while loops, continue statement causes the program control passes to the conditional tests.

##### Syntax
The syntax for a continue statement in C# is as follows −

```
continue;
```

##### Flow Diagram
![continue flow diagram](imgs/continue-flow-diagram.png)

##### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int a = 10;

         /* do loop execution */
         do {
            if (a == 15) {
               /* skip the iteration */
               a = a + 1;
               continue;
            }
            Console.WriteLine("value of a: {0}", a);
            a++;
         }
         while (a < 20);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 16
value of a: 17
value of a: 18
value of a: 19
```

### Infinite Loop
Infinite Loop
A loop becomes infinite loop if a condition never becomes false. The for loop is traditionally used for this purpose. Since none of the three expressions that form the for loop are required, you can make an endless loop by leaving the conditional expression empty.

#### Example
```
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         for (; ; ) {
            Console.WriteLine("Hey! I am Trapped");
         }
      }
   }
}
```

When the conditional expression is absent, it is assumed to be true. You may have an initialization and increment expression, but programmers more commonly use the for(;;) construct to signify an infinite loop.

## Encapsulation
Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. Encapsulation, in object oriented programming methodology, prevents access to implementation details.

Abstraction and encapsulation are related features in object oriented programming. Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction.

Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers −

- Public
- Private
- Protected
- Internal
- Protected internal

### Public Access Specifier
Public access specifier allows a class to expose its member variables and member functions to other functions and objects. Any public member can be accessed from outside the class.

The following example illustrates this −

```
using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      public double length;
      public double width;
      
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Length: 4.5
Width: 3.5
Area: 15.75
```
In the preceding example, the member variables length and width are declared public, so they can be accessed from the function Main() using an instance of the Rectangle class, named r.

The member function Display() and GetArea() can also access these variables directly without using any instance of the class.

The member functions Display() is also declared public, so it can also be accessed from Main() using an instance of the Rectangle class, named r.


### Private Access Specifier
Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.

The following example illustrates this −
```

using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      private double length;
      private double width;
      
      public void Acceptdetails() {
         Console.WriteLine("Enter Length: ");
         length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter Width: ");
         width = Convert.ToDouble(Console.ReadLine());
      }
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Enter Length:
4.4
Enter Width:
3.3
Length: 4.4
Width: 3.3
Area: 14.52

```

In the preceding example, the member variables length and width are declared private, so they cannot be accessed from the function Main(). The member functions AcceptDetails() and Display() can access these variables. Since the member functions AcceptDetails() and Display() are declared public, they can be accessed from Main() using an instance of the Rectangle class, named r.



### Protected Access Specifier
Protected access specifier allows a child class to access the member variables and member functions of its base class. This way it helps in implementing inheritance. We will discuss this in more details in the inheritance chapter.


### Internal Access Specifier
Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.

The following program illustrates this −

```
using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      internal double length;
      internal double width;
      
      double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}
```


When the above code is compiled and executed, it produces the following result −

```
Length: 4.5
Width: 3.5
Area: 15.75
```
In the preceding example, notice that the member function GetArea() is not declared with any access specifier. Then what would be the default access specifier of a class member if we don't mention any? It is private.


### Protected Internal Access Specifier
The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application. This is also used while implementing inheritance.


## Nullables

C# provides a special data types, the nullable types, to which you can assign normal range of values as well as null values.

For example, you can store any value from -2,147,483,648 to 2,147,483,647 or null in a Nullable<Int32> variable. Similarly, you can assign true, false, or null in a Nullable<bool> variable. Syntax for declaring a nullable type is as follows −

```
< data_type> ? <variable_name> = null;
```


The following example demonstrates use of nullable data types −


```
using System;

namespace CalculatorApplication {
   class NullablesAtShow {
      static void Main(string[] args) {
         int? num1 = null;
         int? num2 = 45;
         
         double? num3 = new double?();
         double? num4 = 3.14157;
         
         bool? boolval = new bool?();

         // display the values
         Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
         Console.WriteLine("A Nullable boolean value: {0}", boolval);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Nullables at Show: , 45,  , 3.14157
A Nullable boolean value:
```

### The Null Coalescing Operator (??)
The null coalescing operator is used with the nullable value types and reference types. It is used for converting an operand to the type of another nullable (or not) value type operand, where an implicit conversion is possible.

If the value of the first operand is null, then the operator returns the value of the second operand, otherwise it returns the value of the first operand. The following example explains this −

```
using System;

namespace CalculatorApplication {
   class NullablesAtShow {
      static void Main(string[] args) {
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         
         num3 = num1 ?? 5.34;      
         Console.WriteLine(" Value of num3: {0}", num3);
         
         num3 = num2 ?? 5.34;
         Console.WriteLine(" Value of num3: {0}", num3);
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Value of num3: 5.34
Value of num3: 3.14157
```


## Object Oriented Programming
### Classes
When you define a class, you define a blueprint for a data type. This does not actually define any data, but it does define what the class name means. That is, what an object of the class consists of and what operations can be performed on that object. Objects are instances of a class. The methods and variables that constitute a class are called members of the class.

#### Defining a Class
A class definition starts with the keyword class followed by the class name; and the class body enclosed by a pair of curly braces. Following is the general form of a class definition −
```
<access specifier> class  class_name {
   // member variables
   <access specifier> <data type> variable1;
   <access specifier> <data type> variable2;
   ...
   <access specifier> <data type> variableN;
   // member methods
   <access specifier> <return type> method1(parameter_list) {
      // method body
   }
   <access specifier> <return type> method2(parameter_list) {
      // method body
   }
   ...
   <access specifier> <return type> methodN(parameter_list) {
      // method body
   }
}
```

Note −

- Access specifiers specify the access rules for the members as well as the class itself. If not mentioned, then the default access specifier for a class type is internal. Default access for the members is private.
- 
- Data type specifies the type of variable, and return type specifies the data type of the data the method returns, if any.
- 
- To access the class members, you use the dot (.) operator.
- 
- The dot operator links the name of an object with the name of a member.

The following example illustrates the concepts discussed so far −

```
using System;

namespace BoxApplication {
   class Box {
      public double length;   // Length of a box
      public double breadth;  // Breadth of a box
      public double height;   // Height of a box
   }
   class Boxtester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();   // Declare Box2 of type Box
         double volume = 0.0;    // Store the volume of a box here

         // box 1 specification
         Box1.height = 5.0;
         Box1.length = 6.0;
         Box1.breadth = 7.0;

         // box 2 specification
         Box2.height = 10.0;
         Box2.length = 12.0;
         Box2.breadth = 13.0;
           
         // volume of box 1
         volume = Box1.height * Box1.length * Box1.breadth;
         Console.WriteLine("Volume of Box1 : {0}",  volume);

         // volume of box 2
         volume = Box2.height * Box2.length * Box2.breadth;
         Console.WriteLine("Volume of Box2 : {0}", volume);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Volume of Box1 : 210
Volume of Box2 : 1560
```


### Member Functions and Encapsulation
A member function of a class is a function that has its definition or its prototype within the class definition similar to any other variable. It operates on any object of the class of which it is a member, and has access to all the members of a class for that object.

Member variables are the attributes of an object (from design perspective) and they are kept private to implement encapsulation. These variables can only be accessed using the public member functions.

Let us put above concepts to set and get the value of different class members in a class −

```
using System;

namespace BoxApplication {
   class Box {
      private double length;   // Length of a box
      private double breadth;  // Breadth of a box
      private double height;   // Height of a box
      
      public void setLength( double len ) {
         length = len;
      }
      public void setBreadth( double bre ) {
         breadth = bre;
      }
      public void setHeight( double hei ) {
         height = hei;
      }
      public double getVolume() {
         return length * breadth * height;
      }
   }
   class Boxtester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();
         double volume;
         
         // Declare Box2 of type Box
         // box 1 specification
         Box1.setLength(6.0);
         Box1.setBreadth(7.0);
         Box1.setHeight(5.0);
         
         // box 2 specification
         Box2.setLength(12.0);
         Box2.setBreadth(13.0);
         Box2.setHeight(10.0);
         
         // volume of box 1
         volume = Box1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}" ,volume);
         
         // volume of box 2
         volume = Box2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);
         
         Console.ReadKey();
      }
   }
}
```


When the above code is compiled and executed, it produces the following result −

```
Volume of Box1 : 210
Volume of Box2 : 1560
```

### C# Constructors
A class constructor is a special member function of a class that is executed whenever we create new objects of that class.

A constructor has exactly the same name as that of class and it does not have any return type. Following example explains the concept of constructor −

```
using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      
      public Line() {
         Console.WriteLine("Object is being created");
      }
      public void setLength( double len ) {
         length = len;
      }
      public double getLength() {
         return length;
      }

      static void Main(string[] args) {
         Line line = new Line();    
         
         // set line length
         line.setLength(6.0);
         Console.WriteLine("Length of line : {0}", line.getLength());
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Object is being created
Length of line : 6
```


A default constructor does not have any parameter but if you need, a constructor can have parameters. Such constructors are called parameterized constructors. This technique helps you to assign initial value to an object at the time of its creation as shown in the following example −

```
using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      
      public Line(double len) {  //Parameterized constructor
         Console.WriteLine("Object is being created, length = {0}", len);
         length = len;
      }
      public void setLength( double len ) {
         length = len;
      }
      public double getLength() {
         return length;
      }
      static void Main(string[] args) {
         Line line = new Line(10.0);
         Console.WriteLine("Length of line : {0}", line.getLength()); 
         
         // set line length
         line.setLength(6.0);
         Console.WriteLine("Length of line : {0}", line.getLength()); 
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Object is being created, length = 10
Length of line : 10
Length of line : 6
```

### C# Destructors
A destructor is a special member function of a class that is executed whenever an object of its class goes out of scope. A destructor has exactly the same name as that of the class with a prefixed tilde (~) and it can neither return a value nor can it take any parameters.

Destructor can be very useful for releasing memory resources before exiting the program. Destructors cannot be inherited or overloaded.

Following example explains the concept of destructor −


```
using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      
      public Line() {   // constructor
         Console.WriteLine("Object is being created");
      }
      ~Line() {   //destructor
         Console.WriteLine("Object is being deleted");
      }
      public void setLength( double len ) {
         length = len;
      }
      public double getLength() {
         return length;
      }
      static void Main(string[] args) {
         Line line = new Line();

         // set line length
         line.setLength(6.0);
         Console.WriteLine("Length of line : {0}", line.getLength());           
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Object is being created
Length of line : 6
Object is being deleted
```

### Static Members of a C# Class
We can define class members as static using the static keyword. When we declare a member of a class as static, it means no matter how many objects of the class are created, there is only one copy of the static member.

The keyword static implies that only one instance of the member exists for a class. Static variables are used for defining constants because their values can be retrieved by invoking the class without creating an instance of it. Static variables can be initialized outside the member function or class definition. You can also initialize static variables inside the class definition.

The following example demonstrates the use of static variables −

```
using System;

namespace StaticVarApplication {
   class StaticVar {
      public static int num;
      
      public void count() {
         num++;
      }
      public int getNum() {
         return num;
      }
   }
   class StaticTester {
      static void Main(string[] args) {
         StaticVar s1 = new StaticVar();
         StaticVar s2 = new StaticVar();
         
         s1.count();
         s1.count();
         s1.count();
         
         s2.count();
         s2.count();
         s2.count();
         
         Console.WriteLine("Variable num for s1: {0}", s1.getNum());
         Console.WriteLine("Variable num for s2: {0}", s2.getNum());
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Variable num for s1: 6
Variable num for s2: 6
```

You can also declare a member function as static. Such functions can access only static variables. The static functions exist even before the object is created. The following example demonstrates the use of static functions −


```
using System;

namespace StaticVarApplication {
   class StaticVar {
      public static int num;
      
      public void count() {
         num++;
      }
      public static int getNum() {
         return num;
      }
   }
   class StaticTester {
      static void Main(string[] args) {
         StaticVar s = new StaticVar();
         
         s.count();
         s.count();
         s.count();
         
         Console.WriteLine("Variable num: {0}", StaticVar.getNum());
         Console.ReadKey();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Variable num: 3
```


### Inheritance
One of the most important concepts in object-oriented programming is inheritance. Inheritance allows us to define a class in terms of another class, which makes it easier to create and maintain an application. This also provides an opportunity to reuse the code functionality and speeds up implementation time.

When creating a class, instead of writing completely new data members and member functions, the programmer can designate that the new class should inherit the members of an existing class. This existing class is called the base class, and the new class is referred to as the derived class.

The idea of inheritance implements the IS-A relationship. For example, mammal IS A animal, dog IS-A mammal hence dog IS-A animal as well, and so on.

#### Base and Derived Classes
A class can be derived from more than one class or interface, which means that it can inherit data and functions from multiple base classes or interfaces.

The syntax used in C# for creating derived classes is as follows −

```
<acess-specifier> class <base_class> {
   ...
}

class <derived_class> : <base_class> {
   ...
}
```


Consider a base class Shape and its derived class Rectangle −

```
using System;

namespace InheritanceApplication {
   class Shape {
      public void setWidth(int w) {
         width = w;
      }
      public void setHeight(int h) {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // Derived class
   class Rectangle: Shape {
      public int getArea() { 
         return (width * height); 
      }
   }
   class RectangleTester {
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();

         Rect.setWidth(5);
         Rect.setHeight(7);

         // Print the area of the object.
         Console.WriteLine("Total area: {0}",  Rect.getArea());
         Console.ReadKey();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Total area: 35
```

#### Initializing Base Class
The derived class inherits the base class member variables and member methods. Therefore the super class object should be created before the subclass is created. You can give instructions for superclass initialization in the member initialization list.

The following program demonstrates this −

```
using System;

namespace RectangleApplication {
   class Rectangle {
      
      //member variables
      protected double length;
      protected double width;
      
      public Rectangle(double l, double w) {
         length = l;
         width = w;
      }
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle  
   class Tabletop : Rectangle {
      private double cost;
      public Tabletop(double l, double w) : base(l, w) { }
      
      public double GetCost() {
         double cost;
         cost = GetArea() * 70;
         return cost;
      }
      public void Display() {
         base.Display();
         Console.WriteLine("Cost: {0}", GetCost());
      }
   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         Tabletop t = new Tabletop(4.5, 7.5);
         t.Display();
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Length: 4.5
Width: 7.5
Area: 33.75
Cost: 2362.5
```

#### Multiple Inheritance in C#
C# does not support multiple inheritance. However, you can use interfaces to implement multiple inheritance. The following program demonstrates this −

```
using System;

namespace InheritanceApplication {
   class Shape {
      public void setWidth(int w) {
         width = w;
      }
      public void setHeight(int h) {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // Base class PaintCost
   public interface PaintCost {
      int getCost(int area);
   }
   
   // Derived class
   class Rectangle : Shape, PaintCost {
      public int getArea() {
         return (width * height);
      }
      public int getCost(int area) {
         return area * 70;
      }
   }
   class RectangleTester {
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();
         int area;
         
         Rect.setWidth(5);
         Rect.setHeight(7);
         area = Rect.getArea();
         
         // Print the area of the object.
         Console.WriteLine("Total area: {0}",  Rect.getArea());
         Console.WriteLine("Total paint cost: ${0}" , Rect.getCost(area));
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Total area: 35
Total paint cost: $2450
```

### Polymorphism

The word polymorphism means having many forms. In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.

Polymorphism can be static or dynamic. In static polymorphism, the response to a function is determined at the compile time. In dynamic polymorphism, it is decided at run-time.

#### Static Polymorphism
The mechanism of linking a function with an object during compile time is called early binding. It is also called static binding. C# provides two techniques to implement static polymorphism. They are −

- Function overloading
- Operator overloading
We discuss operator overloading in next chapter.

##### Function Overloading
You can have multiple definitions for the same function name in the same scope. The definition of the function must differ from each other by the types and/or the number of arguments in the argument list. You cannot overload function declarations that differ only by return type.

The following example shows using function print() to print different data types −

```
using System;

namespace PolymorphismApplication {
   class Printdata {
      void print(int i) {
         Console.WriteLine("Printing int: {0}", i );
      }
      void print(double f) {
         Console.WriteLine("Printing float: {0}" , f);
      }
      void print(string s) {
         Console.WriteLine("Printing string: {0}", s);
      }
      static void Main(string[] args) {
         Printdata p = new Printdata();
         
         // Call print to print integer
         p.print(5);
         
         // Call print to print float
         p.print(500.263);
         
         // Call print to print string
         p.print("Hello C++");
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Printing int: 5
Printing float: 500.263
Printing string: Hello C++
```

#### Dynamic Polymorphism
C# allows you to create abstract classes that are used to provide partial class implementation of an interface. Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods, which are implemented by the derived class. The derived classes have more specialized functionality.

Here are the rules about abstract classes −

- You cannot create an instance of an abstract class
- 
- You cannot declare an abstract method outside an abstract class
- 
- When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.


The following program demonstrates an abstract class −

```
using System;

namespace PolymorphismApplication {
   abstract class Shape {
      public abstract int area();
   }
   
   class Rectangle:  Shape {
      private int length;
      private int width;
      
      public Rectangle( int a = 0, int b = 0) {
         length = a;
         width = b;
      }
      public override int area () { 
         Console.WriteLine("Rectangle class area :");
         return (width * length); 
      }
   }
   class RectangleTester {
      static void Main(string[] args) {
         Rectangle r = new Rectangle(10, 7);
         double a = r.area();
         Console.WriteLine("Area: {0}",a);
         Console.ReadKey();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Rectangle class area :
Area: 70
```


When you have a function defined in a class that you want to be implemented in an inherited class(es), you use virtual functions. The virtual functions could be implemented differently in different inherited class and the call to these functions will be decided at runtime.

Dynamic polymorphism is implemented by abstract classes and virtual functions.

The following program demonstrates this −

```
using System;

namespace PolymorphismApplication {
   class Shape {
      protected int width, height;
      
      public Shape( int a = 0, int b = 0) {
         width = a;
         height = b;
      }
      public virtual int area() {
         Console.WriteLine("Parent class area :");
         return 0;
      }
   }
   class Rectangle: Shape {
      public Rectangle( int a = 0, int b = 0): base(a, b) {

      }
      public override int area () {
         Console.WriteLine("Rectangle class area :");
         return (width * height); 
      }
   }
   class Triangle: Shape {
      public Triangle(int a = 0, int b = 0): base(a, b) {
      }
      public override int area() {
         Console.WriteLine("Triangle class area :");
         return (width * height / 2); 
      }
   }
   class Caller {
      public void CallArea(Shape sh) {
         int a;
         a = sh.area();
         Console.WriteLine("Area: {0}", a);
      }
   }  
   class Tester {
      static void Main(string[] args) {
         Caller c = new Caller();
         Rectangle r = new Rectangle(10, 7);
         Triangle t = new Triangle(10, 5);
         
         c.CallArea(r);
         c.CallArea(t);
         Console.ReadKey();
      }
   }
}

```
When the above code is compiled and executed, it produces the following result −

```
Rectangle class area:
Area: 70
Triangle class area:
Area: 25
```

### Operator Overloading
You can redefine or overload most of the built-in operators available in C#. Thus a programmer can use operators with user-defined types as well. Overloaded operators are functions with special names the keyword operator followed by the symbol for the operator being defined. similar to any other function, an overloaded operator has a return type and a parameter list.

For example, go through the following function −

```
public static Box operator+ (Box b, Box c) {
   Box box = new Box();
   box.length = b.length + c.length;
   box.breadth = b.breadth + c.breadth;
   box.height = b.height + c.height;
   return box;
}
```

The above function implements the addition operator (+) for a user-defined class Box. It adds the attributes of two Box objects and returns the resultant Box object.

#### Implementing the Operator Overloading
The following program shows the complete implementation −

```
using System;

namespace OperatorOvlApplication {
   class Box {
      private double length;   // Length of a box
      private double breadth;  // Breadth of a box
      private double height;   // Height of a box

      public double getVolume() {
         return length * breadth * height;
      }
      public void setLength( double len ) {
         length = len;
      }
      public void setBreadth( double bre ) {
         breadth = bre;
      }
      public void setHeight( double hei ) {
         height = hei;
      }
      
      // Overload + operator to add two Box objects.
      public static Box operator+ (Box b, Box c) {
         Box box = new Box();
         box.length = b.length + c.length;
         box.breadth = b.breadth + c.breadth;
         box.height = b.height + c.height;
         return box;
      }
   }
   class Tester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();   // Declare Box2 of type Box
         Box Box3 = new Box();   // Declare Box3 of type Box
         double volume = 0.0;    // Store the volume of a box here

         // box 1 specification
         Box1.setLength(6.0);
         Box1.setBreadth(7.0);
         Box1.setHeight(5.0);

         // box 2 specification
         Box2.setLength(12.0);
         Box2.setBreadth(13.0);
         Box2.setHeight(10.0);

         // volume of box 1
         volume = Box1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);

         // volume of box 2
         volume = Box2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);

         // Add two object as follows:
         Box3 = Box1 + Box2;

         // volume of box 3
         volume = Box3.getVolume();
         Console.WriteLine("Volume of Box3 : {0}", volume);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Volume of Box1 : 210
Volume of Box2 : 1560
Volume of Box3 : 5400
```

##### Overloadable and Non-Overloadable Operators
The following table describes the overload ability of the operators in C# −

1. +, -, !, ~, ++, -- : These unary operators take one operand and can be overloaded.
2. +, -, *, /, % - : These binary operators take one operand and can be overloaded.
3. ==, !=, <, >, <=, >= : The comparison operators can be overloaded.
4. &&, || :The conditional logical operators cannot be overloaded directly.
5. +=, -=, *=, /=, %= : The assignment operators cannot be overloaded.
6. =, ., ?:, ->, new, is, sizeof, typeof : These operators cannot be overloaded.

In the light of the above discussions, let us extend the preceding example, and overload few more operators −

```
using System;

namespace OperatorOvlApplication {
   class Box {
      private double length;    // Length of a box
      private double breadth;   // Breadth of a box
      private double height;    // Height of a box
      
      public double getVolume() {
         return length * breadth * height;
      }
      public void setLength( double len ) {
         length = len;
      }
      public void setBreadth( double bre ) {
         breadth = bre;
      }
      public void setHeight( double hei ) {
         height = hei;
      }
      
      // Overload + operator to add two Box objects.
      public static Box operator+ (Box b, Box c) {
         Box box = new Box();
         box.length = b.length + c.length;
         box.breadth = b.breadth + c.breadth;
         box.height = b.height + c.height;
         return box;
      }
      public static bool operator == (Box lhs, Box rhs) {
         bool status = false;
         if (lhs.length == rhs.length && lhs.height == rhs.height 
            && lhs.breadth == rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public static bool operator !=(Box lhs, Box rhs) {
         bool status = false;
         
         if (lhs.length != rhs.length || lhs.height != rhs.height || 
            lhs.breadth != rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public static bool operator <(Box lhs, Box rhs) {
         bool status = false;
         
         if (lhs.length < rhs.length && lhs.height < rhs.height 
            && lhs.breadth < rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public static bool operator >(Box lhs, Box rhs) {
         bool status = false;
         
         if (lhs.length > rhs.length && lhs.height > 
            rhs.height && lhs.breadth > rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public static bool operator <=(Box lhs, Box rhs) {
         bool status = false;
         
         if (lhs.length <= rhs.length && lhs.height 
            <= rhs.height && lhs.breadth <= rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public static bool operator >=(Box lhs, Box rhs) {
         bool status = false;
         
         if (lhs.length >= rhs.length && lhs.height 
            >= rhs.height && lhs.breadth >= rhs.breadth) {
            
            status = true;
         }
         return status;
      }
      public override string ToString() {
         return String.Format("({0}, {1}, {2})", length, breadth, height);
      }
   }
   class Tester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();   // Declare Box2 of type Box
         Box Box3 = new Box();   // Declare Box3 of type Box
         Box Box4 = new Box();
         double volume = 0.0;    // Store the volume of a box here
         
         // box 1 specification
         Box1.setLength(6.0);
         Box1.setBreadth(7.0);
         Box1.setHeight(5.0);
         
         // box 2 specification
         Box2.setLength(12.0);
         Box2.setBreadth(13.0);
         Box2.setHeight(10.0);
         
         //displaying the Boxes using the overloaded ToString():
         Console.WriteLine("Box 1: {0}", Box1.ToString());
         Console.WriteLine("Box 2: {0}", Box2.ToString());
         
         // volume of box 1
         volume = Box1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);
         
         // volume of box 2
         volume = Box2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);
         
         // Add two object as follows:
         Box3 = Box1 + Box2;
         Console.WriteLine("Box 3: {0}", Box3.ToString());
         
         // volume of box 3
         volume = Box3.getVolume();
         Console.WriteLine("Volume of Box3 : {0}", volume);
         
         //comparing the boxes
         if (Box1 > Box2)
            Console.WriteLine("Box1 is greater than Box2");
         else
            Console.WriteLine("Box1 is not greater than Box2");
         
         if (Box1 < Box2)
            Console.WriteLine("Box1 is less than Box2");
         else
            Console.WriteLine("Box1 is not less than Box2");
         
         if (Box1 >= Box2)
            Console.WriteLine("Box1 is greater or equal to Box2");
         else
            Console.WriteLine("Box1 is not greater or equal to Box2");
         
         if (Box1 <= Box2)
            Console.WriteLine("Box1 is less or equal to Box2");
         else
            Console.WriteLine("Box1 is not less or equal to Box2");
         
         if (Box1 != Box2)
            Console.WriteLine("Box1 is not equal to Box2");
         else
            Console.WriteLine("Box1 is not greater or equal to Box2");
         Box4 = Box3;
         
         if (Box3 == Box4)
            Console.WriteLine("Box3 is equal to Box4");
         else
            Console.WriteLine("Box3 is not equal to Box4");

         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −


```
Box 1: (6, 7, 5)
Box 2: (12, 13, 10)
Volume of Box1 : 210
Volume of Box2 : 1560
Box 3: (18, 20, 15)
Volume of Box3 : 5400
Box1 is not greater than Box2
Box1 is less than Box2
Box1 is not greater or equal to Box2
Box1 is less or equal to Box2
Box1 is not equal to Box2
Box3 is equal to Box4
```

## Collections
Collections standardize the way of which the objects are handled by your program. In other words, it contains a set of classes to contain elements in a generalized manner. With the help of collections, the user can perform several operations on objects like the store, update, delete, retrieve, search, sort etc.

C# divide collection in several classes, some of the common classes are shown below:

![](imgs/collections.jpg)

Generic collection in C# is defined in System.Collection.Generic namespace. It provides a generic implementation of standard data structure like linked lists, stacks, queues, and dictionaries. These collections are type-safe because they are generic means only those items that are type-compatible with the type of the collection can be stored in a generic collection, it eliminates accidental type mismatches. Generic collections are defined by the set of interfaces and classes.

### Collection Class
Collection<T> Class provides the base class for a generic collection. Here T is the type of elements in the collection. This class comes under the System.Collections.ObjectModel namespace.

Characteristics:

- The Collection<T> class can be used immediately by creating an instance of one of its constructed types.
- The Collection<T> class provides protected methods that can be used to customize its behavior when adding and removing items, clearing the collection, or setting the value of an existing item.
- Most Collection<T> objects can be modified. However, a Collection object that is initialized with a read-only IList<T> object cannot be modified.
- Elements in this collection can be accessed using an integer index. Indexes in this collection are zero-based.
- Collection<T> accepts null as a valid value for reference types and allows duplicate elements.

```
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
  
class GFG {
  
    // Driver code
    public static void Main()
    {
        // Creating a collection of ints
        Collection<int> myColl = new Collection<int>();
  
        // Adding elements in Collection myColl
        myColl.Add(2);
        myColl.Add(3);
        myColl.Add(4);
        myColl.Add(5);
  
        // Displaying the elements in myColl
        foreach(int i in myColl)
        {
            Console.WriteLine(i);
        }
    }
}
```

Outputs:

```
2
3
4
5
```

```
// C# Code to illustrate the 
// Properties of Collection class
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
   
class GFG {
   
    // Driver code
    public static void Main()
    {
          
        // Creating a collection of strings
        Collection<string> myColl = new Collection<string>();
   
        // Adding elements in Collection myColl
        myColl.Add("A");
        myColl.Add("B");
        myColl.Add("C");
        myColl.Add("D");
        myColl.Add("E");
          
        // ------- Count Property ----------
          
        // To print the count of
        // elements in Collection
        Console.WriteLine("Count : " + myColl.Count);
   
        // -------- Item[Int32] Property --------
          
        // Get the element at index 2
        Console.WriteLine("Element at index 2 is : " + myColl[2]);
   
        // Get the element at index 3
        Console.WriteLine("Element at index 3 is : " + myColl[3]);
    }
}
```

Outputs:
```
Count : 5
Element at index 2 is : C
Element at index 3 is : D
```

```
// C# code to check if an
// element is in the Collection
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
  
class GFG {
  
    // Driver code
    public static void Main()
    {
        // Creating a collection of strings
        Collection<string> myColl = new Collection<string>();
  
        myColl.Add("A");
        myColl.Add("B");
        myColl.Add("C");
        myColl.Add("D");
        myColl.Add("E");
  
        // Checking if an element is in the Collection
        // The function returns "True" if the
        // item is present in Collection
        // else returns "False"
        Console.WriteLine(myColl.Contains("A"));
    }
}
```

Outputs:

```
True
```


### Various Collection Classes and Their Usage
The following are the various commonly used classes of the System.Collection namespace. Click the following links to check their detail.

#### ArrayList
It represents an ordered collection of an object that can be indexed individually. It is basically an alternative to an array. However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching and sorting items in the list.

```
using System;
using System.Collections;

namespace CollectionApplication {
   class Program {
      static void Main(string[] args) {
         ArrayList al = new ArrayList();
         
         Console.WriteLine("Adding some numbers:");
         al.Add(45);
         al.Add(78);
         al.Add(33);
         al.Add(56);
         al.Add(12);
         al.Add(23);
         al.Add(9);
         
         Console.WriteLine("Capacity: {0} ", al.Capacity);
         Console.WriteLine("Count: {0}", al.Count);
         
         Console.Write("Content: ");
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         
         Console.WriteLine();
         Console.Write("Sorted Content: ");
         al.Sort();
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −


```
Adding some numbers:
Capacity: 8
Count: 7
Content: 45 78 33 56 12 23 9
Content: 9 12 23 33 45 56 78    
```

#### Hashtable
The Hashtable class represents a collection of key-and-value pairs that are organized based on the hash code of the key. It uses the key to access the elements in the collection.

A hash table is used when you need to access elements by using key, and you can identify a useful key value. Each item in the hash table has a key/value pair. The key is used to access the items in the collection.

```
using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         Hashtable ht = new Hashtable();
         
         ht.Add("001", "Zara Ali");
         ht.Add("002", "Abida Rehman");
         ht.Add("003", "Joe Holzner");
         ht.Add("004", "Mausam Benazir Nur");
         ht.Add("005", "M. Amlan");
         ht.Add("006", "M. Arif");
         ht.Add("007", "Ritesh Saikia");
         
         if (ht.ContainsValue("Nuha Ali")) {
            Console.WriteLine("This student name is already in the list");
         } else {
            ht.Add("008", "Nuha Ali");
         }
         
         // Get a collection of the keys.
         ICollection key = ht.Keys;
         
         foreach (string k in key) {
            Console.WriteLine(k + ": " + ht[k]);
         }
         Console.ReadKey();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
001: Zara Ali
002: Abida Rehman
003: Joe Holzner
004: Mausam Benazir Nur
005: M. Amlan
006: M. Arif
007: Ritesh Saikia
008: Nuha Ali 
```

#### SortedList Class
The SortedList class represents a collection of key-and-value pairs that are sorted by the keys and are accessible by key and by index.

A sorted list is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index, it is an ArrayList, and if you access items using a key, it is a Hashtable. The collection of items is always sorted by the key value.

```
using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         SortedList sl = new SortedList();
         
         sl.Add("001", "Zara Ali");
         sl.Add("002", "Abida Rehman");
         sl.Add("003", "Joe Holzner");
         sl.Add("004", "Mausam Benazir Nur");
         sl.Add("005", "M. Amlan");
         sl.Add("006", "M. Arif");
         sl.Add("007", "Ritesh Saikia");
         
         if (sl.ContainsValue("Nuha Ali")) {
            Console.WriteLine("This student name is already in the list");
         } else {
            sl.Add("008", "Nuha Ali");
         }

         // get a collection of the keys. 
         ICollection key = sl.Keys;

         foreach (string k in key) {
            Console.WriteLine(k + ": " + sl[k]);
         }
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
001: Zara Ali
002: Abida Rehman
003: Joe Holzner
004: Mausam Banazir Nur
005: M. Amlan 
006: M. Arif
007: Ritesh Saikia
008: Nuha Ali
```

#### Stack Class
It represents a last-in, first out collection of object. It is used when you need a last-in, first-out access of items. When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item.


```
using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         Stack st = new Stack();
         
         st.Push('A');
         st.Push('M');
         st.Push('G');
         st.Push('W');
         
         Console.WriteLine("Current stack: ");
         foreach (char c in st) {
            Console.Write(c + " ");
         }
         Console.WriteLine();
         
         st.Push('V');
         st.Push('H');
         Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
         Console.WriteLine("Current stack: ");
         
         foreach (char c in st) {
            Console.Write(c + " ");
         }
         
         Console.WriteLine();
         
         Console.WriteLine("Removing values ");
         st.Pop();
         st.Pop();
         st.Pop();
         
         Console.WriteLine("Current stack: ");
         foreach (char c in st) {
            Console.Write(c + " ");
         }
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Current stack: 
W G M A
The next poppable value in stack: H
Current stack: 
H V W G M A
Removing values
Current stack: 
G M A
```

#### Queue Class
It represents a first-in, first out collection of object. It is used when you need a first-in, first-out access of items. When you add an item in the list, it is called enqueue, and when you remove an item, it is called deque.

```
using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         Queue q = new Queue();
         
         q.Enqueue('A');
         q.Enqueue('M');
         q.Enqueue('G');
         q.Enqueue('W');
         
         Console.WriteLine("Current queue: ");
         foreach (char c in q) Console.Write(c + " ");
         
         Console.WriteLine();
         q.Enqueue('V');
         q.Enqueue('H');
         Console.WriteLine("Current queue: ");
         foreach (char c in q) Console.Write(c + " ");
         
         Console.WriteLine();
         Console.WriteLine("Removing some values ");
         char ch = (char)q.Dequeue();
         Console.WriteLine("The removed value: {0}", ch);
         ch = (char)q.Dequeue();
         Console.WriteLine("The removed value: {0}", ch);
         
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Current queue: 
A M G W 
Current queue: 
A M G W V H 
Removing values
The removed value: A
The removed value: M
```


#### BitArray Class
The BitArray class manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0).

It is used when you need to store the bits but do not know the number of bits in advance. You can access items from the BitArray collection by using an integer index, which starts from zero.

```
using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         //creating two  bit arrays of size 8
         BitArray ba1 = new BitArray(8);
         BitArray ba2 = new BitArray(8);
         
         byte[] a = { 60 };
         byte[] b = { 13 };
         
         //storing the values 60, and 13 into the bit arrays
         ba1 = new BitArray(a);
         ba2 = new BitArray(b);
         
         //content of ba1
         Console.WriteLine("Bit array ba1: 60");
         
         for (int i = 0; i < ba1.Count; i++) {
            Console.Write("{0, -6} ", ba1[i]);
         }
         Console.WriteLine();
         
         //content of ba2
         Console.WriteLine("Bit array ba2: 13");
         
         for (int i = 0; i < ba2.Count; i++) {
            Console.Write("{0, -6} ", ba2[i]);
         }
         Console.WriteLine();
         BitArray ba3 = new BitArray(8);
         ba3 = ba1.And(ba2);
         
         //content of ba3
         Console.WriteLine("Bit array ba3 after AND operation: 12");
         
         for (int i = 0; i < ba3.Count; i++) {
            Console.Write("{0, -6} ", ba3[i]);
         }
         Console.WriteLine();
         ba3 = ba1.Or(ba2);
         
         //content of ba3
         Console.WriteLine("Bit array ba3 after OR operation: 61");
         
         for (int i = 0; i < ba3.Count; i++) {
            Console.Write("{0, -6} ", ba3[i]);
         }
         Console.WriteLine();

         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Bit array ba1: 60 
False False True True True True False False 
Bit array ba2: 13
True False True True False False False False 
Bit array ba3 after AND operation: 12
False False True True False False False False 
Bit array ba3 after OR operation: 61
True False True True False False False False 
```



## Structs
In C#, a structure is a value type data type. It helps you to make a single variable hold related data of various data types. The struct keyword is used for creating a structure.

Structures are used to represent a record. Suppose you want to keep track of your books in a library. You might want to track the following attributes about each book −

- Title
- Author
- Subject
- Book ID

### Defining a Structure
To define a structure, you must use the struct statement. The struct statement defines a new data type, with more than one member for your program.

For example, here is the way you can declare the Book structure −

```
struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  
```

The following program shows the use of the structure −

```
using System;

struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class testStructure {
   public static void Main(string[] args) {
      Books Book1;   /* Declare Book1 of type Book */
      Books Book2;   /* Declare Book2 of type Book */

      /* book 1 specification */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali"; 
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 specification */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;

      /* print Book1 info */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* print Book2 info */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);       

      Console.ReadKey();
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
Book 1 title : C Programming
Book 1 author : Nuha Ali
Book 1 subject : C Programming Tutorial
Book 1 book_id : 6495407
Book 2 title : Telecom Billing
Book 2 author : Zara Ali
Book 2 subject : Telecom Billing Tutorial
Book 2 book_id : 6495700
```

### Features of C# Structures
You have already used a simple structure named Books. Structures in C# are quite different from that in traditional C or C++. The C# structures have the following features −

- Structures can have methods, fields, indexers, properties, operator methods, and events.
- 
- Structures can have defined constructors, but not destructors. However, you cannot define a default constructor for a structure. The default constructor is automatically defined and cannot be changed.
- 
- Unlike classes, structures cannot inherit other structures or classes.
- 
- Structures cannot be used as a base for other structures or classes.
- 
- A structure can implement one or more interfaces.
- 
- Structure members cannot be specified as abstract, virtual, or protected.
- 
- When you create a struct object using the New operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the New operator.
- 
- If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.

### Class versus Structure
Classes and Structures have the following basic differences −

- classes are reference types and structs are value types
- structures do not support inheritance
- structures cannot have default constructor
In the light of the above discussions, let us rewrite the previous example −


```
using System;

struct Books {
   private string title;
   private string author;
   private string subject;
   private int book_id;
   
   public void getValues(string t, string a, string s, int id) {
      title = t;
      author = a;
      subject = s;
      book_id = id;
   }
   
   public void display() {
      Console.WriteLine("Title : {0}", title);
      Console.WriteLine("Author : {0}", author);
      Console.WriteLine("Subject : {0}", subject);
      Console.WriteLine("Book_id :{0}", book_id);
   }
};  

public class testStructure {

   public static void Main(string[] args) {
      Books Book1 = new Books();   /* Declare Book1 of type Book */
      Books Book2 = new Books();   /* Declare Book2 of type Book */

      /* book 1 specification */
      Book1.getValues("C Programming",
      "Nuha Ali", "C Programming Tutorial",6495407);

      /* book 2 specification */
      Book2.getValues("Telecom Billing",
      "Zara Ali", "Telecom Billing Tutorial", 6495700);

      /* print Book1 info */
      Book1.display();

      /* print Book2 info */
      Book2.display(); 

      Console.ReadKey();
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Title : C Programming
Author : Nuha Ali
Subject : C Programming Tutorial
Book_id : 6495407
Title : Telecom Billing
Author : Zara Ali
Subject : Telecom Billing Tutorial
Book_id : 6495700

```


## Enums
An enumeration is a set of named integer constants. An enumerated type is declared using the enum keyword.

C# enumerations are value data type. In other words, enumeration contains its own values and cannot inherit or cannot pass inheritance.

### Declaring enum Variable
The general syntax for declaring an enumeration is −
```
enum <enum_name> {
   enumeration list 
};
```

Where,

- The enum_name specifies the enumeration type name.
- 
- The enumeration list is a comma-separated list of identifiers.

Each of the symbols in the enumeration list stands for an integer value, one greater than the symbol that precedes it. By default, the value of the first enumeration symbol is 0. For example −

```
enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
```

### Example
The following example demonstrates use of enum variable −

```
using System;

namespace EnumApplication {
   class EnumProgram {
      enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

      static void Main(string[] args) {
         int WeekdayStart = (int)Days.Mon;
         int WeekdayEnd = (int)Days.Fri;
         
         Console.WriteLine("Monday: {0}", WeekdayStart);
         Console.WriteLine("Friday: {0}", WeekdayEnd);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Monday: 1
Friday: 5
```


## Regular Expressions
A regular expression is a pattern that could be matched against an input text. The .Net framework provides a regular expression engine that allows such matching. A pattern consists of one or more character literals, operators, or constructs.

### Constructs for Defining Regular Expressions
There are various categories of characters, operators, and constructs that lets you to define regular expressions.

- Character escapes
- 
- Character classes
- 
- Anchors
- 
- Grouping constructs
- 
- Quantifiers
- 
- Backreference constructs
- 
- Alternation constructs
- 
- Substitutions
- 
- Miscellaneous constructs

The following example matches words that start with 'S' −


```
using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
   class Program {
      private static void showMatch(string text, string expr) {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         
         foreach (Match m in mc) {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args) {
         string str = "A Thousand Splendid Suns";
         
         Console.WriteLine("Matching words that start with 'S': ");
         showMatch(str, @"\bS\S*");
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Matching words that start with 'S':
The Expression: \bS\S*
Splendid
Suns
```


Example 2 :The following example matches words that start with 'm' and ends with 'e' −

```
using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
   class Program {
      private static void showMatch(string text, string expr) {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         
         foreach (Match m in mc) {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args) {
         string str = "make maze and manage to measure it";

         Console.WriteLine("Matching words start with 'm' and ends with 'e':");
         showMatch(str, @"\bm\S*e\b");
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Matching words start with 'm' and ends with 'e':
The Expression: \bm\S*e\b
make
maze
manage
measure
```


Example 3 :This example replaces extra white space −

```
using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
   class Program {
      static void Main(string[] args) {
         string input = "Hello   World   ";
         string pattern = "\\s+";
         string replacement = " ";
         
         Regex rgx = new Regex(pattern);
         string result = rgx.Replace(input, replacement);

         Console.WriteLine("Original String: {0}", input);
         Console.WriteLine("Replacement String: {0}", result);    
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Original String: Hello World   
Replacement String: Hello World 
```

## File I/O
A file is a collection of data stored in a disk with a specific name and a directory path. When a file is opened for reading or writing, it becomes a stream.

The stream is basically the sequence of bytes passing through the communication path. There are two main streams: the input stream and the output stream. The input stream is used for reading data from file (read operation) and the output stream is used for writing into the file (write operation).

### C# I/O Classes
The System.IO namespace has various classes that are used for performing numerous operations with files, such as creating and deleting files, reading from or writing to a file, closing a file etc.

The following table shows some commonly used non-abstract classes in the System.IO namespace −

1. BinaryReader : Reads primitive data from a binary stream.
2. BinaryWriter: Writes primitive data in binary format.
3. BufferedStream : A temporary storage for a stream of bytes.
4. Directory: Helps in manipulating a directory structure.
5. DirectoryInfo: Used for performing operations on directories.
6. DriveInfo: Provides information for the drives.
7. File: Helps in manipulating files.
8. FileInfo: Used for performing operations on files.
9. FileStream: Used to read from and write to any location in a file.
10. MemoryStream: Used for random access to streamed data stored in memory.
11. Path: Performs operations on path information.
12. StreamReader: Used for reading characters from a byte stream.
13. StreamWriter: Is used for writing characters to a stream.
14. StringReader: Is used for reading from a string buffer.
15. StringWriter: Is used for writing into a string buffer.


### The FileStream Class
The FileStream class in the System.IO namespace helps in reading from, writing to and closing files. This class derives from the abstract class Stream.

You need to create a FileStream object to create a new file or open an existing file. The syntax for creating a FileStream object is as follows −

```
FileStream <object_name> = new FileStream( <file_name>, <FileMode Enumerator>,
   <FileAccess Enumerator>, <FileShare Enumerator>);
```

For example, we create a FileStream object F for reading a file named sample.txt as shown −

```
FileStream F = new FileStream("sample.txt", FileMode.Open, FileAccess.Read,
   FileShare.Read);
```

### Example
The following program demonstrates use of the FileStream class −

```
using System;
using System.IO;

namespace FileIOApplication {
   class Program {
      static void Main(string[] args) {
         FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, 
            FileAccess.ReadWrite);
         
         for (int i = 1; i <= 20; i++) {
            F.WriteByte((byte)i);
         }
         F.Position = 0;
         for (int i = 0; i <= 20; i++) {
            Console.Write(F.ReadByte() + " ");
         }
         F.Close();
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 -1
```


### Advanced File Operations in C#
The preceding example provides simple file operations in C#. However, to utilize the immense powers of C# System.IO classes, you need to know the commonly used properties and methods of these classes.

#### Reading from and Writing to Text Files

The StreamReader and StreamWriter classes are used for reading from and writing data to text files. These classes inherit from the abstract base class Stream, which supports reading and writing bytes into a file stream.

##### The StreamReader Class
The StreamReader class also inherits from the abstract base class TextReader that represents a reader for reading series of characters. 

Example
The following example demonstrates reading a text file named Jamaica.txt. The file reads −

```
Down the way where the nights are gay
And the sun shines daily on the mountain top
I took a trip on a sailing ship
And when I reached Jamaica
I made a stop
```

```
using System;
using System.IO;

namespace FileApplication {
   class Program {
      static void Main(string[] args) {
         try {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("c:/jamaica.txt")) {
               string line;

               // Read and display lines from the file until 
               // the end of the file is reached. 
               while ((line = sr.ReadLine()) != null) {
                  Console.WriteLine(line);
               }
            }
         } catch (Exception e) {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
         }
         Console.ReadKey();
      }
   }
}
```

##### The StreamWriter Class
The StreamWriter class inherits from the abstract class TextWriter that represents a writer, which can write a series of character.



Example
The following example demonstrates writing text data into a file using the StreamWriter class −

```
using System;
using System.IO;

namespace FileApplication {
   class Program {
      static void Main(string[] args) {
         string[] names = new string[] {"Zara Ali", "Nuha Ali"};
         
         using (StreamWriter sw = new StreamWriter("names.txt")) {

            foreach (string s in names) {
               sw.WriteLine(s);
            }
         }
         
         // Read and show each line from the file.
         string line = "";
         using (StreamReader sr = new StreamReader("names.txt")) {
            while ((line = sr.ReadLine()) != null) {
               Console.WriteLine(line);
            }
         }
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Zara Ali
Nuha Ali

```

#### Reading from and Writing into Binary files
The BinaryReader and BinaryWriter classes are used for reading from and writing to a binary file.

##### The BinaryReader Class
The BinaryReader class is used to read binary data from a file. A BinaryReader object is created by passing a FileStream object to its constructor.

##### The BinaryWriter Class
The BinaryWriter class is used to write binary data to a stream. A BinaryWriter object is created by passing a FileStream object to its constructor.

```
using System;
using System.IO;

namespace BinaryFileApplication {
   class Program {
      static void Main(string[] args) {
         BinaryWriter bw;
         BinaryReader br;
         
         int i = 25;
         double d = 3.14157;
         bool b = true;
         string s = "I am happy";
         
         //create the file
         try {
            bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
         } catch (IOException e) {
            Console.WriteLine(e.Message + "\n Cannot create file.");
            return;
         }
         
         //writing into the file
         try {
            bw.Write(i);
            bw.Write(d);
            bw.Write(b);
            bw.Write(s);
         } catch (IOException e) {
            Console.WriteLine(e.Message + "\n Cannot write to file.");
            return;
         }
         bw.Close();
         
         //reading from the file
         try {
            br = new BinaryReader(new FileStream("mydata", FileMode.Open));
         } catch (IOException e) {
            Console.WriteLine(e.Message + "\n Cannot open file.");
            return;
         }
         
         try {
            i = br.ReadInt32();
            Console.WriteLine("Integer data: {0}", i);
            d = br.ReadDouble();
            Console.WriteLine("Double data: {0}", d);
            b = br.ReadBoolean();
            Console.WriteLine("Boolean data: {0}", b);
            s = br.ReadString();
            Console.WriteLine("String data: {0}", s);
         } catch (IOException e) {
            Console.WriteLine(e.Message + "\n Cannot read from file.");
            return;
         }
         br.Close();
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Integer data: 25
Double data: 3.14157
Boolean data: True
String data: I am happy
```

#### Windows File System

C# allows you to work with the directories and files using various directory and file related classes such as the DirectoryInfo class and the FileInfo class.

##### The DirectoryInfo Class
The DirectoryInfo class is derived from the FileSystemInfo class. It has various methods for creating, moving, and browsing through directories and subdirectories. This class cannot be inherited.

##### The FileInfo Class
The FileInfo class is derived from the FileSystemInfo class. It has properties and instance methods for creating, copying, deleting, moving, and opening of files, and helps in the creation of FileStream objects. This class cannot be inherited.

Eample:

```
using System;
using System.IO;

namespace WindowsFileApplication {
   class Program {
      static void Main(string[] args) {
         //creating a DirectoryInfo object
         DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");
         
         // getting the files in the directory, their names and size
         FileInfo [] f = mydir.GetFiles();
         foreach (FileInfo file in f) {
            Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
         }
         
         Console.ReadKey();
      }
   }
}
```

When you compile and run the program, it displays the names of files and their respective sizes in the Windows directory.


## Attributes
An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc. in your program. You can add declarative information to a program by using an attribute. A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.

Attributes are used for adding metadata, such as compiler instruction and other information such as comments, description, methods and classes to a program. The .Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.

### Specifying an Attribute
Syntax for specifying an attribute is as follows −
```
[attribute(positional_parameters, name_parameter = value, ...)]
element
```


Name of the attribute and its values are specified within the square brackets, before the element to which the attribute is applied. Positional parameters specify the essential information and the name parameters specify the optional information.

### Predefined Attributes
The .Net Framework provides three pre-defined attributes −

- AttributeUsage
- Conditional
- Obsolete

### AttributeUsage
The pre-defined attribute AttributeUsage describes how a custom attribute class can be used. It specifies the types of items to which the attribute can be applied.

Syntax for specifying this attribute is as follows −

```
[AttributeUsage (
   validon,
   AllowMultiple = allowmultiple,
   Inherited = inherited
)]
```

Where,

- The parameter validon specifies the language elements on which the attribute can be placed. It is a combination of the value of an enumerator AttributeTargets. The default value is AttributeTargets.All.
- 
- The parameter allowmultiple (optional) provides value for the AllowMultiple property of this attribute, a Boolean value. If this is true, the attribute is multiuse. The default is false (single-use).
- 
- The parameter inherited (optional) provides value for the Inherited property of this attribute, a Boolean value. If it is true, the attribute is inherited by derived classes. The default value is false (not inherited).


For example,

```
[AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property, 
   AllowMultiple = true)]
```


### Conditional
This predefined attribute marks a conditional method whose execution depends on a specified preprocessing identifier.

It causes conditional compilation of method calls, depending on the specified value such as Debug or Trace. For example, it displays the values of the variables while debugging a code.

Syntax for specifying this attribute is as follows −

```
[Conditional(
   conditionalSymbol
)]
```

For example,
```
[Conditional("DEBUG")]
```

The following example demonstrates the attribute −

```
#define DEBUG
using System;
using System.Diagnostics;

public class Myclass {
   [Conditional("DEBUG")]
   
   public static void Message(string msg) {
      Console.WriteLine(msg);
   }
}
class Test {
   static void function1() {
      Myclass.Message("In Function 1.");
      function2();
   }
   static void function2() {
      Myclass.Message("In Function 2.");
   }
   public static void Main() {
      Myclass.Message("In Main function.");
      function1();
      Console.ReadKey();
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
In Main function
In Function 1
In Function 2
```

### Obsolete
This predefined attribute marks a program entity that should not be used. It enables you to inform the compiler to discard a particular target element. For example, when a new method is being used in a class and if you still want to retain the old method in the class, you may mark it as obsolete by displaying a message the new method should be used, instead of the old method.

Syntax for specifying this attribute is as follows −

```
[Obsolete (
   message
)]

[Obsolete (
   message,
   iserror
)]
```

Where,

- The parameter message, is a string describing the reason why the item is obsolete and what to use instead.
- The parameter iserror, is a Boolean value. If its value is true, the compiler should treat the use of the item as an error. Default value is false (compiler generates a warning).


The following program demonstrates this −

```
using System;

public class MyClass {
   [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
   
   static void OldMethod() {
      Console.WriteLine("It is the old method");
   }
   static void NewMethod() {
      Console.WriteLine("It is the new method"); 
   }
   public static void Main() {
      OldMethod();
   }
}
```

When you try to compile the program, the compiler gives an error message stating −
```
 Don't use OldMethod, use NewMethod instead
```

### Creating Custom Attributes
The .Net Framework allows creation of custom attributes that can be used to store declarative information and can be retrieved at run-time. This information can be related to any target element depending upon the design criteria and application need.

Creating and using custom attributes involve four steps −

- Declaring a custom attribute
- Constructing the custom attribute
- Apply the custom attribute on a target program element
- Accessing Attributes Through Reflection

The Last step involves writing a simple program to read through the metadata to find various notations. Metadata is data about data or information used for describing other data. This program should use reflections for accessing attributes at runtime. This we will discuss in the next chapter.

#### Declaring a Custom Attribute
A new custom attribute should is derived from the System.Attribute class. For example,

```
//a custom attribute BugFix to be assigned to a class and its members
[AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

public class DeBugInfo : System.Attribute
```

In the preceding code, we have declared a custom attribute named DeBugInfo.

#### Constructing the Custom Attribute
Let us construct a custom attribute named DeBugInfo, which stores the information obtained by debugging any program. Let it store the following information −

- The code number for the bug
- Name of the developer who identified the bug
- Date of last review of the code
- A string message for storing the developer's remarks


The DeBugInfo class has three private properties for storing the first three information and a public property for storing the message. Hence the bug number, developer's name, and date of review are the positional parameters of the DeBugInfo class and the message is an optional or named parameter.

Each attribute must have at least one constructor. The positional parameters should be passed through the constructor. The following code shows the DeBugInfo class −

```
//a custom attribute BugFix to be assigned to a class and its members
[AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

public class DeBugInfo : System.Attribute {
   private int bugNo;
   private string developer;
   private string lastReview;
   public string message;
   
   public DeBugInfo(int bg, string dev, string d) {
      this.bugNo = bg;
      this.developer = dev;
      this.lastReview = d;
   }
   public int BugNo {
      get {
         return bugNo;
      }
   }
   public string Developer {
      get {
         return developer;
      }
   }
   public string LastReview {
      get {
         return lastReview;
      }
   }
   public string Message {
      get {
         return message;
      }
      set {
         message = value;
      }
   }
}
```

#### Applying the Custom Attribute
The attribute is applied by placing it immediately before its target −

```
[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
class Rectangle {
   //member variables
   protected double length;
   protected double width;
   public Rectangle(double l, double w) {
      length = l;
      width = w;
   }
   [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
   
   public double GetArea() {
      return length * width;
   }
   [DeBugInfo(56, "Zara Ali", "19/10/2012")]
   
   public void Display() {
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
   }
}
```

In the next chapter, we retrieve attribute information using a Reflection class object.

## Reflection
Reflection objects are used for obtaining type information at runtime. The classes that give access to the metadata of a running program are in the System.Reflection namespace.

The System.Reflection namespace contains classes that allow you to obtain information about the application and to dynamically add types, values, and objects to the application.

### Applications of Reflection
Reflection has the following applications −

- It allows view attribute information at runtime.
- 
- It allows examining various types in an assembly and instantiate these types.
- 
- It allows late binding to methods and properties
- 
- It allows creating new types at runtime and then performs some tasks using those types.



### Viewing Metadata
We have mentioned in the preceding chapter that using reflection you can view the attribute information.

The MemberInfo object of the System.Reflection class needs to be initialized for discovering the attributes associated with a class. To do this, you define an object of the target class, as −

```
System.Reflection.MemberInfo info = typeof(MyClass);
```


The following program demonstrates this −

```
using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute {
   public readonly string Url;
   
   public string Topic   // Topic is a named parameter {
      get {
         return topic;
      }
      set {
         topic = value;
      }
   }
   public HelpAttribute(string url)   // url is a positional parameter {
      this.Url = url;
   }
   private string topic;
}

[HelpAttribute("Information on the class MyClass")]
class MyClass {

}

namespace AttributeAppl {
   class Program {
      static void Main(string[] args) {
         System.Reflection.MemberInfo info = typeof(MyClass);
         object[] attributes = info.GetCustomAttributes(true);
         
         for (int i = 0; i < attributes.Length; i++) {
            System.Console.WriteLine(attributes[i]);
         }
         Console.ReadKey();
      }
   }
}
```

When it is compiled and run, it displays the name of the custom attributes attached to the class MyClass −

```
HelpAttribute
```


### Example
In this example, we use the DeBugInfo attribute created in the previous chapter and use reflection to read metadata in the Rectangle class.

```
using System;
using System.Reflection;

namespace BugFixApplication {
   //a custom attribute BugFix to be assigned to a class and its members
   [AttributeUsage(
      AttributeTargets.Class |
      AttributeTargets.Constructor |
      AttributeTargets.Field |
      AttributeTargets.Method |
      AttributeTargets.Property,
      AllowMultiple = true)]

   public class DeBugInfo : System.Attribute {
      private int bugNo;
      private string developer;
      private string lastReview;
      public string message;
      
      public DeBugInfo(int bg, string dev, string d) {
         this.bugNo = bg;
         this.developer = dev;
         this.lastReview = d;
      }
      public int BugNo {
         get {
            return bugNo;
         }
      }
      public string Developer {
         get {
            return developer;
         }
      }
      public string LastReview {
         get {
            return lastReview;
         }
      }
      public string Message {
         get {
            return message;
         }
         set {
            message = value;
         }
      }
   }
   [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
   [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
   
   class Rectangle {
      //member variables
      protected double length;
      protected double width;
      
      public Rectangle(double l, double w) {
         length = l;
         width = w;
      }
      [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
      public double GetArea() {
         return length * width;
      }
      [DeBugInfo(56, "Zara Ali", "19/10/2012")]
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle(4.5, 7.5);
         r.Display();
         Type type = typeof(Rectangle);
         
         //iterating through the attribtues of the Rectangle class
         foreach (Object attributes in type.GetCustomAttributes(false)) {
            DeBugInfo dbi = (DeBugInfo)attributes;
            
            if (null != dbi) {
               Console.WriteLine("Bug no: {0}", dbi.BugNo);
               Console.WriteLine("Developer: {0}", dbi.Developer);
               Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
               Console.WriteLine("Remarks: {0}", dbi.Message);
            }
         }
         
         //iterating through the method attribtues
         foreach (MethodInfo m in type.GetMethods()) {
            
            foreach (Attribute a in m.GetCustomAttributes(true)) {
               DeBugInfo dbi = (DeBugInfo)a;
               
               if (null != dbi) {
                  Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                  Console.WriteLine("Developer: {0}", dbi.Developer);
                  Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                  Console.WriteLine("Remarks: {0}", dbi.Message);
               }
            }
         }
         Console.ReadLine();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Length: 4.5
Width: 7.5
Area: 33.75
Bug No: 49
Developer: Nuha Ali
Last Reviewed: 10/10/2012
Remarks: Unused variable
Bug No: 45
Developer: Zara Ali
Last Reviewed: 12/8/2012
Remarks: Return type mismatch
Bug No: 55, for Method: GetArea
Developer: Zara Ali
Last Reviewed: 19/10/2012
Remarks: Return type mismatch
Bug No: 56, for Method: Display
Developer: Zara Ali
Last Reviewed: 19/10/2012
Remarks: 
```

## Properties

Properties are named members of classes, structures, and interfaces. Member variables or methods in a class or structures are called Fields. Properties are an extension of fields and are accessed using the same syntax. They use accessors through which the values of the private fields can be read, written or manipulated.

Properties do not name the storage locations. Instead, they have accessors that read, write, or compute their values.

For example, let us have a class named Student, with private fields for age, name, and code. We cannot directly access these fields from outside the class scope, but we can have properties for accessing these private fields.

### Accessors
The accessor of a property contains the executable statements that helps in getting (reading or computing) or setting (writing) the property. The accessor declarations can contain a get accessor, a set accessor, or both. For example −


```
// Declare a Code property of type string:
public string Code {
   get {
      return code;
   }
   set {
      code = value;
   }
}

// Declare a Name property of type string:
public string Name {
   get {
      return name;
   }
   set {
      name = value;
   }
}

// Declare a Age property of type int:
public int Age { 
   get {
      return age;
   }
   set {
      age = value;
   }
}
```

### Example
The following example demonstrates use of properties −

```
using System;
namespace tutorialspoint {
   class Student {
      private string code = "N.A";
      private string name = "not known";
      private int age = 0;
      
      // Declare a Code property of type string:
      public string Code {
         get {
            return code;
         }
         set {
            code = value;
         }
      }
      
      // Declare a Name property of type string:
      public string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      
      // Declare a Age property of type int:
      public int Age {
         get {
            return age;
         }
         set {
            age = value;
         }
      }
      public override string ToString() {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
   }
   
   class ExampleDemo {
      public static void Main() {
      
         // Create a new Student object:
         Student s = new Student();
         
         // Setting code, name and the age of the student
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info: {0}", s);
         
         //let us increase age
         s.Age += 1;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Student Info: Code = 001, Name = Zara, Age = 9
Student Info: Code = 001, Name = Zara, Age = 10
```

### Abstract Properties
An abstract class may have an abstract property, which should be implemented in the derived class. The following program illustrates this −

```
using System;

namespace tutorialspoint {
   public abstract class Person {
      public abstract string Name {
         get;
         set;
      }
      public abstract int Age {
         get;
         set;
      }
   }
   class Student : Person {
      private string code = "N.A";
      private string name = "N.A";
      private int age = 0;
      
      // Declare a Code property of type string:
      public string Code {
         get {
            return code;
         }
         set {
            code = value;
         }
      }
      
      // Declare a Name property of type string:
      public override string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      
      // Declare a Age property of type int:
      public override int Age {
         get {
            return age;
         }
         set {
            age = value;
         }
      }
      public override string ToString() {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
   }
   
   class ExampleDemo {
      public static void Main() {
         // Create a new Student object:
         Student s = new Student();
         
         // Setting code, name and the age of the student
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info:- {0}", s);
         
         //let us increase age
         s.Age += 1;
         Console.WriteLine("Student Info:- {0}", s);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Student Info: Code = 001, Name = Zara, Age = 9
Student Info: Code = 001, Name = Zara, Age = 10
```

## Indexers
An indexer allows an object to be indexed such as an array. When you define an indexer for a class, this class behaves similar to a virtual array. You can then access the instance of this class using the array access operator ([ ]).

### Syntax
A one dimensional indexer has the following syntax −

```
element-type this[int index] {

   // The get accessor.
   get {
      // return the value specified by index
   }
   
   // The set accessor.
   set {
      // set the value specified by index
   }
}
```

### Use of Indexers
Declaration of behavior of an indexer is to some extent similar to a property. similar to the properties, you use get and set accessors for defining an indexer. However, properties return or set a specific data member, whereas indexers returns or sets a particular value from the object instance. In other words, it breaks the instance data into smaller parts and indexes each part, gets or sets each part.

Defining a property involves providing a property name. Indexers are not defined with names, but with the this keyword, which refers to the object instance. The following example demonstrates the concept −

```
using System;

namespace IndexerApplication {
   
   class IndexedNames {
      private string[] namelist = new string[size];
      static public int size = 10;
      
      public IndexedNames() {
         for (int i = 0; i < size; i++)
         namelist[i] = "N. A.";
      }
      public string this[int index] {
         get {
            string tmp;
         
            if( index >= 0 && index <= size-1 ) {
               tmp = namelist[index];
            } else {
               tmp = "";
            }
            
            return ( tmp );
         }
         set {
            if( index >= 0 && index <= size-1 ) {
               namelist[index] = value;
            }
         }
      }
      static void Main(string[] args) {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         for ( int i = 0; i < IndexedNames.size; i++ ) {
            Console.WriteLine(names[i]);
         }
         Console.ReadKey();
      }
   }
}

```

When the above code is compiled and executed, it produces the following result −

```
Zara
Riz
Nuha
Asif
Davinder
Sunil
Rubic
N. A.
N. A.
N. A.
```


### Overloaded Indexers
Indexers can be overloaded. Indexers can also be declared with multiple parameters and each parameter may be a different type. It is not necessary that the indexes have to be integers. C# allows indexes to be of other types, for example, a string.

The following example demonstrates overloaded indexers −

```
using System;

namespace IndexerApplication {
   class IndexedNames {
      private string[] namelist = new string[size];
      static public int size = 10;
      
      public IndexedNames() {
         for (int i = 0; i < size; i++) {
            namelist[i] = "N. A.";
         }
      }
      public string this[int index] {
         get {
            string tmp;
            
            if( index >= 0 && index <= size-1 ) {
               tmp = namelist[index];
            } else {
               tmp = "";
            }
            
            return ( tmp );
         }
         set {
            if( index >= 0 && index <= size-1 ) {
               namelist[index] = value;
            }
         }
      }
      
      public int this[string name] {
         get {
            int index = 0;
            
            while(index < size) {
               if (namelist[index] == name) {
                return index;
               }
               index++;
            }
            return index;
         }
      }

      static void Main(string[] args) {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         //using the first indexer with int parameter
         for (int i = 0; i < IndexedNames.size; i++) {
            Console.WriteLine(names[i]);
         }
         
         //using the second indexer with the string parameter
         Console.WriteLine(names["Nuha"]);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Zara
Riz
Nuha
Asif
Davinder
Sunil
Rubic
N. A.
N. A.
N. A.
2
```

## Delegates

C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

### Declaring Delegates
Delegate declaration determines the methods that can be referenced by the delegate. A delegate can refer to a method, which has the same signature as that of the delegate.

For example, consider a delegate −

```
public delegate int MyDelegate (string s);
```


The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable.

Syntax for delegate declaration is −

```
delegate <return type> <delegate-name> <parameter list>
```

### Instantiating Delegates
Once a delegate type is declared, a delegate object must be created with the new keyword and be associated with a particular method. When creating a delegate, the argument passed to the new expression is written similar to a method call, but without the arguments to the method. For example −

```
public delegate void printString(string s);
...
printString ps1 = new printString(WriteToScreen);
printString ps2 = new printString(WriteToFile);
```

Following example demonstrates declaration, instantiation, and use of a delegate that can be used to reference methods that take an integer parameter and returns an integer value.

```
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl {
   
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      static void Main(string[] args) {
         //create delegate instances
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         
         //calling the methods using the delegate objects
         nc1(25);
         Console.WriteLine("Value of Num: {0}", getNum());
         nc2(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Value of Num: 35
Value of Num: 175
```

### Multicasting of a Delegate
Delegate objects can be composed using the "+" operator. A composed delegate calls the two delegates it was composed from. Only delegates of the same type can be composed. The "-" operator can be used to remove a component delegate from a composed delegate.

Using this property of delegates you can create an invocation list of methods that will be called when a delegate is invoked. This is called multicasting of a delegate. The following program demonstrates multicasting of a delegate −

```
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl {
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      static void Main(string[] args) {
         //create delegate instances
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         
         nc = nc1;
         nc += nc2;
         
         //calling multicast
         nc(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −


```
Value of Num: 75
```

### Using Delegates
The following example demonstrates the use of delegate. The delegate printString can be used to reference method that takes a string as input and returns nothing.

We use this delegate to call two methods, the first prints the string to the console, and the second one prints it to a file −

```
using System;
using System.IO;

namespace DelegateAppl {

   class PrintString {
      static FileStream fs;
      static StreamWriter sw;
      
      // delegate declaration
      public delegate void printString(string s);

      // this method prints to the console
      public static void WriteToScreen(string str) {
         Console.WriteLine("The String is: {0}", str);
      }
      
      //this method prints to a file
      public static void WriteToFile(string s) {
         fs = new FileStream("c:\\message.txt",
         FileMode.Append, FileAccess.Write);
         sw = new StreamWriter(fs);
         sw.WriteLine(s);
         sw.Flush();
         sw.Close();
         fs.Close();
      }
      
      // this method takes the delegate as parameter and uses it to
      // call the methods as required
      public static void sendString(printString ps) {
         ps("Hello World");
      }
      
      static void Main(string[] args) {
         printString ps1 = new printString(WriteToScreen);
         printString ps2 = new printString(WriteToFile);
         sendString(ps1);
         sendString(ps2);
         Console.ReadKey();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
The String is: Hello World
```

## Events
Events are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as system generated notifications. Applications need to respond to events when they occur. For example, interrupts. Events are used for inter-process communication.

### Using Delegates with Events
The events are declared and raised in a class and associated with the event handlers using delegates within the same class or some other class. The class containing the event is used to publish the event. This is called the publisher class. Some other class that accepts this event is called the subscriber class. Events use the publisher-subscriber model.

A publisher is an object that contains the definition of the event and the delegate. The event-delegate association is also defined in this object. A publisher class object invokes the event and it is notified to other objects.

A subscriber is an object that accepts the event and provides an event handler. The delegate in the publisher class invokes the method (event handler) of the subscriber class.

### Declaring Events
To declare an event inside a class, first of all, you must declare a delegate type for the even as:

```
public delegate string BoilerLogHandler(string str);
```

then, declare the event using the event keyword −

```
event BoilerLogHandler BoilerEventLog;
```

The preceding code defines a delegate named BoilerLogHandler and an event named BoilerEventLog, which invokes the delegate when it is raised.

```
using System;

namespace SampleApp {
   public delegate string MyDel(string str);
	
   class EventProgram {
      event MyDel MyEvent;
		
      public EventProgram() {
         this.MyEvent += new MyDel(this.WelcomeUser);
      }
      public string WelcomeUser(string username) {
         return "Welcome " + username;
      }
      static void Main(string[] args) {
         EventProgram obj1 = new EventProgram();
         string result = obj1.MyEvent("Tutorials Point");
         Console.WriteLine(result);
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Welcome Tutorials Point
```


## Anonymous Methods

We discussed that delegates are used to reference any methods that has the same signature as that of the delegate. In other words, you can call a method that can be referenced by a delegate using that delegate object.

Anonymous methods provide a technique to pass a code block as a delegate parameter. Anonymous methods are the methods without a name, just the body.

You need not specify the return type in an anonymous method; it is inferred from the return statement inside the method body.

### Writing an Anonymous Method
Anonymous methods are declared with the creation of the delegate instance, with a delegate keyword. For example,

```
delegate void NumberChanger(int n);
...
NumberChanger nc = delegate(int x) {
   Console.WriteLine("Anonymous Method: {0}", x);
};
```


The code block Console.WriteLine("Anonymous Method: {0}", x); is the body of the anonymous method.

The delegate could be called both with anonymous methods as well as named methods in the same way, i.e., by passing the method parameters to the delegate object.

For example,
```
nc(10);
```

### Example
The following example demonstrates the concept −

```
using System;

delegate void NumberChanger(int n);
namespace DelegateAppl {
   class TestDelegate {
      static int num = 10;
      
      public static void AddNum(int p) {
         num += p;
         Console.WriteLine("Named Method: {0}", num);
      }
      public static void MultNum(int q) {
         num *= q;
         Console.WriteLine("Named Method: {0}", num);
      }
      public static int getNum() {
         return num;
      }
      static void Main(string[] args) {
         //create delegate instances using anonymous method
         NumberChanger nc = delegate(int x) {
            Console.WriteLine("Anonymous Method: {0}", x);
         };
         
         //calling the delegate using the anonymous method 
         nc(10);
         
         //instantiating the delegate using the named methods 
         nc =  new NumberChanger(AddNum);
         
         //calling the delegate using the named methods 
         nc(5);
         
         //instantiating the delegate using another named methods 
         nc =  new NumberChanger(MultNum);
         
         //calling the delegate using the named methods 
         nc(2);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Anonymous Method: 10
Named Method: 15
Named Method: 30
```


## Unsafe Codes


C# allows using pointer variables in a function of code block when it is marked by the unsafe modifier. The unsafe code or the unmanaged code is a code block that uses a pointer variable.

### Pointers
A pointer is a variable whose value is the address of another variable i.e., the direct address of the memory location. similar to any variable or constant, you must declare a pointer before you can use it to store any variable address.

The general form of a pointer declaration is −

```
type *var-name;
```

Following are valid pointer declarations −

```
int    *ip;    /* pointer to an integer */
double *dp;    /* pointer to a double */
float  *fp;    /* pointer to a float */
char   *ch     /* pointer to a character */
```

The following example illustrates use of pointers in C#, using the unsafe modifier −

```
using System;

namespace UnsafeCodeApplication {
   class Program {
      static unsafe void Main(string[] args) {
         int var = 20;
         int* p = &var;
         
         Console.WriteLine("Data is: {0} ",  var);
         Console.WriteLine("Address is: {0}",  (int)p);
         Console.ReadKey();
      }
   }
}
```

When the above code wass compiled and executed, it produces the following result −

```
Data is: 20
Address is: 99215364
```


Instead of declaring an entire method as unsafe, you can also declare a part of the code as unsafe. The example in the following section shows this.

### Retrieving the Data Value Using a Pointer
You can retrieve the data stored at the located referenced by the pointer variable, using the ToString() method. The following example demonstrates this −

```
using System;

namespace UnsafeCodeApplication {
   class Program {
      public static void Main() {
         unsafe {
            int var = 20;
            int* p = &var;
            
            Console.WriteLine("Data is: {0} " , var);
            Console.WriteLine("Data is: {0} " , p->ToString());
            Console.WriteLine("Address is: {0} " , (int)p);
         }
         Console.ReadKey();
      }
   }
}
```

When the above code was compiled and executed, it produces the following result −

```
Data is: 20
Data is: 20
Address is: 77128984
```

### Passing Pointers as Parameters to Methods
You can pass a pointer variable to a method as parameter. The following example illustrates this −

```
using System;

namespace UnsafeCodeApplication {
   class TestPointer {
      public unsafe void swap(int* p, int *q) {
         int temp = *p;
         *p = *q;
         *q = temp;
      }
      public unsafe static void Main() {
         TestPointer p = new TestPointer();
         int var1 = 10;
         int var2 = 20;
         int* x = &var1;
         int* y = &var2;
         
         Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
         p.swap(x, y);

         Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
Before Swap: var1: 10, var2: 20
After Swap: var1: 20, var2: 10
```

### Accessing Array Elements Using a Pointer
In C#, an array name and a pointer to a data type same as the array data, are not the same variable type. For example, int *p and int[] p, are not same type. You can increment the pointer variable p because it is not fixed in memory but an array address is fixed in memory, and you can't increment that.

Therefore, if you need to access an array data using a pointer variable, as we traditionally do in C, or C++ ( please check: C Pointers), you need to fix the pointer using the fixed keyword.

The following example demonstrates this −

```
using System;

namespace UnsafeCodeApplication {
   class TestPointer {
      public unsafe static void Main() {
         int[]  list = {10, 100, 200};
         fixed(int *ptr = list)
         
         /* let us have array address in pointer */
         for ( int i = 0; i < 3; i++) {
            Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr + i));
            Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
         }
         
         Console.ReadKey();
      }
   }
}
```

When the above code was compiled and executed, it produces the following result −

```
Address of list[0] = 31627168
Value of list[0] = 10
Address of list[1] = 31627172
Value of list[1] = 100
Address of list[2] = 31627176
Value of list[2] = 200
```

### Compiling Unsafe Code
For compiling unsafe code, you have to specify the /unsafe command-line switch with command-line compiler.

For example, to compile a program named prog1.cs containing unsafe code, from command line, give the command −
```
csc /unsafe prog1.cs
```

If you are using Visual Studio IDE then you need to enable use of unsafe code in the project properties.

To do this −

- Open project properties by double clicking the properties node in the Solution Explorer.
- Click on the Build tab.
- Select the option "Allow unsafe code".

## Multithreading
A thread is defined as the execution path of a program. Each thread defines a unique flow of control. If your application involves complicated and time consuming operations, then it is often helpful to set different execution paths or threads, with each thread performing a particular job.

Threads are lightweight processes. One common example of use of thread is implementation of concurrent programming by modern operating systems. Use of threads saves wastage of CPU cycle and increase efficiency of an application.

So far we wrote the programs where a single thread runs as a single process which is the running instance of the application. However, this way the application can perform one job at a time. To make it execute more than one task at a time, it could be divided into smaller threads.

### Thread Life Cycle
The life cycle of a thread starts when an object of the System.Threading.Thread class is created and ends when the thread is terminated or completes execution.

Following are the various states in the life cycle of a thread −

- The Unstarted State − It is the situation when the instance of the thread is created but the Start method is not called.
- The Ready State − It is the situation when the thread is ready to run and waiting CPU cycle.
- The Not Runnable State − A thread is not executable, when

   - Sleep method has been called
   - Wait method has been called
   - Blocked by I/O operations
- The Dead State − It is the situation when the thread completes execution or is aborted.

### The Main Thread
In C#, the System.Threading.Thread class is used for working with threads. It allows creating and accessing individual threads in a multithreaded application. The first thread to be executed in a process is called the main thread.

When a C# program starts execution, the main thread is automatically created. The threads created using the Thread class are called the child threads of the main thread. You can access a thread using the CurrentThread property of the Thread class.

The following program demonstrates main thread execution −

```
using System;
using System.Threading;

namespace MultithreadingApplication {
   class MainThreadProgram {
      static void Main(string[] args) {
         Thread th = Thread.CurrentThread;
         th.Name = "MainThread";
         
         Console.WriteLine("This is {0}", th.Name);
         Console.ReadKey();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
This is MainThread
```

### Creating Threads
Threads are created by extending the Thread class. The extended Thread class then calls the Start() method to begin the child thread execution.

The following program demonstrates the concept −

```
using System;
using System.Threading;

namespace MultithreadingApplication {
   class ThreadCreationProgram {
      public static void CallToChildThread() {
         Console.WriteLine("Child thread starts");
      }
      static void Main(string[] args) {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         Thread childThread = new Thread(childref);
         childThread.Start();
         Console.ReadKey();
      }
   }
}
```

When the above code is compiled and executed, it produces the following result −

```
In Main: Creating the Child thread
Child thread starts
```

### Managing Threads
The Thread class provides various methods for managing threads.

The following example demonstrates the use of the sleep() method for making a thread pause for a specific period of time.

```
using System;
using System.Threading;

namespace MultithreadingApplication {
   class ThreadCreationProgram {
      public static void CallToChildThread() {
         Console.WriteLine("Child thread starts");
         
         // the thread is paused for 5000 milliseconds
         int sleepfor = 5000; 
         
         Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
         Thread.Sleep(sleepfor);
         Console.WriteLine("Child thread resumes");
      }
      
      static void Main(string[] args) {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         
         Thread childThread = new Thread(childref);
         childThread.Start();
         Console.ReadKey();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
In Main: Creating the Child thread
Child thread starts
Child Thread Paused for 5 seconds
Child thread resumes
```

### Destroying Threads
The Abort() method is used for destroying threads.

The runtime aborts the thread by throwing a ThreadAbortException. This exception cannot be caught, the control is sent to the finally block, if any.

The following program illustrates this −

```
using System;
using System.Threading;

namespace MultithreadingApplication {
   class ThreadCreationProgram {
      public static void CallToChildThread() {
         try {
            Console.WriteLine("Child thread starts");
            
            // do some work, like counting to 10
            for (int counter = 0; counter <= 10; counter++) {
               Thread.Sleep(500);
               Console.WriteLine(counter);
            }
            
            Console.WriteLine("Child Thread Completed");
         } catch (ThreadAbortException e) {
            Console.WriteLine("Thread Abort Exception");
         } finally {
            Console.WriteLine("Couldn't catch the Thread Exception");
         }
      }
      static void Main(string[] args) {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         
         Thread childThread = new Thread(childref);
         childThread.Start();
         
         //stop the main thread for some time
         Thread.Sleep(2000);
         
         //now abort the child
         Console.WriteLine("In Main: Aborting the Child thread");
         
         childThread.Abort();
         Console.ReadKey();
      }
   }
}
```
When the above code is compiled and executed, it produces the following result −

```
In Main: Creating the Child thread
Child thread starts
0
1
2
In Main: Aborting the Child thread
Thread Abort Exception
Couldn't catch the Thread Exception 
```

