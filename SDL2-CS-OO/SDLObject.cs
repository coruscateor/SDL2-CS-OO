using System;

namespace SDL2_CS_OO
{
    
    public abstract class SDLObject
    {

        protected IntPtr myPtr;

        public IntPtr Ptr
        {

            get
            {

                return myPtr;

            }

        }

        protected void CheckPtr()
        {

            Util.ThrowIfPointerZero(myPtr);

        }

        public static bool operator ==(IntPtr Left, SDLObject Right)
        {

            return Left == Right.Ptr;

        }

        public static bool operator !=(IntPtr Left, SDLObject Right)
        {

            return Left != Right.Ptr;

        }

        public static bool operator ==(SDLObject Left, IntPtr Right)
        {

            return Left.Ptr == Right;

        }

        public static bool operator !=(SDLObject Left, IntPtr Right)
        {

            return Left.Ptr != Right;

        }

        public override bool Equals(object obj)
        {

            if(this == obj)
                return true;

            return base.Equals(obj);

        }

        public override int GetHashCode()
        {

            return base.GetHashCode();

        }

        public static implicit operator IntPtr(SDLObject Item)
        {

            return Item.Ptr;

        }

    }

}
