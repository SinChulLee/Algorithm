#include <iostream>
#include <algorithm>

using namespace std;

int gcd(int a, int b)
{
    return b == 0 ? a : gcd(b, a % b);
}

int main()
{
    int N;
    cin >> N;
    int tree[N];
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        cin >> tree[i];
    }
    int min_value = tree[1] - tree[0];

    for (int j = 2; j < N; j++)
    {
        int g = gcd(min_value, tree[j] - tree[j - 1]);
        if (g < min_value)
            min_value = g;
    }

    for (int j = 1; j < N; j++)
    {
        if (tree[j] - tree[j - 1] > min_value)
        {
            count += ((tree[j] - tree[j - 1]) / min_value - 1);
        }
    }

    cout << count;
}