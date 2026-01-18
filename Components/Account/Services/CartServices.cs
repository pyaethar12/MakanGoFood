namespace MakanGoFood.Services
{
    public class CartItem
    {
        public int MenuId { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
    }

    public class CartService
    {
        public List<CartItem> Items { get; } = new();

        public void Add(int menuId, string name, decimal price)
        {
            var item = Items.FirstOrDefault(i => i.MenuId == menuId);
            if (item is null)
                Items.Add(new CartItem { MenuId = menuId, Name = name, Price = price, Quantity = 1 });
            else
                item.Quantity++;
        }

        public void Increase(int menuId) => Items.First(i => i.MenuId == menuId).Quantity++;

        public void Decrease(int menuId)
        {
            var item = Items.First(i => i.MenuId == menuId);
            item.Quantity--;
            if (item.Quantity <= 0) Items.Remove(item);
        }

        public void Clear() => Items.Clear();

        public decimal Total => Items.Sum(i => i.Price * i.Quantity);
    }
}
