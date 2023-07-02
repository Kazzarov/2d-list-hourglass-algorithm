This code solves a programming issue seen on HackerRank :
In a 2D list(in C#) There are many "hourglasses"
Example:

if we have a 6X6 2D list:

1, 1, 1, 0, 0, 0 
0, 1, 0, 0, 0, 0 
1, 1, 1, 0, 0, 0 
0, 0, 0, 0, 0, 0 
0, 0, 25, 0, -9, 0 
0, -3, 0, 0, 0, 0 

The first Hourglass will be:

1,1,1
  1
1,1,1

find the maximum value in all of the "hourglasses" made by values in the 2D array
And return it(not the sum of all of them, but only of the biggest value of a single "hourglass")