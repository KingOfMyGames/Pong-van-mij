using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D bal;
        Vector2 balPosition;
        Vector2 blauweSpelerPlek;
        Vector2 rodeSpelerPlek;
        int yBal = 100;
        int xBal = 100;
        int xBlauw = 20;
        int yBlauw = 20;
        int xRood = 764;
        int yRood = 20;
        int yVector = 3;
        int xVector = 3;
        Texture2D blauweSpeler;
        Texture2D rodeSpeler;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
            // TODO: Add your initialization logic here

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
            bal = Content.Load<Texture2D>("bal");
            blauweSpeler = Content.Load<Texture2D>("blauweSpeler");
            rodeSpeler = Content.Load<Texture2D>("rodeSpeler");
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
            //De volgende regels zorgen ervoor dat de bal aan de boven en onderkant stuitert.
            if (yBal >= 464 || yBal <= 0)
            {
                yVector = -yVector;

            }
            //De volgende regels zorgen ervoor dat de bal aan de linker en rechterkant stuitert.
            if (xBal >= 786 || xBal <= 0)
            {
                xVector = -xVector;
            }
            yBal = yBal + yVector;
            xBal = xBal + xVector;
            blauweSpelerPlek = new Vector2(xBlauw, yBlauw);
            rodeSpelerPlek = new Vector2(xRood, yRood);
            balPosition = new Vector2(xBal, yBal);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(bal, balPosition, Color.White);
            spriteBatch.Draw(blauweSpeler, blauweSpelerPlek, Color.White);
            spriteBatch.Draw(rodeSpeler, rodeSpelerPlek, Color.White);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
