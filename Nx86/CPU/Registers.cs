namespace CPU
{
    public class Registers
    {
        public HLReg AX { get; private set; }

        public HLReg BX { get; private set; }

        public HLReg CX { get; private set; }

        public HLReg DX { get; private set; }

        public Reg CS { get; private set; }

        public Reg IP { get; private set; }

        public Reg SS { get; private set; }

        public Reg SP { get; private set; }

        public Reg BP { get; private set; }

        public Reg SI { get; private set; }

        public Reg DI { get; private set; }

        public Reg DS { get; private set; }

        public Reg ES { get; private set; }

        public Registers()
        {
            this.AX = new HLReg();
            this.BX = new HLReg();
            this.CX = new HLReg();
            this.DX = new HLReg();

            this.CS = new Reg();
            this.IP = new Reg();

            this.SS = new Reg();
            this.SP = new Reg();
            this.BP = new Reg();

            this.SI = new Reg();
            this.DI = new Reg();
            this.DS = new Reg();

            this.ES = new Reg();
        }

        public long CurrentPosition()
        {
            return (this.DS.DecimalValue * 0x10) + this.IP.DecimalValue;
        }

        public void MoveOffset(int offset)
        {
            this.IP.DecimalValue += offset;
        }
    }
}