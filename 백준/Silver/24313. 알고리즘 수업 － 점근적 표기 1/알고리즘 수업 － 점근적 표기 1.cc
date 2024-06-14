#include <iostream>

using namespace std;

int main()
{
    int a1, a2, c, n;
    int ans = 1;
    cin >> a1 >> a2 >> c >> n;

    while (true)
    {
        if (n == 101)
            break;

        if (a1 * n + a2 > c * n)
        {
            ans = 0;
            break;
        }
        n += 1;
    }
    cout << ans;
}