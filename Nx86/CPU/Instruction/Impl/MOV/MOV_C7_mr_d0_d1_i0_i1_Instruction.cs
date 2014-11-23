namespace CPU.Instruction.Impl.MOV
{
    public class MOV_C7_mr_d0_d1_i0_i1_Instruction : BaseInstruction
    {
        public MOV_C7_mr_d0_d1_i0_i1_Instruction(Registers registers, Memory memory)
            : base(registers, memory)
        {
        }

        public static bool Accept(Memory memory, long readOffset)
        {
            return memory.GetValue(readOffset) == 0xC7;
        }

        public override void SetImpl(ref long readOffset)
        {
            var mr = this._memory.GetValue(this._offset);
            this._offset++;
            var d0 = this._memory.GetValue(this._offset);
            this._offset++;
            var d1 = this._memory.GetValue(this._offset);
            this._offset++;
            var i0 = this._memory.GetValue(this._offset);
            this._offset++;
            var i1 = this._memory.GetValue(this._offset);
            this._offset++;
            this._data = new byte[] { mr, d0, d1, i0, i1 };
        }

        public override void Execute()
        {
            this.SetWMemoryValue(this._data[4], this._data[3], this._data[2], this._data[1]);
        }

        public override int GetLen()
        {
            return 6;
        }

        public override string ToString()
        {
            return string.Format("MOV w.[{0}], {1}", this.GetWDataToString(2, 1), this.GetWDataToString(4, 3));
        }
    }
}