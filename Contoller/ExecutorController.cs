using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.ViewModels;

namespace Contoller
{
    public class ExecutorController
    {
        private DBCourseWorkContext context;

        public ExecutorController(DBCourseWorkContext context)
        {
            this.context = context;
        }

        // список всех товаров
        public List<ExecutorView> GetList()
        {
            List<ExecutorView> result = context.Executors.Select(rec => new
           ExecutorView
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Experience = rec.Experience,
                CodingLevel = rec.CodingLevel,
                isBusy = rec.isBusy,
                CategoryId = rec.CategoryId
    })
            .ToList();
            return result;
        }
        // добавление нового товара
        public void AddElement(Executor model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Executor element = context.Executors.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Элемент с данным идентификатором уже существует");
                    }
                    element = new Executor
                    {
                        Id = model.Id,
                        FIO = model.FIO,
                        Experience = model.Experience,
                        CodingLevel = model.CodingLevel,
                        isBusy = model.isBusy,
                        CategoryId = model.CategoryId
                    };
                    context.Executors.Add(element);
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
                    Executor element = context.Executors.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Executors.Remove(element);
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
