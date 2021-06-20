using _61_AddressClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _98_polymorphism_Address
{
	class CompanyAddress : Address
	{
		public string Company { get; set; }
		public string Job { get; set; }

		public override void showInfo(int order)
		{
			base.showInfo(order);
			Console.WriteLine("회사 : " + this.Company);
			Console.WriteLine("업무 : " + this.Job);
		}
		public override void showInfo()
		{
			base.showInfo();
			Console.WriteLine("회사 : " + this.Company);
			Console.WriteLine("업무 : " + this.Job);
		}
	}
}
