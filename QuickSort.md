# Algorithm Description Document

Author: Nigel Dube

Date: 10/02/2023

## 1. Name

Quick Sort

## 2. Abstract
Quick Sort is a comparison-based sorting algorithm. It uses a divide-and-conquer approach to sort an array or list of elements by selecting a pivot element and partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot. The sub-arrays are then recursively sorted.
## 3. Methodology

**Partitioning:** The algorithm selects a pivot element from the array. There are various strategies for choosing a pivot element, such as selecting the first element, the last element, the middle element, or using a randomized approach. The choice of the pivot can impact the algorithm's efficiency. The goal is to first place the pivot in its correct position, with elements less than the pivot to its left and elements greater than the pivot to its right. This is achieved through a partitioning process.

Partitioning is performed using two pointers—one starting from the left (**leftMostGreaterPivot**) end of the array and another from the right end (**pivot**). These pointers move toward each other until they identify elements that are on the wrong side of the pivot. When such elements are found, they are swapped to correct their positions. As the partitioning process continues, the pivot element eventually reaches its correct position in the sorted array. All elements to its left are smaller, and all elements to its right are larger.

**Recursion:** After partitioning, the array is divided into two sub-arrays: elements less than the pivot on the left and elements greater than the pivot on the right. Quick Sort is applied recursively to each sub-array until the entire array is sorted.

**Combining:** As the recursion unwinds, the sorted sub-arrays are combined to produce the final sorted array.
## 4. Pseudocode

```
PARTITION(data, first, last)
    # Current pivot is at index 'last'
    leftMostGreaterPivot = first

    for index in range(first, last):
        if data[index] <= data[last]:
            data[leftMostGreaterPivot], data[index] = data[index], data[leftMostGreaterPivot]
            leftMostGreaterPivot += 1

    data[leftMostGreaterPivot], data[last] = data[last], data[leftMostGreaterPivot]
    return leftMostGreaterPivot

SORT(data, first, last)
    # the array is of size 1 and is sorted
    if first >= last:  
        return
    pivotIndex = Partition(data, first, last)  # PivotIndex is sorted
    Sort(data, first, pivotIndex - 1)
    Sort(data, pivotIndex + 1, last)

```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

**Inputs**:

data: unsorted array.

first: The starting index of the array or sub-array.

last: The ending index of the array.

**Outputs**:

sorted Array


## 6. Analysis Results

* Worst Case: $O(n^2)$

* Best Case: $\Omega(n \log n)$

