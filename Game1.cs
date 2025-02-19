using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PrimeiroJogoPong.Entidades;

namespace PrimeiroJogoPong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private Raquete raquete1;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Global.largura;
            _graphics.PreferredBackBufferHeight = Global.altura;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //criar a raquete
            raquete1 = new Raquete();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Global.spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //carregar a textura no jogo
            Global.textura = new Texture2D(GraphicsDevice, 1, 1);
            Global.textura.SetData<Color>([Color.White]);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //decidir o que vai fazer quando precionar as teclas
            raquete1.Update(gameTime);
        
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //definindo a cor do fundo do jogo
            GraphicsDevice.Clear(Color.Black);

            Global.spriteBatch.Begin();

            // TODO: Add your drawing code here
            //metodo para desenhar a raquete
            raquete1.Draw();

            Global.spriteBatch.End();

            base.Draw(gameTime);

           
        }
    }
}
