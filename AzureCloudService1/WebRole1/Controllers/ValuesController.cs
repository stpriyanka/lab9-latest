using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRole1.Controllers
{
	//  [Authorize]
	public class ValuesController : ApiController
	{

		[HttpPost]
		public double Add(int num1, int num2)
		{
			return num1 + num2;
		}

		[HttpPost]
		public double Divide(int a1, int a2)
		{
			return a1 / a2;
		}

		[HttpPost]
		public double Multiply(int input1, int input2)
		{
			return input1 * input2;
		}

		[HttpPost]
		public double Substruct(int userInput1, int userInput2)
		{
			return userInput1 - userInput2;
		}
	}
}
