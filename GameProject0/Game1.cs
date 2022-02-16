using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SnakeSprite[] snakes;
        private ChickenSprite chicken;
        private EggSprite egg;
        private SpriteFont bangers;
        private Texture2D backgroundTexture; 

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            
            chicken = new ChickenSprite();
            snakes = new SnakeSprite[]
            {
                new SnakeSprite((new Vector2(50, 125)), SnakeDirection.Right),
                new SnakeSprite((new Vector2(50, 375)), SnakeDirection.Right),
                new SnakeSprite((new Vector2(400, 125)), SnakeDirection.Right),
                new SnakeSprite((new Vector2(400, 375)), SnakeDirection.Right)
            };

            egg = new EggSprite(new Vector2(250, 250));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            backgroundTexture = Content.Load<Texture2D>("Plains");
            chicken.LoadContent(Content);
            foreach(var snake in snakes)
            {
                snake.LoadContent(Content);
            }
            egg.LoadContent(Content);
            bangers = Content.Load<SpriteFont>("bangers");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            chicken.Update(gameTime);
            foreach(var snake in snakes)
            {
                snake.Update(gameTime);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);
            chicken.Draw(gameTime, _spriteBatch);
            foreach(var snake in snakes)
            {
                snake.Draw(gameTime, _spriteBatch);
            }
            egg.Draw(gameTime, _spriteBatch);
            _spriteBatch.DrawString(bangers, $"Use 'ESC' to exit game", new Vector2(200, 15), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
