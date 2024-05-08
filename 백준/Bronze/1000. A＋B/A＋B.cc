#include <iostream>

using namespace std;

int main()
{
    int A = 0, B = 0, C; // A와 B를 초기화

    while (A <= 0 || B >= 10) // 조건을 명확히 수정
    {
        // cout << "A와 B를 입력하세요 (A > 0, B < 10 조건): "; // 사용자가 조건을 알 수 있도록 메시지 추가
        cin >> A >> B;
        // if (A <= 0 || B >= 10)
        // {
        //     cout << "다시 입력해주세요\n"; // 조건을 충족하지 않을 때만 에러 메시지 출력
        // }
    }

    C = A + B;
    cout << C; // 결과 출력시 메시지 추가
}