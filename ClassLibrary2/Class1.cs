using System;
using Xunit;

namespace ClassLibrary2
{
    public class Class1
    {
        [Fact]
        public void idNumbershouldbeprovided()
        {
            Employee employee = new Employee();
            Assert.NotNull(employee.IdNumber);

        }
        public static void Main(string[]args)
        {

        }
    }
    class Employee
    {
        public string IdNumber { get; set; }
    }
}
