# C, C++ and C\#

**C** is a procedural, low-level systems language. It offers minimal abstraction
and maximum control.

**C++** is a multi-paradigm (procedural, OOP, generic) language that builds on C,
adding high-level features while retaining low-level control.

**C#** is a modern, high-level, managed language primarily designed for the .NET
ecosystem, focusing on productivity and safety.

## Table of Contents

- [Overview C Family](#overview-c-family)
  - [C algorithms](./c_algorithms/)
  - [C command line interface apps](./c_cli/)
  ---
  - [C++ algorithms](./c++_algorithms/)
  - [C++ command line interface apps](./c++_cli/)
  - [C++ unreal engine](./c++_unreal_engine/)
  ---
  - [C# algorithms](./c#_algorithms/)
  - [C# command line interface apps](./c#_cli/)
  - [C# unity](./unity/)
  - [C# .net](./dotnet/)
- [Learning C Family](#learning-c-family)
  - [Learning C](./learning_c/)
  - [Learning C++](./learning_c++/)
  - [Learning C#](./learning_c_sharp/)
- [Resources](#resources)

## Overview C Family

**The C programming language**, developed in the 70s for system programming,
remains an incredibly popular language mainly due its design philosophy, known
as the *spirit of C* which includes:

- Trusting the programmer’s judgment.
- Allowing low-level operations when needed.
- Keeping the language small and simple.
- Avoiding redundant features.
- Prioritizing speed over portability.

Because of this, C is foundational to computing (many compilers and libraries
use it). It is used for building operating systems (Linux), in embedded systems
(cars and appliances), Internet of Things, and for general purpose programming.
The language combines high performance, direct hardware access, and a large
ecosystem of libraries.

**C++** is a multi-paradigm language (procedural, OOP, generic) that builds on
C, adding high level organization while retaining low level control and C like
speed. It is well suited for large code bases, game engines, graphic intensive
applications and scientific calculation.

**C#** is a modern, high level, managed language (no memory control) primarily
designed for the .NET ecosystem but also used for building cross platform games
using Unity. It is well suited for rapid development especially for the Web,
Mobile, Desktop and Game development.

## Learning C Family

In order to learn C/C++/C# you will need an IDE like VSC, Code::Blocks or
Eclipse. For C/C++ you will also need a compiler like `gcc` or `clang`.
Microsoft has really good extensions for IntelliSense, debugging, and code
browsing which you can install in VSC.

```sh
# on Linux you can install both compiler like this
sudo apt-get install gcc
sudo apt-get install clang

# on MacOS you have to install Xcode developer tools for clang
xcode-select --install
# or install gcc only
brew install gcc
```

For C# you will need the `.NET` application platform to build, debug and run
your code.

```sh
# on Linux add the microsoft package repo and download the sdk
sudo dpkg -i packages-microsoft-prod.deb
sudo apt install -y dotnet-sdk-8.0

# on MacOS
brew install dotnet
```

## Resources

- [Effective C, 2nd Edition]()
- [C Brain Teasers]()
- [Tiny C Projects]()
- [Bare Metal C]()
- [Modern C]()

---

- [A Tour of C++]()
- [Learn C++ by Example]()
- [C++ Brain Teasers]()
- [100 C++ Mistakes and How to Avoid Them]()
- [Modern C++ Programming with Test-Driven Development]()
- [C++ Concurrency in Action]()

---

- [C# Brain Teasers]()
- [C# in Depth, 4th Edition]()
- [Code like a Pro in C#]()
- [Gray hat C#]()
