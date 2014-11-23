namespace CPU
{
    using System;
    using System.Linq;

    using CPU.Instruction;

    public class Engine
    {
        public Registers Registers { get; private set; }

        public Memory Memory { get; private set; }

        public Instructions Instructions
        {
            get
            {
                return this._instructions;
            }
        }

        private Instructions _instructions;

        private byte[] _bytes;

        private int _currentInstructionSize = 0;

        private Step _currentInstruction;

        public Engine()
        {
            this.Registers = new Registers();
            this.Memory = new Memory();
        }

        public Step GetCurrentInstruction()
        {
            return _currentInstruction = this.Instructions.GetNextInstruction(Registers.CurrentPosition());
        }

        public bool ExecuteCurrentInstruction()
        {
            _currentInstruction = _currentInstruction ?? this.Instructions.GetNextInstruction(Registers.CurrentPosition());
            if (_currentInstruction != null)
            {
                _currentInstruction.Instruction.Execute();
                this._currentInstructionSize = _currentInstruction.Instruction.GetLen();
                this.Registers.MoveOffset(this._currentInstructionSize);

                if (OnChange != null)
                {
                    OnChange(this, new EventArgs());
                }

                return true;
            }

            return false;
        }

        //public Step MoveNextInstruction()
        //{
        //    var step = this.Instructions.GetNextInstruction(Registers.CurrentPosition());
        //    if (step != null)
        //    {
        //        step.Instruction.Execute();
        //        this._currentInstructionSize = step.Instruction.GetLen();
        //        this.Registers.MoveOffset(this._currentInstructionSize);

        //        if (OnChange != null)
        //        {
        //            OnChange(this, new EventArgs());
        //        }
        //    }

        //    return step;
        //}

        public void Run()
        {
            while (true)
            {
                if (!this.ExecuteCurrentInstruction())
                {
                    return;
                }
            }
        }

        public void LoadBytes(byte[] bytes)
        {
            this._bytes = bytes;
            this.Reload();
        }

        public void Reload()
        {
            this.Memory = new Memory();
            this.Registers = new Registers();

            // this.Registers.DS.ByteArrayValue = new byte[] { 0x07, 0x00 };
            // this.Registers.IP.ByteArrayValue = new byte[] { 0x01, 0x00 };

            var index = 0;
            this._bytes.ToList().ForEach(b => this.Memory.SetValue(b, (this.Registers.DS.DecimalValue * 0x10) + this.Registers.IP.DecimalValue + (index++)));
            this._instructions = new Instructions(this.Registers, this.Memory);
            this.Instructions.LoadInstructions();
        }

        public event EventHandler<EventArgs> OnChange;
    }
}