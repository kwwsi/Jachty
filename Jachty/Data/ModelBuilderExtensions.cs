using Jachty.Models;
using Microsoft.EntityFrameworkCore;
namespace Jachty.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jacht>().HasData(
                new Jacht
                {
                    JachtID = 1,
                    Nazwa = "Bavaria30",
                    Typ = "Srodladowy",
                    Opis = "Lorem Ipsum...",
                    Cena = 400,
                    ImageName = "bavaria30.jpg"
                },
                new Jacht
                {
                    JachtID = 2,
                    Nazwa = "Bavaria31",
                    Typ = "Srodladowy",
                    Opis = "Lorem Ipsum...",
                    Cena = 500,
                    ImageName = "bavaria31.jpg"
                },
                new Jacht
                {
                    JachtID = 3,
                    Nazwa = "Bavaria32",
                    Typ = "Srodladowy",
                    Opis = "Lorem Ipsum...",
                    Cena = 600,
                    ImageName = "bavaria32.jpg"
                },
                new Jacht
                {
                    JachtID = 4,
                    Nazwa = "Bavaria50",
                    Typ = "Morski",
                    Opis = "Lorem Ipsum...",
                    Cena = 800,
                    ImageName = "bavaria50.jpg"
                },
                new Jacht
                {
                    JachtID = 5,
                    Nazwa = "Bavaria51",
                    Typ = "Morski",
                    Opis = "Lorem Ipsum...",
                    Cena = 1000,
                    ImageName = "bavaria51.jpg"
                },
                new Jacht
                {
                    JachtID = 6,
                    Nazwa = "Bavaria55",
                    Typ = "Morski",
                    Opis = "Lorem Ipsum...",
                    Cena = 1200,
                    ImageName = "bavaria55.jpg"
                }
                );
            return modelBuilder;
        }
    }
}
