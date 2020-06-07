using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3N2
{
    [Serializable]
    public class Song : Media
    {

        private SongMetadata MetaData;

        public Song(string fileName) : base(fileName)
        {
            SongMetadata metadata = new SongMetadata();
            MetaData = metadata;
        }


        public override Metadata GetMetadata()
        {
            return MetaData;
        }
    }
}
