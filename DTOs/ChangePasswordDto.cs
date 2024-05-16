namespace EFCore.Identity.DTOs;

public sealed record ChangePasswordDto(
    Guid Id,
    string CurrentPassword,
    string NewPassword);
