﻿using System;
using System.Linq.Expressions;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            //var r = new Random();
            // favNumber = r.Next(1, 1000);
            //var favNumber = 5;

           // Console.WriteLine("Pick a number from 1-1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            {
                //Console.WriteLine($"{userInput} is too low");

            }
            //else if (userInput > favNumber)
            {
                //Console.WriteLine($"{userInput} is too high");
            }
            //else
            {
                //Console.WriteLine("This is my favorite number!"); 
            
            } //while (userInput !=favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                case"calculus":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                case "PE":
                    Console.WriteLine("PE is the best!!");
                    break;
                case "history":
                    Console.WriteLine("History is fun!");
                    break;
                case "English":
                    Console.WriteLine("English is boring!");
                    break;
                    default:
                    Console.WriteLine("I don't know that subject.");
                    break;
           
            }
        }   
	

	}
    }

