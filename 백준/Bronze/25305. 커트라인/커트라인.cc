#include <iostream>

using namespace std;

int main()
{
    int N, k;
    cin >> N >> k;
    int st[N];

    for (int i = 0; i < N; i++)
    {
        cin >> st[i];
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = i + 1; j < N; j++)
        {
            if (st[i] > st[j])
            {
                int temp = st[i];
                st[i] = st[j];
                st[j] = temp;
            }
        }
    }

    cout << st[N - k];
}