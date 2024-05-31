
using System.Data.Common;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here

    //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id, job2.Id - 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job1.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job1.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
             Assert.AreEqual(job3.ToString(), 
             Environment.NewLine + 
             "ID: "+ job3.Id + Environment.NewLine +
             "Name: " + job3.Name + Environment.NewLine +
             "Employer: " + job3.EmployerName + Environment.NewLine +
             "Location: " + job3.EmployerLocation + Environment.NewLine +
             "Position Type: " + job3.JobType + Environment.NewLine +
             "Core Competency: " + job3.JobCoreCompetency + 
             Environment.NewLine);
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(job2.ToString(), Environment.NewLine +
            "ID: "+ job2.Id + Environment.NewLine +
            "Name: " + "Data not available" + Environment.NewLine +
            "Employer: " + "Data not available"+ Environment.NewLine +
            "Location: " + "Data not available" + Environment.NewLine +
            "Position Type: " + "Data not available"+ Environment.NewLine +
            "Core Competency: " + "Data not available" +
            Environment.NewLine);
        }

    }
}

