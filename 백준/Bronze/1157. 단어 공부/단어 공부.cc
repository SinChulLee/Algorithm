#include <iostream>
#include <algorithm>

using namespace std;

// 가장 많은 count를 가진 index 찾기
int findMaxValueIndex(int arr[], int size)
{
    int MaxIndex = 0;
    for (int i = 1; i < size; i++)
    {
        if (arr[i] > arr[MaxIndex])
        {
            MaxIndex = i;
        }
    }
    return MaxIndex;
}

int countMaxValueOccurrences(int arr[], int size, int MaxValue)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == MaxValue)
        {
            count += 1;
        }
    }
    return count;
}

int main()
{
    string word;
    cin >> word;
    int word_count[26] = {0};

    for (int i = 0; i < word.size(); i++)
    {
        // 소문자일 경우
        if (int(word[i]) - 'A' > 31)
        {
            word_count[int(word[i] - 'A' - 32)] += 1;
        }
        // 대문자일 경우
        else
        {
            word_count[int(word[i] - 'A')] += 1;
        }
    }
    int MaxIndex = findMaxValueIndex(word_count, 26);
    int MaxValue = word_count[MaxIndex];
    int MaxIndexCount = countMaxValueOccurrences(word_count, 26, MaxValue);


    if (MaxIndexCount > 1) // 여러개 존재할 경우
    {
        cout << "?" << endl;
    }
    else // 하나일 경우
        cout << char(MaxIndex + 'A');
}