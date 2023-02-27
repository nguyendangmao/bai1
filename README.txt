Bài 1: 
Given an array of integers, find the sum of its elements.

For example, if the array , , so return .

Function Description

Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.

simpleArraySum has the following parameter(s):

ar: an array of integers
Input Format
The first line contains an integer, , denoting the size of the array.
The second line contains  space-separated integers representing the array's elements.
Constraints
Output Format
Print the sum of the array's elements as a single integer.


Bài 3: 
Alice và Bob mỗi người tạo ra một vấn đề cho HackerRank. Một người đánh giá đánh giá hai thử thách, cho điểm trên thang điểm từ 1 đến 100 cho ba loại: sự rõ ràng của vấn đề , tính độc đáo và độ khó .

Xếp hạng cho thử thách của Alice là bộ ba a = (a[0], a[1], a[2]) và xếp hạng cho thử thách của Bob là bộ ba b = (b[0], b[1], b [2]) .

Nhiệm vụ là tìm các điểm so sánh của chúng bằng cách so sánh a[0] với b[0] , a[1] với b[1] và a[2] với b[2] .

Nếu a[i] > b[i] , thì Alice được thưởng 1 điểm.
Nếu a[i] < b[i] , thì Bob được thưởng 1 điểm.
Nếu a[i] = b[i] , thì không ai nhận được điểm.
Điểm so sánh là tổng số điểm mà một người kiếm được.

Cho trước a và b , hãy xác định các điểm so sánh tương ứng của chúng.

Ví dụ

a = [1, 2, 3]
b = [3, 2, 1]
Đối với các phần tử *0*, Bob được thưởng một điểm vì a[0] .
Đối với các phần tử bằng nhau a[1] và b[1] , không kiếm được điểm nào.
Cuối cùng, đối với các phần tử 2 , a[2] > b[2] nên Alice nhận được một điểm.
Mảng trả về là [1, 1] với điểm của Alice đầu tiên và điểm thứ hai của Bob.




Bài 2:
In this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

Function Description

Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements.

aVeryBigSum has the following parameter(s):

int ar[n]: an array of integers .
Return

long: the sum of all array elements
Input Format

The first line of the input consists of an integer .
The next line contains  space-separated integers contained in the array.

Output Format

Return the integer sum of the elements in the array.

 
Bài 4:

Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix  is shown below:

1 2 3
4 5 6
9 8 9  
The left-to-right diagonal = . The right to left diagonal = . Their absolute difference is .

Function description

Complete the  function in the editor below.

diagonalDifference takes the following parameter:

int arr[n][m]: an array of integers
Return

int: the absolute diagonal difference
Input Format

The first line contains a single integer, , the number of rows and columns in the square matrix .
Each of the next  lines describes a row, , and consists of  space-separated integers .

Constraints

Output Format

Return the absolute difference between the sums of the matrix's two diagonals as a single integer.



Bài 5: 

Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Example

There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:

0.400000
0.400000
0.200000
Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe .

Constraints



Output Format

Print the following  lines, each to  decimals:

proportion of positive values
proportion of negative values
proportion of zeros.



Bài 6: 
Staircase detail

This is a staircase of size :

   #
  ##
 ###
####
Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .

Function Description

Complete the staircase function in the editor below.

staircase has the following parameter(s):

int n: an integer
Print

Print a staircase as described above.

Input Format

A single integer, , denoting the size of the staircase.

Constraints

 .

Output Format

Print a staircase of size  using # symbols and spaces.

Note: The last line must have  spaces in it.
Bài 7: 
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example

The minimum sum is  and the maximum sum is . The function prints

16 24
Function Description

Complete the miniMaxSum function in the editor below.

miniMaxSum has the following parameter(s):

arr: an array of  integers
Print

Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

Input Format

A single line of five space-separated integers.

Constraints


Output Format

Print two space-separated long integers denoting the respective minimum 
and maximum values that can be calculated by summing exactly four of the five integers.
 (The output can be greater than a 32 bit integer.)
Bài 8: 
You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

Example


The maximum height candles are  units high. There are  of them, so return .

Function Description

Complete the function birthdayCakeCandles in the editor below.

birthdayCakeCandles has the following parameter(s):

int candles[n]: the candle heights
Returns

int: the number of candles that are tallest
Input Format

The first line contains a single integer, , the size of .
The second line contains  space-separated integers, where each integer  describes the height of .
Bài 9:
Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Example


Return '12:01:00'.


Return '00:01:00'.

Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):

string s: a time in  hour format
Returns

string: the time in  hour format
Input Format

A single string  that represents a time in -hour clock format (i.e.:  or 
Bài 10: 