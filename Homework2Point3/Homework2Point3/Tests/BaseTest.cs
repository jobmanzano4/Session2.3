using Homework2Point3.DataModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Point3.Tests
{
    public  class BaseTest
    {
        public RestClient RestClient { get; set; }

        public PetModel petDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
