using System;
using System.Runtime.InteropServices;
using SDL2;

namespace SDL2_CS_OO
{
    
    public sealed class SDLPalette : SDLObject, IDisposable
    {

        public SDLPalette(IntPtr PalettePtr)
        {

            myPtr = PalettePtr;

            CheckPtr();

        }

        public SDLPalette(int NColors)
        {

            myPtr = SDL.SDL_AllocPalette(NColors);

            CheckPtr();

        }

        public void SetPaletteColor(SDL.SDL_Color Color)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPaletteColors(myPtr, new SDL.SDL_Color[] { Color }, 0, 1));

        }

        public void SetPaletteColors(SDL.SDL_Color[] Colors)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPaletteColors(myPtr, Colors, 0, Colors.Length - 1));

        }

        public void SetPaletteColors(SDL.SDL_Color[] Colors, int FirstColor)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPaletteColors(myPtr, Colors, FirstColor, Colors.Length - FirstColor - 1));

        }

        public void SetPaletteColors(SDL.SDL_Color[] Colors, int FirstColor, int NColors)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetPaletteColors(myPtr, Colors, FirstColor, NColors));

        }

        public SDL.SDL_Palette GetPaletteStr()
        {

            return (SDL.SDL_Palette)Marshal.PtrToStructure(myPtr, typeof(SDL.SDL_Palette));

        }

        public void SetPaletteStr(SDL.SDL_Palette ThePixelFormat)
        {

            Marshal.StructureToPtr(ThePixelFormat, myPtr, true);

        }

        ~SDLPalette()
        {

            SDL.SDL_FreePalette(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_FreePalette(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
