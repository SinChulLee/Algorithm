#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    long long A = 0, B = 0, C = 0;
    long long num = pow(10, 12);

    while (((A < 1 || A > num) || (B < 1 || B > num) || (C < 1 || C > num)))
    {
        cin >> A >> B >> C;
    }

    cout << A + B + C;
}