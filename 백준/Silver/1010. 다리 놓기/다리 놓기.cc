#include <iostream>
using namespace std;

long long binomial_coefficient(int n, int k)
{
    long long result = 1;
    for (int i = 0; i < k; ++i)
    {
        result *= (n - i);
        result /= (i + 1);
    }

    return result;
}

int main()
{
    int T;
    cin >> T;
    int N, M;
    int ans[T];

    for (int i = 0; i < T; i++)
    {
        cin >> N >> M;
        ans[i] = binomial_coefficient(M, N);
    }

    for (int i = 0; i < T; i++)
    {
        cout << ans[i] << "\n";
    }
    return 0;
}