using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Model.ViewModels;

namespace Controller
{
    public class ExecutorController
    {
        private DSSContext context;

        public ExecutorController(DSSContext context)
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
                CategoryName = rec.CategoryName
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
                        CategoryName = model.CategoryName
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

        public void UpdElement(string FIO, bool isBusy)
        {
            Executor element = context.Executors.First(rec => rec.FIO ==
          FIO);
            element.isBusy = isBusy;
            context.SaveChanges();
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

        public int searchId(string Name)
        {
            Executor element = context.Executors.FirstOrDefault(rec => rec.FIO ==
                  Name);

            return element.Id;
        }

        public string searchFIO(int id)
        {
            Category element = context.Categories.FirstOrDefault(rec => rec.Id ==
                  id);

            return element.Name;
        }


        /*  public string DSS (string category, string priority, string complexity)
          {
              int experiencemin;
              string Level;
              if( priority == "Низкий")
              {
                  experiencemin = 1;
              }
              if (priority == "Средний")
              {
                  experiencemin = 3;
              }
              if (priority == "Высокий")
              {
                  experiencemin = 5;
              }

              if (complexity == "Низкая")
              {
                  Level = "Junior";
              }
              if (complexity == "Средняя")
              {
                  Level = "Middle";

              }
              if (complexity == "Высокая")
              {
                  Level = "Seniour";
              }

              Executor element = context.Executors.All(rec => rec.CategoryName == category , rec.CodingLevel = 
                    Name);

              return element.FIO;
        rec => rec.CategoryName == category, 

        rec => rec.Experience >= experiencemin

          }*/


        //выборка данных 
        public List<ExecutorView> getExecutorsDss(string category, string priority, string complexity)
        {
            int experiencemin = 0;
            string Level = "default";
            if (priority == "Низкий")
            {
                experiencemin = 1;
            }
            if (priority == "Средний")
            {
                experiencemin = 3;
            }
            if (priority == "Высокий")
            {
                experiencemin = 5;
            }

            if (complexity == "Низкая")
            {
                Level = "Junior";
            }
            if (complexity == "Средняя")
            {
                Level = "Middle";

            }
            if (complexity == "Высокая")
            {
                Level = "Seniour";
            }

            List<ExecutorView> result = context.Executors.Where(rec => rec.CodingLevel == Level).Where(rec => rec.CategoryName == category).Where(rec => rec.Experience >= experiencemin).Select(rec => new
             ExecutorView
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Experience = rec.Experience,
                CodingLevel = rec.CodingLevel,
                isBusy = rec.isBusy,
                CategoryName = rec.CategoryName
            })
              .ToList();

            return result;
        }
    }
}
