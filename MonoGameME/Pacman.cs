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
	public class Pacman
	{
		public	List<Texture2D> Player = new List<Texture2D>();
		public Rectangle PacRect;
		
		Vector2 origin;
		Vector2 PacmanPos;
		float rotation;


		int CurrentFrame = 0;
		int Fps = 6;
		int increase = 0;

		int direction = 3;


		public string name { get; set; }
			


		public int Width
		{
			get { return PacRect.Width; }
			set { PacRect.Width = value; }
		}
		public int Height
		{
			get { return PacRect.Height; }
			set { PacRect.Height = value; }
		}
		public int X
		{
			get { return PacRect.X; }
			set { PacRect.X = value; }
		}

		public int Y
		{
			get { return PacRect.Y; }
			set { PacRect.Y = value; }
		}
		public bool IsVisible { get; set; }

		public Pacman()
		{
			PacRect = new Rectangle();
		}

		public Pacman(string Name,bool isVisible, int x, int y, int width, int height)

		{
			name = Name;
			IsVisible = isVisible;
			PacRect = new Rectangle(x, y, width, height);
		}

		public void Update(GameTime theGameTime)
		{
			increase += theGameTime.ElapsedGameTime.Milliseconds;

			if (increase >= 1000 / Fps)
			{
				
				CurrentFrame = CurrentFrame == 0 ? 1 : 0;
				increase = 0;
			}
		

			origin = new Vector2(PacRect.Width / 2, PacRect.Height / 2);



			int antX = PacRect.X;
			int antY = PacRect.Y;

			

			var teclado = Keyboard.GetState();

			if (teclado.IsKeyDown(Keys.Down))
			{
				direction = 1;
				rotation = 1.55f;
		
				

			}
			if (teclado.IsKeyDown(Keys.Up))
			{
				direction = 0;
				rotation = -1.55f;
				

			}
			if (teclado.IsKeyDown(Keys.Right))
			{
				direction = 3;
				rotation = 0f;
		

			}
			if (teclado.IsKeyDown(Keys.Left))
			{
				direction = 2;
				rotation = 3.15f;
			
			
			}

			switch (direction)
			{
				case 0:
					PacRect.Y -= 2;
					break;
				case 1:
					PacRect.Y += 2;
					break;
				case 2:
					PacRect.X -= 2;
					break;
				case 3:
					PacRect.X += 2;
					break;

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
			PacmanPos = new Vector2(PacRect.X, PacRect.Y);


		}

		public void MetDraw(SpriteBatch theSpriteBatch)
		{
			if (IsVisible && Player != null)
			{
				origin = new Vector2(Player[CurrentFrame].Width / 2, Player[CurrentFrame].Height / 2);

				//theSpriteBatch.Draw(Player[CurrentFrame], PacmanPos, PacRect, Color.White, rotation, origin, 1f, SpriteEffects.None, 0);
				theSpriteBatch.Draw(Player[CurrentFrame], PacRect, Color.White);
			}
		}

	

	}

}
