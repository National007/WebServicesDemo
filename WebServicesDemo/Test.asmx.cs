using System;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebServicesDemo
{
    ///// <summary>
    ///// TestDemo 的摘要说明
    ///// </summary>
    //[WebService(Namespace = "http://localhost:8091/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Test : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(Description = "求和方法")]
        public int Add(string a, string b)
        {
            int sum = 0;
            sum = Convert.ToInt32(a) + Convert.ToInt32(b);
            return sum;
        }

        [WebMethod(Description = "求积方法")]
        public int Sum(string a, string b)
        {
            int sum = 0;
            sum = Convert.ToInt32(a) * Convert.ToInt32(b);
            return sum;
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        [WebMethod(Description = "获取人员列表数据")]
        public List<Person> GetPersonList()
        {
            List<Person> lst = new List<Person>();
            lst.Add(new Person { id = 1, name = "小明1", age = 31 });
            lst.Add(new Person { id = 2, name = "小明2", age = 32 });
            lst.Add(new Person { id = 3, name = "小明3", age = 33 });
            lst.Add(new Person { id = 4, name = "小明4", age = 34 });

            return lst;
        }
    }

    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
