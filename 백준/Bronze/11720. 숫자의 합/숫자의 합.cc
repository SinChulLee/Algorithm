#include <iostream>

using namespace std;

int main()
{
    int num, result = 0;
    cin >> num;
    char N;

    for (int i = 0; i < num; i++)
    {
        cin >> N;
        result += N;
    }

    cout << result - 48 * num;
}