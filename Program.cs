using System;
using static System.Console;
using System.Collections;
// Note string is not capital, boolean is bool

namespace Bme121
{
    class Pokemon
    {
	  private int health; 
	  private int attack; 
	  private int defense; 
	  private int speed; 
	  private string name;
	  private string[] moves;
	  private static bool isPoisoned1 = false;
	  private static bool isPoisoned2 = false;
	  private static int toxicMod1 = 0;
	  private static int toxicMod2 = 0;
	  private static bool isLeeched1 = false;
	  private static bool isLeeched2 = false;
	  private static int restCounter1 = 0; // the duplicity is for when 2 blastoises face each other... otherwise, both blastoise will face asleep
	  private static int restCounter2 = 0;
	  private static int beamCounter1 = 0;
	  private static int beamCounter2 = 0;
	  private static int roundCounter = 0; // this is to display to the user what round they are in. 
	  private static int moveCounter1 = 0; 
	  private static int moveCounter2 = 0;
	  private static bool isParalyzed1 = false;
	  private static bool isParalyzed2 = false;	

	   public Pokemon()
	   {
	   }

	   public int getHealth()
	   {
		 return this.health;
	   }
	   public void setHealth(int health)
	   {
		 this.health = health;
	   }
	   public int getAttack()
	   {
		 return this.attack;
	   }
	   public void setAttack(int attack)
	   {
		 this.attack = attack;
	   }
	   public int getDefense()
	   {
		 return this.defense;
	   }
	   public void setDefense(int defense)
	   {
		 this.defense = defense;
	   }
	   public int getSpeed()
	   {
		 return this.speed;
	   }
	   public void setSpeed(int speed)
	   {
		 this.speed = speed;
	   }
		public string getName()
	  {
		return this.name;
	  }
	  public void setName(string name)
	  {
		this.name = name;
	  }
	  public string[] getMove()
	  {
		return this.moves;
	  }
	  
	  public void setMove(string[] moves)
	  {
		this.moves = moves;
	  }
	  
        static void Main( )
        {

			WriteLine("Welcome to the Pokemon Battle Simulator! ");
			WriteLine();
			Write("Finally, you can play a friend in Pokemon using classic characters such as charizard, blastoise, and venusaur. ");
			Write("Pokemon is a turn-based game, meaning you exchange using moves. ");
			WriteLine("Each Pokemon has a specific moveset and attributes for its health, attack, defense, and speed. ");
			WriteLine("The battle continues until one of the pokemon faints."); 
			WriteLine();
			
			bool isSameName = true;
			string playerOneName = "";
			string playerTwoName = "";
			
			while(isSameName ==true)
		    {
				WriteLine("Player 1 please enter your name: ");
				playerOneName = ReadLine();
				WriteLine("Welcome " + playerOneName + "!");
				WriteLine();
				
				WriteLine("Player 2 please enter your name: ");
				playerTwoName = ReadLine(); 
				WriteLine("Welcome " + playerTwoName + "!");
				WriteLine();
				
				if(String.Compare(playerOneName, playerTwoName)==0)
				{
					WriteLine("Players have selected the same name. Please select different names!"); 
					WriteLine();
				}
				
				else
				{
					isSameName = false;
				}
			}
			
			Pokemon playerOne = new Pokemon();
			Pokemon playerTwo = new Pokemon();
				
			pokemonGenerator(playerOne, playerOneName);
			pokemonGenerator(playerTwo, playerTwoName);
			
			playerOne.setName(playerOneName + "'s " + playerOne.getName());
			playerTwo.setName(playerTwoName + "'s " + playerTwo.getName());
		
			battle(playerOne, playerTwo);
				
        }
   
          public static void pokemonGenerator(Pokemon pokemon, string pokemonName )
          {
			bool isValidName = false;
			
			while(isValidName ==false)
			{ 
				isValidName = true;
				Write(pokemonName + ", please pick your Pokemon. ");
				WriteLine("You can choose  between charizard, the fire-breathing dragon, blastoise, the ferocious water turtle, venusaur, the powerful plant-creature, or pikachu, the iconic electric-mouse.");
				string playerOnePoke = ReadLine();
				WriteLine();
				  
				Pokemon charizard = new Pokemon();	
				string[] charizardMoves = new string[] {"flamethrower, ", "dragon claw, ", "belly drum, ", "roost"};
				
				charizard.setHealth(100);
				charizard.setAttack(20);
				charizard.setDefense(120);
				charizard.setSpeed(230);
				charizard.setMove(charizardMoves);
				charizard.setName("Charizard");// this is creating pokemon objects with unique instance variables
				
				Pokemon venusaur = new Pokemon(); 
				string[] venusaurMoves = new string[] {"Razor Leaf, ", "Toxic, ", "Leech Seed, ", "Solar Beam, "};
				 venusaur.setHealth(160);
				 venusaur.setAttack(12);
				 venusaur.setDefense(180);
				 venusaur.setSpeed(100);
				 venusaur.setMove(venusaurMoves);
				 venusaur.setName("Venusaur");
				
				Pokemon blastoise = new Pokemon();
				string[] blastoiseMoves = new string[] {"Hydro Pump, ", "Harden, ", "Ice Beam, ", "Rest"};
				
				  blastoise.setHealth(120);
				  blastoise.setAttack(15);
				  blastoise.setDefense(170);
				  blastoise.setSpeed(160);
				  blastoise.setMove(blastoiseMoves);
				  blastoise.setName("Blastoise");  
				
				Pokemon pikachu = new Pokemon();
				string[] pikachuMoves = new string[] {"Thunder Shock, ", "Iron Tail, ", "Thunder Wave, ", "Light Screen"};
				pikachu.setHealth(80);
				pikachu.setAttack(25);
				pikachu.setDefense(100);
				pikachu.setSpeed(250);
				pikachu.setMove(pikachuMoves);
				pikachu.setName("Pikachu");
				
				if(String.Compare(playerOnePoke, "charizard")==0)
				{
					pokemonCreator(pokemon, charizard);
				}
				
				else if(String.Compare(playerOnePoke, "venusaur")==0)
				{
					pokemonCreator(pokemon, venusaur);
				}
				
				else if(String.Compare(playerOnePoke, "blastoise")==0)
				{
					pokemonCreator(pokemon, blastoise);
				}
				
				else if(String.Compare(playerOnePoke, "pikachu")==0)
				{
					pokemonCreator(pokemon, pikachu);
				}
				else
				{
					isValidName = false;
				}
				
				if(isValidName == true)
				{
					// WriteLine("Congrats! " + /*pokemonName*/ "Tyler" + " you have selected "  + playerOnePoke + ".");
					// WriteLine();
				}
				
				else
				{
					WriteLine("You have entered an invalid Pokemon name!! Please select a valid Pokemon!");
					WriteLine();
				}
			}
		  }
          public static void pokemonCreator(Pokemon pokemon1, Pokemon pokemon2)
		  {
		   pokemon1.setHealth(pokemon2.getHealth());
		   pokemon1.setAttack(pokemon2.getAttack());
		   pokemon1.setSpeed(pokemon2.getSpeed());
		   pokemon1.setName(pokemon2.getName());
		   pokemon1.setDefense(pokemon2.getDefense());
		   pokemon1.setMove(pokemon2.getMove());
		  }
        
        public static void movePrint(string[] array)
        {
			foreach(var item in array)
			{
				Write(item.ToString());
			}
		}
		
		public static void battle(Pokemon playerOne, Pokemon playerTwo)
		{
			while(playerOne.getHealth()>0 && playerTwo.getHealth()>0)
			{
				roundCounter++; 
				if(playerOne.getSpeed() > playerTwo.getSpeed())
				{
					battleExecutor(playerOne, playerTwo);
				}
				else
				{
					battleExecutor(playerTwo, playerOne);
				}
			}
			if(playerOne.getHealth() <=0)
			{
				WriteLine(playerOne.getName() + " has fainted.");
			}
			else
			{
				WriteLine(playerTwo.getName() + " has fainted.");
			}
			WriteLine("This battle has lasted " + roundCounter + " turns.");
		}
		
		public static void battleExecutor(Pokemon pokemonOne, Pokemon pokemonTwo)
		{
			WriteLine("This is round number " + roundCounter);
			moveCounter1 ++; // this is incremented before pokemonOne does its move so that moves like rest knows which pokemon to inflict
			moveExecutor(pokemonOne, pokemonTwo, isParalyzed1, restCounter1, beamCounter1, isLeeched1, isPoisoned1);
			
			if(pokemonTwo.getHealth()>0)
			{
				moveCounter2 ++;
				moveExecutor(pokemonTwo, pokemonOne, isParalyzed2, restCounter2, beamCounter2, isLeeched2, isPoisoned2);
			}
		}
		
		public static void moveExecutor(Pokemon pokemonOne, Pokemon pokemonTwo, bool isParalyzed, int rest, int beam, bool isLeeched, bool isPoisoned)
	    {
			string nextMove = "";
			Write("Choose one of the following moves for ");
			Write(pokemonOne.getName()); 
			Write(": ");
			movePrint(pokemonOne.getMove());
			WriteLine();
			nextMove = ReadLine();
			WriteLine();
			Write(pokemonOne.getName());
			Write(" has selected " );
			WriteLine(nextMove);
			
			Random rand = new Random();
			int accuracy = rand.Next(100) + 1; // this mimics accuracy of moves, with 100 as the maximum and 1 as the minimum.
			int paralyzAccuracy = rand.Next(100) +1;
			
		    bool canMove = true; // resets to true every turn. 
		    
		    if(rest >0)
		    {
				if(moveCounter1 > moveCounter2)
				{
					restCounter1--;
					WriteLine(pokemonOne.getName() + " is fast asleep. It must rest for " + restCounter1 + " more turns.");
				}
				else
				{
					restCounter2--;
					WriteLine(pokemonTwo.getName() + " is fast asleep. It must rest for " + restCounter2 + " more turns.");
			    }
			    canMove = false;
			}
			
			if(beam >0)
			{
				if(beamCounter1 > beamCounter2)
				{
					beamCounter1--;
					WriteLine(pokemonOne.getName() + " must recharge!");
				}
				else
				{
					beamCounter2--;
				}
				canMove = false;
			}
			
			if(isParalyzed == true)
			{
				if(paralyzAccuracy > 50)
				{
					WriteLine(pokemonOne.getName() + " is paralyzed and unable to attack!!");
					canMove = false;
					WriteLine();
				}
			}
					
			if(canMove == true) // if the pokemon is paralyzed this turn, its move will not be activated.
			{
				if(pokemonOne.getName().Contains("Charizard"))
				{
					if(nextMove.Contains("flamethrower"))
					{
						pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*90)/pokemonTwo.getDefense());
						WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*90)/pokemonTwo.getDefense() + " damage.");
						WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					}
					
					if(nextMove.Contains("dragon claw"))
					{
						if(accuracy > 80)
						{
							pokemonTwo.setDefense(pokemonTwo.getDefense() - 40);
							WriteLine("Dragon Claw has caused " + pokemonTwo.getName() + "'s Defense to fall!");
						}
					
						pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*80)/pokemonTwo.getDefense());
						WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*80)/pokemonTwo.getDefense() + " damage.");
						WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					}
					
					if(nextMove.Contains("belly drum"))
					{
						pokemonOne.setHealth(pokemonOne.getHealth()-50);
						pokemonOne.setAttack(pokemonOne.getAttack()*4);
						WriteLine(pokemonOne.getName() + "'s health is now at " + pokemonOne.getHealth());
						WriteLine(pokemonOne.getName() + " has quadrupled its attack!");
					}
					
					if(nextMove.Contains("roost"))
					{
						if(pokemonOne.getHealth() >50)
						{
							pokemonOne.setHealth(100);
							WriteLine(pokemonOne.getName() + " is now at full health!");
						}
					
					    else
						{
							pokemonOne.setHealth(pokemonOne.getHealth() + 50);
							WriteLine(pokemonOne.getName() + " is now at " + pokemonOne.getHealth() + " health.");
						}
					}	
				}
				
				if(pokemonOne.getName().Contains("Blastoise"))
				{
					if(nextMove.Contains("hydro pump"))
					{
						if(accuracy > 70)
						{
							WriteLine("Unlucky! Hydro Pump has missed!");
						}
						
						else
						{
							pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*120)/pokemonTwo.getDefense());
							WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*120)/pokemonTwo.getDefense() + " damage.");
							WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					    }
					}
					
					if(nextMove.Contains("ice beam"))
					{
						pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*90)/pokemonTwo.getDefense());
						WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*90)/pokemonTwo.getDefense() + " damage.");
						WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					}
					
					if(nextMove.Contains("harden"))
					{
						pokemonOne.setDefense(pokemonOne.getDefense()*2);
						WriteLine(pokemonOne.getName() + " has doubled its defense.");
					}
					
					if(nextMove.Contains("rest"))
				    {
						pokemonOne.setHealth(140);
						WriteLine(pokemonOne.getName() + " has regained full health!");
						
						if(isParalyzed == true)
						{
							if(moveCounter1 > moveCounter2)
							{
								isParalyzed1 = false;
							}
							
							else
							{
								isParalyzed2 = false;
							}
							WriteLine(pokemonOne.getName() + " is no longer paralyzed!");
						}
						
						if(isPoisoned == true)
						{
							if(moveCounter1 > moveCounter2)
							{
								isPoisoned1 = false;
							}
							
							else
							{
								isPoisoned2 = false;
							}
							WriteLine(pokemonOne.getName() + " is no longer poisoned!");
						}
						
						if(moveCounter1 > moveCounter2)
						{
							restCounter1 = 2;
						}
						else
					    {
							restCounter2 = 2;
						}
					}
				}
						
				if(pokemonOne.getName().Contains("Venusaur"))
				{
					if(nextMove.Contains("toxic"))
					{
						if( isPoisoned == true)
						{
							WriteLine( pokemonTwo.getName() + " is already poisoned!");
						}
						else if(moveCounter1 > moveCounter2)
						{	
							isPoisoned1 = true;
							WriteLine(pokemonTwo.getName() + " has been badly poisoned!");
						}
						else
						{
							isPoisoned2 = true;
							WriteLine(pokemonTwo.getName() + " has been badly poisoned!");
						}
						isPoisoned = true;
					}
					
					if(nextMove.Contains("leech seed"))
					{
						if( isLeeched == true)
						{
							WriteLine( pokemonTwo.getName() + " is already leeched!");
						}
						else if(moveCounter1 > moveCounter2)
						{	
							isLeeched1 = true;
							WriteLine(pokemonTwo.getName() + " has been badly leeched!");
						}
						else
						{
							isLeeched2 = true;
							WriteLine(pokemonTwo.getName() + " has been badly leeched!");
						}
						isLeeched = true;
					}	
					
					if(nextMove.Contains("razor leaf"))
					{
						if(accuracy >60)
						{
							pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*125)/pokemonTwo.getDefense());
							WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*125)/pokemonTwo.getDefense() + " damage.");
							WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
						}
						else
						{			
							pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*75)/pokemonTwo.getDefense());
							WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*75)/pokemonTwo.getDefense() + " damage.");
							WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
						}
					}
					
					if(nextMove.Contains("solar beam"))
					{
						pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*150)/pokemonTwo.getDefense());
						WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*150)/pokemonTwo.getDefense() + " damage.");
						WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
						WriteLine(pokemonOne.getName() + " must recharge next turn!");
						
						if(moveCounter1 > moveCounter2)
					    {
							beamCounter1 = 1;
						}
						else
						{
							beamCounter2 = 1;
					    }
					}
				}	
				
				if(pokemonOne.getName().Contains("Pikachu"))
				{
					if(nextMove.Contains("iron tail"))
					{
						pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*90)/pokemonTwo.getDefense());
						WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*90)/pokemonTwo.getDefense() + " damage.");
						WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
				    }
				    
				    if(nextMove.Contains("thunder shock"))
					{
						if(accuracy > 70)
					    {
							WriteLine("Unlucky! Thunder Shock has missed!");
						}
						
						else
						{
							pokemonTwo.setHealth(pokemonTwo.getHealth()-(pokemonOne.getAttack()*120)/pokemonTwo.getDefense());
							WriteLine(pokemonOne.getName() + " has done " + (pokemonOne.getAttack()*120)/pokemonTwo.getDefense() + " damage.");
							WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					    }
				    }
				    if(nextMove.Contains("light screen"))
					{
						pokemonOne.setAttack(pokemonOne.getAttack()+5);
						pokemonOne.setDefense(pokemonOne.getDefense() + 40);
						WriteLine(pokemonOne.getName() + "'s attack and defense has risen");
				    }
				    
				    if(nextMove.Contains("thunder wave"))
				    {
						if(accuracy > 75)
					    {
							WriteLine("Unlucky! Thunder Wave has missed!");
						}
						
						else
						{
							pokemonTwo.setSpeed(pokemonTwo.getSpeed()/2);
							WriteLine(pokemonTwo.getName() + " has become paralyzed.");
							if(moveCounter1 > moveCounter2)
							{
								isParalyzed2 = true; // determines which pokemon is getting paralyzed
							}
							else
							{
								isParalyzed1 = true;
							}
					    }
					}
				}			
						
				WriteLine();	
				if(isPoisoned == true)
				{
					if(moveCounter1 > moveCounter2)
					{
						toxicMod1++;
						pokemonTwo.setHealth(pokemonTwo.getHealth() - toxicExecutor(toxicMod1));
						WriteLine(pokemonTwo.getName() + " has lost " + toxicExecutor(toxicMod1) + " health due to poison.");
					}	
					else
					{
						toxicMod2++;
						pokemonTwo.setHealth(pokemonTwo.getHealth() - toxicExecutor(toxicMod2));
						WriteLine(pokemonTwo.getName() + " has lost " + toxicExecutor(toxicMod2) + " health due to poison.");
					}
					WriteLine(pokemonTwo.getName() + " has " + pokemonTwo.getHealth() + " health left.");
					WriteLine();
				}
					
				if(isLeeched == true)
				{
					int leechMod = 6;
					pokemonTwo.setHealth(pokemonTwo.getHealth() - leechMod);
					
					WriteLine(pokemonOne.getName() + " has leeched " + leechMod + " health from " + pokemonTwo.getName() + ".");
					WriteLine(pokemonTwo.getName() + " has "  + pokemonTwo.getHealth() + " health left.");
					
					if(pokemonOne.getHealth() > 154)
					{
						pokemonOne.setHealth(160); // can't go over max health.
						WriteLine(pokemonOne.getName() + " is at full health.");
					}
					
					else
					{
						pokemonOne.setHealth(pokemonOne.getHealth() + leechMod);
						WriteLine(pokemonOne.getName() + " has " + pokemonOne.getHealth() + " health left.");
					}
					WriteLine();
				}
			}
		} 
		
		public static int toxicExecutor(int toxic)
		{
			if(toxic == 0)
			{
				return 0;
			}
			else
			{
				return 6 + toxicExecutor(toxic-1);
			}
		}
	
	}
}
