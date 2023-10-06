def solution(a, b):
    answer1 = str(a) + str(b)
    answer2 = str(b) + str(a)
    answer = answer1 if answer1 >= answer2 else answer2
    return int(answer)