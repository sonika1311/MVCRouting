using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;

namespace MVCRouting.Controllers
{
    public class ParamsController:Controller
    {
        public string Index1(int id)
        {
            return $"Params Controller - id : {id}";
        }
        public string Index2(int id=0)
        {
            return $"Params Controller - id : {id}";
        }
        public string Index3(int? id)
        {
            return $"Params Controller - id : {id}";
        }
        public string Index4(int x)
        {
            return $"Params Controller - x : {x}";
        }
        public string Index5(int? x)
        {
            return $"Params Controller - x : {x}";
        }
        public string Index6(string id)
        {
            return $"Params Controller - id : {id}";
        }
        public string Index7(int Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        public string Index8(int? Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        public string Index9(int Pid, string Pname, double Price)
        {
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        public string Index10()
        {
            int Pid = int.Parse(Request.QueryString["Pid"]);
            string Pname = Request.QueryString["Pname"];
            double Price = double.Parse(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        public string Validate()
        {
            string user = Request["User"];
            string pwd = Request["Pwd"];
            if (user == "admin" && pwd == "admin") return "Valid User";
            else return "Invalid user";
        }
        public string Validate2(string user, string pwd)
        {
            if(user == "admin" && pwd == "admin") return "Valid User";
            else return "Invalid user";
        }
        [ActionName("hello1")]
        public string SayHello()
        {
            return "hello, how are you";
        }
        [ActionName("hello2")]
        public string SayHello(string name)
        {
            return $"hello {name}";
        }
        [NonAction]
        public string Display()
        {
            return "Non action";
        }

    }
}