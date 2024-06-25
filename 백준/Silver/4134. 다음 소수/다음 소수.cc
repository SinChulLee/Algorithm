#include <iostream>
#include <vector>
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

// 주어진 숫자 이상인 가장 작은 소수를 찾는 함수
long long prime_num(long long a)
{
    // 입력된 수가 2보다 작으면 바로 2 반환
    if (a <= 2)
        return 2;

    // 홀수로 시작하기
    if (a % 2 == 0)
        a++;
    while (!is_prime(a))
    {
        a += 2; // 짝수는 소수가 아니므로 2씩 증가
    }
    return a;
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int T;
    cin >> T;
    vector<long long> ans;

    for (int i = 0; i < T; i++)
    {
        long long n;
        cin >> n;
        long long p = prime_num(n);
        ans.push_back(p);
    }

    for (const long long &a : ans)
    {
        cout << a << "\n";
    }

    return 0;
}