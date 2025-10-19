#include <iostream>
#include "Cat.h"

using namespace std;

// constructor
Cat::Cat(string name): name(name){
    cout << "\nCat created: " << name << endl;
    happy = true;
}

// destructor
Cat::~Cat(){
    cout << "Cat destroyed" << endl;
}

void Cat::speak(){
    if (happy) {
        cout << "Nyaaa... my name is " << name << endl;
    } else {
        cout << "mehhh... " << name << " is tired" << endl;
    }
}

void Cat::makeHappy(){
    happy = true;
}

void Cat::makeSad(){
    happy = false;
}

void Cat::changeName(string name){
    this->name = name;
}

string Cat::printName(){
    return "My name is: " + name;
}

string Cat::getName(){
    return name;
}
