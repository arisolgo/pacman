using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MonoGameME
{
	public class Sprite
	{
		public Texture2D texture;
		public Rectangle rectangle;

		public string Name { get; set; }

		public int Width
		{
			get { return rectangle.Width; }
			set { rectangle.Width = value; }
		}
		public int Height
		{
			get { return rectangle.Height; }
			set { rectangle.Height = value; }
		}
		public int X
		{
			get { return rectangle.X; }
			set { rectangle.X = value; }
		}

		public int Y
		{
			get { return rectangle.Y; }
			set { rectangle.Y = value; }
		}
		public bool IsVisible { get; set; }

		public Sprite()
		{
			rectangle = new Rectangle();
		}

		public Sprite(String name, bool isVisible, int x, int y, int width, int height )

		{
			Name = name;
			IsVisible = isVisible;
			rectangle = new Rectangle(x, y, width, height);
		}
		public void LoadImage(ContentManager theContent)
		{
			if (!string.IsNullOrEmpty(Name))
			{
				try
				{
					texture = theContent.Load<Texture2D>(Name);
				}
				catch (Exception ex)
				{
					throw ex;
				}
				
			}

		}

		public void MetDraw(SpriteBatch theSpriteBatch)
		{
			if(IsVisible && texture!= null)
			{
				theSpriteBatch.Draw(texture, rectangle, Color.White);
			}
		}
	}

}
