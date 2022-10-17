using Homework2Point3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Point3.Tests.TestData
{
    public  class GeneratePet
    {
        public static PetModel demoPet()
        {
            return new PetModel
            {
                id = 1231234,
                category = new Category()
                {
                    id = 0,
                    name = "DogCat"
                },
                name = "Doggy",
                photoUrls = new string[]
                    {
                        "test1",
                        "test2"
                    },
                status = "available",
                tags = new Tag[]
                    {
                        new Tag()
                        {
                           id = 0,
                           name = "pet"
                        }
                    }
            };
        }
    }
}
