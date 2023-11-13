# Assignment 1: Escape the maze

## Functionality

The game I implemented has the player starting at one side of a maze, trying to reach the other end. To do so, the player can move forwards and backwards (W/S keys respectively) and turn (A/D keys).

Before reaching the goal area, the player must collect all four coins, each of which is located in one of the corners of the maze. To exit the game, press the ESC key. There is no option to restart besides quitting the game and actually starting it again. However, there are no real fail conditions or dead-locks unless you fall off the floor in the very beginning.

## Implementation

To start of, i generated a layout for the maze using the website <https://mazegenerator.net/>. Then, I loaded the resulting image into Blender, where I created the model for the maze, because I am more comfortable with modelling on Blender as compared to Unity due to more experience.

### Finish Area

The model can then be easily used in Unity, just by saving the .blend file in the Assets folder. I had to go back and recalculate the normals of some faces, because otherwise the model would be see-through from the wrong directions.
In Unity, I then added a floor to the maze, as well as a player character (cylinder), spheres for the coins and a finish area. I added colliders to all models and the rigid body physics to the player. Originally, I had intended for the player to have to run into a movable object to finish the maze, however this was changed during the course of implementation.
In the final submission, this movable object in the goal area still exists, but the ending is triggered by a box collider applied to the floor of the finish area. Once the player touches this collider, a script checks whether the player has a score of 4. If this check is successful, the HUD displays a congratulatory message, otherwise a hint is added about the requirements (i.e. collecting all coins from the corners.).

### Collectibles

Once the player touches one of the collectibles, their score is incremented by one (up to a maximum of 4, because there are four collectibles). To signal that this collectible has been collected and to prevent collecting one coins multiple times, the object is then removed from the scene.

### Movement

The player moves backwards or forwards with the W/S keys. The A/D keys allow the player to turn left or right. I choose this layout over the more standard move left/right control scheme, because it made it easier to have the camera follow the player, always looking in the direction the player will move when pressing the W key.
This was achieved by having the camera be a child of the player in the Unity hierarchy. Thus, when the player-character rotates, the camera rotates around the player, keeping its distance.

I have also added controls to change the distance of the camera to the player. When rotating the mouse wheel, the distance and rotation of the camera changes between a low and a high point. By default, it is almost but not quite as low as the controls allow, slightly above the player and tilted down slightly.
At the lowest point, it is directly behind the player. At the highest, it is above the player looking down. This can be used to adjust the difficulty level and to peek over walls.

Unfortunately, at the lowest setting (which does not show anything about the layout of the maze other then the corridor the player is currently in), rotating can cause the camera to go through walls, potentially revealing coins. Due to time constraints, I did not look into preventing this.

One problem I encountered during development was the player-character falling over after colliding with a wall, i.e. rotating one the x or z axis. I fixed this by constraining rotation to the y axis in the rigid body component. To quit the game, the player can press the Esc Key.

### Materials + Lightning

I did not spend a lot of time on making sure that the game looks as good as it could. I added simple materials to all objects, with the coins glowing slightly. I also added a bit of fog, because I think it makes the maze seem more mysterious and less bland. I would probably have preferred a different skybox and a more nuanced lighting, but I did not have enough time to play around with this and stuck mostly with the defaults here.

### HUD

I added a static, non-moving text field at the start of the maze explaining the controls and the goal of the game. I also added a text-field that moves with the camera, which shows the progress in collecting all coins. If the finish is reached after collecting all coins, this text changes to a congratulatory message. If the finish is reached beforehand, a message is added to this HUD, hinting the player at what the win condition is.
