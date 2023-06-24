using EMP_Details;
using Xunit.Sdk;

namespace EmpTest
{
    [TestClass]
    public class EmployeeTests
    {

        [TestMethod]
        public void Programmer_cal_salary()
        {
            //Arrange


            Programmer p1 = new Programmer();
            p1.Emp_Data("Amit", 50000);

            // Act
            double result = p1.calculate_salary();



            // Assert

            Assert.AreNotEqual(0, result);

        }
        [TestMethod]
        public void Manager_cal_salary()
        {
            //Arrange

            Manager m1 = new Manager();
            m1.Emp_Data("Amit", 20000);

            // Act

            double result = m1.calculate_salary();



            // Assert

            Assert.AreNotEqual(0, result);
        }
        [TestMethod]
        public void SalesExec_cal_salary()
        {
            //Arrange

            SalesExec s1 = new SalesExec();
            s1.Emp_Data("Amit", 60000);
            // Act

            double result = s1.calculate_salary();



            // Assert

            Assert.AreNotEqual(0, result);
        }


    }
}