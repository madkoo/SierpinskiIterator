using System.Windows.Forms;
namespace Iteraator
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PointDrawer());
        }
    }
}
