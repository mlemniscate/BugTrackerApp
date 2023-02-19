using BugTracker.ProjectContext.Domain.Persons;
using BugTracker.ProjectContext.Domain.Persons.Exceptions;
using BugTracker.ProjectContext.Domain.Projects.Exceptions;
using BugTracker.ProjectContext.Domain.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugTracker.ProjectContext.Domain.Test.Persons;

[TestClass]
public class PersonTest
{
    [TestMethod]
    [ExpectedException(typeof(PersonFirstNameIsRequiredException))]
    [DataRow("")]
    [DataRow("  ")]
    [DataRow(null)]
    public void SetFirstNameNull_Exception(string firstName)
    {
        Initialize(firstName:firstName);
    }

    [TestMethod]
    [ExpectedException(typeof(PersonLastNameIsRequiredException))]
    [DataRow("")]
    [DataRow("  ")]
    [DataRow(null)]
    public void SetLastNameNull_Exception(string lastName)
    {
        Initialize(lastName:lastName);
    }

    [TestMethod]
    [ExpectedException(typeof(PersonPersonnelCodeIsRequiredException))]
    [DataRow("")]
    [DataRow("  ")]
    [DataRow(null)]
    public void SetPersonnelCodeNull_Exception(string personnelCode)
    {
        Initialize(personnelCode:personnelCode);
    }

    private void Initialize(string firstName = "Milad",
        string lastName = "Abdi",
        string personnelCode = "20120805")
    {
        new Person(firstName, lastName, personnelCode);
    }

}