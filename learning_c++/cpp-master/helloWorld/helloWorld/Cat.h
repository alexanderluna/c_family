//
//  Cat.h
//  helloWorld
//
//  Created by Lisa on 4/16/17.
//  Copyright © 2017 Sascha Luna. All rights reserved.
//

#ifndef Cat_h
#define Cat_h

#include <iostream>

using namespace std;

class Cat {
private:
    bool happy;
    string name;
    
public:
    Cat(string name);
    ~Cat();
    void speak();
    void makeHappy();
    void makeSad();
    string printName();
    void changeName(string newName);
    string getName();
};

#endif /* Cat_h */

// Notes:
// constructor
// Cat();
// destructor
// ~Cat();
// 2nd constructor
// Cat(string newName) { name = newName; };

