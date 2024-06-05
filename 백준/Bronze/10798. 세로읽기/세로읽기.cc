#include <iostream>

using namespace std;

int main()
{
    string word[5];
    int word_max_length = 0;
    for (int i = 0; i < 5; i++)
    {
        cin >> word[i];
        if (word[i].length() > word_max_length)
            word_max_length = word[i].length();
    }

    for (int i = 0; i < word_max_length; i++)
    {
        for (int j = 0; j < 5; j++)
            if (i < word[j].length())
                cout << word[j][i];
    }
}