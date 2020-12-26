using NUnit.Framework;
using RestaurantApp.Exceptions;
using RestaurantApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTestProject1
{
    class TablesDataHelperUnitTests
    {
        TablesDataHelper tableDataHelper;
        [SetUp]
        public void SetUp()
        {
            tableDataHelper = new TablesDataHelper();
        }

        [Test]
        public void TableDataSetupTest()
        {
            try
            {
                var tableDataHelper = new TablesDataHelper();
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void TestGetAll()
        {
            try
            {
                var tables = tableDataHelper.GetAll();
                if (!tables.Any())
                {
                    Assert.Fail();
                }
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void TestGetTableByNumber()
        {
            try
            {
                var table = tableDataHelper.GetTableByNumber(1);

                Assert.AreEqual(1, table.Number);
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void TestGetMaxSeats()
        {
            try
            {
                var maxSeats = tableDataHelper.GetTableMaxSeats(1);
                Assert.AreEqual(4, maxSeats);
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void TestAddTable()
        {
            try
            {
                tableDataHelper.AddTable(2, 2);
            }
            catch(TableAlreadyExistsException e)
            {
                Assert.Pass("table exists");
            }
            Assert.Pass();
        }
    }
}
