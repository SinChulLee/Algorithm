#include <iostream>

using namespace std;

int main()
{
    int T;
    cin >> T;
    int R[T];
    string S[T];

    for (int i = 0; i < T; i++)
    {
        cin >> R[i] >> S[i];
    }

    for (int j = 0; j < T; j++)
    {
        for (int k = 0; k < S[j].size(); k++)
        {
            for (int z = 0; z < R[j]; z++)
            {
                cout << S[j][k];
            }
        }
        cout << endl;
    }
}