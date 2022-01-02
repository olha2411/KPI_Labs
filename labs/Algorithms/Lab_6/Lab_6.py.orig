

def main():    
    H_low =[]
    H_high = []    
    Input=[]
    input("input_10.txt",Input)
    sort_input(Input,"is02_OlhaPavlushchenko_06_output.txt",H_low,H_high)  #запис у файл


def input(file_name,Input): # зчитування файлу
   file = open(file_name, 'r')
   k = 0
   lines = file.readlines()
   for str in lines:
       if k == 0:
           n = int(str)
           k = 1
       else:
           Input.append(int(str))
   file.close()

def sort_input(A, filename,H_low,H_high):
   file = open(filename, 'w')
   n = len(A)
   for i in range(0, n):
       AddElement(A[i],H_low,H_high)
       file.write(get_median(H_low,H_high))
   file.close()

def Left(i):            #визначення індексу лівого нащадка елементу
    return i*2   

def Right(i):           #визначення індексу правого нащадка елементу
    return i*2 + 1


def MaxHeapify(A,i):
    p = Left(i)-1           
    q = Right(i)-1          
    if p < len(A) and A[p] > A[i-1]:      #якщо введений індекс лежить у межах піраміди і значення більше, ніж вхідне
        largest = p
    else:
        largest = i-1
    if q < len(A) and A[q]>A[largest]:    #якщо введений індекс лежить у межах піраміди і значення більше, ніж попереднє
        largest = q
    if largest != i-1:                  #якщо індекс не дорівнює вхідному
        A[i-1],A[largest] = A[largest],A[i-1]   #зміна елементів місцями
        MaxHeapify(A, largest)                  #повторний виклик процедури


def HeapExtractMax(A):    
    if len(A) > 0:     #якщо піраміда не порожня
       max = A[0]       #визначення найбільшого елементу 
    A.pop(0)          #видалення найбільшого елементу  
    return max


def MinHeapify(A,i):
    p = Left(i)-1
    q = Right(i)-1
    if p < len(A) and A[p] < A[i-1]:
        lowest = p
    else:
        lowest = i-1
    if q < len(A) and A[q] < A[lowest]:
        lowest = q
    if lowest != i-1:
       A[i-1],A[lowest] = A[lowest],A[i-1]       
       MinHeapify(A, lowest)


def HeapExtractMin(A):   
    if len(A) > 0:
       min = A[0]       #мінімальне значення з неспадної піраміди
    A.pop(0)            #видалення найменшого елементу
    return min



def BuildMaxHeap(A):
   heap_size = len(A)
   for i in range(heap_size//2, 0, -1):
       MaxHeapify(A, i)

def BuildMinHeap(A):
   heap_size = len(A)
   for i in range(heap_size//2, 0, -1):
       MinHeapify(A, i)

def AddElement(x,H_low,H_high):
   if (len(H_low) > 0 and H_low[0] > x) or len(H_low) == 0:
       H_low.append(x)
       BuildMaxHeap(H_low)
   else:
       H_high.append(x)
       BuildMinHeap(H_high)
   if len(H_low) - len(H_high) == 2:    #якщо розмір H_low став більшим на 2 за розмір H_high
       max = HeapExtractMax(H_low)      #взяти найбільний з H_low елемент 
       H_high.insert(0, max)            #вставити в іншу піраміду
       BuildMaxHeap(H_low)
       BuildMinHeap(H_high)
   else:
       if len(H_high) - len(H_low) == 2:        #якщо розмір H_high став більшим на 2 за розмір H_low
           min = HeapExtractMax(H_low)          #взяти найменший з H_high елемент 
           H_low.insert(0, min)                 #вставити в іншу піраміду
           BuildMinHeap(H_high)
           BuildMaxHeap(H_low)

def get_median(H_low,H_high):
   if (len(H_low) - len(H_high)) % 2 == 0:     #якщо загальна кількість елементів парна
       result = str(H_low[0]) + " " + str(H_high[0])  #повернути найбільший з H_low і найменший з H_high
   else:
       if len(H_low) > len(H_high):  #якщо елементів в H_low більше, ніж у H_high
           result = str(H_low[0])       #повернути найбільший елемент з цієї піраміди
       else:
           result = str(H_high[0])      #повернути найменший елемент з цієї піраміди
   result += '\n'
   return result


main()