#include <iostream>
using namespace std;

int K;              // K번째 저장되는 값을 추적하기 위한 변수
int save_count = 0; // 저장 횟수를 추적하기 위한 변수
int result = -1;    // K번째 저장되는 값을 저장할 변수, 초기값은 -1

void merge_sort(int A[], int p, int r);
void merge(int A[], int p, int q, int r);

void merge_sort(int A[], int p, int r)
{
    if (p < r)
    {
        int q = (p + r) / 2;     // q는 p와 r의 중간 지점
        merge_sort(A, p, q);     // 전반부 정렬
        merge_sort(A, q + 1, r); // 후반부 정렬
        merge(A, p, q, r);       // 병합
    }
}

// A[p..q]와 A[q+1..r]을 병합하여 A[p..r]을 오름차순 정렬된 상태로 만든다.
// A[p..q]와 A[q+1..r]은 이미 오름차순으로 정렬되어 있다.
void merge(int A[], int p, int q, int r)
{
    int n1 = q - p + 1;
    int n2 = r - q;
    int *L = new int[n1];
    int *R = new int[n2];

    for (int i = 0; i < n1; i++)
        L[i] = A[p + i];
    for (int j = 0; j < n2; j++)
        R[j] = A[q + 1 + j];

    int i = 0, j = 0, k = p;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
            A[k++] = L[i++];
        else
            A[k++] = R[j++];

        // 저장 횟수를 증가시키고 K번째 저장된 값을 확인
        save_count++;
        if (save_count == K)
            result = A[k - 1];
    }

    while (i < n1)
    {
        A[k++] = L[i++];
        save_count++;
        if (save_count == K)
            result = A[k - 1];
    }

    while (j < n2)
    {
        A[k++] = R[j++];
        save_count++;
        if (save_count == K)
            result = A[k - 1];
    }

    delete[] L;
    delete[] R;
}

int main()
{
    int N;
    cin >> N >> K;
    int *A = new int[N];
    for (int i = 0; i < N; i++)
    {
        cin >> A[i];
    }
    merge_sort(A, 0, N - 1);

    cout << result << endl;

    delete[] A;
    return 0;
}