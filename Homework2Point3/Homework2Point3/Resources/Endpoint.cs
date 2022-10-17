using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Point3.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>
    public class Endpoint
    {
        //Base URL
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetPetById(long petID) => $"{baseURL}/pet/{petID}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeletePetById(long petID) => $"{baseURL}/pet/{petID}";
    }
}
