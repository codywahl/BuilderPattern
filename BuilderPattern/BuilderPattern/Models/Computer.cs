using System;
using System.Collections.Generic;

namespace BuilderPattern.Models
{
    public class Computer
    {
        public string ComputerType { get; private set; }
        public string MotherBoard { get; private set; }
        public string Cpu { get; private set; }
        public string Gpu { get; private set; }
        public int RamInGb { get; private set; }
        public int PsuWattage { get; private set; }
        public List<string> Drives { get; }

        public Computer()
        {
            Drives = new List<string>();
        }

        public Computer(string computerType, string motherBoard, string cpu, string gpu, int ramInGb, int psuWattage, List<string> drives)
        {
            ComputerType = computerType;
            MotherBoard = motherBoard;
            Cpu = cpu;
            Gpu = gpu;
            RamInGb = ramInGb;
            PsuWattage = psuWattage;
            Drives = drives;
        }

        public void SetComputerType(string computerType)
        {
            ComputerType = computerType;
        }

        public void SetMotherBoard(string motherBoard)
        {
            MotherBoard = motherBoard;
        }

        public void SetCpu(string cpu)
        {
            Cpu = cpu;
        }

        public void SetGpu(string gpu)
        {
            Gpu = gpu;
        }

        public void SetRam(int ramInGb)
        {
            RamInGb = ramInGb;
        }

        public void SetPsu(int psuWattage)
        {
            PsuWattage = psuWattage;
        }

        public void AddDrive(string drive)
        {
            Drives.Add(drive);
        }

        public void RemoveDrive(string drive)
        {
            if (Drives.Contains(drive))
                Drives.Remove(drive);
        }

        public override string ToString()
        {
            return "Computer Type: " + ComputerType + Environment.NewLine +
                   "Motherboard: " + MotherBoard + Environment.NewLine +
                   "CPU: " + Cpu + Environment.NewLine +
                   "GPU: " + Gpu + Environment.NewLine +
                   "Ram: " + RamInGb.ToString() + "GB" + Environment.NewLine +
                   "PSU: " + PsuWattage + " Watts" + Environment.NewLine +
                   "Drives: " + string.Join(",", Drives.ToArray()) + Environment.NewLine;
        }
    }
}