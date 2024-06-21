#include <iostream>
#include <unordered_set>

using namespace std;

int main()
{
    int N, M, count = 0;
    cin >> N >> M;
    unordered_set<string> S;
    for (int i = 0; i < N; i++)
    {
        string word;
        cin >> word;
        S.insert(word);
    }

    for (int j = 0; j < M; j++)
    {
        string word;
        cin >> word;
        if (S.find(word) != S.end())
            count += 1;
    }

    cout << count;
}