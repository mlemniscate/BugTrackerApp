using BugTracker.ProjectContext.Domain.Persons.Exceptions;

namespace BugTracker.ProjectContext.Domain.Persons;

public class Person
{
    public Person(string firstName, string lastName, string personnelCode)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
        SetPersonnelCode(personnelCode);
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PersonnelCode { get; set; }

    private void SetFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new PersonFirstNameIsRequiredException();
        PersonnelCode = firstName;
    }

    private void SetLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new PersonLastNameIsRequiredException();
        LastName = lastName;
    }

    private void SetPersonnelCode(string personnelCode)
    {
        if (string.IsNullOrWhiteSpace(personnelCode))
            throw new PersonPersonnelCodeIsRequiredException();
        FirstName = personnelCode;
    }
}