﻿using System;
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
        private int createdEventId = 0;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
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
            var DomeCall = new DomeCall();
            createEventResponseDto res = DomeCall.createEvent(e);
            Assert.IsTrue(res.statusId == 0);

            createdEventId = res.eventId;
        }

        [TestMethod]
        public void UpdateEventShouldSucceed()
        {
            Assert.IsTrue(createdEventId > 0);

            eventUpdateDto e = new eventUpdateDto()
            {
                DOME_eventDatasUpdate = new eventDataUpdateDto()
                {
                    eventId = createdEventId,
                    eventCategoryId = (int)EventCategory.RendezVous,
                    eventTitle = "TEST MODIF EVENT",
                    eventTimeStart = DateTime.Now.AddHours(1),
                    eventTimeEnd = DateTime.Now.AddHours(2),
                }
            };
            var DomeCall = new DomeCall();
            R221.domeResponseDto res = DomeCall.updateEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void UpdateEventStateShouldSucceed()
        {
            Assert.IsTrue(createdEventId > 0);

            eventUpdateStateInnerDto update = new eventUpdateStateInnerDto
            {
                eventId = createdEventId,
                eventState = (int)EventState.Realise
            };
            eventUpdateStateDto e = new eventUpdateStateDto()
            {
                DOME_eventDatasUpdate = new eventUpdateStateInnerDto[]
                {
                    update
                }
            };
            var DomeCall = new DomeCall();
            eventUpdateStateResponseDto res = DomeCall.updateEventState(e);
            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void DeleteEventShouldSucceed()
        {
            Assert.IsTrue(createdEventId > 0);

            deleteEventDto e = new deleteEventDto()
            {
                eventId = createdEventId,
            };
            var DomeCall = new DomeCall();
            R231.domeResponseDto res = DomeCall.deleteEvent(e);
            Assert.IsTrue(res.statusId == 0);
        }
    }
}