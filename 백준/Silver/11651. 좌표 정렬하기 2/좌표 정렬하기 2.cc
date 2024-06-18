#include <iostream>
#include <cstdlib>

using namespace std;

struct Pair
{
    int first;
    int second;
};

// 비교함수
int compare(const void *a, const void *b)
{
    const Pair *x = (const Pair *)a;
    const Pair *y = (const Pair *)b;

    if (x->second != y->second)
        return x->second - y->second; // 첫 번째 원소 기준으로 오름차순 정렬
    else
        return x->first - y->first; // 두 번째 원소 기준으로 오름차순 정렬
}

int main()
{
    int n;
    cin >> n;

    Pair a[n];

    // 수 입력받기
    for (int i = 0; i < n; i++)
    {
        cin >> a[i].first >> a[i].second;
    }

    // Quick Sort 알고리즘 (피벗 선택 -> 분할 -> 재귀적 정렬)
    qsort(a, n, sizeof(Pair), compare);

    // 출력
    for (int i = 0; i < n; i++)
    {
        cout << a[i].first << ' ' << a[i].second << '\n';
    }

    return 0;
}