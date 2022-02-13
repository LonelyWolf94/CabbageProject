using CabbageProject.BusinessLogic;
using CabbageProject.Tests.SlackIntegration;
using Gurock.TestRail;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static CabbageProject.BusinessLogic.Management;
using static CabbageProject.Data.Data;

namespace CabbageProject.Tests
{
    public class Tests
    {
        private bool _isPassed = true;
        private double _expectedPercOfDiscForFruitsOnSaturday = 0.11;

        [SetUp]
        public void SetUp()
        {
            ChangePercOfDisc(DayOfWeek.Sunday);
        }

        [Test]
        public void TestDiscountForFruitsOnSunday()
        {
            try
            {
                foreach(var product in Products)
                {
                    if (product.Category == (int)Category.Fruits)
                    {
                        Assert.AreEqual(_expectedPercOfDiscForFruitsOnSaturday, product.PercentOfDiscount);
                    }
                }         
            }
            catch(AssertionException ex)
            {
                _isPassed = false;
                throw ex;
            }
        }

        [TearDown]
        public void WriteIntoTestRail()
        {
            APIClient client = new APIClient("https://oleksiimaiatskyi.testrail.io/")
            {
                User = "oleksii_maiatskyi@epam.com",
                Password = "WxQPNvGFBhH.IWwDO/zz"
            };

            if (_isPassed)
            {
                client.SendPost($"add_result_for_case/1/1", new Dictionary<string, object> { { "status_id", 1 } });
            }
            else
            {
                client.SendPost($"add_result_for_case/1/1", new Dictionary<string, object> { { "status_id", 5 } });

                IntegrationSlack.WriteIntoSlack($"Test case '1' was failed.");
            }
        }
    }
}