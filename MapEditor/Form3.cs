using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
	public partial class Form3 : Form
	{
		Bitmap image;
		Bitmap imageResult;
		String fileName;
		int mapWidth;
		int mapHeight;
		string[,] imageStringCell;
		Color[,] imageStringCellColor;
		
		Dictionary<int, string[,]> imageStringRow;
		
		Dictionary<int, Color[,]> imageStringRowColor;
		
		//Dictionary<int, int[,]> imageStringRowPosition;
		int numberRow;
		int numberColumn;
		Graphics g;
		List<int> deleteArr;
		List<string[,]> listTiles;
		List<string[,]> listTiles2;
		public Form3()
		{
			InitializeComponent();
			imageStringRow = new Dictionary<int, string[,]>();
			imageStringRowColor = new Dictionary<int, Color[,]>();
			
			g = panel1.CreateGraphics();
			deleteArr = new List<int>();
			listTiles = new List<string[,]>();
			listTiles2 = new List<string[,]>();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			int key = 0;
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Image";
			dlg.Filter = "png files (*.png)|*.png|(*.jpg)|*.jpg";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				fileName = dlg.FileName;
				image = new Bitmap(Image.FromFile(fileName));
				mapHeight = image.Height;
				mapWidth = image.Width;
				numberRow = image.Height / 16;
				numberColumn = image.Width / 16;
				for (int y = 0; y < numberRow; y++)
				{
					for (int x = 0; x < numberColumn; x++)
					{

						LoadTilePixel(image, y, x,key);
						key++;
						
					}
					
					
				}
				
				
				MessageBox.Show("Thành công! " + imageStringRow.Count, "Kết quả", MessageBoxButtons.OK);
			}

			dlg.Dispose();
		}
		public void LoadTilePixel(Bitmap img,int y,int x,int key)
		{
			int numberOfJ = y * 16 + 16;
			int numberOfI = x * 16 + 16;
			imageStringCell = new string[16, 16];
			imageStringCellColor = new Color[16, 16];
			
			int indexCellRow = 0;
			int indexCellColumn = 0;
			for (int j=y*16;j< numberOfJ; j++)
			{
				for(int i=x*16;i< numberOfI; i++)
				{
					imageStringCell[indexCellRow, indexCellColumn] =img.GetPixel(i, j).ToString();
					imageStringCellColor[indexCellRow, indexCellColumn] = img.GetPixel(i, j);
					indexCellColumn++;
				}
				indexCellRow++;
				indexCellColumn = 0;
			}
			imageStringRow.Add(key, imageStringCell);
			imageStringRowColor.Add(key, imageStringCellColor);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[,] cellImg = imageStringRow[4];
			OpenFileDialog dlgx = new OpenFileDialog();

			dlgx.Title = "Save data";
			dlgx.Filter = "text files (*.txt)|*.txt";

			if (dlgx.ShowDialog() == DialogResult.OK)
			{
				StreamWriter sw = new StreamWriter(dlgx.FileName);

				for (int y = 0; y < 16; y++)
				{
					for (int x = 0; x < 16; x++)
					{

						sw.Write(cellImg[x, y] + "\t");
					}
					sw.Write('\n');
				}

				sw.Close();
			}

			dlgx.Dispose();
		}
		public void DrawTile()
		{

			
			int index = 0;
			Bitmap bitmap = new Bitmap(mapWidth, mapHeight);
			foreach (int key in imageStringRowColor.Keys)
			{

				
				int currentRow = key / (mapWidth/16);
				int currentColumn = key - (currentRow* (mapWidth / 16));
				int startIndexWidth = currentColumn * 16;
				int startIndexHeight = currentRow * 16;
				Color[,] value = imageStringRowColor[key];
				for (int i= startIndexHeight; i< startIndexHeight + 16;i++)
				{
					for (int j = startIndexWidth; j < startIndexWidth + 16; j++)
					{

						bitmap.SetPixel(j, i, value[i-startIndexHeight, j- startIndexWidth]);
					}
				}
				
				//index++;
				//if (index == 6) return;
			}
			g.DrawImage(bitmap, 0, 0);
			imageResult = bitmap;

		}
		public bool Compare2Tiles(string[,] tile1, string[,] tile2)
		{
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					if (tile1[i, j] != tile2[i, j])
						return false;
				}
			}
			return true;
		}
		public void CompareTiles()
		{
			int count = imageStringRow.Count;
			for (int i=0;i< count - 1;i++)
			{
				
					for (int j = i + 1; j < count; j++)
					{
					
						if(!deleteArr.Contains(i)||!deleteArr.Contains(j))
						{
							if (Compare2Tiles(imageStringRow[imageStringRow.Keys.ElementAt(i)], imageStringRow[imageStringRow.Keys.ElementAt(j)]))
							{
								
								deleteArr.Add(j);
								
							}
						}
						
					}
				
				
			}
			//Xóa
			foreach (int val in deleteArr)
			{
				imageStringRow.Remove(val);
				imageStringRowColor.Remove(val);
			}


		}
		public void CompareTiles2()
		{
			
			//foreach(string[,] value in imageStringRow.Values)
			//{
			//	listTiles.Add(value);
			//}
			//listTiles2=listTiles.GroupBy(x => x)
			//  .Where(g => g.Count() > 1)
			//  .Select(y => y.Key)
			//  .ToList();
		}
		public void Search( int left, int mid, int right)
		{
			//for (int i = left; i <= mid; i++)
			//{
			//	for (int j = mid + 1; j <= right; j++)
			//	{
			//		if (!deleteArr.Contains(i) || !deleteArr.Contains(j))
			//		{
			//			if (Compare2Tiles(imageStringRow[imageStringRow.Keys.ElementAt(i)], imageStringRow[imageStringRow.Keys.ElementAt(j)]))
			//			{

			//				deleteArr.Add(j);

			//			}
			//		}
			//}
			//}



		}

		
		private void btnFilter_Click(object sender, EventArgs e)
		{
			CompareTiles();
			//int count = imageStringRow.Count;
			//CompareTiles2();
			
			MessageBox.Show("Filter xong! " + imageStringRowColor.Count);
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			DrawTile();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			if(imageResult!=null)
			{
				e.Graphics.DrawImage(imageResult, -hScrollBar1.Value, -vScrollBar1.Value);
			}
			
		}

		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			panel1.Invalidate();
		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			panel1.Invalidate();
		}
	}
}
