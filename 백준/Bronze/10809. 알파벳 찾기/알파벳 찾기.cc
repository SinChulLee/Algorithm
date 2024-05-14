#include <iostream>

using namespace std;

int main()
{
    string S;
    cin >> S;
    int al[26];

    // a ~ z -1로 초기화
    for (int i = 0; i < 26; i++)
    {
        al[i] = -1;
    }

    for (int j = 0; j < S.size(); j++)
    {
        for (int k = 0; k < 26; k++)
        {
            if ((int(S[j]) - 97) == k && al[k] == -1)
            {
                al[k] = j;
            }
        }
    }

    for (int i = 0; i < 26; i++)
    {
        cout << al[i] << " ";
    }
}