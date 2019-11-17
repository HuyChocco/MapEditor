using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class Form2 : Form
    {
        static Form2 _instance;
        public static Form2 Instance()
        {
            if (_instance == null)
                _instance = new Form2();
            return _instance;
        }
        Bitmap image;
        Graphics g;
        Tile tile;
        int palletSize;

        public Form2()
        {
            InitializeComponent();
            tile = Tile.Instance();
        }

        public void GetImage(Image iImage)
        {
            image = new Bitmap(iImage);
            
            g = panel1.CreateGraphics();

            palletSize = image.Size.Width / tile.GetTileSize() > image.Size.Height / tile.GetTileSize() ?
                             image.Size.Width / tile.GetTileSize() : image.Size.Width / tile.GetTileSize();

            //TilesID = new int[palletSize];

            this.Width = image.Size.Width + 50;
            this.Height = image.Size.Height + 50;
            

            g.DrawImage(image, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int posX = e.X / tile.GetTileSize();
            int posY = e.Y / tile.GetTileSize();

            if (posX > image.Size.Width / tile.GetTileSize() || posY > image.Size.Height / tile.GetTileSize())
                return;

            RectangleF cloneRect = new RectangleF(posX * tile.GetTileSize(), posY * tile.GetTileSize(),
                                                  tile.GetTileSize(), tile.GetTileSize());

            System.Drawing.Imaging.PixelFormat format = image.PixelFormat;
            Bitmap cloneBitmap = image.Clone(cloneRect, format);           
            
            Tile.Instance().CopyTile(cloneBitmap, GetTileID(posX,posY),"");

            Form1.Instance().SetCurrentTile(cloneBitmap);
        }

        int GetTileID(int x, int y)
        {
            return x + y * palletSize;
        }

        public Bitmap GetTileByID(int id)
        {
            int posY = id / tile.GetTileSize();
            int posX = id - posY * tile.GetTileSize();

            RectangleF cloneRect = new RectangleF(posX * tile.GetTileSize(), posY * tile.GetTileSize(),
                                                  tile.GetTileSize(), tile.GetTileSize());

            System.Drawing.Imaging.PixelFormat format = image.PixelFormat;
            Bitmap cloneBitmap = image.Clone(cloneRect, format);

            return cloneBitmap;
        }
    }
}
