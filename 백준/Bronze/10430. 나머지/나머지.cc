#include <iostream>

using namespace std;

int main()
{
    int A, B, C;

    while (A < 2 || A > 10000 && B < 2 || B > 10000 && C < 2 || C > 10000)
    {
        cin >> A >> B >> C;
    }

    cout << (A + B) % C << endl;
    cout << ((A % C) + (B % C)) % C << endl;
    cout << (A * B) % C << endl;
    cout << ((A % C) * (B % C)) % C;
}