def solution(arr, queries):
    answer = arr
    
    for i in range(len(queries)):
            temp = answer[queries[i][0]]
            answer[queries[i][0]] = answer[queries[i][1]]
            answer[queries[i][1]] = temp
            
    return answer