# Game-Engines-Assignment
<p><b>Name:</b>Marcus Gleeson<br>
<b>Student Number:</b>D19124543<br>
<b>Class Group:</b>DT508
</P>
<p>This was a new unity project that I started at the start of reading week, all modeles and assets are assets that I have created myself</p>
<h1>Game Idea</h1>
<p>For my Game Engines Assignment, I will be doing a procedurally generated city shooter game. This city will feature procedurally generated buildings of different heights that the player can roam around.</p>
<p>On top of the procedurally generated city, I will look at using the unity spectrum data to make a sphere in the game look like a sun with rotating rings that reacts to the sound of the game music.</p>

<h2>How will I achieve this?</h2>
<p>I will achieve the procedurally generated city by using Perlin noise. This technique will allow me to have some of the buildings, different heights in the game as it will sample the Perlin noise and then instantiate the building's height from that sample of the Perlin noise.</p>
<p>To achieve the unity spectrum data, I will get the songs data from the audio source and then from that data I dynamically change the height of the cubes which form up the rings that rotate around the sun. To add a bit more flare to the game, I will use unity post-processing effect so that I can have each of the cubes that form the ring around the sun, a different colour.</p>

<h2>Player's gaol in the game</h2>
<p>The goal of the game is for the player to kill all of the enemy robots. These enemy robots will move towards the player, but the player can choose to roam around the city to kill them. When the player has killed all of the enemy robots, then the player will win the game and the game will end.</p>
<p>If the player dies before the player has killed all of the enemy robots, then the player will lose the game.</p>