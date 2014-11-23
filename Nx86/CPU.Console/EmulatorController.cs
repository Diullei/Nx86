namespace CPU.Console
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class EmulatorController
    {
        private readonly IEmulatorShell _shell;

        private readonly Engine _cpuEngine;

        private bool _loadedFile;

        public EmulatorController(IEmulatorShell shell, Engine cpuEngine)
        {
            this._shell = shell;
            this._cpuEngine = cpuEngine;
        }

        public void OpenFile(string fileName)
        {
            var bytes = File.ReadAllBytes(fileName);
            _cpuEngine.LoadBytes(bytes);
            _shell.SetCode(_cpuEngine.Instructions.InstructionsToExecute.Select(step => step.Instruction.ToString()).ToList());
            _shell.SetMem(_cpuEngine.Memory.Data.Select((dt, i) => FormatMem(dt, i)).ToList());
            _shell.SetFileName(Path.GetFileName(fileName));
            _loadedFile = true;
            this.LoadUI();
        }

        private static string FormatMem(byte dt, long index)
        {
            return string.Format("{0}:  {1}  {2}  {3}", 
                Convert.ToString(index, 16).PadLeft(4, '0').ToUpper(),
                Convert.ToString(Data.ToInt64(new byte[] { dt }), 16).PadLeft(2, '0').ToUpper(),
                Data.ToInt64(new byte[] { dt }).ToString(CultureInfo.InvariantCulture).PadLeft(3, '0'),
                Convert.ToChar(dt).ToString(CultureInfo.InvariantCulture));
        }

        public void LoadUI()
        {
            _shell.SetTextboxBackColorToWhite();

            _shell.AH = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.AX.GetH() }), 16).PadLeft(2, '0').ToUpper();
            _shell.AL = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.AX.GetL() }), 16).PadLeft(2, '0').ToUpper();
            _shell.BH = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.BX.GetH() }), 16).PadLeft(2, '0').ToUpper();
            _shell.BL = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.BX.GetL() }), 16).PadLeft(2, '0').ToUpper();
            _shell.CH = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.CX.GetH() }), 16).PadLeft(2, '0').ToUpper();
            _shell.CL = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.CX.GetL() }), 16).PadLeft(2, '0').ToUpper();
            _shell.DH = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.DX.GetH() }), 16).PadLeft(2, '0').ToUpper();
            _shell.DL = Convert.ToString(Data.ToInt64(new byte[] { _cpuEngine.Registers.DX.GetL() }), 16).PadLeft(2, '0').ToUpper();

            _shell.CS = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.CS.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.IP = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.IP.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.SS = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.SS.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.SP = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.SP.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.BP = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.BP.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.SI = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.SI.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.DI = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.DI.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.DS = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.DS.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();
            _shell.ES = Convert.ToString(Data.ToInt64(_cpuEngine.Registers.ES.ByteArrayValue), 16).PadLeft(4, '0').ToUpper();

            _shell.Offset = string.Format("{0}:{1}", _shell.DS, _shell.IP);

            var step = _cpuEngine.GetCurrentInstruction();

            if (step != null)
            {
                _shell.SetCodePosition(step.Index);
                _shell.SetMemRegion(step.Offset, step.Instruction.GetLen());
            }
            else
            {
                _shell.SetCodePosition(_cpuEngine.Instructions.InstructionsToExecute.Count);
                _shell.ShowInfoMessage("The program has terminated");
            }
        }

        public void ExecAndGoNextStep()
        {
            if (!_loadedFile)
            {
                return;
            }

            _cpuEngine.ExecuteCurrentInstruction();
            this.LoadUI();
        }

        public void Reload()
        {
            if (!_loadedFile)
            {
                return;
            }

            _cpuEngine.Reload();
            this.LoadUI();
            _shell.SetTextboxBackColorToWhite();
            _shell.SetTextboxFontColorToBlack();
        }
    }
}