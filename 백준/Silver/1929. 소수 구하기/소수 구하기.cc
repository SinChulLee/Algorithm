#include <iostream>
#include <cmath>

using namespace std;

// 소수 판별 함수
bool is_prime(long long num)
{
    if (num <= 1)
        return false;
    if (num <= 3)
        return true;
    if (num % 2 == 0 || num % 3 == 0)
        return false;
    for (long long i = 5; i * i <= num; i += 6)
    {
        if (num % i == 0 || num % (i + 2) == 0)
            return false;
    }
    return true;
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    long long M, N;
    cin >> M >> N;

    for (long long i = M; i <= N; i++) // 상한 N을 포함
    {
        if (is_prime(i))
        {
            cout << i << "\n";
        }
    }

    return 0;
}