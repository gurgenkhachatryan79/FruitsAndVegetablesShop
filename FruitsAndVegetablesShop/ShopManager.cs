namespace FruitsAndVegetablesShop
{
    public class ShopManager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        //  public List<IProducts> ProductsList;
        //  public Shop shop;

        public ShopManager(int id, string name, int age)
        {
            Name = name;
            Age = age;
            Id = id;
            //   shop = new Shop();
            //  ProductsList = new List<IProducts>();

        }

        //public void GetProductForShop(List<IProducts> products)
        //{
        //    shop.ProductsList.AddRange(products);
        //}
    }
}
