#include <iostream>
#include <stack>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int N;
    cin >> N;
    int count = 1;
    vector<int> temp;
    stack<int> line1;
    stack<int> line2;

    // 역순으로 저장해야 함
    for (int i = 0; i < N; i++)
    {
        int num;
        cin >> num;
        temp.push_back(num);
    }

    reverse(temp.begin(), temp.end());

    for (int j = 0; j < N; j++)
    {
        line1.push(temp[j]);
    }

    while (true)
    {
        if (count == N)
        {
            cout << "Nice";
            break;
        }

        if (!line1.empty() && line1.top() == count)
        {
            line1.pop();
            count += 1;
        }
        else if (!line2.empty() && line2.top() == count)
        {
            line2.pop();
            count += 1;
        }
        else
        {
            if (line1.empty())
            {
                cout << "Sad";
                break;
            }
            line2.push(line1.top());
            line1.pop();
        }
    }
}