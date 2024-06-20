#include <iostream>
#include <unordered_set>
#include <vector>

using namespace std;

int main()
{
    int N, M;
    cin >> N;
    unordered_set<int> card_onhand;
    for (int i = 0; i < N; i++)
    {
        int card;
        cin >> card;
        card_onhand.insert(card);
    }
    cin >> M;
    int card_exist[M];
    for (int j = 0; j < M; j++)
    {
        int num;
        cin >> num;
        if (card_onhand.find(num) == card_onhand.end())
            card_exist[j] = 0;
        else
            card_exist[j] = 1;
    }

    for (int k = 0; k < M; k++)
    {
        cout << card_exist[k] << " ";
    }
}