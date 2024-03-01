def solution(arr, queries):
    answer = []
    can_answer = []
    
    for i in range(len(queries)):

        for j in range(queries[i][0], queries[i][1]+1):
            if arr[j] > queries[i][2]:
                can_answer.append(arr[j])
   
        if can_answer != []:
            answer.append(min(can_answer))

        else:
            answer.append(-1)
            
        can_answer = []
                
    return answer