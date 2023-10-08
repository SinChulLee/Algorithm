def solution(ineq, eq, n, m):
    eq = "=" if eq == "=" else ''
    a = f"{n} {ineq}{eq} {m}"
    answer = 1 if eval(a) == True else 0
    return answer