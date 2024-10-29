# Graphics-Assignment
 
 # Video Link

https://www.youtube.com/watch?v=aoVxDwX6p4U

Dylan Dos Ramos - 100873698  


# Base Game

Movement

The movement system is pretty simple overall, it calls to see what button the player is pressing, and responds with the corresponding action depending on what direction they pressed. For jumping however, it adds an extra element, that being if the player is grounded or not. If they player is grounded, then the game will let the player jump, however if the player is not grounded, then the game will not let the player jump. 


![Movement](https://github.com/user-attachments/assets/097ffe88-7a43-41a4-a126-4aa3acb44bdb)
![JumpCode](https://github.com/user-attachments/assets/1e13153e-88cd-4163-8c2a-2f2fcccad6f2)


Moving Platform

The moving platform works by getting the speed from the inspector, as well as the start point, and the end point of its path. Using this information it determines how fast along the path it should move, once it reaches it’s destination the game checks if the positions match, and if they do match it sends the platform to the start point after a set time period. Then after it reaches the original point, the process restarts again. 

![MovingPlatform](https://github.com/user-attachments/assets/486ccafb-ec67-4133-aad9-50af8b3f9712)
![CodePlat](https://github.com/user-attachments/assets/afca512c-4ca7-4c28-b315-e381e89eed10)

Win/Loss

The Win/Loss condition triggers whenever the player touches a certain tag. For the loss condition, it results from the player falling off the map, respawning them back onto the starting platform. This was pretty much needed, since without it the player would be falling forever without a way to get back to the game.

As for the winning condition, it comes from the player finishing the level and touching the ending goal post, prompting the player with a retry or a quit button. 

![DeathPlane](https://github.com/user-attachments/assets/d4597264-be86-40d5-a8a7-5d05e89eebb2)
![Win](https://github.com/user-attachments/assets/98e708d1-4c06-4dd1-89cb-280f4bebee68)
![Death](https://github.com/user-attachments/assets/01159866-635c-4be5-ae6e-af6bf4bc3ef9)
![End](https://github.com/user-attachments/assets/2d018d2b-2173-42c7-ad00-b2e26b5bc3d3)
