using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EndPointBuilder
    {
        public StringBuilder sbUrl { get; set; } = new();
        public StringBuilder sbParams { get; set; } = new();

        public const char Delimiter = '/'; 
        public string BaseUrl { get; set; }
        public EndPointBuilder(string baseurl)
        {
            BaseUrl= baseurl;
        }

        public EndPointBuilder Append(string value)
        {
            sbUrl.Append(value);
            sbUrl.Append(Delimiter);
            return this;
        }

        public EndPointBuilder AppendParams(string name,string value)
        {
            sbParams.AppendFormat("{0}={1}&",name,value);
            return this;
        }

        public string Build()
        {
            if(BaseUrl.EndsWith(Delimiter))
                sbUrl.Insert(0,BaseUrl);
            else
                sbUrl.Insert(0,BaseUrl+Delimiter);

            var url= sbUrl.ToString().TrimEnd('&');

            if(sbParams.Length > 0)
            {
                string qParams = sbParams.ToString().TrimEnd('&');
                url = sbUrl.ToString().TrimEnd(Delimiter).TrimEnd('?');

                url = $"{sbUrl}?{qParams}";
            }

            return url.TrimEnd(Delimiter);
        }
    }
}
