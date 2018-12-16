using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameME
{
	abstract class Figure
	{
		int x;
		int y;
		int height;
		int width;

		public abstract void Draw();
	}
}
