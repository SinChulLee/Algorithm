#include <iostream>

using namespace std;

int main()
{
    int A, B;
    cin >> A >> B;

    int units = B % 10;       // 일의 자리
    int tens = (B / 10) % 10; // 십의 자리
    int hundreds = B / 100;   // 백의 자리

    cout << A * units << endl;
    cout << A * tens << endl;
    cout << A * hundreds << endl;
    cout << A * B;
}