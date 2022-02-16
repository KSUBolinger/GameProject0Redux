using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class ChickenSprite
    {
        private Texture2D texture;
        private Vector2 position = new Vector2(200, 200);

        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Chicken");
        }


        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var source = new Rectangle(32, 64, 32, 32);
            spriteBatch.Draw(texture, position, source, Color.White);
        }

    }
}
