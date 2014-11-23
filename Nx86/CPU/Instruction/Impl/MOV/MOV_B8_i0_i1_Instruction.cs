namespace CPU.Instruction.Impl.MOV
{
    /* 
     * ==================================================
     *  mnemonics	op xx xx xx xx xx	sw	len	flags
     * ==================================================
     *  MOV AX,iw	AX i0 i1	        W	3	--------
     * ==================================================
     *  iw     -> register or memory byte
     *  i0, i1 -> Immediate word value
     *  W      -> 16-bit operanrs
     * ==================================================
     */
    public class MOV_B8_i0_i1_Instruction : BaseInstruction
    {
        public MOV_B8_i0_i1_Instruction(Registers registers, Memory memory)
            : base(registers, memory)
        {
        }

        public static bool Accept(Memory memory, long readOffset)
        {
            return memory.GetValue(readOffset) == 0xB8;
        }

        public override void SetImpl(ref long readOffset)
        {
            var i0 = this._memory.GetValue(this._offset);
            this._offset++;
            var i1 = this._memory.GetValue(this._offset);
            this._offset++;
            this._data = new byte[] { i0, i1 };
        }

        public override void Execute()
        {
            this._registers.AX.ByteArrayValue = _data;
        }

        public override int GetLen()
        {
            return 3;
        }

        public override string ToString()
        {
            return string.Format("MOV AX, [{0}]", this.GetBDataToString(0));
        }
    }
}