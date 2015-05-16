using FortuneLib.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneLib
{
    public static class Utils
    {
        public static Fortune ParseFortune(string filename, string text, bool isOffensive)
        {
            FortuneType t;
            var b = Enum.TryParse<FortuneType>(Path.GetFileNameWithoutExtension(filename), out t);

            if (!b) return null;

            return new Fortune
            {
                Type = t,
                FortuneText = text,
                IsOffensive = isOffensive
            };
        }
    }
}
