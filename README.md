<html>
<body>
<p><b>Name:</b>Marcus Gleeson<br>
<b>Student Number:</b>D19124543<br>
<b>Class Group:</b>DT508
</P>
<p>This was a new unity project that I started at the start of reading week, all modeles and assets are assets that I have created myself</p>

<h1>Description of the project</h1>
<p>
This game is a 3D first person shooter that is based in a percedural generated city.
You will take control of a first person character and using your weapon and the allocated grenades, you will need to defeat the hordes of enemies.
The city is percedural generated using perlin noise which makes the city unique due to the buildings being a variation of heights.
In the game you will have a choice to player the game in either colour or greyscale, which offeres a new way to see and play the game.
The goal of the player is to kill all the enemies to win the game, but if the player is killed, then the player will lose the game.

</P>

<h1>Instructions for use</h1
<p>
Upon starting the game, you will be greeted with the main menu.
There will be three tabs at the top, <b>Start</b>, <b>How To Play</b> and <b>Quit</b>.
<ol>
  <li><b>Start:</b> From this tab you can choose to play the game in <b>Colour</b> or <b>Greyscale</b>. There is also the Start button to Start the game.</li>
  <li><b>How To Play:</b> This tab allows you the view the controls of the game.</li>
  <li><b>Quit:</b> This tab allows the player to quit the game.</li>
</ol>
<h3>Character Controls</h3>
<p>
<table>
  <tr>
    <th><b>Task</b></th>
    <th><b>Controls</b></th> 
  </tr>
  <tr>
    <td>To Move The Character In The Game</td>
    <td><b>The W,A,S,D Keys</b></td>
  </tr>
  <tr>
    <td>To Make The Character Jump</td>
    <td><b>The Space Bar</b></td>
  </tr>
  <tr>
    <td>To Shoot The Characters Weapon</td>
    <td><b>The Left Mouse Button</b></td>
  </tr>
  <tr>
    <td>To Throw Grenades</td>
    <td><b>The Right Mouse Button</b></td>
  </tr>
  <tr>
    <td>To Bring Up The Menu</td>
    <td><b>The Escape Key</b></td>
  </tr>
 
</table>
</p>
</P>

<h1>How it works</h1
<p>
Upon starting the game, you will be greeted with the main menu.
There will be three tabs at the top, <b>Start</b>, <b>How To Play</b> and <b>Quit</b>.
<ol>
  <li><b>Start:</b> From this tab you can choose to play the game in <b>Colour</b> or <b>Greyscale</b>. There is also the Start button to Start the game.</li>
  <li><b>How To Play:</b> This tab allows you the view the controls of the game.</li>
  <li><b>Quit:</b> This tab allows the player to quit the game.</li>
</ol>

Upon the player pressing the start button, You will take control of a first person shooter, enemies will start to spawn immediatly from three different spawn points around the city.
The enemies will spawn staggered into the game with two seconds inbetween each spawn. When the enemies count reaches 10, the spawning stops. 
A total of 20 enemies will spawn in the game, and for every enemy you kill, another will spawn in its place.
</P>
<p>Whe you press the start button, the game will randomly choose between four different songs from an array, This song will play in the game and when the song finishes, it will randomly pick another song.
   In the game There is a a bright sun that has two rotating circles of cubes that react to to song that is being played, wach cube tha spawns has post process effect on them, so when they spawn in each cube will be a different colour.</p>
<p>The goal of the player is to kill all the enemies using the players weapon and the allocated grenades.
How to player kills the enemies is up to the player, the player can wait for the enemies to come to the player or the player can roam around the city and kill the enemies.
If the player kills all the enemies, then the player will win the game but if the player loses all there lives, then the player will lose the game.</p>

<h1>References</h1>
<p>
https://www.youtube.com/watch?v=_QajrabyTJc&t=1289s&ab_channel=Brackeys

</P>

<h1>What I am most proud of in the assignment</h1>
<p>
If I was to choose what I was most proud of in the assignment, It would be very difficult to choose one, so I have choosen my top three.
<ol>
  <li><b>The GreyScale shader:</b>It was simple enough to create and what I like to most about the shader, is that it adds another way that the player can play the game. 
         In my opinion I perfer the greyscale version of the game more then the coloured version of the game. 
         A feature I like is the ablity to switch from colour to greyscale view or vice versa at any time, by simply bring up the games menu in game.</li>
	<img src="/images/GreyscaleInGame.png" style="width:128px;height:128px;">

  <li><b>Percedural city:</b> I was very pleased when I got the percedural Generated city working. On top of getting the city to generate, I was pleased to be able to get the perlin noise to work aswell.
	This allows the heights of the buildings to be a varity of different sizes, which makes the city feel more alive, instead of prefabs of ready made building being spawned in.
	Not only does this allow the city to be unique, each time the game is played, but I also feel that it will add some more playablity to the game.</li>
	<img src="/images/City.png" style="width:128px;height:128px;"> 
  <li><b>Enemies:</b>The last part of what I was most proud of in the assignment was, The enemy assets, which I made in the blender 3D modelling software. 
         I built the walking animations for the enemies in Unity and I coded them that each enemy will be a different colour when they spawn in. 
         I was really happy how they turned out and I think they add to the game very nicely.  </li>
	<img src="/images/Gonk.png" style="width:128px;height:128px;">
</ol>
</P>
<h1>Game Proposal</h1>
<p>For my Game Engines Assignment, I will be doing a procedurally generated city shooter game. This city will feature procedurally generated buildings of different heights that the player can roam around.</p>
<p>On top of the procedurally generated city, I will look at using the unity spectrum data to make a sphere in the game look like a sun with rotating rings that reacts to the sound of the game music.</p>

<h2>How will I achieve this?</h2>
<p>I will achieve the procedurally generated city by using Perlin noise. This technique will allow me to have some of the buildings, different heights in the game as it will sample the Perlin noise and then instantiate the building's height from that sample of the Perlin noise.</p>
<p>To achieve the unity spectrum data, I will get the songs data from the audio source and then from that data I dynamically change the height of the cubes which form up the rings that rotate around the sun. To add a bit more flare to the game, I will use unity post-processing effect so that I can have each of the cubes that form the ring around the sun, a different colour.</p>

<h2>Player's gaol in the game</h2>
<p>The goal of the game is for the player to kill all of the enemy robots. These enemy robots will move towards the player, but the player can choose to roam around the city to kill them. When the player has killed all of the enemy robots, then the player will win the game and the game will end.</p>
<p>If the player dies before the player has killed all of the enemy robots, then the player will lose the game.</p>

<h2>Links to videos or websites that have helped me</h2>
https://www.youtube.com/watch?v=Ri1uNPNlaVs&ab_channel=PeerPlay

<h1>In game images</h1>
<img src="/images/menu.png" style="width:128px;height:128px;"> 
<img src="/images/InGame.png" style="width:128px;height:128px;"> 
<img src="/images/InGameColour.png" style="width:128px;height:128px;"> 
</body>
</html>
