namespace ReservasAereas.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ReservasAereas.Models.ReservaAereaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //se habilita que se pueda eliminar los datos de una columna si esta se debe borrar, 
            //si no se habilita esta propiedad el sistema no permite realizar esta accion y sacaria error.
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ReservasAereas.Models.ReservaAereaContext";
        }

        protected override void Seed(Models.ReservaAereaContext context)
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
        }
    }
}
