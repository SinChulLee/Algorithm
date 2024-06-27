#include <iostream>
#include <stack>

using namespace std;

int main()
{
    int K;
    cin >> K;
    stack<int> sck;
    int sum = 0;
    for (int i = 0; i < K; i++)
    {
        int num;
        cin >> num;
        if (num == 0)
        {
            if (!sck.empty())
            {
                sum -= sck.top();
                sck.pop();
            }
            else
                continue;
        }

        else
        {
            sum += num;
            sck.push(num);
        }
    }

    cout << sum;
}