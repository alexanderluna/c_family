//// Arrays and functions
//#include <iostream>
//using namespace std;
//
//void show1(const int nElements, string txts[]) {
//    //    Print size of text, loses information about array
//    //    Prints size of a string (8)
//    //    cout << sizeof(txts) << endl;
//    for(int i = 0; i < nElements; i++) {
//        cout << txts[i] << endl;
//    }
//}
//
//void show2(const int nElements, string *txts) {
//    for(int i = 0; i < nElements; i++) {
//        cout << txts[i] << endl;
//    }
//}
//
//void show3(string (&txts)[3]) {
//    for(int i = 0; i < sizeof(txts)/sizeof(string); i++) {
//        cout << txts[i] << endl;
//    }
//}
//
//// allocate memory
//char *getMemory() {
//    char *pMemory = new char[100];
//    cout << "Created 100 characters" << endl;
//    return pMemory;
//}
//
//// free up memory
//void freeMemory(char *pMemory) {
//    delete [] pMemory;
//    cout << "Deleted 100 characters" << endl;
//}
//
//
//int main(){
//    
//    string texts[] = {"Apple", "Peach", "Banana"};
//    cout << sizeof(texts) << endl;
//    
//    cout << "\nCall Show 1" << endl;
//    show1(3, texts);
//    
//    cout << "\nCall Show 2" << endl;
//    show2(3, texts);
//    
//    cout << "\nCall Show 3" << endl;
//    show3(texts);
//    
//    cout << "\nCall getMemory() and freeMemory()" << endl;
//    char *pMemory = getMemory();
//    freeMemory(pMemory);
//}
