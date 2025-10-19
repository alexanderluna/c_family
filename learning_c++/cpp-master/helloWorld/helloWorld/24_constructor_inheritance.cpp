//// constructor inheritance
//#include <iostream>
//
//using namespace std;
//
//class Machine {
//private:
//    int id;
//public:
//    Machine(): id(0) { cout << "No argument Machine created" << endl; }
//    Machine(int id): id(id) { cout << "Parameter Machine created" << endl;}
//    void info() { cout << "My ID is: " << id << endl; }
//};
//
//
//class Vehicle: public Machine {
//public:
//    Vehicle() {cout << "No argument Vehicle created" << endl; }
//    Vehicle(int id): Machine(id) {cout << "Argument Vehicle created" << endl; }
//};
//
//
//class Car: public Vehicle {
//public:
//    Car() { cout << "No argument Car created" << endl; }
//    Car(int id): Vehicle(id) { cout << "Argument Car created" << endl; }
//};
//
//
//int main(){
//    // Machine class
//    cout << "<< Create a Machine (NP) >>" << endl;
//    Machine machine;
//    machine.info();
//    
//    cout << "\n<< Create a Machine (WP) >>" << endl;
//    Machine machineParam(1);
//    machineParam.info();
//    
//    
//    // Vehicle class
//    cout << "\n<< Create a Vehicle (NP) >>" << endl;
//    Vehicle vehicle;
//    vehicle.info();
//    
//    cout << "\n<< Create a Vehicle (WP) >>" << endl;
//    Vehicle vehicleParam(2);
//    vehicleParam.info();
//    
//    
//    // Car class
//    cout << "\n<< Create a Car (NP) >>" << endl;
//    Car car;
//    car.info();
//    
//    cout << "\n<< Create a Car (WP) >>" << endl;
//    Car carParam(3);
//    carParam.info();
//    
//}
