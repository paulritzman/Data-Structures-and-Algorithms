# Array Binary Search
An application which accepts an array of integers and an integer key to search for within the array.
The application utilizes a binary search algorithm to locate the index of the key from within the array.

## Challenge

Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key.
Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Solution
![ArrayBinarySearch 01](../assets/array-binary-search-images/array-binary-search-01.jpg)
![ArrayBinarySearch 02](../assets/array-binary-search-images/array-binary-search-02.jpg)

I solved this problem by using a while loop which iterated continuously so long as the "begin" index was less than or equal to the "end" index.
Each iteration through the loop checks to see if the key is equal to, greater than, or less than, the integer located at the current index
location within the array. As soon as the key and number at the current index location match, that index is returned. Otherwise, if the
key is less than or greater than the number at the current index location, the "begin" or "end" indexes are changed to effectively
split the portion of the array being search by half each iteration. If the key is not found, the "begin" or "end" index will
increment/decrement a last time, causing the "begin" index to be greater than the "end" index, and "-1" will be returned.
