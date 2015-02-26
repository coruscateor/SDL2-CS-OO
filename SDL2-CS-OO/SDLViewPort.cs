using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLViewPort
    {

        private SDL.SDL_Rect myRect; 

        public SDLViewPort()
        {
        }

        public SDLViewPort(SDL.SDL_Rect Rect)
        {

            myRect = Rect;

        }

        public SDLViewPort(int H, int W, int X, int Y)
        {

            myRect = new SDL.SDL_Rect { h = H, w = W, x = X, y = Y };

        }

        public SDL.SDL_Rect Rect
        {

            get
            {

                return myRect;

            }
            set
            {

                myRect = value;

            }

        }

        public int H
        {

            get
            {

                return myRect.h;

            }
            set
            {

                myRect.h = value;

            }

        }

        public int W
        {

            get
            {

                return myRect.w;

            }
            set
            {

                myRect.w = value;

            }

        }

        public int Y
        {

            get
            {

                return myRect.y;

            }
            set
            {

                myRect.y = value;

            }

        }

        public int X
        {

            get
            {

                return myRect.x;

            }
            set
            {

                myRect.x = value;

            }

        }

        public void Render(IntPtr Renderer)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetViewport(Renderer, ref myRect));

        }

        public void Render(SDLRenderer Renderer)
        {

            Util.ThrowIfResultIsError(SDL.SDL_RenderSetViewport(Renderer.Ptr, ref myRect));

        }

    }

}
