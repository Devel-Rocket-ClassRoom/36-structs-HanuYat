using System;

// README.md를 읽고 코드를 작성하세요.

InventoryItem[] items = new InventoryItem[]
{
    new InventoryItem("검", 3.5, 1500),
    new InventoryItem("방패", 5.0, 1200),
    new InventoryItem("포션", 0.3, 50),
    new InventoryItem("활", 1.8, 1300),
    new InventoryItem("투구", 2.0, 800)
};

Console.WriteLine("=== 인벤토리 목록 ===");
foreach (var item in items)
{
    Console.WriteLine($"{item.Name} - 무게: {item.Weight}kg, 가격: {item.Price}골드");
}
Console.WriteLine();

Console.WriteLine("=== 인벤토리 통계 ===");

double totalWeight = 0;
for (int i = 0; i < items.Length; i++)
{   
    totalWeight += items[i].Weight;
}
Console.WriteLine($"전체 무게: {totalWeight:F1}kg");

int totalPrice = 0;
for (int i = 0; i < items.Length; i++)
{
    totalPrice += items[i].Price;
}
Console.WriteLine($"전체 가격: {totalPrice}골드");

int averagedPrice = 0;
for (int i = 0; i < items.Length; i++)
{
    averagedPrice = totalPrice / items.Length;
}
Console.WriteLine($"평균 가격: {averagedPrice}골드");

int maxPrice = int.MinValue;
string mostExpensiveItem = "";
foreach (var item in items)
{
    if (item.Price > maxPrice)
    {
        maxPrice = item.Price;
        mostExpensiveItem = item.Name;
    }
}
Console.WriteLine($"가장 비싼 아이템: {mostExpensiveItem}");

double minWeight = double.MaxValue;
string lightestItem = "";
for (int i = 0; i < items.Length; i++)
{
    if (items[i].Weight < minWeight)
    {
        minWeight = items[i].Weight;
        lightestItem = items[i].Name;
    }
}
Console.WriteLine($"가장 가벼운 아이템: {lightestItem}");