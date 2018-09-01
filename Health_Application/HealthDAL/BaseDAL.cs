//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Web;

//namespace Health_Application.HealthDAL
//{
//    //Abstraction of all DAL class so each DAL class to inherit
//    public class BaseDal<T> where T : class, new()
//    {
//        //need to make sure one request share the same context entity
//        //DataModelContainer db = new DataModelContainer();
//        //依赖抽象编程。 好处 可以应对变化的时候，改变最小
//        public DbContext Db
//        {
//            get { return DbContextFactory.GetCurrentDbContext(); }
//        }

//        //crud


//        public IQueryable<T> GetEntites(Expression<Func<T, bool>> whereLambda)
//        {
//            return Db.Set<T>().Where(whereLambda).AsQueryable();

//        }
//        //S 方法泛型
//        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex,
//            out int total, Expression<Func<T, bool>> whereLambda,
//            Expression<Func<T, S>> orderByLambda, bool isAsc)
//        {
//            total = Db.Set<T>().Where(whereLambda).Count();
//            if (isAsc)
//            {
//                var temp = Db.Set<T>().Where(whereLambda)
//                    .OrderBy<T, S>(orderByLambda)
//                    .Skip(pageSize * (pageIndex - 1))
//                    .Take(pageSize).AsQueryable();

//                return temp;
//            }
//            else
//            {
//                var temp = Db.Set<T>().Where(whereLambda)
//                    .OrderByDescending<T, S>(orderByLambda)
//                    .Skip(pageSize * (pageIndex - 1))
//                    .Take(pageSize).AsQueryable();

//                return temp;
//            }

//        }

//        public T Add(T entity)
//        {
//            Db.Set<T>().Add(entity);
//            //Db.SaveChanges();
//            return entity;
//        }

//        public bool Update(T entity)
//        {
//            Db.Entry(entity).State = EntityState.Modified;
//            //return Db.SaveChanges() > 0;
//            return true;
//        }

//        public bool Delete(T entity)
//        {
//            Db.Entry(entity).State = EntityState.Deleted;
//            //return Db.SaveChanges() > 0;
//            return true;
//        }
//    }
//}
