using System;
using System.Windows.Forms;
using Castle.Core.Interceptor;
using Castle.DynamicProxy;

namespace Awesome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IComparable ProxyMe(ProxyGenerator generator, IInterceptor interceptor)
        {
            return generator.CreateInterfaceProxyWithoutTarget<IComparable>(interceptor);
        }
    }
}
