using BugTracker.ProjectContext.Domain.ExceptionMessages;
using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Persons.Exceptions;

public class PersonPersonnelCodeIsRequiredException : DomainException
{
    public override string Message => PersonExceptions.PersonPersonnelCodeIsRequiredException;
}