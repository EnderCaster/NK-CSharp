using DotRas;
using System;
using System.Linq;

namespace NK_CSharp
{
    class User
    {
        private string un;
        private string pw;
        private RasDialer dialer = new RasDialer();
        const char PREFIX0 = '\r';
        const char PREFIX1 = '\n';
        const string RADIUS = "hebeicncxinli002";

        public RasDialer Dialer
        {
            get
            {
                return dialer;
            }

            set
            {
                dialer = value;
            }
        }

        public User()
        {
        }
        public User(string Username, string Password)
        {
            un = Username;
            pw = Password;
        }
        public void CreateConnect(string ConnectName)
        {
            RasDialer dialer = new RasDialer();
            try { 
                
                    System.Collections.ObjectModel.ReadOnlyCollection<RasDevice> readOnlyCollection = RasDevice.GetDevices();
                    RasDevice device = RasDevice.GetDevices().Where(o => o.DeviceType == RasDeviceType.PPPoE).First();
                    RasEntry entry = RasEntry.CreateBroadbandEntry(ConnectName, device);
                    entry.PhoneNumber = " ";
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("创建PPPoE连接失败");
            }
        }
        private string calcRealUser()
        {
            string realUN = "";
            return realUN;
        }
        public bool dial()
        {
            string realUN = calcRealUser();
            string realPW = this.pw;
            
            bool isDialSuccess = false;
            try
            {
                return isDialSuccess;
            }catch(Exception e)
            {
                return false;
            }
        }
    }
}
