
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameME
{
	public abstract class Figure
	{
		protected Rectangle rectangle;

		public Figure(InitialState initialState)
		{
			this.rectangle = new Rectangle(initialState.x, initialState.y, 32, 32);
		}

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

		public abstract void LoadContent(SpriteBatch spriteBatch);

		public abstract void Draw(SpriteBatch spriteBatch);
	}
}
