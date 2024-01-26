
namespace Mobile.App.Helpers
{
    public class MessageHelper
    {
        private static MessageHelper _instance;

        public static MessageHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MessageHelper();
                }
                return _instance;
            }
        }
    }
}