namespace CPU.Instruction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CPU.Instruction.Impl.MOV;

    public class Instructions
    {
        private readonly Registers _registers;

        private readonly Memory _memory;

        private readonly List<Type> _availableInstructions;

        private List<Step> _instructionsToExecute;

        public Instructions(Registers registers, Memory memory)
        {
            this._registers = registers;
            this._memory = memory;
            this._availableInstructions = new List<Type>();
            this._instructionsToExecute = new List<Step>();
            this.RegisterInstructions();
        }

        public List<Step> InstructionsToExecute
        {
            get
            {
                return this._instructionsToExecute;
            }
        }

        private void RegisterInstructions()
        {
            this._availableInstructions.Add(typeof(MOV_A0_d0_d1_Instruction));
            this._availableInstructions.Add(typeof(MOV_A1_d0_d1_Instruction));
            this._availableInstructions.Add(typeof(MOV_B0_i0_Instruction));
            this._availableInstructions.Add(typeof(MOV_B8_i0_i1_Instruction));
            this._availableInstructions.Add(typeof(MOV_C6_mr_d0_d1_i0_Instruction));
            this._availableInstructions.Add(typeof(MOV_C7_mr_d0_d1_i0_i1_Instruction));
        }

        public BaseInstruction GetValidInstruction(long readOffset)
        {
            var type = this._availableInstructions.FirstOrDefault(i => (bool)i.GetMethod("Accept").Invoke(null, new object[] { _memory, readOffset }));
            if (type != null)
            {
                return (BaseInstruction)Activator.CreateInstance(type, _registers, _memory);
            }

            return null;
        }

        public void LoadInstructions()
        {
            this._instructionsToExecute = new List<Step>();

            var index = 0;
            long offset = (_registers.DS.DecimalValue * 0x10) + _registers.IP.DecimalValue;
            while (offset < Memory.SIZE)
            {
                var inst = this.GetValidInstruction(offset);
                if (inst != null)
                {
                    var cache = offset;
                    inst.Set(ref offset);
                    this.InstructionsToExecute.Add(new Step(inst, cache, index++));
                }
                else
                {
                    return;
                }
            }
        }

        public Step GetNextInstruction(long currentPosition)
        {
            return this.InstructionsToExecute.FirstOrDefault(x => x.Offset == currentPosition);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            this.InstructionsToExecute.ForEach(i => sb.AppendLine(i.Instruction.ToString()));

            return sb.ToString();
        }
    }
}