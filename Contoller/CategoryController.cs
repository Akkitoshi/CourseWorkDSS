using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Model.ViewModels;

namespace Contoller
{
    public class CategoryController
    {
        private DBCourseWorkContext context;

        public CategoryController(DBCourseWorkContext context)
        {
            this.context = context;
        }

        // список всех товаров
        public List<CategoryView> GetList()
        {
            List<CategoryView> result = context.Categories.Select(rec => new
           CategoryView
            {
                Id = rec.Id,
                Name = rec.Name
            })
            .ToList();
            return result;
        }
        // добавление нового товара
        public void AddElement(Category model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Category element = context.Categories.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Элемент с данным идентификатором уже существует");
                    }
                    element = new Category
                    {
                        Id = model.Id,
                        Name = model.Name
                    };
                    context.Categories.Add(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        //удалить продукт
        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Category element = context.Categories.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Categories.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
