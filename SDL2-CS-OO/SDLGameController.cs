using System;
using SDL2;

namespace SDL2_CS_OO
{

    public sealed class SDLGameController : SDLIndexedDevice, IDisposable
    {

        public SDLGameController(int Device_Index)
        {

            myPtr = SDL.SDL_GameControllerOpen(Device_Index);

            CheckPtr();

            myDeviceIndex = Device_Index;

        }
        
        public SDLGameController(SDLJoystick Joystick)
        {

            myPtr = SDL.SDL_GameControllerOpen(Joystick.DeviceIndex);

            CheckPtr();

            myDeviceIndex = Joystick.DeviceIndex;

        }

        public bool GetAttached()
        {

            return SDL.SDL_GameControllerGetAttached(myPtr) == SDL.SDL_bool.SDL_TRUE;

        }

        public short GetAxis(SDL.SDL_GameControllerAxis Axis)
        {

            return SDL.SDL_GameControllerGetAxis(myPtr, Axis);

        }

        public SDL.SDL_GameControllerButtonBind GetBindForAxis(SDL.SDL_GameControllerAxis Axis)
        {

            return SDL.SDL_GameControllerGetBindForAxis(myPtr, Axis);

        }

        public SDL.SDL_GameControllerButtonBind GetBindForButton(SDL.SDL_GameControllerButton Button)
        {

            return SDL.SDL_GameControllerGetBindForButton(myPtr, Button);

        }

        public bool GetButton(SDL.SDL_GameControllerButton Button)
        {

            return SDL.SDL_GameControllerGetButton(myPtr, Button) == 1;

        }

        public IntPtr GetJoystickPtr()
        {

            return SDL.SDL_GameControllerGetJoystick(myPtr);

        }

        public SDLJoystick GetJoystick()
        {

            return new SDLJoystick(SDL.SDL_GameControllerGetJoystick(myPtr));

        }

        public string GetMapping()
        {

            return SDL.SDL_GameControllerMapping(myPtr);

        }

        public string GetName()
        {

            return SDL.SDL_GameControllerName(myPtr);

        }

        public string GetNameForIndex()
        {

            return SDL.SDL_GameControllerNameForIndex(myDeviceIndex);

        }

        ~SDLGameController()
        {

            SDL.SDL_GameControllerClose(myPtr);

        }

        public void Dispose()
        {

            SDL.SDL_GameControllerClose(myPtr);

            GC.SuppressFinalize(this);

        }

    }

}
