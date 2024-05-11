#include <iostream>

using namespace std;

int main()
{
    int X, N, result = 0;

    cin >> X >> N;
    int a[N], b[N];

    for (int i = 0; i < N; i++)
    {
        cin >> a[i] >> b[i];
        result += a[i] * b[i];
    }

    if (result == X)
    {
        cout << "Yes";
    }
    else
        cout << "No";
}