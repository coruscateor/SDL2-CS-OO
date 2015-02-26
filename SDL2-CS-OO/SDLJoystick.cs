using System;
using SDL2;

namespace SDL2_CS_OO
{
    
    public sealed class SDLJoystick : SDLIndexedDevice, IDisposable
    {

        public SDLJoystick(IntPtr JoystickPtr)
        {

            myPtr = JoystickPtr;

            CheckPtr();

        }

        public SDLJoystick(int Device_Index)
        {

            myPtr = SDL.SDL_JoystickOpen(Device_Index);

            CheckPtr();

            myDeviceIndex = Device_Index;

        }

        public bool EventState(int State)
        {

            return Util.GetBoolResultOrThrow(SDL.SDL_JoystickEventState(State));

        }

        public bool GetAttached()
        {

            return SDL.SDL_JoystickGetAttached(myPtr) == SDL.SDL_bool.SDL_TRUE;

        }

        public short GetAxis(int Axis)
        {

            short Result = SDL.SDL_JoystickGetAxis(myPtr, Axis);

            ThrowIfResultIsError(Result);

            return Result;

        }

        public void GetBall(out int Dx, out int Dy, int Ball = 0)
        {

            Util.ThrowIfResultIsError(SDL.SDL_JoystickGetBall(myPtr, Ball, out Dx, out Dy));

        }

        public bool GetButton(int Button)
        {

            return SDL.SDL_JoystickGetButton(myPtr, Button) == 1;

        }

        public Guid GetDeviceGUID()
        {

            Guid Result = SDL.SDL_JoystickGetDeviceGUID(myDeviceIndex);

            Util.ThrowIfGUIDIsEmpty(Result);

            return Result;

        }

        public Guid GetGUID()
        {

            Guid Result = SDL.SDL_JoystickGetGUID(myPtr);

            Util.ThrowIfGUIDIsEmpty(Result);

            return Result;

        }

        public byte GetHat(int Hat = 0)
        {

            return SDL.SDL_JoystickGetHat(myPtr, Hat);

        }

        public int InstanceID()
        {

            return SDL.SDL_JoystickInstanceID(myPtr);

        }
        
        public bool IsHaptic()
        {

            return Util.GetBoolResultOrThrow(SDL.SDL_JoystickIsHaptic(myPtr));

        }

        public bool TryGetHaptic(out SDLHaptic Haptic)
        {

            if(Util.GetBoolResultOrThrow(SDL.SDL_JoystickIsHaptic(myPtr)))
            {

                Haptic = new SDLHaptic(this);

                return true;

            }

            Haptic = null;

            return false;

        }


        public string GetName()
        {

            return Util.GetStringResultOrThrow(SDL.SDL_JoystickName(myPtr));

        }

        public string GetNameForIndex()
        {

            return Util.GetStringResultOrThrow(SDL.SDL_JoystickNameForIndex(myDeviceIndex));

        }

        public int NumAxis()
        {

            int Result = SDL.SDL_JoystickNumAxes(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumBalls()
        {

            int Result = SDL.SDL_JoystickNumBalls(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumButtons()
        {

            int Result = SDL.SDL_JoystickNumButtons(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public int NumHats()
        {

            int Result = SDL.SDL_JoystickNumHats(myPtr);

            Util.ThrowIfResultIsError(Result);

            return Result;

        }

        public bool IsGameController()
        {

            return SDL.SDL_IsGameController(myDeviceIndex) == SDL.SDL_bool.SDL_TRUE;

        }

        public bool TryGetGameController(out SDLGameController GameController)
        {

            if(SDL.SDL_IsGameController(myDeviceIndex) == SDL.SDL_bool.SDL_TRUE)
            {

                GameController = new SDLGameController(this);

                return true;

            }

            GameController = null;

            return false;

        }

        ~SDLJoystick()
        {

            SDL.SDL_JoystickClose(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_JoystickClose(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
