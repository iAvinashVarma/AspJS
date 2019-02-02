using System;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			btnImage.Attributes.Add("onmouseover", "this.src='/Images/greenButton.png'");
			btnImage.Attributes.Add("onmouseoout", "this.src='/Images/blueButton.png'");
		}
	}
}