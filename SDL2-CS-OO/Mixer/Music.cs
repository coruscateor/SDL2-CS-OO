using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Mixer
{
    
    public sealed class Music : SDLObject, IDisposable
    {

        public Music(string File)
        {

            myPtr = SDL_mixer.Mix_LoadMUS(File);

            CheckPtr();

        }

        public static bool Playing
        {

            get
            {

                return SDL_mixer.Mix_PlayingMusic() == 1;

            }

        }

        public static bool Paused
        {

            get
            {

                return SDL_mixer.Mix_PausedMusic() == 1;

            }

        }

        public static void Pause()
        {

            SDL_mixer.Mix_PauseMusic();

        }

        public static void Resume()
        {

            SDL_mixer.Mix_PauseMusic();

        }

        public static void Rewind()
        {

            SDL_mixer.Mix_RewindMusic();

        }

        public static void SetPosition(double Position)
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_SetMusicPosition(Position));

        }

        public static void SetCMD(string Command)
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_SetMusicCMD(Command));

        }

        public static void UseInternalMusicPlayers()
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_SetMusicCMD(null));

        }

        public static void Halt()
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_HaltMusic());

        }

        public static void FadeOut(int MS)
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_FadeOutMusic(MS));

        }

        public static SDL_mixer.Mix_Fading Fading
        {

            get
            {

                return SDL_mixer.Mix_FadingMusic();

            }

        }

        public void FadeIn(int MS, int Loops = 0)
        {

           Util.ThrowIfResultIsError(SDL_mixer.Mix_FadeInMusic(myPtr, Loops, MS));

        }

        public void FadeIn(int MS, double Position, int Loops = 0)
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_FadeInMusicPos(myPtr, Loops, MS, Position));

        }

        public SDL_mixer.Mix_MusicType Type
        {

            get
            {

                return SDL_mixer.Mix_GetMusicType(myPtr);

            }

        }

        public void Play(int Loops = 0)
        {

            Util.ThrowIfResultIsError(SDL_mixer.Mix_PlayMusic(myPtr, Loops));

        }

        ~Music()
        {

            SDL_mixer.Mix_FreeMusic(myPtr);

        }

        public void Dispose()
        {
            
            SDL_mixer.Mix_FreeMusic(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
