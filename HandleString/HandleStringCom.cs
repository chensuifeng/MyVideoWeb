using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleString
{
    public class HandleStringCom
    {
        public string GetString(HandTypeEnum stype, string str)
        {

            string returnstr = string.Empty;
            switch (stype)
            {
                case HandTypeEnum.gzip:
                    returnstr = new HandGzip().GetString(str);
                    break;
            }
            return returnstr;
        }
    }
}
