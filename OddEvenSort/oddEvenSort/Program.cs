﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSort
{
    class Program
    {
        public int[] OddEven(int[] array)
        {
           //Initialization
            int Flag = 0;
            int temp = 0;

            //while flag =0 or f!=1
            while (Flag == 0)
            {
                
                /*Initialize Flag is 1
                When both if condition is false then the flag remain 1 
                and the while loop is terminate*/

                Flag = 1;

                //use Even Loop for comparing even idexes of an array 

                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    /* Use if conditon for comparing adjacents elements
                   
                     if they are in wrong order than swap*/

                    if (array[i] > array[i + 1])
                    {
                        
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        //Initialize flag variable is zero
                        Flag = 0;
                    }
                }


                //use Odd Loop for comparing odd idexes of an array 
                for (int i = 1; i < array.Length - 1; i += 2)
                {

                    /* Use if conditon for comparing adjacents elements
                        if they are in wrong order than swap*/
                    if (array[i] > array[i + 1])
                    {
                        
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        //Initialize flag variable is zero
                        Flag = 0;
                    }
                }  
               
            }
            //return sorted array

            return array;

        }
        static void Main(string[] args)
        {
            //Initializing the array 
            int[] arr = new int[] { 3, 2, 3, 8, 5, 6, 4, 1 };
            

            //Creating object of Program class for calling function
            Program pg = new Program();

            //Calling OddEven Function
              pg.OddEven(arr);

            //Printing the sorted array 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
