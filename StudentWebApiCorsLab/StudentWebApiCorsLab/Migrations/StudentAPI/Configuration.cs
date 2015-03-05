namespace StudentWebApiCorsLab.Migrations.StudentAPI
{
    using StudentWebApiCorsLab.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentWebApiCorsLab.Models.StudentApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentAPI";
        }

        protected override void Seed(StudentWebApiCorsLab.Models.StudentApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var students = new List<Student>
            {
                new Student {   StudentId = "A00111111",
                                FirstName = "John",
                                LastName = "Archer",
                                Program = "CIT"},
                new Student {   StudentId = "A00222222",
                                FirstName = "Jane",
                                LastName = "Baker",
                                Program = "CST"},
                new Student {   StudentId = "A00333333",
                                FirstName = "Bill",
                                LastName = "Carter",
                                Program = "BTECH"},
                new Student {   StudentId = "A00444444",
                                FirstName = "Judy",
                                LastName = "Fisher",
                                Program = "Nursing"}

            };

            students.ForEach(s => context.Students.AddOrUpdate(p => p.StudentId, s));
            context.SaveChanges();
        }
    }
}
