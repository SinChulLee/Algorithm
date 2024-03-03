def solution(number):
    answer = 0
    str_num = str(number)
    hap = 0
    
    for i in range(len(str_num)):
        hap += int(str_num[i])
    
    answer = hap % 9
    
    return answer