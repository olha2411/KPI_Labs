import random
import copy
import numpy as np  
from graphics import plot_data
              
def buble_sort(numbers):   
    n = len(numbers)  #кількість елементів масиву
    i = 0             #лічильник кількості проходів по масиву 
    count = 0         #лічильник для кількості порівнянь
    for i in range(n):
        for j in range( n-1):            #проходження по елементам 
            count += 1
            if numbers[j]>numbers[j+1]:
                numbers[j],numbers[j+1]=numbers[j+1],numbers[j] 
        
    return count
    
    
def insertion_sort(num):
    n = len(num)
    count = 0                   #лічильник для кількості порівнянь
    for i in range(1,n):        
        temp = num[i]           #змінна поточного елемента
        j = i-1                 #лічильник попередньго елемента            
        while(j>=0 and num[j]>temp):    #перебір елементів поки воеи більші за temp
            num[j+1] = num[j]           #присвоєння наступному елементу поточний
            j -= 1 
            if j>=0:
                count+=1
        num[j+1] = temp   
        count+=1
    return count


def improved_buble_sort(numbers):
    n = len(numbers)
    count = 0                 #лічильник кількості порівнянь
    for i in range(n):      #лічильник кількості проходів по масиву 
        swap = False
        for j in range(n-i-1):   #проходження по елементам
            count += 1
            if numbers[j]>numbers[j+1]:
                numbers[j],numbers[j+1]=numbers[j+1],numbers[j]         
                swap = True
        if swap == False:
            break                            
    return count
   

def generate_data(n, gen_type):
    
    if gen_type == "best":                        #генерація списку 
        A = [i+1 for i in range(n)]
        #print(A)
        return A
    elif gen_type == "worst":                     #генерація списку в зворотній послідовності
        A = [i+1 for i in reversed(range(n))]
        #print(A)
        return A
    else:                                       #генерація рандомних значень
        A = [i+1 for i in range(n)]
        random.shuffle(A)
        #print(A)
        return A
    

def main():           
    sizes = [10, 100, 1000]
    types = ["random", "best", "worst"]
    data_plot = {'random': {'bubble':{}, 'insertion':{}, 'bubble_impr':{}}, 
             'best': {'bubble':{}, 'insertion':{}, 'bubble_impr':{}},
             'worst': {'bubble':{}, 'insertion':{}, 'bubble_impr':{}}}
    for n in sizes:
        print ("\nDATA SIZE: ", n)
        for gen_type in types:
            print ("\n\tDATA TYPE:", gen_type)
            data = generate_data(n, gen_type)
            data_bubble = np.copy(data)            
            bubble_op_count = buble_sort(data_bubble)            
            print ("\tBubble sort operation count:", int(bubble_op_count))
            data_plot[gen_type]['bubble'][n] = bubble_op_count
            data_bubble_impr = np.copy(data)
            bubble_impr_op_count = improved_buble_sort(data_bubble_impr)
            print ("\tImproved bubble sort operation count:", int(bubble_impr_op_count))
            data_plot[gen_type]['bubble_impr'][n] = bubble_impr_op_count
            data_insertion = np.copy(data)
            insertion_op_count = insertion_sort(data_insertion)
            print ("\tInsertion sort operation count:", int(insertion_op_count))
            data_plot[gen_type]['insertion'][n] = insertion_op_count
        plot_data(data_plot, logarithmic=True, oneplot=False)
        
    

main()