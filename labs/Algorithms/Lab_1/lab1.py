import random
import copy
               
def main():
    A=[]    
    n=int(input("Enter the quantity of numbers: "))    
    A=[random.randint(1,40) for i in range(n)]
    print("unsorted list")
    print(A)    
    B=[]
    B=copy.copy(A)
    print("buble_sort")
    buble_sort(n,A)
    print("improved_buble_sort")
    improved_buble_sort(n, B)
    print("sorted list: ")   
    buble_sorted_list(n, A)

def buble_sort(n,numbers):      
    i=0        
    cout=0
    for i in range(n):
        for j in range( n-1):            
            cout+=1
            if (numbers[j]>numbers[j+1]):
                numbers[j],numbers[j+1]=numbers[j+1],numbers[j] 
    print(numbers) 
    print(cout) 
    
    
def improved_buble_sort(n, numbers):
    count=0
    for i in range(n):
        flag = False
        for j in range(n-i-1):   
            count+=1
            if (numbers[j]>numbers[j+1]):
                numbers[j],numbers[j+1]=numbers[j+1],numbers[j]         
                swap=True
        if(swap==False):
            break                                     
    
    print(numbers) 
    print(count) 
   

def buble_sorted_list(n, A):         
    for i in range(n-1):
        for j in range(n-1):            
              if ((A[j]%2 !=0) and (A[j+1]%2 !=0) and (A[j]<A[j+1])) or ((A[j]%2 !=0) and (A[j+1]%2 ==0)) or\
                 ((A[j]%2 ==0) and (A[j+1]%2 ==0) and (A[j]>A[j+1])):               
                  A[j],A[j+1]=A[j+1],A[j]                                                   
    
    print(A) 

main()
