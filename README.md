# Unity Billboard Demo

Note: this project uses Unity 4.6.1. Created to answer [this question](http://www.reddit.com/r/Unity3D/comments/2ssgzr/moving_world_coordinate_screen_space_canvas/).

It has 3 scripts:

* Rotate: on the sphere. It rotates the sphere.
* BillboardToCamera: on each Canvas. Makes them always face the camera.
* FadeAlphaByDistance: on each Text. Makes them fade out when they're far from the camera. Caveat: have to manually set minDistance and maxDistance, values which represent the text's minimum and maximum distances from the camera. Uncomment `Debug.Log(distance)` and watch the console in the editor to get a sense of appropriate values.
