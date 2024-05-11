#include <iostream>

using namespace std;

int main()
{
    int n;
    int Answer = 0;

    cin >> n;

    for (int i = 1; i <= n; i++)
    {
        Answer += i;
    }

    cout << Answer;
}