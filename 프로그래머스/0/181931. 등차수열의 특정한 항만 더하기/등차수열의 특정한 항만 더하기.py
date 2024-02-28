def solution(a, d, included):
    answer = 0
    cur_a = a
    
    for i in range(len(included)):
        if included[i] == True:
            answer += cur_a            
        cur_a += d       
        
    return answer