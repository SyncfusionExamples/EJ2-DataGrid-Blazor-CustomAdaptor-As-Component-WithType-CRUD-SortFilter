﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomAdaptorSample.Data;

namespace CustomAdaptorSample.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\SyncfusionExamples\Grid\CustomAdaptor-withtype-sortfilter\grid1\CustomAdaptorSample\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}