namespace CPU.Console
{
    using System.Collections.Generic;

    public interface IEmulatorShell
    {
        string AL { get; set; }

        string AH { get; set; }

        string BL { get; set; }

        string BH { get; set; }

        string CL { get; set; }

        string CH { get; set; }

        string DL { get; set; }

        string DH { get; set; }

        string CS { get; set; }

        string IP { get; set; }

        string SS { get; set; }

        string SP { get; set; }

        string BP { get; set; }

        string SI { get; set; }

        string DI { get; set; }

        string DS { get; set; }

        string ES { get; set; }

        string Offset { get; set; }

        void SetCode(List<string> instructions);

        void SetCodePosition(int position);

        void ShowInfoMessage(string message);

        void SetTextboxBackColorToWhite();

        void SetTextboxFontColorToBlack();

        void SetMem(List<string> data);

        void SetFileName(string fileName);

        void SetMemRegion(long offset, int len);
    }
}