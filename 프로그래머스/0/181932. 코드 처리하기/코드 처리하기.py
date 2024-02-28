def solution(code):
    ret = ''
    mode = 0
    idx = 0
    
    for i in range(len(code)):
        if mode == 0:
            if code[i] == "1":
                mode = 1
                idx += 1
                continue
            else:
                if idx % 2 == 0:
                    ret = ret + code[i]
                    
        if mode == 1:
            if code[i] == "1":
                mode = 0
                idx += 1
                continue              
            else:
                if idx % 2 == 1:
                    ret = ret + code[i]               
        idx += 1
        
    if ret == '':
        return "EMPTY"
    return ret