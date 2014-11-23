namespace CPU.Instruction.Impl.MOV
{
    /* 
     * ==================================================
     *  mnemonics	op xx xx xx xx xx	sw	len	flags
     * ==================================================
     *  MOV AL,rmb	A0 d0 d1	        B	3	--------
     * ==================================================
     *  rmb    -> register or memory byte
     *  d0, d1 -> Displacement [Low-byte High-byte]
     *  B      -> 8-bit operanrs
     * ==================================================
     */
    public class MOV_A0_d0_d1_Instruction : BaseInstruction
    {
        public MOV_A0_d0_d1_Instruction(Registers registers, Memory memory)
            : base(registers, memory)
        {
        }

        public static bool Accept(Memory memory, long readOffset)
        {
            return memory.GetValue(readOffset) == 0xA0;
        }

        public override void SetImpl(ref long readOffset)
        {
            var d0 = this._memory.GetValue(this._offset);
            this._offset++;
            var d1 = this._memory.GetValue(this._offset);
            this._offset++;
            this._data = new byte[] { d0, d1 };
        }

        public override void Execute()
        {
            this._registers.AX.SetL(this.GetBMemoryValue(this._data[0]));
        }

        public override int GetLen()
        {
            return 3;
        }

        public override string ToString()
        {
            return string.Format("MOV AL, [{0}]", this.GetWDataToString(1, 0));
        }
    }
}