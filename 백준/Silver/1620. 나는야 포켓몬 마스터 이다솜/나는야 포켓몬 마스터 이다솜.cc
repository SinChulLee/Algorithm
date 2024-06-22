#include <iostream>
#include <unordered_map>
#include <vector>
#include <string>

using namespace std;

bool is_number(const string &s)
{
    for (char const &c : s)
    {
        if (!isdigit(c))
            return false;
    }
    return true;
}

int main()
{
    int M, N;
    cin >> M >> N;

    vector<string> Pokemon(M);
    vector<string> ans(N);
    unordered_map<string, int> PokemonIndex;

    for (int i = 0; i < M; i++)
    {
        cin >> Pokemon[i];
        PokemonIndex[Pokemon[i]] = i + 1; // 인덱스를 1부터 시작
    }

    for (int j = 0; j < N; j++)
    {
        string Problem;
        cin >> Problem;
        if (is_number(Problem))
        {
            int index = stoi(Problem);
            // 인덱스는 1부터 시작하므로 -1
            ans[j] = Pokemon[index - 1];
        }
        else
        {
            ans[j] = to_string(PokemonIndex[Problem]);
        }
    }

    for (const string &a : ans)
    {
        cout << a << "\n";
    }
    return 0;
}