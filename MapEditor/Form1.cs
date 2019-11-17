using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
namespace MapEditor
{

    public partial class Form1 : Form
    {
        Pen pen;
        Graphics g;
        Graphics g2;
        int size;
        int tileSize;
        Image pallet;
        Bitmap backGroundImage;
        Form2 palletForm;
        Tile tile;
        bool isMouseDown;
        int opacity;

        int[] TilesData;
		List<Tile> RSTILES;
		string[] TilesDateName;
        static Form1 _instance = null;
		private BufferedGraphicsContext currentContext;
		private BufferedGraphics myBuffer;
		public static Form1 Instance()
        {
            if (_instance == null)
                _instance = new Form1();
            return _instance;
        }

        public Form1()
        {

			//currentContext = BufferedGraphicsManager.Current;
			

			RSTILES = new List<Tile>();
            InitializeComponent();
            tile = Tile.Instance();
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            size = 16;
            tileSize = 16;
            tile.SetTileSize(tileSize);
            g = panel1.CreateGraphics();
            g2 = panel2.CreateGraphics();
			//myBuffer = currentContext.Allocate(g,
			  // panel1.DisplayRectangle);
			CreateTilesData(size);
            opacity = 160;
			TilesDateName = new string[tileSize*size];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pallet = Image.FromFile(dlg.FileName);
                if (palletForm == null)
                {
                    palletForm = Form2.Instance();
                }
                palletForm.Show();
                palletForm.GetImage(pallet);
            }

            dlg.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
			//g = myBuffer.Graphics;
			e.Graphics.Clear(Color.White);
			g.SmoothingMode = SmoothingMode.AntiAlias;

			//for (int x = 0; x < size; x++)
			//{
			//    e.Graphics.DrawLine(pen, tileSize * x, tileSize * 0, tileSize * x, tileSize * (size - 1));
			//}
			//for (int y = 0; y < size; y++)
			//{
			//    e.Graphics.DrawLine(pen, 0, tileSize * y, tileSize * (size - 1), tileSize * y);
			//}
			for (int x = 0; x <= size; x++)
			{
				g.DrawLine(pen, tileSize * x - hScrollBar1.Value, -vScrollBar2.Value, tileSize * x - hScrollBar1.Value, tileSize * (size) - vScrollBar2.Value);
			}
			for (int y = 0; y <= size; y++)
			{
				g.DrawLine(pen, 0 - hScrollBar1.Value, tileSize * y - vScrollBar2.Value, tileSize * (size) - hScrollBar1.Value, tileSize * y - vScrollBar2.Value);
			}
			if (backGroundImage != null)
			{
				g.DrawImage(backGroundImage, -hScrollBar1.Value, -vScrollBar2.Value);
				
			}
			//myBuffer.Render(this.CreateGraphics());
		}

        void DrawTilesLine()
        {
			for (int x = 0; x <= size; x++)
			{
				g.DrawLine(pen, tileSize * x - hScrollBar1.Value, -vScrollBar2.Value, tileSize * x - hScrollBar1.Value, tileSize * (size) - vScrollBar2.Value);
			}
			for (int y = 0; y <= size; y++)
			{
				g.DrawLine(pen, 0 - hScrollBar1.Value, tileSize * y - vScrollBar2.Value, tileSize * (size) - hScrollBar1.Value, tileSize * y - vScrollBar2.Value);
			}
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                size = Int32.Parse(textBox1.Text);
            else
                size = 0;

            CreateTilesData(size);
			panel1.Invalidate();
			//DrawTilesLine();
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                tileSize = Int32.Parse(textBox2.Text);
            else
                tileSize = 0;
            tile.SetTileSize(tileSize);
			//DrawTilesLine();
			panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
			int posX, posY;
			//if (hScrollBar1.Value / this.tile.GetTileSize() >= 0)
			//{
				posX = (e.X+ hScrollBar1.Value >> 4) / (tile.GetTileSize() / 16);
			//}
			//else
			//{
				//posX = (e.X >> 4) / (tile.GetTileSize() / 16);
			//}
			//if(vScrollBar2.Value / this.tile.GetTileSize() >= 0)
			//{
				posY = (e.Y+ vScrollBar2.Value >> 4) / (tile.GetTileSize() / 16);
			//}
			//else
			//{
				//posY = (e.Y >> 4) / (tile.GetTileSize() / 16);
			//}
			
			int posXUpdated, posYUpdated;
			if (posX > size - 1 || posY > size - 1)
				return;
			RectangleF cloneRect = new RectangleF(posX * tile.GetTileSize(), posY * tile.GetTileSize() ,
															 tile.GetTileSize(), tile.GetTileSize());

			System.Drawing.Imaging.PixelFormat format = backGroundImage.PixelFormat;
			Bitmap cloneBitmap = backGroundImage.Clone(cloneRect, format);

			Tile.Instance().CopyTile(cloneBitmap, int.Parse(txtID.Text),txtTileName.Text);

			Bitmap tileImage = Tile.Instance().PasteTile();
			if (tileImage != null)
			{
				//g.DrawImage(tileImage, ((posX * (this.tile.GetTileSize() / 16)) << 4) - hScrollBar1.Value % this.tile.GetTileSize(), ((posY* (this.tile.GetTileSize() / 16)) << 4) - vScrollBar2.Value % this.tile.GetTileSize());
				//TilesData[posX + posY * size] = this.tile.id;
				//TilesDateName[this.tile.id] = txtTileName.Text;
				Tile tile = new Tile();
				tile.location = txtLocation.Text;
				tile.nameTile= txtTileName.Text;
				tile.id = this.tile.id;
				
				//if(hScrollBar1.Value % this.tile.GetTileSize()==0)
				//{
					posXUpdated = ((posX * (this.tile.GetTileSize() / 16)) << 4);
					lbX.Text = posXUpdated.ToString(); //+ hScrollBar1.Value).ToString();

				//}
				//else
				//{
				//posXUpdated = ((posX * (this.tile.GetTileSize() / 16)) << 4) + 0;
				//lbX.Text = (((posX * (this.tile.GetTileSize() / 16)) << 4) + 0).ToString();

				//}

				//if(vScrollBar2.Value % this.tile.GetTileSize() == 0)
				//{
				posYUpdated = ((posY * (this.tile.GetTileSize() / 16)) << 4); //+ vScrollBar2.Value;
				lbY.Text = posYUpdated.ToString();
					
				//}
				//else
				//{
					//lbY.Text = (((posY * (this.tile.GetTileSize() / 16)) << 4) + 0).ToString();
					//posYUpdated= ((posY * (this.tile.GetTileSize() / 16)) << 4) + 0;
				//}
				g.DrawImage(tileImage, posXUpdated - hScrollBar1.Value , posYUpdated - vScrollBar2.Value );
				tile.x = posXUpdated;
				tile.y = posYUpdated;
				tile.width = int.Parse(txtWidth.Text);
				tile.height = int.Parse(txtHeight.Text);
				RSTILES.Add(tile);
				//lbX.Text = (((posX * (this.tile.GetTileSize() / 16)) << 4) + hScrollBar1.Value ).ToString();
				//lbY.Text = (((posY * (this.tile.GetTileSize() / 16)) << 4) + vScrollBar2.Value ).ToString();
				//g.DrawImage(tileImage, posXUpdated, posYUpdated);
				lbW.Text = this.tile.GetTileSize().ToString();
				lbH.Text= this.tile.GetTileSize().ToString();
				DrawTilesLine();
			}
		}

        void CreateTilesData(int size)
        {
            TilesData = new int[size * size];

            for (int i = 0; i < size * size; i++)
            {
                TilesData[i] = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Save data";
            dlg.Filter = "text files (*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
				//sw.WriteLine(size + "\t" + tileSize);
				//for (int y = 0; y < size; y++)
				//{
				//    for (int x = 0; x < size; x++)
				//    {

				//        sw.Write(TilesData[x + y * size].ToString() + "\t");
				//    }
				//    sw.Write('\n');
				//}
				foreach (Tile tile in this.RSTILES)
				{
					sw.Write(tile.location + "," + tile.id.ToString() + "," + tile.nameTile + "," + tile.x.ToString() + "," + tile.y.ToString() + "," + tile.width.ToString() + "," + tile.height.ToString() + ",");
					sw.Write('\n');
				}
				sw.Close();
				//for(int i=576;i<2270;i+=16)
				//{
				//	sw.Write("" + "," + 0 + "," + "ground" + "," + i + "," + 1099 + "," + 16 + "," + 16 + ",");
				//	sw.Write('\n');
				//}
				//sw.Close();
			}

			dlg.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
			

		}

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!isMouseDown)
                //return;
			
            
        }


        public void SetCurrentTile(Bitmap image)
        {
            g2.DrawImage(new Bitmap(image, panel2.Size), 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
				Bitmap im=new Bitmap(Image.FromFile(dlg.FileName));
				backGroundImage = new Bitmap(im.Width,im.Height);

                for (int y = 0; y < im.Height; y++)
                {
                    for (int x = 0; x < im.Width;x++)
                    {
                        Color color = im.GetPixel(x, y);
                        color = Color.FromArgb(opacity, color.R, color.G, color.B);
                        backGroundImage.SetPixel(x, y, color);
                    }
                }
            }

            dlg.Dispose();

			//Draw();
			// DrawTilesLine();
			panel1.Invalidate();
			//pictureBox1.Invalidate();
		}

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
			panel1.Invalidate();
		}

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
			//Draw();
			panel1.Invalidate();
		}

        void Draw()
        {
            g.Clear(Color.White);

            if (backGroundImage != null)
            {
                //ColorMatrix colormatrix = new ColorMatrix();


                g.DrawImage(backGroundImage, -hScrollBar1.Value, 0);
            }

            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                {
                    if (TilesData[x + y * size] != -1)
                        g.DrawImage(Form2.Instance().GetTileByID(TilesData[x + y * size]),
                                    x * tile.GetTileSize() - hScrollBar1.Value, y * tile.GetTileSize());
                }

            DrawTilesLine();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            opacity = int.Parse(textBox3.Text);
        }

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			new Form3().Show();
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
		{
			panel1.Invalidate();
		}

		private void label10_Click(object sender, EventArgs e)
		{

		}
	}
}
