namespace Youper.API.IAM.Domain.Model.Commands;

/// <summary>
///     Command to create a new user.
/// </summary>
/// <param name="Email">The email address of the user.</param>
/// <param name="PasswordHash">The hashed password for authentication.</param>
/// <param name="FullName">The full name of the user.</param>
/// <param name="Role">The role assigned to the user (e.g., 'admin', 'psychologist', 'patient').</param>
public record CreateUserCommand(string Email, string PasswordHash, string FullName, string Role);