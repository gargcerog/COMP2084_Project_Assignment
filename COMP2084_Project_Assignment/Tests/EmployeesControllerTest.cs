using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP2084_Project_Assignment.Controllers;
using COMP2084_Project_Assignment.Data;
using COMP2084_Project_Assignment.Models;
using System.Diagnostics;

namespace COMP2084_Project_Assignment.Tests
{
    public class EmployeesControllerTest
    {

        [Fact]
        public async Task Create_Employees_Test()
        {
            using (var testDb = new ApplicationDbContext(GetTestDbOpts()))
            {
                var testCtrl = new EmployeesController(testDb);
                var fakeEmployees = MakeFakeEmployees(3);

                // Adding new Employees
                foreach (var employee in fakeEmployees)
                {
                    var result = await testCtrl.Create(employee);
                    var resultVr = Assert.IsType<RedirectToActionResult>(result);
                    Assert.Equal("Index", resultVr.ActionName);
                }
            }
        }


        [Fact]
        public async Task Create_Employees_Invalid_Test()
        {
            using (var testDb = new ApplicationDbContext(GetTestDbOpts()))
            {
                var testCtrl = new EmployeesController(testDb);
                var fakeEmployees = MakeFakeEmployees(3);

                //Simulate an error condition in the employee creation
                testCtrl.ModelState.AddModelError("model-state-error", "The model state is invalid");

                // Adding new Employees
                foreach (var employee in fakeEmployees)
                {
                    var result = await testCtrl.Create(employee);
                    var resultVr = Assert.IsType<ViewResult>(result);

                    // Check if the returned object is of expected type
                    Assert.Equal(employee.GetType().ToString(), resultVr.Model.ToString());
                }
            }
        }


        //----------------- Additional Methods---------------------------

        // Method returns a DbContextOptions<ApplicationDbContext> object with out in memory database configurations for running the tests
        private DbContextOptions<ApplicationDbContext> GetTestDbOpts() 
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestEmployeesCtrllr").Options;
        }

        // Method generates fake employees for testing
        protected List<Employee> MakeFakeEmployees(int n)
        {
            Random random = new Random();
            var Employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Employees.Add(new Employee
                {
                    Name = $"testName{i}",
                    UserName = $"testUserName{i}",
                    PhoneNumber = $"testPhone{i}",
                    Age = random.Next(20,60)
                });
            }
            return Employees;
        }
    }
}
