#include <iostream>

using namespace std;

int facto_cal(const int num)
{
    int ans = 1;
    for (int i = num; i > 0; i--)
    {
        ans = ans * i;
    }
    return ans;
}

int main()
{
    int N, K;
    cin >> N >> K;
    int final_result;

    int denominator = facto_cal(N);
    int numerator = facto_cal(K) * facto_cal(N - K);
    final_result = denominator / numerator;
    cout << final_result;
}