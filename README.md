# Graphics Final Project

(Assignment 1 can be found below the project final section)

## Video Link

## Controls

WASD - Movement

Space - Jumping

Top of keyboard 1-5 - Illumination

Top of keyboard 6-7 - Colour Correction off/on (off by default)
 
Top of keyboard 8-9 - Texture on/off (on by default)

Top of keyboard "- and =". Water texture on/off (On by default)

Near top of keyboard [ and ]. Lens Flare on/off (On by default)

## Updates 

Movement

Updated the movement slightly to flow better and for the player to move a little bit faster, as well as jump higher. This was done because I felt that the movement felt a little slow at certain points, so increasing it felt right.

Moving Platform

Updated the platform a little bit, unfortunately couldn't manage to get the player to move along it like I wanted to, however I did change how it worked slightly, just so it's a bit more optimized. 

## Textures

Applied textures to both the walls and the floors of the level. In addition the waving effect also has a texture applied to it

## Visual effects


## Sources

Wave effect: Original code taken from the lecture. Modified the code to allow for the implementation of an additional texture to give the illusion of foam on the waves. In addition allowed for both textures to scroll, giving it the sense of moving water. 

Water Texture for waves: https://3dtextures.me/2017/12/28/water-001/

Photoshop: Used Photoshop for developing the textures

 # Graphics-Assignment 1
 
 # Video Link

https://www.youtube.com/watch?v=aoVxDwX6p4U

Dylan Dos Ramos - 100873698  

# Controls

WASD - Movement

Space - Jumping

Top of keyboard 1-5 - Illumination

Top of keyboard 6-7 - Colour Correction off/on (off by default)


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


# Ilumination

The illumination script was done by taking a GameObject, and 3 different materials and setting them all up into a script, allowing them to be changed out whenever the player wanted. This is done by swapping out the material with a given button using MeshRendering and getting the component. In addition enabling and disabling lighting, and setting particles to be active or deactivated.

![Illum](https://github.com/user-attachments/assets/e294e2d9-f641-4620-979d-cd8c13e73e27)
![IllumCode](https://github.com/user-attachments/assets/b7433d4c-a779-4e5a-a063-c17874d6a6f2)

# Colour Grading

The Colour Grading is done by using a LUT map, and applying it onto the camera, in addition having the LUT Shader Script also allowed the Colour grading to take effect. The swapping was also done via pressing buttons to turn it on and off. Using the certain colour grade that’s in this build allowed the game to have a much older feel to it, having a similar look to some gameboy games, but 3D. In combination with some of the toon shaders used in this level, it really adds to the visual style I’m currently aiming for with the game.

![ColourGrade](https://github.com/user-attachments/assets/ed479c42-ce17-42d0-b5b4-5b7c50bcd817)


# Shaders

Toon

Starting off with the main shader being used in the scene, being the toon shader. I decided to go ahead with this shader mainly because I like the look and visual style of those games, and I thought it would mesh well with the colour grading. Right now the toon shader is applied to an NPC at the front of the level, and on the circular platforms, however I’m aiming to make some more basic models and use them to show off the Shader a little bit more.

In terms of how it was used, I used the given toon shader from the lectures as a base, and built off of that, adding in an extra area for the light to be applied to, having this extra area can allow the shader to have a little more visual appeal as well.

![ToonCode](https://github.com/user-attachments/assets/2b5d736f-5312-462b-8c3e-eeaeb1002cf7)
![Toon](https://github.com/user-attachments/assets/84b47f53-6c12-4b8d-8ac0-ecb203ee894d)

Hologram

For the second shader adding in the Hologram felt like the correct addition. This shader was applied to an NPC at the front of the level, as well as the moving platforms and the end of level gate. Having it on the moving platforms made it feel more like it was a moving glass floor, and while it wasn’t the original intention to make it feel that way, adding it onto that object looked nice, so keeping it just felt right.

For the implementation of it, using the hologram shader that was provided in the lecture notes was the main base for the shader, however playing around with it a little bit, I increased the rim lighting on it, and increased how bright the center of the Shader was.

![Bright](https://github.com/user-attachments/assets/70d9c780-92f9-4f2d-8594-3f4c71219c85)
![Holo](https://github.com/user-attachments/assets/83d3a8aa-712c-4a1b-8e66-21c3c89681d6)


# Sources

Toon shader base - Lecture notes

I used the toon shader provided in class as a base so I could properly build on top of it without just starting all the way from scratch. This saved some time, and allowed me to learn a little bit more on how the shader actually works.

Hologram shader - Lecture notes

I used the Hologram shader from the lectures as a base to be able to mess around with it. Since the hologram shader is pretty basic, I only changed a few parts of it. That being the size of the hologram's rim, the colour of the hologram, and the brightness of the hologram. 

Specular lighting - Lecture notes

The specular lighting was also used as a base to be changed around with. This allowed me to learn more about how the lighting model of the shader worked, how it could be changed, and how it could be implemented properly into the scene.

LUT/ScreenCameraShader

I decided to use the LUT shader code provided in class since it worked well with the effect I was trying to achieve, that of course being the old school retro look, mainly by using a lot of lime green for the colour correction. In addition I attempted to go without the screenCameraShader, however I figured that it was a required component of the code, and since the code is so small, I couldn’t figure out a way to go about it a different way. 

