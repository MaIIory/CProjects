using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ViewFactory
{
    abstract class ViewFactory
    {
        abstract public Viewable CreateView();
    }
}
