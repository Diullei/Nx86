namespace CPU
{
    public class Data16 : Data
    {
        public Data16()
            : base(false, Size.Word)
        {
            this.ByteArrayValue = new byte[] { 0x0, 0x0 };
        }
    }
}