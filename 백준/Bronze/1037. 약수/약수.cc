#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
    int N;
    cin >> N;
    int num;
    vector<int> divisor;

    for (int i = 0; i < N; i++)
    {
        cin >> num;
        divisor.push_back(num);
    }

    // 약수가 한 개인 경우
    if (divisor.size() == 1)
    {
        cout << pow(divisor[0], 2);
        return 0;
    }

    // 최소 공배수를 구하기 때문에 가장 큰 값과 가장 작은 값 찾기
    auto max_it = max_element(divisor.begin(), divisor.end());
    auto min_it = min_element(divisor.begin(), divisor.end());
    int max_divisor = *max_it;
    int min_divisor = *min_it;
    long long result = max_divisor * min_divisor;
    cout << result;
}