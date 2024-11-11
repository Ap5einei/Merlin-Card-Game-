# Merlin-Card-Game-
Unity Project 
‘Merlin's Demon War’ is a simple fun single player card battler.

Scene:![Merlin's_Demon_War_Mock-Up](https://github.com/user-attachments/assets/db7afa12-847d-4af2-b51d-1d13f737478a)


Merlin faces Mordred and her army of darkness in a battle to the death.

Content:

The player takes the role of Merlin and using a selection of spells must defeatthe Evil hordes of Mordred. The objective is simply to kill as many enemies as possible.

Mock-Up
This is an image

Playthrough
Run the game:

New Game Screen:

The new game screen contains a logo for ‘Merlin's Demon War’ and two options, ‘New Game’ and ‘Quit’.

Press, ‘New Game’: The game loads a 2D screen. It is divided into the following sections.

The play field: Position Middle Top: On the left of the play field is the player’s character card, ‘Merlin’. On the right side of the playfield is the enemy ‘Demon’ card.
The mana meter: Positioned on either side of the playfield. On the left for the player and on the right for the enemy are the mana meters. These fill up with a mana gem eachturn and dictate the number and the strength of the cards that can be played. (They fill up by +1 each turn. Turn one = 1 mana, Turn two = 2 mana etc.)
The hand area: Positioned below the playfield is the hand area. This runs the full width of the screen and is divided into two clear sections. The left half is for the player’s attack cards the right side for the opponents.
Decks: Below each of the mana meters are the decks of the player and the enemy.
Turn Counter: At the top of the screen the turn counter prints out whose turn is taking place.
Death Counter: At the top left of the screen the death counter displays the number of enemies killed and gives a player score.
The game over screen appears if the Merlin card is destroyed. It shows the players score and how many demons were killed.
The game begins:
Each player is dealt 3 cards from his deck.

The player’s cards are face up and enemy’s face down.

The turn counter says, ‘Player’s Turn’.

A single mana gem appears in both mana counters.

The player starts, he picks an attack card of mana value 1.

The card vanishes and an effect is emitted from Merlin card.

The enemy card shows a hit effect and the damage to the amount on the attack card is taken.

If the enemy card’s health is zero the enemy and its attack cards are destroyed, the player’s enemy kill counter goes up by one and a new enemy moves onto the play field, and 3 new play cards appear in the hand area. (Otherwise the enemy card remains in place.)

The turn counter says, ‘Enemy Turn’. One of the enemy cards is chosen and turns face up before vanishing an effect is emitted from the enemy card.

The Merlin card shows a hit effect and damage to the amount on the attack card is taken.

If the Merlin card’s health is reduced to zero the Merlin card and its attack cards are destroyed.

The game screen appears. It shows “Game Over, you destroyed”, X, “minions.” and the players score.

The Cards
The cards are divided into:

Ice Spells

Fire Spells

Health Boosts

and Mirror

Card List
Spell	Mana Cost	Damage	Note
Ice	1	2	Half damage against Ice
Fire	1	2	Half damage against Fire
Ice2	2	4	Half damage against Ice
Fire2	2	4	Half damage against Fire
Ice Fire	3	3	3 destruction Ice and Fire
Destruct	5	9(Kill)	Destroys enemy card
Boost	1	+2 Health	+2 health boost to Merlin
Boost2	2	+4 Health	+4 health boost to Merlin
Mirror	2	Reflect	Reflects an enemy attack
Card Display Description
Name	Title	Description
Ice	Ice Attack	Casts an Ice Attack
Fire	Fire Attack	Casts a Fireball Attack
Ice 2	Multi Ice	Casts multiple Ice attacks
Fire 2	Multi Fire	Casts multiple Fireball attacks
Ice Fire	Fire & Ice	Casts both Fire and Ice attacks
Destruct	Destruct	Destroys the Enemy
Boost	Small Health	Restores 1 Health
Boost 2	Large Health	Restores 4 Health
Mirror	Mirror	Reflects an Enemy attack
Number of Cards in a Deck
Card	Number
Ice	6
Fire	6
Ice2	4
Fire2	4
Fire & Ice	3
Destruct	1
Boost1	6
Boost2	3
Mirror	2
