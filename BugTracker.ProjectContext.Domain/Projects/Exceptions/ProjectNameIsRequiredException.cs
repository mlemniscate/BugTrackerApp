using BugTracker.ProjectContext.Domain.ExceptionMessages;
using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Projects.Exceptions;

public class ProjectNameIsRequiredException : DomainException
{
    public override string Message => ProjectExceptins.ProjectNameIsRequiredException;
}