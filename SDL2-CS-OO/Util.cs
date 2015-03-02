using System;
using SDL2;

namespace SDL2_CS_OO
{

    /// <summary>
    /// Miscellaneous helper methods
    /// </summary>
    public static class Util
    {

        public static string GetError()
        {

            return SDL.SDL_GetError(); 

        }

        public static bool CheckError(out string ErrorMessage)
        {

            ErrorMessage = SDL.SDL_GetError();

            return !string.IsNullOrWhiteSpace(ErrorMessage);

        }

        public static SDL.SDL_bool ConvertTo(bool Bool)
        {

            if(Bool)
                return SDL.SDL_bool.SDL_TRUE;

            return SDL.SDL_bool.SDL_FALSE;

        }

        public static bool ConvertFrom(SDL.SDL_bool Bool)
        {

            return Bool == SDL.SDL_bool.SDL_TRUE;

        }

        public static SDL.SDL_version GetSDLVersion()
        {

            SDL.SDL_version Version;

            SDL.SDL_VERSION(out Version);

            return Version;

        }

        public static void Delay()
        {

            SDL.SDL_Delay(0u);

        }

        public static void Delay(int Milliseconds)
        {

            SDL.SDL_Delay((uint)Milliseconds);

        }

        public static void Delay(uint Milliseconds)
        {

            SDL.SDL_Delay(Milliseconds);

        }

        public static void Delay(TimeSpan TS)
        {

            SDL.SDL_Delay((uint)TS.TotalMilliseconds);

        }

        public static void ThrowIfPointerZero(IntPtr Ptr)
        {

            if(Ptr == IntPtr.Zero)
                throw new SDLInvalidPtrException(Ptr);

        }

        public static void ThrowIfResultIsError(int Value)
        {

            if(Value != 0)
                throw new SDLErrorException(Value);

        }

        public static bool GetBoolResultOrThrow(int Value)
        {

            if(Value != 0)
                throw new SDLErrorException(Value);

            return Value > 0;

        }

        public static string GetStringResultOrThrow(string Value)
        {

            if(Value == null)
                throw new SDLErrorException();

            return Value;

        }

        public static void ThrowIfGUIDIsEmpty(Guid Result)
        {

            if(Result == Guid.Empty)
                throw new SDLErrorException();

        }

        public static void SetClipBoardText(string Text)
        {

            ThrowIfResultIsError(SDL.SDL_SetClipboardText(Text));

        }

        public static void CreateWindowAndRenderer(int Width, int Height, SDL.SDL_WindowFlags Window_flags, out IntPtr Window, out IntPtr Renderer)
        {

            ThrowIfResultIsError(SDL.SDL_CreateWindowAndRenderer(Width, Height, Window_flags, out Window, out Renderer));

        }

        public static void CreateWindowAndRenderer(int Width, int Height, SDL.SDL_WindowFlags Window_flags, out SDLWindow Window, out SDLRenderer Renderer)
        {

            IntPtr WindowPtr;
            
            IntPtr RendererPtr;

            ThrowIfResultIsError(SDL.SDL_CreateWindowAndRenderer(Width, Height, Window_flags, out WindowPtr, out RendererPtr));

            Window = new SDLWindow(WindowPtr);

            Renderer = new SDLRenderer(RendererPtr);

        }

        public static bool PollEvent(out SDL.SDL_Event Event)
        {

            return SDL.SDL_PollEvent(out Event) == 1;

        }

        public static bool PollEvent(PassEvent EventAction)
        {

            SDL.SDL_Event Result;

            if(SDL.SDL_PollEvent(out Result) == 1)
            {

                EventAction(out Result);

                return true;

            }

            return false;

        }

        public static bool MouseIsHaptic()
        {

            int Result = SDL.SDL_MouseIsHaptic();

            ThrowIfResultIsError(Result);

            return Result == 1;

        }

        public static bool GetRelativeMouseMode()
        {

            return SDL.SDL_GetRelativeMouseMode() == SDL.SDL_bool.SDL_TRUE;

        }

        public static bool TrySetRelativeMouseMode(bool Enabled, out int Result, out string ErrorMessage)
        {

            Result = SDL.SDL_SetRelativeMouseMode(ConvertTo(Enabled));

            if(Result == -1)
            {

                ErrorMessage = SDL.SDL_GetError();

                return false;

            }

            ErrorMessage = "";

            return Result == 0;

        }

    }

}
