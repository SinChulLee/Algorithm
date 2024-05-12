#include <iostream>

using namespace std;

int main()
{
    int num[9];
    int max, count;

    for (int i = 0; i < 9; i++)
    {
        cin >> num[i];
        if (i == 0)
        {
            max = num[i];
            count = 1;
        }

        if (i > 0)
        {
            if (num[i] > max)
            {
                max = num[i];
                count = i + 1;
            }
        }
    }
    cout << max << endl
         << count;
}