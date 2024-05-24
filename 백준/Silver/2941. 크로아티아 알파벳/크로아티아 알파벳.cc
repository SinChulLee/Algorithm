#include <iostream>

using namespace std;

int count_Cro_Alpha(string word)
{
    int count = 0;
    int i = 0;
    while (i < word.size())
    {
        switch (word[i])
        {
        case 'c':
            if (word[i + 1] == '=' or word[i + 1] == '-')
            {
                i += 2; // 다음 문자 건너 뛰기
            }
            else
                i++;
            count += 1;
            break;

        case 'd':
            if (word[i + 1] == 'z' and word[i + 2] == '=')
            {
                i += 3;
            }
            else if (word[i + 1] == '-')
            {
                i += 2;
            }
            else
                i++;
            count += 1;
            break;

        case 'l':
            if (word[i + 1] == 'j')
            {
                i += 2;
            }
            else
                i++;
            count += 1;
            break;

        case 'n':
            if (word[i + 1] == 'j')
            {
                i += 2;
            }
            else
                i++;
            count += 1;
            break;

        case 's':
            if (word[i + 1] == '=')
            {
                i += 2;
            }
            else
                i++;
            count += 1;
            break;

        case 'z':
            if (word[i + 1] == '=')
            {
                i += 2;
            }
            else
                i++;
            count += 1;
            break;

        default:
            i++;
            count += 1;
            break;
        }
    }
    return count;
}

int main()
{
    string word;
    cin >> word;
    int count = count_Cro_Alpha(word);
    cout << count;
}