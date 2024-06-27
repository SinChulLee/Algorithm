#include <iostream>
#include <stack>
#include <vector>

using namespace std;

bool is_equal(const string line)
{
    stack<char> s;
    for (char c : line)
    {
        if (c == '(' || c == '[')
            s.push(c);
        // )일 경우
        else if (c == ')')
        {

            if (s.empty() || s.top() != '(')
                return false;
            s.pop();
        }
        // ]일 경우
        else if (c == ']')
        {

            if (s.empty() || s.top() != '[')
                return false;
            s.pop();
        }
    }
    return s.empty();
}

int main()
{
    ios::sync_with_stdio(false); // C++ 표준 스트림의 동기화를 비활성화하여 속도를 높임
    cin.tie(nullptr);            // cin과 cout의 묶음을 해제하여 입출력 속도를 높임
    cout.tie(nullptr);           // cin.tie(nullptr)와 함께 사용하여 cout의 묶음을 해제

    vector<string> lines;
    vector<string> answers;
    string input;

    while (true)
    {
        getline(cin, input);
        if (input == ".")
            break;
        lines.push_back(input);
    }

    for (const string &line : lines)
    {
        if (is_equal(line))
            answers.push_back("yes");
        else
            answers.push_back("no");
    }

    for (const string &ans : answers)
    {
        cout << ans << "\n";
    }
    return 0;
}