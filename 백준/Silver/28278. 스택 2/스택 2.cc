#include <iostream>
#include <stack>
#include <vector>

using namespace std;

int main()
{
    int N;
    cin >> N;
    stack<int> sck;
    vector<int> ans;
    for (int i = 0; i < N; i++)
    {
        int command;
        cin >> command;
        switch (command)
        {
        case 1:
            int X;
            cin >> X;
            sck.push(X);
            break;
        case 2:
            if (sck.empty())
            {
                ans.push_back(-1);
                break;
            }
            else
            {
                ans.push_back(sck.top());
                sck.pop();
                break;
            }
        case 3:
            ans.push_back(sck.size());
            break;
        case 4:
            if (sck.empty())
            {
                ans.push_back(1);
                break;
            }
            else
            {
                ans.push_back(0);
                break;
            }
        case 5:
            if (sck.empty())
            {
                ans.push_back(-1);
                break;
            }
            else
            {
                ans.push_back(sck.top());
                break;
            }

        default:
            break;
        }
    }

    for (const int &a : ans)
    {
        cout << a << "\n";
    }
}