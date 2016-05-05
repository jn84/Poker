/********************************************
 *		 Name:	Jeremy Nims
 *		Class:	CPS 293, Wed 5:30
 * Assignment:	Poker (MP5?)
 * ******************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
	class Card : IEquatable<Card>, IComparable<Card>
	{
		const int dimX = 167, dimY = 244;
		static private Bitmap cardArr = new Bitmap(Application.StartupPath + "\\cardArr.png");
		static private Random newCardIndex = new Random();

		private int cardIndex;
		private cardSuit suit;
		private cardValue value;
		private Bitmap image;

		public int CardIndex { get { return cardIndex; } }
		public cardSuit Suit { get { return suit; } }
		public cardValue Value { get { return value; } }
		public Bitmap Image { get { return image; } }

		public Card()
		{
			cardIndex = newCardIndex.Next(0, 52);
			suit = (cardSuit)(cardIndex / 13);
			value = (cardValue)(cardIndex % 13);
			SetImage();
		}

		private void SetImage()
		{
			Rectangle cardRect =
			new Rectangle((int)value * dimX,
						  (int)suit * dimY,
						  dimX,
						  dimY);
			image = new Bitmap(dimX, dimY);
			Graphics cardImage = Graphics.FromImage(image);
			cardImage.DrawImage(cardArr, 0, 0, cardRect, GraphicsUnit.Pixel);
		}

		// For the Sort method
		int IComparable<Card>.CompareTo(Card c)
		{
			return this.value.CompareTo(c.value);
		}

		// For Distinct() in terms of the card's value
		public bool Equals(Card cardObj)
		{
			return this.value.Equals(cardObj.value);
		}

		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}
	}
}
