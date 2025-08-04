using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Data type defined to hold a pair of major and minor colors
    /// used in the 25-pair color code for telecommunications wiring
    /// </summary>
    public class ColorPair
    {
        /// <summary>
        /// Major color of the pair
        /// </summary>
        public Color majorColor { get; set; }
        
        /// <summary>
        /// Minor color of the pair
        /// </summary>
        public Color minorColor { get; set; }
        
        /// <summary>
        /// String representation of the color pair
        /// </summary>
        /// <returns>Formatted string with major and minor color names</returns>
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
