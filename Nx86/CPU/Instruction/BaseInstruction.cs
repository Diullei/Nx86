namespace CPU.Instruction
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class BaseInstruction : IInstruction
    {
        protected readonly Registers _registers;

        protected readonly Memory _memory;

        protected byte[] _data;

        protected long _offset;

        protected BaseInstruction(Registers registers, Memory memory)
        {
            this._registers = registers;
            this._memory = memory;
        }

        private string NormalizeHex(string hex, int size)
        {
            if (hex.Length < size)
            {
                hex = hex.PadLeft(size, '0');
            }

            if (Regex.IsMatch(hex, "^[a-fA-F]"))
            {
                hex = "0" + hex;
            }

            return hex + "h";
        }

        protected void SetMemoryValue(byte value, byte position)
        {
            this._memory.SetValue(value, (_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position }));
        }

        protected void SetBMemoryValue(byte value, byte position1, byte position2)
        {
            this._memory.SetValue(value, (_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position1, position2 }));
        }

        protected void SetWMemoryValue(byte value1, byte value2, byte position1, byte position2)
        {
            var offset = (_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position1, position2 });
            this._memory.SetValue(value2, offset);
            this._memory.SetValue(value1, offset + 1);
        }

        protected byte GetBMemoryValue(byte position)
        {
            return this._memory.GetValue((_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position }));
        }

        protected byte GetMemoryValue(byte position1, byte position2)
        {
            return this._memory.GetValue((_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position1, position2 }));
        }

        protected byte[] GetWMemoryValue(byte position1, byte position2)
        {
            var offset = (_registers.DS.DecimalValue * 0x10) + Data.ToInt64(new byte[] { position1, position2 });
            return new byte[]
                       {
                           this._memory.GetValue(offset - 1),
                           this._memory.GetValue(offset)
                       };
        }

        protected string GetBDataToString(int index)
        {
            return this._data.Length > index
                       ? NormalizeHex(Convert.ToString(Data.ToInt64(new byte[] { this._data[index] }), 16), 2)
                       : "!?";
        }

        protected string GetWDataToString(int index1, int index2)
        {
            return this._data.Length > index1 && this._data.Length > index2
                       ? NormalizeHex(Convert.ToString(Data.ToInt64(new byte[] { this._data[index1], this._data[index2] }), 16), 4)
                       : "!?";
        }

        public abstract void SetImpl(ref long readOffset);

        public void Set(ref long readOffset)
        {
            if ((bool)this.GetType().GetMethod("Accept").Invoke(null, new object[] { this._memory, readOffset }))
            {
                this._offset = readOffset;
                this._offset++;

                this.SetImpl(ref readOffset);

                readOffset = this._offset;
            }
        }

        public abstract void Execute();

        public abstract int GetLen();
    }
}