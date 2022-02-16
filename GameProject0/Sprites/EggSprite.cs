using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class EggSprite
    {
        private Vector2 position;
        private Texture2D texture;


        public EggSprite(Vector2 position)
        {
            this.position = position;

        }


        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("egg");
        }


        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var source = new Rectangle(0, 0, 16, 16);
            spriteBatch.Draw(texture, position, source, Color.White, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0);
        }
    }
}
