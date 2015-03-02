using System;
using System.Collections.Generic;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDL_GLContext : SDLObject, IDisposable
    {

        public SDL_GLContext(IntPtr ThePtr)
        {

            myPtr = ThePtr;

            CheckPtr();

        }

        ~SDL_GLContext()
        {

            SDL.SDL_GL_DeleteContext(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_GL_DeleteContext(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
