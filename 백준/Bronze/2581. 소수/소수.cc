#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int M, N, total_sum = 0;
    cin >> M >> N;
    vector<int> prime_num;

    for (M; M <= N; M++)
    {
        int div_num = 1, count = 0;
        while (true)
        {
            if (div_num > M || count > 2)
                break;
            if (M % div_num == 0)
                count++;
            div_num++;
        }

        if (count == 2)
        {
            prime_num.push_back(M);
            total_sum += M;
        }
    }
    if (prime_num.empty())
        cout << -1;
    else
    {
        cout << total_sum << endl;
        auto min_it = min_element(prime_num.begin(), prime_num.end());
        int min_value = *min_it;
        cout << min_value;
    }
}