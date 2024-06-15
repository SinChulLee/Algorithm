#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> ans_list;

    for (int i = N - 1; i > 0; i--)
    {
        int sum = 0;
        string numStr = to_string(i);
        for (int j = 0; j < numStr.size(); j++)
        {
            sum += numStr[j] - '0'; // '0'의 아스키 값 빼야 자리의 실제 숫자값
        }
        if (sum + i == N)
        {
            ans_list.push_back(i);
        }
    }
    if (!ans_list.empty())
    {
        auto min_it = min_element(ans_list.begin(), ans_list.end());
        int ans = *min_it;
        cout << ans;
    }
    else
    {
        cout << 0;
    }
    return 0;
}