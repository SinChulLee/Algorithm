#include <iostream>
#include <climits>

using namespace std;

int main()
{
    int N;
    cin >> N;

    int minCount = INT_MAX;

    for (int i = 0; i <= N / 5; i++) // i: 5kg 봉지의 수
    {
        for (int j = 0; j <= N / 3; j++) // j: 3kg 봉지의 수
        {
            if (5 * i + 3 * j == N)
            {
                int count = i + j;
                if (count < minCount)
                {
                    minCount = count;
                }
            }
        }
    }

    if (minCount == INT_MAX)
    {
        cout << -1;
    }
    else
    {
        cout << minCount;
    }

    return 0;
}