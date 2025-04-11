/*
1. ------------------- Супермаркет
   Створити ієрархію класів для продажу товарів Супермаркету
   	Продукт(назва, термін споживання, категорія - молочні. хлібобулочні та ін., ціна, кількість)
   	Товар (назва, категорія - побутова хімія, текстиль та ін., ціна, кількість)
   Створити програму для роботи Супермаркету
   	Додавання продукту(товару) у базу(врахувати, що товар у базі може бути наявний або ні )
   	Збереження бази товарів(у файл)
   	Завантаження бази товарів з файлу
   	Перегляд продуктів(товарів), впорядкованих по категоріях
   	Пошук певного товару(продукту) з видачею інформації про товар(продукт)
   	Видалення певного товару(продукту) з бази
   	Продаж товару(з видачею чеку)
*/

using System.ComponentModel;

Console.WriteLine("------------- Welcome to our Supermarket -------------");
Console.WriteLine("\tMenu:");
Console.WriteLine("1. Add Product");
Console.WriteLine("2. Save to file");
Console.WriteLine("3. Load from file");
Console.WriteLine("4. Show all products");
Console.WriteLine("5. Find product");
Console.WriteLine("6. Delete product");
Console.WriteLine("7. Sell product");

Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
	case 1:
		
		break;
	case 4:
		//...
		break;
}

public class Product
{
	public string name;
	public int quantity;
	public double price;
	public string category;
	public string expirationDate;
}