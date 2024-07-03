#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int N;
    cin >> N;
    // 결과값, 팩토리얼은 곱셈으로 구현되기에 1로 초기화
    int ans = 1;
    for (int i = N; i > 0; i--)
    {
        ans = ans * i;
    }

    cout << ans;
}