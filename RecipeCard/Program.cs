using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 원본 레시피 ===");
Ingredient[] ingredients = new Ingredient[]
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽"),
};

RecipeCard tomatoPasta = new RecipeCard("토마토 파스타", 2, ingredients);
tomatoPasta.PrintRecipe();
Console.WriteLine();

Console.WriteLine("=== 4인분으로 변환 ===");
tomatoPasta.ScaleRecipe(4);