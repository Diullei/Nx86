//namespace CPU
//{
//    using System;

//    public class ByteScan
//    {
//        private readonly byte[] _bytes = new byte[] { };

//        private int _index;

//        public ByteScan(byte[] bytes)
//        {
//            if (bytes.Length == 0)
//            {
//                throw new ArgumentException("bytes");
//            }

//            this._bytes = bytes;
//            this._index = 0;
//        }

//        public byte Get()
//        {
//            return this._bytes[this._index];
//        }

//        public void MoveNext()
//        {
//            if (this._index < this._bytes.Length)
//            {
//                this._index++;
//            }
//        }

//        public byte[] GetBytes()
//        {
//            return this._bytes;
//        }

//        public int GetCurrentIndex()
//        {
//            return this._index;
//        }

//        public bool EOF()
//        {
//            return this._index >= this._bytes.Length;
//        }
//    }
//}