using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLErrorException : Exception
    {

        public SDLErrorException()
            : base(SDL.SDL_GetError())
        {
        }

        public SDLErrorException(int TheCode) : base(SDL.SDL_GetError())
        {

            Code = TheCode;

        }

        public SDLErrorException(int TheCode, Exception TheInnerException)
            : base(SDL.SDL_GetError(), TheInnerException)
        {

            Code = TheCode;

        }

        public int Code
        {

            get;
            private set;

        }

    }

}
