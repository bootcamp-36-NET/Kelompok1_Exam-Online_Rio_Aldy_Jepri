using ExamOnline.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Events> Events { set; get; }
        public DbSet<EventDetails> EventDetails { set; get; }
        public DbSet<Subjects> Subjects { set; get; }

    }
}
