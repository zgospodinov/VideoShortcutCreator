using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoShortcutCreator.Api.Enums
{
    public enum VideoFormats
    {
        mkv,
        webm,
        flv,
        vob,
        ogg,
        ogv,
        avi,
        wmv,
        mp4,
        m4p,
        m4v,
        mpg,
        mpeg,
    }


    public static class Enum<T> where T : struct, IConvertible
    {
        public static List<string> Values
        {
            get
            {
                if (!typeof(T).IsEnum)
                    throw new ArgumentException("T must be an enumerated type");

                return Enum.GetNames(typeof(T)).ToList();
            }
        }
    }
}
