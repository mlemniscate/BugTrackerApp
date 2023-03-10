using BugTracker.ProjectContext.Domain.ExceptionMessages;
using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Projects.Exceptions;

public class ProjectNameTooLongException : DomainException
{
    public override string Message => ProjectExceptins.ProjectNameTooLongException;
}