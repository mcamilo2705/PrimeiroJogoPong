using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace PrimeiroJogoPong
{
    public class Global
    {
        //SpriteBatch vai permitir que carregue muitos elementos ao mesmo tempo
        public static SpriteBatch spriteBatch;
        //Definir o tamanho da tela
        public static int largura = 640, altura = 400;
        //opcao de carregar objetos 2d
        public static Texture2D textura;
        public static int pntuacao1, pntuacao2;
    }
}
