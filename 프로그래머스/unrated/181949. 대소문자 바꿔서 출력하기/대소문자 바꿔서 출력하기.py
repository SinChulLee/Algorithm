str = input()
result = []
for i in str:
    if i.isupper(): 
        i = i.lower()
        result.append(i)
    else:
        i = i.upper()
        result.append(i)
    
print(''.join(result))
    