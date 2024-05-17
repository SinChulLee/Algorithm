#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <cctype> // isspace 사용을 위해 필요

using namespace std;

int main()
{
    vector<string> line;
    string word;

    for (int i = 0; i < 100; i++)
    {
        getline(cin, word);
        
        // word가 공백이 아닐 경우 
        // and [](unsigned char c){ return isspace(c); } 람다 함수는 각 문자가 공백인지 확인
        if (!word.empty() && !all_of(word.begin(), word.end(), [](unsigned char c)
                                     { return isspace(c); }))
        {
            line.push_back(word);
        }
        if (cin.eof())
        {
            break;
        }
    }

    for (int j = 0; j < line.size(); j++)
    {
        cout << line[j] << endl;
    }
}