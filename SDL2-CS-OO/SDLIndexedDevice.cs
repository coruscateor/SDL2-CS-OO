using System;

namespace SDL2_CS_OO
{
    
    public abstract class SDLIndexedDevice : SDLObject
    {

        protected int myDeviceIndex = -1;

        public int DeviceIndex
        {

            get
            {

                return myDeviceIndex;

            }

        }

        public bool HasDeviceIndex
        {

            get
            {

                return myDeviceIndex > -1;

            }

        }

        protected void ThrowIfResultIsError(short Value)
        {

            if(Value == 0)
                throw new SDLErrorException((int)Value);

        }

    }

}
