using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP2084_Project_Assignment.Controllers;
using COMP2084_Project_Assignment.Data;
using COMP2084_Project_Assignment.Models;


namespace COMP2084_Project_Assignment.Tests
{
    public class EmployeesControllerTest
    {

        private DbContextOptions<ApplicationDbContext> GetTestDbOpts() 
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestEmployeesCtrllr").Options;
            
        }

    }
}
