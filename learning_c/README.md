# Learning C

## Basic Syntax

C is designed to create small, fast and lower level code which means it's closer
to machine code. The way C works is:

1. source code: written in C
2. compile: checks for errors and compiles the source
3. output: an executable with machine code

> There are 5 major C versions. ANSI C (1980), C99 which fixed a lot of
> things from 1999, C11 from 2011 which added new features, C17 fixed some
> common problems and C23 the latest standard which improved compatibility with
> C++.

Your typical C program will look like this:

```c
/*
 * It is good practice to start with a comment describing what the code is about
 */

// next include the libraries you are going to need
#include <stdio.h>

// the main function is your starting point and the most important function
int main() {
  char name[20];

  puts("Enter your name");
  scanf("%19s", name);
  printf("Greeting from C, %s.\n", name);

  return 0;
}
```

> You can compile and run your C program with [gcc (GNU Compiler Collection)](https://gcc.gnu.org)
> `gcc hello.c -o hello && ./hello`.

Notice that the main function returns an `int`. When the computer runs your
program it will check the return value of the `main()` function. Returning 0
means the program was successful while returning any other number indicates a
problem.

Why did we use a character array to store then name instead of a string ? In C,
Strings are just character arrays but with a sentinel character, which is an
additional character at the end of the string `\0` (Null character).

You can control the flow of your program with control statements like `if/else`
or `switch` statements:

```c
// in C numbers are booleans. 0 = false, 1+ = true
int val = 0;
char card = 'K';

if (card == 'K') {
    val = 10;
} else if (card == 'A') {
    val = 11;
}

// switch only works with single values
// not with arrays or string
switch(card) {
    case 'K':
        val = 10;
        break;
    case 'A':
        val = 11;
        break;
    default
}
```

If you want to run code over and over you can use a loop statement like a
`while` or `for` loop:

```c
while(playing) {
    // keep running game logic
}

do {
    // run game logic at least once
} while(playing);

for (counter = 1; counter < 10; counter++) {
    // keep counting
}
```

> use a `break` statement to skip out of the loop and a `continue` statement to
> skip the rest of the loop and go back to the start of the loop.

A function in C can return a value or nothing but you always have to specify
the return value type and the argument types. In fact, almost anything has a
return value in C even assignments:

```c
int main() {
    return 0;
}

int greater(int a, int b) {
    if (a > b)
        return a;
    return b;
}

// no return
void hello() {
    puts("Hello there");
}

// assignment return values can be used to chain them together
a = b = 5;
```

## Memory and Pointers

Pointer is a fundamental part of C. A **Pointer** is the address of a piece of
data in memory and is really useful for two things:

- it is an efficient way to passing data around instead of making copies.
- several pieces of code can work on the same piece of data

> Any time you declare a variable within a function, the computer will store it
> in the **stack**.

In order to get the memory address of a variable, use the `&` operator. You can
store the address of a variable in a **pointer variable** using a `*` to get
the value stored in that address.

```c
#include <stdio.h>

void update_score(int *score) { *score = *score + 1; }

int main() {
  int score = 7;

  printf("Current score: %i\n", score);

  update_score(&score);

  printf("New score: %i\n", score);

  return 0;
}
```

### Array Variables

When it comes to strings, C treats strings like an array of characters. This
means that if you point to a string, C will point at the array of characters
that make up that string (array variable). Specifically, it will point to the
start of the array in memory. However, if you point at an array variable the
result is the array variable itself.

> Given a character array `char greeting[] = "Hello World";`, using the `sizeof`
> operator on `greeting` will return the size of the array. Using the `sizeof`
> operator on a pointer will returns 4 (32-bit) or 8 (64-bit) depending on your
> Operating System. If you pass a pointer of an array you are effectively losing
> information about the size of the array (**pointer decay**). Furthermore,
> the computer doesn't allocate any memory to store array variables which in
> turn means that you can't point an array variable at something else.

### Pointer Arithmetic

You can access a value within an array in two ways:

1. use **bracket notation**: `greeting[4]`
2. use **pointer arithmetic**: `*(greeting + 4)`

Pointer arithmetic explains why arrays begin with index 0. This way the index
becomes the number you have to add to the pointer to find the location of the
element. On the other hand, it also explains why pointers have to have types.
If you add 1 to a `char` pointer you will get the next character because each
character occupies 1 byte of memory. However, if you add 1 to an `int`, `short`,
`long` which have different sizes wouldn't return the correct number. The type
exists so that the knows how much to adjust the pointer arithmetic.

As seen previously, `scanf` gets user input and saves it in a variable. The way
`scanf` does this is through pointers. Each character or number the user inputs,
updates the array. This means that if you don't limit the length of the input,
the user can enter data beyond the size of the array resulting a
**buffer overflow**. A securer alternative to `scanf` is `fgets` which requires
a maximum length argument.

```c
char name[20];

scanf("%s", name); // may result in a buffer overflow
scanf("%19s", name); // limits the input manually
fgets(name, sizeof(name), stdin); // limits the input to the size of the array
```

### Constants

In C, string literals are stored in the constant memory block which is read
only. This makes it impossible to update a string literal even if you try to
access the characters of the string with a pointer. If you need to update a
string use a character array.

```c
char *greeting = "Hello";
greeting[0] = greeting[3]; // bus error

char greeting[] = "Hello";
greeting[0] = greeting[3]; // lello
```

> A quick break down of how memory is managed on your computer:
>
> 1. Stack: this is where local variables are stored.
> 2. Heap: dynamic memory allocation for data that is created while the program runs
> 3. Globals: global variables are stored and created here when the program first runs
> 4. Constants: are read-only and also created when the program first runs
> 5. Code: Your code is stored in the lowest memory address and is also read-only
