﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dome;
using System.Configuration;

namespace Dome.Test
{
    [TestClass]
    public class Dome
    {


        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];

        }


        [TestMethod]
        public void Authentification()
        {


            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));
        }


        [TestMethod]
        public void AuthentificationFail()
        {
            string username = "toto";
            string password = "tata";

            AuthentificationHelper.Instance.connect(username, password);

            Assert.IsFalse(AuthentificationHelper.Instance.isConnected);
            Assert.IsTrue(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));
        }








    }
}
