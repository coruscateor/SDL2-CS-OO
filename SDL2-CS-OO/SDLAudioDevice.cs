using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLAudioDevice : IDisposable
    {

        private uint myDeviceID;

        private SDL.SDL_AudioSpec myObtainedSpec;

        public SDLAudioDevice(ref SDL.SDL_AudioSpec Desired, out SDL.SDL_AudioSpec Obtained)
        {

            myDeviceID = SDL.SDL_OpenAudioDevice(null, 0, ref Desired, out Obtained, (int)SDL.SDL_AUDIO_ALLOW_ANY_CHANGE);

            CheckDeviceID();

            myObtainedSpec = Obtained;

        }

        public SDLAudioDevice(ref SDL.SDL_AudioSpec Desired, out SDL.SDL_AudioSpec Obtained, int Allowed_Changes)
        {

            myDeviceID = SDL.SDL_OpenAudioDevice(null, 0, ref Desired, out Obtained, Allowed_Changes);

            CheckDeviceID();

            myObtainedSpec = Obtained;

        }

        public SDLAudioDevice(string Device, bool Iscapture, ref SDL.SDL_AudioSpec Desired, out SDL.SDL_AudioSpec Obtained, int Allowed_Changes)
        {

            myDeviceID = SDL.SDL_OpenAudioDevice(Device, Convert.ToInt32(Iscapture), ref Desired, out Obtained, Allowed_Changes);

            CheckDeviceID();

            myObtainedSpec = Obtained;

        }

        private void CheckDeviceID()
        {

            if(myDeviceID < 0u)
                throw new SDLErrorException();

        }

        public uint DeviceID
        {

            get
            {

                return myDeviceID;

            }

        }

        public SDL.SDL_AudioSpec ObtainedSpec
        {

            get
            {

                return myObtainedSpec;

            }

        }

        public void Lock()
        {

            SDL.SDL_LockAudioDevice(myDeviceID);

        }

        public void Lock(Action<SDLAudioDevice> Action)
        {

            SDL.SDL_LockAudioDevice(myDeviceID);

            try
            {

                Action(this);

            }
            finally
            {

                SDL.SDL_UnlockAudioDevice(myDeviceID);

            }

        }

        public void UnLock()
        {

            SDL.SDL_UnlockAudioDevice(myDeviceID);

        }

        public void Play()
        {

            SDL.SDL_PauseAudioDevice(myDeviceID, 0);

        }

        public void Pause()
        {

            SDL.SDL_PauseAudioDevice(myDeviceID, 1);

        }

        ~SDLAudioDevice()
        {

            SDL.SDL_CloseAudioDevice(myDeviceID);

        }

        public void Dispose()
        {

            SDL.SDL_CloseAudioDevice(myDeviceID);

            GC.SuppressFinalize(this);

        }

    }

}
