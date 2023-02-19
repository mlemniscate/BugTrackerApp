using BugTracker.ProjectContext.Domain.Projects.Exceptions;
using Framework.Core.Domain;

namespace BugTracker.ProjectContext.Domain.Projects;

public class Project : BaseEntity
{
    public Project(string name)
    {
        SetProjectName(name);
    }

    public string Name { get; set; }

    public string Description { get; set; }

    private void SetProjectName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ProjectNameIsRequiredException();
        if (name.Length > 50)
            throw new ProjectNameTooLongException();

        Name = name;
    }
}