//// if statements
//#include <iostream>
//using namespace std;
//
//int main(){
//    
//    string password = "password";
//    cout << "Enter password: ";
//    
//    string input;
//    cin >> input;
//    
//    if (input == password) {
//        cout << "Correct password\nAccess granted\n" << endl;
//        
//        cout << "1. Add new Record" << endl;
//        cout << "2. Search Record" << endl;
//        cout << "3. Delete Record" << endl;
//        cout << "4. Quit" << endl;
//        cout << "Enter your selection > ";
//        
//        int answer;
//        cin >> answer;
//        
//        switch (answer) {
//            case 1:
//                cout << "Adding new record...\nDone, added new Record" << endl;
//                break;
//            case 2:
//                cout << "Searching record...\nDone, found record" << endl;
//                break;
//            case 3:
//                cout << "Deleting record...\nDone, deleted record" << endl;
//                break;
//            case 4:
//                cout << "Exiting...\nHave a nice day" << endl;
//            default:
//                break;
//        }
//        
//    } else if (input != password) {
//        cout << "Wrong password\nAccess denied" << endl;
//    }
//
//
//
//    /* == equal to
//     * != not equal
//     * > greater than
//     * < less than
//     * <= less than or equal
//     * >= greater than or equal
//     * || or
//     * && and
//     */
//
//    int first = 7;
//    int second = 5;
//
//    if (first < second) {
//        cout << "Condition 1: true" << endl;
//        if (first == 7 && second == 5) {
//            cout << "Condition 2: true" << endl;
//        } else {
//            cout << "Condition 2: false" << endl;
//        }
//    } else {
//        cout << "Condition 1: false" << endl;
//        if (first == 5 || second == 5) {
//            cout << "Condition 2: true" << endl;
//        } else {
//            cout << "Condition 2: false" << endl;
//        }
//    }
//    
//    return 0;
//    
//}
