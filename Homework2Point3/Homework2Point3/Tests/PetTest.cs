using Homework2Point3.DataModels;
using Homework2Point3.Helpers;
using Homework2Point3.Resources;
using RestSharp;
using System.Net;

namespace Homework2Point3.Tests
{
    [TestClass]
    public class PetTest : BaseTest
    {
        private static List<PetModel> petCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            petDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task GetPet()
        {
            //AAA
            //Arrange
            var getPetRequest = new RestRequest(Endpoint.GetPetById(petDetails.id));
            petCleanUpList.Add(petDetails);

            //Act
            var petResponse = await RestClient.ExecuteGetAsync<PetModel>(getPetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, petResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(petDetails.name, petResponse.Data.name, "Pet name did not matched");
            Assert.AreEqual(petDetails.category.id, petResponse.Data.category.id, "Pet category id did not matched");
            Assert.AreEqual(petDetails.category.name, petResponse.Data.category.name, "Pet category did not matched");
            Assert.AreEqual(petDetails.photoUrls[0], petResponse.Data.photoUrls[0], "Pet photo did not matched");
            Assert.AreEqual(petDetails.tags[0].id, petResponse.Data.tags[0].id, "Pet tag id did not matched");
            Assert.AreEqual(petDetails.tags[0].name, petResponse.Data.tags[0].name, "Pet tag did not matched");
            Assert.AreEqual(petDetails.status, petResponse.Data.status, "Pet status  did not matched");
        }

        /// <summary>
        /// Cleaning up all posted pet in API
        /// </summary>
        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(Endpoint.GetPetById(petDetails.id));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }
    }
}