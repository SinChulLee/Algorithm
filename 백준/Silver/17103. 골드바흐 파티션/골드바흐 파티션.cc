#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

// 에라토스테네스의 체를 사용하여 n까지의 소수를 구하는 함수
vector<bool> sieve(int n)
{
    vector<bool> is_prime(n + 1, true);
    is_prime[0] = is_prime[1] = false;

    for (int i = 2; i * i <= n; i++)
    {
        if (is_prime[i])
        {
            for (int j = i * i; j <= n; j += i)
            {
                is_prime[j] = false;
            }
        }
    }

    return is_prime;
}

// 골드바흐의 파티션을 구하는 함수
int goldbach_partition_count(int num, const vector<bool> &is_prime)
{
    int count = 0;

    for (int i = 2; i <= num / 2; i++)
    {
        if (is_prime[i] && is_prime[num - i])
        {
            count++;
        }
    }

    return count;
}

int main()
{
    int T;
    cin >> T;

    vector<int> inputs(T);
    int max_input = 0;

    // 입력을 받으면서 최대값을 찾음
    for (int i = 0; i < T; i++)
    {
        cin >> inputs[i];
        if (inputs[i] > max_input)
        {
            max_input = inputs[i];
        }
    }

    // 최대값까지의 소수를 구함
    vector<bool> is_prime = sieve(max_input);

    // 각 입력에 대해 골드바흐의 파티션 개수를 구함
    for (int i = 0; i < T; i++)
    {
        int num = inputs[i];
        if (num % 2 != 0 || num < 4)
        {
            cout << "0\n";
            continue;
        }

        int partition_count = goldbach_partition_count(num, is_prime);
        cout << partition_count << "\n";
    }

    return 0;
}
