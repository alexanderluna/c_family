# Learning C# (csharp)

## C# vs .NET

C# is a programming language while .NET is a framework for building
applications. The .NET framework isn't limited to C# as it can use F#, VB, etc.
The .NET framework consists of 2 components:

- CLR (common language runtime)
- Class Library

## CLR (Common Language Runtime)

Before C# there were languages like C and C++ where code was compiled directly
into machine code. However, this means that code build on one machine wouldn't
run on another machine. Thus, C# borrowed an idea from Java where code gets
translated into an intermediate language called ByteCode for portability. In
C#, something similar happens. Code gets translated into IL
(Intermediate Language) which is machine agnostic. The CLR is responsible for
taking that IL and translate it into machine code using JIT (just in time
compilation).

## .NET Architecture

An application consists of Classes which collaborate with each other to
provide functionality. As the number of classes increases, Namespaces organize
classes into groups. In turn, Assembly (DLL, EXE) organize Namespaces. Finally
the Application build one or more Assemblies

## Code Examples

1. [Variables](learning_c_sharp/01_Variables.cs)
2. [Arrays](learning_c_sharp/02_Arrays.cs)
3. [Loops](learning_c_sharp/03_Loops.cs)
4. [Conditionals](learning_c_sharp/04_Conditionals.cs)
5. [Objects and Methods](learning_c_sharp/05_ObjectsAndMethods.cs)
6. [Dates](learning_c_sharp/Dates.cs)
7. [Files](learning_c_sharp/Files.cs)
8. [Getter and Setters](learning_c_sharp/GetterSetter.cs)

## Resources

- [(Udemy) C# Basics for Beginners](https://www.udemy.com/csharp-tutorial-for-beginners/)
- [(Udemy) C# Intermediate](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/)
- [(Udemy) C# Advanced Topics](https://www.udemy.com/csharp-advanced/)
- [(Book) Head First C#](http://shop.oreilly.com/product/0636920027812.do)
- [(Book) C# in Depth](https://www.manning.com/books/c-sharp-in-depth-fourth-edition)
