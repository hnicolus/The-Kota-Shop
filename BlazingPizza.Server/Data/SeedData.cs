namespace BlazingPizza.Server
{
    public static class SeedData
    {
        public static void Initialize(KotaStoreContext db)
        {
            var toppings = new Topping[]
            {
                new Topping()
                {
                    Name = "Extra cheese",
                    Price = 2.50m,
                },

                new Topping()
                {
                    Name = "Russian",
                    Price = 5.00m
                },

                new Topping()
                {
                    Name = "Special",
                    Price = 5.00m
                },
                new Topping()
                {
                    Name = "Bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "Chilli Sauce",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Onions",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Mushrooms",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "extra Spice",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Extra Chips",
                    Price = 3.20m,
                },
               
                new Topping()
                {
                    Name = "Fresh tomatoes",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Basil",
                    Price = 1.50m,
                },
              
            };

            var specials = new KotaSpecial[]
            {
                new KotaSpecial()
                {
                    Name = "Basic Cheese Kota",
                    Description = "It's cheesy and delicious. Why wouldn't you want one?",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/cheese.jpg",
                },
                new KotaSpecial()
                {
                    Id = 2,
                    Name = "The Weekend Kota Special",
                    Description = "The Good kasi Stuff",
                    BasePrice = 11.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
                },
                new KotaSpecial()
                {
                    Id = 3,
                    Name = "Classic Kota",
                    Description = "The ususal!",
                    BasePrice = 10.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
                },
                new KotaSpecial()
                {
                    Id = 4,
                    Name = "chicken Kota",
                    Description = "Spicy chicken, hot sauce and Chips," +
                    " guaranteed to warm you up",
                    BasePrice = 12.75m,
                    ImageUrl = "img/pizzas/meaty.jpg",
                },
                new KotaSpecial()
                {
                    Id = 5,
                    Name = "Kota 4 Lovers",
                    Description = "It has love in it. Isn't that obvious?",
                    BasePrice = 11.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
                },
                new KotaSpecial()
                {
                    Id = 6,
                    Name = "Beef Kota",
                    Description = "Best and Unique...",
                    BasePrice = 10.25m,
                    ImageUrl = "img/pizzas/bacon.jpg",
                },
                new KotaSpecial()
                {
                    Id = 7,
                    Name = "Veggie Kota",
                    Description = "It's like salad, but on a Kota",
                    BasePrice = 11.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
                },
                new KotaSpecial()
                {
                    Id = 8,
                    Name = "Chips",
                    Description = "Plain chips with tomatoes sauce and salt",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
                },
            };

            db.Toppings.AddRange(toppings);
            db.Specials.AddRange(specials);
            db.SaveChanges();
        }
    }
}
