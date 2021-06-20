using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.Json;


namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/json";
            string algorithms = Request.QueryString["algorithms"];
            string v1, v2;
            v1 = Request.QueryString["v1"];
            v2=  Request.QueryString["v2"];

            var a_1 = new Result();

            switch (algorithms)
            {
                case "fib":
                   
                 
                    if (!string.IsNullOrEmpty(v1) && v1.All(Char.IsDigit))
                    {

                        int result = process.Fibonacci(int.Parse(v1));
                        a_1 = new Result
                        {                           
                             message="Fibonacci Dizisinin "+ v1 + ". Elemani  /"+ v1 + ". element of the Fibonacci sequence ",
                             result = result.ToString(),
                        };
                    }
                    else
                    {
                        a_1 = new Result
                        {
                            message = "Değer Sayı Olmak Zorundadır./ Value must be numeric",
                        };
                    }               
                                  
                   
                    break;


                case "ack":
                    if (!string.IsNullOrEmpty(v1) && v1.All(Char.IsDigit)&& !string.IsNullOrEmpty(v2) && v2.All(Char.IsDigit))
                    {

                        int result = process.Ackermann(int.Parse(v1),int.Parse(v2));
                        a_1 = new Result
                        {
                            message = "Sonuç // Result",
                            result = result.ToString(),
                        };
                    }
                    else
                    {
                        a_1 = new Result
                        {
                            message = "Değer Sayı Olmak Zorundadır./ Value must be numeric",
                        };
                    }

                    break;

                   

                case "fact":                  

                    if (!string.IsNullOrEmpty(v1) && v1.All(Char.IsDigit))
                    {

                        int result = process.Factorial(int.Parse(v1));
                        a_1 = new Result
                        {

                            message =  v1 + "! Faktöriyel  /" + v1 + "! factorial value",
                            result = result.ToString(),

                        };
                    }
                    else
                    {
                        a_1 = new Result
                        {
                            message = "Değer Sayı Olmak Zorundadır./ Value must be numeric",

                        };
                    }                   

                    break;
                default:
                    Response.Write("geçersiz işlem//4004found");
                    break;
                
            }
            string jsonString = JsonSerializer.Serialize(a_1);
            Response.Write(jsonString);
            Response.End();

        }
    }
}