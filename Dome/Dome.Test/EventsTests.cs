using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R201;
using Dome.Enum;

namespace Dome.Test
{
    [TestClass]
    public class EventsTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];

            AuthentificationHelper.Instance.connect(settings.username, settings.password);
        }

        [TestMethod]
        public void AddEventShouldSucceed()
        {
            var e = new createEventDto()
            {
                DOME_eventCreate = new createEventInnerDto()
                {
                    eventCategoryId = (int)EventCategory.VisiteProche,
                    eventTitle = "Event test",
                    eventTimeStart = DateTime.Now,
                    eventTimeEnd = DateTime.Now.AddHours(1),
                    benefProfileId = 15,

                }
            };

            createEventResponseDto res = DomeCall.createEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }
    }
}
