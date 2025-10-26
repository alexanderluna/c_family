//// integer variable types
//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main(){
//    // max and min value for int
//    // int variableName
//    cout << "Max int: " << INT_MAX << endl;
//    cout << "Min int: " << INT_MIN << endl;
//    
//    // max and min value for long int
//    // long int variableName
//    // long variableName
//    cout << "Max long int: " << LONG_MAX << endl;
//    cout << "Min long int: " << LONG_MIN << endl;
//    
//    // max and min value for short int
//    // short int variableName
//    // short variableName
//    cout << "Max short int: " << SHRT_MAX << endl;
//    cout << "Min short int: " << SHRT_MIN << endl;
//    
//    // Signed vs Usigned
//    // Signed => Allow negative number
//    // Unsigned => Don't allow negative number (ignores - sign)
//    // Unsigned ints have one extra space don't store + or - internally
//    signed int sNumber = -10000;
//    unsigned int uNumber = -1000;
//    
//    cout << "Signed Number: " << sNumber
//    << "\nUsigned Number: " << uNumber
//    << endl;
//    
//    // Size of Integers in bytes
//    cout << "Long int byte size: " << sizeof(long int)
//    << "\nShort int byte size: " << sizeof(short int)
//    << "\nNormal int byte size: " << sizeof(int)
//    << endl;
//
//
//
//    int first_number;
//    int second_number;
//
//    double quotient;
//
//    cout << setprecision(2);
//    cout << "Please give me a number: ";
//    cin >> first_number;
//
//    cout << "Please give me a second nubmer: ";
//    cin >> second_number;
//
//    cout << "The sum of the two numbers you gave me is: "
//    << first_number + second_number
//    << "\nThe difference of the two numbers is: "
//    << first_number - second_number
//    << "\nThe product of the two numbers is: "
//    << first_number * second_number
//    << "\nThe quotient of the two numbers is: "
//    << first_number / second_number
//    << "\nThe remainder of the two numbers is: "
//    << first_number % second_number << endl;
//
//    quotient = double(first_number) / double(second_number);
//
//    cout << "The quotient is exactly: " << quotient << endl;
//    cin.ignore();
//    return 0;
//
//// Note: getline() doesn't work with integers. User cin >> to pipe the input into the variable.
////    Make all numbers have 2 decimal places using fixed.
////    cout << setprecision(2) << fixed;
//
//    return 0;
//    
//}
