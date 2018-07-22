using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Data
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // Creamos datos Dummie
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name= "New York City",
                    Description = "The One with the Big Park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id=1,
                            Name="Central Park",
                            Description="The most visited urban park in the United States."
                        },
                      new PointOfInterestDto(){
                            Id=2,
                            Name="Empire State Building",
                            Description="A 102-story skyscrapper located in Midtown Manhattan."
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="Antwerp",
                    Description="The one with a cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id= 3,
                            Name="Cathedral of our Lady",
                            Description="A Gothic Cathedral Style, conceived by Jan and Pieter Appelmans."
                        },
                        new PointOfInterestDto(){
                            Id= 4,
                            Name="Antwerp Central Station",
                            Description="The the finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CityDto()
                {
                    Id= 3,
                    Name = "Paris",
                    Description="The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id= 5,
                            Name="Eiffel Tower",
                            Description="A wrought iron lattice on the Champ de Mars, named after Gustav Eiffel."
                        },
                        new PointOfInterestDto(){
                            Id= 6,
                            Name="The Louvre",
                            Description="The world's largers museum."
                        }
                    }
                }
            };
        }
    }
}
