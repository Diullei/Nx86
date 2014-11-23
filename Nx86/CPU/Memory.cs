namespace CPU
{
    using System.Collections.Generic;

    public class Memory
    {
        public static long SIZE = 0x100000;

        private readonly byte[] _data;

        public Memory()
        {
            var mem = new List<byte>();

            for (var i = 0; i < SIZE; i++)
            {
                mem.Add(0x0);
            }

            this._data = mem.ToArray();
        }

        public byte[] Data
        {
            get
            {
                return this._data;
            }
        }

        public byte GetValue(long position)
        {
            return this.Data[position];
        }

        public void SetValue(byte[] bytes, int position)
        {
            if (bytes.Length > 0)
            {
                this.Data[position] = bytes[0];
            }

            if (bytes.Length > 1)
            {
                this.Data[position + 1] = bytes[1];
            }
        }

        public void SetValue(byte bytes, long position)
        {
            this.Data[position] = bytes;
        }
    }
}