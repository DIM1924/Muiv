using System.Diagnostics;
namespace WWW
{
    public class Engine
    {
        public bool SendMesage(string message)
        {
            Debug.WriteLine("Mesage SENT");
            return true;
        }
    }
}