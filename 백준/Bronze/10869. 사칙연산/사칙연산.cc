#include <iostream>

using namespace std;

int main()
{
    int A = 0, B = 0;

    while (A < 1 || B > 10000)
    {
        cin >> A >> B;
    }

    cout << A + B << endl;
    cout << A - B << endl;
    cout << A * B << endl;
    cout << A / B << endl;
    cout << A % B;
}