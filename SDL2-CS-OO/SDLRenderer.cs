using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLRenderer : SDLObject, IDisposable
    {

        public SDLRenderer(IntPtr Renderer)
        {

            myPtr = Renderer;

            CheckPtr();

        }

        public SDLRenderer(IntPtr Window, uint Flags)
        {

            myPtr = SDL.SDL_CreateRenderer(Window, -1, Flags);

            CheckPtr();

        }

        public SDLRenderer(IntPtr Window, SDL.SDL_RendererFlags Flags)
        {

            myPtr = SDL.SDL_CreateRenderer(Window, -1, (uint)Flags);

            CheckPtr();

        }

        public SDLRenderer(IntPtr Window, int Index, uint Flags)
        {

            myPtr = SDL.SDL_CreateRenderer(Window, Index, Flags);

            CheckPtr();

        }

        public SDLRenderer(IntPtr Window, int Index, SDL.SDL_RendererFlags Flags)
        {

            myPtr = SDL.SDL_CreateRenderer(Window, Index, (uint)Flags);

            CheckPtr();

        }

        public void GetInfo(out SDL.SDL_RendererInfo Info)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRendererInfo(myPtr, out Info));

        }

        public void GetRenderDrawBlendMode(out SDL.SDL_BlendMode BlendMode)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRenderDrawBlendMode(myPtr, out BlendMode));

        }

        public void GetRenderDrawColor(out byte R, out byte G, out byte B, out byte A)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRenderDrawColor(myPtr, out R, out G, out B, out A));

        }

        public void GetOutputSize(out int W, out int H)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetRendererOutputSize(myPtr, out W, out H));

        }

        public bool TryGetRenderTarget(out SDLTexture Texture)
        {

            IntPtr Result = SDL.SDL_GetRenderTarget(myPtr);

            if(Result == IntPtr.Zero)
            {

                Texture = null;

                return false;

            }

            Texture = new SDLTexture(Result);

            return true;

        }

        public bool TryGetRenderTarget(out IntPtr Texture)
        {

            Texture = SDL.SDL_GetRenderTarget(myPtr);

            return Texture != IntPtr.Zero;

        }

        public bool IsRenderTarget(SDLTexture Texture)
        {

            return Texture == SDL.SDL_GetRenderTarget(myPtr);

        }

        public bool IsRenderTarget(IntPtr Texture)
        {

            return Texture == SDL.SDL_GetRenderTarget(myPtr);

        }

        public bool RenderTargetIsDefault()
        {

            return SDL.SDL_GetRenderTarget(myPtr) == IntPtr.Zero;

        }

        public void RenderClear()
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

        public void RenderCopy(IntPtr Texture, IntPtr Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, IntPtr.Zero, Dstrect));

        }

        public void RenderCopy(IntPtr Texture, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, IntPtr.Zero, ref Dstrect));

        }

        public void RenderCopy(IntPtr Texture, IntPtr Srcrect, IntPtr Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, Srcrect, Dstrect));

        }

        public void RenderCopy(IntPtr Texture, IntPtr Srcrect, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture, Srcrect, ref Dstrect));

        }

        public void RenderCopy(SDLTexture Texture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopy(myPtr, Texture.Ptr, ref Srcrect, ref Dstrect));

        }

        public void RenderCopyEx(IntPtr TheTexture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect, double Angle, ref SDL.SDL_Point Center, SDL.SDL_RendererFlip Flip)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderCopyEx(myPtr, TheTexture, ref Srcrect, ref Dstrect, Angle, ref Center, Flip));

        }

        public void RenderCopyEx(SDLTexture TheTexture, ref SDL.SDL_Rect Srcrect, ref SDL.SDL_Rect Dstrect, double Angle, ref SDL.SDL_Point Center, SDL.SDL_RendererFlip Flip)
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

        public void GetViewport(out SDL.SDL_Rect Rect)
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

        public void SetViewport(ref SDL.SDL_Rect Rect)
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
