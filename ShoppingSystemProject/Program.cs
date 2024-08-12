namespace ShoppingSystemProject
{
    internal class Program
    {
        static List<string> itemsToCart = new List<string>();
        static Dictionary<string , decimal> itemPrices = new Dictionary<string , decimal>()
        {
            {"camira",2500 },
            {"tv",4000 },
            {"laptop",32000 }
        };
        static Stack<string> actions = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welecom To Shopping System :) ");
            Console.WriteLine("------------------------------");
            while (true) 
            {
                Console.WriteLine("Please choose an option : ");
                Console.WriteLine(" 1) Add item to cart");
                Console.WriteLine(" 2) View cart");
                Console.WriteLine(" 3) Remove item from cart");
                Console.WriteLine(" 4) Checkout");
                Console.WriteLine(" 5) Undo last action");
                Console.WriteLine(" 6) Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ViewCart();
                        break;
                    case 3:
                        RemoveItem();
                        break;
                    case 4:
                        CheckOut();
                        break;
                    case 5:
                        UndoAction();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine("------------------------------");
            }
        }

        private static void AddItem()
        {
            Console.WriteLine("Available items: ");
            foreach (var item in itemPrices)
            {
                Console.WriteLine($"Item: {item.Key.PadRight(8)}, Price: ${item.Value.ToString().PadRight(6)}");
            }
            Console.WriteLine("Select an item : ");
            string itemName = Console.ReadLine();
            if (itemPrices.ContainsKey(itemName.ToLower())) 
            {
                itemsToCart.Add(itemName);
                Console.WriteLine($"Item: {itemName} was added to your cart successfully :)");
                actions.Push($"Item: {itemName} is added to your cart");
            }
            else
            {
                Console.WriteLine("Invalid input or item is not available at that time.");
            }
        }
        private static IEnumerable<ValueTuple<string, decimal>> GetItemPrices()
        {
            List<ValueTuple<string , decimal>> values= new List<ValueTuple<string , decimal>>();
            foreach (var item in itemsToCart)
            {
                values.Add((item, itemPrices[item]));
            }
            return values;
            
        }
        private static void ViewCart()
        {
            var items = GetItemPrices();
            if (items.Any()) 
            {
                Console.WriteLine("Items in your cart: ");
                foreach (var item in items)
                {
                    Console.WriteLine($"Item: {item.Item1.PadRight(8)}, Price: ${item.Item2.ToString().PadRight(6)}");
                }
            }
            else
            {
                Console.WriteLine("Your cart is empty");
            }
            
        }
        private static void RemoveItem()
        {
            ViewCart();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Select an item: ");
            string itemName = Console.ReadLine();
            if (itemsToCart.Contains(itemName.ToLower()))
            {
                itemsToCart.Remove(itemName);
                actions.Push($"Item: {itemName} is removed from your cart");
                Console.WriteLine($"Item: {itemName} was removed from your cart successfully :)");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        private static void CheckOut()
        {
            var items = GetItemPrices();
            decimal totalPrice = 0;
            if (items.Any())
            {
                Console.WriteLine("Items in your cart: ");
                foreach (var item in items)
                {
                    totalPrice += item.Item2;
                    Console.WriteLine($"Item: {item.Item1.PadRight(8)}, Price: {item.Item2.ToString().PadRight(6)}");
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Total Price = {totalPrice:C2}");
            }
            else
            {
                Console.WriteLine("Your cart is empty");
            }
            itemsToCart.Clear();
            actions.Push("checkout");
        }
        private static void UndoAction()
        {
            string lastAction = actions.Pop();
            Console.WriteLine($"Last action is {lastAction}");
            var stringArray = lastAction.Split();
            if (stringArray.Contains("removed"))
            {
                itemsToCart.Add(stringArray[1]);
            }
            else if(stringArray.Contains("added"))
            {
                itemsToCart.Remove(stringArray[1]);
            }
            else
            {
                Console.WriteLine("Checkout can not be undone.Please ask for refund ");
            }
        }


    }
}
