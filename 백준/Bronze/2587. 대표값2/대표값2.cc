#include <iostream>

using namespace std;

int main()
{
    int num[5], sum = 0;

    for (int i = 0; i < 5; i++)
    {
        cin >> num[i];
        sum += num[i];
    }

    for (int j = 0; j < 5; j++)
    {
        for (int k = j + 1; k < 5; k++)
        {
            if (num[j] > num[k])
            {
                int temp = num[j];
                num[j] = num[k];
                num[k] = temp;
            }
        }
    }

    cout << sum / 5 << endl
         << num[2];
}