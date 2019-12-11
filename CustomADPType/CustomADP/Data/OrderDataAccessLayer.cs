using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomADP.Data;

namespace CustomADP.Data
{
    public class OrderDataAccessLayer
    {
        OrderContext db = new OrderContext();

        //To Get all Orders details   
        public DbSet<Order> GetAllOrders()
        {
            try
            {
                return db.Orders;
            }
            catch
            {
                throw;
            }
        }

        // To Add new Order record
        public void AddOrder(Order Order)
        {
            try
            {
                db.Orders.Add(Order);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Order    
        public void UpdateOrder(Order Order)
        {
            try
            {
                // db.Orders.Update(Order);
                //db.Entry(Order).State = EntityState.Detached;
                //db.Orders.Update(Order);

                //var primaryKeyValue = Order.OrderID;
                var dbData = db.Orders.Find(Order.OrderID);
                //db.Orders.Where(= )
                // var data = db.Orders.Where(or => or.OrderID == Order.OrderID).FirstOrDefault();
                if (dbData != null)
                {
                    dbData.OrderID = Order.OrderID;
                    dbData.CustomerID = Order.CustomerID;
                    dbData.EmployeeID = Order.EmployeeID;
                }
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Order    
        public Order GetOrderData(int id)
        {
            try
            {
                Order Order = db.Orders.Find(id);
                return Order;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Order    
        public void DeleteOrder(int? id)
        {
            try
            {
                Order ord = db.Orders.Find(id);
                db.Orders.Remove(ord);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void BatchUpdate(Order Changed, Order Added, object Deleted, string KeyField)
        {
            //if (Changed != null)
            //{
            //    db.Entry(Changed).State = EntityState.Modified;
            //    db.SaveChanges();
            //}
            //if (Added != null)
            //{
            //    db.Orders.Add(Added);
            //    db.SaveChanges();
            //}
            //if (Deleted != null)
            //{

            //}

            if (Changed != null)
            {
                //foreach (var rec in (IEnumerable<Order>)Changed)
                //{
                var dbData = db.Orders.Find(Changed.OrderID);
                //   Orders[0].CustomerID = rec.CustomerID;
                dbData.OrderID = Changed.OrderID;
                dbData.CustomerID = Changed.CustomerID;
                dbData.EmployeeID = Changed.EmployeeID;
                //}
            }
            if (Added != null)
            {
                foreach (var rec in (IEnumerable<Order>)Added)
                {
                    db.Orders.Add(rec);
                    //Orders.Add(rec);
                }

            }
            if (Deleted != null)
            {
                foreach (var rec in (IEnumerable<Order>)Deleted)
                {
                    //  Orders.RemoveAt(0);
                }
                Order ord = db.Orders.Find(KeyField);
                db.Orders.Remove(ord);
                db.SaveChanges();

            }
        }
    }
}