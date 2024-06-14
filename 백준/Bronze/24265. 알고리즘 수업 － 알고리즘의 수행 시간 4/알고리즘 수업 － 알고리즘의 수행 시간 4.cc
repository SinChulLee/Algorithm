#include <iostream>

using namespace std;

int main()
{
    long n, cnt = 0;
    cin >> n;
    for (int i = 1; i < n; i++)
    {
        cnt += i;
    }
    cout << cnt << endl
         << 2;
}