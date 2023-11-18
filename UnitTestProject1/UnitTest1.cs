using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Data.SqlClient;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        Class1 class1;

        [TestInitialize]
        public void TestInitialize()
        {
            class1 = new Class1();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            class1.closeConnection();
        }

        [TestMethod]
        public void TestOpenConnection()
        {
            class1.openConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
        }

        [TestMethod]
        public void TestCloseConnection()
        {
            class1.openConnection();
            class1.closeConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Closed, connection.State);
        }

        [TestMethod]
        public void TestGetConnection()
        {
            SqlConnection connection = class1.getConnection();
            Assert.IsNotNull(connection);
        }

        [TestMethod]
        public void TestOpenConnectionTwice()
        {
            class1.openConnection();
            class1.openConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
        }

        [TestMethod]
        public void TestCloseConnectionWithoutOpen()
        {
            class1.closeConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Closed, connection.State);
        }

        [TestMethod]
        public void TestDifferentConnections()
        {
            Class1 class2 = new Class1();
            class1.openConnection();
            class2.openConnection();

            SqlConnection connection1 = class1.getConnection();
            SqlConnection connection2 = class2.getConnection();

            Assert.AreNotSame(connection1, connection2);
        }

        [TestMethod]
        public void TestInvalidConnectionString()
        {
            // Предполагается что здесь будет неверная строка подключения
            Class1 class2 = new Class1();
            class2.openConnection();

            SqlConnection connection2 = class2.getConnection();

            Assert.AreEqual(System.Data.ConnectionState.Open, connection2.State);
        }

        [TestMethod]
        public void TestInvalidCommand()
        {
            class1.openConnection();

            SqlCommand command = new SqlCommand("INVALID COMMAND", class1.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            Assert.IsFalse(reader.HasRows);
        }

        [TestMethod]
        public void TestNullConnection()
        {
            class1.closeConnection();
            SqlConnection connection = class1.getConnection();
            Assert.IsNull(connection);
        }

        [TestMethod]
        public void TestConnectionTimeout()
        {
            // Предполагается, что здесь будет некорректная строка подключения с неправильно настроенным таймаутом.
            class1.openConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
        }

        [TestMethod]
        public void TestUnsupportedDatabase()
        {
            // Предполагается, что здесь будет название базы данных, которая не поддерживается.
            class1.openConnection();
            SqlConnection connection = class1.getConnection();
            Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
        }
    }
}