using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AppUserDtos
{
    public class AppUserFavouriteCampgroundsDto
    {
        public List<AppUserFavouriteCampgroundDto> FavouriteCampgrounds { get; set; } = new();

        public async Task AddFavouriteCampgroundDto(AppUserFavouriteCampgroundDto favCampgroundDto)
        {
            this.FavouriteCampgrounds.Add(favCampgroundDto);
        }
    }
}
