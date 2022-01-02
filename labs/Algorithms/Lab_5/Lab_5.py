import random
import math

def main():
    print ("Enter the digit number: ")
    d = int(input())                                #кількість розрядів
    p = pow(10,d-1)    
    r = pow(10,(d))
    n = 7    
    A = [random.randint(p,r) for i in range(n)]      #масив чисел    
    print (A)          
    RadixSort(A,d)
    print ("Sorted: ", A)
    

def CountingSort(A,k):
    C = [0 for i in range(10)]                  #додатковий масив для зберігання кількості елементів 
    B = [0 for i in range(len(A))]              #масив відсортованих елементів    
    
    for j in range(len(A)):                  
        C[int((A[j]/k)%10)] += 1               #кількість кожного з елементів з даним значенням розряду   
     
    for i in range (1,10):                      #визначаємо індекси елементів масива, на які вони мають стати у відсоротованому масиві      
        C[i] += C[i-1]     
      
    for j in range (len(A)-1,-1,-1):  
        B[C[int((A[j]/k)%10)]-1] = A[j]             #поміщення значень в вихідний масив
        C[int((A[j]/k)%10)] -=  1                   #зменшуємо кількість вхідних елементів на 1;
                                                    #оскільки може бути ще такий елемент і тоді він стане попереду
               
    for p in range(len(B)):
        A[p] = B[p]
    

def RadixSort(A,d):
    digitNumber = 1                               #розряд числа (від молодшого до старшого)
    for i in range(d):                          #проходи по розрядам
        CountingSort(A,digitNumber)
        digitNumber *= 10                       #перехід на наступний розряд
    return A

main()


