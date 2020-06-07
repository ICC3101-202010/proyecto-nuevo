using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3N2
{
    [Serializable]
    public class Playlist
    {
        private string Name;
        private bool PrivateList;
        private List<Media> PList;
        private string CreatedBy;

        public Playlist(string name, bool privateList, string createdBy)
        {

            Name = name;
            List<Media> pList = new List<Media>();
            PList = pList;
            PrivateList = privateList;
            CreatedBy = createdBy;

        }


        public string GetName() { return Name; }

        public void AddMedia(Media media)
        {
            PList.Add(media);
        }

        public List<Media> GetList()
        {
            return PList;
        }
    }
}
