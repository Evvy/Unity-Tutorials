# Unity Tutorials [2019]
These tutorials are ment to give a wider understanding / more context to elements of unity coding.  
Each tutorial will contain a variety of explanations, ranging from mathematical explanations to pure code.  
For more details, check out Unity's own documentation: [Unity3D](https://docs.unity3d.com/ScriptReference/)

## Things to add  
- [x] Time.deltaTime
- [ ] Hmm...

## [Time.deltaTime](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html)

> **Syntax:**
>```cs
>public static float deltaTime;
>```

>**Description:**  
>The completion time in seconds since the last frame (Read Only).  
>This property provides the time between the current and previous frame.

**Explanation:**

```
120 FPS (Frames Per Second):

  1/120 = 0.00833333333...
  0.00833333333 * 1 = 0.00833333333
  0.00833333333 * 120 = 0.9999999996 ≈ 1


60 FPS (Frames Per Second):

  1/60 = 0.01666666666...
  0.01666666666 * 1 = 0.01666666666
  0.01666666666*1 * 60 = 0.9999999996 ≈ 1


30 FPS (Frames Per Second):

  1/30 = 0.03333333333...
  0.03333333333 * 1 = 0.03333333333
  0.03333333333 * 30 = 0.9999999999 ≈ 1
```

**Maths:**

>![Equation](http://latex.codecogs.com/gif.latex?%5Cfrac%7B1%7D%7Bx%7D%20%5Ccdot%20y%20%5Ccdot%20x%20%3D%20%5Cfrac%7B1%20%5Ccdot%20y%20%5Ccdot%20x%7D%7Bx%7D%20%3D%201%20%5Ccdot%20y%20%3D%20y)  
>_x_ = FPS (Frames Per Second)  
>_y_ = UPS (Units per Second)

## Contributing  
Please read [CONTRIBUTING.md](https://github.com/Evvy/Unity-Tutorials/blob/master/CONTRIBUTING.md) to see the process for submitting pull requests to me.

## Authors

* **Even Engesland** - [Evvy](https://github.com/Evvy)

See also the list of [contributors](http://github.com/Evvy/Unity-Tutorials/contributors) who participated in this project.
