#include <iostream>
#include <set>
#include <string>

using namespace std;

int main()
{
    int N;
    set<string> username;
    int cnt = 0;
    cin >> N;

    for (int i = 0; i < N; i++)
    {
        string line;
        cin >> line;

        // ENTER이 입력될 경우 username 초기화
        if (line == "ENTER")
        {
            username.clear();
        }
        // 아닐 경우 -> username 저장 및 username이 이미 있는 경우 cnt 추가하지 않기
        else
        {
            if (username.find(line) == username.end())
            {
                username.insert(line);
                cnt += 1;
            }
        }
    }

    cout << cnt;
}