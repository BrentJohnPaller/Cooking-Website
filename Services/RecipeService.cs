using CookingWebsite.Models;

namespace CookingWebsite.Services
{
    public static class RecipeService
    {
        public static List<Recipe> GetAllRecipes()
        {
            return new List<Recipe>
            {
                //PASTA
                new Recipe
                {
                    Id = 1, Title = "Classic Spaghetti Carbonara",
                    Description = "A rich and creamy Roman pasta dish made with eggs, cheese, pancetta, and pepper. No cream needed!",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1755594461640-b800c6bafdfa?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 20, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Maria", DatePosted = new DateTime(2026, 1, 15), Likes = 245,
                    Ingredients = new List<string> { "400g spaghetti","200g pancetta or guanciale","4 large eggs","100g Pecorino Romano, grated","50g Parmesan, grated","Black pepper to taste","Salt for pasta water" },
                    Steps = new List<string> { "Cook spaghetti in heavily salted boiling water until al dente.","Fry pancetta in a large pan over medium heat until crispy.","Whisk together eggs, Pecorino, and Parmesan. Season with black pepper.","Reserve 1 cup of pasta cooking water before draining.","Remove pan from heat. Add drained pasta to pancetta and toss.","Add egg mixture and a splash of pasta water. Toss quickly to create a creamy sauce.","Serve immediately with extra cheese and black pepper." }
                },
                new Recipe
                {
                    Id = 7, Title = "Penne Arrabbiata",
                    Description = "Fiery and bold Italian pasta in a spicy tomato sauce with garlic and red chili flakes.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1582035619445-9c26d5de240d?q=80&w=880&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 20, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 1, 20), Likes = 198,
                    Ingredients = new List<string> { "400g penne","400g crushed tomatoes","4 cloves garlic, sliced","1 tsp red chili flakes","3 tbsp olive oil","Fresh parsley","Salt and pepper","Parmesan for serving" },
                    Steps = new List<string> { "Cook penne in salted boiling water until al dente.","Heat olive oil in a pan. Add garlic and chili flakes, cook 2 minutes.","Add crushed tomatoes. Season with salt and pepper. Simmer 15 minutes.","Drain pasta and toss with the sauce.","Serve topped with fresh parsley and Parmesan." }
                },
                new Recipe
                {
                    Id = 8, Title = "Fettuccine Alfredo",
                    Description = "Silky, buttery fettuccine coated in a luscious Parmesan cream sauce. Pure Italian comfort food.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1645112411341-6c4fd023714a?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 15, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Lucia", DatePosted = new DateTime(2026, 1, 25), Likes = 220,
                    Ingredients = new List<string> { "400g fettuccine","200ml heavy cream","100g butter","150g Parmesan, grated","2 cloves garlic, minced","Salt and black pepper","Fresh parsley" },
                    Steps = new List<string> { "Cook fettuccine in salted water until al dente. Reserve 1 cup pasta water.","Melt butter in a large pan over medium heat. Add garlic and cook 1 minute.","Add cream and bring to a gentle simmer.","Add Parmesan and stir until melted and smooth.","Toss in drained pasta. Add pasta water to loosen if needed.","Season with salt and pepper. Serve with fresh parsley." }
                },
                new Recipe
                {
                    Id = 9, Title = "Pasta Bolognese",
                    Description = "A slow-cooked hearty meat sauce from Bologna, Italy. Rich, deep, and absolutely worth the wait.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1622973536968-3ead9e780960?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 120, Servings = 6, Difficulty = "Medium",
                    Author = "Chef Roberto", DatePosted = new DateTime(2026, 2, 1), Likes = 310,
                    Ingredients = new List<string> { "500g tagliatelle","400g ground beef","400g ground pork","400g crushed tomatoes","1 onion, finely chopped","2 carrots, finely diced","2 celery stalks, finely diced","150ml red wine","150ml whole milk","3 tbsp olive oil","Salt and pepper" },
                    Steps = new List<string> { "Heat oil in a heavy pot. Cook onion, carrot, and celery until soft, about 10 minutes.","Add ground beef and pork. Cook until browned, breaking up lumps.","Pour in wine and cook until evaporated.","Add tomatoes and stir well. Season with salt and pepper.","Simmer on very low heat for 90 minutes, stirring occasionally.","Stir in milk and cook 10 more minutes.","Toss with freshly cooked tagliatelle and serve with Parmesan." }
                },
                new Recipe
                {
                    Id = 10, Title = "Cacio e Pepe",
                    Description = "A deceptively simple Roman pasta with just pecorino, black pepper, and pasta water. Technique is everything.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1562281556-0f8c259a9f3a?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 15, Servings = 2, Difficulty = "Hard",
                    Author = "Chef Maria", DatePosted = new DateTime(2026, 2, 8), Likes = 267,
                    Ingredients = new List<string> { "200g spaghetti or tonnarelli","100g Pecorino Romano, finely grated","50g Parmesan, finely grated","2 tsp coarsely ground black pepper","Salt for pasta water" },
                    Steps = new List<string> { "Cook pasta in lightly salted water. Reserve 2 cups pasta water before draining.","Toast black pepper in a dry pan for 1 minute until fragrant.","Add 1/2 cup pasta water to the pan and let it reduce slightly.","Add drained pasta and toss to coat.","Remove from heat. Add cheese gradually, tossing vigorously and adding pasta water to form a creamy sauce.","Serve immediately with extra pepper and cheese." }
                },
                new Recipe
                {
                    Id = 11, Title = "Pasta Primavera",
                    Description = "Fresh spring vegetables tossed with penne in a light olive oil and garlic sauce. Colorful and healthy.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1566640445929-28a1aa99e0d7?q=80&w=1172&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 20, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 2, 15), Likes = 156,
                    Ingredients = new List<string> { "400g penne","1 zucchini, sliced","1 cup cherry tomatoes","1 bell pepper, sliced","1 cup broccoli florets","4 cloves garlic, sliced","4 tbsp olive oil","Parmesan for serving","Fresh basil","Salt and pepper" },
                    Steps = new List<string> { "Cook penne until al dente. Reserve pasta water.","Heat olive oil in a large pan. Add garlic and cook 1 minute.","Add broccoli and bell pepper. Cook 4 minutes.","Add zucchini and tomatoes. Cook 3 more minutes.","Toss in drained pasta with a splash of pasta water.","Season with salt and pepper. Top with basil and Parmesan." }
                },
                new Recipe
                {
                    Id = 12, Title = "Lasagna al Forno",
                    Description = "Classic baked Italian lasagna layered with rich Bolognese, creamy bechamel, and melted cheese.",
                    Category = "Pasta", ImageUrl = "https://plus.unsplash.com/premium_photo-1723770033472-0b0452d98225?q=80&w=1097&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 30, CookTimeMinutes = 60, Servings = 8, Difficulty = "Hard",
                    Author = "Chef Lucia", DatePosted = new DateTime(2026, 2, 22), Likes = 389,
                    Ingredients = new List<string> { "12 lasagna sheets","500g ground beef","400g crushed tomatoes","500ml bechamel sauce","200g mozzarella, shredded","100g Parmesan, grated","1 onion, chopped","2 cloves garlic","2 tbsp olive oil","Salt and pepper" },
                    Steps = new List<string> { "Make meat sauce: cook onion and garlic in oil, add beef, then tomatoes. Simmer 30 minutes.","Prepare bechamel or use store-bought.","Preheat oven to 180C.","Layer in a baking dish: meat sauce, lasagna sheets, bechamel, cheese. Repeat 3 times.","Top with remaining bechamel and Parmesan.","Bake 45 minutes until golden and bubbling. Rest 10 minutes before serving." }
                },
                new Recipe
                {
                    Id = 13, Title = "Shrimp Scampi Linguine",
                    Description = "Plump shrimp in a garlicky white wine butter sauce over linguine. Ready in 20 minutes.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1709096723102-327e4187cc15?q=80&w=1074&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 15, Servings = 4, Difficulty = "Easy",
                    Author = "Chef James", DatePosted = new DateTime(2026, 3, 1), Likes = 243,
                    Ingredients = new List<string> { "400g linguine","500g large shrimp, peeled","6 cloves garlic, minced","150ml dry white wine","4 tbsp butter","2 tbsp olive oil","Juice of 1 lemon","Red chili flakes","Fresh parsley","Salt and pepper" },
                    Steps = new List<string> { "Cook linguine until al dente. Reserve pasta water.","Heat olive oil in a large pan. Add shrimp, cook 2 minutes per side. Remove.","Add butter and garlic to pan. Cook 1 minute.","Pour in wine and lemon juice. Simmer 3 minutes.","Return shrimp to pan. Add drained pasta and toss.","Add pasta water if needed. Top with parsley and chili flakes." }
                },
                new Recipe
                {
                    Id = 14, Title = "Mushroom Truffle Pasta",
                    Description = "Earthy wild mushrooms and truffle oil tossed with tagliatelle for an indulgent restaurant-quality meal at home.",
                    Category = "Pasta", ImageUrl = "https://plus.unsplash.com/premium_photo-1726804961062-31c16c245079?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 20, Servings = 2, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 3, 8), Likes = 178,
                    Ingredients = new List<string> { "200g tagliatelle","300g mixed mushrooms","3 cloves garlic, minced","100ml heavy cream","2 tbsp truffle oil","30g Parmesan, grated","2 tbsp butter","Fresh thyme","Salt and pepper" },
                    Steps = new List<string> { "Cook tagliatelle until al dente. Reserve pasta water.","Melt butter in a pan over high heat. Add mushrooms and cook until golden, 5 minutes.","Add garlic and thyme. Cook 1 more minute.","Pour in cream and simmer 3 minutes.","Toss in drained pasta. Add pasta water to loosen.","Drizzle with truffle oil and serve with Parmesan." }
                },
                new Recipe
                {
                    Id = 15, Title = "Pasta e Fagioli",
                    Description = "A hearty Italian peasant soup of pasta and beans in a rich tomato broth. Warming and filling.",
                    Category = "Pasta", ImageUrl = "https://images.unsplash.com/photo-1693609930476-5838e8584277?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 35, Servings = 6, Difficulty = "Easy",
                    Author = "Chef Roberto", DatePosted = new DateTime(2026, 3, 15), Likes = 145,
                    Ingredients = new List<string> { "200g ditalini pasta","2 cans cannellini beans","400g crushed tomatoes","1 onion, chopped","3 cloves garlic","2 carrots, diced","1L chicken broth","2 tbsp olive oil","1 tsp rosemary","Parmesan rind","Salt and pepper" },
                    Steps = new List<string> { "Heat oil in a large pot. Cook onion, garlic, and carrots 5 minutes.","Add tomatoes, broth, rosemary, and Parmesan rind. Simmer 15 minutes.","Add beans. Mash some with the back of a spoon to thicken.","Add pasta and cook until al dente.","Remove Parmesan rind. Adjust seasoning.","Serve drizzled with olive oil and topped with Parmesan." }
                },

                //SEAFOOD
                new Recipe
                {
                    Id = 2, Title = "Honey Garlic Butter Salmon",
                    Description = "Perfectly seared salmon fillets glazed with a sweet and savory honey garlic butter sauce.",
                    Category = "Seafood", ImageUrl = "https://plus.unsplash.com/premium_photo-1723507303239-14b6f6c0a58e?q=80&w=1214&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 15, Servings = 2, Difficulty = "Easy",
                    Author = "Chef James", DatePosted = new DateTime(2026, 2, 3), Likes = 312,
                    Ingredients = new List<string> { "2 salmon fillets (skin-on)","3 tbsp butter","4 cloves garlic, minced","3 tbsp honey","1 tbsp soy sauce","Juice of 1 lemon","Salt and pepper","Fresh parsley for garnish" },
                    Steps = new List<string> { "Pat salmon fillets dry and season with salt and pepper.","Heat a skillet over medium-high heat and add 1 tbsp butter.","Sear salmon skin-side up for 4 minutes, then flip.","Add remaining butter, garlic, honey, soy sauce, and lemon juice.","Baste salmon repeatedly with the sauce for 3-4 minutes.","Salmon is done when it flakes easily with a fork.","Garnish with fresh parsley and serve with the pan sauce." }
                },
                new Recipe
                {
                    Id = 16, Title = "Garlic Butter Shrimp",
                    Description = "Juicy shrimp sautéed in a rich garlic butter sauce with a squeeze of lemon. Ready in 10 minutes.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1625943553852-781c6dd46faa?q=80&w=1045&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 10, Servings = 4, Difficulty = "Easy",
                    Author = "Chef James", DatePosted = new DateTime(2026, 2, 10), Likes = 287,
                    Ingredients = new List<string> { "500g large shrimp, peeled and deveined","5 cloves garlic, minced","4 tbsp butter","2 tbsp olive oil","Juice of 1 lemon","1/4 tsp red chili flakes","Fresh parsley","Salt and pepper" },
                    Steps = new List<string> { "Pat shrimp dry and season with salt and pepper.","Heat olive oil in a large skillet over medium-high heat.","Add shrimp in a single layer. Cook 1-2 minutes per side until pink. Remove.","Add butter and garlic to the pan. Cook 1 minute.","Return shrimp to pan. Add lemon juice and chili flakes.","Toss everything together. Garnish with parsley and serve immediately." }
                },
                new Recipe
                {
                    Id = 17, Title = "Pan-Seared Sea Bass",
                    Description = "Crispy-skinned sea bass with a light herb butter sauce. Elegant enough for a dinner party.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1682970078946-22576389f45d?q=80&w=1333&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 15, Servings = 2, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 2, 17), Likes = 201,
                    Ingredients = new List<string> { "2 sea bass fillets","3 tbsp butter","2 cloves garlic, crushed","Fresh thyme and rosemary","Juice of half a lemon","2 tbsp olive oil","Salt and pepper" },
                    Steps = new List<string> { "Score the skin of the sea bass and season both sides generously.","Heat olive oil in an oven-safe skillet over high heat.","Place fish skin-side down. Press gently with a spatula. Cook 4 minutes.","Add butter, garlic, and herbs. Baste the fish continuously.","Flip and cook 2 more minutes.","Squeeze lemon over fish and serve immediately." }
                },
                new Recipe
                {
                    Id = 18, Title = "Classic Fish and Chips",
                    Description = "Crispy beer-battered cod with golden chunky chips. A beloved British classic done right at home.",
                    Category = "Seafood", ImageUrl = "https://plus.unsplash.com/premium_photo-1695758774479-faae1180b078?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 30, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 2, 24), Likes = 334,
                    Ingredients = new List<string> { "4 cod fillets","4 large potatoes, cut into chips","200g all-purpose flour","250ml cold beer","1 tsp baking powder","Oil for deep frying","Salt and malt vinegar to serve" },
                    Steps = new List<string> { "Parboil chips 5 minutes. Drain and dry thoroughly.","Make batter: whisk flour, baking powder, and beer until smooth. Season.","Heat oil to 180C. Fry chips until golden, about 8 minutes. Drain and keep warm.","Pat fish dry, season, and dip into batter letting excess drip off.","Fry fish 5-6 minutes until golden and crispy.","Drain on paper towels. Serve with chips, salt, and malt vinegar." }
                },
                new Recipe
                {
                    Id = 19, Title = "Creamy Clam Chowder",
                    Description = "A thick, creamy New England-style clam chowder loaded with tender clams, potatoes, and smoky bacon.",
                    Category = "Seafood", ImageUrl = "https://plus.unsplash.com/premium_photo-1664391935474-f1e502d3ad61?q=80&w=1055&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 30, Servings = 6, Difficulty = "Medium",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 3, 3), Likes = 256,
                    Ingredients = new List<string> { "2 cans clams with juice","200g bacon, diced","3 potatoes, peeled and diced","1 onion, diced","2 celery stalks, diced","500ml heavy cream","250ml fish stock","3 tbsp butter","3 tbsp flour","Fresh thyme","Salt and pepper" },
                    Steps = new List<string> { "Cook bacon in a large pot until crispy. Remove and set aside.","In bacon fat, cook onion and celery until soft.","Add butter and flour. Stir 2 minutes to make a roux.","Add clam juice and fish stock. Whisk until smooth. Bring to a boil.","Add potatoes and thyme. Simmer 15 minutes until potatoes are tender.","Add cream and clams. Heat through but do not boil.","Season with salt and pepper. Top with bacon and serve with oyster crackers." }
                },
                new Recipe
                {
                    Id = 20, Title = "Grilled Lobster Tail",
                    Description = "Succulent grilled lobster tail with lemon garlic butter. A luxurious treat that is surprisingly simple to make.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1647687214141-64500b1f21df?q=80&w=735&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 12, Servings = 2, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 3, 10), Likes = 412,
                    Ingredients = new List<string> { "2 lobster tails","4 tbsp butter, melted","4 cloves garlic, minced","Juice of 1 lemon","1 tsp paprika","Fresh parsley","Salt and pepper" },
                    Steps = new List<string> { "Using kitchen scissors, cut through the top shell of each lobster tail lengthwise.","Gently pull meat up through the shell, resting it on top.","Mix melted butter, garlic, lemon juice, and paprika.","Brush lobster generously with butter mixture.","Grill shell-side down over medium-high heat for 10-12 minutes, basting frequently.","Meat should be opaque and lightly charred. Serve with remaining butter sauce." }
                },
                new Recipe
                {
                    Id = 21, Title = "Mussels in White Wine",
                    Description = "Fresh mussels steamed in white wine, garlic, and herbs. Ready in 15 minutes and perfect with crusty bread.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1775634018153-51e9884dbf7c?q=80&w=880&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 15, Servings = 2, Difficulty = "Easy",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 3, 17), Likes = 189,
                    Ingredients = new List<string> { "1kg fresh mussels, cleaned","250ml dry white wine","4 cloves garlic, sliced","1 shallot, finely chopped","3 tbsp butter","Fresh parsley","Crusty bread to serve","Salt and pepper" },
                    Steps = new List<string> { "Discard any mussels that are open and do not close when tapped.","Melt butter in a large pot over medium heat. Cook shallot and garlic 2 minutes.","Pour in wine and bring to a boil.","Add mussels. Cover and steam 5-7 minutes until all shells open.","Discard any mussels that did not open.","Stir in parsley and serve in deep bowls with crusty bread." }
                },
                new Recipe
                {
                    Id = 22, Title = "Tuna Poke Bowl",
                    Description = "Hawaiian-style fresh tuna poke bowl with sushi rice, avocado, edamame, and a savory sesame soy dressing.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1592171029478-6e98b23f3f03?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 20, Servings = 2, Difficulty = "Easy",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 3, 24), Likes = 298,
                    Ingredients = new List<string> { "300g sushi-grade tuna, diced","2 cups sushi rice, cooked","1 avocado, sliced","1/2 cup edamame","1/4 cup cucumber, diced","3 tbsp soy sauce","1 tbsp sesame oil","1 tsp rice vinegar","1 tsp sriracha","Sesame seeds","Green onions" },
                    Steps = new List<string> { "Cook sushi rice and season with rice vinegar.","Make dressing: whisk soy sauce, sesame oil, and sriracha.","Toss diced tuna with half the dressing. Marinate 10 minutes.","Divide rice into bowls.","Arrange tuna, avocado, edamame, and cucumber on top of rice.","Drizzle remaining dressing over everything. Top with sesame seeds and green onions." }
                },
                new Recipe
                {
                    Id = 23, Title = "Baked Cod with Lemon Herb Crust",
                    Description = "Flaky baked cod topped with a golden breadcrumb, lemon, and herb crust. Light, healthy, and delicious.",
                    Category = "Seafood", ImageUrl = "https://images.unsplash.com/photo-1587913956756-4fcf4833241d?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 20, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 4, 1), Likes = 167,
                    Ingredients = new List<string> { "4 cod fillets","1 cup panko breadcrumbs","3 tbsp butter, melted","Zest of 1 lemon","2 cloves garlic, minced","2 tbsp fresh parsley, chopped","1 tsp dried oregano","Salt and pepper" },
                    Steps = new List<string> { "Preheat oven to 200C. Line a baking tray with parchment.","Mix panko, melted butter, lemon zest, garlic, parsley, and oregano.","Season cod fillets with salt and pepper. Place on baking tray.","Press breadcrumb mixture firmly onto each fillet.","Bake 18-20 minutes until crust is golden and fish flakes easily.","Serve with lemon wedges and a green salad." }
                },
                new Recipe
                {
                    Id = 24, Title = "Seafood Paella",
                    Description = "A stunning Spanish rice dish packed with shrimp, mussels, squid, and saffron-infused bomba rice.",
                    Category = "Seafood", ImageUrl = "https://plus.unsplash.com/premium_photo-1719424374504-653c684f12fe?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 40, Servings = 6, Difficulty = "Hard",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 4, 8), Likes = 445,
                    Ingredients = new List<string> { "400g bomba or arborio rice","300g shrimp","300g mussels","200g squid rings","1 onion, diced","4 cloves garlic","400g crushed tomatoes","1L seafood stock","1 tsp saffron threads","1 tsp smoked paprika","4 tbsp olive oil","Lemon wedges to serve" },
                    Steps = new List<string> { "Dissolve saffron in 2 tbsp warm water. Set aside.","Heat olive oil in a large paella pan. Cook onion until soft.","Add garlic and paprika. Cook 1 minute.","Add tomatoes and cook 5 minutes.","Add rice and stir to coat. Pour in stock and saffron water.","Arrange seafood on top. Do not stir from this point.","Cook over medium heat 20-25 minutes until rice is done and bottom is lightly crusted. Serve with lemon." }
                },

                //BREAKFAST (10)
                new Recipe
                {
                    Id = 3, Title = "Fluffy Blueberry Pancakes",
                    Description = "Light and airy pancakes bursting with fresh blueberries. The perfect weekend breakfast treat.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1517306085770-871ff74b2274?q=80&w=915&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 20, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 3, 10), Likes = 189,
                    Ingredients = new List<string> { "2 cups all-purpose flour","2 tbsp sugar","2 tsp baking powder","1/2 tsp salt","2 large eggs","1 3/4 cups milk","1/4 cup melted butter","1 cup fresh blueberries","1 tsp vanilla extract" },
                    Steps = new List<string> { "Whisk together flour, sugar, baking powder, and salt in a large bowl.","In another bowl, beat eggs then mix in milk, melted butter, and vanilla.","Pour wet ingredients into dry ingredients. Stir until just combined — lumps are okay!","Gently fold in blueberries.","Heat a greased griddle or pan over medium heat.","Pour 1/4 cup batter per pancake. Cook until bubbles form on top, then flip.","Cook 1-2 more minutes until golden. Serve with maple syrup and extra blueberries." }
                },
                new Recipe
                {
                    Id = 25, Title = "Classic Eggs Benedict",
                    Description = "Poached eggs on toasted English muffins with Canadian bacon and rich hollandaise sauce.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1559716229-d8f4e9d01ec6?q=80&w=880&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 20, Servings = 2, Difficulty = "Hard",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 3, 17), Likes = 334,
                    Ingredients = new List<string> { "4 eggs","2 English muffins, split and toasted","4 slices Canadian bacon","3 egg yolks","200g butter, melted","Juice of half a lemon","White vinegar for poaching","Salt, pepper, and paprika" },
                    Steps = new List<string> { "Make hollandaise: whisk egg yolks and lemon juice in a double boiler until thick. Slowly drizzle in melted butter while whisking. Season.","Pan-fry Canadian bacon until warmed through.","Bring a pot of water with a splash of vinegar to a gentle simmer.","Crack each egg into a small cup. Create a gentle whirlpool in the water and slide egg in. Poach 3 minutes.","Place bacon on toasted muffins. Top with poached eggs.","Spoon hollandaise over everything. Dust with paprika and serve immediately." }
                },
                new Recipe
                {
                    Id = 26, Title = "Avocado Toast with Poached Egg",
                    Description = "Creamy smashed avocado on sourdough topped with a perfectly poached egg, chili flakes, and microgreens.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1613769049987-b31b641f25b1?q=80&w=1167&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 10, Servings = 2, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 3, 24), Likes = 267,
                    Ingredients = new List<string> { "2 slices sourdough bread","2 ripe avocados","2 eggs","Juice of half a lemon","Red chili flakes","Microgreens or baby spinach","Salt and pepper","White vinegar" },
                    Steps = new List<string> { "Toast sourdough until golden and crispy.","Scoop avocado into a bowl. Add lemon juice, salt, and pepper. Mash to your preferred texture.","Poach eggs: simmer water with a splash of vinegar. Create a whirlpool, slide in egg, cook 3 minutes.","Spread avocado generously on toast.","Top with poached egg. Season with salt, pepper, and chili flakes.","Finish with microgreens and serve immediately." }
                },
                new Recipe
                {
                    Id = 27, Title = "Full English Breakfast",
                    Description = "A hearty British fry-up with bacon, eggs, sausages, baked beans, grilled tomatoes, and toast.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1655979283362-535e6a167a53?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 25, Servings = 2, Difficulty = "Medium",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 4, 1), Likes = 298,
                    Ingredients = new List<string> { "4 rashers back bacon","2 pork sausages","2 eggs","1 can baked beans","2 tomatoes, halved","4 mushrooms","2 slices bread","Butter","Salt and pepper" },
                    Steps = new List<string> { "Grill sausages under medium heat, turning occasionally, about 15 minutes.","Add bacon rashers and grill alongside sausages for last 5 minutes.","Heat baked beans in a small saucepan.","Fry mushrooms and tomatoes in butter in a pan.","Fry eggs to your liking in the same pan.","Toast and butter the bread.","Arrange everything on a warm plate and serve immediately." }
                },
                new Recipe
                {
                    Id = 28, Title = "French Toast",
                    Description = "Golden, custardy French toast dusted with powdered sugar and served with fresh berries and maple syrup.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1484723091739-30a097e8f929?q=80&w=749&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 15, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 4, 8), Likes = 212,
                    Ingredients = new List<string> { "8 thick slices brioche or challah","3 eggs","150ml milk","2 tbsp sugar","1 tsp vanilla extract","1/2 tsp cinnamon","Butter for frying","Powdered sugar, berries, and maple syrup to serve" },
                    Steps = new List<string> { "Whisk eggs, milk, sugar, vanilla, and cinnamon in a shallow bowl.","Heat butter in a large skillet over medium heat.","Dip each bread slice in the egg mixture, letting it soak 30 seconds per side.","Cook in batches 2-3 minutes per side until golden.","Serve stacked with a dusting of powdered sugar, fresh berries, and maple syrup." }
                },
                new Recipe
                {
                    Id = 29, Title = "Shakshuka",
                    Description = "Eggs poached in a spiced tomato and pepper sauce. A Middle Eastern breakfast classic that is bold and satisfying.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1590412200988-a436970781fa?w=600",
                    PrepTimeMinutes = 10, CookTimeMinutes = 25, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 4, 15), Likes = 321,
                    Ingredients = new List<string> { "6 eggs","400g crushed tomatoes","2 bell peppers, diced","1 onion, diced","4 cloves garlic","1 tsp cumin","1 tsp paprika","1/2 tsp chili flakes","2 tbsp olive oil","Fresh parsley and feta to serve" },
                    Steps = new List<string> { "Heat olive oil in a large skillet. Cook onion and peppers until soft, 8 minutes.","Add garlic, cumin, paprika, and chili flakes. Cook 1 minute.","Pour in tomatoes. Season and simmer 10 minutes.","Make 6 wells in the sauce. Crack an egg into each well.","Cover and cook 7-10 minutes until whites are set but yolks are still runny.","Top with feta and parsley. Serve directly from the pan with crusty bread." }
                },
                new Recipe
                {
                    Id = 30, Title = "Breakfast Burrito",
                    Description = "A loaded breakfast burrito stuffed with scrambled eggs, crispy bacon, cheese, salsa, and avocado.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1542895364-1f38d277f031?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 15, Servings = 2, Difficulty = "Easy",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 4, 22), Likes = 178,
                    Ingredients = new List<string> { "2 large flour tortillas","4 eggs, beaten","4 strips bacon","1/2 cup cheddar cheese, shredded","1 avocado, sliced","4 tbsp salsa","2 tbsp sour cream","Salt and pepper","Butter" },
                    Steps = new List<string> { "Cook bacon until crispy. Drain and chop roughly.","Scramble eggs in butter over medium-low heat until just set. Season.","Warm tortillas in a dry pan or microwave.","Layer eggs, bacon, cheese, avocado, salsa, and sour cream down the center of each tortilla.","Fold sides in, then roll tightly into a burrito.","Optional: toast seam-side down in the pan 1 minute per side until golden." }
                },
                new Recipe
                {
                    Id = 31, Title = "Banana Oat Smoothie Bowl",
                    Description = "A thick and creamy smoothie bowl topped with granola, fresh fruit, and honey. Nutritious and beautiful.",
                    Category = "Breakfast", ImageUrl = "https://plus.unsplash.com/premium_photo-1663841165547-1b671e7a6bfa?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 0, Servings = 1, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 5, 1), Likes = 143,
                    Ingredients = new List<string> { "2 frozen bananas","1/2 cup rolled oats","1/2 cup almond milk","1 tbsp peanut butter","Toppings: granola, sliced banana, strawberries, blueberries, honey, chia seeds" },
                    Steps = new List<string> { "Blend frozen bananas, oats, almond milk, and peanut butter until very thick and smooth.","Pour into a bowl.","Arrange toppings: granola, sliced fruit, and chia seeds.","Drizzle with honey and serve immediately." }
                },
                new Recipe
                {
                    Id = 32, Title = "Overnight Oats",
                    Description = "No-cook creamy oats prepared the night before. Endlessly customizable and perfect for busy mornings.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1619854232004-82cb7160cd65?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 5, CookTimeMinutes = 0, Servings = 1, Difficulty = "Easy",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 5, 8), Likes = 156,
                    Ingredients = new List<string> { "1/2 cup rolled oats","1/2 cup milk or almond milk","1/4 cup Greek yogurt","1 tbsp chia seeds","1 tbsp honey or maple syrup","1/2 tsp vanilla extract","Toppings of your choice" },
                    Steps = new List<string> { "Combine oats, milk, yogurt, chia seeds, honey, and vanilla in a jar or container.","Stir well until everything is combined.","Seal and refrigerate overnight or for at least 6 hours.","In the morning, give it a stir. Add a splash more milk if too thick.","Top with fresh fruit, nut butter, or granola and enjoy cold." }
                },
                new Recipe
                {
                    Id = 33, Title = "Waffles with Strawberry Compote",
                    Description = "Crispy on the outside, fluffy on the inside classic waffles served with a warm homemade strawberry compote.",
                    Category = "Breakfast", ImageUrl = "https://images.unsplash.com/photo-1591530105150-9cfa92500da9?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 20, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 5, 15), Likes = 234,
                    Ingredients = new List<string> { "2 cups flour","2 tbsp sugar","2 tsp baking powder","1/2 tsp salt","2 eggs, separated","1 3/4 cups milk","1/2 cup melted butter","1 tsp vanilla","For compote: 300g strawberries, 3 tbsp sugar, 1 tbsp lemon juice" },
                    Steps = new List<string> { "Make compote: cook strawberries, sugar, and lemon juice in a pan over medium heat 10 minutes until thickened. Set aside.","Whisk flour, sugar, baking powder, and salt.","Mix egg yolks, milk, butter, and vanilla. Combine with dry ingredients.","Beat egg whites to soft peaks. Fold gently into batter.","Cook in a preheated waffle iron until golden and crispy.","Serve topped with warm strawberry compote and whipped cream." }
                },

                //ASIAN
                new Recipe
                {
                    Id = 4, Title = "Thai Green Curry",
                    Description = "Aromatic and creamy Thai green curry with vegetables and coconut milk. Bold, fragrant, and incredibly satisfying.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1707056924965-2c687206af67?q=80&w=1173&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 25, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 4, 5), Likes = 278,
                    Ingredients = new List<string> { "2 tbsp green curry paste","400ml coconut milk","500g chicken breast, sliced","1 zucchini, sliced","1 bell pepper, sliced","1 cup spinach","2 tbsp fish sauce","1 tbsp sugar","Fresh basil leaves","Jasmine rice for serving" },
                    Steps = new List<string> { "Heat oil in a wok over medium-high heat. Add curry paste and fry for 1 minute.","Add half the coconut milk and stir to combine with paste.","Add chicken and cook for 5 minutes until cooked through.","Pour in remaining coconut milk, fish sauce, and sugar.","Add zucchini and bell pepper. Simmer for 8 minutes.","Stir in spinach until wilted.","Serve over jasmine rice topped with fresh basil." }
                },
                new Recipe
                {
                    Id = 34, Title = "Chicken Ramen",
                    Description = "A rich, soul-warming Japanese ramen with soft-boiled eggs, tender chicken, and a deeply flavored broth.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1740813626726-d811be64edbf?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 40, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 4, 12), Likes = 345,
                    Ingredients = new List<string> { "4 portions ramen noodles","2 chicken breasts","1.5L chicken broth","3 tbsp soy sauce","2 tbsp miso paste","1 tbsp sesame oil","4 eggs","4 cloves garlic","Fresh ginger, 3 slices","Green onions, nori, corn, and bamboo shoots to serve" },
                    Steps = new List<string> { "Simmer chicken in broth with garlic and ginger 20 minutes. Remove chicken and shred.","Whisk miso paste into a ladleful of broth until dissolved. Return to pot.","Add soy sauce and sesame oil. Taste and adjust seasoning.","Soft-boil eggs 6.5 minutes. Cool in ice water, peel, and halve.","Cook noodles per package instructions.","Divide noodles into bowls. Ladle hot broth over. Top with chicken, egg, green onions, nori, and corn." }
                },
                new Recipe
                {
                    Id = 35, Title = "Beef Pad Thai",
                    Description = "Thailand's famous stir-fried noodle dish with tender beef, crunchy bean sprouts, and a tangy tamarind sauce.",
                    Category = "Asian", ImageUrl = "https://plus.unsplash.com/premium_photo-1664472637341-3ec829d1f4df?q=80&w=1025&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 15, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 4, 19), Likes = 289,
                    Ingredients = new List<string> { "300g flat rice noodles","300g beef sirloin, thinly sliced","3 tbsp tamarind paste","3 tbsp fish sauce","2 tbsp oyster sauce","1 tbsp sugar","2 eggs","1 cup bean sprouts","4 green onions","3 cloves garlic","Lime, peanuts, and cilantro to serve","Oil for stir-frying" },
                    Steps = new List<string> { "Soak rice noodles in warm water 20 minutes. Drain.","Mix tamarind, fish sauce, oyster sauce, and sugar for the sauce.","Stir-fry beef in hot oil over high heat until browned. Remove.","Add garlic to the wok. Add noodles and sauce. Toss quickly.","Push noodles to one side. Scramble eggs on the other side.","Add beef, bean sprouts, and green onions. Toss everything together.","Serve topped with peanuts, lime wedges, and cilantro." }
                },
                new Recipe
                {
                    Id = 36, Title = "Korean Bibimbap",
                    Description = "A vibrant Korean rice bowl topped with seasoned vegetables, beef, a fried egg, and spicy gochujang sauce.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1693429308125-3be7b105ad56?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 30, CookTimeMinutes = 20, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 4, 26), Likes = 312,
                    Ingredients = new List<string> { "4 cups cooked short-grain rice","200g ground beef","2 cups spinach","1 zucchini, julienned","1 carrot, julienned","1 cup bean sprouts","4 eggs","Gochujang sauce","Soy sauce, sesame oil, sesame seeds","Garlic and sugar" },
                    Steps = new List<string> { "Cook beef with 1 tbsp soy sauce and 1 tsp sesame oil. Set aside.","Blanch spinach 30 seconds. Squeeze dry and season with sesame oil and salt.","Stir-fry zucchini and carrot separately with garlic, soy sauce, and sesame oil.","Blanch bean sprouts 1 minute. Season with sesame oil.","Fry eggs sunny-side up.","Divide rice into bowls. Arrange all toppings. Place egg on top.","Add a dollop of gochujang. Drizzle with sesame oil. Mix everything before eating." }
                },
                new Recipe
                {
                    Id = 37, Title = "Dim Sum Har Gow",
                    Description = "Delicate steamed shrimp dumplings with thin, translucent wrappers. A Cantonese dim sum classic.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1549273963-1791d0656a05?q=80&w=764&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 45, CookTimeMinutes = 15, Servings = 4, Difficulty = "Hard",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 5, 3), Likes = 198,
                    Ingredients = new List<string> { "300g shrimp, roughly chopped","100g water chestnuts, finely diced","1 tbsp sesame oil","1 tbsp oyster sauce","1 tsp ginger, grated","For wrappers: 150g wheat starch, 50g tapioca starch, 180ml boiling water","Soy sauce for dipping" },
                    Steps = new List<string> { "Mix shrimp, water chestnuts, sesame oil, oyster sauce, and ginger. Chill.","Pour boiling water into combined starches. Mix quickly until a dough forms. Knead smooth.","Divide into small balls. Press or roll each into a thin round wrapper.","Place a teaspoon of filling in the center. Pleat and seal the edges.","Steam in a bamboo steamer over boiling water 8-10 minutes.","Serve immediately with soy sauce dipping sauce." }
                },
                new Recipe
                {
                    Id = 38, Title = "Japanese Gyoza",
                    Description = "Crispy pan-fried Japanese dumplings with a juicy pork and cabbage filling. Dip in the classic soy-vinegar sauce.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1738681336104-608b4e7dc3b0?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 30, CookTimeMinutes = 15, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 5, 10), Likes = 334,
                    Ingredients = new List<string> { "30 gyoza wrappers","300g ground pork","2 cups cabbage, finely shredded","2 cloves garlic, minced","1 tsp ginger, grated","2 tbsp soy sauce","1 tbsp sesame oil","1 tbsp mirin","Dipping sauce: soy sauce and rice vinegar" },
                    Steps = new List<string> { "Salt cabbage and let sit 5 minutes. Squeeze out all water.","Mix pork, cabbage, garlic, ginger, soy sauce, sesame oil, and mirin.","Place a teaspoon of filling in the center of each wrapper. Moisten edges.","Fold and pleat to seal tightly.","Heat oil in a pan. Add gyoza flat-side down. Cook until golden, 2 minutes.","Add 1/4 cup water, cover immediately and steam 5 minutes.","Uncover and cook until water evaporates. Serve with dipping sauce." }
                },
                new Recipe
                {
                    Id = 39, Title = "Singaporean Chicken Rice",
                    Description = "Silky poached chicken served over fragrant rice cooked in chicken fat and broth. The iconic Singaporean dish.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1639896773759-9e663d880a7b?q=80&w=754&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 50, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 5, 17), Likes = 267,
                    Ingredients = new List<string> { "1 whole chicken","2 cups jasmine rice","4 cloves garlic","Fresh ginger, 5 slices","3 stalks green onion","1 tbsp sesame oil","1 tsp salt","Chili sauce and dark soy sauce to serve","Cucumber slices to serve" },
                    Steps = new List<string> { "Rub chicken all over with salt. Stuff cavity with ginger and green onion.","Poach chicken in barely simmering water with garlic and ginger 35-40 minutes.","Remove chicken and immediately submerge in ice water 10 minutes. This gives silky skin.","Reserve poaching broth.","Fry rice with a little chicken fat and garlic 2 minutes. Add 2 cups broth. Cook until done.","Chop chicken. Serve over rice with cucumber, chili sauce, and dark soy sauce. Ladle hot broth on the side." }
                },
                new Recipe
                {
                    Id = 40, Title = "Miso Glazed Eggplant",
                    Description = "Japanese nasu dengaku — roasted eggplant with a sweet miso glaze. A simple, stunning vegetarian dish.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1706288586340-17b39437aafc?q=80&w=1171&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 10, CookTimeMinutes = 20, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 5, 24), Likes = 189,
                    Ingredients = new List<string> { "2 large eggplants","3 tbsp white miso paste","2 tbsp mirin","1 tbsp sake or dry sherry","1 tbsp sugar","1 tsp sesame oil","Sesame seeds and green onion to serve" },
                    Steps = new List<string> { "Preheat oven to 200C. Halve eggplants lengthwise. Score flesh in a crosshatch pattern.","Brush with oil. Roast cut-side down 15 minutes.","Mix miso, mirin, sake, sugar, and sesame oil to make glaze.","Flip eggplants. Brush generously with miso glaze.","Broil 3-5 minutes until glaze is caramelized and bubbly.","Garnish with sesame seeds and green onion. Serve over rice." }
                },
                new Recipe
                {
                    Id = 41, Title = "Vietnamese Pho Bo",
                    Description = "Vietnam's iconic beef noodle soup with a fragrant star anise and cinnamon broth. A labor of love worth every minute.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1631709497146-a239ef373cf1?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 180, Servings = 6, Difficulty = "Hard",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 6, 1), Likes = 412,
                    Ingredients = new List<string> { "1kg beef bones","500g beef brisket","300g rice noodles","2 onions, charred","Fresh ginger, charred","3 star anise","1 cinnamon stick","4 cloves","1 tbsp fish sauce","Toppings: bean sprouts, Thai basil, lime, hoisin sauce, sriracha" },
                    Steps = new List<string> { "Blanch bones in boiling water 5 minutes. Rinse and drain.","Char onion and ginger directly over a flame or under the broiler.","Simmer bones, brisket, charred aromatics, and spices in 3L water for 2-3 hours.","Strain broth. Slice brisket thinly. Season broth with fish sauce and salt.","Cook noodles per package instructions.","Divide noodles into bowls. Lay raw beef slices on top. Pour boiling broth over — it cooks the beef.","Serve with all toppings on the side." }
                },
                new Recipe
                {
                    Id = 42, Title = "Kung Pao Chicken",
                    Description = "A classic Sichuan stir-fry with tender chicken, crunchy peanuts, and dried chilies in a bold, tangy sauce.",
                    Category = "Asian", ImageUrl = "https://images.unsplash.com/photo-1605704931020-ba62cdb2ba9b?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 15, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 6, 8), Likes = 298,
                    Ingredients = new List<string> { "500g chicken breast, diced","1/2 cup roasted peanuts","8 dried red chilies","4 cloves garlic, minced","1 tsp ginger, minced","3 tbsp soy sauce","2 tbsp rice vinegar","1 tbsp hoisin sauce","1 tbsp sugar","1 tsp cornstarch","2 tbsp oil","Green onions to serve" },
                    Steps = new List<string> { "Marinate chicken with 1 tbsp soy sauce and cornstarch for 10 minutes.","Mix remaining soy sauce, vinegar, hoisin, and sugar for the sauce.","Stir-fry chicken in hot oil until cooked through. Remove.","Add dried chilies to the wok. Cook 30 seconds until fragrant.","Add garlic and ginger. Cook 30 seconds more.","Return chicken to the wok. Add sauce and toss to coat.","Add peanuts and green onions. Serve over rice." }
                },

                //DESSERT
                new Recipe
                {
                    Id = 5, Title = "Classic Chocolate Lava Cake",
                    Description = "Decadent individual chocolate cakes with a warm, gooey molten center. An impressive dessert ready in 30 minutes.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1617305855058-336d24456869?q=80&w=880&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 12, Servings = 4, Difficulty = "Hard",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 4, 20), Likes = 401,
                    Ingredients = new List<string> { "200g dark chocolate (70%)","150g butter","4 eggs + 4 egg yolks","150g powdered sugar","50g all-purpose flour","Cocoa powder for dusting","Vanilla ice cream for serving" },
                    Steps = new List<string> { "Preheat oven to 220C. Grease 4 ramekins and dust with cocoa powder.","Melt chocolate and butter together in a double boiler. Let cool slightly.","Beat eggs, egg yolks, and sugar together until pale and thick.","Fold chocolate mixture into egg mixture.","Sift in flour and fold until just combined.","Divide batter into ramekins. Refrigerate up to 24 hours or bake immediately.","Bake for 10-12 minutes until edges are set but center jiggles. Invert onto plates and serve immediately with ice cream." }
                },
                new Recipe
                {
                    Id = 43, Title = "Classic Tiramisu",
                    Description = "The iconic Italian dessert with layers of espresso-soaked ladyfingers and velvety mascarpone cream.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1587322740944-9bc2776404e8?q=80&w=1173&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 30, CookTimeMinutes = 0, Servings = 8, Difficulty = "Medium",
                    Author = "Chef Lucia", DatePosted = new DateTime(2026, 4, 27), Likes = 456,
                    Ingredients = new List<string> { "500g mascarpone","4 eggs, separated","100g sugar","250ml strong espresso, cooled","2 tbsp coffee liqueur or rum","24 ladyfinger biscuits","Cocoa powder for dusting" },
                    Steps = new List<string> { "Beat egg yolks and sugar until pale and thick.","Fold in mascarpone until smooth.","Beat egg whites to stiff peaks. Gently fold into mascarpone mixture.","Mix espresso and liqueur in a shallow bowl.","Quickly dip each ladyfinger in espresso — do not soak, just a quick dip.","Layer half the ladyfingers in a dish. Spread half the cream over.","Repeat layers. Dust generously with cocoa. Refrigerate at least 4 hours or overnight." }
                },
                new Recipe
                {
                    Id = 44, Title = "Crème Brûlée",
                    Description = "Silky vanilla custard beneath a perfectly caramelized sugar crust. A French classic that never gets old.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1676300184943-09b2a08319a3?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 45, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 5, 4), Likes = 367,
                    Ingredients = new List<string> { "500ml heavy cream","6 egg yolks","100g sugar","1 vanilla bean or 1 tsp vanilla extract","4 tbsp sugar for the crust" },
                    Steps = new List<string> { "Preheat oven to 150C. Split vanilla bean and scrape seeds into cream.","Heat cream until just simmering. Remove from heat.","Whisk egg yolks and sugar until pale. Slowly pour warm cream into egg mixture while whisking.","Strain through a fine sieve. Pour into 4 ramekins.","Place ramekins in a baking dish. Pour hot water halfway up the sides.","Bake 40-45 minutes until set but still slightly wobbly. Chill at least 2 hours.","Sprinkle 1 tbsp sugar over each. Torch until caramelized and serve immediately." }
                },
                new Recipe
                {
                    Id = 45, Title = "New York Cheesecake",
                    Description = "Dense, creamy, and gloriously rich New York-style cheesecake with a buttery graham cracker crust.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1611497438246-dcbb383de3c4?q=80&w=1169&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 30, CookTimeMinutes = 70, Servings = 12, Difficulty = "Hard",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 5, 11), Likes = 423,
                    Ingredients = new List<string> { "900g cream cheese, softened","200g sugar","4 eggs","200ml sour cream","1 tsp vanilla extract","For crust: 200g graham crackers, 80g melted butter, 2 tbsp sugar" },
                    Steps = new List<string> { "Crush crackers and mix with melted butter and sugar. Press into the bottom of a 23cm springform pan. Bake 10 minutes at 160C.","Beat cream cheese until smooth. Add sugar gradually.","Beat in eggs one at a time.","Mix in sour cream and vanilla.","Pour over crust. Wrap pan in foil. Bake in a water bath at 160C for 60-70 minutes.","Turn oven off. Leave cheesecake inside 1 hour with door ajar.","Refrigerate overnight before serving." }
                },
                new Recipe
                {
                    Id = 46, Title = "Sticky Toffee Pudding",
                    Description = "A British classic — moist date sponge smothered in a warm, buttery toffee sauce. Pure comfort.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1604423907382-6eaa8b5ccb3a?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 30, Servings = 8, Difficulty = "Medium",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 5, 18), Likes = 312,
                    Ingredients = new List<string> { "200g Medjool dates, pitted","250ml boiling water","1 tsp baking soda","175g flour","1 tsp baking powder","100g butter","175g brown sugar","2 eggs","For toffee sauce: 200g butter, 200g brown sugar, 200ml heavy cream" },
                    Steps = new List<string> { "Pour boiling water over dates and baking soda. Soak 10 minutes, then blend.","Cream butter and sugar. Beat in eggs one at a time.","Fold in flour, baking powder, and date mixture.","Pour into a greased baking tin. Bake at 180C for 25-30 minutes.","Make toffee sauce: melt butter and sugar, add cream, simmer 3 minutes.","Poke holes in warm pudding. Pour half the sauce over.","Serve slices with extra warm toffee sauce and vanilla ice cream." }
                },
                new Recipe
                {
                    Id = 47, Title = "Mango Panna Cotta",
                    Description = "Silky Italian panna cotta topped with a vibrant fresh mango coulis. Light, elegant, and refreshing.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1767429013015-8ea007ccf002?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 10, Servings = 6, Difficulty = "Easy",
                    Author = "Chef Lucia", DatePosted = new DateTime(2026, 5, 25), Likes = 234,
                    Ingredients = new List<string> { "500ml heavy cream","100ml milk","80g sugar","1 tsp vanilla extract","3 tsp gelatin powder","3 tbsp cold water","For mango coulis: 2 mangoes, 2 tbsp sugar, 1 tbsp lime juice" },
                    Steps = new List<string> { "Bloom gelatin in cold water for 5 minutes.","Heat cream, milk, and sugar until sugar dissolves. Do not boil.","Remove from heat. Stir in gelatin until dissolved. Add vanilla.","Pour into 6 molds or glasses. Refrigerate at least 4 hours.","Blend mango, sugar, and lime juice until smooth. Strain.","When ready to serve, unmold panna cotta or serve in glasses. Top with mango coulis." }
                },
                new Recipe
                {
                    Id = 48, Title = "Apple Tarte Tatin",
                    Description = "A stunning French upside-down caramelized apple tart with buttery, flaky pastry. Serve warm with crème fraîche.",
                    Category = "Dessert", ImageUrl = "https://plus.unsplash.com/premium_photo-1666353535417-c86616951727?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 20, CookTimeMinutes = 40, Servings = 8, Difficulty = "Hard",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 6, 1), Likes = 289,
                    Ingredients = new List<string> { "6 Golden Delicious apples","150g sugar","80g butter","1 sheet puff pastry","Crème fraîche to serve" },
                    Steps = new List<string> { "Peel, core, and quarter apples.","Melt butter and sugar in a 24cm oven-safe skillet over medium heat until caramel forms.","Arrange apple quarters tightly in the caramel, cut-side up.","Cook on the stove 10 minutes, occasionally basting with caramel.","Lay puff pastry over the apples, tucking edges down inside the pan.","Bake at 200C for 25-30 minutes until pastry is deep golden.","Cool 5 minutes, then invert onto a plate. Serve warm with crème fraîche." }
                },
                new Recipe
                {
                    Id = 49, Title = "Churros with Chocolate Sauce",
                    Description = "Crispy Spanish churros rolled in cinnamon sugar and served with a rich, thick chocolate dipping sauce.",
                    Category = "Dessert", ImageUrl = "https://images.unsplash.com/photo-1624371414361-e670edf4898d?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    PrepTimeMinutes = 15, CookTimeMinutes = 20, Servings = 6, Difficulty = "Medium",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 6, 8), Likes = 378,
                    Ingredients = new List<string> { "250ml water","120g flour","1 tbsp sugar","1/2 tsp salt","1 tbsp olive oil","Oil for frying","For coating: 100g sugar, 2 tsp cinnamon","For sauce: 200g dark chocolate, 200ml cream, 2 tbsp butter" },
                    Steps = new List<string> { "Bring water, sugar, salt, and oil to a boil. Remove from heat.","Add flour and stir vigorously until dough pulls away from the sides.","Heat oil to 180C. Pipe dough through a star-tip nozzle, cutting into 15cm lengths.","Fry 3-4 minutes until deep golden and crispy.","Drain and toss immediately in cinnamon sugar.","Make chocolate sauce: heat cream, pour over chopped chocolate and butter. Stir until smooth.","Serve churros immediately with chocolate dipping sauce." }
                },
                new Recipe
                {
                    Id = 50, Title = "Eton Mess",
                    Description = "A delightfully messy British dessert of crushed meringue, whipped cream, and fresh strawberries.",
                    Category = "Dessert", ImageUrl = "https://img.taste.com.au/Ry7-rDw5/w720-h480-cfill-q80/taste/2019/10/mixed-berry-eton-mess-taste-155102-2.jpg",
                    PrepTimeMinutes = 15, CookTimeMinutes = 0, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 6, 15), Likes = 167,
                    Ingredients = new List<string> { "400g fresh strawberries","300ml heavy cream","4 store-bought meringue nests","2 tbsp powdered sugar","1 tsp vanilla extract","Fresh mint to garnish" },
                    Steps = new List<string> { "Hull and roughly chop 300g of the strawberries. Slice remaining 100g for garnish.","Mash chopped strawberries with powdered sugar. Let sit 10 minutes to create a sauce.","Whip cream with vanilla until soft peaks form.","Break meringues into rough chunks.","Gently fold together cream, crushed meringue, and mashed strawberries — do not overmix.","Spoon into glasses. Top with sliced strawberries and mint. Serve immediately." }
                },
                new Recipe
                {
                    Id = 51, Title = "Leche Flan",
                    Description = "The beloved Filipino caramel custard — silky smooth, rich, and sweet with a deep amber caramel top.",
                    Category = "Dessert", ImageUrl = "https://www.pepper.ph/_next/image?url=https%3A%2F%2Fcdn.sanity.io%2Fimages%2Ff3knbc2s%2Fproduction%2Fe28fbcc9b8533d867ba614f42699f7f5e76790b2-2500x1500.jpg%3Fauto%3Dformat&w=1300&q=100",
                    PrepTimeMinutes = 15, CookTimeMinutes = 45, Servings = 8, Difficulty = "Medium",
                    Author = "Chef Maria", DatePosted = new DateTime(2026, 6, 22), Likes = 389,
                    Ingredients = new List<string> { "10 egg yolks","1 can condensed milk (390ml)","1 can evaporated milk (370ml)","1 tsp vanilla extract","For caramel: 200g sugar, 3 tbsp water" },
                    Steps = new List<string> { "Make caramel: heat sugar and water in a llanera or round pan until amber. Quickly coat the bottom.","Whisk egg yolks until smooth.","Add condensed milk, evaporated milk, and vanilla. Mix gently — avoid creating bubbles.","Strain custard through a fine sieve into the prepared pan.","Cover tightly with foil. Steam over low heat for 40-45 minutes until set.","Cool completely then refrigerate at least 2 hours.","Invert onto a plate to unmold. The caramel will flow over the custard." }
                },

                //SALADS
                new Recipe
                {
                    Id = 6, Title = "Fresh Garden Salad with Lemon Vinaigrette",
                    Description = "A vibrant, crunchy garden salad tossed in a bright lemon vinaigrette. Light, healthy, and ready in 10 minutes.",
                    Category = "Salads", ImageUrl = "https://cakesandcoriander.com/wp-content/uploads/2022/06/Herb-Garden-Vietnameses-Salad-9-1140x500.jpg",
                    PrepTimeMinutes = 10, CookTimeMinutes = 0, Servings = 2, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 5, 1), Likes = 134,
                    Ingredients = new List<string> { "4 cups mixed greens","1 cup cherry tomatoes, halved","1 cucumber, sliced","1/4 red onion, thinly sliced","1/4 cup olives","50g feta cheese, crumbled","Juice of 1 lemon","3 tbsp olive oil","1 tsp Dijon mustard","Salt and pepper" },
                    Steps = new List<string> { "Combine mixed greens, tomatoes, cucumber, red onion, and olives in a large bowl.","Whisk together lemon juice, olive oil, Dijon mustard, salt, and pepper.","Drizzle dressing over salad and toss gently to coat.","Top with crumbled feta cheese.","Serve immediately." }
                },
                new Recipe
                {
                    Id = 52, Title = "Caesar Salad",
                    Description = "The legendary Caesar salad with crispy romaine, house-made dressing, crunchy croutons, and shaved Parmesan.",
                    Category = "Salads", ImageUrl = "https://playswellwithbutter.com/wp-content/uploads/2024/06/Charred-Sweet-Corn-Caesar-Salad-11.jpg",
                    PrepTimeMinutes = 20, CookTimeMinutes = 10, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 5, 8), Likes = 267,
                    Ingredients = new List<string> { "2 heads romaine lettuce","100g Parmesan, shaved","For croutons: 4 slices bread, 3 tbsp olive oil, garlic powder","For dressing: 2 anchovy fillets, 2 cloves garlic, 1 egg yolk, 2 tbsp lemon juice, 1 tsp Dijon mustard, 100ml olive oil, 30g Parmesan" },
                    Steps = new List<string> { "Make croutons: cube bread, toss with oil and garlic powder. Bake at 180C until golden, 10 minutes.","Make dressing: pound anchovies and garlic into a paste. Whisk in egg yolk, lemon, and mustard. Slowly drizzle in olive oil while whisking. Stir in Parmesan. Season.","Chop romaine into bite-sized pieces. Wash and dry thoroughly.","Toss romaine with dressing until evenly coated.","Top with croutons and shaved Parmesan. Serve immediately." }
                },
                new Recipe
                {
                    Id = 53, Title = "Greek Salad",
                    Description = "A classic Greek village salad with juicy tomatoes, crisp cucumber, kalamata olives, and a generous slab of feta.",
                    Category = "Salads", ImageUrl = "https://www.primalkitchen.com/cdn/shop/articles/20240905221054-pk-greek-salad-0214-min.jpg?v=1725643684",
                    PrepTimeMinutes = 10, CookTimeMinutes = 0, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Marco", DatePosted = new DateTime(2026, 5, 15), Likes = 198,
                    Ingredients = new List<string> { "4 large tomatoes, chunked","1 large cucumber, chunked","1/2 red onion, sliced","1 cup kalamata olives","200g feta cheese, in a block","1 green bell pepper, sliced","4 tbsp extra virgin olive oil","1 tsp dried oregano","Salt and black pepper" },
                    Steps = new List<string> { "Combine tomatoes, cucumber, red onion, olives, and bell pepper in a large bowl.","Place the block of feta on top — do not crumble.","Drizzle generously with olive oil.","Sprinkle with oregano, salt, and pepper.","Serve as is, letting diners break up the feta themselves. Pairs perfectly with crusty bread." }
                },
                new Recipe
                {
                    Id = 54, Title = "Nicoise Salad",
                    Description = "The elegant French composed salad with tuna, green beans, potatoes, boiled eggs, and anchovy dressing.",
                    Category = "Salads", ImageUrl = "https://assets.bonappetit.com/photos/66573628bb9e3cf71a29c890/1:1/w_1920,c_limit/tuna-nicoise-salad_LEDE_052224_6151_VOG_final.jpg",
                    PrepTimeMinutes = 20, CookTimeMinutes = 20, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Antoine", DatePosted = new DateTime(2026, 5, 22), Likes = 178,
                    Ingredients = new List<string> { "400g tuna, grilled or canned","200g green beans, blanched","300g baby potatoes, boiled and halved","4 eggs, hard-boiled and halved","1 cup cherry tomatoes","1/2 cup kalamata olives","4 anchovy fillets","For dressing: 1 tsp Dijon, 2 tbsp red wine vinegar, 5 tbsp olive oil, 1 clove garlic" },
                    Steps = new List<string> { "Cook potatoes in salted water until tender, about 15 minutes. Cool.","Blanch green beans 3 minutes. Refresh in ice water.","Make dressing: whisk mustard, vinegar, garlic, and olive oil.","Arrange all ingredients on a large platter — do not toss, keep components separate.","Drape anchovies over the tuna.","Drizzle dressing over everything and serve at room temperature." }
                },
                new Recipe
                {
                    Id = 55, Title = "Watermelon Feta Mint Salad",
                    Description = "A refreshing summer salad of sweet watermelon, salty feta, and fresh mint with a lime honey dressing.",
                    Category = "Salads", ImageUrl = "https://www.seriouseats.com/thmb/4q2pHbYsYhMXVHEdISs3u7IMTTo=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/20210524-Watermelon-Feta-Mint-Salad-liz-voltz-seriouseats-4-cce131458da64fd2a5e64a4bf77def90.jpg",
                    PrepTimeMinutes = 10, CookTimeMinutes = 0, Servings = 6, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 5, 29), Likes = 212,
                    Ingredients = new List<string> { "1kg seedless watermelon, cubed","150g feta cheese, crumbled","1/4 cup fresh mint leaves","1/4 red onion, very thinly sliced","Juice of 1 lime","1 tbsp honey","2 tbsp olive oil","Black pepper" },
                    Steps = new List<string> { "Cube watermelon and arrange on a large platter.","Scatter feta and red onion over the watermelon.","Whisk lime juice, honey, and olive oil together.","Drizzle dressing over the salad.","Tear mint leaves and scatter over everything.","Season with black pepper. Serve immediately and very cold." }
                },
                new Recipe
                {
                    Id = 56, Title = "Thai Papaya Salad",
                    Description = "Som tum — the iconic spicy, tangy, crunchy green papaya salad from Thailand. Addictively good.",
                    Category = "Salads", ImageUrl = "https://www.seriouseats.com/thmb/yKNZ9ICJC5ZNhzcYHdHENxogpFw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/20210928-Som-Tam-Thai-green-papaya-salad-vicky-wasik-24-f0d666fc609f49a0b9f34897bd2c6303.jpg",
                    PrepTimeMinutes = 20, CookTimeMinutes = 0, Servings = 4, Difficulty = "Medium",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 6, 5), Likes = 245,
                    Ingredients = new List<string> { "1 green papaya, peeled and shredded","2 cloves garlic","2 bird's eye chilies (or to taste)","2 tbsp fish sauce","2 tbsp lime juice","1 tbsp palm sugar or brown sugar","1/2 cup cherry tomatoes, halved","1/4 cup green beans, cut into 2cm pieces","2 tbsp dried shrimp","1/4 cup roasted peanuts" },
                    Steps = new List<string> { "In a mortar, pound garlic and chilies into a rough paste.","Add green beans and lightly pound to bruise.","Add tomatoes and pound gently.","Season with fish sauce, lime juice, and sugar. Taste and adjust — it should be spicy, sour, salty, and slightly sweet.","Add shredded papaya and dried shrimp. Toss using the pestle and a spoon.","Transfer to a plate. Top with roasted peanuts. Serve with sticky rice." }
                },
                new Recipe
                {
                    Id = 57, Title = "Caprese Salad",
                    Description = "The simplest and most beautiful Italian salad — fresh mozzarella, ripe tomatoes, basil, and a drizzle of olive oil.",
                    Category = "Salads", ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/caprese-salad-recipe-2-664ceea357d6f.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
                    PrepTimeMinutes = 10, CookTimeMinutes = 0, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Lucia", DatePosted = new DateTime(2026, 6, 12), Likes = 189,
                    Ingredients = new List<string> { "4 large ripe tomatoes, sliced","400g fresh buffalo mozzarella, sliced","Large bunch of fresh basil","4 tbsp extra virgin olive oil","1 tbsp balsamic glaze","Flaky sea salt and black pepper" },
                    Steps = new List<string> { "Slice tomatoes and mozzarella to equal thickness.","Alternate slices of tomato and mozzarella on a large platter, overlapping slightly.","Tuck whole basil leaves between the slices.","Drizzle generously with your best olive oil.","Add a drizzle of balsamic glaze.","Season with flaky salt and black pepper. Serve immediately." }
                },
                new Recipe
                {
                    Id = 58, Title = "Cobb Salad",
                    Description = "An American classic — rows of chicken, bacon, blue cheese, hard-boiled eggs, and avocado on crisp lettuce.",
                    Category = "Salads", ImageUrl = "https://www.allrecipes.com/thmb/lUCXnzWTl9WOQ9NRAT08hA4O2lE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/14415-cobb-salad-DDMFS-4x3-608ba9c5768b49079eb75fe9a9898307.jpg",
                    PrepTimeMinutes = 20, CookTimeMinutes = 15, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Sarah", DatePosted = new DateTime(2026, 6, 19), Likes = 156,
                    Ingredients = new List<string> { "2 chicken breasts, grilled and sliced","6 strips bacon, cooked and crumbled","4 eggs, hard-boiled and quartered","2 avocados, sliced","100g blue cheese, crumbled","1 cup cherry tomatoes, halved","1 head romaine lettuce, chopped","Ranch or blue cheese dressing" },
                    Steps = new List<string> { "Grill chicken with salt, pepper, and a little olive oil. Slice when cooled.","Cook bacon until crispy. Drain and crumble.","Hard-boil eggs 10 minutes. Cool, peel, and quarter.","Arrange chopped lettuce as the base on a large platter.","Lay toppings in neat rows across the lettuce: chicken, bacon, eggs, avocado, blue cheese, tomatoes.","Serve with your choice of dressing on the side." }
                },
                new Recipe
                {
                    Id = 59, Title = "Quinoa and Roasted Vegetable Salad",
                    Description = "A hearty, nutritious salad with fluffy quinoa, caramelized roasted vegetables, and a lemon tahini dressing.",
                    Category = "Salads", ImageUrl = "https://gratefulgrazer.com/wp-content/uploads/2023/11/Closeup-of-Warm-Roasted-Vegetable-Quinoa-Salad.jpg",
                    PrepTimeMinutes = 15, CookTimeMinutes = 30, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Elena", DatePosted = new DateTime(2026, 6, 26), Likes = 143,
                    Ingredients = new List<string> { "1 cup quinoa","1 zucchini, diced","1 red bell pepper, diced","1 cup cherry tomatoes","1 red onion, cut into wedges","1 can chickpeas, drained","3 tbsp olive oil","For dressing: 3 tbsp tahini, 2 tbsp lemon juice, 1 clove garlic, 3 tbsp water","Salt, pepper, and cumin" },
                    Steps = new List<string> { "Preheat oven to 200C. Toss vegetables and chickpeas with olive oil, cumin, salt, and pepper.","Roast 25-30 minutes until caramelized. Toss halfway through.","Cook quinoa per package instructions. Fluff with a fork.","Make dressing: whisk tahini, lemon juice, garlic, and water until smooth.","Combine quinoa and roasted vegetables in a large bowl.","Drizzle with tahini dressing. Serve warm or at room temperature." }
                },
                new Recipe
                {
                    Id = 60, Title = "Asian Sesame Noodle Salad",
                    Description = "Cold noodles tossed in a savory sesame ginger dressing with crunchy vegetables and edamame.",
                    Category = "Salads", ImageUrl = "https://www.allrecipes.com/thmb/boPhig-uW3pugR9W24ZPykyI6wU=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/699335-0b1ff49c3ed84070bf9581f3a3aff871.jpg",
                    PrepTimeMinutes = 15, CookTimeMinutes = 10, Servings = 4, Difficulty = "Easy",
                    Author = "Chef Priya", DatePosted = new DateTime(2026, 7, 3), Likes = 198,
                    Ingredients = new List<string> { "300g soba or rice noodles","1 cup edamame, shelled","1 red bell pepper, julienned","2 carrots, julienned","3 green onions, sliced","1/4 cup cilantro","For dressing: 3 tbsp soy sauce, 2 tbsp sesame oil, 1 tbsp rice vinegar, 1 tbsp ginger, 1 tsp honey, 1 tsp sriracha","Sesame seeds and chopped peanuts" },
                    Steps = new List<string> { "Cook noodles per package instructions. Rinse under cold water until completely cool.","Whisk all dressing ingredients together.","Combine noodles, edamame, bell pepper, and carrots in a large bowl.","Pour dressing over and toss well to coat everything evenly.","Add green onions and cilantro. Toss again.","Serve topped with sesame seeds and peanuts. Can be made ahead and refrigerated." }
                }
            };
        }

        public static Recipe? GetRecipeById(int id)
            => GetAllRecipes().FirstOrDefault(r => r.Id == id);

        public static List<Recipe> GetRecipesByCategory(string category)
            => GetAllRecipes().Where(r => r.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

        public static List<string> GetCategories()
            => GetAllRecipes().Select(r => r.Category).Distinct().OrderBy(c => c).ToList();

        public static List<CookingTip> GetCookingTips()
        {
            return new List<CookingTip>
            {
                new CookingTip { Id = 1, Title = "Mise en Place", Content = "Prepare and measure all ingredients before you start cooking. This French technique prevents mistakes and makes cooking relaxed.", Icon = "🔪" },
                new CookingTip { Id = 2, Title = "Salt Your Pasta Water", Content = "Pasta water should taste like the sea. Properly salted water seasons your pasta from the inside out.", Icon = "🧂" },
                new CookingTip { Id = 3, Title = "Rest Your Meat", Content = "Always let cooked meat rest before cutting. This allows juices to redistribute, keeping your meat tender and moist.", Icon = "🥩" },
                new CookingTip { Id = 4, Title = "Room Temperature Eggs", Content = "Use room temperature eggs for baking. Cold eggs can cause batters to curdle and produce uneven results.", Icon = "🥚" },
                new CookingTip { Id = 5, Title = "Taste As You Go", Content = "Taste your food at every stage of cooking. Adjust seasoning gradually — it's easy to add more but impossible to take back.", Icon = "👨‍🍳" },
                new CookingTip { Id = 6, Title = "Sharp Knives Are Safer", Content = "A sharp knife requires less force, giving you more control. Dull knives slip and are the real danger in the kitchen.", Icon = "⚡" }
            };
        }
    }
}