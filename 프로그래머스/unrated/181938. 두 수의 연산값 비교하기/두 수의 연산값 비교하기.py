def solution(a, b):
    re = str(a) + str(b)
    answer = int(re) if int(re) >= 2 * a * b else 2*a*b 
    return answer