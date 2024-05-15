#include <iostream>
#include <algorithm>
#include <cstring>

using namespace std;

int main()
{
    int ar[30] = {3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10};
    char S[20];
    int count = 0;
    cin >> S;

    for (int i = 0; i < strlen(S); i++)
    {
        count += ar[S[i] - 'A'];
    }
    cout << count;
}