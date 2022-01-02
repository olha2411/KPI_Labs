
def main():     
   input_file = input("Enter the file name: ")                          #введення назви файла для відкриття
   f = open(input_file)                                                
   user_X = int(input("Enter the user number: "))                       #користувач для порівняння
   arr = f.readlines()
   del arr[0]
   arr = [[int(n) for n in x.split()]for x in arr]                      #зчитаний масив 
   A = arr[user_X - 1][1:]                                              #вподобання обраного користувача
   n1 = len(arr)    
   comparison_rating=[[0 for i in range(2)]for j in range(n1)]          #рейтинг порівнянь вподобань
   for i in range(0,n1):       
       if arr[i][1:] != A:
           B = arr[i][1:]           
           cout = MergeSortInvCount(user_preferences(A,B))              #підрахунок інверсій
           comparison_rating[i][1] = arr[i][0]
           comparison_rating[i][0] = cout           
   
   MergeSort(comparison_rating,0,len(comparison_rating)-1)              #сортування за кількістю інверсій
   
   file=open("is02_OlhaPavlushchenko_03_output.txt", "w")               #виведення в файл
   file.write(str(user_X) + '\n')    
   for i in range(len(comparison_rating)):
       if(comparison_rating[i][0] != 0 and comparison_rating[i][1] != 0):
            file.write(str(comparison_rating[i][1]) + ' ' + str(comparison_rating[i][0]) + '\n')
   file.write(str(user_X) + '\n')          
   file.close()        
   
def MergeSortInvCount(arr):                                             #MergeSort з підрахунком інверсій
    inv = 0                                                             #інверсії
    if len(arr) > 1:  
        q = len(arr)//2;                                                #середина масиву
        L = arr[:q]                                                     #перша половина масиву
        R = arr[q:]                                                     #друга половина масиву
        inv += MergeSortInvCount(L)                                     #рекурсивний виклик MergeSort для сортування першої половини
        inv += MergeSortInvCount(R)                                     #рекурсивний виклик MergeSort для сортування другої половини
        i = k = 0 
        j = 0
        while i < len(L) and j < len(R):            
                if L[i] <= R[j]:
                    arr[k] = L[i]
                    i=i+1
                    k=k+1
                else:
                    arr[k] = R[j]                   
                    j=j+1
                    inv = inv + (len(L) - i)                            
                    k=k+1

        while i < len(L):
            arr[k] = L[i]
            i += 1
            k += 1
 
        while j < len(R):
            arr[k] = R[j]
            j += 1                                   
            k += 1           
    
    return inv


def MergeSort(arr, start, end):                     #MergeSort
    if len(arr) > 1:  
        q=len(arr)//2;                              #середина масиву
        L=arr[:q]                                   #перша половина масиву
        R=arr[q:]                                   #друга половина масиву
        MergeSort(L, start, q)
        MergeSort(R, q+1, end)
        i = k = 0 
        j = 0
        while i < len(L) and j < len(R):            
                if L[i] <= R[j]:
                    arr[k]=L[i]
                    i=i+1
                    k=k+1
                else:
                    arr[k] = R[j]                   
                    j=j+1                                       
                    k=k+1

        while i < len(L):
            arr[k] = L[i]
            i += 1
            k += 1
 
        while j < len(R):
            arr[k] = R[j]
            j += 1                                   
            k += 1
                
    return arr


def user_preferences(User_X, another_User):    
    arr3=[0 for i in range(len(User_X))]
    for i in range(len(User_X)):        
            arr3[User_X[i]-1]=another_User[i]    
    return arr3


main()

