using System;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			BtnImage.Attributes.Add("onmouseover", "this.src='/Images/greenButton.png'");
			BtnImage.Attributes.Add("onmouseoout", "this.src='/Images/blueButton.png'");
		}

		protected void BtnImage_Click(object sender, ImageClickEventArgs e)
		{
			Response.Write("Server side click event handled");
		}
	}
}