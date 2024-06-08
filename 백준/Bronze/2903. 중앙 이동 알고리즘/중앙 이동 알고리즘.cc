#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int N, ans = 2;
    cin >> N;
    while (N--)
    {
        ans += (ans - 1);
    }
    ans = pow(ans, 2);
    cout << ans;
}