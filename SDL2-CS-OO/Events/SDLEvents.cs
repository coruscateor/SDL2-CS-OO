using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace SDL2_CS_OO.Events
{

    public delegate void EventD(object Sender, ref SDL.SDL_Event Event);

    public sealed class SDLEvents
    {

        public event Action<object> NoEventPending;

        public event EventD ClipBoardUpdate;

        public event EventD ControllerAxisMotion;

        public event EventD ControllerButtonDown;

        public event EventD ControllerButtonUp;

        public event EventD ControllerDeviceAdded;

        public event EventD ControllerDeviceMapped;

        public event EventD ControllerDeviceMoved;

        public event EventD DollarGesture;

        public event EventD DollarRecord;

        public event EventD DropFile;

        public event EventD FingerDown;

        public event EventD FingerMotion;

        public event EventD FingerUp;

        public event EventD FirstEvent;

        public event EventD JoyAxisMotion;

        public event EventD JoyBallMotion;

        public event EventD JoyButtonDown;

        public event EventD JoyButtonUp;

        public event EventD JoyDeviceAdded;

        public event EventD JoyDeviceRemoved;

        public event EventD JoyHatMotion;

        public event EventD KeyDown;

        public event EventD KeyUp;

        public event EventD LastEvent;

        public event EventD MouseButtonDown;

        public event EventD MouseButtonUp;

        public event EventD MouseMotion;

        public event EventD MouseWheel;

        public event EventD MultiGesture;

        public event EventD Quit;

        public event EventD Render_Taregets_Reset;

        public event EventD SYSWMEvent;

        public event EventD TextEditing;

        public event EventD TextInput;

        public event EventD UserEvent;

        public event EventD WindowEvent;

        public void Poll()
        {

            SDL.SDL_Event Event;

            if(SDL.SDL_PollEvent(out Event) != 1)
            {

                //No event pending

                OnNoEventPending();

                return;

            }

            Poll(ref Event);

        }

        private void OnNoEventPending()
        {

            if(NoEventPending != null)
                NoEventPending(this);

        }

        private void OnClipBoardUpdate(ref SDL.SDL_Event Event)
        {

            if(ClipBoardUpdate != null)
                ClipBoardUpdate(this, ref Event);

        }

        private void OnControllerAxisMotion(ref SDL.SDL_Event Event)
        {

            if(ControllerAxisMotion != null)
                ControllerAxisMotion(this, ref Event);

        }

        private void OnControllerButtonDown(ref SDL.SDL_Event Event)
        {

            if(ControllerButtonDown != null)
                ControllerButtonDown(this, ref Event);

        }

        private void OnControllerButtonUp(ref SDL.SDL_Event Event)
        {

            if(ControllerButtonUp != null)
                ControllerButtonUp(this, ref Event);

        }

        private void OnControllerDeviceAdded(ref SDL.SDL_Event Event)
        {

            if(ControllerDeviceAdded != null)
                ControllerDeviceAdded(this, ref Event);

        }

        private void OnControllerDeviceMapped(ref SDL.SDL_Event Event)
        {

            if(ControllerDeviceMapped != null)
                ControllerDeviceMapped(this, ref Event);

        }

        private void OnControllerDeviceMoved(ref SDL.SDL_Event Event)
        {

            if(ControllerDeviceMoved != null)
                ControllerDeviceMoved(this, ref Event);

        }

        private void OnDollarGesture(ref SDL.SDL_Event Event)
        {

            if(DollarGesture != null)
                DollarGesture(this, ref Event);

        }

        private void OnDollarRecord(ref SDL.SDL_Event Event)
        {

            if(DollarRecord != null)
                DollarRecord(this, ref Event);

        }

        private void OnDropFile(ref SDL.SDL_Event Event)
        {

            if(DropFile != null)
                DropFile(this, ref Event);

        }

        private void OnFingerDown(ref SDL.SDL_Event Event)
        {

            if(FingerDown != null)
                FingerDown(this, ref Event);

        }

        private void OnFingerMotion(ref SDL.SDL_Event Event)
        {

            if(FingerMotion != null)
                FingerMotion(this, ref Event);

        }

        private void OnFingerUp(ref SDL.SDL_Event Event)
        {

            if(FingerUp != null)
                FingerUp(this, ref Event);

        }

        private void OnFirstEvent(ref SDL.SDL_Event Event)
        {

            if(FirstEvent != null)
                FirstEvent(this, ref Event);

        }

        private void OnJoyAxisMotion(ref SDL.SDL_Event Event)
        {

            if(JoyAxisMotion != null)
                JoyAxisMotion(this, ref Event);

        }

        private void OnJoyBallMotion(ref SDL.SDL_Event Event)
        {

            if(JoyBallMotion != null)
                JoyBallMotion(this, ref Event);

        }

        private void OnJoyButtonDown(ref SDL.SDL_Event Event)
        {

            if(JoyButtonDown != null)
                JoyButtonDown(this, ref Event);

        }

        private void OnJoyButtonUp(ref SDL.SDL_Event Event)
        {

            if(JoyButtonUp != null)
                JoyButtonUp(this, ref Event);

        }

        private void OnJoyDeviceAdded(ref SDL.SDL_Event Event)
        {

            if(JoyDeviceAdded != null)
                JoyDeviceAdded(this, ref Event);

        }


        private void OnJoyDeviceRemoved(ref SDL.SDL_Event Event)
        {

            if(JoyDeviceRemoved != null)
                JoyDeviceRemoved(this, ref Event);

        }


        private void OnJoyHatMotion(ref SDL.SDL_Event Event)
        {

            if(JoyHatMotion != null)
                JoyHatMotion(this, ref Event);

        }


        private void OnKeyDown(ref SDL.SDL_Event Event)
        {

            if(KeyDown != null)
                KeyDown(this, ref Event);

        }

        private void OnKeyUp(ref SDL.SDL_Event Event)
        {

            if(KeyUp != null)
                KeyUp(this, ref Event);

        }

        private void OnLastEvent(ref SDL.SDL_Event Event)
        {

            if(LastEvent != null)
                LastEvent(this, ref Event);

        }

        private void OnMouseButtonDown(ref SDL.SDL_Event Event)
        {

            if(MouseButtonDown != null)
                MouseButtonDown(this, ref Event);

        }

        private void OnMouseButtonUp(ref SDL.SDL_Event Event)
        {

            if(MouseButtonUp != null)
                MouseButtonUp(this, ref Event);

        }

        private void OnMouseMotion(ref SDL.SDL_Event Event)
        {

            if(MouseMotion != null)
                MouseMotion(this, ref Event);

        }

        private void OnMouseWheel(ref SDL.SDL_Event Event)
        {

            if(MouseWheel != null)
                MouseWheel(this, ref Event);

        }

        private void OnMultiGesture(ref SDL.SDL_Event Event)
        {

            if(MultiGesture != null)
                MultiGesture(this, ref Event);

        }

        private void OnQuit(ref SDL.SDL_Event Event)
        {

            if(Quit != null)
                Quit(this, ref Event);

        }

        private void OnRender_Targets_Reset(ref SDL.SDL_Event Event)
        {

            if(Render_Taregets_Reset != null)
                Render_Taregets_Reset(this, ref Event);

        }

        private void OnSYSWMEvent(ref SDL.SDL_Event Event)
        {

            if(SYSWMEvent != null)
                SYSWMEvent(this, ref Event);

        }

        private void OnTextEditing(ref SDL.SDL_Event Event)
        {

            if(TextEditing != null)
                TextEditing(this, ref Event);

        }

        private void OnTextInput(ref SDL.SDL_Event Event)
        {

            if(TextInput != null)
                TextInput(this, ref Event);

        }

        private void OnUserEvent(ref SDL.SDL_Event Event)
        {

            if(UserEvent != null)
                UserEvent(this, ref Event);

        }

        private void OnWindowEvent(ref SDL.SDL_Event Event)
        {

            if(WindowEvent != null)
                WindowEvent(this, ref Event);

        }

        public void Poll(ref SDL.SDL_Event Event)
        {

            switch(Event.type)
            {

                case SDL.SDL_EventType.SDL_CLIPBOARDUPDATE:

                    OnClipBoardUpdate(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERAXISMOTION:

                    OnControllerAxisMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERBUTTONDOWN:

                    OnControllerButtonDown(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERBUTTONUP:

                    OnControllerButtonUp(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERDEVICEADDED:

                    OnControllerDeviceAdded(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERDEVICEREMAPPED:

                    OnControllerDeviceMapped(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_CONTROLLERDEVICEREMOVED:

                    OnControllerDeviceMoved(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_DOLLARGESTURE:

                    OnDollarGesture(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_DOLLARRECORD:

                    OnDollarRecord(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_DROPFILE:

                    OnDropFile(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_FINGERDOWN:

                    OnFingerDown(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_FINGERMOTION:

                    OnFingerMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_FINGERUP:

                    OnFingerUp(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_FIRSTEVENT:

                    OnFirstEvent(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYAXISMOTION:

                    OnJoyAxisMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYBALLMOTION:

                    OnJoyBallMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYBUTTONDOWN:

                    OnJoyButtonDown(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYBUTTONUP:

                    OnJoyButtonUp(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYDEVICEADDED:

                    OnJoyDeviceAdded(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYDEVICEREMOVED:

                    OnJoyDeviceRemoved(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_JOYHATMOTION:

                    OnJoyHatMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_KEYDOWN:

                    OnKeyDown(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_KEYUP:

                    OnKeyUp(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_LASTEVENT:

                    OnLastEvent(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:

                    OnMouseButtonDown(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:

                    OnMouseButtonUp(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_MOUSEMOTION:

                    OnMouseMotion(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_MOUSEWHEEL:

                    OnMouseWheel(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_MULTIGESTURE:

                    OnMultiGesture(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_QUIT:

                    OnQuit(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_RENDER_TARGETS_RESET:

                    OnRender_Targets_Reset(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_SYSWMEVENT:

                    OnSYSWMEvent(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_TEXTEDITING:

                    OnTextEditing(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_TEXTINPUT:

                    OnTextInput(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_USEREVENT:

                    OnUserEvent(ref Event);

                    break;
                case SDL.SDL_EventType.SDL_WINDOWEVENT:

                    OnWindowEvent(ref Event);

                    break;

            }

        }

    }

}
