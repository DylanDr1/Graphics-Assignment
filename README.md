# Graphics Final Project

(Assignment 1 can be found below the project final section)

## Video Link

Dylan Dos Ramos - 100873698  

## Controls

WASD - Movement

Space - Jumping

Top of keyboard 1-5 - Illumination

Top of keyboard 6-7 - Colour Correction off/on (off by default)
 
Top of keyboard 8-9 - Texture on/off (on by default)

Top of keyboard "- and =". Effects on/off (On by default)


## Updates 

Movement

Updated the movement slightly to flow better and for the player to move a little bit faster, as well as jump higher. This was done because I felt that the movement felt a little slow at certain points, so increasing it felt right.

Moving Platform

Updated the platform a little bit, unfortunately couldn't manage to get the player to move along it like I wanted to, however I did change how it worked slightly, just so it's a bit more optimized. This also allowed for the implementation of moving platforms to be added in at a much faster and easier pace.

![Data](https://github.com/user-attachments/assets/4c1cedfc-af68-460c-95be-ff3744e3b63c)

Hologram shader

Edited the Hologram shader to be brighter around the edges as well as have less of a see through hole in the middle of it. I did this because I wanted the ending panel to be a bit more visable, since in the previous version it was hard to see at certain angles, changing this allowed it to be viewed easier.

Before:
![Hologram before](https://github.com/user-attachments/assets/80a2523e-4f49-49a4-a6ab-4c607f1659d1)

After:
![Holoafter](https://github.com/user-attachments/assets/185fb141-78b0-4f62-8844-20f600534925)

Toon shader

Changed up the blending of the different sections a bit more, as well as made the darkest part of it a little bit brighter. This change happened because while it was nice to see such a drastic change between the different sections, it was a bit too much overall, so this change made all the sections blend together a little easier.

Before:
![OldToon](https://github.com/user-attachments/assets/85aec891-34ba-4449-9b05-70360831ed5c)

After:
![NewToon](https://github.com/user-attachments/assets/fa3c98e3-2536-497b-9fc4-c831bb6def58)

## Textures

Applied textures to both the walls, floors and the poles at the end of the level. In addition the waving effect also has a texture applied to it. These textures were applied because having a plain colour on the walls and floor made the scene look fairly pooring, so having textures on those objects made them stand out a little bit more then they did prior. 

In addition the colour pallete used mainly consisted of red, and green colours, this still keeps the colour I was going for before, which are bright simple colours. Doing this kept the style of old school platformers, in which most had bright colours in them.

Lastly the water texture at the bottom uses a pre existing texture, since i'm not the best at art, the original texture is credited at the bottom with sources for this section. I still decided to go along with this, because as i'll explain again in the visual effects, I wanted to implement a better way for the player to visualize the death barrier, since having just a random death plane didn't look the best, so instead the player falling into water just felt better for this scene.

Debug commands were also added in, so by pressing certain buttons textures can be toggled on or off.

![TexturesDiagram](https://github.com/user-attachments/assets/6a6c330f-e7da-40a0-9803-eba63e69c135)

![Texture](https://github.com/user-attachments/assets/46c433ff-d965-47e0-bf16-e469fe7d025c)

In game floor:

![FloorGame](https://github.com/user-attachments/assets/c7db9a66-5749-4a47-a309-541f52235517)

Floor texture:

![BrickCustom2](https://github.com/user-attachments/assets/457005a5-1f03-4f80-af18-8a5ac947c2ba)

In game wall:
![WallGame](https://github.com/user-attachments/assets/667e67fa-a6c2-470b-a05d-b6fdf182f7e5)

Wall texture:

![BrickCustom](https://github.com/user-attachments/assets/050f0bf2-32fe-4cf1-aa6e-ac633b612afc)

In game pole:

![PoleGame](https://github.com/user-attachments/assets/fba8a52c-bec6-41ae-8652-a5fe1656c6e5)

pole texture:

![Pole](https://github.com/user-attachments/assets/25df50b5-7da4-4490-8594-195c10183b75)

Water texture:

![Water_001_COLOR](https://github.com/user-attachments/assets/b6482454-d3f7-443a-b05b-55b0157e86fc)

## Visual effects

As for the visual effects, the first one added into the game uses the wave effect seen in class, however, it's changed around. The one in class simply moved up and down in a fairly small interval. However with this updated one, it allows for the movement and speed of the wave to be at a greater degree, and allows for a more accurate and less sharp wave for the effect. In addition, this effect also scrolls across the plane, allowing for it to look even more like a wave. As stated previously, this effect was implemented into the scene because instead of having a simple invisible death barrier, I thought it would be better to have some water moving at the bottom, to give the illusion of the player falling into the water and dying, instead of randomly being teleported back up after a set time.

![Water1](https://github.com/user-attachments/assets/8b732741-0940-4467-8619-a26e497706b1)

![Water2](https://github.com/user-attachments/assets/07f64514-c9b4-4542-8d1b-f25416e49e0d)

The other visual effect that was implemented into the scene, was that of a lens flare, now I decided on this one because I thought it added a nice value to the scene, having a lens flare simply made the lighting look a little bit better than without it, so adding this in improved the scene slightly. This was also done by applying a lens flare effect onto the players camera, and also applying a flare layer ontop of that, these are both important, since if its not attached to the camera, it won't appear for the player, in addition, the flare layer actually makes it viewable in gameplay, as without it the camera isn't able to see it.

![LensFlare](https://github.com/user-attachments/assets/9aee2beb-d5b8-48e5-bf04-c73d0604a231)

In addition, the visual effects can be toggled on and off by pressing the Debug keys found at the top of the ReadME
![effects](https://github.com/user-attachments/assets/83dd2591-a50a-4924-93a9-afe18a61683d)


## Sources

Wave effect: Original code taken from the lecture. Modified the code to allow for the implementation of an additional texture to give the illusion of foam on the waves. In addition allowed for both textures to scroll, giving it the sense of moving water. 

Water Texture for waves: https://3dtextures.me/2017/12/28/water-001/

Water texture was used because I wasn't confident enough in my artistic skills to portray the look of water, this texture was also provided in class, so I felt that it was good enough to use for this project.  

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

