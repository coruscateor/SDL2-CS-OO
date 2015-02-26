using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.TTF
{

    /// <summary>
    /// http://www.libsdl.org/projects/SDL_ttf/docs/SDL_ttf.html
    /// </summary>
    public sealed class TTFFont : SDLObject, IDisposable
    {

        public TTFFont(string File, int PtSize)
        {

            myPtr = SDL_ttf.TTF_OpenFont(File, PtSize);
            
        }

        public TTFFont(string File, int PtSize, long Index)
        {

            myPtr = SDL_ttf.TTF_OpenFontIndex(File, PtSize, Index);
            
        }

        public TTFFont(IntPtr Src, bool Freesrc, int PtSize)
        {

            myPtr = SDL_ttf.TTF_OpenFontRW(Src, Convert.ToInt32(Freesrc), PtSize);

        }

        public TTFFont(IntPtr Src, bool Freesrc, int PtSize, long Index)
        {

            myPtr = SDL_ttf.TTF_OpenFontIndexRW(Src, Convert.ToInt32(Freesrc), PtSize, Index);

        }

        public int GetStyle()
        {

            return SDL_ttf.TTF_GetFontStyle(myPtr);

        }

        public void SetStyle(int Style)
        {

            SDL_ttf.TTF_SetFontStyle(myPtr, Style);

        }

        public int GetOutline(int Outline)
        {

            return SDL_ttf.TTF_GetFontOutline(myPtr);

        }

        public void SetOutline(int Outline)
        {

            SDL_ttf.TTF_SetFontOutline(myPtr, Outline);

        }

        public int GetHinting()
        {

            return SDL_ttf.TTF_GetFontHinting(myPtr);

        }

        public void SetHinting(int Hinting)
        {

            SDL_ttf.TTF_SetFontHinting(myPtr, Hinting);

        }

        public int GetKerning()
        {

            return SDL_ttf.TTF_GetFontKerning(myPtr);

        }

        public void SetKerning(int Allowed)
        {

            SDL_ttf.TTF_SetFontKerning(myPtr, Allowed);

        }

        public int Height()
        {

            return SDL_ttf.TTF_FontHeight(myPtr);

        }

        public int Ascent()
        {

            return SDL_ttf.TTF_FontAscent(myPtr);

        }

        public int Decent()
        {

            return SDL_ttf.TTF_FontDescent(myPtr);

        }

        public int LineSkip()
        {

            return SDL_ttf.TTF_FontLineSkip(myPtr);

        }

        public long Faces()
        {

            return SDL_ttf.TTF_FontFaces(myPtr);

        }

        public int FontFaceIsFixedWidth()
        {

            return SDL_ttf.TTF_FontFaceIsFixedWidth(myPtr);

        }

        public string FontFaceFamilyName()
        {

            return SDL_ttf.TTF_FontFaceFamilyName(myPtr);

        }

        public string FontFaceStyleName()
        {

            return SDL_ttf.TTF_FontFaceStyleName(myPtr);

        }

        public int GlyphIsProvided(ushort Ch)
        {

            return SDL_ttf.TTF_GlyphIsProvided(myPtr, Ch);

        }

        public int GlyphIsProvided(char Ch)
        {

            return SDL_ttf.TTF_GlyphIsProvided(myPtr, Ch);

        }

        public void GlyphMetrcs(ushort Ch, out int Minx, out int Minxx, out int Miny, out int Maxy, out int Advance)
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_GlyphMetrics(myPtr, Ch, out Minx, out Minxx, out Miny, out Maxy, out Advance));

        }

        public void GlyphMetrcs(char Ch, out int Minx, out int Minxx, out int Miny, out int Maxy, out int Advance)
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_GlyphMetrics(myPtr, Ch, out Minx, out Minxx, out Miny, out Maxy, out Advance));

        }

        public void SizeText(string Text, out int W, out int H)
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_SizeText(myPtr, Text, out W, out H));

        }

        public void SizeUTF8(string Text, out int W, out int H)
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_SizeUTF8(myPtr, Text, out W, out H));

        }

        public void SizeUNICODE(string Text, out int W, out int H)
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_SizeUNICODE(myPtr, Text, out W, out H));

        }

        //Rendering

        public IntPtr RenderText_SolidPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderText_Solid(myPtr, Text, Fg);

        }

        public SDLSurface RenderText_Solid(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderText_Solid(myPtr, Text, Fg));

        }

        public IntPtr RenderUTF8_SolidPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderUTF8_Solid(myPtr, Text, Fg);

        }

        public SDLSurface RenderUTF8_Solid(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUTF8_Solid(myPtr, Text, Fg));

        }

        public IntPtr RenderUNICODE_SolidPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderUNICODE_Solid(myPtr, Text, Fg);

        }

        public SDLSurface RenderUNICODE_Solid(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUNICODE_Solid(myPtr, Text, Fg));

        }

        public IntPtr RenderGlyph_SolidPtr(ushort Ch, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderGlyph_Solid(myPtr, Ch, Fg);

        }

        public IntPtr RenderGlyph_SolidPtr(char Ch, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderGlyph_Solid(myPtr, Ch, Fg);

        }

        public SDLSurface RenderGlyph_Solid(ushort Ch, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Solid(myPtr, Ch, Fg));

        }

        public SDLSurface RenderGlyph_Solid(char Ch, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Solid(myPtr, Ch, Fg));

        }

        public IntPtr RenderText_ShadedPtr(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return SDL_ttf.TTF_RenderText_Shaded(myPtr, Text, Fg, Bg);

        }

        public SDLSurface RenderText_Shaded(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderText_Shaded(myPtr, Text, Fg, Bg));

        }

        public IntPtr Render_UTF8_ShadedPtr(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return SDL_ttf.TTF_RenderUTF8_Shaded(myPtr, Text, Fg, Bg);

        }

        public SDLSurface RenderUTF8_Shaded(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUTF8_Shaded(myPtr, Text, Fg, Bg));

        }

        public IntPtr Render_UNICODE_ShadedPtr(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return SDL_ttf.TTF_RenderUNICODE_Shaded(myPtr, Text, Fg, Bg);

        }

        public SDLSurface RenderUNICODE_Shaded(string Text, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUNICODE_Shaded(myPtr, Text, Fg, Bg));

        }

        public IntPtr RenderGlyph_ShadedPtr(ushort Ch, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return SDL_ttf.TTF_RenderGlyph_Shaded(myPtr, Ch, Fg, Bg);

        }

        public IntPtr RenderGlyph_ShadedPtr(char Ch, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return SDL_ttf.TTF_RenderGlyph_Shaded(myPtr, Ch, Fg, Bg);

        }

        public SDLSurface RenderGlyph_Shaded(ushort Ch, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Shaded(myPtr, Ch, Fg, Bg));

        }

        public SDLSurface RenderGlyph_Shaded(char Ch, SDL.SDL_Color Fg, SDL.SDL_Color Bg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Shaded(myPtr, Ch, Fg, Bg));

        }

        public IntPtr RenderText_BlendedPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderText_Blended(myPtr, Text, Fg);

        }

        public SDLSurface RenderText_Blended(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderText_Blended(myPtr, Text, Fg));

        }

        public IntPtr RenderUTF8_BlendedPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderUTF8_Blended(myPtr, Text, Fg);

        }

        public SDLSurface RenderUTF8_Blended(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUTF8_Blended(myPtr, Text, Fg));

        }

        public IntPtr RenderUNICODE_BlendedPtr(string Text, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderUNICODE_Blended(myPtr, Text, Fg);

        }

        public SDLSurface RenderUNICODE_Blended(string Text, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderUNICODE_Blended(myPtr, Text, Fg));

        }

        public IntPtr RenderGlyph_BlendedPtr(ushort Ch, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderGlyph_Blended(myPtr, Ch, Fg);

        }

        public IntPtr RenderGlyph_BlendedPtr(char Ch, SDL.SDL_Color Fg)
        {

            return SDL_ttf.TTF_RenderGlyph_Blended(myPtr, Ch, Fg);

        }

        public SDLSurface RenderGlyph_Blended(ushort Ch, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Blended(myPtr, Ch, Fg));

        }

        public SDLSurface RenderGlyph_Blended(char Ch, SDL.SDL_Color Fg)
        {

            return new SDLSurface(SDL_ttf.TTF_RenderGlyph_Blended(myPtr, Ch, Fg));

        }

        ~TTFFont()
        {

            SDL_ttf.TTF_CloseFont(myPtr);

        }

        public void Dispose()
        {

            SDL_ttf.TTF_CloseFont(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
