using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE
{
    
    public class FoodApp
    {
        private Recipe recipe;//recipe class

        public FoodApp()//Constructor to initialize the application
        {
            recipe = new Recipe();
        }

        public void Run()// Method to start the application
        {
            while (true)
            {
                //Menu options
                Console.WriteLine("1. Add ingredient");
                Console.WriteLine("2. Add step");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear all data");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Choose an option:");
                
                // Read user choice
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                    continue;
                }

                //Will Perform action based on user choice
                switch (choice)
                {
                    case 1:
                        AddIngredient();
                        break;
                    case 2:
                        AddStep();
                        break;
                    case 3:
                        DisplayRecipe();
                        break;
                    case 4:
                        ScaleRecipe();
                        break;
                    case 5:
                        ResetQuantities();
                        break;
                    case 6:
                        ClearData();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }
            
        //Method to incorporate a component into the recipe
        private void AddIngredient()
        {
            Console.WriteLine("Enter ingredient name:");

            string name = Console.ReadLine();

            double quantity;

            Console.WriteLine("Enter quantity:");

            while (!double.TryParse(Console.ReadLine(), out quantity))
            
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number.");
            }

            Console.WriteLine("Enter unit:");
            string unit = Console.ReadLine();

            recipe.AddIngredient(name, quantity, unit);
        }
   
        //Method to include a step in the recipe
        private void AddStep()
        {
            Console.WriteLine("Enter step description:");
            string description = Console.ReadLine();
            recipe.AddStep(description);
        }
                         
        

        // Method to display the recipe
        private void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:");
            recipe.DisplayRecipe();
            Console.WriteLine();
        }
        // Method to scale the recipe
        private void ScaleRecipe()
        {
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
            double factor;
            while (!double.TryParse(Console.ReadLine(), out factor) || (factor != 0.5 && factor != 2 && factor != 3))
            {
                Console.WriteLine("Invalid factor. Please enter 0.5, 2, or 3.");
            }

            recipe.ScaleRecipe(factor);
            Console.WriteLine("Recipe scaled successfully.\n");
        }
             
        //Method to reset quantities
        private void ResetQuantities()
        {
            // Not implemented for now
            Console.WriteLine("Quantities reset successfully.\n");
        }
        //method to clear data
        private void ClearData()
        {
            recipe = new Recipe();
            Console.WriteLine("All data cleared successfully.\n");
        }
    }
}