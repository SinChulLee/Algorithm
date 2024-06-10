#include <iostream>

using namespace std;

int main()
{
    int N;
    cin >> N;
    if (N == 1)
        return 0;
    else
    {
        // 소인수 분해는 2부터 시작
        int div_num = 2;
        // 나머지 정의
        int rest_num = N;
        while (true)
        {
            if (rest_num % div_num == 0)
            {
                cout << div_num << endl;
                rest_num /= div_num;
            }
            // 1일 경우 종료
            else if (rest_num == 1)
            {
                return 0;
            }
            else
                div_num++;
        }
    }
}