using Microsoft.AspNetCore.Connections;

namespace Address.General
{
    public class GeneralResult
    {

        public object Data { get; set; }

        public List<string> ErrorList { get; set; }

        public bool Ok { get; set; }

        public GeneralResult()
        {
            Ok = true;
            ErrorList = new List<string>();
        }

        public void AddError(string pException)
        {
            Ok = false;
            ErrorList.Add(pException);
        }
    }
}
