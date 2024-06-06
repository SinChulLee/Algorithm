#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int N, B;
    cin >> N >> B;
    int multiple = 0;
    string result;

    while (pow(B, multiple) <= N)
    {
        multiple += 1;
    }
    multiple -= 1;

    for (int i = multiple; i >= 0; i--)
    {
        int divisor = int(pow(B, i));
        int semi_result = N / divisor; // 몫
        N = N % divisor;               // 나머지

        // 몫 변환
        if (int(semi_result) >= 10)
            result += (semi_result + 'A' - 10);
        else
            result += char(semi_result + '0');

        multiple -= 1;
    }
    cout << result;
}