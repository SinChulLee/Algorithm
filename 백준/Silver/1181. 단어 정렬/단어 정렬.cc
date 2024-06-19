#include <iostream>
#include <set>
#include <vector>
#include <algorithm>

using namespace std;

// 단어 길이 비교 함수
bool compareLength(const string &a, const string &b)
{
    if (a.length() != b.length())
        return a.length() < b.length();
    return a < b; // 길이가 같은 경우 사전 순 정렬
}

int main()
{
    int N;
    cin >> N;
    set<string> unique_words;
    vector<string> words;

    for (int i = 0; i < N; i++)
    {
        string word;
        cin >> word;
        unique_words.insert(word); // 중복 제거
    }

    // set을 vector로 복사
    for (const auto &word : unique_words)
    {
        words.push_back(word);
    }

    // 단어 길이 순으로 정렬
    sort(words.begin(), words.end(), compareLength);

    // 정렬된 단어 출력
    for (const auto &word : words)
    {
        cout << word << "\n";
    }

    return 0;
}