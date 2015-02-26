using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SDL2;

namespace SDL2_CS_OO.TTF
{
 
    /// <summary>
    /// http://www.libsdl.org/projects/SDL_ttf/docs/SDL_ttf.html
    /// </summary>
    public static class TTFUtil
    {

        public static void Init()
        {

            Util.ThrowIfResultIsError(SDL_ttf.TTF_Init());

        }

        public static bool WasInit
        {

            get
            {

                return SDL_ttf.TTF_WasInit() == 1;

            }

        }

        public static string GetSystemFontsPath()
        {

            return Environment.GetFolderPath(Environment.SpecialFolder.Fonts);

        }

        public static bool IsSystemFont(string TTFFilePath)
        {

            return TTFFilePath.StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.Fonts)) && TTFFilePath.EndsWith(".ttf");

        }

        public static List<string> GetSystemFontsList()
        {
            
            List<string> Items = new List<string>();

            foreach(var Item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Fonts)))
            {

                Items.Add(Item);

            }

            return Items;

        }

        public static Dictionary<string, string> GetSystemFonts()
        {

            return GetAvalibleFonts(Environment.GetFolderPath(Environment.SpecialFolder.Fonts));

        }

        public static Dictionary<string, string> GetAvalibleFonts(string FontsDirectory)
        {

            Dictionary<string, string> Fonts = new Dictionary<string, string>();

            int FontLength = FontsDirectory.Length;

            int FontStartIndex = FontsDirectory.Length - 1;

            foreach(var Item in Directory.GetFiles(FontsDirectory, "*.ttf"))
            {

                Fonts.Add(Item.Substring(FontStartIndex, Item.Length - FontLength - 4), Item);

            }

            return Fonts;

        }

        public static Dictionary<string, string> GetAvalibleFonts(params string[] AdditionalPaths)
        {

            Dictionary<string, string> Fonts = new Dictionary<string, string>();

            string FontsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);

            int FLength = FontsDirectory.Length - 4;

            int FontStartIndex = FontsDirectory.Length - 1;

            foreach(var Item in Directory.GetFiles(FontsDirectory, "*.ttf"))
            {

                Fonts.Add(Item.Substring(FontStartIndex, Item.Length - FLength), Item);

            }

            foreach(var Item in AdditionalPaths)
            {

                FLength = Item.Length - 4;

                FontStartIndex = Item.Length - 1;

                foreach(var FItem in Directory.GetFiles(Item, "*.ttf"))
                {

                    Fonts.Add(Item.Substring(FontStartIndex, Item.Length - FLength), Item);

                }

            }

            return Fonts;

        }

        //Quit

        //public void SetError()
        //{

        //}

        //GetError

    }

}
