def solution(num_list):
    multiple = 1
    sum = 0
    
    for i in range(len(num_list)):
        multiple *= num_list[i]
        sum += num_list[i]
        
    if multiple > sum ** 2:
        answer = 0
    else:
        answer = 1
        
    return answer