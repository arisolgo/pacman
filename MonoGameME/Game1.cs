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
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;


		bool dead = false;
		int TotalHeight;
		int TotalWidht;

		SpriteFont YouWin;
		Vector2 WinFontPos;

		//Ghost States
		Ghost Red;
		Ghost RedUp;
		Ghost RedDown;
		Ghost RedLeft;
	
		//Pacman States
		Pacman pacman;
		Pacman pacmanUp;
		Pacman pacmanDown;
		Pacman pacmanLeft;

		int puntaje = 0;
		int SpriteChange = 0;

		//Tablero 

		//Bolitas
		List<Sprite> Points = new List<Sprite>();

		

		//Obstaculos
		Sprite Background;
		Sprite rect1;
		Sprite rect1_5;
		Sprite rect2;
		Sprite rect3;
		Sprite rect3_5;
		Sprite rect4;
		Sprite rect5;
		Sprite rect6;
		Sprite rect7;
		Sprite rect8;
		Sprite rect9;
		Sprite rect10;
		Sprite rect11;
		Sprite rect12;
		Sprite rect13;
		Sprite rect14;
		Sprite rect15;
		Sprite rect16;
		Sprite rect17;
		Sprite rect18;
		Sprite rect19;
		Sprite rect20;
		Sprite rect21;
		Sprite rect22;
		Sprite rect23;
		Sprite rect24;
		Sprite rect25;
		Sprite rect26;
		Sprite rect27;
		Sprite rect28;
		Sprite rect29;
		Sprite rect30;
		Sprite rect31;
		Sprite rect32;
		Sprite rect33;
		Sprite rect34;
		Sprite rect35;
		Sprite rect36;
		Sprite rect37;
		Sprite rect38;
		Sprite rect39;
		Sprite rect40;
		Sprite rect41;
		Sprite rect42;
		Sprite rect43;
		Sprite rect44;
		Sprite rect44_5;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			IsMouseVisible = true;
			Content.RootDirectory = "Content";
		}

		/// <summary>

		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{

			TotalHeight = 480;
			TotalWidht = 550;
			graphics.PreferredBackBufferHeight = TotalHeight;
			graphics.PreferredBackBufferWidth = TotalWidht;
			graphics.ApplyChanges();

			Background = new Sprite("1", true, 0, 0, 550, 480);
			pacman = new Pacman("Pacman", true, 9, 443, 36, 29);
			pacmanUp = new Pacman("PacmanUp", true, 9, 443, 36, 29);
			pacmanDown = new Pacman("PacmanDown", true, 9, 443, 36, 29);
			pacmanLeft = new Pacman("PacmanLeft", true, 9, 443, 36, 29);

			//GHOST
			Red = new Ghost("Red", true, 275, 222, 36, 29);
			RedUp = new Ghost("RedUp", true, 9, 9, 36, 29);
			RedDown = new Ghost("RedDown", true, 9, 9, 36, 29);
			RedLeft = new Ghost("RedLeft", true, 9, 9, 36, 29);

			//Pantalla de EndGame
			WinFontPos = new Vector2(TotalWidht-380, TotalHeight / 2);



			//Columna Vertical Izquierda

			Points.Add(new Sprite("Pointo", true, 124, 24 + 17, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 34, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 124, 24 + 68, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 85, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 124, 24 + 119, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 136, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 153, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 170, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 187, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 204, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 221, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 238, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 255, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 272, 7, 6));
	
			Points.Add(new Sprite("Pointo", true, 124, 24 + 306, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 323, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 340, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 357, 7, 6));
			Points.Add(new Sprite("Pointo", true, 124, 24 + 374, 7, 6));
			

			


			//Columna derecha vertical

			Points.Add(new Sprite("Pointo", true, 418, 24 + 17, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 34, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 418, 24 + 68, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 85, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 418, 24 + 119, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 136, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 153, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 170, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 187, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 204, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 221, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 238, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 255, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 272, 7, 6));	
			Points.Add(new Sprite("Pointo", true, 418, 24 + 306, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 323, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 340, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 357, 7, 6));
			Points.Add(new Sprite("Pointo", true, 418, 24 + 374, 7, 6));
			
			



			//Floor
			Points.Add(new Sprite("Pointo", true, 24, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+19, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+38, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+57, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+76, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+95, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+114, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+133, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+152, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+171, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+190, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+209, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+228, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+247, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+266, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+285, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+304, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+323, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+342, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+361, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+380, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+399, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+418, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+437, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+456, 456 , 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 456, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 456, 7, 6));

			//Top
			Points.Add(new Sprite("Pointo", true, 24, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+19, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+38, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+57, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+76, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+95, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+114, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+133, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+152, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+171, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+190, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+209, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+228, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+266, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+285, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+304, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+323, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+342, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+361, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+380, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+399, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+418, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+437, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24+456, 24 , 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 24, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 24, 7, 6));



			//Mitad Inferior
			Points.Add(new Sprite("Pointo", true, 24, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 19, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 38, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 57, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 76, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 95, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 114, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 133, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 152, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 171, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 190, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 209, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 228, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 266, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 285, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 304, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 323, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 342, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 361, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 380, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 399, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 418, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 437, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 456, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 316, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 316, 7, 6));



			// Linea de Arriba de la mitad Superior
			Points.Add(new Sprite("Pointo", true, 24, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 19, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 38, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 57, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 76, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 95, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 114, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 133, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 152, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 171, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 190, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 209, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 228, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 247, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 266, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 285, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 304, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 323, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 342, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 361, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 380, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 399, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 418, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 437, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 456, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 81, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 81, 7, 6));



			//Linea de abajo de la mitad inferior
			Points.Add(new Sprite("Pointo", true, 24, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 19, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 38, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 57, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 76, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 95, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 114, 409, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 24 + 152, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 171, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 190, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 209, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 228, 409, 7, 6));
			
			Points.Add(new Sprite("Pointo", true, 24 + 266, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 285, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 304, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 323, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 342, 409, 7, 6));
		
			Points.Add(new Sprite("Pointo", true, 24 + 380, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 399, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 418, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 437, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 456, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 409, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 409, 7, 6));




			//Mitad superior
			Points.Add(new Sprite("Pointo", true, 24, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 19, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 38, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 57, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 76, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 95, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 114, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 152, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 171, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 190, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 209, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 228, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 266, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 285, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 304, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 323, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 342, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 380, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 399, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 418, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 437, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 456, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 475, 128, 7, 6));
			Points.Add(new Sprite("Pointo", true, 24 + 494, 128, 7, 6));






			//Obstacules


			rect1 = new Sprite("Layer 2", true, 6, 5, 4, 142);
			rect1_5 = new Sprite("Layer 2.5", true, 6, 397, 3, 178);
			rect2 = new Sprite("Layer 5", true, 10, 4, 540, 3);
			rect3 = new Sprite("Layer 4", true, 538, 7, 4, 142);
			rect3_5 = new Sprite("Layer 4.5", true, 539, 302, 2, 170);
			rect4 = new Sprite("Layer 6", true, 10, 473, 540, 2);
			rect5 = new Sprite("Layer 7", true, 49, 37, 60, 31);
			rect6 = new Sprite("Layer 8", true, 147, 37, 79, 31);
			rect7 = new Sprite("Layer 11", true, 265, 5, 20, 63);
			rect8 = new Sprite("Layer 3", true, 324, 37, 79, 31);
			rect9 = new Sprite("Layer 10", true, 440, 37, 60, 31);
			rect10 = new Sprite("Layer 12", true, 49, 99, 60, 16);
			rect11 = new Sprite("Layer 13", true, 147, 99, 21, 110);
			rect12 = new Sprite("Layer 14", true, 168, 146, 58, 15);
			rect13 = new Sprite("Layer 15", true, 206, 99, 138, 16);
			rect14 = new Sprite("Layer 16", true, 264, 99, 22, 62);
			rect15 = new Sprite("Layer 35", true, 382, 99, 21, 110);
			rect16 = new Sprite("Layer 19", true, 324, 146, 58, 15);
			rect17 = new Sprite("Layer 18", true, 440, 99, 60, 16);
			rect18 = new Sprite("Layer 3", true, 0, 146, 109, 63);
			rect19 = new Sprite("Layer 23", true, 0, 240, 109, 63);
			rect20 = new Sprite("Layer 20", true, 440, 146, 109, 63);
			rect21 = new Sprite("Layer 27", true, 440, 240, 109, 63);
			rect22 = new Sprite("Layer 24", true, 147, 240, 21, 63);
			rect23 = new Sprite("Layer 26", true, 382, 240, 21, 63);
			rect24 = new Sprite("Layer 25", true, 206, 287, 138, 16);
			rect25 = new Sprite("Layer 35", true, 265, 304, 20, 46);
			rect26 = new Sprite("Layer 36", true, 147, 333, 79, 17);
			rect27 = new Sprite("Layer 28", true, 49, 333, 60, 17);
			rect28 = new Sprite("Layer 29", true, 88, 350, 21, 47);
			rect29 = new Sprite("Layer 41", true, 0, 380, 50, 17);
			rect30 = new Sprite("Layer 30", true, 49, 427, 177, 16);
			rect31 = new Sprite("Layer 33", true, 147, 380, 21, 46);
			rect32 = new Sprite("Layer 34", true, 206, 380, 138, 17);
			rect33 = new Sprite("Layer 40", true, 265, 397, 20, 46);
			rect34 = new Sprite("Layer 31", true, 324, 427, 177, 16);
			rect35 = new Sprite("Layer 32", true, 382, 380, 21, 46);
			rect36 = new Sprite("Layer 39", true, 440, 350, 21, 47);
			rect37 = new Sprite("Layer 38", true, 440, 333, 60, 17);
			rect38 = new Sprite("Layer 42", true, 500, 380, 50, 17);
			rect39 = new Sprite("Layer 37", true, 324, 333, 79, 17);
			rect40 = new Sprite("Layer 46", true, 206, 192, 12, 61);
			rect41 = new Sprite("Layer 45", true, 206, 247, 138, 7);
			rect42 = new Sprite("Layer 48", true, 332, 192, 12, 62);
			rect43 = new Sprite("Layer 44", true, 255, 194, 39, 4);
			rect44 = new Sprite("Layer 47", true, 211, 192, 44, 9);
			rect44_5 = new Sprite("Layer 49", true, 295, 192, 49, 9);







			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.

			spriteBatch = new SpriteBatch(GraphicsDevice);



			Background.LoadImage(this.Content);
			pacman.LoadImage(this.Content);
			pacmanUp.LoadImage(this.Content);
			pacmanDown.LoadImage(this.Content);
			pacmanLeft.LoadImage(this.Content);

			Red.LoadImage(this.Content);
			RedUp.LoadImage(this.Content);
			RedDown.LoadImage(this.Content);
			RedLeft.LoadImage(this.Content);





			YouWin = this.Content.Load<SpriteFont>("YouWin");


			for (int i = 0; i < Points.Count; i++)
			{
				Points[i].LoadImage(this.Content);
			}



			rect1.LoadImage(this.Content);
			rect1_5.LoadImage(this.Content);
			rect2.LoadImage(this.Content);
			rect3.LoadImage(this.Content);
			rect3_5.LoadImage(this.Content);
			rect4.LoadImage(this.Content);
			rect5.LoadImage(this.Content);
			rect6.LoadImage(this.Content);
			rect7.LoadImage(this.Content);
			rect8.LoadImage(this.Content);
			rect9.LoadImage(this.Content);
			rect10.LoadImage(this.Content);
			rect11.LoadImage(this.Content);
			rect12.LoadImage(this.Content);
			rect13.LoadImage(this.Content);
			rect14.LoadImage(this.Content);
			rect15.LoadImage(this.Content);
			rect16.LoadImage(this.Content);
			rect17.LoadImage(this.Content);
			rect18.LoadImage(this.Content);
			rect19.LoadImage(this.Content);
			rect20.LoadImage(this.Content);
			rect21.LoadImage(this.Content);
			rect22.LoadImage(this.Content);
			rect23.LoadImage(this.Content);
			rect24.LoadImage(this.Content);
			rect25.LoadImage(this.Content);
			rect26.LoadImage(this.Content);
			rect27.LoadImage(this.Content);
			rect28.LoadImage(this.Content);
			rect29.LoadImage(this.Content);
			rect30.LoadImage(this.Content);
			rect31.LoadImage(this.Content);
			rect32.LoadImage(this.Content);
			rect33.LoadImage(this.Content);
			rect34.LoadImage(this.Content);
			rect35.LoadImage(this.Content);
			rect36.LoadImage(this.Content);
			rect37.LoadImage(this.Content);
			rect38.LoadImage(this.Content);
			rect39.LoadImage(this.Content);
			rect40.LoadImage(this.Content);
			rect41.LoadImage(this.Content);
			rect42.LoadImage(this.Content);
			rect43.LoadImage(this.Content);
			rect44.LoadImage(this.Content);
			rect44_5.LoadImage(this.Content);


			// TODO: use this.Content to load your game content here
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here



			var teclado = Keyboard.GetState();

			int antX = pacman.X;
			int antY = pacman.Y;

			pacmanUp.X = antX;
			pacmanUp.Y = antY;

			pacmanDown.X = antX;
			pacmanDown.Y = antY;

			pacmanLeft.X = antX;
			pacmanLeft.Y = antY;

			int GantX = Red.X; //Ghost Anterior x
			int GantY = Red.Y;

			RedUp.X = GantX;
			RedUp.Y = GantY;

			RedDown.X = GantX;
			RedDown.Y = GantY;

			RedLeft.X = GantX;
			RedLeft.Y = GantY;

			//Movimientos del fantasma
			if(Red.X<antX)
			{
				Red.X += 1;
			}
			else if(Red.X>antX)
			{
				Red.X -= 1;
			}
			else if(Red.Y> pacman.Y)
			{
				Red.Y--;
			}
			else if (Red.Y < pacman.Y)
			{
				Red.Y++;
			}
			
			/*while (Red.X < pacman.X && Red.Y<pacman.Y)
			{
				Red.X += 1;
			}
			while (Red.X > pacman.X && Red.Y < pacman.Y)
			{
				Red.X += 1;
			}
			while (Red.Y < pacman.Y)
			{
				Red.X += 1;
			}
			while (Red.Y > pacman.Y)
			{
				Red.X += 1;
			}
			while (Red.Y > pacman.Y && Red.X > pacman.X)
			{
				Red.X += 1;
			}*/




			pacman.Update(gameTime);

			if (teclado.IsKeyDown(Keys.Down))
			{
				SpriteChange = 2;

			}
			if (teclado.IsKeyDown(Keys.Up))
			{
				SpriteChange = 1;

			}
			if (teclado.IsKeyDown(Keys.Right))
			{

				SpriteChange = 0;
			}
			if (teclado.IsKeyDown(Keys.Left))
			{

				SpriteChange = 3;

			}


			#region Collisions Tablero
			if (pacman.PacRect.Intersects(rect1.rectangle) || pacman.PacRect.Intersects(rect1_5.rectangle) || pacman.PacRect.Intersects(rect2.rectangle) || pacman.PacRect.Intersects(rect3.rectangle)
			|| pacman.PacRect.Intersects(rect3_5.rectangle) || pacman.PacRect.Intersects(rect4.rectangle) ||pacman.PacRect.Intersects(rect5.rectangle) || pacman.PacRect.Intersects(rect6.rectangle)
				|| pacman.PacRect.Intersects(rect7.rectangle) || pacman.PacRect.Intersects(rect8.rectangle) || pacman.PacRect.Intersects(rect9.rectangle)
				|| pacman.PacRect.Intersects(rect10.rectangle) || pacman.PacRect.Intersects(rect11.rectangle) || pacman.PacRect.Intersects(rect12.rectangle)
				|| pacman.PacRect.Intersects(rect13.rectangle) || pacman.PacRect.Intersects(rect14.rectangle) || pacman.PacRect.Intersects(rect15.rectangle)
				|| pacman.PacRect.Intersects(rect16.rectangle) || pacman.PacRect.Intersects(rect17.rectangle) || pacman.PacRect.Intersects(rect18.rectangle)
				|| pacman.PacRect.Intersects(rect19.rectangle) || pacman.PacRect.Intersects(rect20.rectangle) || pacman.PacRect.Intersects(rect21.rectangle)
				|| pacman.PacRect.Intersects(rect22.rectangle) || pacman.PacRect.Intersects(rect23.rectangle) || pacman.PacRect.Intersects(rect24.rectangle)
				|| pacman.PacRect.Intersects(rect25.rectangle) || pacman.PacRect.Intersects(rect26.rectangle) || pacman.PacRect.Intersects(rect27.rectangle)
				|| pacman.PacRect.Intersects(rect28.rectangle) || pacman.PacRect.Intersects(rect29.rectangle) || pacman.PacRect.Intersects(rect30.rectangle)
				|| pacman.PacRect.Intersects(rect31.rectangle) || pacman.PacRect.Intersects(rect32.rectangle) || pacman.PacRect.Intersects(rect33.rectangle)
				|| pacman.PacRect.Intersects(rect34.rectangle) || pacman.PacRect.Intersects(rect35.rectangle) || pacman.PacRect.Intersects(rect36.rectangle)
				|| pacman.PacRect.Intersects(rect37.rectangle) || pacman.PacRect.Intersects(rect38.rectangle) || pacman.PacRect.Intersects(rect39.rectangle)
				|| pacman.PacRect.Intersects(rect40.rectangle) || pacman.PacRect.Intersects(rect41.rectangle) || pacman.PacRect.Intersects(rect42.rectangle)
				|| pacman.PacRect.Intersects(rect43.rectangle) || pacman.PacRect.Intersects(rect44.rectangle) || pacman.PacRect.Intersects(rect44_5.rectangle))
			{
				pacman.X = antX;
				pacman.Y = antY;
			}

				#endregion


				#region Collisions Puntos

				for (int i = 0; i < Points.Count; i++)
			{
				if (pacman.PacRect.Intersects(Points[i].rectangle) || pacmanUp.PacRect.Intersects(Points[i].rectangle) 
					|| pacmanDown.PacRect.Intersects(Points[i].rectangle) || pacmanLeft.PacRect.Intersects(Points[i].rectangle))
				{
					Points.RemoveAt(i);
					puntaje += 100;
				}
			}


				#endregion

				if(Red.GhostRect.Intersects(pacman.PacRect))
			{
				dead = true;
				pacman.X = antX;
				pacman.Y = antY;
			}
				if(Points.Count ==0)
			{
				Red.X = GantX;
				Red.Y = GantY;
			}



				//Si se pasa del limite de la pantalla retorna en el inicio del otro lado.
				if (pacman.PacRect.X > 550)
			{
				pacman.PacRect.X = 0;
			}
			if (pacman.PacRect.X < 0)
			{
				pacman.PacRect.X = 550;
			}
			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{


			// TODO: Add your drawing code here

			spriteBatch.Begin();
			//PUNTOS TABLEROS
			for (int i = 0; i < Points.Count; i++)
			{
				Points[i].MetDraw(spriteBatch);
			}








			//PACMAN Cambio forzado de orientacion
			if (dead == false)

			{ 
				if (SpriteChange == 1)
				{
					pacmanUp.MetDraw(spriteBatch);
				}
				if (SpriteChange == 0)
				{
					pacman.MetDraw(spriteBatch);
				}
				if (SpriteChange == 2)
				{
					pacmanDown.MetDraw(spriteBatch);
				}
				if (SpriteChange == 3)
				{
					pacmanLeft.MetDraw(spriteBatch);
				}
			}
		
			

			//TABLERO Pintado por mi Ocultado para mejor estetica

		/*	rect1.MetDraw(spriteBatch);
			rect1_5.MetDraw(spriteBatch);
			rect2.MetDraw(spriteBatch);
			rect3.MetDraw(spriteBatch);
			rect3_5.MetDraw(spriteBatch);
			rect4.MetDraw(spriteBatch);
			rect5.MetDraw(spriteBatch);
			rect6.MetDraw(spriteBatch);
			rect7.MetDraw(spriteBatch);
			rect8.MetDraw(spriteBatch);
			rect9.MetDraw(spriteBatch);
			rect10.MetDraw(spriteBatch);
			rect11.MetDraw(spriteBatch);
			rect12.MetDraw(spriteBatch);
			rect13.MetDraw(spriteBatch);
			rect14.MetDraw(spriteBatch);
			rect15.MetDraw(spriteBatch);
			rect16.MetDraw(spriteBatch);
			rect17.MetDraw(spriteBatch);
			rect18.MetDraw(spriteBatch);
			rect19.MetDraw(spriteBatch);
			rect20.MetDraw(spriteBatch);
			rect21.MetDraw(spriteBatch);
			rect22.MetDraw(spriteBatch);
			rect23.MetDraw(spriteBatch);
			rect24.MetDraw(spriteBatch);
			rect25.MetDraw(spriteBatch);
			rect26.MetDraw(spriteBatch);
			rect27.MetDraw(spriteBatch);
			rect28.MetDraw(spriteBatch);
			rect29.MetDraw(spriteBatch);
			rect30.MetDraw(spriteBatch);
			rect31.MetDraw(spriteBatch);
			rect32.MetDraw(spriteBatch);
			rect33.MetDraw(spriteBatch);
			rect34.MetDraw(spriteBatch);
			rect35.MetDraw(spriteBatch);
			rect36.MetDraw(spriteBatch);
			rect37.MetDraw(spriteBatch);
			rect38.MetDraw(spriteBatch);
			rect39.MetDraw(spriteBatch);
			rect40.MetDraw(spriteBatch);
			rect41.MetDraw(spriteBatch);
			rect42.MetDraw(spriteBatch);
			rect43.MetDraw(spriteBatch);
			rect44.MetDraw(spriteBatch);
			rect44_5.MetDraw(spriteBatch);*/

			GraphicsDevice.Clear(Color.Black);
			Background.MetDraw(spriteBatch);
			Red.MetDraw(spriteBatch);

			if (Points.Count==0)
			{
				spriteBatch.DrawString(YouWin, "YOU WIN", WinFontPos, Color.White);
				spriteBatch.DrawString(YouWin, "SCORE: "+ puntaje, new Vector2(550-380,480/2+35), Color.White);
	
			}


			if (dead)
			{
				spriteBatch.DrawString(YouWin, "YOU LOSE", WinFontPos, Color.White);
				spriteBatch.DrawString(YouWin, "SCORE: " + puntaje, new Vector2(550 - 380, 480 / 2 + 35), Color.White);
			}

			//pacman.MetDraw(spriteBatch);




			spriteBatch.End();

			base.Draw(gameTime);
		}


	}

}
	

