using System.Linq;

namespace Personal
{
    using System.Data.Entity.Migrations;
    using Context;

    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PersonalContext())
            {

                var location1 = ctx.Locations.FirstOrDefault(x => x.City.Equals("Craiova"));
                if (location1 != null)
                {
                    location1.PostalCode = "123456";
                    ctx.Locations.AddOrUpdate(location1);
                }

                ctx.SaveChanges();

                var location2 = ctx.Locations.FirstOrDefault(x => x.City.Equals("Bucuresti"));
                if (location2 != null)
                {
                    ctx.Locations.Remove(location2);
                }

                ctx.SaveChanges();
            }
        }
    }
}
