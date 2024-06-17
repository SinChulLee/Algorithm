#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int N, num;
    cin >> N;
    vector<int> num_list;

    for (int i = 0; i < N; i++)
    {
        cin >> num;
        num_list.push_back(num);
    }

    for (int j = 0; j < num_list.size(); j++)
    {
        for (int k = j + 1; k < num_list.size(); k++)
        {
            if (num_list[j] > num_list[k])
            {
                int temp = num_list[j];
                num_list[j] = num_list[k];
                num_list[k] = temp;
            }
        }
    }

    for (int x = 0; x < num_list.size(); x++)
    {
        cout << num_list[x] << endl;
    }
}