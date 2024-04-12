using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE
{
    public class Recipe
    {
        //Ingrediant array
         private Ingredient[] Ingredients;
         //Steps array
        private Step[] Steps;
        //Recipe constructor to initialize
        public Recipe()
        {
            Ingredients = new Ingredient[0];
            Steps = new Step[0];
        }
        //Method to add an ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit)
        {
            Array.Resize(ref Ingredients, Ingredients.Length + 1);
            Ingredients[Ingredients.Length - 1] = new Ingredient(name, quantity, unit);
        }
        //Method to include a step in the recipe
        public void AddStep(string description)
        {
            Array.Resize(ref Steps, Steps.Length + 1);
            Steps[Steps.Length - 1] = new Step(description);
        }
        //Method to show the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine(ingredient.ToString());
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }
        //Method to adjust the formula by a specified amount
        public void ScaleRecipe(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        } 
        //Method to return amounts to their initial values 
        public void ResetQuantities()
        {
            // Not implemented for now
        }
    }
}