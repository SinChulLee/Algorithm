#include <iostream>

using namespace std;

int main()
{
    int N, num = 1, i = 1;
    cin >> N;
    while (true)
    {
        if (num >= N)
            break;
        num += 6 * i;
        i += 1;
    }
    cout << i;
}