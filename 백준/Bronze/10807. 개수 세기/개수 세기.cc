#include <iostream>

using namespace std;

int main()
{
    int N, V;
    int count = 0;

    cin >> N;
    int num[N];
    for (int i = 0; i < N; i++)
    {
        cin >> num[i];
    }

    cin >> V;

    for (int j = 0; j < N; j++)
    {
        if (num[j] == V)
        {
            count += 1;
        }
    }

    cout << count;
}