def solution(arr):
    stk = []
    i = 0
    while True:
        if i >= len(arr):
            break
        else:
            if stk == []:
                stk.append(arr[i])
                i += 1
                print(stk)
            elif stk != [] and stk[-1] < arr[i]:
                stk.append(arr[i])
                i += 1
            else:
                stk.remove(stk[-1])
            
    return stk