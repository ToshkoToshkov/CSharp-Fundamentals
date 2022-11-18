using _06.StoreBoxes;
using System.Text;

string input = Console.ReadLine();

List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] currCommand = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string serialNumber = currCommand[0];
    string itemName = currCommand[1];
    int itemQuantity = int.Parse(currCommand[2]);
    decimal itemPrice = decimal.Parse(currCommand[3]);
    
    //decimal priceOfOneBox = itemQuantity * itemPrice;

    Item item = new Item()
    {
        Name = itemName,
        Price = itemPrice
    };

    Box box = new Box()
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = itemQuantity,
        PriceForBox = itemQuantity * itemPrice
    };

    boxes.Add(box);

    input = Console.ReadLine();
}

List<Box> orderedBoxes = boxes.OrderByDescending(p => p.PriceForBox).ToList();
 
StringBuilder sb = new StringBuilder();

string result = "";

foreach (var box in orderedBoxes)
{
    sb.AppendLine(box.SerialNumber);
    sb.AppendLine($@"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    sb.AppendLine($@"--${box.PriceForBox:f2}");

    result = sb.ToString();
}

Console.WriteLine(result);


