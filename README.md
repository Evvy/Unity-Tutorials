# Unity Tutorials
These tutorials are ment to give a wider understanding / more context to elements of Unity(C#) coding.  
Each tutorial will contain a variety of explanations, ranging from mathematical explanations to pure code.  
**For more details, check out Unity's own documentation: [Unity3D](https://docs.unity3d.com/ScriptReference/).**

## Table of Contents :bookmark_tabs:
- [Time.deltaTime](#timedeltaTime)
     - [Explanation](#explanation-book)
     - [Code](#code-computer)
     - [Math](#maths-triangular_ruler)
- [Contributing](#contributing-memo)
- [Authors](#authors-construction_worker)

## Things to add :clipboard:
- [x] Time.deltaTime
- [ ] Hmm...

## [Time.deltaTime](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html)

>**Syntax:**
>```cs
>public static float deltaTime;
>```

>**Description:**  
>The completion time in seconds since the last frame (Read Only).  
>This property provides the time between the current and previous frame.

### Explanation :book:
In this [code example](#code-computer) we are setting the speed to a float value of ```3.0f```.  
This value can be viewed as the ```y``` in the [mathematical formula](#maths-triangular_ruler).  
```3.0f``` is the amount of units we would like our object to travel per second (Units Per Second).  
In order to understand how the object(s) is/are going to travel using this ```transform.Translate``` method, we have to understand what happens when this is called in the ```Update()``` function.  
The ```Update()``` function gets called every frame. Meaning that for every frame, the ```transform.Translate``` will be run.  
Say we are running a game at ```60 FPS (Frames Per Second)```.  
This means that 60 frames are rendered per second.  
If we have a set speed at ```3.0f```, this will get called 60 times a second, resulting in a movement of ```180 UPS (Units Per Seconds)```.  
What we wish for as a result, is a movement of ```3 UPS (Units Per Second)```.  
In order to achieve this we use ```Time.deltaTime```.  
We can easily show how this is possible using the mathematical calculation below.  
>_x_ = 60  
>_y_ = 3

```
60 FPS (Frames Per Second) | Float speed of 3.0f:

  1/60 = 0.01666666666...
  0.01666666666 * 3 = 0.04999999998
  0.04999999998 * 60 = 2.9999999988 ≈ 3
```

#### Code :computer:
The files for these codes can be found [here](https://github.com/Evvy/Unity-Tutorials/tree/master/Time.deltaTime).

Without ```Time.deltaTime```
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDeltaTime : MonoBehaviour {
  public float speed = 3.0f;
  
  public void Update() {
    transform.Translate(speed);
  }
}
```
With ```Time.deltaTime```
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime : MonoBehaviour {
  public float speed = 3.0f;
  
  public void Update() {
    transform.Translate(speed * Time.deltaTime);
  }
}
```

#### Maths :triangular_ruler:
Formula explaining how to calculate units per second:

![Equation](http://latex.codecogs.com/gif.latex?%5Cfrac%7B1%7D%7Bx%7D%20%5Ccdot%20y%20%5Ccdot%20x%20%3D%20%5Cfrac%7B1%20%5Ccdot%20y%20%5Ccdot%20x%7D%7Bx%7D%20%3D%201%20%5Ccdot%20y%20%3D%20y)
>_x_ = FPS (Frames Per Second)  
>_y_ = UPS (Units Per Second)

##### Step-by-Step Calculation:
```
x FPS (Frames Per Second):

  1/x = ...
  ... * y = ...
  ... * x = ... ≈ y


120 FPS (Frames Per Second):

  1/120 = 0.00833333333...
  0.00833333333 * 1 = 0.00833333333
  0.00833333333 * 120 = 0.9999999996 ≈ 1


60 FPS (Frames Per Second):

  1/60 = 0.01666666666...
  0.01666666666 * 1 = 0.01666666666
  0.01666666666 * 60 = 0.9999999996 ≈ 1


30 FPS (Frames Per Second):

  1/30 = 0.03333333333...
  0.03333333333 * 1 = 0.03333333333
  0.03333333333 * 30 = 0.9999999999 ≈ 1
```

## Contributing :memo:
Please read [CONTRIBUTING.md](https://github.com/Evvy/Unity-Tutorials/blob/master/CONTRIBUTING.md) to see the process for submitting pull requests to me.

## Author(s) :construction_worker:

* **Even Engesland** - [Evvy](https://github.com/Evvy)

See also the list of [contributors](http://github.com/Evvy/Unity-Tutorials/contributors) who participated in this project.
