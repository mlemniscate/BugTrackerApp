using BugTracker.ProjectContext.Domain.ExceptionMessages;
using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Persons.Exceptions;

public class PersonFirstNameIsRequiredException : DomainException
{
    public override string Message => PersonExceptions.PersonFirstNameIsRequiredException;
}