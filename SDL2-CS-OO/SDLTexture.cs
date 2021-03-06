﻿using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLTexture : SDLObject, IDisposable
    {

        public SDLTexture(IntPtr TexturePtr)
        {

            myPtr = TexturePtr;

            CheckPtr();

        }

        public SDLTexture(SDLRenderer Renderer, uint Format, int Access, int W, int H)
        {

            myPtr = SDL.SDL_CreateTexture(Renderer.Ptr, Format, Access, W, H);

            CheckPtr();

        }

        public SDLTexture(IntPtr Renderer, uint Format, int Access, int W, int H)
        {

            myPtr = SDL.SDL_CreateTexture(Renderer, Format, Access, W, H);

            CheckPtr();

        }

        public SDLTexture(SDLRenderer Renderer, ref SDL.SDL_PixelFormat Format, int Access, int W, int H)
        {

            myPtr = SDL.SDL_CreateTexture(Renderer.Ptr, Format.format, Access, W, H);

            CheckPtr();

        }

        public SDLTexture(SDLRenderer Renderer, uint Format, SDL.SDL_TextureAccess Access, int W, int H)
        {

            myPtr = SDL.SDL_CreateTexture(Renderer.Ptr, Format, (int)Access, W, H);

            CheckPtr();

        }

        public SDLTexture(SDLRenderer Renderer, ref SDL.SDL_PixelFormat Format, SDL.SDL_TextureAccess Access, int W, int H)
        {

            myPtr = SDL.SDL_CreateTexture(Renderer.Ptr, Format.format, (int)Access, W, H);

            CheckPtr();

        }

        public static SDLTexture CreateFromSurface(SDLRenderer Renderer, SDLSurface Surface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(Renderer.Ptr, Surface.Ptr));

        }

        public static SDLTexture CreateFromSurface(SDLRenderer Renderer, IntPtr Surface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(Renderer.Ptr, Surface));

        }

        public static SDLTexture CreateFromSurface(IntPtr Renderer, SDLSurface Surface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(Renderer, Surface.Ptr));

        }

        public static SDLTexture CreateFromSurface(IntPtr Renderer, IntPtr Surface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(Renderer, Surface));
            
        }

        public static SDLTexture LoadBMP(SDLRenderer Renderer, string File)
        {

            IntPtr ptr = SDL.SDL_LoadBMP(File);

            try
            {

                return CreateFromSurface(Renderer, ptr);

            }
            finally
            {

                SDL.SDL_FreeSurface(ptr);

            }

        }

        public static SDLTexture LoadBMP(IntPtr Renderer, string File)
        {

            IntPtr ptr = SDL.SDL_LoadBMP(File);

            try
            {

                return CreateFromSurface(Renderer, ptr);

            }
            finally
            {

                SDL.SDL_FreeSurface(ptr);

            }

        }

        public static IntPtr LoadBMPPtr(SDLRenderer Renderer, string File)
        {

            IntPtr ptr = SDL.SDL_LoadBMP(File);

            try
            {

                return SDL.SDL_CreateTextureFromSurface(Renderer, ptr);

            }
            finally
            {

                SDL.SDL_FreeSurface(ptr);

            }

        }


        public static IntPtr LoadBMPPtr(IntPtr Renderer, string File)
        {

            IntPtr ptr = SDL.SDL_LoadBMP(File);

            try
            {

                return SDL.SDL_CreateTextureFromSurface(Renderer, ptr);

            }
            finally
            {

                SDL.SDL_FreeSurface(ptr);

            }

        }

        public void Lock(out IntPtr Pixels, out int Pitch)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, IntPtr.Zero, out Pixels, out Pitch));

        }

        public void Lock(out IntPtr Pixels, out int Pitch, Action<SDLTexture, SDLRenderer> Action, SDLRenderer Renderer)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, IntPtr.Zero, out Pixels, out Pitch));

            try
            {

                Action(this, Renderer);

            }
            finally
            {

                SDL.SDL_UnlockTexture(myPtr);

            }

        }

        public void Lock(IntPtr Rect, out IntPtr Pixels, out int Pitch)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, Rect, out Pixels, out Pitch));

        }

        public void Lock(IntPtr Rect, out IntPtr Pixels, out int Pitch, Action<SDLTexture, SDLRenderer> Action, SDLRenderer Renderer)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, Rect, out Pixels, out Pitch));

            try
            {

                Action(this, Renderer);

            }
            finally
            {

                SDL.SDL_UnlockTexture(myPtr);

            }

        }

        public void Lock(ref SDL.SDL_Rect Rect, out IntPtr Pixels, out int Pitch)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, ref Rect, out Pixels, out Pitch));

        }

        public void Lock(ref SDL.SDL_Rect Rect, out IntPtr Pixels, out int Pitch, Action<SDLTexture, SDLRenderer> Action, SDLRenderer Renderer)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockTexture(myPtr, ref Rect, out Pixels, out Pitch));

            try
            {

                Action(this, Renderer);

            }
            finally
            {

                SDL.SDL_UnlockTexture(myPtr);

            }

        }

        public void UnLock()
        {

            SDL.SDL_UnlockTexture(myPtr);

        }

        public void Query(out uint Format, out int Access, out int W, out int H)
        {

            Util.ThrowIfResultIsError(SDL.SDL_QueryTexture(myPtr, out Format, out Access, out W, out H));

        }

        public void QueryPixels(out IntPtr Pixels, out int Pitch)
        {

            Util.ThrowIfResultIsError(SDL.SDL_QueryTexturePixels(myPtr, out Pixels, out Pitch));

        }

        public void GL_BindTexture(out float TexW, out float TexH)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_BindTexture(myPtr, out TexW, out TexH));

        }

        public void SetAlphaMod(byte Alpha)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetTextureAlphaMod(myPtr, Alpha));

        }

        public void SetBlendMode(SDL.SDL_BlendMode BlendMode)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetTextureBlendMode(myPtr, BlendMode));

        }

        public void GL_UnbindTexture()
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_UnbindTexture(myPtr));

        }
        
        ~SDLTexture()
        {

            SDL.SDL_DestroyTexture(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_DestroyTexture(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
