namespace BlazingPizza;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Extra Cheesy Pizza",
                Description = "It's melty cheese deliciousness. How can you resist?",
                BasePrice = 10.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon!",
                BasePrice = 12.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 12.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Buffalo chicken",
                Description = "Blazing spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up!",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                BasePrice = 12.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Veggie Delight",
                Description = "We put a salad on a pizza.",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil.",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}