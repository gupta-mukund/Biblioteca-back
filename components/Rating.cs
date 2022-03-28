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
        private bool hasEverBeenClicked;
        private bool noRating;
        public event EventHandler<RatingEvent> RatingDone;
        public Rating()
        {
            InitializeComponent();
            currentStars = 1;
            noRating = false;
            hasEverBeenClicked = false;
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
            foreach (IconPictureBox item in this.Controls.OfType<IconPictureBox>())
            {
                item.IconChar = IconChar.Star;
                item.IconFont = IconFont.Solid;
                if (Convert.ToInt32(item.Tag) > currentStars)
                {
                    item.IconColor = Color.White;
                }
                else
                {
                    item.IconColor = Color.Yellow;
                }
                
            }
        }
        private void StarClick(object sender, EventArgs e)
        {
            this.hasEverBeenClicked = true;
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
            if (Convert.ToInt32(star.Tag) > currentStars)
            {
                star.IconFont = IconFont.Regular;
                star.IconColor = Color.Yellow;   
            } else
            {
                star.IconFont = IconFont.Solid;
                star.IconColor = Color.Yellow;
            }
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!hasEverBeenClicked && !noRating)
            {
                MessageBox.Show("Sure about not leaving a rating?");
                noRating = true;
            } else
            {
                RatingDone?.Invoke(this, new RatingEvent(currentStars));
            }
        }
    }
    public class RatingEvent : EventArgs
    {
        public int NumberOfStars { get; set; }
        public RatingEvent(int stars)
        {
            NumberOfStars = stars;
        }
    }
}
