def solution(n):
    answer = [n]
    
    while True:
        if n == 1:
            break
        elif n % 2 == 0:
            n /= 2
            answer.append(n)
        else:
            n = 3 * n + 1
            answer.append(n)
            
    return answer