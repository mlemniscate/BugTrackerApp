using BugTracker.ProjectContext.Domain.Projects;
using BugTracker.ProjectContext.Domain.Projects.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugTracker.ProjectContext.Domain.Test.Projects;

[TestClass]
public class ProjectTest
{
    [TestMethod]
    [ExpectedException(typeof(ProjectNameTooLongException))]
    [DataRow("Lorem Ipsum comes from a latin text written in 45BC by Roman statesman, lawyer, scholar, and philosopher, Marcus Tullius Cicero.")]
    [DataRow("Lorem Ipsum comes from a latin text written in 45B.")]
    public void SetProjectNameLongerThenFiftyCharacter_Exception(string projectName)
    {
        new Project(projectName);
    }
}