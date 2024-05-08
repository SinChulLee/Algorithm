#include <iostream>
#include <iomanip> // setprecision을 사용하기 위해 필요

using namespace std;

int main()
{
    double A = 0, B = 0, C;

    while (A <= 0 || B >= 10 && B == 0)
    {
        cin >> A >> B;
    }

    C = A / B;

    cout << fixed << setprecision(9); // 소수점 아래 9자리까지 고정하여 표현
    cout << C;
}