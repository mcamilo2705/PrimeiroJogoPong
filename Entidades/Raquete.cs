using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PrimeiroJogoPong.Entidades
{
    public class Raquete
    {
        public Rectangle retangulo;
        public bool segundaRaquete;
        //public Rectangle retangulo2;

        //metodo que tem o mesmo nome da classe e chamado de Metodo Contrutor
        //determina o que acontece quando criar objetos da classe
        public Raquete(bool segundaRaquete)
        {
            this.segundaRaquete = segundaRaquete;
            //definir onde vai estar o retangulo e o tamanho dele
            retangulo = new Rectangle((this.segundaRaquete ? Global.largura-30 : 0) , 140, 30, 180);
           // retangulo2 = new Rectangle(610, 140, 30, 180);

        }
        //o que vai acontecer com a raquete
        public void Update(GameTime gameTime)
        {
            //keyboardstate pega o que digitou no teclado
            KeyboardState teclado = Keyboard.GetState();
            if ((this.segundaRaquete ? teclado.IsKeyDown(Keys.Up) : teclado.IsKeyDown(Keys.W)) && retangulo.Y > 0)
            {
                //definir a velocidade de subida do retangulo
                retangulo.Y -= (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }
            if ((this.segundaRaquete ? teclado.IsKeyDown(Keys.Down) : teclado.IsKeyDown(Keys.S)) && retangulo.Y < Global.altura-retangulo.Height)
            {
                //definir a velocidade de subida do retangulo
                retangulo.Y += (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }

            //if (teclado.IsKeyDown(Keys.W) && retangulo2.Y > 0)
            //{
            //    //definir a velocidade de subida do retangulo
            //    retangulo2.Y -= (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            //}
            //if (teclado.IsKeyDown(Keys.S) && retangulo2.Y < Global.altura - retangulo2.Height)
            //{
            //    //definir a velocidade de subida do retangulo
            //    retangulo2.Y += (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            //}

        }
        //desenhar a raquete
        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);
            //Global.spriteBatch.Draw(Global.textura, retangulo2, Color.White);
        }
    }
}
