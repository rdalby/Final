# Temporal-Fizz
### Rachel Dalby

## Overview:
My game follows a school kid on their journey through the ages. The kid was tasked to go to the history teacher’s office. Where the History Teacher instructs him to go to the bookshelf and look at the popcans (soda). He sees one that has a red unearthly feel to it and some cheesy tagline. The Kid decides to drink it and it transports him to pre-historic times. The kid must solve the clues to defeat each “boss” that will be guarding the next pop. Must drink the pop to get to new level but don’t have to right away. You go through that pattern until finally back to the present.

### GitHub Repo:
[Final](https://github.com/rdalby/Final/)

### Designed and Programmed in: 
Unity Version: 2020.3.19f1

### Genre: 
Third-person open world adventure

### Controls: 
- Arrow keys/ WASD keys for movement
- Enter key to pickup/drink 
- F key to throw picked up item
- Mouse to move camera (highly recommend to use movement keys for better game play)

### Starting Scene: 
Opening Scene

### Downloading/Running project comments: 
When opening I had to remove the library folder to get it to upload as it was over 9gb and it exceeded my github upload allowance. But it should auto-create a new library folder when you import the project into unity. There are some files there I did not remove from some packages I imported but ended up not using I did try to clean it up the best I could but also leaving some for the expanded version of the game. The import errors you may receive on some of the models should be fine as they are not used in the scene and it runs without those references. 

If you need the full project file with nothing deleted (over 40gb not sure how it got that way other than maybe the 4k textures) or the simplied version with library (roughly 12gb) I can provide a sharepoint or drive link if necessary. (rdalby@hsph.harvard.edu)

---

## Walkthrough: 
**Opening Scene**  
*press ‘enter’*

**School Scene**  
*Leave classroom stopping by classmate, go to end of hall where Principal is then go upstairs. English Teacher can’t give you and up so go down next hall to the end. The end room is the History Teacher’s office. It is a mess he is seen in back right corner mumbling to himself. He said says to go to popcans, go to 2nd bookshelf and collide with tipped over popcan. Popup comes up on screen press ‘enter’*

**DinosaurScene**    
*Do not go to the TRex right away you will die. Instead head towards the maze. Inside the maz there will be a bone to pickup. Once you get to the bone press ‘enter’ to pick it up and it gets deposited into your inventory and an icon comes up on your screen. Find your way out of the maze and head towards the TRex. It will start to follow you as you get closer, throw the bone using the ‘f’ key. The TRex will then go towards the bone and drop the popcan on its tail. Head towards the popcan avoiding the TRex as it can still damage you. A popup will appear once you are in range of the popcan. Press ‘enter’ this will bring you to the demo end screen.*  
  
*However if you end up getting damaged by the TRex there are first aide kits littered throughout the scene. They do not add a lot of health but there is enough to give you a full health bar from the end. So if you come into trouble you can find through. Though if you lose all you life you will be transitioned to the Game Over screen.*  
  
**Congratulations**  
*You have completed the demo of this game and the first 2 levels. Press ‘enter’ to get back to the title screen.*  
  
**Game Over**  
*You have the option to replay the last scene or go back to the title screen. You will restart the entire scene if you replay it.*  

---

## Elements

### Game Scenes:
Opening Scene  
Dinosaur Scene  
School Scene  
Congratulations Scene  
Game Over Scene  


### Levels:
School  
Pre-Historic  

### Scripts:
BossItem.cs  
Congratulations.cs  
Enemies.cs  
EnemiesMovement.cs  
GameOver.cs  
HealthBar.cs  
ItemIndicator.cs  
LoadsceneOnInput.cs  
NPC.cs  
Player.cs  
PopCan.cs  

  

### Characters:
*Player*
- Third person view
- Shows icon of item in UI when picked up
  
*Dinosaur*
- Boss
- Throw bone to defeat
- Once in bones radius drops pop can 
- Health Bar (not enabled)
- Shows damage to enemies
- Enemies disappear when damage bar goes to 0
  
*NPCs*
- Classmate, Principal, English Teacher, History Teacher
- Cannot be damaged or killed
- Popup dialog when close with clues on where to go
  
  
### Player Life: 
- option to gain life back by picking up random item in level
- Loss of life brings you to game over screen with extra hint
- Health bar displayed at top of screen
- Boss takes out half your life
  
  

### Levels:
*Backgrounds/scenes change depending on era*
- School
- Rocky/trees/water/mountain
- Pre-mapped maps not dynamically created
- Open space
- Objects, containers, items, and bosses
  
  
### Items:
- Items are required to be found and picked up to defeat each level’s boss
  
*Pop Cans*
- Drink when pressing the enter key while the popup is active
- New design/name for each era
- Choosing drink option
- Screen goes black 
- Signals transition to next scene
  
*Boss Items*
- Pickup while popup is displaying
- Disappears when picked up but icon displays showing you have it
- Throw with f key
  
  
### Clues: 
- Level specific
- Game Over’s scene has clue
  
  
### Dialogs:
- NPCs will give helpful hints
- Storyline Dialogs will come through
  
---


## Scene Design Choices:
### Opening Scene, Congratulations Scene, and Game Over Scene:
  
*Skybox*  
- underwater skybox 
- felt surreal and that’s what I imagine the game to be
  
*TextmeshPro boxes*  
- allowed for better font options
  
*Keyed input to go to next screen*  
- I don’t want a lot of focus to be on mouse use as it can get the character slightly messed up. But it is necessary to look around to find the items so I need the mouse input there. 
  
*Option to go back to previous scene (Game Over Scene only)*  
- I didn’t want the user to have to go all the way back to the school to get to the dinosaur scene again especially because it does take a minute to do that. Also because it only takes 2 hits for the boss to kill the player. I didn’t want to make it to easy either. 
  
### School Scene:
  
*Skybox*  
- Clearday skybox 
- tried to brighten up the scene with the lighting as best I could
  
*HUD UI*  
- Dialog boxes that pop up as the player gets closer to NPCs
- NPC hints in the dialog boxes 
- Free image for the background
- TextmeshPro for the text in the boxes
  
*Player*  
- Third-person controller for best animation
- free-look camera Cinemachine allows for good followup
- Camera focus point needed to make sure it focuses on the right area
- School outfit

*NPCs*  
- Each have animator
- Some sort of popup message on trigger stay
- positioned strategically to allow for decent direction for the character
  
*Characters*  
- I created each character in Realme Player’s avatar builder and exported them
- I had 1 base male character that I used didn’t textures and materials to create a different feeling character
- I modified the models in blender to combine the neck and head onto some of the avatars I created in realme player
  
*Animations*  
- some were created and modified by me
- downloaded some animations from mixamo
- Fade into the scene was created by me to give the player some sort of transition
  
*School layout*  
- used snap prefab office for the walls, floor, ceiling
- modified the textures and materials of the prefabs
- removed some elements from the prefabs
- combined objects and models to create my own prefabs
- created and modified textures and materials in photoshop to meet my needs
- wanted to make it feel like a school and have the base for other items to be used
- all objects were manually entered/modified
  
*Terrain*  
- added terrain in as I wasn’t sure if I would allow for more movement later
- I wanted to set the base for if I allowed outside wanderings
  
*Lighting*  
- I had to generate a lighting mask or the scene would constantly be to dark or to bright


### Dinosaur Scene:
  
*Skybox*  
- Unearthly skybox 
- I wanted something that really made it seem like it changed and this 
  
*HUD UI*  
- Health bar that follows the users health
- item indicator for when you have the item
- popups for both the item and popcan that are triggered by proximity
 
*Terrain*  
- mountain with snow
- hills with trees both dead and alive
- water section with moving water
- grass that moves in the wind
- rock maze with textured rocks
- dirt, sand, moss, and snow ground textures underneath design elements
  
*Rock maze*  
- each wall is made out of a bunch of rock models I put together
- tried to rotate and turn upside down to lose the impression of repeated walls
- will later house additional enemies that you will have to fight or run from
  
*First aide kits*  
- a way to get health back 
- littered throughout the level
  
*PopCan*  
- on dinosaurs tail
- falls off when giving dinosaur bone
- popup comes up when you are in it’s trigger zone to drink it
- this brings you to the end of the demo screen
- box collider needed to be expanded or you would lose the popcan in the grass at times
  
*Dinosaur*  
- has a range when it will come after you
- stays in idle animation until it’s within range then walk animation
- when it’s super close it changes to a bite animation
- when the item is within range and a flag is sprung popcan detaches as child from dino
- Takes out 50 life points if colliding with even after item falls (on purpose)
- goes after the item when in range instead of player
  
*Player*  
- different outfit
- planned on creating animation with player standing up and looking around
- Found that animations stop working when moving
- camera issues with following the character and directing to where the character looks
- hierarchy is like it is to allow for best camera to player view
- when getting the item the item icon is displayed and item disappears
- use *f* key to throw the item 
- can pickup and throw item as much as you want until boss gets to it
  
*BossItem*  
- bone
- needs colliders messed with to turn to trigger and back again to properly do what it needs to do without colliding with excess things and having random physics happen to it.
- Dino goes after item instead of player if the item is within range
- triggers popup when player is close
  
*Animations*  
- really put in a lot of effort for the dino to have animations
- needed to create a mex from the model that I had
- There were some animations for the model already but they did not work w/o the mesh
- used blender to create the mesh for the dino
- Fade into the scene was created by me to give the player some sort of transition
  
*Textures/materials*  
- Searched for some really realistic ones to get full effect
- Adapted materials to be used for other models
- photoshoped textured to create new materials

---

## Scripts Usage:
**Congratulations.cs (CongratulationsScene) - 
GameOver.cs (GameOverScene) - 
LoadSceneOnInput.cs (OpeningScene)**  
- Purely for getting input for next scene. I have additional plans for the GameOver script and congratulations scripts. Hence why I didn’t just expand on the LoadSceneOnInput script
	
**HealthBar.cs (DinosaurScene) - 
ItemIndicator.cs (DinosaurScene)**  
- Informative and ones that just initialize the objects used for later

**Enemies.cs (DinosaurScene)**  
- Not used at this time but will be used and setup to be used later

**NPC.cs (SchoolScene)**  
- Used for scripting and showing each different NPC’s hints in the school scene

**PopCan.cs (SchoolScene)(DinosaurScene)**  
- Controls when the popcan can be grabbed. Needed to adapt to trigger then not trigger depending on if it is being attached to the Dino’s tail or not. Then having gravity when falling can’t use Kinematic and have force applied to it. So I needed to make the popcan’s adaptable in that sense. I made it generic to apply to any of the popcan items for different levels

**EnemiesMovement.cs (DinosaurScene)**  
- The main script for AI movement for the enemies. I wanted them to follow the player or if it was boss to follow the item over the player. Generic so it can be applied to all enemies.

**Player.cs (DinosaurScene)**  
- Contains all the data for the player. How much health it has for the health bar to use on the HUD. If you have the item it is the code to use “f” to throw the item. Has what each enemy does for damage put in. Can alter those as it moves on and forward. Methods for when colliding with first aide kits and how much health they give back. Also modifications to the bossitem for how it needs to be setup to be thrown. All the bossitem code would not work in the bossitem class I had to separate it or it would not apply the settings to the game object for some reason.

**BossItem.cs (DinosaurScene)**  
- Adapts the item to trigger or not trigger depending on what is colliding with it. Sets up the rigidbody attributes to make sure that it can be collided with and not sink through the terrain. Has the code for when it gets pickedup. OnTriggerStay is used repeatedly as that allows for the popups to stay up and not blink away after update is ran.

    
  
---

## Difficulties: 
I had a number of difficulties with my project the terrain was a tricky one as I wanted to get something that felt “real” and the more realistic I went the more I realized that I needed to adapt other elements to match. I pulled in some terrain tools from a package and some terrain textures to get look and feel down. Building the terrain was a trial and error type of situation and I kind just kind of went through each section learning what each part does.  

The Item picking up and throwing section was really hard I had to convert to a trigger on collide then out again when you left the trigger. Then if you picked it up having to change more settings. It was extremely difficult and combursome and looked off when it was animated. I could get the pickup fine but for some reason throw the item I couldn't get it to modify. Same goes for it I attached the item first and just tried to throw it I could get the throw down but no pickup. So I opted for a setting the item inactive on pickup and then transforming to the characters position on throw and adding force to it to go towards where you were throwing. I used this concept for the popcan on the Dinosaurs tail.  
  
Animations were a struggle for me but I got them working and figured out how to adapt downloaded ones to work with humanoid figures. Also how to modify and create my own animations. I used blender to create some meshes and skeletons for the models I didn’t have so I could use animations on them. I did not include a number of my animations in the final project as they did not get to be completely utilized. I wanted to create some animations going into the scenes and whatnot but there was just not enough time to get everything I wanted in. I was however able to get each of my NPCs, Character, and Trex animated. I plan on adding in some animations for the HUD UI later.  
  
Then came the lighting issues. Especially with the school scene I could not get the lighting to work inside the school with lights. Everything was either way to bright even with the intensity turned down or super dark. Both ends of the spectrum lost all the details I had put into the design of the school. 
Then I had issues with the item pickup/throw. I could get the item picked up and attached to the character just fine but I could not get the throw. I figured out that I could just set it to inactive and put the icon in the HUD instead. Then do the other computing I needed making it look like it came from the player without it being attached to the player. It actually worked out better as the bone for the dinosaur scene is rather large and looked off when the player ran with it.  
  
These are just the big issues that I ran into and they took a lot of time to work through. I did however adapt my code to be generic for each continuing level so I could reuse a lot of my scripts. I tried to make it as flexible as possible.  

I spent over 80 hours on what is here and some additional items that I had removed/extracted that goes to later levels/expanded versions of current levels that I was not able to finish in time. Including more items/background characters in the school scene, as well as, bigger playing area including outside. In the dinosaur level there is an enemies script that I started to set the framework in for the enemies and how they will take damage on collision. I had some additional models created for the enemies but they had issues with the gravity and animations to the point that they would up in the area and not come down. I realized it had to do with the colliders and how they initially collided and how they weren't updating the gravity. As such I removed them to make a more uniform scene.  
  
I do plan on continuing this game as it is something that have enjoyed and I find myself getting sucked into it. I plan on expanding it out at least to 8 different levels and having rotating hints for each scene on random and scripts for the NPCs and transitions. 
  
---
  
  
 ## Expanded Scope:
8 total levels to time travel to different bosses in each level  
additional enemies  
items to pickup on the level that react to the scene  
Weapons to use against enemies in level  
  
  
---

## Software I Used to edit/create: 
Photoshop  
Blender  
RealPlayer me – model builder  
Mixamo - animations  
Unity Asset Store


## Imported Assests: 
*most prefabs and models were additionally modified by different uses of textures, designs, animations, and scripts*  
*Unless otherwise linked all items were found in the [unity asset](https://assetstore.unity.com/) store under their name*

*Terrain*  
- Terrain Textures Pack Free
- Terrain Tools Sample Asset Packs
  
*Skyboxes*  
- Skybox Series Free

*Animations*
- [Mixamo](https://www.mixamo.com/#/) for animations 
- UMotion Community - Animation Editor
  
*Models*  
- Characer bases [RealPlayer Me](https://readyplayer.me/)
- Trex -[Tyranosaurus Rex (Animated)](https://skfb.ly/o6KUK) by SpiderCraft9972 is licensed under [Creative Commons Attribution](http://creativecommons.org/licenses/by/4.0/)
- School assets
- School Globe
- Table angular
- Student ID
- School Supplies
- Sci Fi Food Pack
- Horror School Props
- Toon Furniture
- QA Books
- First-Aid Set
- FREE Rigged Skeleton and Bone Collection
- Free Rocks
- Snaps prototype | office
- Human Character (FREE Sample Pack)
  
*Sprites*  
- Free icons set
  
*Textures*  
- Floor Textures -4K
- Low Poly Free Vegetation Kit
- Outdoor Ground Textures
  
*Misc*  
- Standard Assets

  


## Packages Used In Project: 
  
Cinemachine  
Input System  
JetBrains Rider Editor  
ProBuilder  
ProGrids  
Test Framework  
TextMeshPro  
Timeline  
unity UI  
Version Control  
Visual Studio Code Editor  
Visual Studio Editor  
