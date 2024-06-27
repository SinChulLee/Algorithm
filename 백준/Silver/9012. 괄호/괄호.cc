#include <iostream>
#include <stack>
#include <vector>

using namespace std;

bool isVaild_VPS(const string P)
{
    stack<char> s;
    for (char c : P)
    {
        if (c == '(')
            s.push(c);
        else if (c == ')')
        {
            if (s.empty() || s.top() != '(')
                return false;
            s.pop();
        }
    }
    return s.empty();
}

int main()
{
    int T;
    cin >> T;
    vector<string> VPS;
    for (int i = 0; i < T; i++)
    {
        string PS;
        cin >> PS;
        if (isVaild_VPS(PS))
            VPS.push_back("YES");
        else
            VPS.push_back("NO");
    }

    for (const string &v : VPS)
    {
        cout << v << "\n";
    }
}