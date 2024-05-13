#include <iostream>

using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;
    int bucket[N], temp = 0;

    for (int a = 0; a < N; a++)
    {
        bucket[a] = a + 1;
    }

    for (int b = 0; b < M; b++)
    {
        int i, j;
        cin >> i >> j;
        temp = bucket[i - 1];
        bucket[i - 1] = bucket[j - 1];
        bucket[j - 1] = temp;
    }

    for (int c = 0; c < N; c++)
    {
        cout << bucket[c] << " ";
    }
}