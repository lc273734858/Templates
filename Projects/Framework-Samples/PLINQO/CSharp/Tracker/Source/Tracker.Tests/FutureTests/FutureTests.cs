﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeSmith.Data.Linq;
using NUnit.Framework;
using Tracker.Core.Data;

namespace Tracker.Tests.FutureTests
{
    [TestFixture]
    public class FutureTests : FutureBase
    {
        [Test]
        public void SimpleTest()
        {
            var db = new TrackerDataContext();
            db.Log = Console.Out;

            // build up queries

            var q1 = db.User
                .ByEmailAddress("one@test.com")
                .Future();

            var q2 = db.Task
                .Where(t => t.Summary == "Test")
                .Future();

            // should be 2 queries 
            Assert.AreEqual(2, db.FutureQueries.Count);

            // this triggers the loading of all the future queries
            var users = q1.ToList();
            Assert.IsNotNull(users);

            // should be cleared at this point
            Assert.AreEqual(0, db.FutureQueries.Count);
            
            // this should already be loaded
            Assert.IsTrue(((IFutureQuery)q2).IsLoaded);

            var tasks = q2.ToList();
            Assert.IsNotNull(tasks);

        }

        [Test]
        public void FutureCountTest()
        {
            var db = new TrackerDataContext();
            db.Log = Console.Out;

            // build up queries

            var q1 = db.User
                .ByEmailAddress("one@test.com")
                .Future();

            var q2 = db.Task
                .Where(t => t.Summary == "Test")
                .FutureCount();

            // should be 2 queries 
            Assert.AreEqual(2, db.FutureQueries.Count);

            // this triggers the loading of all the future queries
            var users = q1.ToList();
            Assert.IsNotNull(users);

            // should be cleared at this point
            Assert.AreEqual(0, db.FutureQueries.Count);

            // this should already be loaded
            Assert.IsTrue(((IFutureQuery)q2).IsLoaded);

            int count = q2;
            Assert.Greater(count, 0);
        }

        [Test]
        public void FutureCountReverseTest()
        {
            var db = new TrackerDataContext();
            db.Log = Console.Out;

            // build up queries

            var q1 = db.User
                .ByEmailAddress("one@test.com")
                .Future();

            var q2 = db.Task
                .Where(t => t.Summary == "Test")
                .FutureCount();

            // should be 2 queries 
            Assert.AreEqual(2, db.FutureQueries.Count);

            // access q2 first to trigger loading, testing loading from FutureCount
            // this triggers the loading of all the future queries
            var count = q2.Value;
            Assert.Greater(count, 0);

            // should be cleared at this point
            Assert.AreEqual(0, db.FutureQueries.Count);

            // this should already be loaded
            Assert.IsTrue(((IFutureQuery)q1).IsLoaded);
            
            var users = q1.ToList();
            Assert.IsNotNull(users);            
        }

        [Test]
        public void FutureValueTest()
        {
            var db = new TrackerDataContext();
            db.Log = Console.Out;

            // build up queries
            var q1 = db.User
                .ByEmailAddress("one@test.com")
                .FutureFirstOrDefault();

            var q2 = db.Task
                .Where(t => t.Summary == "Test")
                .FutureCount();

            // duplicate query except count
            var q3 = db.Task
                .Where(t => t.Summary == "Test")
                .Future();

            // should be 3 queries 
            Assert.AreEqual(3, db.FutureQueries.Count);

            // this triggers the loading of all the future queries
            User user = q1;
            Assert.IsNotNull(user);

            // should be cleared at this point
            Assert.AreEqual(0, db.FutureQueries.Count);

            // this should already be loaded
            Assert.IsTrue(((IFutureQuery)q2).IsLoaded);

            var count = q2.Value;
            Assert.Greater(count, 0);

            var tasks = q3.ToList();
            Assert.IsNotNull(tasks);
        }

        [Test]
        public void FutureValueReverseTest()
        {
            var db = new TrackerDataContext();
            db.Log = Console.Out;

            // build up queries

            var q1 = db.User
                .Where(u => u.EmailAddress == "one@test.com")
                .FutureFirstOrDefault();

            var q2 = db.Task
                .Where(t => t.Summary == "Test")
                .FutureCount();

            // duplicate query except count
            var q3 = db.Task
                .Where(t => t.Summary == "Test")
                .Future();

            // should be 3 queries 
            Assert.AreEqual(3, db.FutureQueries.Count);

            // access q2 first to trigger loading, testing loading from FutureCount
            // this triggers the loading of all the future queries
            var count = q2.Value;
            Assert.Greater(count, 0);

            // should be cleared at this point
            Assert.AreEqual(0, db.FutureQueries.Count);

            // this should already be loaded
            Assert.IsTrue(((IFutureQuery)q1).IsLoaded);

            var users = q1.Value;
            Assert.IsNotNull(users);

            var tasks = q3.ToList();
            Assert.IsNotNull(tasks);

        }
    }
}
