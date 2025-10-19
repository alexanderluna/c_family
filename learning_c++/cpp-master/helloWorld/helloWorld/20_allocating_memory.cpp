//// Allocating Memory
//#include <iostream>
//using namespace std;
//
//class Animal {
//private:
//    string name;
//    
//public:
//    Animal() {
//        cout << "Animal created" << endl;
//    }
//    
//    Animal(const Animal& other): name(other.name) {
//        cout << "Animal created by copying" << endl;
//    }
//    
//    ~Animal() {
//        cout << "Animal destroyed" << endl;
//    }
//    
//    void setName(string name) {
//        this->name = name;
//    }
//    
//    void speak() const {
//        cout << "My name is: " << name << endl;
//    }
//};
//
//Animal *createAnimal() {
//    Animal *a = new Animal();
//    a->setName("Berd");
//    return a;
//}
//
//
//int main(){
//    Animal *dog = createAnimal();
//    dog->speak();
//    
//    Animal *pAnimals = new Animal[10];
//    
//    pAnimals[5].setName("George");
//    pAnimals[5].speak();
//    delete [] pAnimals;
//    
//    
//    // challenge: create animals and set
//    //            the name to a character
//    //            in the alphabet
//    
//    char c = 'a';
//    
//    for (int i = 0; i < 26; i++) {
//        Animal *pAnimal = new Animal();
//        pAnimal->setName(string(1, c));
//        pAnimal->speak();
//        delete pAnimal;
//        c++;
//    }
//    
//    return 0;
//    
//}
