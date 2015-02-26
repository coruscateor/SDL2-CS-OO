using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO
{
    
    public static class SDLInit
    {

        public static void AudioSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_AUDIO));

        }

        public static void EveryThing()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_EVERYTHING));

        }

        public static void GameControllerSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_GAMECONTROLLER));

        }

        public static void HapticSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_HAPTIC));

        }

        public static void JoystickSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_JOYSTICK));

        }

        public static void NoParachuteSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_NOPARACHUTE));

        }

        public static void TimerSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_TIMER));

        }

        public static void VideoSubSystem()
        {

            Util.ThrowIfResultIsError(SDL.SDL_InitSubSystem(SDL.SDL_INIT_VIDEO));

        }

    }

}
