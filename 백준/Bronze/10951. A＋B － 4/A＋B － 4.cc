#include <iostream>
#include <vector>
using namespace std;

int main()
{
    int A, B;
    vector<int> answers; // 동적 배열로 사용 가능한 vector 사용

    while (true)
    {
        cin >> A >> B;
        if (cin.eof())
        {
            break;
        }
        answers.push_back(A + B); // 각 쌍의 합을 vector에 추가
    }

    for (int ans : answers)
    {
        cout << ans << endl;
    }
}