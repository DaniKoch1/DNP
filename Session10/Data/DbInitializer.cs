using System;
using System.Linq;
using Session10.Data.Entities;

namespace Session10.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CatContext context){
            if(context.Cats.Any())
                return; //DB has been seeded

            var cats=new Cat []{
                new Cat{Id=1, Name="Fluffy", Color="red", FavoriteDish="chicken", Price=12, Birthdate=new DateTime(2012,12,12)},
                new Cat{Id=2, Name="Juni", Color="blackAndWhite", FavoriteDish="catFood", Price=100000000, Birthdate=new DateTime(2008,06,29)},
                new Cat{Id=3, Name="Kitka", Color="blackAndWhite", FavoriteDish="catFood", Price=100000000, Birthdate=new DateTime(2004,06,27)}
            };
            foreach(Cat c in cats)
                context.Add(c);
            context.SaveChanges();
        }
        
        
    }
}