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
	public class Ghost
	{
		public List<Texture2D> Player = new List<Texture2D>();
		public Rectangle GhostRect;

		Vector2 origin;
		Vector2 GhostPos;
		float rotation;


		int CurrentFrame = 0;
		int Fps = 6;
		int increase = 0;

		int direction = 3;


		public string name { get; set; }



		public int Width
		{
			get { return GhostRect.Width; }
			set { GhostRect.Width = value; }
		}
		public int Height
		{
			get { return GhostRect.Height; }
			set { GhostRect.Height = value; }
		}
		public int X
		{
			get { return GhostRect.X; }
			set { GhostRect.X = value; }
		}

		public int Y
		{
			get { return GhostRect.Y; }
			set { GhostRect.Y = value; }
		}
		public bool IsVisible { get; set; }

		public Ghost()
		{
			GhostRect = new Rectangle();
		}

		public Ghost(string Name, bool isVisible, int x, int y, int width, int height)

		{
			name = Name;
			IsVisible = isVisible;
			GhostRect = new Rectangle(x, y, width, height);
		}

		public void Update(GameTime theGameTime)
		{
			increase += theGameTime.ElapsedGameTime.Milliseconds;

			if (increase >= 1000 / Fps)
			{

				CurrentFrame = CurrentFrame == 0 ? 1 : 0;
				increase = 0;
			}


			



		



			
			

		
		}

		public void LoadImage(ContentManager theContent)
		{




			String pathName;
			for (int i = 0; i < 2; i++)
			{
				pathName = this.name + (i + 1);
				Player.Add(theContent.Load<Texture2D>(pathName));

			}
			GhostPos = new Vector2(GhostRect.X, GhostRect.Y);

		}
		public void MetDraw(SpriteBatch theSpriteBatch)
		{
			if (IsVisible && Player != null)
			{
				origin = new Vector2(Player[CurrentFrame].Width / 2, Player[CurrentFrame].Height / 2);

				//theSpriteBatch.Draw(Player[CurrentFrame], PacmanPos, PacRect, Color.White, rotation, origin, 1f, SpriteEffects.None, 0);
				theSpriteBatch.Draw(Player[CurrentFrame], GhostRect, Color.White);
			}
		}
	}
}