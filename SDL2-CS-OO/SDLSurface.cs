using System;
using System.Runtime.InteropServices;
using SDL2;

namespace SDL2_CS_OO
{

    /// <summary>
    /// Wraps a surface pointer
    /// 
    /// The SDL Surface is part of the old API and uses only sofware rendering.
    /// 
    /// You should use SDLRenderer
    /// </summary>
    public sealed class SDLSurface : SDLObject, IDisposable
    {

        public SDLSurface(IntPtr TheWindowPtr)
        {

            myPtr = SDL.SDL_GetWindowSurface(TheWindowPtr);

            CheckPtr();

        }

        public SDLSurface(SDLWindow TheWindow)
        {

            myPtr = SDL.SDL_GetWindowSurface(TheWindow.Ptr);

            CheckPtr();

        }

        public SDLSurface(int TheWidth, int TheHeight, int TheDepth, uint TheRMask, uint TheGMask, uint TheBMask, uint TheAMask)
        {

            myPtr = SDL.SDL_CreateRGBSurface(0u, TheWidth, TheHeight, TheDepth, TheRMask, TheGMask, TheBMask, TheAMask);

            CheckPtr();

        }

        public SDLSurface(IntPtr Pixels, int TheWidth, int TheHeight, int TheDepth, int ThePitch, uint TheRMask, uint TheGMask, uint TheBMask, uint TheAMask)
        {

            myPtr = SDL.SDL_CreateRGBSurfaceFrom(Pixels, TheWidth, TheHeight, TheDepth, ThePitch, TheRMask, TheGMask, TheBMask, TheAMask);

            CheckPtr();

        }

        public static SDLSurface LoadBMP(string File)
        {

            IntPtr ptr = SDL.SDL_LoadBMP(File);

            Util.ThrowIfPointerZero(ptr);

            return new SDLSurface(ptr);

        }

        public SDL.SDL_Rect GetClipRect()
        {

            SDL.SDL_Rect Rect;

            SDL.SDL_GetClipRect(myPtr, out Rect);

            return Rect;

        }

        public void GetColorKey(out uint Key)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetColorKey(myPtr, out Key));

        }

        public SDLRenderer CreateRenderer()
        {

            return new SDLRenderer(myPtr);

        }

        public SDLTexture CreateTextureFromSurface(IntPtr TheRenderer)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(TheRenderer, myPtr));

        }

        public SDLTexture CreateTextureFromSurface(SDLRenderer TheRenderer)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(TheRenderer.Ptr, myPtr));

        }

        public void GetAlphaMod(out byte alpha)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetSurfaceAlphaMod(myPtr, out alpha));

        }

        public void BlitScaled(IntPtr dst)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, IntPtr.Zero, dst, IntPtr.Zero));

        }

        public void BlitScaled(SDLSurface dst)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, IntPtr.Zero, dst.Ptr, IntPtr.Zero));

        }

        public void BlitScaled(IntPtr srcrect, IntPtr dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, srcrect, dst, dstrect));

        }

        public void BlitScaled(IntPtr srcrect, SDLSurface dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, srcrect, dst.Ptr, dstrect));

        }

        public void BlitScaled(IntPtr srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, srcrect, dst, ref dstrect));

        }

        public void BlitScaled(IntPtr srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, srcrect, dst.Ptr, ref dstrect));

        }

        public void BlitScaled(ref SDL.SDL_Rect srcrect, IntPtr dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, ref srcrect, dst, dstrect));

        }

        public void BlitScaled(ref SDL.SDL_Rect srcrect, SDLSurface dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, ref srcrect, dst.Ptr, dstrect));

        }

        public void BlitScaled(ref SDL.SDL_Rect srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, ref srcrect, dst, ref dstrect));

        }

        public void BlitScaled(ref SDL.SDL_Rect srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitScaled(myPtr, ref srcrect, dst.Ptr, ref dstrect));

        }

        public void BlitSurface(IntPtr dst)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, IntPtr.Zero, dst, IntPtr.Zero));

        }

        public void BlitSurface(SDLSurface dst)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, IntPtr.Zero, dst.Ptr, IntPtr.Zero));

        }

        public void BlitSurface(IntPtr srcrect, IntPtr dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, srcrect, dst, dstrect));

        }

        public void BlitSurface(IntPtr srcrect, SDLSurface dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, srcrect, dst.Ptr, dstrect));

        }

        public void BlitSurface(IntPtr srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, srcrect, dst, ref dstrect));

        }

        public void BlitSurface(IntPtr srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, srcrect, dst.Ptr, ref dstrect));

        }

        public void BlitSurface(ref SDL.SDL_Rect srcrect, IntPtr dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, ref srcrect, dst, dstrect));

        }

        public void BlitSurface(ref SDL.SDL_Rect srcrect, SDLSurface dst, IntPtr dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, ref srcrect, dst.Ptr, dstrect));

        }

        public void BlitSurface(ref SDL.SDL_Rect srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, ref srcrect, dst, ref dstrect));

        }

        public void BlitSurface(ref SDL.SDL_Rect srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_BlitSurface(myPtr, ref srcrect, dst.Ptr, ref dstrect));

        }

        public SDL.SDL_BlendMode GetBlendMode()
        {

            SDL.SDL_BlendMode CurrentBlendMode;

            Util.ThrowIfResultIsError(SDL.SDL_GetSurfaceBlendMode(myPtr, out CurrentBlendMode));

            return CurrentBlendMode;

        }

        public void GetColorMod(out byte R, out byte G, out byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetSurfaceColorMod(myPtr, out R, out G, out B));

        }

        public SDLSurface ConvertSurface(SDLPixelFormat Fmt)
        {

            IntPtr Result = SDL.SDL_ConvertSurface(myPtr, Fmt.Ptr, 0u);

            Util.ThrowIfPointerZero(Result);

            return new SDLSurface(Result);

        }

        public SDLSurface ConvertSurface(IntPtr Fmt)
        {

            IntPtr Result = SDL.SDL_ConvertSurface(myPtr, Fmt, 0u);

            Util.ThrowIfPointerZero(Result);

            return new SDLSurface(Result);

        }

        public SDLSurface ConvertSurfaceFormat(uint Fmt)
        {

            IntPtr Result = SDL.SDL_ConvertSurfaceFormat(myPtr, Fmt, 0u);

            Util.ThrowIfPointerZero(Result);

            return new SDLSurface(Result);

        }

        public void Lock()
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockSurface(myPtr));

        }

        public void Lock(Action<SDLSurface, SDL.SDL_Surface> Action)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LockSurface(myPtr));

            try
            {

                Action(this, GetSurfaceStr());

            }
            finally
            {

                SDL.SDL_UnlockSurface(myPtr);

            }

        }

        public void Unlock()
        {

            SDL.SDL_UnlockSurface(myPtr);

        }

        public bool MUSTLOCK
        {

            get
            {

                return SDL.SDL_MUSTLOCK(myPtr);
            
            }

        }

        public void SaveBMP(string File)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SaveBMP(myPtr, File));

        }

        //FillRect

        public void FillRect(ref SDL.SDL_Rect Rect, uint Color)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRect(myPtr, ref Rect, Color));

        }

        public void FillRect(ref SDL.SDL_Rect Rect, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRect(myPtr, ref Rect, SDL.SDL_MapRGB(GetSurfaceStr().format, R, G, B)));

        }

        public void FillRect(ref SDL.SDL_Rect Rect, IntPtr Format, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRect(myPtr, ref Rect, SDL.SDL_MapRGB(Format, R, G, B)));

        }

        public void FillRect(ref SDL.SDL_Rect Rect, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRect(myPtr, ref Rect, SDL.SDL_MapRGBA(GetSurfaceStr().format, R, G, B, A)));

        }

        public void FillRect(ref SDL.SDL_Rect Rect, IntPtr Format, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRect(myPtr, ref Rect, SDL.SDL_MapRGBA(Format, R, G, B, A)));

        }

        //FillRects

        public void FillRects(SDL.SDL_Rect[] Rects, int Count, uint Color)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Count, Color));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, int Count, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Count, SDL.SDL_MapRGB(GetSurfaceStr().format, R, G, B)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, int Count, IntPtr Format, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Count, SDL.SDL_MapRGB(Format, R, G, B)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, int Count, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Count, SDL.SDL_MapRGBA(GetSurfaceStr().format, R, G, B, A)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, int Count, IntPtr Format, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Count, SDL.SDL_MapRGBA(Format, R, G, B, A)));

        }

        //FillRects no count 

        public void FillRects(SDL.SDL_Rect[] Rects, uint Color)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Rects.Length, Color));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Rects.Length, SDL.SDL_MapRGB(GetSurfaceStr().format, R, G, B)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, IntPtr Format, byte R, byte G, byte B)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Rects.Length, SDL.SDL_MapRGB(Format, R, G, B)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Rects.Length, SDL.SDL_MapRGBA(GetSurfaceStr().format, R, G, B, A)));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, IntPtr Format, byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_FillRects(myPtr, Rects, Rects.Length, SDL.SDL_MapRGBA(Format, R, G, B, A)));

        }

        public void LowerBlit(ref SDL.SDL_Rect srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LowerBlit(myPtr, ref srcrect, dst, ref dstrect));

        }

        public void LowerBlit(ref SDL.SDL_Rect srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LowerBlit(myPtr, ref srcrect, dst.Ptr, ref dstrect));

        }

        public void LowerBlitScaled(ref SDL.SDL_Rect srcrect, IntPtr dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LowerBlitScaled(myPtr, ref srcrect, dst, ref dstrect));

        }

        public void LowerBlitScaled(ref SDL.SDL_Rect srcrect, SDLSurface dst, ref SDL.SDL_Rect dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_LowerBlitScaled(myPtr, ref srcrect, dst.Ptr, ref dstrect));

        }

        public SDL.SDL_Surface GetSurfaceStr()
        {

            return (SDL.SDL_Surface)Marshal.PtrToStructure(myPtr, typeof(SDL.SDL_Surface));

        }

        public void SetSurfaceStr(SDL.SDL_Surface TheSurface)
        {

            Marshal.StructureToPtr(TheSurface, myPtr, true);

        }

        ~SDLSurface()
        {

            SDL.SDL_FreeSurface(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_FreeSurface(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
