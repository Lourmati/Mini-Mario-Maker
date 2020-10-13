using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTilesetMario;

/// <summary>
/// Oussama Lourhmati
/// </summary>
namespace Labo5
{
    /// <summary>
    /// Classe pour le Form du Mario Maker
    /// </summary>
    public partial class Form1 : Form
    {
        Choix choix;
        Bitmap[,] tab = new Bitmap[32, 16];
        public Form1()
        {
            InitializeComponent();
            Initialisation();
        }

        /// <summary>
        /// Initialisation de mes boutons (choix) et du tableau de Bitmap qui contient les images du Mario Maker (ciel, plancher, etc.)
        /// </summary>
        private void Initialisation()
        {
            BtnNuage.BackgroundImage = TilesetImageGenerator.GetTile(4);
            BtnBrique.BackgroundImage = TilesetImageGenerator.GetTile(1);
            BtnPlancher.BackgroundImage = TilesetImageGenerator.GetTile(0);
            BtnCoin.BackgroundImage = TilesetImageGenerator.GetTile(3);

            for (int i = 0; i < tab.GetLength(0); i ++)
            {
                for (int j = 0; j < tab.GetLength(1); j ++)
                {
                    if (j >= 14)
                    {
                        tab[i, j] = TilesetImageGenerator.GetTile(0);
                    }
                    else
                    {
                        tab[i, j] = TilesetImageGenerator.GetTile(2);
                    }
                }
            }
        }

        /// <summary>
        /// Paint du Form, dessine le tableau de bitmap contenant le ciel et le plancher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DoubleBuffered = true;
            for (int i = 0; i < tab.GetLength(0); i ++)
            {
                for (int j = 0; j < tab.GetLength(1); j ++)
                {
                    g.DrawImage(tab[i, j], i*32, j*32, 32, 32);
                }
            }
        }

        /// <summary>
        /// Évenement mouseClick, il y aura un changement sur le Form selon le choix de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (choix)
            {
                case Choix.Brique:
                    if (tab[e.X / 32, e.Y / 32] != TilesetImageGenerator.GetTile(1))
                    {
                        tab[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(1);
                        Refresh();
                    }
                    break;
                case Choix.Plancher:
                    if (tab[e.X / 32, e.Y / 32] != TilesetImageGenerator.GetTile(0))
                    {
                        tab[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(0);
                        Refresh();
                    }
                    break;
                case Choix.Nuage:
                    if (tab[e.X / 32, e.Y / 32] != TilesetImageGenerator.GetTile(4))
                    {
                        tab[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(4);
                        Refresh();
                    }
                    break;
                case Choix.Coin:
                    if (tab[e.X / 32, e.Y / 32] != TilesetImageGenerator.GetTile(3))
                    {
                        tab[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(3);
                        Refresh();
                    }
                    break;
            }
        }

        /// <summary>
        /// Énum pour la sélection du choix, si il veut ajouter la brique, le plancher, le nuage ou le coin.
        /// </summary>
        private enum Choix
        {
            Brique,
            Plancher,
            Nuage,
            Coin,
        };


        /// <summary>
        /// Évenement clique si l'utilisateur choisi la brique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {

            if (sender as Button == BtnBrique)
            {
               choix = Choix.Brique;
            }

            if (sender as Button == BtnPlancher)
            {
                choix = Choix.Plancher;
            }

            if (sender as Button == BtnNuage)
            {
                choix = Choix.Nuage;
            }

            if (sender as Button == BtnCoin)
            {
                choix = Choix.Coin;
            }

        }
    }
}
