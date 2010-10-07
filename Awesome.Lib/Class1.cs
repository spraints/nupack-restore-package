using log4net;

namespace Awesome.Lib
{
    public class Class1
    {
        public static void Blah(ILog logger)
        {
            logger.Warn("Blah!");
        }
    }
}
