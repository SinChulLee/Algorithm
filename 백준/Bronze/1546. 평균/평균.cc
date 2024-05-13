#include <iostream>
#include <algorithm>
#include <iomanip> // std::setprecision과 std::fixed를 사용하기 위해 필요

using namespace std;

int main()
{
    int N;
    cin >> N;
    int score[N];
    for (int i = 0; i < N; i++)
    {
        cin >> score[i];
    }
    // 포인터를 활용한 역참조로 주소의 값을 반환
    // cout << *max_element(score, score + N);
    double high_score = *max_element(score, score + N);
    double total_new_score = 0;

    for (int j = 0; j < N; j++)
    {
        double new_score = score[j] / high_score * 100;
        total_new_score += new_score;
    }
    cout << std::fixed << std::setprecision(2) << total_new_score / N;
}