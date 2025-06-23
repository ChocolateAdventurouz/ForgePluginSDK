using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Models
{
    public class FX
    {
        public int Id { get; }
        public string FilePath { get; }
        public TimeSpan Duration { get; }


        public FX(int id, string filePath, TimeSpan duration)
        {
            Id = id;
            FilePath = filePath;
            Duration = duration;
        }
    }
}
