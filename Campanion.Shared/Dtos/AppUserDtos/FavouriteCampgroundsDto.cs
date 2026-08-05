using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AppUserDtos
{
    public class FavouriteCampgroundsDto
    {
        public List<FavouriteCampgroundDto> FavouriteCampgrounds { get; set; } = new();

        public async Task AddFavouriteCampgroundDto(FavouriteCampgroundDto favCampgroundDto)
        {
            this.FavouriteCampgrounds.Add(favCampgroundDto);
        }
    }
}
