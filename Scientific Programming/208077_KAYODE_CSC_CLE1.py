#NAME: KAYODE PETER TEMITOPE
#MATRIC NUMBER: 208077
#DEPARTMENT: COMPUTER SCIENCE (200 Level)

                    #Class Exercise Solution
                    #DOUBLE FACTORIAL

def fact(n):
    f = 1
    for i in range(n, 0, -2):
        f = f*i
    return f


x = 8    #by assigning any value(either even or odd values) to x and running it, it gives the double factorial of the number
result = fact(x)
print(result)