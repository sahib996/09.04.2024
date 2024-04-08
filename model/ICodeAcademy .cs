using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04._2024.model
{
    internal interface ICodeAcademy
    {
        string CodeEmail { get; set; }
        void GenerateEmail();
    }
}
