using Youper.API.IAM.Domain.Model.Commands;

namespace Youper.API.IAM.Domain.Model.Aggregates;

/// <summary>
///     This class represents the User aggregate.
///     It encapsulates the main user attributes and construction logic.
/// </summary>
public partial class User
{
    protected User()
    {
        Email = string.Empty;
        PasswordHash = string.Empty;
        FullName = string.Empty;
        Role = string.Empty;
    }

    /// <summary>
    ///     Constructor for the User aggregate.
    /// </summary>
    /// <remarks>
    ///     The constructor is the command handler for the CreateUserCommand.
    /// </remarks>
    /// <param name="command">The CreateUserCommand command</param>
    public User(CreateUserCommand command)
    {
        Email = command.Email;
        PasswordHash = command.PasswordHash;
        FullName = command.FullName;
        Role = command.Role;
    }

    public int Id { get; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string FullName { get; private set; }
    public string Role { get; private set; }
}