#include <iostream>

using namespace std;

int main()
{
    int N;
    cin >> N;
    long long temp = 666;
    int cnt = 1;
    string str = "";

    if (N == 1)
    {
        cout << 666;
        return 0;
    }
    else
    {
        while (true)
        {
            str = "";
            temp++;
            str += to_string(temp);

            if (str.find("666") == -1)
                continue;
            else
            {
                cnt++;
                if (cnt == N)
                {
                    cout << str;
                    break;
                }
            }
        }
    }
}