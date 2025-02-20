using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PrimeiroJogoPong.Entidades
{
    public class Bola
    {
        //criar o retangulo
        Rectangle retangulo;
        int direita = 1, cima = 1, velocidade =200;
        
        //metodo construtor, ou seja, o mesmo nome da classe, ele nao ter retorno ou e void
        public Bola()
        {
            retangulo = new Rectangle(Global.largura / 2 - 15, Global.altura / 2 - 15, 30, 30); 
        }

        public void Update(GameTime gameTime, Raquete raquete1, Raquete raquete2)
        {
            //definindo acoes para a bola
            int delta = (int)(velocidade * gameTime.ElapsedGameTime.TotalSeconds);
            retangulo.X += direita * delta;
            retangulo.Y += cima * delta;

            //condicionais para sabe;
            //se a bola bater no teto ela tem que descer
            //se a bola bater no chao ela tem que subir
            //se a bola bater na raquete da esquerda ela vai para a direita
            //se a bola bater na raquete da direita ela vai para a esquerda

            if(retangulo.Y > 0)
            {
                cima *= -1;
            }
            
            if (retangulo.Y < Global.altura - retangulo.Height)
            {
                cima *= -1;
            }
            
            //se encostou na raquete da esrquerda
            if (raquete1.retangulo.Right > retangulo.Left && retangulo.Top > raquete1.retangulo.Top && retangulo.Bottom < raquete1.retangulo.Bottom)
            {
                direita = 1;
            }

            //se encostou na raquete da direita
            if (raquete2.retangulo.Left < retangulo.Right && retangulo.Top > raquete2.retangulo.Top && retangulo.Bottom < raquete2.retangulo.Bottom)
            {
                direita = -1;
            }

            //verificar se a bola passou da raquete
            if (retangulo.X < 0)
            {
                Global.pntuacao2 += 1;
                ReiniciarPartida();
            }

            if(retangulo.X > Global.largura - retangulo.Width)
            {
                Global.pntuacao1 += 1;
                ReiniciarPartida();
            }
            
        }

        public void ReiniciarPartida()
        {
            retangulo.X = Global.largura / 2 - 15;
            retangulo.Y = Global.altura / 2 - 15;
        }

        //desenhar a raquete
        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);
            //Global.spriteBatch.Draw(Global.textura, retangulo2, Color.White);
        }
    }
}
