using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLWAV : IDisposable
    {

        private string myFile;

        private SDL.SDL_AudioSpec myAudioSpec;

        private IntPtr myAudio_Buf;

        private uint myAudio_Len;

        public SDLWAV(string File, ref SDL.SDL_AudioSpec Spec)
        {

            myAudioSpec = SDL.SDL_LoadWAV(File, ref Spec, out myAudio_Buf, out myAudio_Len);

            myFile = File;

        }

        public string File
        {

            get
            {

                return myFile;

            }

        }

        public SDL.SDL_AudioSpec AudioSpec
        {

            get
            {

                return myAudioSpec;

            }

        }

        public IntPtr Audio_Buf
        {

            get
            {

                return myAudio_Buf;

            }

        }

        public uint Audio_Len
        {

            get
            {

                return myAudio_Len;

            }

        }

        public SDLAudioDevice GetAudioDevice()
        {

            SDL.SDL_AudioSpec Obtained;

            return new SDLAudioDevice(ref myAudioSpec, out Obtained);

        }

        public SDLAudioDevice GetAudioDevice(out SDL.SDL_AudioSpec Obtained)
        {

            return new SDLAudioDevice(ref myAudioSpec, out Obtained);

        }

        public SDLAudioDevice GetAudioDevice(int Allowed_Changes)
        {

            SDL.SDL_AudioSpec Obtained;

            return new SDLAudioDevice(ref myAudioSpec, out Obtained, Allowed_Changes);

        }

        public SDLAudioDevice GetAudioDevice(out SDL.SDL_AudioSpec Obtained, int Allowed_Changes)
        {

            return new SDLAudioDevice(ref myAudioSpec, out Obtained, Allowed_Changes);

        }

        public SDLAudioDevice GetAudioDevice(string Device, bool Iscapture, int Allowed_Changes)
        {

            SDL.SDL_AudioSpec Obtained;

            return new SDLAudioDevice(Device, Iscapture, ref myAudioSpec, out Obtained, Allowed_Changes);

        }

        public SDLAudioDevice GetAudioDevice(string Device, bool Iscapture, out SDL.SDL_AudioSpec Obtained, int Allowed_Changes)
        {

            return new SDLAudioDevice(Device, Iscapture, ref myAudioSpec, out Obtained, Allowed_Changes);

        }

        ~SDLWAV()
        {

            SDL.SDL_FreeWAV(myAudio_Buf);

        }

        public void Dispose()
        {

            SDL.SDL_FreeWAV(myAudio_Buf);

            GC.SuppressFinalize(this);

        }

    }

}
