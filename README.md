# GROUP MEMBERS :

  #### Ghazal		  	            : 17B-081-SE(B)	
#### Hassan Ali Raza	    :	17B-082-SE(B)


## ODD EVEN SORT
### INTRODUCTION:
Odd even sort also known as brick sort is a relatively simple sorting algorithm, developed originally for use on parallel processors with local interconnections. It is a comparison sort related to bubble sort, with which it shares many characteristics.
### WORKING:
It works on operating two alternating phases, even phase and odd phase.
### EVEN PHASE:
Even-indexed items compare and exchange with their right neighbor.
### ODD PHASE:
Odd-indexed items compare and exchange with their right neighbor.
### IMPLEMENTATION
These phases compare all odd/even indexed pairs of adjacent elements in the list and, if a pair is in the wrong order the elements are switched. The next step repeats this for even/odd indexed pairs. Then it alternates between odd/even and even/odd steps until the list is sorted.
#### Step 1:
Firstly we compare odd indexed number with its right neighbor and if the first number is greater than its right number then we swap it otherwise no change. Similarly we do this in every odd phase.

 
#### Step 2:
In second step that is even phase we compare even indexed number with its right neighbor and if the first number is greater than its right then we swap it similarly we do this in each even phase.
 
We repeat these steps until we obtain the sorted list.
 
## How to run the code?
The “OddEvenSort.sln” file given in the folder can be opened in Visual studio 2013. This file contains the source code of programme which has been written and compiled in C#.
The code contains the odd even sort function in which we do all the working. In odd even sort function we use a flag variable and a temp variable and for and while loop. While loop will work until we obtain the sorted list and first inner for loop is for odd phase and second inner loop is for even phase. When we obatin the sorted list we return that array to main function. Main function contains the array of numbers that are defined and an object for the class and a loop to print the array of sorted elements that are returned from odd even sort  funtion.

