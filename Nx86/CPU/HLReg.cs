namespace CPU
{
    public class HLReg : Reg
    {
        public void SetH(byte h)
        {
            var aux = this.ByteArrayValue;
            this.ByteArrayValue = new byte[] { h, aux[1] };
        }

        public void SetL(byte l)
        {
            var aux = this.ByteArrayValue;
            this.ByteArrayValue = new byte[] { aux[0], l };
        }

        public byte GetH()
        {
            return this.ByteArrayValue[0];
        }

        public byte GetL()
        {
            return this.ByteArrayValue[1];
        }
    }
}