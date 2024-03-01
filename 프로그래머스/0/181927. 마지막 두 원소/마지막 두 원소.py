def solution(num_list):
    answer = []
    answer = num_list
    
    A = num_list[len(num_list) - 1]
    B = num_list[len(num_list) - 2]
    
    if A > B:
        answer.append(A - B)
    else:
        answer.append(A * 2)
        
    return answer