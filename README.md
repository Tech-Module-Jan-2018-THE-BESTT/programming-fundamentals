﻿
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



 ### Problem 2. Rectangle Area

 ##### Write a program, which calculates a rectangle’s area, based on its width and height. 
 ##### The width and height come as floating point numbers on the console, formatted to the 2nd character after the decimal point.

| Input   | Output |
|---------|--------|
| 2 7     | 14.00  |
| 7 8     | 56.00  |
| 12.33 5 | 61.65  |

*******************************************************************************************************************

 ### Problem 3. Miles to Kilometers

 ##### Write a program, which converts miles to kilometers. Format the output to the 2nd decimal place.
 ##### Note: 1 mile == 1.60934 kilometers
 ##### Examples:


| Input   | Output |
|---------|--------|
| 60      | 96.56  |
| 1       | 1.61   |
| 52.1113 | 83.86  |
 
 
*******************************************************************************************************************

 ### Problem 4. Beverage Labels

 ##### Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per 100ml. Calculate the energy and sugar content for the given volume and print them on the console in the following format:

 * Name – as per the input

 * Volume – integer, suffixed by “ml” (e.g. “220ml”)

 * Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)

 * Sugar content – integer, suffixed by “g” (e.g. “30g”) 

 ##### Examples:

| Input                | Output                                |
|----------------------|---------------------------------------|
|Nuka-Cola             | 220ml Nuka-Cola:                      |
|220                   | 660kcal, 154g sugars                  |
|300                   |                                       |
|70                    |                                       |
|______________________|_______________________________________|
|Ice-cold Nuka-Cola    | 250ml Ice Cold Nuka-Cola:             |
|250                   | 875kcal, 162.5g sugars                |
|350                   |                                       |
|65                    |                                       |
|______________________|_______________________________________|
|Nuka-Cola Quantum     | 350ml Nuka-Cola Quantum:              |
|350                   | 2100kcal, 490g sugars                 |
|600                   |                                       |
|140                   |                                       |

*******************************************************************************************************************

 ### Problem 5. * Character Stats

 ##### Write a program, which displays information about a video game character. You will receive their name, current health, maximum health, current energy and maximum energy on separate lines. The current values will always be valid (equal or lower than their respective max values). Print them in the format as per the examples.

 ##### Examples:

| Input                | Output                                |
|----------------------|---------------------------------------|
|Mayro                 | Name: Mayro                           |
|5                     | Health: IIIIII.....I|||||||||||||||||||
|10                    | Energy: IIIIIIIIII.I                  |
|9                     |                                       |
|10                    |                                       |
|______________________|_______________________________________|
|Bauser                | Name: Bause                           |
|10                    | Health: IIIIIIIIIIII|||||||||||||||||||
|10                    | Energy: IIIIIIIIIIII                  |
|10                    |                                       |
|10                    |                                       |
|______________________|_______________________________________|
|Loogi                 | Name: Loogi                           |
|8                     | Health: IIIIIIIII............I        |
|20                    | Energy: III............I              |
|2                     |                                       |
|14                    |                                       |
|______________________|_______________________________________|
|Toad                  | Name: Toad                            |
|0                     | Health: I.....I                       |
|5                     | Energy: I..........I|||||||||||||||||||
|0                     |                                       |
|10                    |                                       |


 #### Hints
    * You can print a character multiple times, using new string(character, count).

