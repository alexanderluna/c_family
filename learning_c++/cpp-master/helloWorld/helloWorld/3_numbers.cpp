//// Work with nubmers and decimal places.
//#include <iostream>
//#include <iomanip>
//
//using namespace std;
//
//int main() {
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
//}
//
//// Note: getline() doesn't work with integers. User cin >> to pipe the input into the variable.
////    Make all numbers have 2 decimal places using fixed.
////    cout << setprecision(2) << fixed;
