#include <iostream>
#include <algorithm> // gcd 함수 사용을 위해 추가

using namespace std;

// 최대 공약수를 구하는 함수
int gcd(int a, int b)
{
    return b == 0 ? a : gcd(b, a % b);
}

// 분수를 나타내는 구조체
struct Fraction
{
    int numerator;
    int denominator;

    // 결과를 출력하는 함수
    void print() const
    {
        cout << numerator << " " << denominator << endl;
    }

    // 분수를 기약 분수로 만드는 함수
    void reduce()
    {
        int g = gcd(numerator, denominator);
        numerator /= g;
        denominator /= g;
    }
};

// 두 분수를 더하는 함수
Fraction addFractions(const Fraction &f1, const Fraction &f2)
{
    // 분모의 최소 공배수 구하기
    int lcm_denominator = f1.denominator * (f2.denominator / gcd(f1.denominator, f2.denominator));

    // 새로운 분자 계산
    int numerator_sum = f1.numerator * (lcm_denominator / f1.denominator) + f2.numerator * (lcm_denominator / f2.denominator);

    // 결과 분수
    Fraction result = {numerator_sum, lcm_denominator};

    // 결과 분수를 기약 분수로 만들기
    result.reduce();

    return result;
}

int main()
{
    Fraction f1, f2;

    // 첫 번째 분수 입력
    cin >> f1.numerator >> f1.denominator;

    // 두 번째 분수 입력
    cin >> f2.numerator >> f2.denominator;

    // 두 분수를 더하기
    Fraction result = addFractions(f1, f2);

    // 결과 출력
    // result.print();
    cout << result.numerator << " " << result.denominator;

    return 0;
}