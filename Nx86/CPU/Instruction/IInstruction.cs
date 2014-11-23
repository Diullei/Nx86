namespace CPU.Instruction
{
    public interface IInstruction
    {
        void Set(ref long readOffset);

        void Execute();

        int GetLen();
    }
}