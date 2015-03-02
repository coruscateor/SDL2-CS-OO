using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO
{
    
    public static class SDL_GL
    {

        public static bool ExtensionSupported(string Extension)
        {

            return SDL.SDL_GL_ExtensionSupported(Extension) == SDL.SDL_bool.SDL_TRUE;

        }

        public static int GetAttribute(SDL.SDL_GLattr Attr)
        {

            int value;

            Util.ThrowIfResultIsError(SDL.SDL_GL_GetAttribute(Attr, out value));

            return value;

        }

        public static SDL_GLContext GetCurrentContext()
        {

            IntPtr Result = SDL.SDL_GL_GetCurrentContext();

            return new SDL_GLContext(Result);

        }

        public static IntPtr GetCurrentContextPtr()
        {

            IntPtr Result = SDL.SDL_GL_GetCurrentContext();

            Util.ThrowIfPointerZero(Result);

            return Result;

        }

        public static SDLWindow GetCurrentWindow()
        {

            IntPtr Result = SDL.SDL_GL_GetCurrentWindow();

            return new SDLWindow(Result);

        }

        public static bool TryGetCurrentWindow(IEnumerable<SDLWindow> Windows, out SDLWindow Window)
        {

            IntPtr Result = SDL.SDL_GL_GetCurrentWindow();

            Util.ThrowIfPointerZero(Result);

            foreach(var Item in Windows)
            {

                if(Item.Ptr == Result)
                {

                    Window = Item;

                    return true;

                }

            }

            Window = null;

            return false;

        }

        public static IntPtr GetCurrentWindowPtr()
        {

            IntPtr Result = SDL.SDL_GL_GetCurrentWindow();

            Util.ThrowIfPointerZero(Result);

            return Result;

        }

        public static VerticalRetrace GetSwapInterval()
        {

            int Result = SDL.SDL_GL_GetSwapInterval();

            switch(Result)
            {

                case 0:

                    return VerticalRetrace.IsNotSyncronised;
                case 1:

                    return VerticalRetrace.IsSyncronised;

            }

            throw new SDLErrorException(Result);

        }

        public static void ResetAttributes()
        {

            SDL.SDL_GL_ResetAttributes();

        }

        public static void SetAttribute(SDL.SDL_GLattr Attr, int Value)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_SetAttribute(Attr, Value));

        }

        public static void SetSwapInterval(int Interval)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_SetSwapInterval(Interval));

        }

    }

}
