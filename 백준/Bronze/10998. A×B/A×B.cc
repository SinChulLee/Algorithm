#include <iostream>

using namespace std;

int main()
{
    int A = 0, B = 0, C;

    while (A <= 0 || B >= 10)
    {
        cin >> A >> B;
    }

    C = A * B;
    cout << C;
}