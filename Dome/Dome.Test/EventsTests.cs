using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R201;
using Dome.R221;
using Dome.R231;
using Dome.Enum;
using Dome.R221s;

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
            createEventDto e = new createEventDto()
            {
                DOME_eventCreate = new createEventInnerDto()
                {
                    eventCategoryId = (int)EventCategory.VisiteProche,
                    eventTitle = "TEST CREA EVENT",
                    eventTimeStart = DateTime.Now,
                    eventTimeEnd = DateTime.Now.AddHours(1),
                    benefProfileId = 15,
                }
            };

            createEventResponseDto res = DomeCall.createEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void UpdateEventShouldSucceed()
        {
            eventUpdateDto e = new eventUpdateDto()
            {
                DOME_eventDatasUpdate = new eventDataUpdateDto()
                {
                    eventId = 15,
                    eventCategoryId = (int)EventCategory.RendezVous,
                    eventTitle = "TEST MODIF EVENT",
                    eventTimeStart = DateTime.Now.AddHours(1),
                    eventTimeEnd = DateTime.Now.AddHours(2),
                }
            };

            R221.domeResponseDto res = DomeCall.updateEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void UpdateEventStateShouldSucceed()
        {
            var update = new eventUpdateStateInnerDto
            {
                eventId = 15,
                eventState = (int)EventState.Realise
            };
            eventUpdateStateDto e = new eventUpdateStateDto()
            {
                DOME_eventDatasUpdate = new eventUpdateStateInnerDto[]
                {
                    update
                }
            };

            eventUpdateStateResponseDto res = DomeCall.updateEventState(e);
            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void DeleteEventShouldSucceed()
        {
            deleteEventDto e = new deleteEventDto()
            {
                eventId = 15,
            };

            R231.domeResponseDto res = DomeCall.deleteEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }
    }
}
