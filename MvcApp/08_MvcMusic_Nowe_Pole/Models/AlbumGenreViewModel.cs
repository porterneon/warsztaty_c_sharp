using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMusic.Models
{
    public class AlbumGenreViewModel
    {
        public List<Album> Albums;
        public SelectList Genres;
        public string AlbumGenre { get; set; }
        public string SearchString { get; set; }
    }
}