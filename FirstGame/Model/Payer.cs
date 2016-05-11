using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Frameork.Input;

namespace FirstGame.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;

		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active;



		// Amount of hit points that player has
		public int Health;


		
		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height 
		{
			get { return PlayerTexture.Height; }
		}
		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		public void Initialize()
		{
			this.active = true;
			this.health = 100;
			this.score = 0;
			this.PlayerTexture = Texture;
			this.Position = Position;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

		public void Draw()
		{

		}


	}
}

