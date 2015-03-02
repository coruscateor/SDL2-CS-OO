using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Mixer
{

    /// <summary>
    /// http://www.libsdl.org/projects/SDL_mixer/docs/SDL_mixer_toc.html#SEC_Contents
    /// </summary>
    public abstract class Chunk : SDLObject, IDisposable
    {

        public int FadeInChannel(int MS, int Channel = -1, int Loops = 0)
        {

            int Result = SDL_mixer.Mix_FadeInChannel(Channel, myPtr, Loops, MS);

            if(Result == -1)
                throw new SDLErrorException(Result);

            return Result;

        }

        public int FadeInChannelTimed(int MS, int Ticks, int Channel = -1, int Loops = 0)
        {

            int Result = SDL_mixer.Mix_FadeInChannelTimed(Channel, myPtr, Loops, MS, Ticks);

            if(Result == -1)
                throw new SDLErrorException(Result);

            return Result;

        }

        public int PlayChannel(int Channel = -1, int Loops = 0)
        {

            int Result = SDL_mixer.Mix_PlayChannel(Channel, myPtr, Loops);

            if(Result == -1)
                throw new SDLErrorException(Result);

            return Result;

        }

        public int PlayChannelTimed(int Ticks, int Channel = -1, int Loops = 0)
        {

            int Result = SDL_mixer.Mix_PlayChannelTimed(Channel, myPtr, Loops, Ticks);

            if(Result == -1)
                throw new SDLErrorException(Result);

            return Result;

        }

        public int Volume(int Volume)
        {

            return SDL_mixer.Mix_VolumeChunk(myPtr, Volume);

        }

        ~Chunk()
        {

            SDL_mixer.Mix_FreeChunk(myPtr);

        }
    
        public void Dispose()
        {

            SDL_mixer.Mix_FreeChunk(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
