using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ViewFactory
{
    class ClientViewFactory : ViewFactory
    {
        public override Viewable CreateView()
        {
            return new ClientView();
        }
    }
}
