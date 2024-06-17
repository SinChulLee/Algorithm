#include <iostream>
#include <cstdlib>

using namespace std;
// 최대 1,000,000개
int a[1000001];

// 비교함수
int compare(const void *a, const void *b)
{
    const int *x = (int *)a;
    const int *y = (int *)b;
    if (*x > *y)
        return 1;
    else if (*x < *y)
        return -1;
    return 0;
}
int main()
{
    int n, k, count = 0;
    cin >> n;

    // 수 입력받기
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }

    // Quick Sort 알고리즘 (피벗 선택 -> 분할 -> 재귀적 정렬)
    qsort(a, n, sizeof(int), compare);

    // 출력
    for (int i = 0; i < n; i++)
    {
        cout << a[i] << '\n';
    }

    return 0;
}