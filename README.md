# Space War
Name: Jiyuan Liu

Student Number: D17129141

Class Group: TU856

# Description of the project
This will be a 3D project showing a combat between space fleets of two planets. Space ships with various steering behaviours will be implemented in the project.

# Storyboard
The story is about the war between two planets. One of the planets is called Astra, and the other is called Traiwynd. Both planets are poor in resources and need to be sourced from other planets. And the space fleets of these two planets often clash over resources as they explore the universe.
The scene takes place when the space fleet of Astra returns from the exploration of the planet encountering with space fleet of Traiwynd. The space ships pursue the mothership at beginning. When enemies appear, they move and fire towards the enemies to cover the evacuation of the mothership.

# Video Demo
https://youtu.be/5sU4OvV2moU

# Most Proud Of
I am most proud of design of different scenes, different steering behaviours implemented for space ships, and the space portal implemented by shader graph and particle system.

# Events Summary
1. Astra fleet completes resource extraction and leaves the planet.
2. Astra fleet dodges meteorites in the path.
3. Traiwynd fleet emerges from space portal.
4. Astra fleet changes route to escape.
5. Traiwynd fighters pursue Astra fleet and shoot laser attacks.
6. Astra fighters depart.
7. Astra fighters and Traiwynd fighters attack each other using laser beam.
8. Astra fleet escape through space portal.

# How It Works
## Behaviours
- Seek: Add force towards the target.
- Arrive: Add force towards the target but slow down when arrives.
- PathFollow: Add force to move along way points.
- Pursue: Add force to follow a target.
- OffsetPursue: Add force to follow a target with specific offset.

## Weapons
- Laser beam: Prefab that moves forward after generation.
- Astra fighter controller: Control Astra fighters to instantiate laser beams.
- Traiwynd fighter controller: Control Traiwynd fighters to instantiate laser beams.

## Space Portal
- Shader Graph
- Particle System

![image](https://github.com/KIERANLJY/Games-Engines-2-Assignment/blob/main/Images/shader.png)


## Canvas
- Replay button: Replay the project from first scene.
- Quit button: Quit the application.


# Classes
- AstraFighterController: Wrote by myself
- AstraFighterSpawner: Wrote by myself
- Boid: Modified from course code
- CameraFollow: Wrote by myself
- DontDestroy: Wrote by myself
- LaserBeam: Wrote by myself
- LookCamera: Wrote by myself
- Menu: Wrote by myself
- MovingCamera: Wrote by myself
- ObstacleAvoidence: Modified from course code
- Path: Wrote by myself
- RandomRotator: Wrote by myself
- ScenesTransition: Wrote by myself
- ShipBoid: Modified from course code
- SteeringBehaviour: Modified from course code
- TimeupSceneTransition: Wrote by myself
- TraiwyndFighterController: Wrote by myself

# Resources
Skybox: https://assetstore.unity.com/packages/2d/textures-materials/sky/starfield-skybox-92717

Space ships models: https://www.aigei.com/unity3d/model/airship_5/

Asteroids: https://assetstore.unity.com/packages/3d/environments/asteroids-pack-84988

Audio souce: https://www.youtube.com/watch?v=zUrSQNSN6_c


