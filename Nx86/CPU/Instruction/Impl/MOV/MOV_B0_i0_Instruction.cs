namespace CPU.Instruction.Impl.MOV
{
    /* 
     * ==================================================
     *  mnemonics	op xx xx xx xx xx	sw	len	flags
     * ==================================================
     *  MOV AL,ib	B0 i0   	        B	2	--------
     * ==================================================
     *  ib -> immediate byte
     *  i0 -> Immediate word value
     *  B  -> 8-bit operanrs
     * ==================================================
     */
    public class MOV_B0_i0_Instruction : BaseInstruction
    {
        public MOV_B0_i0_Instruction(Registers registers, Memory memory)
            : base(registers, memory)
        {
        }

        public static bool Accept(Memory memory, long readOffset)
        {
            return memory.GetValue(readOffset) == 0xB0;
        }

        public override void SetImpl(ref long readOffset)
        {
            var i0 = this._memory.GetValue(this._offset);
            this._offset++;
            this._data = new byte[] { i0 };
        }

        public override void Execute()
        {
            this._registers.AX.SetL(_data[0]);
        }

        public override int GetLen()
        {
            return 2;
        }

        public override string ToString()
        {
            return string.Format("MOV AL, {0}", this.GetBDataToString(0));
        }
    }
}