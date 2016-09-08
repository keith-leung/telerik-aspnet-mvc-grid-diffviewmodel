using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp1.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Kendo.Mvc;
using System.Linq.Expressions;

namespace TelerikMvcApp1.Controllers
{
    public class TestEntitiesController : Controller
    {
        TestDbContext db = new TestDbContext();

        // GET: TestEntities
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestEntityA_Read([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<TestEntity> entities = this.GetEntityQueryable();

            var filters = request.Filters.Cast<FilterDescriptor>();

            foreach (var filter in filters)
            {
                if (filter.Member == "TitleStartWith")
                {
                    //Change the filter to this task:
                    //entities = entities.Where(m => m.Title.StartsWith(filter.Value.ToString()));
                    filter.Member = "Title";
                    filter.Operator = FilterOperator.StartsWith;
                }
                else if (filter.Member == "ContentStartWith")
                {
                    //Change the filter to this task:
                    //entities = entities.Where(m => m.Content.StartsWith(filter.Value.ToString()));
                    filter.Member = "Content";
                    filter.Operator = FilterOperator.StartsWith;
                }
            }

            //Add this condition: entities = entities.Where(m => m.Type == EntityType.A);
            request.Filters.Add(new FilterDescriptor()
            {
                Operator = FilterOperator.IsEqualTo,
                Member = "Type",
                Value = EntityType.A,
            }); 

            return Json(entities.ToDataSourceResult(request, (entity) =>
            {
                return new TestEntityViewModelA()
                {
                    TestEntityId = entity.TestEntityId,
                    TitleStartWith = entity.Title,
                    ContentStartWith = entity.Content,
                };
            }));
        }

        public ActionResult TestEntityB_Read([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<TestEntity> entities = this.GetEntityQueryable();

            var filters = request.Filters.Cast<FilterDescriptor>();

            foreach (var filter in filters)
            {
                if (filter.Member == "TitleEndWith")
                { 
                    filter.Member = "Title";
                    filter.Operator = FilterOperator.EndsWith;
                }
                else if (filter.Member == "ContentEndWith")
                { 
                    filter.Member = "Content";
                    filter.Operator = FilterOperator.EndsWith;
                }
            }

            //Add this condition: entities = entities.Where(m => m.Type == EntityType.B);
            request.Filters.Add(new FilterDescriptor()
            {
                Operator = FilterOperator.IsEqualTo,
                Member = "Type",
                Value = EntityType.B,
            });

            return Json(entities.ToDataSourceResult(request, (entity) =>
            {
                return new TestEntityViewModelB()
                {
                    TestEntityId = entity.TestEntityId,
                    TitleEndWith = entity.Title,
                    ContentEndWith = entity.Content,
                };
            }));
        }

        public ActionResult TestEntityC_Read([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<TestEntity> entities = this.GetEntityQueryable();

            var filters = request.Filters.Cast<FilterDescriptor>();

            foreach (var filter in filters)
            {
                if (filter.Member == "TitleContains")
                {
                    filter.Member = "Title";
                    filter.Operator = FilterOperator.Contains;
                }
                else if (filter.Member == "ContentContains")
                {
                    filter.Member = "Content";
                    filter.Operator = FilterOperator.Contains;
                }
            }

            //Add this condition: entities = entities.Where(m => m.Type == EntityType.C);
            request.Filters.Add(new FilterDescriptor()
            {
                Operator = FilterOperator.IsEqualTo,
                Member = "Type",
                Value = EntityType.C,
            });

            return Json(entities.ToDataSourceResult(request, (entity) =>
            {
                return new TestEntityViewModelC()
                {
                    TestEntityId = entity.TestEntityId,
                    TitleContains = entity.Title,
                    ContentContains = entity.Content,
                };
            }));
        }

        public ActionResult TestEntityD_Read([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<TestEntity> entities = this.GetEntityQueryable();

            var filters = request.Filters.Cast<FilterDescriptor>();

            foreach (var filter in filters)
            {
                if (filter.Member == "TitleNotContains")
                {
                    filter.Member = "Title";
                    filter.Operator = FilterOperator.DoesNotContain;
                }
                else if (filter.Member == "ContentNotContains")
                {
                    filter.Member = "Content";
                    filter.Operator = FilterOperator.DoesNotContain;
                }
            }

            //Add this condition: entities = entities.Where(m => m.Type == EntityType.D);
            request.Filters.Add(new FilterDescriptor()
            {
                Operator = FilterOperator.IsEqualTo,
                Member = "Type",
                Value = EntityType.D,
            });

            return Json(entities.ToDataSourceResult(request, (entity) =>
            {
                return new TestEntityViewModelD()
                {
                    TestEntityId = entity.TestEntityId,
                    TitleNotContains = entity.Title,
                    ContentNotContains = entity.Content,
                };
            }));
        }

        private IQueryable<TestEntity> GetEntityQueryable()
        {
            return db.TestEntities;
        }
    }
}