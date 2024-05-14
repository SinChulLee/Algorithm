#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int T;
    cin >> T;
    string S[T];

    for (int i = 0; i < T; i++)
    {
        cin >> S[i];
    }

    for (int j = 0; j < T; j++)
    {
        cout << S[j][0] << S[j][S[j].size() - 1] << endl;
    }
}