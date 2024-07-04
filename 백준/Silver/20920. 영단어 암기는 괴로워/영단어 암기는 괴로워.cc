#include <iostream>
#include <unordered_map>
#include <vector>
#include <algorithm>

using namespace std;

bool compare(const pair<string, int> &a, const pair<string, int> &b)
{
    if (a.second != b.second)
    {
        return a.second > b.second; // 빈도수에 따라 내림차순 정렬
    }
    if (a.first.size() != b.first.size())
    {
        return a.first.size() > b.first.size(); // 길이에 따라 내림차순 정렬
    }
    return a.first < b.first; // 사전순으로 오름차순 정렬
}

int main()
{

    ios::sync_with_stdio(false); // C++ 표준 스트림의 동기화를 비활성화하여 속도를 높임
    cin.tie(nullptr);            // cin과 cout의 묶음을 해제하여 입출력 속도를 높임
    cout.tie(nullptr);

    int N, M;
    cin >> N >> M;
    unordered_map<string, int> word_dict;

    for (int i = 0; i < N; i++)
    {
        string word;
        cin >> word;
        if (word.size() >= M)
        {
            word_dict[word]++;
        }
    }

    vector<pair<string, int>> word_list(word_dict.begin(), word_dict.end());
    stable_sort(word_list.begin(), word_list.end(), compare);

    for (const auto &pair : word_list)
    {
        cout << pair.first << "\n";
    }

    return 0;
}
