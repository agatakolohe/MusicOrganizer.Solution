using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Album
    {
        //private static List<Album> _instances = new List<Album> { };
        public string AlbumName { get; set; }
        //public int Id { get; set; }
        //public List<Artist> Artists { get; set; }

        public Album(string albumName)
        {
            AlbumName = albumName;

        }


    }
}