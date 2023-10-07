def solution(n):
    answer = 'even' if n % 2 == 0 else 'odd'
    result = 0
    if answer == 'even':
        for i in range(0, n+1, 2):
            result += i ** 2
    else:
        for i in range(1, n+1, 2):
            result += i
    return result