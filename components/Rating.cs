using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Biblioteca.components
{
    public partial class Rating : UserControl
    {
        private int currentStars;
        private bool hasAlreadyBeenClicked;
        public Rating()
        {
            InitializeComponent();
            currentStars = 1;
            hasAlreadyBeenClicked = false;
            InitStars();
            
        }

        private List<IconPictureBox> FindClickedList(int numberOfStars)
        {
            InitStars();
            List<string> tmp = new List<string>();
            
            for (int i = 1; i <= numberOfStars; i++)
            {
                tmp.Add(i.ToString());
            }

            return this.Controls.OfType<IconPictureBox>().Where(p => tmp.Any(x => x == p.Tag.ToString())).ToList();
        }

        private void InitStars()
        {
            List<IconPictureBox> obj = this.Controls.OfType<IconPictureBox>().ToList();
            foreach (IconPictureBox item in obj)
            {
                if (item == obj.First())
                {

                }
                item.IconChar = IconChar.Star;
                item.IconFont = IconFont.Solid;
                item.IconColor = Color.White;
            }
        }
        private void StarClick(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(((IconPictureBox)sender).Tag);
            currentStars = number;

            foreach (IconPictureBox item in FindClickedList(number))
            {
                LetColor(item);
            }
        }

        private void LetColor(IconPictureBox star)
        {
            star.IconFont = IconFont.Solid;
            star.IconColor = Color.Yellow;
        }
        private void LetHover(IconPictureBox star)
        {
            star.IconFont = IconFont.Regular;
            star.IconColor = Color.Yellow;
        }

        private void StarHover(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(((IconPictureBox)sender).Tag);

            foreach (IconPictureBox item in FindClickedList(number))
            {
                LetHover(item);
            }
        }
        private void StarOut(object sender, EventArgs e)
        {
            InitStars();
        }
    }
}
