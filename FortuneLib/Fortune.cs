using FortuneLib.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FortuneLib
{
    public static class Fortune
    {
        private static List<FortuneItem> _fortuneList;
        private static List<FortuneItem> _offensiveList;

        static Fortune()
        {
            File.WriteAllBytes(Path.GetTempPath() + "fortune_normal.bin", Resources.FortuneLibResources.fortunes_normal);
            File.WriteAllBytes(Path.GetTempPath() + "fortune_offensive.bin", Resources.FortuneLibResources.fortunes_offensive);

            _fortuneList = Utils.DeserializeList<List<FortuneItem>>(Path.GetTempPath() + "fortune_normal.bin");
        }

        public static FortuneItem ParseFortune(string filename, string text, bool isOffensive)
        {
            FortuneType t;
            var b = Enum.TryParse<FortuneType>(Path.GetFileNameWithoutExtension(filename), out t);

            if (!b)
                throw new FormatException("Fortune type not found");

            return new FortuneItem
            {
                Type = t,
                FortuneText = text,
                IsOffensive = isOffensive
            };
        }
    }
}
