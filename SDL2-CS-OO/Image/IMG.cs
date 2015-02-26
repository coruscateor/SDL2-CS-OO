using System;
using SDL2;

namespace SDL2_CS_OO.Image
{
    
    /// <summary>
    /// http://www.libsdl.org/projects/SDL_image/docs/SDL_image_frame.html
    /// 
    /// Looks out of date
    /// </summary>
    public static class IMG
    {

        public static SDLSurface Load(string File)
        {

            return new SDLSurface(SDL_image.IMG_Load(File));

        }

        public static IntPtr Load_RWPtr(IntPtr Src, bool Freesrc)
        {

            return SDL_image.IMG_Load_RW(Src, Convert.ToInt32(Freesrc));

        }

        public static SDLSurface Load_RW(IntPtr Src, bool Freesrc)
        {

            return new SDLSurface(SDL_image.IMG_Load_RW(Src, Convert.ToInt32(Freesrc)));

        }

        public static IntPtr LoadTexturePtr(SDLRenderer Renderer, string File)
        {

            return SDL_image.IMG_LoadTexture(Renderer.Ptr, File);

        }

        public static SDLTexture LoadTexture(SDLRenderer Renderer, string File)
        {

            return new SDLTexture(SDL_image.IMG_LoadTexture(Renderer.Ptr, File));

        }

        public static IntPtr LoadTexture_RWPtr(SDLRenderer Renderer, IntPtr Src, bool Freesrc)
        {

            return SDL_image.IMG_LoadTexture_RW(Renderer.Ptr, Src, Convert.ToInt32(Freesrc));

        }

        public static SDLTexture LoadTexture_RW(SDLRenderer Renderer, IntPtr Src, bool Freesrc)
        {

            return new SDLTexture(SDL_image.IMG_LoadTexture_RW(Renderer.Ptr, Src, Convert.ToInt32(Freesrc)));

        }

        public static IntPtr LoadTextureTyped_RWPtr(SDLRenderer Renderer, IntPtr Src, bool Freesrc, string Type)
        {

            return SDL_image.IMG_LoadTextureTyped_RW(Renderer.Ptr, Src, Convert.ToInt32(Freesrc), Type);

        }

        public static SDLTexture LoadTextureTyped_RW(SDLRenderer Renderer, IntPtr Src, bool Freesrc, string Type)
        {

            return new SDLTexture(SDL_image.IMG_LoadTextureTyped_RW(Renderer.Ptr, Src, Convert.ToInt32(Freesrc), Type));

        }

        public static IntPtr LoadTyped_RWPtr(IntPtr Src, bool Freesrc, string Type)
        {

            return SDL_image.IMG_LoadTyped_RW(Src, Convert.ToInt32(Freesrc), Type);

        }

        public static SDLTexture LoadTyped_RW(IntPtr Src, bool Freesrc, string Type)
        {

            return new SDLTexture(SDL_image.IMG_LoadTyped_RW(Src, Convert.ToInt32(Freesrc), Type));

        }

        public static IntPtr ReadXPMFromArrayPtr(string[] xpm)
        {

            return SDL_image.IMG_ReadXPMFromArray(xpm);

        }

        public static SDLSurface ReadXPMFromArray(string[] xpm)
        {

            return new SDLSurface(SDL_image.IMG_ReadXPMFromArray(xpm));

        }

        public static void SavePNG(IntPtr Surface, string File)
        {

            Util.ThrowIfResultIsError(SDL_image.IMG_SavePNG(Surface, File));

        }

        public static void SavePNG(SDLSurface Surface, string File)
        {

            Util.ThrowIfResultIsError(SDL_image.IMG_SavePNG(Surface.Ptr, File));

        }

        public static void SavePNG_RW(IntPtr Surface, IntPtr Dst, bool Freedst)
        {

            Util.ThrowIfResultIsError(SDL_image.IMG_SavePNG_RW(Surface, Dst, Convert.ToInt32(Freedst)));

        }

        public static void SavePNG(SDLSurface Surface, IntPtr Dst, bool Freedst)
        {

            Util.ThrowIfResultIsError(SDL_image.IMG_SavePNG_RW(Surface.Ptr, Dst, Convert.ToInt32(Freedst)));

        }

    }

}
