
 # 1. Exercises: C# Intro and Basic Syntax 
###### [SoftUni Link to the solutions](https://judge.softuni.bg/Contests/577)

******************************************************************************************************************* 

 ### Problem 1. Debit Card Number 

 ##### Write a program, which receives 4 integers on the console and prints them in 4-digit debit card format.
 ##### See the examples below for the appropriate formatting.

| Input          |  Output             |
|----------------|---------------------|
| 12             | 0012 0433 0001 5331 |
| 433            |                     |
| 1              |                     |
| 5331           |                     |
|________________|_____________________|
| 9182           | 9182 4221 0012 0003 |
| 4221           |                     |
| 12             |                     |
| 3              |                     |
|________________|_____________________|
| 812            | 0812 0321 0123 0022 |
| 321            |                     |
| 123            |                     |
| 22             |                     |
*******************************************************************************************************************
    Problem 2. Miles to Kilometers
Write a program, which converts miles to kilometers. Format the output to the 2nd decimal place.
Note: 1 mile == 1.60934 kilometers
Examples
Input      60
Output     96.56

Input      1 
Output     1.61

Input      52.1113
Output     83.86   








    Problem 5. * Character Stats
Write a program, which displays information about a video game character. You will receive their name, current health, maximum health, current energy and maximum energy on separate lines. The current values will always be valid (equal or lower than their respective max values). Print them in the format as per the examples.
Examples


Input: 
Mayro
5
10
9
10

Output:
Name: Mayro
Health: ||||||.....|
Energy: ||||||||||.|

Input:
Bauser
10
10
10
10
Output:
Name: Bauser
Health: ||||||||||||
Energy: ||||||||||||


Input:
Loogi
8
20
2
14
Output:
Name: Loogi
Health: |||||||||............|
Energy: |||............|

Input:
Toad
0
5
0
10
Output:
Name: Toad
Health: |.....|
Energy: |..........|
Hints
    • You can print a character multiple times, using new string(character, count).