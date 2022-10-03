using KwekkerCommon.DTOs;
using KwekkerCommon.Models;

namespace KwekkerCommon.Utils;

public static class KwekMapper
{
    public static KwekOutputDTO KwekToOutputDto(Kwek kwek)
    {
        return new KwekOutputDTO
        {
            Id = kwek.Id,
            Text = kwek.Text,
            User = new UserOutputDTO
            {
                Username = kwek.User.Username,
                DisplayName = kwek.User.DisplayName,
                AvatarUrl = kwek.User.AvatarUrl
            },
            PostedAt = kwek.PostedAt
        };
    }
}