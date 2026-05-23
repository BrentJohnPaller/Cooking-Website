It's a cooking community web application built with ASP.NET Core MVC (.NET 10), designed to let food enthusiasts share and discover cooking content in a social-media-style format.
What users can do:

Register an account with a display name, profile photo, and bio
Create posts in four formats — full recipes (with ingredients, steps, photos, cook time, difficulty), embedded YouTube cooking videos, quick cooking tips, and food photos
Like and comment on any post, with support for threaded replies and liking individual comments
Delete their own posts and comments
Browse a built-in static recipe catalogue organized by category, separate from user-generated content

How it's structured:
The site runs on two data sources side by side. User-generated content (posts, comments, likes, accounts) lives in a SQLite database managed through Entity Framework Core. A separate in-memory recipe catalogue — hardcoded in RecipeService — powers the homepage's featured/latest recipes and the dedicated recipe browsing section. These two sides never mix; the catalogue is read-only and requires no login.
The social layer:
Posts show the author's name and avatar, a timestamp, like counts, and comment counts. Comments are threaded so replies nest under their parent. Both posts and comments can be liked, and likes are tracked per-user so you can't double-like. Post and comment deletion is owner-restricted — you can only remove your own content.
Authentication:
Registration and login are handled by ASP.NET Core Identity with cookie-based sessions. Password requirements are deliberately relaxed (6-character minimum, no special character rules). No email confirmation is required, so accounts are usable immediately after sign-up.
In short, it's a focused, no-frills platform where cooking enthusiasts can post recipes and tips, watch videos, and engage with a community — backed by a clean MVC architecture with a lightweight SQLite database.
