﻿using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.Web;
using CodeSmith.Data.Caching;
using CodeSmith.Data.Memcached;
using NUnit.Framework;
using Tracker.Core.Data;
using CodeSmith.Data.Linq;

namespace Tracker.Memcached.Tests.CacheTests
{
    public abstract class MemcachedTestBase
    {
        private List<int> _roleIds = new List<int>();
        private Process _memcached;


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            // setup memcached
            _memcached = Process.Start(
                @"..\..\..\..\Libraries\memcached.exe",
                "-vv -p 11200");

            using (var db = new TrackerDataContext())
            {
                var role1 = new Role
                {
                    Name = "Test Role"
                };
                var role2 = new Role
                {
                    Name = "Duck Roll"
                };

                db.Role.InsertOnSubmit(role1);
                db.Role.InsertOnSubmit(role2);
                db.SubmitChanges();

                _roleIds.Add(role1.Id);
                _roleIds.Add(role2.Id);
            }
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            using (var db = new TrackerDataContext())
                db.Role.Delete(r => _roleIds.Contains(r.Id));


            if (_memcached != null)
            {
                _memcached.Kill();
                _memcached.Dispose();
            }
        }

        [SetUp]
        public void SetUp()
        {
            var keys = new List<string>();

            var enumerator = HttpRuntime.Cache.GetEnumerator();
            while (enumerator.MoveNext())
                keys.Add(enumerator.Key as string);

            keys.ForEach(k => HttpRuntime.Cache.Remove(k));
        }

        [TearDown]
        public void TearDown()
        {
            
        }
    }
}