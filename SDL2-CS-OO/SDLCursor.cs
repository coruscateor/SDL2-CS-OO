using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLCursor : SDLObject, IDisposable
    {

        public SDLCursor(IntPtr Cursor)
        {

            myPtr = Cursor;

            CheckPtr();

        }

        public SDLCursor(SDL.SDL_SystemCursor Id)
        {

            myPtr = SDL.SDL_CreateSystemCursor(Id);

            CheckPtr();

        }

        public SDLCursor(SDLSurface Surface, int Hot_x, int Hot_y)
        {

            myPtr = SDL.SDL_CreateColorCursor(Surface.Ptr, Hot_x, Hot_y);

            CheckPtr();

        }

        public SDLCursor(IntPtr Surface, int Hot_x, int Hot_y)
        {

            myPtr = SDL.SDL_CreateColorCursor(Surface, Hot_x, Hot_y);

            CheckPtr();

        }

        public SDLCursor(IntPtr Data, IntPtr Mask, int W, int H, int Hot_x, int Hot_y)
        {

            myPtr = SDL.SDL_CreateCursor(Data, Mask, W, H, Hot_x, Hot_y);

            CheckPtr();

        }

        public static SDLCursor GetCurrrent()
        {

            return new SDLCursor(SDL.SDL_GetCursor());

        }

        public static void Show()
        {

            int Result = SDL.SDL_ShowCursor(1);

            Util.ThrowIfResultIsError(Result);

        }

        public static void Hide()
        {

            int Result = SDL.SDL_ShowCursor(0);

            Util.ThrowIfResultIsError(Result);

        }

        public static bool IsVisible()
        {

            int Result = SDL.SDL_ShowCursor(-1);

            Util.ThrowIfResultIsError(Result);

            return Result == 1;

        }

        public bool IsCurrent
        {

            get
            {

                return myPtr == SDL.SDL_GetCursor();

            }

        }

        public void Set()
        {

            SDL.SDL_SetCursor(myPtr);

        }

        ~SDLCursor()
        {

            SDL.SDL_FreeCursor(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_FreeCursor(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
