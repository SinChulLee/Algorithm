def solution(a, b, c):
    
    # 모두 다를 때 
    if a != b and a != c and b != c:
        answer = a + b + c
    # 모두 같을 때
    elif a == b == c:
        answer = (a + b + c) * (a**2 + b**2 + c**2) * (a**3 + b**3 + c**3)
    # 나머지 경우
    # elif (a == b and b != c) or (a == c and c != b) or (b == c and c != a):
    #     answer = (a + b + c) * (a**2 + b**2 + c**2)
    else:
        answer = (a + b + c) * (a**2 + b**2 + c**2)
        
    return answer