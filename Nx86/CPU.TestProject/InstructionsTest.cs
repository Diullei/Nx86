namespace CPU.TestProject
{
    using System.Collections;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InstructionsTest
    {
        private static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);
        }

        [TestMethod]
        public void MOV_C6_mr_d0_d1_i0_1()
        {
            var bytes = new byte[]
                            {
                                // MOV [0fh], 04h
                                0xc6, 0x06, 0x0f, 0x00, 0x04
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV b.[000fh], 04h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var value = engine.Memory.GetValue((engine.Registers.DS.DecimalValue * 0x10) + 0x0f);
            Assert.AreEqual(0x04, value);

            Assert.AreEqual(@"MOV b.[000fh], 04h
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_C6_mr_d0_d1_i0_2()
        {
            var bytes = new byte[]
                            {
                                // MOV [0fh], 04h
                                0xc6, 0x06, 0x0f, 0x00, 0x04
                            };
            var engine = new Engine();
            engine.Registers.DS.ByteArrayValue = new byte[] { 0x07, 0x00 };
            engine.Registers.IP.ByteArrayValue = new byte[] { 0x01, 0x00 };

            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV b.[000fh], 04h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var value = engine.Memory.GetValue((engine.Registers.DS.DecimalValue * 0x10) + 0x0f);
            Assert.AreEqual(0x04, value);

            Assert.AreEqual(@"MOV b.[000fh], 04h
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_C6_mr_d0_d1_i0_3()
        {
            var bytes = new byte[]
                            {
                                // MOV [0201h], 03h
                                0xc6, 0x06, 0x01, 0x02, 0x03
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV b.[0201h], 03h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var value = engine.Memory.GetValue(0x0201);
            Assert.AreEqual(0x03, value);

            Assert.AreEqual(@"MOV b.[0201h], 03h
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_C7_mr_d0_d1_i0_i1_1()
        {
            var bytes = new byte[]
                            {
                                // MOV [0405h], 0a03h
                                0xc7, 0x06, 0x05, 0x04, 0x03, 0x0A
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV w.[0405h], 0a03h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var value1 = engine.Memory.GetValue((engine.Registers.DS.DecimalValue * 0x10) + 0x0405);
            Assert.AreEqual(0x03, value1);

            var value2 = engine.Memory.GetValue((engine.Registers.DS.DecimalValue * 0x10) + 0x0406);
            Assert.AreEqual(0x0A, value2);

            Assert.AreEqual(@"MOV w.[0405h], 0a03h
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_A0_d0_d1_1()
        {
            var bytes = new byte[]
                            {
                                // MOV [0fh], 04h
                                0xc6, 0x06, 0x0f, 0x00, 0x04, 
                                // MOV AL, [0fh]
                                0xa0, 0x0f, 0x00
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV b.[000fh], 04h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var step2 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV AL, [000fh]", step2.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            Assert.IsTrue(ByteArrayCompare(new byte[] { 0x00, 0x04 }, engine.Registers.AX.ByteArrayValue));

            Assert.AreEqual(@"MOV b.[000fh], 04h
MOV AL, [000fh]
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_A1_d0_d1_1()
        {
            var bytes = new byte[]
                            {
                                // MOV [0405h], 04h
                                0xc6, 0x06, 0x05, 0x04, 0x04, 
                                // MOV AX, [0405h]
                                0x0A1, 0x05, 0x04
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV b.[0405h], 04h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            var value = engine.Memory.GetValue(0x0405);
            Assert.AreEqual(0x04, value);

            var step2 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV AX, [0405h]", step2.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            Assert.IsTrue(ByteArrayCompare(new byte[] { 0x00, 0x04 }, engine.Registers.AX.ByteArrayValue));

            Assert.AreEqual(@"MOV b.[0405h], 04h
MOV AX, [0405h]
", engine.Instructions.ToString());
        }

        [TestMethod]
        public void MOV_B0_i0_1()
        {
            var bytes = new byte[]
                            {
                                // MOV AL, 1h
                                0xb0, 0x01 
                            };
            var engine = new Engine();
            engine.LoadBytes(bytes);

            var step1 = engine.GetCurrentInstruction();
            Assert.AreEqual("MOV AL, 01h", step1.Instruction.ToString());

            engine.ExecuteCurrentInstruction();

            Assert.IsTrue(ByteArrayCompare(new byte[] { 0x00, 0x01 }, engine.Registers.AX.ByteArrayValue));

            Assert.AreEqual(@"MOV AL, 01h
", engine.Instructions.ToString());
        }
    }
}
