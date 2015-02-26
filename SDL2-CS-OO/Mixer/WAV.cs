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

            Util.ThrowIfPointerZero(SDL_mixer.Mix_LoadWAV(File));

        }

        public WAV(IntPtr Src, bool Freesrc)
        {

            Util.ThrowIfPointerZero(SDL_mixer.Mix_LoadWAV_RW(Src, Convert.ToInt32(Freesrc)));

        }

        public WAV(byte[] Mem)
        {

            Util.ThrowIfPointerZero(SDL_mixer.Mix_QuickLoad_WAV(Mem));

        }

    }

}
