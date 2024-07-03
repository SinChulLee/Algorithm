#include <iostream>
#include <set>

using namespace std;

int main()
{
    int N;
    cin >> N;
    int cnt = 1; // 총총이는 이미 춤을 추고 있으므로 1부터 시작
    set<string> dancing_people;
    string A[N], B[N];
    dancing_people.insert("ChongChong");

    for (int i = 0; i < N; i++)
    {
        cin >> A[i] >> B[i];
        if (dancing_people.find(A[i]) != dancing_people.end() && dancing_people.find(B[i]) == dancing_people.end())
        {
            dancing_people.insert(B[i]);
            cnt += 1;
        }
        else if (dancing_people.find(B[i]) != dancing_people.end() && dancing_people.find(A[i]) == dancing_people.end())
        {
            dancing_people.insert(A[i]);
            cnt += 1;
        }
    }

    cout << cnt;
}