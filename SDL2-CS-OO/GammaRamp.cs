using System;

namespace SDL2_CS_OO
{

    public struct GammaRamp
    {

        ushort[] myRed;

        ushort[] myGreen;

        ushort[] myBlue;

        public GammaRamp(ushort[] TheRed, ushort[] TheGreen, ushort[] TheBlue)
        {

            if(TheRed.Length != 256)
                throw new Exception("Invalid Length");

            myRed = TheRed;

            if(TheGreen.Length != 256)
                throw new Exception("Invalid Length");

            myGreen = TheGreen;

            if(TheBlue.Length != 256)
                throw new Exception("Invalid Length");

            myBlue = TheBlue;

        }

        public ushort[] Red
        {

            get
            {

                return myRed;

            }
            set
            {

                if(value.Length != 256)
                    throw new Exception("Invalid Length");

                myRed = value;

            }

        }

        public ushort[] Green
        {

            get
            {

                return myGreen;

            }
            set
            {

                if(value.Length != 256)
                    throw new Exception("Invalid Length");

                myGreen = value;

            }


        }

        public ushort[] Blue
        {

            get
            {

                return myBlue;

            }
            set
            {

                if(value.Length != 256)
                    throw new Exception("Invalid Length");

                myBlue = value;

            }
            
        }

    }

}
