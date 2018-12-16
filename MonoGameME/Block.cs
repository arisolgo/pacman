using System;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameME
{
	public class Block : Figure
	{
		public Block(InitialState initialState) : base(initialState)
		{
		}

		public override void LoadContent(SpriteBatch spriteBatch)
		{
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			throw new NotImplementedException();
		}
	}
}
