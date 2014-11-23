namespace CPU
{
    using System;
    using System.Collections.Generic;

    // TODO
    // [ ] - setar double com signed value
    public class Data
    {
        public enum Size
        {
            Bit, // 1
            Byte, // 8
            Word, // 16
        }

        private byte[] _value;

        public bool Signed { get; private set; }

        public Size ValueSize { get; private set; }

        public byte[] ByteArrayValue
        {
            get
            {
                return this.Value;
            }

            set
            {
                if (!ValidSize(ToInt64(value)))
                {
                    throw new OverflowException();
                }

                this.Value = value;
            }
        }

        public static long ToInt64(byte[] value)
        {
            if (value.Length < 8)
            {
                var b = new List<byte>();

                for (var i = 0; i < 8 - value.Length; i++)
                {
                    b.Add(0);
                }

                b.AddRange(value);

                b.Reverse();
                value = b.ToArray();
            }

            return BitConverter.ToInt64(value, 0);
        }

        public long DecimalValue
        {
            get
            {
                return ToInt64(this.Value);
            }

            set
            {
                if (!ValidSize(value))
                {
                    throw new OverflowException();
                }

                this.Value = BitConverter.GetBytes(value);
            }
        }

        public string HexValue
        {
            get
            {
                return Convert.ToString(ToInt64(this.Value), 16);
            }

            set
            {
                if (!ValidSize(Convert.ToInt64(value, 16)))
                {
                    throw new OverflowException();
                }

                this.Value = BitConverter.GetBytes(Convert.ToInt64(value, 16));
            }
        }

        public string BinaryValue
        {
            get
            {
                return Convert.ToString(BitConverter.ToInt64(this.Value, 0), 2);
            }

            set
            {
                if (!ValidSize(Convert.ToInt64(value, 2)))
                {
                    throw new OverflowException();
                }

                this.Value = BitConverter.GetBytes(Convert.ToInt64(value, 2));
            }
        }

        private byte[] Value
        {
            get
            {
                return this._value;
            }

            set
            {
                switch (ValueSize)
                {
                    case Size.Bit:
                    case Size.Byte:
                        _value = value;
                        break;
                    case Size.Word:
                        if (value.Length < 2)
                        {
                            if (value.Length == 0)
                            {
                                _value = new byte[] { 0, 0 };
                            }

                            if (value.Length == 1)
                            {
                                _value = new byte[] { 0, value[0] };
                            }
                        }
                        else if (value.Length == 8)
                        {
                            _value = new byte[] { value[1], value[0] };
                        }
                        else if (value.Length == 2)
                        {
                            _value = value;
                        }

                        break;
                    default:
                        this._value = value;
                        break;
                }
            }
        }

        public Data(bool signed, Size valueSize)
        {
            this.Signed = signed;
            this.ValueSize = valueSize;
        }

        private bool ValidSize(long value)
        {
            switch (ValueSize)
            {
                case Size.Bit:
                    return value <= 1;
                case Size.Byte:
                    return value <= 255;
                case Size.Word:
                    return value <= 65535;
            }

            return false;
        }
    }
}