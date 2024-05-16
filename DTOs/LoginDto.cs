namespace EFCore.Identity.DTOs;

public sealed record LoginDto(
    string UserNameOrEmail,
    string Password);

