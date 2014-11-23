namespace CPU.Instruction
{
    public class Step
    {
        public BaseInstruction Instruction { get; set; }

        public long Offset { get; set; }

        public int Index { get; set; }

        public Step(BaseInstruction instruction, long offset, int index)
        {
            this.Instruction = instruction;
            this.Offset = offset;
            this.Index = index;
        }
    }
}