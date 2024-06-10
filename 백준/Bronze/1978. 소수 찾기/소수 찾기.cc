#include <iostream>

using namespace std;

int main()
{
    int N;
    cin >> N;
    int prime_num = 0;
    int num_arr[N];
    for (int i = 0; i < N; i++)
    {
        cin >> num_arr[i];
        int count = 0;
        int div_num = 1;
        while (true)
        {
            if (div_num > num_arr[i])
                break;
            if (num_arr[i] % div_num == 0)
                count++;

            div_num++;
        }
        if (count == 2)
            prime_num += 1;
    }
    cout << prime_num;
}