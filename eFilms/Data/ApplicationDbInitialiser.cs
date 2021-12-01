using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eFilms.Models;
using eFilms.Data.Enums;

namespace eFilms.Data
{
    public class ApplicationDbInitialiser
    {
        //Function to seed the database with default data
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Gets the context from the DbContext
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                //Calls a method to ensure that the database has been created
                context.Database.EnsureCreated();



                //Store
                //If no stores in the db then add some
                if (!context.Stores.Any())
                {
                    context.Stores.AddRange(new List<Store>()
                    {
                        new Store()
                        {
                            Name = "Blockbuster",
                            Description = "A description",
                            StoreLogoURL = "https://en.wikipedia.org/wiki/Blockbuster_LLC#/media/File:Blockbuster_logo.svg"
                        },
                        new Store()
                        {
                            Name = "Choices",
                            Description = "A description",
                            StoreLogoURL = "https://en.wikipedia.org/wiki/ChoicesUK#/media/File:ChoicesUK_Logo.png"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                //If no actors in the db then add some
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Robert Downey Jr.",
                            Bio = "An actor",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Robert_Downey_Jr.#/media/File:Robert_Downey_Jr_2014_Comic_Con_(cropped).jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tom Holland",
                            Bio = "An actor",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Tom_Holland#/media/File:Tom_Holland_by_Gage_Skidmore.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Chris Evans",
                            Bio = "An actor",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Chris_Evans_(actor)#/media/File:Mark_Kassen,_Tony_C%C3%A1rdenas_and_Chris_Evans_(cropped).jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tobey Maguire",
                            Bio = "An actor",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Tobey_Maguire#/media/File:Tobey_Maguire_2014.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Willem Dafoe",
                            Bio = "A Bio",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Willem_Dafoe#/media/File:Willem_Dafoe_Cannes_2019.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Directors
                //If no directors in the db then add some
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            FullName = "Jon Faverau",
                            Bio = "A director",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Jon_Favreau#/media/File:Jon_Favreau_2016.jpeg"
                        },
                        new Director()
                        {
                            FullName = "The Russo Brothers",
                            Bio = "Two directors",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Russo_brothers#/media/File:Joe_Russo_&_Anthony_Russo_by_Gage_Skidmore.jpg"
                        },
                        new Director()
                        {
                            FullName = "Sam Raimi",
                            Bio = "A directors",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Sam_Raimi#/media/File:Sam_Raimi_by_Gage_Skidmore_2.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Films
                //If no films in the db then add some
                if (!context.Films.Any())
                {
                    context.Films.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            Name = "Iron Man",
                            Description = "A film about Iron Man",
                            FilmCoverURL = "",
                            ReleaseDate = DateTime.Today,
                            Price = 9.99,
                            FilmCategory = FilmCategory.Action,
                            DirectorId = 1
                        },
                        new Film()
                        {
                            Name = "Captain America: Civil War",
                            Description = "A film about superheros",
                            FilmCoverURL = "",
                            ReleaseDate = DateTime.Today,
                            Price = 14.99,
                            FilmCategory = FilmCategory.Action,
                            DirectorId = 2
                        },
                        new Film()
                        {
                            Name = "Spider-Man",
                            Description = "The best film",
                            FilmCoverURL = "",
                            ReleaseDate = DateTime.Today,
                            Price = 999.99,
                            FilmCategory = FilmCategory.Action,
                            DirectorId = 3
                        }
                    });
                    context.SaveChanges();
                }
                //StoreFilms
                //If no storeFilms in the db then add some
                if (!context.StoreFilms.Any())
                {
                context.StoreFilms.AddRange(new List<StoreFilms>()
                    {
                        new StoreFilms()
                        {
                            FilmId = 1,
                            StoreId = 1
                        },
                        new StoreFilms()
                        {
                            FilmId = 2,
                            StoreId = 1
                        },
                        new StoreFilms()
                        {
                            FilmId = 3,
                            StoreId = 1
                        },
                        new StoreFilms()
                        {
                            FilmId = 2,
                            StoreId = 2
                        },
                        new StoreFilms()
                        {
                            FilmId = 3,
                            StoreId = 2
                        }
                    });
                    context.SaveChanges();
                }
                //FilmActors
                //If no filmActors in the db then add some
                if (!context.FilmActors.Any())
                {
                    context.FilmActors.AddRange(new List<FilmActors>()
                    {
                        new FilmActors()
                        {
                            FilmId = 1,
                            ActorId = 1
                        },
                        new FilmActors()
                        {
                            FilmId = 2,
                            ActorId = 1
                        },
                        new FilmActors()
                        {
                            FilmId = 2,
                            ActorId = 2
                        },
                        new FilmActors()
                        {
                            FilmId = 2,
                            ActorId = 3
                        },
                        new FilmActors()
                        {
                            FilmId = 3,
                            ActorId = 4
                        },
                        new FilmActors()
                        {
                            FilmId = 3,
                            ActorId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
