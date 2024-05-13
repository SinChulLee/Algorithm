#include <iostream>
#include <vector>
#include <algorithm> // std::find 함수 사용을 위해 추가

using namespace std;

int main()
{
    vector<int> remain;
    int num;

    for (int i = 0; i < 10; i++)
    {
        cin >> num;
        int modValue = num % 42;

        // find 함수를 사용하여 remain 벡터 내에 modValue가 이미 존재하는지 검사
        if (find(remain.begin(), remain.end(), modValue) == remain.end())
        {
            remain.push_back(modValue); // modValue가 remain에 없으면 추가
        }
    }

    // remain 벡터에 저장된 고유 요소의 수 출력
    cout << remain.size() << endl;

    return 0;
}