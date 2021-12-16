﻿namespace DataAccessLayer.Models;

public class Bookmark
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
