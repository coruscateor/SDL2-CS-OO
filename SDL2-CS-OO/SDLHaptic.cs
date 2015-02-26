using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLHaptic : SDLIndexedDevice, IDisposable
    {

        public SDLHaptic()
        {

            myPtr = SDL.SDL_HapticOpenFromMouse();

            CheckPtr();

            myDeviceIndex = Index();

        }

        public SDLHaptic(int Device_index)
        {

            myPtr = SDL.SDL_HapticOpen(Device_index);

            CheckPtr();

            myDeviceIndex = Device_index;

        }

        public SDLHaptic(IntPtr Joystick)
        {

            myPtr = SDL.SDL_HapticOpenFromJoystick(Joystick);

            CheckPtr();

            myDeviceIndex = Index();

        }

        public SDLHaptic(SDLJoystick Joystick)
        {

            myPtr = SDL.SDL_HapticOpenFromJoystick(Joystick);

            CheckPtr();

            myDeviceIndex = Joystick.DeviceIndex;

        }

        public void DestroyEffect(int Effect)
        {

            SDL.SDL_HapticDestroyEffect(myPtr, Effect);

        }

        public bool EffectSupported(ref SDL.SDL_HapticEffect Effect)
        {

            return Util.GetBoolResultOrThrow(SDL.SDL_HapticEffectSupported(myPtr, ref Effect));

        }

        public bool GetEffectStatus(int Effect)
        {

            return Util.GetBoolResultOrThrow(SDL.SDL_HapticGetEffectStatus(myPtr, Effect));

        }

        public int Index()
        {

            int Result = SDL.SDL_HapticIndex(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public string Name()
        {

            string Result = SDL.SDL_HapticName(myDeviceIndex);

            if(Result == null)
                throw new SDLErrorException();

            return Result;

        }

        public int NewEffect(ref SDL.SDL_HapticEffect Effect)
        {

            int Result = SDL.SDL_HapticNewEffect(myPtr, ref Effect);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumAxes()
        {

            int Result = SDL.SDL_HapticNumAxes(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumEffects()
        {

            int Result = SDL.SDL_HapticNumEffects(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumEffectsPlaying()
        {

            int Result = SDL.SDL_HapticNumEffectsPlaying(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public bool Opened()
        {

            return SDL.SDL_HapticOpened(myDeviceIndex) > 0;

        }

        public void Pause()
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticPause(myPtr));

        }

        public uint Query()
        {

            uint Result = SDL.SDL_HapticQuery(myPtr);

            if(Result < 0u)
                throw new SDLErrorException((int)Result);

            return Result;

        }

        public void RumbleInit()
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticRumbleInit(myPtr));

        }

        public void RumblePlay(float Strength, uint Length)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticRumblePlay(myPtr, Strength, Length));

        }

        public void RumbleStop()
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticRumbleStop(myPtr));

        }

        public bool RumbleSupported()
        {

            return Util.GetBoolResultOrThrow(SDL.SDL_HapticRumbleSupported(myPtr));

        }

        public void RunEffect(int Effect, uint Iterations)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticRunEffect(myPtr, Effect, Iterations));

        }

        public void SetAutocenter(int Autocenter)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticSetAutocenter(myPtr, Autocenter));

        }

        public void SetGain(int Gain)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticSetGain(myPtr, Gain));

        }

        public void StopAll()
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticStopAll(myPtr));

        }

        public void StopEffect(int Effect)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticStopEffect(myPtr, Effect));

        }

        public void UnPause()
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticUnpause(myPtr));

        }

        public void UpdateEffect(int Effect, ref SDL.SDL_HapticEffect Data)
        {

            Util.ThrowIfResultIsError(SDL.SDL_HapticUpdateEffect(myPtr, Effect, ref Data));

        }

        ~SDLHaptic()
        {

            SDL.SDL_HapticClose(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_HapticClose(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
