using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLRenderer : SDLObject, IDisposable
    {

        public SDLRenderer(IntPtr TheSurfacePtr)
        {

            myPtr = SDL.SDL_CreateRenderer(TheSurfacePtr, 0, (uint)SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);

            CheckPtr();

        }

        public SDLRenderer(IntPtr TheWindowPtr, SDL.SDL_RendererFlags TheFlags)
        {

            myPtr = SDL.SDL_CreateRenderer(TheWindowPtr, -1, (uint)TheFlags);

            CheckPtr();

        }

        public SDLRenderer(IntPtr TheWindowPtr, int TheIndex, SDL.SDL_RendererFlags TheFlags)
        {

            myPtr = SDL.SDL_CreateRenderer(TheWindowPtr, TheIndex, (uint)TheFlags);

            CheckPtr();

        }

        public void GetInfo(out SDL.SDL_RendererInfo Info)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRendererInfo(myPtr, out Info));

        }

        public void GetDrawBlendMode(out SDL.SDL_BlendMode TheBlendMode)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRenderDrawBlendMode(myPtr, out TheBlendMode));

        }

        public void GetDrawColor(out byte R, out byte G, out byte B, out byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRenderDrawColor(myPtr, out R, out G, out B, out A));

        }

        public void Clear()
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderClear(myPtr));

        }

        public SDLTexture CreateTextureFromSurface(IntPtr Suface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(myPtr, Suface));

        }

        public SDLTexture CreateTextureFromSurface(SDLSurface Surface)
        {

            return new SDLTexture(SDL.SDL_CreateTextureFromSurface(myPtr, Surface.Ptr));

        }

        public void Copy(IntPtr Texture, IntPtr Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, IntPtr.Zero, Dstrect));

        }

        public void Copy(IntPtr Texture, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, IntPtr.Zero, ref Dstrect));

        }

        public void Copy(IntPtr Texture, IntPtr Srcrect, IntPtr Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, Srcrect, Dstrect));

        }

        public void Copy(IntPtr Texture, IntPtr Srcrect, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, Srcrect, ref Dstrect));

        }

        public void Copy(SDLTexture Texture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture.Ptr, ref Srcrect, ref Dstrect));

        }

        public void CopyEx(IntPtr TheTexture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect, double Angle, ref SDL.SDL_Point Center, SDL.SDL_RendererFlip Flip)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopyEx(myPtr, TheTexture, ref Srcrect, ref Dstrect, Angle, ref Center, Flip));

        }

        public void CopyEx(SDLTexture TheTexture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect, double Angle, ref SDL.SDL_Point Center, SDL.SDL_RendererFlip Flip)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopyEx(myPtr, TheTexture.Ptr, ref Srcrect, ref Dstrect, Angle, ref Center, Flip));

        }

        public void DrawLine(int X1, int Y1, int X2, int Y2)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawLine(myPtr, X1, Y1, X2, Y2));

        }

        public void DrawLines(SDL.SDL_Point[] Points)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawLines(myPtr, Points, Points.Length));

        }

        public void DrawLines(SDL.SDL_Point[] Points, int Count)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawLines(myPtr, Points, Count));

        }

        public void DrawPoint(int X, int Y)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawPoint(myPtr, X, Y));

        }

        public void DrawPoints(SDL.SDL_Point[] Points)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawPoints(myPtr, Points, Points.Length));

        }

        public void DrawPoints(SDL.SDL_Point[] Points, int Count)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawPoints(myPtr, Points, Count));

        }

        public void DrawRect(ref IntPtr Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawRect(myPtr, Rect));

        }

        public void DrawRect(ref SDL.SDL_Rect Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawRect(myPtr, ref Rect));

        }

        public void DrawRects(SDL.SDL_Rect[] Rects)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawRects(myPtr, Rects, Rects.Length));

        }

        public void DrawRects(SDL.SDL_Rect[] Rects, int Count)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderDrawRects(myPtr, Rects, Count));

        }

        public void FillRect(ref IntPtr Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderFillRect(myPtr, Rect));

        }

        public void FillRect(ref SDL.SDL_Rect Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderFillRect(myPtr, ref Rect));

        }

        public void FillRects(SDL.SDL_Rect[] Rects)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderFillRects(myPtr, Rects, Rects.Length));

        }

        public void FillRects(SDL.SDL_Rect[] Rects, int Count)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderFillRects(myPtr, Rects, Count));

        }

        public void GetClipRect(out SDL.SDL_Rect Rect)
        {

            SDL.SDL_RenderGetClipRect(myPtr, out Rect);

        }

        public void GetLogicalSize(out int W, out int H)
        {

            SDL.SDL_RenderGetLogicalSize(myPtr, out W, out H);

        }

        public void GetScale(out float ScaleX, out float ScaleY)
        {

            SDL.SDL_RenderGetScale(myPtr, out ScaleX, out ScaleY);

        }

        public void GetViewPort(out SDL.SDL_Rect Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderGetViewport(myPtr, out Rect));

        }

        public void RenderPresent()
        {

            SDL.SDL_RenderPresent(myPtr);

        }

        public void ReadPixels(ref SDL.SDL_Rect Rect, uint Format, IntPtr Pixels, int Pitch)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderReadPixels(myPtr, ref Rect, Format, Pixels, Pitch));

        }

        public void SetClipRect(ref IntPtr Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetClipRect(myPtr, Rect));

        }

        public void SetClipRect(ref SDL.SDL_Rect Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetClipRect(myPtr, ref Rect));

        }

        public void SetLogicalSize(int W, int H)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetLogicalSize(myPtr, W, H));

        }

        public void SetScale(float ScaleX, float ScaleY)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetScale(myPtr, ScaleX, ScaleY));

        }

        public void SetViewPort(ref SDL.SDL_Rect Rect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetViewport(myPtr, ref Rect));

        }

        public void SetDrawColor(byte R, byte G, byte B, byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetRenderDrawColor(myPtr, R, G, B, A));

        }

        public void SetDrawBlendMode(SDL.SDL_BlendMode BlendMode)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetRenderDrawBlendMode(myPtr, BlendMode));

        }

        public void SetTarget(ref IntPtr Texture)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetRenderTarget(myPtr, Texture));

        }

        public void SetTarget(SDLTexture Texture)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetRenderTarget(myPtr, Texture.Ptr));

        }

        ~SDLRenderer()
        {

            SDL.SDL_DestroyRenderer(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_DestroyRenderer(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
