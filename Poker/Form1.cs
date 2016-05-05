/********************************************
 *		 Name:	Jeremy Nims
 *		Class:	CPS 293, Wed 5:30
 * Assignment:	Poker (MP5?)
 * ******************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
	enum cardSuit
	{
		SPADE = 3, HEART = 2,
		CLUB = 0,  DIAMOND = 1
	}

	enum cardValue
	{
		TWO = 0,	THREE = 1,	FOUR = 2,	FIVE = 3,	
		SIX = 4,	SEVEN = 5,	EIGHT = 6,	NINE = 7, 
		TEN = 8,	JACK = 9,	QUEEN = 10,	KING = 11,	ACE = 12	
	}

	public partial class Form1 : Form
	{
		List<Card> cardHand = new List<Card>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)   
				cardHand.Add(new Card());             // Initialize the list, or else index out of range
			NewHand();
		}

		private void newHand_Click(object sender, EventArgs e)
		{
			NewHand();
		}

		private void NewHand()
		{
			DrawNewHand();
			DisplayCards();
			SortCards();
			txtWinType.Text = GetWinMessage();
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			DisplayCards(); 									   // Already sorted, just update images
		}

		private void DrawNewHand()                     // Constructs five new cards, ensuring uniqueness
		{
			int[] indices = { -1, -1, -1, -1, -1 };
			for (int i = 0; i < 5; i++)
			{
				do											// loop ensures no duplicate cards in a hand
				{
					cardHand[i] = new Card();
				} while (indices.Contains(cardHand[i].CardIndex));
				indices[i] = cardHand[i].CardIndex;
			}
			GC.Collect();                                          // Memory balloons if GC isn't forced
		}

		private void DisplayCards()                          // Populate the new images on the main form
		{
			pictCard_1.Image = cardHand[0].Image;
			pictCard_2.Image = cardHand[1].Image;
			pictCard_3.Image = cardHand[2].Image;
			pictCard_4.Image = cardHand[3].Image;
			pictCard_5.Image = cardHand[4].Image;
		}

		private void SortCards()
		{
			cardHand.Sort();
		}

		private string GetWinMessage()
		{
			// Cards are sorted by value
			if (isRoyalFlush())
				return "Royal Flush";
			if (isStraightFlush())
				return "Straight Flush";
			if (isFourKind())
				return "Four of a Kind";
			if (isFullHouse())
				return "Full House";
			if (isFlush())
				return "Flush";
			if (isStraight())
				return "Straight";
			if (isThreeKind())
				return "Three of a Kind";
			if (isTwoPair())
				return "Two Pair";
			if (isPair())
				return "Pair";
			return "No win";
		}

		private bool isRoyalFlush()                             // Is straight flush AND contains an ace
		{			
			return (isStraightFlush() && cardHand[4].Value.Equals(cardValue.ACE));
		}

		private bool isStraightFlush()                                     // Is a straight, and a flush
		{			
			return (isStraight() && isFlush());
		}

		private bool isFourKind()                   // The count of the value of the middle card is four
		{			
			return (cardHand.Count(card => card.Equals(cardHand[2])).Equals(4));
		}

		private bool isFullHouse()          // Number of distinct card values is 2. 4-kind must be false
		{			
			return (cardHand.Distinct().Count().Equals(2));
		}

		private bool isFlush()                          // Each card's suit equals the first card's suit
		{			
			return (cardHand.All(card => card.Suit.Equals(cardHand[0].Suit)));
		}

		private bool isStraight()       // The nth card's (val+1) equals the (n+1) card's value, for all
		{			
			for (int i = 0; i < 4; i++)
				if (cardHand[i + 1].Value != (cardHand[i].Value + 1))
					return false;
			return true;
		}

		private bool isThreeKind()   // The count of the value of the middle card is 3. Full house false
		{			
			return (cardHand.Count(card => card.Equals(cardHand[2])).Equals(3));
		}

		private bool isTwoPair()       // Hand contains three distinct card values. 3-kind must be false
		{			
			return (cardHand.Distinct().Count().Equals(3));
		}

		private bool isPair()          // Four distinct card values means there must be two of one value
		{			
			return (cardHand.Distinct().Count().Equals(4));
		}
	}
}
