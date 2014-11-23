namespace CPU.Instruction.Impl.MOV
{
    /* 
     * =====================================================
     *  mnemonics	op xx xx xx xx xx	sw	len	flags
     * =====================================================
     *  MOV rmb,ib	C6 mr d0 d1 i0	    B	3~5	--------
     * =====================================================
     *  mr     -> Addressing mode Byte = MODRM(mod-reg-r/m)
     *  d0, d1 -> Displacement [Low-byte High-byte]
     *  i0     -> Immediate word value
     *  B      -> 8-bit operanrs
     * =====================================================
     */
    public class MOV_C6_mr_d0_d1_i0_Instruction : BaseInstruction
    {
        public MOV_C6_mr_d0_d1_i0_Instruction(Registers registers, Memory memory)
            : base(registers, memory)
        {
        }

        public static bool Accept(Memory memory, long readOffset)
        {
            return memory.GetValue(readOffset) == 0xC6; 
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
            this._data = new byte[] { mr, d0, d1, i0 };
        }

        public override void Execute()
        {
            this.SetBMemoryValue(this._data[3], this._data[2], this._data[1]);
        }

        public override int GetLen()
        {
            return 5;
        }

        public override string ToString()
        {
            return string.Format("MOV b.[{0}], {1}", this.GetWDataToString(2, 1), this.GetBDataToString(3));
        }
    }
}