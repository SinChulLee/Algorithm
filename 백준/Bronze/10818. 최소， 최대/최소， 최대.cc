#include <iostream>

using namespace std;

int main()
{
    int N;
    cin >> N;
    int num[N];
    int min, max;

    for (int i = 0; i < N; i++)
    {
        cin >> num[i];
        if (i == 0)
        {
            min = num[0], max = num[0];
        }

        if (i > 0)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
            else if (num[i] > max)
            {
                max = num[i];
            }
        }
    }

    cout << min << " " << max;
}