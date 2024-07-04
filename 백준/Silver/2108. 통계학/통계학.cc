#include <iostream>
#include <vector>
#include <unordered_map>
#include <algorithm>
#include <cmath>

using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> num_list(N);
    double num_sum = 0; // for문에서 속도 향상을 위해 미리 초기화

    for (int i = 0; i < N; i++)
    {
        cin >> num_list[i];
        num_sum += num_list[i]; // 산술 평균을 구하기 위해 합계 계산
    }

    // 산술 평균 계산
    double mean = num_sum / N;
    if (round(mean) == -0)
        mean = 0;

    // 범위를 구하기 위해 최대값과 최소값 구하기
    auto max_it = max_element(num_list.begin(), num_list.end());
    auto min_it = min_element(num_list.begin(), num_list.end());
    int max_value = *max_it;
    int min_value = *min_it;
    int range = max_value - min_value;

    // 중앙값 계산을 위해 정렬
    sort(num_list.begin(), num_list.end());
    int median;
    if (N % 2 == 0)
    {
        median = (num_list[N / 2 - 1] + num_list[N / 2]) / 2;
    }
    else
    {
        median = num_list[N / 2];
    }

    // 최빈값 계산을 위해 빈도수 세기
    unordered_map<int, int> frequency;
    for (const auto &num : num_list)
    {
        frequency[num]++;
    }

    // 최빈값이 여러 개일 경우 두 번째로 작은 값을 출력하기 위해
    // 빈도가 가장 높은 값을 찾고, 같은 빈도를 가진 모든 값을 벡터에 저장
    vector<int> modes;
    int max_count = 0;
    for (const auto &pair : frequency)
    {
        if (pair.second > max_count)
        {
            max_count = pair.second;
            modes.clear();
            modes.push_back(pair.first);
        }
        else if (pair.second == max_count)
        {
            modes.push_back(pair.first);
        }
    }

    // 최빈값 벡터를 정렬하고 두 번째로 작은 값 선택
    sort(modes.begin(), modes.end());
    int mode = (modes.size() > 1) ? modes[1] : modes[0];

    // 결과 출력 부분
    cout << round(mean) << "\n"; // 산술 평균
    cout << median << "\n";      // 중앙값
    cout << mode << "\n";        // 최빈값 (여러 개일 경우 두 번째로 작은 값)
    cout << range << "\n";       // 범위

    return 0;
}