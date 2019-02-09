# Unity Tutorials [2019]

## [Time.deltaTime](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html)
**Syntax:**

```cs
public static float deltaTime;
```

**Description:**

The completion time in seconds since the last frame (Read Only).  
This property provides the time between the current and previous frame.

**Explanation:**

```
120 FPS (Frames Per Second):
  1/120 = 0.00833333333...
  0.00833333333 * 1 = 0.00833333333
  0.00833333333 * 120


60 FPS (Frames Per Second):
1/60 = 0.01666666666...

30 FPS (Frames Per Second):
1/30 = 0.03333333333...
```

**Maths:**

![Equation](http://latex.codecogs.com/gif.latex?%5Cfrac%7B1%7D%7Bx%7D%20%5Ccdot%20y%20%5Ccdot%20x%20%3D%20%5Cfrac%7B1%20%5Ccdot%20y%20%5Ccdot%20x%7D%7Bx%7D%20%3D%201%20%5Ccdot%20y%20%3D%20y)

_x_ = FPS (Frames Per Second)  
_y_ = UPS (Units per Second)
