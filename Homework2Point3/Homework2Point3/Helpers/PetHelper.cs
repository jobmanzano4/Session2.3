using Homework2Point3.DataModels;
using Homework2Point3.Resources;
using Homework2Point3.Tests.TestData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Point3.Helpers
{
    /// <summary>
    /// Class containing all methods for pets
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new pet
        /// </summary>
        ///

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.demoPet();
            var postRequest = new RestRequest(Endpoint.PostPet());

            //Send Post Request to add new pet
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
