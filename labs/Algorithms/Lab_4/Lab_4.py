
def main():
   #input_file = input("Enter the file name: ")                          #введення назви файла для відкриття
   #f = open(input_file)                                                                
  # arr = f.readlines()
   #del arr[0]
   #arr = [[int(n) for n in x.split()]for x in arr]                      #масив чисел
   #n = len(arr)   
   arr = [4]
   n = len(arr) 
   #print(arr)   
   comparisons1 = QuickSort(arr,0,n-1)
   comparisons2 = MedianQuickSort(arr, 0, n-1)     
   print (arr)
  
   file=open("is02_OlhaPavlushchenko_04_output.txt", "w")               
   file.write(str(comparisons1) + ' ' + str(comparisons2))          #виведення в файл
   file.close()
   

def QuickSort(array, p, r):                                                               
    if p<r:       
        q,count1 = Partition(array,p,r)                                 #розділення
        count2 = QuickSort(array, p, q-1)                               #рекурсивно вихиваємо для  лівого підмасиву
        count3 = QuickSort(array, q+1, r)                               #рекурсивно вихиваємо для правого підмасиву
    else:
         return 0
    return count1 + count2 + count3

def Partition(array, p, r):
    count = 0
    if(len(array>1)):
        x = array[r]                                                        #опорний елемент
        i = p-1
        for j in range(p, r):
            count += 1                                                      #кількість порівнянь
            if array[j] <= x:                                               #якщо елемент менший за опорний
                i += 1
                array[i], array[j] = array[j], array[i]                     #перестановка елементів, що в лівому підмасиві елементи менші за опорний

        array[i+1],array[r] = array[r],array[i+1]                           #перестановка крайнього лівого  елемента, який більший за опорний, та опорний
    else:
        return array
    return i+1, count    


def MedianQuickSort(array, p, r): 
    count = 0
    n=len(array)                        #довжнина масиву
    j = 0    
    if p<r:
        if n >= 3:                                     #якщо розмір масиву більший рівний 3
            q, count1 = MedianPartition(array, p, r)            
            count2 = MedianQuickSort(array, p, q-1)
            count3 = MedianQuickSort(array, q+1, r)
        else:                                           #якщо розмір менший 3, порівнюємо елементи між собою
                if array[p] > array[r]:                     
                    array[p], array[r] = array[r], array[p]    
                return 1
    else:
        return 0

    return count1+count2+count3

def MedianPartition(array, p, r):                                               #визначення медіани
    m = int((p+r)/2)                                                            #середній елемент(індекс)
    if array[m] <= array[p] <= array[r] or array[r] <= array[p] <=array[m]:     #пошук середнього за значенням елементу
        array[m],array[p] =  array[p],array[m]  
    elif array[p] <= array[m] <= array[r] or array[r] <= array[m] <= array[p]:
        array[m], array[r] =  array[r],array[m]
    return Partition(array, p,r)



main()



