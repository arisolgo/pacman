using Microsoft.Xna.Framework.Graphics;

namespace MonoGameME
{
	public abstract class Player : Figure
	{
		public enum Orientation { Up, Down, Left, Right };

		protected Texture2D texture;

		public Player(InitialState initialState) : base(initialState)
		{
			this.orientation = Orientation.Right;
		}

		public Orientation orientation
		{
			get { return orientation; }
			set { orientation = value; }
		}
	}
}
