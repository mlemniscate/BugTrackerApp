using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Projects.Exceptions;

public class ProjectNameTooLongException : DomainException
{
    public override string Message => "Project Name cannot be longer then 50 character.";
}