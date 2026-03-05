using System;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");        
        Console.WriteLine("재료:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount}{ingredient.Unit}");
        }
    }

    public void ScaleRecipe(int newServings)
    {
        double scaleFactor = (double)newServings / Servings;
        Servings = newServings;
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i] = new Ingredient(
                Ingredients[i].Name,
                Ingredients[i].Amount * scaleFactor,
                Ingredients[i].Unit
            );
        }

        PrintRecipe();
    }
}