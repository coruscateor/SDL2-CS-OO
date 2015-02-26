using System;
using System.Runtime.InteropServices;
using SDL2;

namespace SDL2_CS_OO
{
    
    public sealed class SDLPixelFormat : SDLObject, IDisposable
    {

        public SDLPixelFormat(uint Pixel_Format)
        {

            myPtr = SDL.SDL_AllocFormat(Pixel_Format);

            CheckPtr();

        }

        public void GetRGB(uint Pixel, out byte R, out byte G, out byte B)
        {

            SDL.SDL_GetRGB(Pixel, myPtr, out R, out G, out B);

        }

        public void GetRGBA(uint Pixel, out byte R, out byte G, out byte B, out byte A)
        {

            SDL.SDL_GetRGBA(Pixel, myPtr, out R, out G, out B, out A);

        }

        public uint MapRGB(byte R, byte G, byte B)
        {

            return SDL.SDL_MapRGB(myPtr, R, G, B);

        }

        public uint MapRGBA(byte R, byte G, byte B, byte A)
        {

            return SDL.SDL_MapRGBA(myPtr, R, G, B, A);

        }

        public void SetPixelFormatPalette(SDLPalette Palette)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPixelFormatPalette(myPtr, Palette.Ptr));

        }

        public void SetPixelFormatPalette(IntPtr Palette)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPixelFormatPalette(myPtr, Palette));

        }

        public SDL.SDL_PixelFormat GetPixelFormatStr()
        {

            return (SDL.SDL_PixelFormat)Marshal.PtrToStructure(myPtr, typeof(SDL.SDL_PixelFormat));

        }

        public void SetPixelFormatStr(SDL.SDL_PixelFormat ThePixelFormat)
        {

            Marshal.StructureToPtr(ThePixelFormat, myPtr, true);

        }

        ~SDLPixelFormat()
        {

            SDL.SDL_FreeFormat(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_FreeFormat(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
