using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public interface IPlugin
    {
        Shape Load(Form form);
    }

