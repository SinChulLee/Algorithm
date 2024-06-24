#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int T;
    vector<int> ans;
    cin >> T;

    for (int i = 0; i < T; i++)
    {
        int A, B;
        cin >> A >> B;

        // A와 B가 같을 때
        if (A == B)
            ans.push_back(A);
        // 같지 않을 때
        else
        {
            // 최소 공배수 구하기
            if (A > B)
            {
                for (int j = 1; j <= B; j++)
                {
                    int min_value = A * j;
                    if (min_value % A == 0 && min_value % B == 0)
                    {
                        ans.push_back(min_value);
                        break;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= A; j++)
                {
                    int min_value = B * j;
                    if (min_value % A == 0 && min_value % B == 0)
                    {
                        ans.push_back(min_value);
                        break;
                    }
                }
            }
        }
    }

    for (const int &a : ans)
    {
        cout << a << "\n";
    }
}