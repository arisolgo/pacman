using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameME
{
	public class Board
	{
		private SpriteBatch spriteBatch;

		private Pacman pacman;
		private List<Ghost> ghosts;
		private List<Point> points;
		private List<Block> blocks;

		public Board(
			InitialState pacman,
			List<InitialState> ghosts,
			List<InitialState> points, 
			List<InitialState> blocks
		)
		{
			this.pacman = new Pacman(pacman);

			this.ghosts = new List<Ghost>();
			foreach(InitialState ghost in ghosts)
			{
				this.ghosts.Add(new Ghost(ghost));
			}

			this.points = new List<Point>();
			foreach (InitialState point in points)
			{
				this.points.Add(new Point(point));
			}

			this.blocks = new List<Block>();
			foreach (InitialState block in blocks)
			{
				this.blocks.Add(new Block(block));
			}
		}

		public void LoadContent(SpriteBatch spriteBatch)
		{
			this.spriteBatch = spriteBatch;

			this.pacman.LoadContent(this.spriteBatch);
			foreach (Ghost ghost in this.ghosts)
			{
				ghost.LoadContent(this.spriteBatch);
			}
			foreach (Point point in this.points)
			{
				point.LoadContent(this.spriteBatch);
			}
			foreach (Block block in this.blocks)
			{
				block.LoadContent(this.spriteBatch);
			}
		}

		public void Update(GameTime gameTime)
		{
			// TODO
		}

		public void Draw(GameTime gameTime)
		{
			this.pacman.Draw(this.spriteBatch);
			foreach (Ghost ghost in this.ghosts)
			{
				ghost.Draw(this.spriteBatch);
			}
			foreach (Point point in this.points)
			{
				point.Draw(this.spriteBatch);
			}
			foreach (Block block in this.blocks)
			{
				block.Draw(this.spriteBatch);
			}
		}
	}
}
