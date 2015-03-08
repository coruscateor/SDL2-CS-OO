using System;
using System.Collections.Generic;
using System.Linq;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLWindow : SDLObject, IDisposable
    {

        public SDLWindow(IntPtr Ptr)
        {

            myPtr = Ptr;

            CheckPtr();

        }

        public SDLWindow(string Title)
        {

            SDL.SDL_WindowFlags Flags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE;

            myPtr = SDL.SDL_CreateWindow(Title, SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 480, 680, Flags);

            CheckPtr();

        }

        public SDLWindow(SDL.SDL_WindowFlags Flags)
        {

            myPtr = SDL.SDL_CreateWindow("", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 480, 680, Flags);

            CheckPtr();

        }

        public SDLWindow(string TheTitle, SDL.SDL_WindowFlags Flags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE)
        {

            myPtr = SDL.SDL_CreateWindow(TheTitle, SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 480, 680, Flags);

            CheckPtr();

        }

        public SDLWindow(string Title = "", int x = SDL.SDL_WINDOWPOS_UNDEFINED, int y = SDL.SDL_WINDOWPOS_UNDEFINED, int w = 480, int h = 640, SDL.SDL_WindowFlags TheFlags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE)
        {

            myPtr = SDL.SDL_CreateWindow(Title, x, y, w, h, TheFlags);

            CheckPtr();

        }

        public static SDLWindow CreateFrom(IntPtr Data)
        {

            return new SDLWindow(SDL.SDL_CreateWindowFrom(Data));

        }

        public uint GetID()
        {

            return SDL.SDL_GetWindowID(myPtr);

        }

        public SDLRenderer GetRenderer()
        {

            return new SDLRenderer(SDL.SDL_GetRenderer(myPtr));

        }

        public IntPtr GetRendererPtr()
        {

            return SDL.SDL_GetRenderer(myPtr);

        }

        public SDLRenderer CreateRenderer(uint Flags)
        {

            return new SDLRenderer(myPtr, Flags);

        }

        public IntPtr CreateRendererPtr(uint Flags)
        {

            return SDL.SDL_CreateRenderer(myPtr, -1, Flags);

        }

        public SDLRenderer CreateRenderer(SDL.SDL_RendererFlags Flags)
        {

            return new SDLRenderer(myPtr, Flags);

        }

        public IntPtr CreateRendererPtr(SDL.SDL_RendererFlags Flags)
        {

            return SDL.SDL_CreateRenderer(myPtr, -1, (uint)Flags);

        }

        public SDLRenderer CreateRenderer(int Index, uint Flags)
        {

            return new SDLRenderer(myPtr, Index, Flags);

        }

        public IntPtr CreateRendererPtr(int Index, uint Flags)
        {

            return SDL.SDL_CreateRenderer(myPtr, Index, Flags);

        }

        public SDLRenderer CreateRenderer(int Index, SDL.SDL_RendererFlags Flags)
        {

            return new SDLRenderer(myPtr, Index, Flags);

        }
        
        public IntPtr CreateRendererPtr(int Index, SDL.SDL_RendererFlags Flags)
        {

            return SDL.SDL_CreateRenderer(myPtr, Index, (uint)Flags);

        }

        public void SetWindowPositionX(int Value)
        {

            int OldX;

            int Y;

            SDL.SDL_GetWindowPosition(myPtr, out OldX, out Y);

            SDL.SDL_SetWindowPosition(myPtr, Value, Y);

        }

        public void SetPositionY(int Value)
        {

            int X;

            int OldY;

            SDL.SDL_GetWindowPosition(myPtr, out X, out OldY);

            SDL.SDL_SetWindowPosition(myPtr, X, Value);

        }

        public void SetPosition(int X, int Y)
        {

            SDL.SDL_SetWindowPosition(myPtr, X, Y);

        }

        public void GetPosition(out int X, out int Y)
        {

            SDL.SDL_GetWindowPosition(myPtr, out X, out Y);

        }

        public void SetSizeW(int Value)
        {

            int OldW;

            int H;

            SDL.SDL_GetWindowSize(myPtr, out OldW, out H);

            SDL.SDL_SetWindowSize(myPtr, Value, H);

        }

        public void SetSizeH(int Value)
        {

            int W;

            int OldH;

            SDL.SDL_GetWindowSize(myPtr, out W, out OldH);

            SDL.SDL_SetWindowSize(myPtr, W, Value);

        }

        public void SetSize(int W, int H)
        {

            SDL.SDL_SetWindowSize(myPtr, W, H);

        }

        public void GetSize(out int W, out int H)
        {

            SDL.SDL_GetWindowSize(myPtr, out W, out H);

        }

        public void Hide()
        {

            SDL.SDL_HideWindow(myPtr);

        }

        public void Show()
        {

            SDL.SDL_ShowWindow(myPtr);

        }

        public float GetBrightness()
        {

            return SDL.SDL_GetWindowBrightness(myPtr);

        }

        public void SetBrightness(float Brightness)
        {

            SDL.SDL_SetWindowBrightness(myPtr, Brightness);

        }

        public IntPtr GetData(string TheName)
        {

            return SDL.SDL_GetWindowData(myPtr, TheName);

        }

        public int GetDisplayIndex()
        {

            int Result = SDL.SDL_GetWindowDisplayIndex(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public SDL.SDL_DisplayMode GetDispalyMode()
        {

            SDL.SDL_DisplayMode CurrentDisplayMode;

            Util.ThrowIfResultIsError(SDL.SDL_GetWindowDisplayMode(myPtr, out CurrentDisplayMode));

            return CurrentDisplayMode;

        }

        public SDL.SDL_WindowFlags GetFlags()
        {

            return (SDL.SDL_WindowFlags)SDL.SDL_GetWindowFlags(myPtr);

        }

        public uint GetFlagsUInt()
        {

            return SDL.SDL_GetWindowFlags(myPtr);

        }

        public void GetGammaRamp(ushort[] TheRed, ushort[] TheGreen, ushort[] TheBlue)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GetWindowGammaRamp(myPtr, TheRed, TheGreen, TheBlue));

        }

        public void GetGammaRamp(out ushort[] TheRed, out ushort[] TheGreen, out ushort[] TheBlue)
        {

            TheRed = new ushort[256];

            TheGreen = new ushort[256];

            TheBlue = new ushort[256];

            Util.ThrowIfResultIsError(SDL.SDL_GetWindowGammaRamp(myPtr, TheRed, TheGreen, TheBlue));

        }

        public GammaRamp GetGammaRamp()
        {

            ushort[] CurrentRed = new ushort[256];

            ushort[] CurrentGreen = new ushort[256];

            ushort[] CurrentBlue = new ushort[256];

            Util.ThrowIfResultIsError(SDL.SDL_GetWindowGammaRamp(myPtr, CurrentRed, CurrentGreen, CurrentBlue));

            return new GammaRamp(CurrentRed, CurrentGreen, CurrentBlue);

        }

        public void GetMaximumSize(out int Max_W, out int Max_H)
        {

            SDL.SDL_GetWindowMaximumSize(myPtr, out Max_W, out Max_H);

        }

        public void GetMinimumSize(out int Max_W, out int Max_H)
        {

            SDL.SDL_GetWindowMinimumSize(myPtr, out Max_W, out Max_H);

        }

        public SDLPixelFormat GetPixelFormat()
        {

            return new SDLPixelFormat(SDL.SDL_GetWindowPixelFormat(myPtr));

        }

        public uint GetPixelFormatUInt()
        {

            return SDL.SDL_GetWindowPixelFormat(myPtr);

        }

        public IntPtr GetSurfacePtr()
        {

            return SDL.SDL_GetWindowSurface(myPtr);

        }

        public SDLSurface GetSurface()
        {

            return new SDLSurface(SDL.SDL_GetWindowSurface(myPtr));

        }

        public string GetTitle()
        {

            return SDL.SDL_GetWindowTitle(myPtr);

        }

        public void SetTitle(string Title)
        {

            SDL.SDL_SetWindowTitle(myPtr, Title);

        }

        public bool GetWMInfo(ref SDL.SDL_SysWMinfo Info)
        {

            return SDL.SDL_GetWindowWMInfo(myPtr, ref Info) != SDL.SDL_bool.SDL_FALSE;

        }

        public void SetGammaRamp(ushort[] Red, ushort[] Green, ushort[] Blue)
        {

            Util.ThrowIfResultIsError(SDL.SDL_SetWindowGammaRamp(myPtr, Red, Green, Blue));

        }

        public void UpdateSurface()
        {

            Util.ThrowIfResultIsError(SDL.SDL_UpdateWindowSurface(myPtr));

        }

        public bool TryUpdateSurfaceRects(SDL.SDL_Rect[] Rects)
        {

            return SDL.SDL_UpdateWindowSurfaceRects(myPtr, Rects, Rects.Length) > -1;

        }

        public void UpdateSurfaceRects(SDL.SDL_Rect[] Rects)
        {

            Util.ThrowIfResultIsError(SDL.SDL_UpdateWindowSurfaceRects(myPtr, Rects, Rects.Length));

        }

        public bool TryUpdateSurfaceRects(IEnumerable<SDL.SDL_Rect> Rects)
        {

            var RectsArray = Rects.ToArray();

            return SDL.SDL_UpdateWindowSurfaceRects(myPtr, RectsArray, RectsArray.Length) > -1;

        }

        public void UpdateSurfaceRects(IEnumerable<SDL.SDL_Rect> Rects)
        {

            var RectsArray = Rects.ToArray();

            Util.ThrowIfResultIsError(SDL.SDL_UpdateWindowSurfaceRects(myPtr, RectsArray, RectsArray.Length));

        }

        public bool TryUpdateSurfaceRects(IList<SDL.SDL_Rect> Rects)
        {

            var RectsArray = Rects.ToArray();

            return SDL.SDL_UpdateWindowSurfaceRects(myPtr, RectsArray, RectsArray.Length) > -1;

        }

        public void UpdateSurfaceRects(IList<SDL.SDL_Rect> Rects)
        {

            var RectsArray = Rects.ToArray();

            Util.ThrowIfResultIsError(SDL.SDL_UpdateWindowSurfaceRects(myPtr, RectsArray, RectsArray.Length));

        }

        public void SetBordered(bool Bordered)
        {

            SDL.SDL_SetWindowBordered(myPtr, Util.ConvertTo(Bordered));

        }

        public IntPtr SetData(string Name, IntPtr UserData)
        {

            return SDL.SDL_SetWindowData(myPtr, Name, UserData);

        }

        public bool GetGrab()
        {

            return SDL.SDL_GetWindowGrab(myPtr) == SDL.SDL_bool.SDL_TRUE;

        }

        public void SetGrab(bool Grabbed)
        {

            SDL.SDL_SetWindowGrab(myPtr, Util.ConvertTo(Grabbed));

        }

        public void SetIcon(IntPtr Icon)
        {

            SDL.SDL_SetWindowIcon(myPtr, Icon);

        }

        public SDL_GLContext GL_CreateContext()
        {

            IntPtr Result = SDL.SDL_GL_CreateContext(myPtr);

            return new SDL_GLContext(Result);

        }

        public IntPtr GL_CreateContextPtr()
        {

            IntPtr Result = SDL.SDL_GL_CreateContext(myPtr);

            Util.ThrowIfPointerZero(Result);

            return Result;

        }

        public void GL_GetDrawableSize(out int W, out int H)
        {

            SDL.SDL_GL_GetDrawableSize(myPtr, out W, out H);

        }

        public void GL_MakeCurrent(IntPtr Context)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_MakeCurrent(myPtr, Context));

        }

        public void GL_MakeCurrent(SDL_GLContext Context)
        {

            Util.ThrowIfResultIsError(SDL.SDL_GL_MakeCurrent(myPtr, Context.Ptr));

        }

        public bool HasMouseFocus()
        {

            return myPtr == SDL.SDL_GetMouseFocus();

        }

        public bool HasKeyboardFocus()
        {

            return myPtr == SDL.SDL_GetKeyboardFocus();

        }

        public void WarpMouse(int X, int Y)
        {

            SDL.SDL_WarpMouseInWindow(myPtr, X, Y);

        }

        public void GL_SwapWindow()
        {

            SDL.SDL_GL_SwapWindow(myPtr);

        }

        ~SDLWindow()
        {

            SDL.SDL_DestroyWindow(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_DestroyWindow(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
