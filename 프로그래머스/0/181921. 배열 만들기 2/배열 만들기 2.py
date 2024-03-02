def solution(l, r):
    answer = []
    a = ["0", "5"]
    
    for i in range(l, r+1):
        str_i = str(i)
        signal = True
        
        for k in str_i:
            if k not in a:
                signal = False
                
        if signal == True:
            answer.append(i)
                     
    if answer == []:
        answer.append(-1)
        
    return answer