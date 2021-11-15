﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.Repositories;
public class CategoryRepository : Repository<Category>
{
    private RestaurantContext db;

    public CategoryRepository(RestaurantContext context)
    {
        db = context;
    }

    public IEnumerable<Category> GetAll()
    {
        return db.Categories;
    }

    public Category Get(int id)
    {
        return db.Categories.Find(id);
    }

    public void Create(Category category)
    {
        db.Categories.Add(category);
    }

    public void Update(Category category)
    {
        db.Entry(category).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        Category? category = db.Categories.Find(id);

        if (category != null) db.Categories.Remove(category);
    }
}
