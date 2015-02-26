using System;
using SDL2;

namespace SDL2_CS_OO
{

    public delegate void PassEvent(out SDL.SDL_Event Event);

    public enum VerticalRetrace
    {

        IsNotSyncronised = 0,
        IsSyncronised = 1

    }

}
