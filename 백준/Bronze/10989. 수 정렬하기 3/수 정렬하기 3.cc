#include <iostream>
using namespace std;

int n[10001]; // 최대 크기가 10000인 정수 배열 선언

int main()
{
    ios::sync_with_stdio(false); // C++ 표준 입출력과 C 표준 입출력의 동기화를 끔
    cin.tie(nullptr);            // 입력 스트림과의 묶음을 해제
    cout.tie(nullptr);           // 출력 스트림과의 묶음을 해제

    int a;
    cin >> a; // 정렬할 숫자의 개수 입력

    int t;
    for (int i = 1; i <= a; i++)
    {
        cin >> t; // 정수 입력
        n[t]++;   // 입력된 정수의 개수(인덱스값)를 증가시킴
    }

    for (int i = 1; i <= 10000; i++)
    {
        while (n[i]) // n[i]가 0이 될 때까지
        {
            cout << i << "\n"; // i를 출력
            n[i]--;            // 출력한 수의 개수를 감소시킴
        }
    }
}
