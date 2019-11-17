using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MapEditor
{
    class Tile
    {
        Bitmap tile;
        public int id;
		public string nameTile;
		public int x;
		public int y;
		public int width;
		public int height;
		public string location;
        static Tile _instance = null;
        public static Tile Instance()
        {
            if (_instance == null)
            {
                _instance = new Tile();
            }
            return _instance;
        }

        int tileSize = 0;

        public void CopyTile(Bitmap iTile, int id,string name )
        {
            tile = iTile;
            this.id = id;
			this.nameTile = name;
        }

        public void GetTileById(int id)
        {

        }

        public void SetTileSize(int size)
        {
            tileSize = size;           
        }

        public int GetTileSize()
        {
            return tileSize;
        }

        public Bitmap PasteTile()
        {
            if (tile != null)
            {
                return tile;
            }
            return null;
        }
    }
}
