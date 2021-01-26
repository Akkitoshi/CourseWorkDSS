using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Model.ViewModels;

namespace Contoller
{
    public class PriorityController
    {
        private DBCourseWorkContext context;

        public PriorityController(DBCourseWorkContext context)
        {
            this.context = context;
        }

        // список всех товаров
        public List<PriorityView> GetList()
        {
            List<PriorityView> result = context.Priorities.Select(rec => new
           PriorityView
            {
                Id = rec.Id,
                Name = rec.Name
            })
            .ToList();
            return result;
        }
        // добавление нового товара
        public void AddElement(Priority model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Priority element = context.Priorities.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Элемент с данным идентификатором уже существует");
                    }
                    element = new Priority
                    {
                        Id = model.Id,
                        Name = model.Name
                    };
                    context.Priorities.Add(element);
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
                    Priority element = context.Priorities.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Priorities.Remove(element);
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
