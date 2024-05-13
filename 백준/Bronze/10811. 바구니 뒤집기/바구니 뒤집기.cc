#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;
    int bucket[N];

    for (int i = 0; i < N; i++)
    {
        bucket[i] = i + 1;
    }

    for (int a = 0; a < M; a++)
    {
        int i, j;
        cin >> i >> j;
        reverse(bucket + i - 1, bucket + j);
    }

    for (int i = 0; i < N; i++)
    {
        cout << bucket[i] << " ";
    }
}