#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int A, B, C;
    vector<string> ans;

    while (true)
    {
        cin >> A >> B >> C;

        if (A == 0 && B == 0 && C == 0)
            break;

        int max_line, min_line1, min_line2;
        // 가장 긴 변 찾기
        if (A >= B && A >= C)
        {
            max_line = A;
            min_line1 = B;
            min_line2 = C;
        }
        else if (B >= A && B >= C)
        {
            max_line = B;
            min_line1 = A;
            min_line2 = C;
        }
        else
        {
            max_line = C;
            min_line1 = A;
            min_line2 = B;
        }

        if (max_line >= min_line1 + min_line2)
        {
            ans.push_back("Invalid");
            continue;
        }

        if (A == B && A == C && B == C)
            ans.push_back("Equilateral");
        else if (A != B && A != C && B != C)
            ans.push_back("Scalene");
        else
            ans.push_back("Isosceles");
    }

    for (int i = 0; i < ans.size(); i++)
    {
        cout << ans[i] << endl;
    }
}