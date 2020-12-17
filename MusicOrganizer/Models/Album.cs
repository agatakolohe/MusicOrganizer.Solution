using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Album
    {
        private static List<Album> _instances = new List<Album> { };
        public string AlbumName { get; set; }
        public int Id { get; set; }
        //public List<Artist> Artists { get; set; }

        public Album(string albumName)
        {
            AlbumName = albumName;
            _instances.Add(this);
            Id = _instances.Count;

        }

        public static List<Album> GetAll()
        {
            return _instances;
        }

        public static Album Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}