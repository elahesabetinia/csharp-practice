List<string> items = new List<string>();

while (true)
{
    Console.WriteLine("\n--- Shopping List ---");
    Console.WriteLine("1. Add item");
    Console.WriteLine("2. Remove item");
    Console.WriteLine("3. Show list");
    Console.WriteLine("4. Exit");
    Console.Write("Choose: ");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            AddItem(items);
            break;
        case "2":
            RemoveItem(items);
            break;
        case "3":
            ShowItems(items);
            break;
        case "4":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

static void AddItem(List<string> items)
{
    Console.Write("Item name: ");
    string name = (Console.ReadLine() ?? "").Trim();

    if (name == "")
    {
        Console.WriteLine("Name cannot be empty.");
        return;
    }
    items.Add(name);
    Console.WriteLine($"'{name}' added.");
}

static void RemoveItem(List<string> items)
{
    Console.Write("Item name to remove: ");
    string name = (Console.ReadLine() ?? "").Trim();

    if (items.Remove(name))
        Console.WriteLine($"'{name}' removed.");
    else
        Console.WriteLine("Item not found.");
}

static void ShowItems(List<string> items)
{
    if (items.Count == 0)
    {
        Console.WriteLine("The list is empty.");
        return;
    }

    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {items[i]}");
    }
}