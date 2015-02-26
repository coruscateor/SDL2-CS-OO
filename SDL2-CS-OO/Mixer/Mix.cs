using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Mixer
{

    public static class Mix
    {

        public const int Max = -1;

        public static void OpenAudio(ushort Format, int Channels, int ChunkSize)
        {

            int Result = SDL_mixer.Mix_OpenAudio(SDL_mixer.MIX_DEFAULT_FREQUENCY, Format, Channels, ChunkSize);

            if(Result != 0)
                throw new SDLErrorException(Result);

        }

        public static void OpenAudio(int Frequerncy, ushort Format, int Channels, int ChunkSize)
        {

            int Result = SDL_mixer.Mix_OpenAudio(Frequerncy, Format, Channels, ChunkSize);

            if(Result != 0)
                throw new SDLErrorException(Result);

        }

        public static bool TryOpenAudio(ushort Format, int Channels, int ChunkSize)
        {

            return SDL_mixer.Mix_OpenAudio(SDL_mixer.MIX_DEFAULT_FREQUENCY, Format, Channels, ChunkSize) == 0;

        }

        public static bool TryOpenAudio(int Frequerncy, ushort Format, int Channels, int ChunkSize)
        {

            return SDL_mixer.Mix_OpenAudio(Frequerncy, Format, Channels, ChunkSize) == 0;

        }

        public static void StopCustomMusicPlayer()
        {

            SDL_mixer.Mix_HookMusic(null, IntPtr.Zero);

        }

    }

}
