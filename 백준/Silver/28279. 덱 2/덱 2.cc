#include <iostream>
#include <deque>
#include <vector>

using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    int N;
    cin >> N;
    deque<int> dq;
    vector<int> ans;

    for (int i = 0; i < N; i++)
    {
        int command;
        cin >> command;

        switch (command)
        {
            int x;
        case 1:
            cin >> x;
            dq.push_front(x);
            break;
        case 2:
            cin >> x;
            dq.push_back(x);
            break;
        case 3:
            if (dq.empty())
                ans.push_back(-1);
            else
            {
                ans.push_back(dq.front());
                dq.pop_front();
            }
            break;
        case 4:
            if (dq.empty())
                ans.push_back(-1);
            else
            {
                ans.push_back(dq.back());
                dq.pop_back();
            }
            break;
        case 5:
            ans.push_back(dq.size());
            break;
        case 6:
            if (dq.empty())
                ans.push_back(1);
            else
                ans.push_back(0);
            break;
        case 7:
            if (dq.empty())
                ans.push_back(-1);
            else
                ans.push_back(dq.front());
            break;
        case 8:
            if (dq.empty())
                ans.push_back(-1);
            else
                ans.push_back(dq.back());
            break;

        default:
            break;
        }
    }

    for (const int &a : ans)
    {
        cout << a << "\n";
    }
}