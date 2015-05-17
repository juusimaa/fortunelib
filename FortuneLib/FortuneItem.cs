using System;

namespace FortuneLib
{
    /// <summary>
    /// Class for Fortune cookie.
    /// </summary>
    [Serializable]
    public class FortuneItem
    {
        /// <summary>
        /// Fortune cookie text.
        /// </summary>
        public string FortuneText { get; set; }

        /// <summary>
        /// Fortune cookie type.
        /// </summary>
        public FortuneLib.Enums.FortuneType Type { get; set; }
        
        /// <summary>
        /// Fortune cookie lenght.
        /// </summary>
        public int Lenght 
        {
            get { return FortuneText.Length; }
        }
        
        /// <summary>
        /// Is fortune offensive.
        /// </summary>
        public bool IsOffensive { get; set; }

        /// <summary>
        /// Format fortune to string.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ToString(int index = 0)
        {
            if (Type == Enums.FortuneType.bofh)
            {
                return "BOFH Excuse #" + index + ": " + FortuneText;
            }

            return FortuneText;
        }
    }
}
