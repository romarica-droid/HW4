# HW4
## Devlog
In my project, i used the model-view-control pattern to seperate my visual ui elements from my game mechanics. For instance, most of the game mechanics that are handled in the backend are through the bird, GameController, and Pipemovement class that handles all of the logic for the game. Then, i used an additional class to help with UI elements like the score and game over screen. This happened since i used a locater and used several events within the bird class that would send out a message for when the bird either hit a pipe or scored a point. I had a bit of trouble setting up the audio sources, which i decided to keep within the player class, however everything else UI related is defined in the UI class.

Elaborating futhur on the use of the Locator class, i setup a basic locator script within my project. I then created 2 events wihtin my bird script to handle both the winning and losing of the game. My first event was an addpoint event, which was sent to the UI to notify the system when the player scored a point. This message would be sent to the ui class and then add a point to the player's total points. In contrast, the endGame event was used to handle when the player hit a pipe. A message was sent to the game controller to notify that the game ended and pipes need to stop being spawned, and then sent to the UI to display the game over screen.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites

-[Pit Sounds](https://www.youtube.com/watch?v=li7kqpDKEhk)
-[Explosion Sound](https://www.youtube.com/watch?v=Y2A43FW0fb4)
-[Rupee Sound](https://www.youtube.com/watch?v=9HZ-kj3mP5Q)