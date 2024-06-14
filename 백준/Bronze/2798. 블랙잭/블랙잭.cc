#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;
    int num[N];
    int sum;
    vector<int> can;

    for (int i = 0; i < N; i++)
    {
        cin >> num[i];
    }

    for (int i = 0; i < N - 2; i++)
    {
        for (int j = i + 1; j < N - 1; j++)
        {
            for (int k = j + 1; k < N; k++)
            {
                sum = (num[i] + num[j] + num[k]);
                if (sum <= M)
                {
                    can.push_back(sum);
                }
            }
        }
    }
    auto max_it = max_element(can.begin(), can.end());
    int ans = *max_it;
    cout << ans;
}