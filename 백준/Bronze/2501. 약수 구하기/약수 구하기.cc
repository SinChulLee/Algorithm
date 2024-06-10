#include <iostream>

using namespace std;

int main()
{
    int N, K, divisor = 1, count = 0;
    cin >> N >> K;

    while (true)
    {
        if (N % divisor == 0)
        {
            count++;
            if (count == K)
            {
                cout << divisor;
                break;
            }
        }
        divisor += 1;
        if (divisor > N)
        {
            cout << 0;
            break;
        }
    }
}