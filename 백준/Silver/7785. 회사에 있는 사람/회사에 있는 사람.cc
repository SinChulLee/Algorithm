#include <iostream>
#include <unordered_set>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int n;
    cin >> n;
    unordered_set<string> cur_entered;

    for (int i = 0; i < n; i++)
    {
        string name, log;
        cin >> name >> log;
        if (log == "enter")
            cur_entered.insert(name);
        if (log == "leave")
            cur_entered.erase(name);
    }

    // unordered_set을 vector로 복사
    vector<string> entered_names(cur_entered.begin(), cur_entered.end());

    // 사전순의 역순으로 정렬
    sort(entered_names.begin(), entered_names.end(), greater<string>());

    // 출력
    for (const string &name : entered_names)
    {
        cout << name << "\n";
    }

    return 0;
}