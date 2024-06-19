#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

struct info
{
    int age;
    string name;
    int cnt;
};

// 비교 함수
bool compare(const info &a, const info &b)
{
    if (a.age != b.age)
        return a.age < b.age; // 나이 기준으로 오름차순 정렬
    return a.cnt < b.cnt;     // 들어온 순서 기준으로 오름차순 정렬
}

int main()
{
    int N;
    cin >> N;
    vector<info> judge(N);

    for (int i = 0; i < N; i++)
    {
        cin >> judge[i].age >> judge[i].name;
        judge[i].cnt = i;
    }

    // std::sort를 사용하여 정렬
    sort(judge.begin(), judge.end(), compare);

    // 출력
    for (const auto &j : judge)
    {
        cout << j.age << ' ' << j.name << '\n';
    }

    return 0;
}