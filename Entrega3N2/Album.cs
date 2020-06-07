using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3N2
{
    [Serializable]
    public class Album
    {
        private string Name;
        private List<Song> SongList;
        private string CoverPhoto;

        public Album(string name)
        {
            Name = name;
        }

        public void AddSong(Song song)
        {
            SongList.Add(song); //Event?
        }

        public string GetName
        {
            get
            {
                return Name;
            }
        }
    }
}
