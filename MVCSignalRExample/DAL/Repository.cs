using MVCSignalRExample.Models;

namespace MVCSignalRExample.DAL
{
    //this is just a simulation for data source
    public class Repository
    {
        static Foo data = new Foo();
        public Foo GetData()
        {
            return data;
        }
        public void UpdateData(Foo foo)
        {
            data = foo;
            RefreshHub.Refresh();
        }
    }
}