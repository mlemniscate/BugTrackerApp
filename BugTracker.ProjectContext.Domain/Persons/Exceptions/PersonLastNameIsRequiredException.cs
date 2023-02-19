using BugTracker.ProjectContext.Domain.ExceptionMessages;
using Framework.Domain;

namespace BugTracker.ProjectContext.Domain.Persons.Exceptions;

public class PersonLastNameIsRequiredException : DomainException
{
    public override string Message => PersonExceptions.PersonLastNameIsRequiredException;
}