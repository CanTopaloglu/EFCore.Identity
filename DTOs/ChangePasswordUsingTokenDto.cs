namespace EFCore.Identity.DTOs;

public sealed record ChangePasswordUsingTokenDto(
    string Email,
    string NewPassword,
    string Token);
