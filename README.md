SDL2-CS-OO is a companion library for the [SDL2# project](https://github.com/flibitijibibo/SDL2-CS).

This library takes many of the methods exposed by SDL2# and composes them into objects based on the types of data they work with.

For instance you can instantiate an SDLWindow and manipulate it like so:

```
SDLWindow Window = new SDLWindow();

Window.SetTitle("SDLWindow");

Window.SetSize(800, 600);
```

Now get the renderer for the window:

```
SDLRenderer Renderer = Window.GetRenderer();

Renderer.SetDrawColor(0, 0, 0, 255); //White

Renderer.Clear();

Renderer.SetDrawColor(255, 0, 0, 255); //Red

Renderer.DrawLine(0, 400, 600, 400);

Renderer.RenderPresent();
```

TODO:
- Create proper examples which mainly focus on demonstrating common usage scenarios for SDL.
- Write more documentation, including tutorials.