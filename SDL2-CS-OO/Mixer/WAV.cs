using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Mixer
{

    public sealed class WAV : Chunk
    {

        public WAV(string File)
        {

            myPtr = SDL_mixer.Mix_LoadWAV(File);

            CheckPtr();

        }

        public WAV(IntPtr Src, bool Freesrc)
        {

            myPtr = SDL_mixer.Mix_LoadWAV_RW(Src, Convert.ToInt32(Freesrc));

            CheckPtr();

        }

        public WAV(byte[] Mem)
        {

            myPtr = SDL_mixer.Mix_QuickLoad_WAV(Mem);

            CheckPtr();

        }

    }

}
