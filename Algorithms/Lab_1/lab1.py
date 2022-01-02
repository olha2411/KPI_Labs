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
    print("bubble_sort")
    bubble_sort(n,A)
    print("improved_bubble_sort")
    improved_bubble_sort(n, B)
    print("sorted list: ")   
    bubble_sorted_list(n, A)

def bubble_sort(n,numbers):      
    i=0        
    cout=0
    for i in range(n):
        for j in range( n-1):            
            cout+=1
            if (numbers[j]>numbers[j+1]):
                numbers[j],numbers[j+1]=numbers[j+1],numbers[j] 
    print(numbers) 
    print(cout) 
    
    
def improved_bubble_sort(n, numbers):
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
   

def bubble_sorted_list(n, A):         
    for i in range(n-1):
        for j in range(n-1):            
              if ((A[j]%2 !=0) and (A[j+1]%2 !=0) and (A[j]<A[j+1])) or ((A[j]%2 !=0) and (A[j+1]%2 ==0)) or\
                 ((A[j]%2 ==0) and (A[j+1]%2 ==0) and (A[j]>A[j+1])):               
                  A[j],A[j+1]=A[j+1],A[j]                                                   
    
    print(A) 

main()
