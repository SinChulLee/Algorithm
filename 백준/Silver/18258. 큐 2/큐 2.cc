#include <iostream>
#include <deque>
#include <vector>

using namespace std;

int main()
{
    ios::sync_with_stdio(false); // C++ 표준 스트림의 동기화를 비활성화하여 속도를 높임
    cin.tie(nullptr);            // cin과 cout의 묶음을 해제하여 입출력 속도를 높임
    cout.tie(nullptr);

    long long N;
    cin >> N;
    deque<int> qu;
    vector<int> ans;

    for (long long i = 0; i < N; i++)
    {
        string command;
        cin >> command;
        if (command == "push")
        {
            int num;
            cin >> num;
            qu.push_back(num);
        }
        else if (command == "pop")
        {
            if (!qu.empty())
            {
                ans.push_back(qu.front());
                qu.pop_front();
            }
            else
                ans.push_back(-1);
        }
        else if (command == "size")
            ans.push_back(qu.size());
        else if (command == "empty")
            ans.push_back(qu.empty());
        else if (command == "front")
        {
            if (qu.empty())
                ans.push_back(-1);
            else
                ans.push_back(qu.front());
        }
        else
        {
            if (qu.empty())
                ans.push_back(-1);
            else
                ans.push_back(qu.back());
        }
    }

    for (const int &a : ans)
    {
        cout << a << "\n";
    }
}
