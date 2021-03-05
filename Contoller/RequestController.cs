using System;
using System.Collections.Generic;
using System.Linq;
using Model.ViewModels;
using Model;

namespace Controller
{
    public class RequestController
    {
        private DSSContext context;

        public RequestController(DSSContext context)
        {
            this.context = context;
        }

        // список всех товаров
        public List<RequestView> GetList()
        {
            List<RequestView> result = context.Requests.Select(rec => new
           RequestView
            {
                Id = rec.Id,
                Theme = rec.Theme,
                CategoryId = rec.CategoryId,
                PriorityId = rec.PriorityId,
                ComplexityId = rec.ComplexityId,
                ExecutorId = rec.ExecutorId,
                Description = rec.Description
            })
            .ToList();
            return result;
        }
        // добавление нового товара
        public void AddElement(Request model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Request element = context.Requests.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Элемент с данным идентификатором уже существует");
                    }
                    element = new Request
                    {
                        Id = model.Id,
                        Theme = model.Theme,
                        CategoryId = model.CategoryId,
                        PriorityId = model.PriorityId,
                        ComplexityId = model.ComplexityId,
                        ExecutorId = model.ExecutorId,
                        Description = model.Description
                    };
                    context.Requests.Add(element);
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


        public int searchId(int id)
        {
            Request element = context.Requests.FirstOrDefault(rec => rec.Id ==
                  id);

            return element.ExecutorId;
        }

        //удалить продукт
        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Request element = context.Requests.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Requests.Remove(element);
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
