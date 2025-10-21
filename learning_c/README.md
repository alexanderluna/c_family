# Learning C

## Introduction

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
// in numbers are booleans. 0 = false, 1+ = true
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
