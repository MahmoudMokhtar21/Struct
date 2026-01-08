using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public struct first
    {
        // public int v;
        public int MyProperty { get; set; }
        public first(int x) { }
        public void show()
        {
            Console.WriteLine("not show");
        }
        public void end()
        {
            Console.WriteLine("not show");
        }

    }


    public struct Digitalsize
    {
        private long bit;

        public string Byte => $"{(bit/bitsinbyte):N0}Bit";
        public string KB => $"{(bit / bitsinkb):N0}KB";
        public string MB => $"{(bit / bitsinmb):N0}MB";
        public string GB => $"{(bit / bitsingb):N0}GB";
        public string TB => $"{(bit / bitsintb):N0}TB";






        private const long bitsinbits = 1;
        private const long bitsinbyte = 8;
        private const long bitsinkb = bitsinbyte * 1024;
        private const long bitsinmb = bitsinkb * 1024;
        private const long bitsingb = bitsinmb * 1024;
        private const long bitsintb = bitsingb * 1024;
        public Digitalsize(long initialvalue)
            { 
            this.bit = initialvalue;
        }
    }


}
