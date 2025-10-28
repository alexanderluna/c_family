# Learning C++

- [Basic Syntax](#the-basics)
  - [Functions](#functions)
  - [Types](#types)
  - [Scope and Immutability](#scope-and-immutability)
  - [Arrays, Pointers and References](#arrays-pointers-and-references)
  - [Loops](#loops)
  - [Control Flow](#control-flow)
- [User-Defined Types](#user-defined-types)
  - [Structures](#structures)
  - [Classes](#classes)
  - [Enums](#enums)
  - [Unions](#unions)
- [Modularity](#modularity)
- [Error Handling](#error-handling)

## The Basics

C++ is a statically typed and compiled language, meaning that your source code
has to be compiled into an object files which are then combined by a linker
creating an executable. Each executable is created for a specific
hardware/system (non portable). Nonetheless, we do talk about C++ portability in
terms of source code which can be compiled and run on a variety of systems. The
ISO C++ standard defines two kinds of entities.

1. Core languages features (built-in types):
2. Standard-library components (container, I/O operations): provided by C++ implementation

Your typical C++ program looks like this:

```cpp
// makes standard library declarations available in your program
#include <iostream>;

using namespace std;

// the main function is your required entry point
// with an int return value to the system
int main() {
    cout << "Greeting from C++\n";
}
```

### Functions

**Function** declarations have a name, return type and the types of the
arguments that must be supplied in a call. Functions can be a member of a class
in which case the name of its class is also part of the function type. C++ also
supports **function overloading** (multiple functions with the same name).

```cpp
double get(const vector<double>& vec, int index);

char& String::operator[](int index);

// the compiler choses the most appropriate for each call.
void print(int);
void print(double);
void print(string)
```

### Types

Every name and expression has a type that limits the operations it can perform.
A declaration introduces an entity into the program and specifies the type:

- type: set of possible values and operations with a fixed size
- object: memory that holds a value
- value: bits interpreted as a type
- variable: named object

C++ offers a long list of **fundamental types** and **arithmetic operators**.
For a complete list reference the C++ Reference:

- [Fundamental types](https://en.cppreference.com/w/cpp/language/types.html)
- [Arithmetic operators](https://en.cppreference.com/w/cpp/language/operator_arithmetic.html)

Before you can use an object you have to **initialize** it and C++ has several
ways of accomplishing this:

```cpp
double rate = 5.5;      // traditional
double rate {5.5};      // preferred
double rate = {5.5};

auto playable = true;
auto firstCharacter = 'a';
auto year = 1980;
```

> The `{}` is preferred because it will throw an error early if the value
> doesn't match the type while the `=` will try to convert the type and result
> in unexpected behavior.

### Scope and Immutability

Each declaration introduces its name into a **scope**:

1. local scope: declared in a function or lambda
2. class scope: a member name defined within a class
3. namespace scope: defined within a namespace but outside any other scope

You can declare two types of **immutability**. One with `const` and another with
`constexpr`. Functions declared `constexpr` or `consteval` are the C++ version
of a **pure function**.

```cpp
constexpr double nth(double x, int n)
{
    // own local variables
    double res = 1;
    int i = 0;

    // can use loops
    while (i < n) {
        res *= x;
        ++i;
    }

    return res;
}
```

### Arrays, Pointers and References

You can allocate a contiguous sequence of objects in memory using an **array**,
**pointers** and **references**. An array has to declare its type and size.

```cpp
char name[10];              // an array of 10 characters

char* initial = &name[0];   // initial points to the 1st element of name

char* end = nullptr;
```

> `*` means "contents of" and `&` means "address of". If you don't have an
> object to point to you can use the **null pointer** `nullptr`.

### Loops

You loop over an array with a **for loop** or **while loop**:

```cpp
char name[10] = {'a', 'l', 'e', 'x', 'a', 'n', 'd', 'e', 'r'};

for (auto c=0; c!=10; ++c)
    cout << name[c] << '\n';

for (auto &letter : name)
    cout << letter << '\n';
```

> When you don't want to modify an argument and don't want to copy a value, you
> can use a **const reference**. When you use them in declarations, the
> operators (&, *, []) are called **declarator operators**.

### Control Flow

You can control the flow of your program with `if` and `switch` statements:

```cpp
if (answer == true)
    cout << "OK" << '\n';

switch (answer) {
    case 'yes':
        cout << "OK,  let's do that" << '\n';
        break;
    case 'no':
        cout << "Too bad,  let's not do that" << '\n';
        break;
    default:
        cout << "I don't know what you mean" << '\n';
        return false;
}
```

## User-Defined Types

C++ has two types:

1. built-in types: fundamental, low level and efficient types
2. user-defined types: use C++ abstraction mechanism to create high level type

### Structures

Creating a new type can be as simple as defining a data structure with a
`struct` and initializing it with a function to allocate its objects in memory.

```cpp
struct Vector {
  double *el;
  int sz;
};

void vector_init(Player &v, int s) {
  v.el = new double[s]; // create elements of specified size
  v.sz = s;
}

double read_and_sum(int s) {
  Vector v;
  vector_init(v, s);

  for (int i = 0; i != s; ++i)
    cin >> v.el[i];

  // sum up all the elements
  double sum = 0;
  for (int i = 0; i != s; ++i)
    sum += v.element[i];
  return sum;
}
```

However, the problem with this approach is that the user has to know the
internal details of this new data structure representation and manage the memory
manually to be able to use it.

### Classes

A class solves these problems by encapsulating the data hiding the internal
details (making them `private`) and exposing an interface with `public` members.

```cpp
class Vector {
public:
  // the constructor requires an int to initialize a Vector
  Vector(int s) : element{new double[s]}, sz{s} {}
  // operator[] lets us control what should be returned when Vector[x] is called
  double &operator[](int i) { return element[i]; }
  int size() { return sz; }

private:
  double *element;
  int sz;
};

double read_and_sum(int s) {
  Vector v(s);
  for (int i = 0; i != v.size(); ++i)
    cin >> v[i];

  double sum = 0;
  for (int i = 0; i != v.size(); ++i)
    sum += v[i];

  return sum;
}
```

> A `struct` is a `class` where its members are public by default. The `class`
> implementation simplified the initialization of the Vector through the
> constructor. Furthermore it manages its own data through a fixed sized object.

### Enums

Another user-defined type C++ supports is `enum` and `enum class`. Enumerations
are used to represent small sets of integer values making your code more
readable and less error-prone. You have two forms of Enumerators:

1. `enum class`: scoped enum is strongly typed and must be used with its name
2. `enum`: unscoped enum is directly available and automatically converted to an `int`

```cpp
enum class Color { red, green, blue };
enum class Light { red, green, blue };

Color col = Color::blue; 
Light lgt = Color::blue; // error has to be a Color type
int b = Color::blue; // error blue is a color
int b = int(Color::blue);

enum Color { red, green, blue };

int c = blue;
```

> Generally, `enum class` is preferred because `enum class` also supports custom
> `operator` like other classes and the scope makes its use less error-prone.

### Unions

A `union` is a `struct` where all members share the same address occupying only
as much space as the largest member. Since they occupy the same space, it means
that only one member can hold a value at a time. It is a very memory efficient
data type. However, you have to manually manage which member is currently
active which can be error-prone.

```cpp
enum class Type { ptr, num };
union Value { Node* p; int i; };

struct Entry {
  string name;
  Type t;  // "tag" to track active union member
  Value v; // use v.p if t==Type::ptr, v.i if t==Type::num
};
```

In order to simply things and add type safety, you can use the standard
library's `variant` type. This way you don't have to manually manage the
currently active member with a tag.

```cpp
struct Entry {
  string name;
  variant<Node*, int> v; // Can hold either Node* or int
};

void f(Entry* pe) {
  if (holds_alternative<int>(pe->v))
    cout << get<int>(pe->v); // Type-safe access
}
```

## Modularity

C++ consists of many different functions, types, classes and templates.
Therefore, it is important to clearly separate **declarations** (interface) from
**definitions** (implementation). The declaration specifies what is needed to
use the function:

```cpp
double sqrt(double) // sqrt requires a double and returns a double
```

Modularity in C++ allows us to separate the implementation in two ways:

1. Header Files: declarations are placed in a `.h` file and included with `#include`
2. Modules: code is organized in modules with `export module` and included with `import`

```cpp
// Vector.h

class Vector {
  // interface declaration
}

// Vector.cpp

#include "Vector.h"

Vector::Vector(int s): element{new double[s]}, sz{s} {
  // implementation details
}

// your program.cpp

#include "Vector.h"

double sqrt_sum(const Vector& v) {
  // implementation details
}
```

This is the standard approach and it is the same in C. However, this approach
results in slow compilation because header files are processed multiple times
and depending on the order you declare the `#include` it can result in
inconsistency. Therefore, C++ 20 introduced the `export module` and `import`

```cpp
export module Vector;

export class Vector {
  // interface declaration
}

Vector::Vector(int s): element{new double[s]}, sz{s} {
  // implementation details
}

// your program.cpp

import Vector;

double sqrt_sum(const Vector& v) {
  // implementation details
}
```

> Header files are still the standard due to legacy code and will have to be
> replaced gradually by the new module syntax. That is why the new module
> syntax allows to mix `#include` and `import`.

## Error Handling
