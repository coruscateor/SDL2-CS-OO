using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLInvalidPtrException : Exception
    {

        public SDLInvalidPtrException(IntPtr ThePtr) : base(SDL.SDL_GetError())
        {

            Ptr = ThePtr;

        }

        public SDLInvalidPtrException(IntPtr ThePtr, Exception TheInnerException)
            : base(SDL.SDL_GetError(), TheInnerException)
        {

            Ptr = ThePtr;

        }

        public SDLInvalidPtrException(IntPtr ThePtr, string TheMessage) : base(TheMessage)
        {

            Ptr = ThePtr;

        }

        public SDLInvalidPtrException(IntPtr ThePtr, string TheMessage, Exception TheInnerException)
            : base(TheMessage, TheInnerException)
        {

            Ptr = ThePtr;

        }

        public IntPtr Ptr
        {

            get;
            private set;

        }

    }

}
