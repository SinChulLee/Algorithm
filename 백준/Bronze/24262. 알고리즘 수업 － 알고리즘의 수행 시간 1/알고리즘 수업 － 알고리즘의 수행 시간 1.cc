#include <iostream>

using namespace std;

int main()
{
    int n, count = 0, A;
    cin >> n;

    while (true)
    {
        A = n % 2;
        n = A;
        count += 1;
        if (n < 2)
            break;
    }
    cout << count << endl
         << 0;
}