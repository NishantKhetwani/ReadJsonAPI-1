using System.Collections.Generic;

namespace ReadJsonAPI.Models
{
    public class ColorExample
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Code Code { get; set; }
    }
    public class Code
    {
        public IList<int> RGBA { get; set; }
        public string Hex { get; set; }
    }
}