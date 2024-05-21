#include <iostream>

using namespace std;

void plus_star(int i, int N)
{
    for (int j = N - 1; j > i; j--)
    {
        cout << ' ';
    }

    for (int k = 0; k < (i * 2) + 1; k++)
    {
        cout << "*";
    }

    cout << endl;
}

void minus_star(int i, int N)
{
    for (int j = N; j <= i; j++)
    {
        cout << ' ';
    }

    for (int k = 0; k < (2 * (2 * N - 1 - i)) - 1; k++)
    {
        cout << "*";
    }

    cout << endl;
}

int main()
{
    int N;
    cin >> N;

    for (int i = 0; i < (2 * N) - 1; i++)
    {
        if (i < N)
        {
            plus_star(i, N);
        }
        else
        {
            minus_star(i, N);
        }
    }
    return 0;
}
