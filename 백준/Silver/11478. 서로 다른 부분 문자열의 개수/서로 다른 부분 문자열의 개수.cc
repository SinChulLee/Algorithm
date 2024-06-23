#include <iostream>
#include <unordered_set>

using namespace std;

int main()
{
    string S;
    cin >> S;
    unordered_set<string> parti;

    for (int i = 0; i < S.size(); i++)
    {
        for (int j = 0; j < S.size(); j++)
        {
            parti.insert(S.substr(i, j));
        }
    }

    cout << parti.size();
}