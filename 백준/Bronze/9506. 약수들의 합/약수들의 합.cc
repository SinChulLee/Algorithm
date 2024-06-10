#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int n, div_num = 1;
    vector<int> num_arr;

    while (true)
    {
        cin >> n;
        if (n == -1)
        {
            break;
        }
        num_arr.push_back(n);
    }
    vector<int> num_divisor_arr[num_arr.size()];

    for (int i = 0; i < num_arr.size(); i++)
    {
        while (true)
        {
            // num_arr[i]가 1일 경우
            if (num_arr[i] == 1)
            {
                num_divisor_arr[i].push_back(div_num);
            }
            // 나누는 수가 num_arr[i]와 같을 경우
            // 나누는 수를 1로 초기화 미
            if (div_num == num_arr[i])
            {
                div_num = 1;
                break;
            }

            if (num_arr[i] % div_num == 0)
            {
                num_divisor_arr[i].push_back(div_num);
            }
            div_num++;
        }
    }

    for (int j = 0; j < num_arr.size(); j++)
    {
        int total_sum = 0;
        for (int k = 0; k < num_divisor_arr[j].size(); k++)
        {
            total_sum += num_divisor_arr[j][k];
        }
        if (num_arr[j] == total_sum)
        {
            cout << num_arr[j] << " = ";
            for (int k = 0; k < num_divisor_arr[j].size(); k++)
            {
                // 마지막에는 + 빼기
                if (k == num_divisor_arr[j].size() - 1)
                {
                    cout << num_divisor_arr[j][k] << endl;
                    break;
                }
                cout << num_divisor_arr[j][k] << " + ";
            }
        }
        else
        {
            cout << num_arr[j] << " is NOT perfect." << endl;
        }
    }
}