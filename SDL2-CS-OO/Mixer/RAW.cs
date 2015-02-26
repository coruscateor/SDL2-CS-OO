using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Mixer
{

    public sealed class RAW : Chunk
    {

        public RAW(byte[] Mem)
        {

            Util.ThrowIfPointerZero(SDL_mixer.Mix_QuickLoad_RAW(Mem, (uint)Mem.Length));

        }

        public RAW(byte[] Mem, int Len)
        {

            Util.ThrowIfPointerZero(SDL_mixer.Mix_QuickLoad_RAW(Mem, (uint)Len));

        }

    }

}
