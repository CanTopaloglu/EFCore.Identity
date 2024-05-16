namespace EFCore.Identity.DTOs;

public sealed record RegisterDto(
    string Email,
    string UserName,
    string FirstName,
    string LastName,
    string Password);
