#include <iostream>
#include <vector>
#include <unordered_set>

using namespace std;

bool IsGroupWord(string word)
{
    unordered_set<char> seen;
    char prev = '\0';

    for (char ch : word)
    {
        if (ch != prev)
        {
            if (seen.find(ch) != seen.end())
            {
                return false; // 이미 등장했던 문자가 연속하지 않게 다시 등장한 경우
            }
            seen.insert(ch);
            prev = ch;
        }
    }
    return true; // 모든 문자가 조건을 만족하면 그룹 단어
}

int main()
{
    vector<string> wordlist;
    int word_count;
    cin >> word_count;

    for (int i = 0; i < word_count; i++)
    {
        string word;
        cin >> word;
        wordlist.push_back(word);
    }

    int group_word_count = 0;
    for (const string &word : wordlist)
    {
        if (IsGroupWord(word))
        {
            group_word_count++;
        }
    }

    cout << group_word_count;
}