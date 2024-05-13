#include <iostream>

using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;
    int bucket[N];

    for (int a = 0; a < N; a++)
    {
        bucket[a] = 0;
    }

    for (int a = 0; a < M; a++)
    {
        int i, j, k;
        cin >> i >> j >> k;
        for (int b = i - 1; b < j; b++)
        {
            bucket[b] = k;
        }
    }

    for (int c = 0; c < N; c++)
    {
        cout << bucket[c] << " ";
    }
}